
namespace ModToolLS
{
    partial class SettingsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LPLabel = new System.Windows.Forms.Label();
            this.LeaguePathBox = new System.Windows.Forms.TextBox();
            this.changeLeaguePath = new System.Windows.Forms.Button();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LPLabel
            // 
            this.LPLabel.AutoSize = true;
            this.LPLabel.Location = new System.Drawing.Point(31, 46);
            this.LPLabel.Name = "LPLabel";
            this.LPLabel.Size = new System.Drawing.Size(74, 13);
            this.LPLabel.TabIndex = 0;
            this.LPLabel.Text = "League Path :";
            // 
            // LeaguePathBox
            // 
            this.LeaguePathBox.Location = new System.Drawing.Point(34, 67);
            this.LeaguePathBox.Name = "LeaguePathBox";
            this.LeaguePathBox.Size = new System.Drawing.Size(771, 20);
            this.LeaguePathBox.TabIndex = 1;
            // 
            // changeLeaguePath
            // 
            this.changeLeaguePath.Location = new System.Drawing.Point(111, 41);
            this.changeLeaguePath.Name = "changeLeaguePath";
            this.changeLeaguePath.Size = new System.Drawing.Size(149, 23);
            this.changeLeaguePath.TabIndex = 2;
            this.changeLeaguePath.Text = "Change League Path";
            this.changeLeaguePath.UseVisualStyleBackColor = true;
            this.changeLeaguePath.Click += new System.EventHandler(this.changeLeaguePath_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorBox.Location = new System.Drawing.Point(281, 46);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(329, 13);
            this.ErrorBox.TabIndex = 3;
            // 
            // SettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.changeLeaguePath);
            this.Controls.Add(this.LeaguePathBox);
            this.Controls.Add(this.LPLabel);
            this.Name = "SettingsUC";
            this.Size = new System.Drawing.Size(843, 481);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPLabel;
        private System.Windows.Forms.TextBox LeaguePathBox;
        private System.Windows.Forms.Button changeLeaguePath;
        private System.Windows.Forms.TextBox ErrorBox;
    }
}
