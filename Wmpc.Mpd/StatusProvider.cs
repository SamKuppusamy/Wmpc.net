using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class StatusProvider : Provider {

        const string MPD_CLEAR_ERROR = "clearerror";
        const string MPD_CURRENTSONG = "currentsong";
        const string MPD_STATUS = "status";
        const string MPD_STATS = "stats";

        public StatusProvider(Client client) : base(client) { }

        public Response QueryClearError() {
            return this.client.SendCommand(MPD_CLEAR_ERROR);
        }

        public Track QueryCurrentSong() {
            Response response =  this.client.SendCommand(MPD_CURRENTSONG);
            Track track = new Track(response);
            return track;
        }

        public Status QueryStatus() {
            return new Status(this.client.SendCommand(MPD_STATUS));
        }

        public Stats QueryStats() {
            return new Stats(this.client.SendCommand(MPD_STATS));
        }

    }
}
