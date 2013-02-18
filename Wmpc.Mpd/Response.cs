using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class Response {

        protected bool ok = false;

        public bool OK {
            get {
                return this.ok;
            }
        }

        protected string[] header;

        public string[] Header {
            get {
                return this.header;
            }
        }

        protected string responseString;

        public string ResponseString {
            get {
                return this.responseString;
            }
        }

        protected List<KeyValuePair<string, string>> values;

        public List<KeyValuePair<string, string>> Values {
            get {
                return this.values;
            }
        }

        //public Response() { }

        public Response(string str) {
            this.responseString = str;
            this.Parse();
        }

        private void Parse() {
            string[] lines = this.responseString.Split('\n');
            this.values = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < lines.Length - 1; i++) {
               
                if (lines[i].Trim() == "OK") {
                    break;
                }

                string[] arr = lines[i].Split(' ');

                if (i == 0 && lines[i].StartsWith("OK")) {
                    this.header = arr;
                    continue;
                }

                if (lines[i].StartsWith("ACK")){
                    arr = lines[i].Split(' ');
                    string msg = string.Empty;
                    for (int j = 3; j < arr.Length; j++) {
                        msg += arr[j] + " ";
                    }
                    throw new MpdException(msg, arr);
                }

                arr = lines[i].Split(':');
                string key = arr[0].Trim();
                string value = arr[1].Trim();
               
                this.values.Add(new KeyValuePair<string, string>(key, value));
            }

            this.ok = true;

        }

        public void Parse(string str) {
            this.responseString = str;
            this.Parse();
        }

    }
}
