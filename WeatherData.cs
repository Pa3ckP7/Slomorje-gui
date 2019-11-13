using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace Slomorje_gui
{
    class WeatherData
    {
        private static readonly WebClient wc = new WebClient();
        public static String Temp() 
        {
            var binaryData = wc.DownloadData("https://www.nib.si/mbp/sl/oceanografski-podatki/buoy-2/live-data-2");
            var strData = Encoding.UTF8.GetString(binaryData);
            var match = Regex.Match(strData, @"Temperatura: (?<temp>\d+.\d+)");
            return ($"{match.Groups["temp"].Value} °C");
        }
        public static String Wind()
        {
            var binaryData = wc.DownloadData("https://www.nib.si/mbp/sl/oceanografski-podatki/buoy-2/live-data-2");
            var strData = Encoding.UTF8.GetString(binaryData);
            var match = Regex.Match(strData, @"Hitrost vetra: (?<veter>\d+.\d+)");
           // int tester = ConverteBig(match.Groups["veter"].Value);
            /*if (tester >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;

            }
            else if (tester >= 20 && tester <= 29)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (tester >= 10 && tester <= 19)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }*/
            return ($"{match.Groups["veter"].Value} m/s");
            //Console.ResetColor();
            
        }
        public static String SeaW() 
        {
            var binaryData = wc.DownloadData("https://www.nib.si/mbp/sl/oceanografski-podatki/buoy-2/live-data-2");
            var strData = Encoding.UTF8.GetString(binaryData);
            var match = Regex.Match(strData, @"Značilna višina: (?<valovi>\d+.\d+)");
            //int tester = ConverteBig(match.Groups["valovi"].Value);
            /*if (tester >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;

            }
            else if (tester >= 2 && tester < 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (tester >= 1 && tester < 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }*/
            return ($"{match.Groups["valovi"].Value} m");
            //Console.ResetColor();
        }
        public static String SeaTP() 
        {
            var binaryData = wc.DownloadData("https://www.nib.si/mbp/sl/oceanografski-podatki/buoy-2/live-data-2");
            var strData = Encoding.UTF8.GetString(binaryData);
            var match = Regex.Match(strData, @"Temperatura na površini \(globina 2.5 m\): (?<temp>\d+.\d+)");
            //int tester=ConverteBig(match.Groups["temp"].Value);
            /*if (tester >= 24 && tester <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else if (tester >= 19 && tester < 24)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }*/
            return ($"{ match.Groups["temp"].Value} °C");
            //Console.ResetColor();
        }
        public static String SeaTG1()
        {
            var binaryData = wc.DownloadData("https://www.nib.si/mbp/sl/oceanografski-podatki/buoy-2/live-data-2");
            var strData = Encoding.UTF8.GetString(binaryData);
            var match = Regex.Match(strData, @"Temperatura na dnu - senzor 1 \(globina ca. 23 m\): (?<temp>\d+.\d+)");
            /*if (!string.IsNullOrWhiteSpace(match.Groups["temp"].Value))
            {
                int tester = ConverteBig(match.Groups["temp"].Value);
                if (tester >= 24 && tester <= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                else if (tester >= 19 && tester < 24)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }*/
            return ($"{match.Groups["temp"].Value} °C");
            //Console.ResetColor();

            
        }
        public static String SeaTG2() 
        {

            var binaryData2 = wc.DownloadData("https://www.nib.si/mbp/sl/oceanografski-podatki/buoy-2/live-data-2");
            var strData2 = Encoding.UTF8.GetString(binaryData2);
            var match2 = Regex.Match(strData2, @"Temperatura na dnu - senzor 2 \(globina ca. 23 m\): (?<temp2>\d+.\d+)");
            /*if (!string.IsNullOrWhiteSpace(match2.Groups["temp2"].Value))
            {


                int tester2 = ConverteBig(match2.Groups["temp2"].Value);
                if (tester2 >= 24 && tester2 <= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                else if (tester2 >= 19 && tester2 < 24)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }*/
            return ($"{match2.Groups["temp2"].Value} ° C");
            //Console.ResetColor();
        }
        
 
    }
}
