namespace Data_Analysis_Software
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.labelstarttime = new System.Windows.Forms.Label();
            this.labelweight = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.labellength = new System.Windows.Forms.Label();
            this.labelsmode = new System.Windows.Forms.Label();
            this.labelmonitor = new System.Windows.Forms.Label();
            this.labelinterval = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(281, 43);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(494, 382);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Start Time";
            // 
            // labelstarttime
            // 
            this.labelstarttime.AutoSize = true;
            this.labelstarttime.Location = new System.Drawing.Point(25, 46);
            this.labelstarttime.Name = "labelstarttime";
            this.labelstarttime.Size = new System.Drawing.Size(55, 13);
            this.labelstarttime.TabIndex = 3;
            this.labelstarttime.Text = "Start Time";
            // 
            // labelweight
            // 
            this.labelweight.AutoSize = true;
            this.labelweight.Location = new System.Drawing.Point(26, 199);
            this.labelweight.Name = "labelweight";
            this.labelweight.Size = new System.Drawing.Size(41, 13);
            this.labelweight.TabIndex = 13;
            this.labelweight.Text = "Weight";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(25, 148);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(30, 13);
            this.labeldate.TabIndex = 12;
            this.labeldate.Text = "Date";
            // 
            // labellength
            // 
            this.labellength.AutoSize = true;
            this.labellength.Location = new System.Drawing.Point(26, 171);
            this.labellength.Name = "labellength";
            this.labellength.Size = new System.Drawing.Size(40, 13);
            this.labellength.TabIndex = 10;
            this.labellength.Text = "Length";
            // 
            // labelsmode
            // 
            this.labelsmode.AutoSize = true;
            this.labelsmode.Location = new System.Drawing.Point(25, 126);
            this.labelsmode.Name = "labelsmode";
            this.labelsmode.Size = new System.Drawing.Size(41, 13);
            this.labelsmode.TabIndex = 11;
            this.labelsmode.Text = "SMode";
            // 
            // labelmonitor
            // 
            this.labelmonitor.AutoSize = true;
            this.labelmonitor.Location = new System.Drawing.Point(25, 102);
            this.labelmonitor.Name = "labelmonitor";
            this.labelmonitor.Size = new System.Drawing.Size(42, 13);
            this.labelmonitor.TabIndex = 9;
            this.labelmonitor.Text = "Monitor";
            // 
            // labelinterval
            // 
            this.labelinterval.AutoSize = true;
            this.labelinterval.Location = new System.Drawing.Point(25, 76);
            this.labelinterval.Name = "labelinterval";
            this.labelinterval.Size = new System.Drawing.Size(42, 13);
            this.labelinterval.TabIndex = 8;
            this.labelinterval.Text = "Interval";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelweight);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labellength);
            this.Controls.Add(this.labelsmode);
            this.Controls.Add(this.labelmonitor);
            this.Controls.Add(this.labelinterval);
            this.Controls.Add(this.labelstarttime);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label labelstarttime;
        private System.Windows.Forms.Label labelweight;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labellength;
        private System.Windows.Forms.Label labelsmode;
        private System.Windows.Forms.Label labelmonitor;
        private System.Windows.Forms.Label labelinterval;
    }
}

