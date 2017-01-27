using System;
using System.IO.Ports;

namespace PatternRecognition {
    class RS232Communication {
        private SerialPort port;
        private byte[,] shape;


        public RS232Communication(byte[,] shape) {
            port = new SerialPort("COM6", 9600);
            port.StopBits = StopBits.One;
            port.Parity = Parity.None;
            port.Open();
            this.shape = shape;
        }

        public void Run() {
            for (int i = 4; i >= 0; i--) {
                byte[] be = { 0, 0 };
                port.Write(be, 0, 1);
                Console.Out.Write(be[0] + " ");
                port.Write(be, 1, 1);
                Console.Out.Write(be[1] + " ");
                for (int j = 0; j < 5; j++) {
                    byte[] b = {shape[i, j]};
                    port.Write(b, 0, 1);
                    Console.Out.Write(b[0] + " ");
                }
                Console.Out.WriteLine("");
            }
            port.Close();
        }
    }
}