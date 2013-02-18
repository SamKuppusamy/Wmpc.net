using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class Track : ResponseEntity {

        public string File { get; set; }
        public Dictionary<string, string> Tags { get; set; }

        public Track(Response response)
            : base(response) {
            this.Tags = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> pair in response.Values) {
                this.Tags.Add(pair.Key, pair.Value);
            }
        }

    }
}
