using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using Wmpc.Mpd;

namespace Wmpc.net {
    class Program {
        static void Main(string[] args) {

            Mpd.Client client = new Mpd.Client("192.168.1.3", 6600);
            //Response response = client.SendCommand("play"); // ("command_list_begin\nstats\nstats\ncommand_list_end");
            //Track track = client.StatusProvider.QueryCurrentSong(); //
  
            //Console.WriteLine(response.ResponseString);

            //Console.WriteLine(client.SendCommand("add \"Nightwish/2006 - End Of An Era/12 - Kuolema Tekee Taiteilijan.mp3\"").ResponseString);



            //Color screenTextColor = Color.Orange;
            //Color screenBackgroundColor = Color.Black;
            //SetScreenColorsApp.SetScreenColors(screenTextColor, screenBackgroundColor);
          

            //Console.WriteLine("Some text in a console window");
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.ReadLine();
        }
    }
}
