using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord;
using Accord.Imaging;
using Accord.Imaging.Filters;
using Accord.Math.Geometry;
using Accord.Video.DirectShow;

namespace PatternRecognition {
    public partial class MainForm : Form {
        private FilterInfoCollection deviceInfo;
        private VideoCaptureDevice camera;
        private List<byte[,]> oldPatterns;

        private Boolean startDetection = false;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(Object sender, EventArgs e) {
            oldPatterns = new List<byte[,]>();

            deviceInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in deviceInfo)
                deviceListComboBox.Items.Add(device.Name);

            deviceListComboBox.SelectedIndex = (deviceInfo.Count != 0) ? deviceInfo.Count - 1 : 0;

            videoSourcePlayer.NewFrame += VideoSourcePlayerOnNewFrame;
            CreateFilters();
        }

        private void InitializeCamera() {
            String moniker = deviceInfo[deviceListComboBox.SelectedIndex].MonikerString;
            camera = new VideoCaptureDevice(moniker);
            videoSourcePlayer.VideoSource = camera;
            videoSourcePlayer.Start();
        }

        private void VideoSourcePlayerOnNewFrame(object sender, ref Bitmap image) {
            if (startDetection)
                PatternRecognition(image);
        }

        private void startVideoButton_Click(Object sender, EventArgs e) {
            InitializeCamera();
            ResetPattern();
            // komunikacija sa mikrokontrolerom
            // new Thread(new Client(this).Run).Start();
            detected = false;
            startVideoButton.Enabled = false;
        }

        private void stopVideoButton_Click(Object sender, EventArgs e) {
            if (videoSourcePlayer.IsRunning) {
                videoSourcePlayer.SignalToStop();
            }
            startVideoButton.Enabled = true;
        }

        private Grayscale grayscaleFilter;
        private SobelEdgeDetector sobelFilter;
        private Dilatation3x3 dilitationFilter;
        private Threshold thresholdFilter;
        private BlobCounter blobCounter;
        private SimpleShapeChecker shapeChecker;
        private SquareBinaryGlyphRecognizer binaryGlyphRecognizer;
        private Invert invertFilter;
        private RotateBilinear rotateFilter;
        private Mirror mirrorFilter;
        private Pen pen;
        private GrahamConvexHull hullFinder;
        private OtsuThreshold otsuThresholdFilter;

        public void CreateFilters() {
            grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            sobelFilter = new SobelEdgeDetector();
            dilitationFilter = new Dilatation3x3();
            thresholdFilter = new Threshold(100);
            blobCounter = new BlobCounter {MinHeight = 200, MinWidth = 200, FilterBlobs = true, ObjectsOrder = ObjectsOrder.Size};
            shapeChecker = new SimpleShapeChecker();
            binaryGlyphRecognizer = new SquareBinaryGlyphRecognizer(5); // 5x5 matrica
            invertFilter = new Invert();
            rotateFilter = new RotateBilinear(90);
            pen = new Pen(Color.CornflowerBlue, 4);
            mirrorFilter = new Mirror(false, true);
            hullFinder = new GrahamConvexHull();
            otsuThresholdFilter = new OtsuThreshold();
        }

        private Boolean detected = false;

        private void PatternRecognition(Bitmap bitmap) {
            // Prvi korak - grayscalling originalne slike
            Bitmap frame = grayscaleFilter.Apply(bitmap);

            BitmapData frameData = frame.LockBits(new Rectangle(0, 0, frame.Width, frame.Height), ImageLockMode.ReadWrite, frame.PixelFormat);

            // Drugi korak - detekcija ivica pomocu Sobel filtra
            sobelFilter.ApplyInPlace(frameData);

            // Treći korak - konvertuj sliku u crno-bijelu pri čemu je threshold = 100 odnoso od 0 do 155 je crna boja, a od 156 do 255 je bijela boja
            thresholdFilter.ApplyInPlace(frameData);

            // Četvrti korak - dilitacija / pojacavanje bijele boje jer
            dilitationFilter.ApplyInPlace(frameData);

            // Peti korak - kreiranje binarne slike
            frame = frame.Clone(new Rectangle(0, 0, frame.Width, frame.Height), PixelFormat.Format8bppIndexed);

            // Šesti korak - pronalazak potencijalnih oblika na slici
            blobCounter.ProcessImage(frameData);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            // za crtanje po originalnoj slici
            Graphics g = Graphics.FromImage(bitmap);

            // Sedmi korak - provjeri svaki oblik
            foreach (Blob blob in blobs) {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blob);
                List<IntPoint> hullPoints = hullFinder.FindHull(edgePoints);
                List<IntPoint> corners = null;

                // da li je četverougao?
                if (shapeChecker.IsQuadrilateral(hullPoints, out corners))
                    // da li je kvadrat?
                    if (shapeChecker.CheckPolygonSubType(corners) == PolygonSubType.Square) {
                        if (!detected) {
                            // Osmi korak - odrđivanje centra gravitacije i gornjeg lijevog tjemena
                            FindNewCorners(corners);

                            // Deveti korak - ekstrakcija prepoznatog kvadrata sa originalne slike u novu sliku dimenzija 100x100
                            SimpleQuadrilateralTransformation quadrilateralTransformation = new SimpleQuadrilateralTransformation(corners, 100, 100);
                            Bitmap recognizedSquare = quadrilateralTransformation.Apply(bitmap);
                            recognizedSquare = recognizedSquare.Clone(new Rectangle(0, 0, recognizedSquare.Width, recognizedSquare.Height), PixelFormat.Format8bppIndexed);

                            // Deseti korak - od nove slike ponovo napravi crno-bijelu
                            otsuThresholdFilter.ApplyInPlace(recognizedSquare);

                            // Jedanaesti korak - invertuj boje
                            invertFilter.ApplyInPlace(recognizedSquare);

                            //Dvanaesti korak - prepoznaj oblik (formiraj matricu)
                            float confidence; // vjerovatnoća da je prepoznat pravi oblik (odnos borja crnih i bijelih piksela u ćeliji
                            byte[,] pattern = binaryGlyphRecognizer.Recognize(recognizedSquare, new Rectangle(0, 0, recognizedSquare.Width, recognizedSquare.Height), out confidence);
                            recognizedSquare.Dispose();

                            if (confidence >= 0.6) {
                                oldPatterns.Add(pattern);
                                Boolean canDraw = CheckPrevious();
                                if (canDraw) {
                                    // Trinaesti korak - iscrtaj matricu
                                    DrawPattern(pattern);
                                    detected = true;

                                    // pravim delay od 3s nakon što prepozna pattern
                                    new Task(() => {
                                        Thread.Sleep(3*1000);
                                        detected = false;
                                    }).Start();

                                    // Komunikacija sa warehouse uređajem.
                                    //new Thread(new RS232Communication(shape).Run).Start();
                                }
                            }
                        }
                        // iscrtaj ivice oko prepoznatog kvadrata
                        g.DrawPolygon(pen, ToPointsArray(hullPoints));
                    }
            }

            g.Dispose();
            frame.UnlockBits(frameData);
            frame.Dispose();
        }

        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points) {
            return points.Select(p => new System.Drawing.Point(p.X, p.Y)).ToArray();
        }

        private void FindNewCorners(List<IntPoint> corners) {
            // Centar gravitacije unutar kvadrata
            Accord.Point g = PointsCloud.GetCenterOfGravity(corners);
            // Pošto se radi o kvadratu to je 
            IntPoint p1 = corners[0], p2 = corners[1], p3 = corners[2], p4 = corners[3];
            // gdje je: p1 - top left, p2 - top right, p3 - bottom right, p4 - bottom left

            foreach (IntPoint p in corners) {
                if (p.X <= g.X && p.Y >= g.Y)
                    p1 = p;
                else if (p.X >= g.X && p.Y >= g.Y)
                    p2 = p;
                else if (p.X >= g.X && p.Y <= g.Y)
                    p3 = p;
                else if (p.X <= g.X && p.Y <= g.Y)
                    p4 = p;
            }

            corners[0] = p4;
            corners[1] = p3;
            corners[2] = p2;
            corners[3] = p1;
        }

        private void DrawPattern(byte[,] pattern) {
            if (InvokeRequired) {
                Invoke(new MethodInvoker(() => { DrawPattern(pattern); }));
                return;
            }

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (pattern[i, j] != 0)
                        table.GetControlFromPosition(j, i).BackColor = Color.CornflowerBlue;
                    else
                        table.GetControlFromPosition(j, i).BackColor = this.BackColor;
        }

        private void ResetPattern() {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    table.GetControlFromPosition(j, i).BackColor = this.BackColor;
        }

        private int numOfSamePatterns = 5;

        private Boolean CheckPrevious() {
            if (oldPatterns.Count < 2)
                return false;

            int n = oldPatterns.Count - 1;
            int m = (n < numOfSamePatterns) ? n : numOfSamePatterns;

            for (int k = 1; k < m; k++) {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        // kako bi se osigurao od naglih
                        if (oldPatterns[n][i, j] != oldPatterns[n - k][i, j])
                            return false;
            }

            return true;
        }

        public bool StartDetection {
            get { return startDetection; }
            set { startDetection = value; }
        }

        private void myCheckBox_CheckedChanged(Object sender, EventArgs e) {
            startDetection = myCheckBox.Checked;
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e) {
            if (videoSourcePlayer.IsRunning)
                videoSourcePlayer.Stop();
        }
    }
}