using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class MpdException : Exception {

        string error;
        int commandListNum;
        string command;

        public MpdException(string message, string[] data)
            : base(message) {
            this.error = data[1];
            this.command = data[2];
        }

    }
}
