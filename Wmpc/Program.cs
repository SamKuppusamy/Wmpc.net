using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wmpc.Mpd;

namespace Wmpc.net {
    class Program {
        static void Main(string[] args) {

            Mpd.Client client = new Mpd.Client("192.168.1.3", 6600);
            Response response = client.SendCommand("play"); // ("command_list_begin\nstats\nstats\ncommand_list_end");
            //Track track = client.StatusProvider.QueryCurrentSong(); //
            
            //Console.WriteLine(response.ResponseString);

            Console.WriteLine(client.SendCommand("currentsong").ResponseString);

            Console.Read();
        }
    }
}
