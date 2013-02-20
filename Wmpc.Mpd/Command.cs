using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class Command {

        public string Cmd { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }

        public Command(string command) {
            this.Cmd = command;
        }

        public Command(string command, string param1)
            : this(command) {
            this.Param1 = param1;
        }

        public Command(string command, int param1)
            : this(command) {
            this.Param1 = param1.ToString();
        }

        public Command(string command, bool param1)
            : this(command) {
                this.Param1 = Utils.BoolToString(param1);
        }

        public Command(string command, string param1, string param2)
            : this(command, param1) {
            this.Param2 = param2;
        }

        public Command(string command, int param1, string param2)
            : this(command, param1) {
            this.Param2 = param2;
        }

        public Command(string command, bool param1, string param2)
            : this(command, param1) {
            this.Param2 = param2;
        }

        public Command(string command, string param1, int param2)
            : this(command, param1) {
            this.Param2 = param2.ToString();
        }

        public Command(string command, int param1, int param2)
            : this(command, param1) {
            this.Param2 = param2.ToString();
        }

        public Command(string command, bool param1, int param2)
            : this(command, param1) {
            this.Param2 = param2.ToString();
        }

        public Command(string command, string param1, bool param2)
            : this(command, param1) {
            this.Param2 = Utils.BoolToString(param2);
        }

        public Command(string command, int param1, bool param2)
            : this(command, param1) {
            this.Param2 = Utils.BoolToString(param2);
        }

        public Command(string command, bool param1, bool param2)
            : this(command, param1) {
            this.Param2 = Utils.BoolToString(param2);
        }

        public bool QuoteParam1 { get; set; }
        public bool QuoteParam2 { get; set; }

        public override string ToString() {
            string command = this.Cmd;
            if (this.Param1 != null) {
                if (this.QuoteParam1) {
                    command += " \"" + this.Param1 + "\"";
                } else {
                    command += " " + this.Param1;
                }
            }
            if (this.Param2 != null) {
                if (this.QuoteParam2) {
                    command += " \"" + this.Param2 + "\"";
                } else {
                    command += " " + this.Param2;
                }
            }
            command += "\n";
            return command;
        }

    }
}
