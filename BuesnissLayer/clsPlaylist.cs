using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuesnissLayer
{
    public class clsPlaylist
    {
        public static string dir = "C:\\Users\\DELL\\Music";

        private static List <string> Audiolist = new List<string>();
        public static List<string> LoadFiles() => Audiolist = Directory.GetFiles(dir, "*.mp3").ToList();
        public static string ShowPath(string str)
        {
            StringBuilder Ext = new StringBuilder(Path.GetExtension(str).Trim());
            return str.Remove(0, dir.Length + 1).Replace(Ext.ToString(), "\0");
        }
    }
}
