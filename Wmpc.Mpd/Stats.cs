using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class Stats : ResponseEntity {

        const string MPD_STAT_ARTISTS = "artists";
        const string MPD_STAT_SONGS = "songs";
        const string MPD_STAT_UPTIME = "uptime";
        const string MPD_STAT_DB_PLAYTIME = "db_playtime";
        const string MPD_STAT_DB_UPDATE = "db_update";
        const string MPD_STAT_PLAYTIME = "playtime";

        public int Artists { get; set; }
        public int Songs { get; set; }
        public int Uptime { get; set; }
        public int DbPlaytime { get; set; }
        public int DbUpdate { get; set; }
        public int Playtime { get; set; }

        public Stats(Response response)
            : base(response) {
           
            foreach (KeyValuePair<string, string> pair in response.Values) {
                switch (pair.Key) {
                    case MPD_STAT_ARTISTS:
                        this.Artists = int.Parse(pair.Value);
                        break;
                    case MPD_STAT_SONGS:
                        this.Songs = int.Parse(pair.Value);
                        break;
                    case MPD_STAT_UPTIME:
                        this.Uptime = int.Parse(pair.Value);
                        break;
                    case MPD_STAT_DB_PLAYTIME:
                        this.DbPlaytime = int.Parse(pair.Value);
                        break;
                    case MPD_STAT_DB_UPDATE:
                        this.DbUpdate = int.Parse(pair.Value);
                        break;
                    case MPD_STAT_PLAYTIME:
                        this.Playtime = int.Parse(pair.Value);
                        break;
                }
            }
        }

    }
}
