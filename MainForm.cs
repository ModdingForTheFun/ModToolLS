using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ModToolLS
{
    public partial class MainForm : Form
    {


        public MainForm()
        {

            //set up the window
            InitializeComponent();

            this.Text = "";

            this.Icon = new Icon("ICON.ico");

            this.CenterToScreen();

            // check of league path is set

            FileWorker FW = new FileWorker();
            String LeaguePath = FW.getLeaguePath();

            String[] files = Directory.GetFiles(LeaguePath);

            bool foundLol = false;

            foreach(String s in files)
            {
                if (s.Contains("League of Legends.exe"))
                {
                    foundLol = true;
                }
            }

            if (!foundLol)
            {
                MainMenuStrip.Hide();

                this.WindowState = FormWindowState.Minimized;

                new PathPopUp(this).Show();
            }

            
            
        }

        public void openWindow()
        {
            this.WindowState = FormWindowState.Normal;
            MainMenuStrip.Show();
        }

        private void openSettingsWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            mainPanel.Controls.Clear();

            SettingsUC set = new SettingsUC();
            mainPanel.Controls.Add(set);

        }

        private void createMapToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new MapEditor().Show();
            this.WindowState = FormWindowState.Normal;

        }
    }
}
