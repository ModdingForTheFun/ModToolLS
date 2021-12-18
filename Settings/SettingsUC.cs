using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ModToolLS
{
    public partial class SettingsUC : UserControl
    {
        public SettingsUC()
        {
            InitializeComponent();

            String path = new FileWorker().getLeaguePath();

            LeaguePathBox.Text = path;
        }

        private void changeLeaguePath_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog openDialog = new FolderBrowserDialog();

            if (openDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openDialog.SelectedPath))
            {

                string file = openDialog.SelectedPath;

                string[] files = Directory.GetFiles(openDialog.SelectedPath);

                bool rightFolder = false;

                foreach (String s in files)
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

                    LeaguePathBox.Text = file;
                }
                else
                {
                    ErrorBox.Text = "Couldn't find League of Legends.exe";
                }

            }

        }
    }
}
