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
        static byte[] binaryData = wc.DownloadData("https://www.nib.si/mbp/sl/oceanografski-podatki/buoy-2/live-data-2");
        static string strData = Encoding.UTF8.GetString(binaryData);
        public static String Temp() 
        {
            
            var match = Regex.Match(strData, @"Temperatura: (?<temp>\d+.\d+)");
            return ($"{match.Groups["temp"].Value} °C");
        }
        public static String Wind()
        {
            
            var match = Regex.Match(strData, @"Hitrost vetra: (?<veter>\d+.\d+)");
           
            return ($"{match.Groups["veter"].Value} m/s");
           
            
        }
        public static String SeaW() 
        {
           
            var match = Regex.Match(strData, @"Značilna višina: (?<valovi>\d+.\d+)");
            
            return ($"{match.Groups["valovi"].Value} m");
            
        }
        public static String SeaTP() 
        {
           
            var match = Regex.Match(strData, @"Temperatura na površini \(globina 2.5 m\): (?<temp>\d+.\d+)");
            
            return ($"{ match.Groups["temp"].Value} °C");
            
        }
        public static String SeaTG1()
        {
            
            var match = Regex.Match(strData, @"Temperatura na dnu - senzor 1 \(globina ca. 23 m\): (?<temp>\d+.\d+)");
           
            return ($"{match.Groups["temp"].Value} °C");
            

            
        }
        public static String SeaTG2() 
        {

            
            var match2 = Regex.Match(strData, @"Temperatura na dnu - senzor 2 \(globina ca. 23 m\): (?<temp2>\d+.\d+)");
           
            return ($"{match2.Groups["temp2"].Value} ° C");
            
        }
        public static void RefreshData() 
        {
            binaryData = wc.DownloadData("https://www.nib.si/mbp/sl/oceanografski-podatki/buoy-2/live-data-2");
            strData = Encoding.UTF8.GetString(binaryData);
        }
        
 
    }
}
