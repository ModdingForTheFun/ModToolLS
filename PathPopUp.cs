using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModToolLS
{
    public partial class PathPopUp : Form
    {

        private MainForm mainForm;

        public PathPopUp(MainForm  mainForm)
        {
            InitializeComponent();

            this.CenterToScreen();

            this.mainForm = mainForm;
        }

        private void OpenFileExplorer_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog openDialog = new FolderBrowserDialog();

            if (openDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openDialog.SelectedPath))
            {

                string file = openDialog.SelectedPath;

                PathText.Text = file;

                string[] files = Directory.GetFiles(openDialog.SelectedPath);

                bool rightFolder = false;

                foreach(String s in files)
                {
                    if (s.Contains("League of Legends.exe"))
                    {
                        rightFolder = true;
                    }
                }

                if (rightFolder)
                {

                    ErrorBox.Text = "";

                    FileWorker FW = new FileWorker();
                    FW.writeLeaguePathToConfig(file);

                    mainForm.openWindow();

                    this.Dispose();
                }
                else
                {
                    ErrorBox.Text = "Couldn't find League of Legends.exe";
                }

            }

        }


    }
}
