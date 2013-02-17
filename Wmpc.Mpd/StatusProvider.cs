using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class StatusProvider : Provider {

        const string MPD_CLEAR_ERROR = "clearerror";
        const string MPD_CURRENTSONG = "currentsong";
        const string MPD_STATUS = "status";

        public StatusProvider(Client client) : base(client) { }

        public Response QueryClearError() {
            return this.client.SendCommand(MPD_CLEAR_ERROR);
        }

        public Track QueryCurrentSong() {
            Response response =  this.client.SendCommand(MPD_CURRENTSONG);
            Track track = new Track(response.Values);
            return track;
        }

        public Response QueryStatus(string status) {
            return this.client.SendCommand(MPD_STATUS + ' ' + status);
        }

        public Response QueryElapsed() {
            return this.QueryStatus(Status.MPD_STATUS_ELAPSED);
        }

    }
}
