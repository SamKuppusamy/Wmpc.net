using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wmpc.Mpd {
    public class DatabaseProvider : Provider {

        const string MPD_DB_COUNT = "count";
        const string MPD_DB_FIND = "find";
        const string MPD_DB_FINDADD = "findadd";
        const string MPD_DB_LIST = "list";
        const string MPD_DB_LISTALL = "listall";
        const string MPD_DB_LISTALLINFO = "listallinfo";
        const string MPD_DB_SEARCH = "search";
        const string MPD_DB_SEARCHADD = "searchadd";
        const string MPD_DB_SEARCHADDPL = "searchaddpl";
        const string MPD_DB_UPDATE = "update";
        const string MPD_DB_RESCAN = "rescan";
        
        public DatabaseProvider(Client client) : base(client) { }

        public Response QueryCount(string tag, string needle) {
            return this.client.SendCommand(MPD_DB_COUNT);
        }

        public Response QueryFind(string type, string what) {
            Command command = new Command(MPD_DB_FIND, type, what);
            command.QuoteParam2 = true;
            return this.client.SendCommand(command);
        }

        public Response QueryFindAdd(string type, string what) {
            Command command = new Command(MPD_DB_FINDADD, type, what);
            command.QuoteParam2 = true;
            return this.client.SendCommand(command);
        }

        public Response QueryList(string type) {
            Command command = new Command(MPD_DB_LIST, type);
            return this.client.SendCommand(command);
        }

        public Response QueryList(string type, string album) {
            Command command = new Command(MPD_DB_LIST, type, album);
            command.QuoteParam2 = true;
            return this.client.SendCommand(command);
        }

        public Response QueryListall(string uri) {
            Command command = new Command(MPD_DB_LISTALL, uri);
            return this.client.SendCommand(command);
        }

        public Response QueryListallInfo(string uri) {
            Command command = new Command(MPD_DB_LISTALLINFO, uri);
            return this.client.SendCommand(command);
        }

        public Response QuerySearch(string type, string what) {
            Command command = new Command(MPD_DB_SEARCH, type, what);
            command.QuoteParam2 = true;
            return this.client.SendCommand(command);
        }

        public Response QuerySearchAdd(string type, string what) {
            Command command = new Command(MPD_DB_SEARCHADD, type, what);
            command.QuoteParam2 = true;
            return this.client.SendCommand(command);
        }

        public Response QuerySearchAddPl(string name, string type, string what) {
            Command command = new Command(MPD_DB_SEARCHADD, name + " " + type, what);
            command.QuoteParam2 = true;
            return this.client.SendCommand(command);
        }

        public Response QueryUpdate(string uri) {
            Command command = new Command(MPD_DB_UPDATE, uri);
            return this.client.SendCommand(command);
        }

        public Response QueryRescan(string uri) {
            Command command = new Command(MPD_DB_RESCAN, uri);
            return this.client.SendCommand(command);
        }

    }
}
