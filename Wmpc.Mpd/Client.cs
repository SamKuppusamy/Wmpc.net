using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Wmpc.Mpd {

    public class Client {

        private TcpClient tcpClient;
        
#region "properties"

        private StatusProvider statusProvider;

        public StatusProvider StatusProvider {
            get {
                return this.statusProvider;
            }
        }

        private PlaybackProvider playbackProvider;

        public PlaybackProvider PlaybackProvider {
            get {
                return this.playbackProvider;
            }
        }


        private string server;

        public string Server {
            get {
                return this.server;
            }
        }

        private int port;

        public int Port {
            get {
                return this.port;
            }
        }

        private string version;

        public string Version {
            get {
                return this.version;
            }
        }

#endregion

        public Client(string server, int port){
            this.tcpClient = new TcpClient(server, port);
            this.server = server;
            this.port = port;

            this.statusProvider = new StatusProvider(this);
            this.playbackProvider = new PlaybackProvider(this);
        }

        public string Send(string command) {
            if (!command.EndsWith("\n")) command += (char)10;

            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] data = utf8.GetBytes(command);
            NetworkStream stream = this.tcpClient.GetStream();
            stream.Write(data, 0, data.Length);
            data = new byte[256];
            String response = String.Empty;
            while (true) {
                int bytes = stream.Read(data, 0, data.Length);
                string str = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                response += str;
                if (str.EndsWith("OK\n") || str.Contains("ACK ")) {
                    break;
                }
            }
            return response;
        }

        public Response SendCommand(Command  command) {
            return this.SendCommand(command.ToString());
        }

        public Response SendCommand(string command) {
            string data = this.Send(command);
            Response r = new Response(data);
            if (r.Header != null) {
                this.version = r.Header[2];
            }
            return r;
        }


    }

}