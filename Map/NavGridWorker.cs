using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModToolLS
{
    class NavGridWorker
    {

        private bool ready = false;

        public NavGridWorker(String file,MapEditor mainForm)
        {

            if (file.Length < 1)
            {
                Console.WriteLine("Error:  must provide a file");
            }
            else
            if(file.ToLower().EndsWith(".aimesh_ngrid") == true)
            {

                FileWrapper ngridFile = new FileWrapper(file);

                int ngridMajorVersion = ngridFile.ReadByte();
                int ngridMinorVersion = 0;
                if (ngridMajorVersion != 2)
                {
                    // not sure why this is short but the other is byte, might just be padding
                    // note that the only known non-zero minor version to exist (other than unofficial 2.1) is 3.1, with no know difference from 3.0
                    ngridMinorVersion = ngridFile.ReadShort();
                }
                else
                {
                    // version 2 lacked a minor version value (although it clearly needed one since there's an unofficial version 2.0 and 2.1 split)
                }

                Console.WriteLine("\nngrid major version = " + ngridMajorVersion + " minor version = " + ngridMinorVersion);

                if (ngridMajorVersion != 7 && ngridMajorVersion != 5 && ngridMajorVersion != 3 && ngridMajorVersion != 2)
                {
                    Console.WriteLine("Error:  unsupported ngrid version number " + ngridMajorVersion + " (please report this)");
                    return;
                }


                //TODO add another check that it is season 4.20 version

                //mainForm.setMajorVersion(ngridMajorVersion + "");
                //mainForm.setMinorVersion(ngridMinorVersion + "");
                

                NGridFileReader NGridFile = new NGridFileReader(ngridFile, ngridMajorVersion, ngridMinorVersion);


                //NGridFile.ColorPanel(mainForm);
            }

        }





































    }

}
