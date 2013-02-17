using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class Track {

        public int Num { get; set; }
        public int Pos { get; set; }
        public int Id { get; set; }
        public string File { get; set; }
        public int Time { get; set; }
        public Dictionary<string, string> Tags { get; set; }

        public Track(List<KeyValuePair<string, string>> values) {
            this.Tags = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> pair in values) {
                switch (pair.Key.ToLower()) {
                    case "id": 
                        this.Id = int.Parse(pair.Value); 
                        break;
                    case "pos":
                        this.Pos = int.Parse(pair.Value);
                        break;
                    case "track":
                        this.Num = int.Parse(pair.Value);
                        break;
                    case "file":
                        this.File = pair.Value;
                        break;
                    case "time":
                        this.Time = int.Parse(pair.Value);
                        break;
                    default:
                        this.Tags.Add(pair.Key, pair.Value);
                        break;
                }
            }
        }

    }
}
