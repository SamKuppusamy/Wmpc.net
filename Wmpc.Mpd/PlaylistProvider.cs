using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class PlaylistProvider : Provider {

        const string MPD_ADD = "add";
        const string MPD_ADDID= "addid";
        const string MPD_CLEAR= "clear";
        const string MPD_DELETE = "delete";
        const string MPD_DELETEID = "deleteid";
        const string MPD_MOVE = "move";
        const string MPD_MOVEID = "moveid";
        const string MPD_PLAYLIST= "playlist";
        const string MPD_PLAYLISTFIND = "playlistfind";
        const string MPD_PLAYLISTID = "playlistid";
        const string MPD_PLAYLISTINFO = "playlistinfo";
        const string MPD_PLAYLISTSEARCH = "playlistsearch";
        const string MPD_PLCHANGES = "plchanges";
        const string MPD_PLCHANGESPOSID = "plchangesposid";
        const string MPD_PRIO = "prio";
        const string MPD_PRIOID = "prioid";
        const string MPD_SHUFFLE = "shuffle";
        const string MPD_SWAP = "swap";
        const string MPD_SWAPID = "swapid";
        
        /*
     
move [{FROM} | {START:END}] {TO}
 Moves the song at FROM or range of songs at START:END to TO in the playlist. [5] 
moveid {FROM} {TO}
 Moves the song with FROM (songid) to TO (playlist index) in the playlist. If TO is negative, it is relative to the current song in the playlist (if there is one). 
playlist 
 Displays the current playlist. 
playlistfind {TAG} {NEEDLE}
 Finds songs in the current playlist with strict matching. 
playlistid {SONGID}
 Displays a list of songs in the playlist. SONGID is optional and specifies a single song to display info for. 
playlistinfo [[SONGPOS] | [START:END]]
 Displays a list of all songs in the playlist, or if the optional argument is given, displays information only for the song SONGPOS or the range of songs START:END [5] 
playlistsearch {TAG} {NEEDLE}
 Searches case-sensitively for partial matches in the current playlist. 
plchanges {VERSION}
 Displays changed songs currently in the playlist since VERSION. 
 To detect songs that were deleted at the end of the playlist, use playlistlength returned by status command. 
plchangesposid {VERSION}
 Displays changed songs currently in the playlist since VERSION. This function only returns the position and the id of the changed song, not the complete metadata. This is more bandwidth efficient. 
 To detect songs that were deleted at the end of the playlist, use playlistlength returned by status command. 
        */


        public PlaylistProvider(Client client) : base(client) { }

        public Response QueryAdd(string uri) {
            Command command = new Command(MPD_ADD, "\"" + uri + "\"");
            return this.client.SendCommand(command);
        }

        public Response QueryAddId(string uri, int position) {
            Command command = new Command(MPD_ADDID, "\"" + uri + "\"", position);
            return this.client.SendCommand(command);
        }

        public Status QueryClear() {
            return new Status(this.client.SendCommand(MPD_CLEAR));
        }

        public Stats QueryDelete(int start, int end) {
            Command command = new Command(MPD_DELETE, start.ToString() + ":" + end.ToString());
            return new Stats(this.client.SendCommand(command));
        }

        public Stats QueryDelete(int pos) {
            Command command = new Command(MPD_DELETE, pos);
            return new Stats(this.client.SendCommand(command));
        }

        public Stats QueryDeleteId(int songid) {
            Command command = new Command(MPD_DELETEID, songid);
            return new Stats(this.client.SendCommand(command));
        }

        public Stats QueryPrio(byte priority, int start, int end) {
            Command command = new Command(MPD_PRIO, (int)priority, start.ToString() + ":" + end.ToString());
            return new Stats(this.client.SendCommand(command));
        }

        public Stats QueryPrioId(byte priority, int id) {
            Command command = new Command(MPD_PRIOID, (int)priority, id);
            return new Stats(this.client.SendCommand(command));
        }

        public Stats QueryShuffle(int start, int end) {
            Command command = new Command(MPD_SHUFFLE, start.ToString() + ":" + end.ToString());
            return new Stats(this.client.SendCommand(command));
        }

        public Stats QueryShuffle() {
            return new Stats(this.client.SendCommand(MPD_SHUFFLE));
        }

        public Stats QuerySwap(int song1, int song2) {
            Command command = new Command(MPD_SWAP, song1, song2);
            return new Stats(this.client.SendCommand(command));
        }


        public Stats QuerySwapId(int id1, int id2) {
            Command command = new Command(MPD_SWAPID, id1, id2);
            return new Stats(this.client.SendCommand(command));
        }


    }
}
