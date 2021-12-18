
namespace ModToolLS
{
    partial class PathPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterPathLabel = new System.Windows.Forms.Label();
            this.PathText = new System.Windows.Forms.TextBox();
            this.OpenFileExplorer = new System.Windows.Forms.Button();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterPathLabel
            // 
            this.EnterPathLabel.AutoSize = true;
            this.EnterPathLabel.Location = new System.Drawing.Point(204, 74);
            this.EnterPathLabel.Name = "EnterPathLabel";
            this.EnterPathLabel.Size = new System.Drawing.Size(406, 13);
            this.EnterPathLabel.TabIndex = 0;
            this.EnterPathLabel.Text = "Please Enter the Path to your League 4.20 Folder ( has League of Legends.exe in i" +
    "t )";
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(12, 108);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(776, 20);
            this.PathText.TabIndex = 1;
            // 
            // OpenFileExplorer
            // 
            this.OpenFileExplorer.Location = new System.Drawing.Point(329, 134);
            this.OpenFileExplorer.Name = "OpenFileExplorer";
            this.OpenFileExplorer.Size = new System.Drawing.Size(142, 23);
            this.OpenFileExplorer.TabIndex = 2;
            this.OpenFileExplorer.Text = "Open File Explorer";
            this.OpenFileExplorer.UseVisualStyleBackColor = true;
            this.OpenFileExplorer.Click += new System.EventHandler(this.OpenFileExplorer_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorBox.Location = new System.Drawing.Point(301, 189);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(190, 13);
            this.ErrorBox.TabIndex = 3;
            // 
            // PathPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.OpenFileExplorer);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.EnterPathLabel);
            this.Name = "PathPopUp";
            this.Text = "PathPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterPathLabel;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button OpenFileExplorer;
        private System.Windows.Forms.TextBox ErrorBox;
    }
}