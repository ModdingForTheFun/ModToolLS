using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ModToolLS
{
    class FileWorker
    {




        public void writeLeaguePathToConfig(string leaguePath)
        {

            StreamWriter sw;

            if (!File.Exists("Config.cfg"))
            {
                sw = new StreamWriter(File.Create("Config.cfg"));
            }
            else
            {
                sw = new StreamWriter("Config.cfg");
            }

            sw.WriteLine("League path :" + leaguePath);

            sw.Flush();
            sw.Close();
        }

        public String getLeaguePath()
        {

            if (!File.Exists("Config.cfg"))
            {
                StreamWriter sw = new StreamWriter(File.Create("Config.cfg"));

                sw.WriteLine("League path :");

                sw.Flush();
                sw.Close();
            }


            StreamReader sr = new StreamReader("Config.cfg");

            String path = sr.ReadLine();

            sr.Close();

            if (path != null && path.Contains(":"))
            {
                path = path.Substring(path.IndexOf(":") + 1);

                return path;
            }
            else
            {
                return " ";
            }

        }
















    }

}
