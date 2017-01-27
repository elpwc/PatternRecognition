using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PatternRecognition {
    class Client {
        private MainForm form;
        private Boolean connect;

        public Client(MainForm form) {
            this.form = form;
            this.connect = true;
        }

        public void Run() {
            IPAddress address = IPAddress.Parse("169.254.0.100");
            int port = 80;

            for (int i = 0; connect && i < 10; i++) {
                try {
                    TcpClient client = new TcpClient();
                    client.Connect(address, port);
                    //Console.Out.WriteLine("Konektovan na server!");
                    TextReader reader = new StreamReader(new BufferedStream(client.GetStream()));
                    TextWriter writer = new StreamWriter(new BufferedStream(client.GetStream())) {AutoFlush = true};

                    writer.WriteLine("GET /R");
                    while (connect) {
                        String response = reader.ReadLine();
                        //Console.Out.WriteLine(response);
                        if (response.Contains("OK")) {
                            form.StartDetection = true;
                            connect = false;
                        }
                    }
                    client.Close();
                } catch (Exception e) {
                    Console.Out.WriteLine(e.StackTrace);
                }
            }
        }
    }
}