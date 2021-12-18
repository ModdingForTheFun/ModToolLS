using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ModToolLS.Map;

namespace ModToolLS
{
    public partial class MapEditor : Form
    {

        public MapEditor()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) //Save
        {

            
        }

        private void button2_Click(object sender, EventArgs e) //open
        {
            

        }




        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        private void mapObjectsmobToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MapObjectsEditor MOE = new MapObjectsEditor();

            ContentHolder.Controls.Clear();

            ContentHolder.Controls.Add(MOE);

        }
    }
}
