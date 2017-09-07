using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWebClient7917
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                WebClient client = new WebClient();
                //client.Headers.Add("Content-Type", "text/plain; charset=UTF-8");  // ekstra header info
                //client.Encoding = Encoding.UTF8;                                  // ekstra om encoding
                string Message = client.DownloadString("http://bjoerks.net/test/test.txt");
                Console.WriteLine("Message:" + Message + ":end of Message");
            }

            {
                WebClient client = new WebClient();
                //client.Headers.Add("Content-Type", "text/htm; charset=UTF-8");     // ekstra header info
                //client.Encoding = Encoding.UTF8;                                   // ekstra om encoding
                string Message = client.DownloadString("http://bjoerks.net/Csharp/Opgaver/OpgaverHttp_ENG.htm");
                Console.WriteLine("Message:" + Message + ":end of Message");
            }
            Console.ReadLine();         // vent på retur
        }
    }
}
