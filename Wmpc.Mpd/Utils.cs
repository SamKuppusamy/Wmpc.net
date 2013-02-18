using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public static class Utils {

        public static bool ParseBool(string b) {
            return (b != "0");
        }

        public static string BoolToString(bool b) {
            if (b) {
                return "1";
            } else {
                return "0";
            }
        }


    }
}
