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
        
        public PlaylistProvider(Client client) : base(client) { }

        public Response QueryAdd(string uri) {
            Command command = new Command(MPD_ADD, "\"" + uri + "\"");
            return this.client.SendCommand(command);
        }

        public Response QueryAddId(string uri, int position) {
            Command command = new Command(MPD_ADDID, "\"" + uri + "\"", position);
            return this.client.SendCommand(command);
        }

        public Response QueryClear() {
            return this.client.SendCommand(MPD_CLEAR);
        }

        public Response QueryDelete(int start, int end) {
            Command command = new Command(MPD_DELETE, start.ToString() + ":" + end.ToString());
            return this.client.SendCommand(command);
        }

        public Response QueryDelete(int pos) {
            Command command = new Command(MPD_DELETE, pos);
            return this.client.SendCommand(command);
        }

        public Response QueryDeleteId(int songid) {
            Command command = new Command(MPD_DELETEID, songid);
            return this.client.SendCommand(command);
        }

        public Response QueryPrio(byte priority, int start, int end) {
            Command command = new Command(MPD_PRIO, (int)priority, start.ToString() + ":" + end.ToString());
            return this.client.SendCommand(command);
        }

        public Response QueryPrioId(byte priority, int id) {
            Command command = new Command(MPD_PRIOID, (int)priority, id);
            return this.client.SendCommand(command);
        }

        public Response QueryShuffle(int start, int end) {
            Command command = new Command(MPD_SHUFFLE, start.ToString() + ":" + end.ToString());
            return this.client.SendCommand(command);
        }

        public Response QueryShuffle() {
            return this.client.SendCommand(MPD_SHUFFLE);
        }

        public Response QuerySwap(int song1, int song2) {
            Command command = new Command(MPD_SWAP, song1, song2);
            return this.client.SendCommand(command);
        }

        public Response QuerySwapId(int id1, int id2) {
            Command command = new Command(MPD_SWAPID, id1, id2);
            return this.client.SendCommand(command);
        }

        public Response QueryMove(int from, int start, int end) {
            Command command = new Command(MPD_MOVE, from, start.ToString() + ":" + end.ToString());
            return this.client.SendCommand(command);
        }

        public Response QueryMoveId(int from, int to) {
            Command command = new Command(MPD_MOVEID, from, to);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylist() {
            Command command = new Command(MPD_PLAYLIST);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistFind(string tag, string needle) {
            Command command = new Command(MPD_PLAYLISTFIND, tag, needle);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistId() {
            Command command = new Command(MPD_PLAYLISTID);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistId(int songid) {
            Command command = new Command(MPD_PLAYLISTID, songid);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistInfo(int start, int end) {
            Command command = new Command(MPD_PLAYLISTINFO, start.ToString() + ":" + end.ToString());
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistInfo(int songpos) {
            Command command = new Command(MPD_PLAYLISTINFO, songpos);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistInfo() {
            Command command = new Command(MPD_PLAYLISTINFO);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistSearch(string tag, string needle) {
            Command command = new Command(MPD_PLAYLISTSEARCH, tag, needle);
            return this.client.SendCommand(command);
        }

        public Response QueryPlChanges(string version) {
            Command command = new Command(MPD_PLCHANGES, version);
            return this.client.SendCommand(command);
        }

        public Response QueryPlChangesPosId(string version) {
            Command command = new Command(MPD_PLCHANGESPOSID, version);
            return this.client.SendCommand(command);
        }


        const string MPD_LISTPLAYLIST = "listplaylist";
        const string MPD_LISTPLAYLISTINFO = "listplaylistinfo";
        const string MPD_LISTPLAYLISTS = "listplaylists";
        const string MPD_LOAD = "load";
        const string MPD_PLAYLISTADD = "playlistadd";
        const string MPD_PLAYLISTCLEAR = "playlistclear";
        const string MPD_PLAYLISTDELETE = "playlistdelete";
        const string MPD_PLAYLISTMOVE = "playlistmove";
        const string MPD_RENAME = "rename";
        const string MPD_RM = "rm";
        const string MPD_SAVE = "save";

        public Response QueryListPlaylist(string name) {
            Command command = new Command(MPD_LISTPLAYLIST, name);
            return this.client.SendCommand(command);
        }

        public Response QueryListPlaylistInfo(string name) {
            Command command = new Command(MPD_LISTPLAYLISTINFO, name);
            return this.client.SendCommand(command);
        }

        public Response QueryListPlaylist(string name) {
            Command command = new Command(MPD_LISTPLAYLIST, name);
            return this.client.SendCommand(command);
        }

        public Response QueryListPlaylists() {
            Command command = new Command(MPD_LISTPLAYLISTS);
            return this.client.SendCommand(command);
        }

        public Response QueryLoad(string name) {
            Command command = new Command(MPD_LOAD, name);
            return this.client.SendCommand(command);
        }

        public Response QueryLoad(string name, int start, int end) {
            Command command = new Command(MPD_LOAD, name, start.ToString() + ":" + end.ToString());
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistAdd(string name, string uri) {
            Command command = new Command(MPD_PLAYLISTADD, name, uri);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistClear(string name) {
            Command command = new Command(MPD_PLAYLISTCLEAR, name);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistDelete(string name, int songpos) {
            Command command = new Command(MPD_PLAYLISTDELETE, name, songpos);
            return this.client.SendCommand(command);
        }

        public Response QueryPlaylistMove(string name, int songid, int songpos) {
            Command command = new Command(MPD_PLAYLISTMOVE, name, songid.ToString() + " " + songpos.ToString());
            return this.client.SendCommand(command);
        }

        public Response QueryRename(string name, string newName) {
            Command command = new Command(MPD_PLAYLISTCLEAR, name, newName);
            return this.client.SendCommand(command);
        }

        public Response QueryRm(string name) {
            Command command = new Command(MPD_RM, name);
            return this.client.SendCommand(command);
        }

        public Response QuerySave(string name) {
            Command command = new Command(MPD_SAVE, name);
            return this.client.SendCommand(command);
        }

    }
}
