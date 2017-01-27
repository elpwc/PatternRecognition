using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternRecognition {
    public partial class MyCheckBox : CheckBox {
        public MyCheckBox() {
            this.Appearance = System.Windows.Forms.Appearance.Button;
            this.BackColor = Color.Transparent;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.CornflowerBlue;
            this.FlatAppearance.BorderSize = 2;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            Padding = new Padding(6);
        }

        protected override void OnPaint(PaintEventArgs e) {
            this.OnPaintBackground(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = new GraphicsPath()) {
                var d = Padding.All;
                var r = this.Height - 2*d;
                path.AddArc(d, d, r, r, 90, 180);
                path.AddArc(this.Width - r - d, d, r, r, -90, 180);
                path.CloseFigure();
                e.Graphics.FillPath(Checked ? Brushes.DarkGray : Brushes.LightGray, path);
                r = Height - 1;
                var rect = Checked ? new Rectangle(Width - r - 1, 0, r, r) : new Rectangle(0, 0, r, r);
                e.Graphics.FillEllipse(Checked ? Brushes.CornflowerBlue : Brushes.DarkGray, rect);
            }
        }
    }
}