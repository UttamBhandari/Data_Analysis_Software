namespace Data_Analysis_Software
{
    partial class btnindividualform
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelstarttime = new System.Windows.Forms.Label();
            this.labelweight = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.labellength = new System.Windows.Forms.Label();
            this.labelsmode = new System.Windows.Forms.Label();
            this.labelmonitor = new System.Windows.Forms.Label();
            this.labelinterval = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnviewgraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.restartToolStripMenuItem});
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelstarttime
            // 
            this.labelstarttime.AutoSize = true;
            this.labelstarttime.Location = new System.Drawing.Point(721, 39);
            this.labelstarttime.Name = "labelstarttime";
            this.labelstarttime.Size = new System.Drawing.Size(55, 13);
            this.labelstarttime.TabIndex = 3;
            this.labelstarttime.Text = "Start Time";
            // 
            // labelweight
            // 
            this.labelweight.AutoSize = true;
            this.labelweight.Location = new System.Drawing.Point(724, 178);
            this.labelweight.Name = "labelweight";
            this.labelweight.Size = new System.Drawing.Size(41, 13);
            this.labelweight.TabIndex = 13;
            this.labelweight.Text = "Weight";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(723, 132);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(30, 13);
            this.labeldate.TabIndex = 12;
            this.labeldate.Text = "Date";
            // 
            // labellength
            // 
            this.labellength.AutoSize = true;
            this.labellength.Location = new System.Drawing.Point(724, 155);
            this.labellength.Name = "labellength";
            this.labellength.Size = new System.Drawing.Size(40, 13);
            this.labellength.TabIndex = 10;
            this.labellength.Text = "Length";
            // 
            // labelsmode
            // 
            this.labelsmode.AutoSize = true;
            this.labelsmode.Location = new System.Drawing.Point(723, 109);
            this.labelsmode.Name = "labelsmode";
            this.labelsmode.Size = new System.Drawing.Size(41, 13);
            this.labelsmode.TabIndex = 11;
            this.labelsmode.Text = "SMode";
            // 
            // labelmonitor
            // 
            this.labelmonitor.AutoSize = true;
            this.labelmonitor.Location = new System.Drawing.Point(722, 86);
            this.labelmonitor.Name = "labelmonitor";
            this.labelmonitor.Size = new System.Drawing.Size(42, 13);
            this.labelmonitor.TabIndex = 9;
            this.labelmonitor.Text = "Monitor";
            // 
            // labelinterval
            // 
            this.labelinterval.AutoSize = true;
            this.labelinterval.Location = new System.Drawing.Point(722, 62);
            this.labelinterval.Name = "labelinterval";
            this.labelinterval.Size = new System.Drawing.Size(42, 13);
            this.labelinterval.TabIndex = 8;
            this.labelinterval.Text = "Interval";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 392);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnviewgraph
            // 
            this.btnviewgraph.Location = new System.Drawing.Point(361, 27);
            this.btnviewgraph.Name = "btnviewgraph";
            this.btnviewgraph.Size = new System.Drawing.Size(75, 23);
            this.btnviewgraph.TabIndex = 25;
            this.btnviewgraph.Text = "View Graph";
            this.btnviewgraph.UseVisualStyleBackColor = true;
            this.btnviewgraph.Click += new System.EventHandler(this.btnviewgraph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Change Speed To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "KM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Mile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 25);
            this.button3.TabIndex = 30;
            this.button3.Text = "Compare File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(598, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Result";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(872, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Interval Detection";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(572, 274);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(432, 176);
            this.dataGridView2.TabIndex = 33;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(726, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnindividualform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 480);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnviewgraph);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelweight);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labellength);
            this.Controls.Add(this.labelsmode);
            this.Controls.Add(this.labelmonitor);
            this.Controls.Add(this.labelinterval);
            this.Controls.Add(this.labelstarttime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "btnindividualform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelstarttime;
        private System.Windows.Forms.Label labelweight;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labellength;
        private System.Windows.Forms.Label labelsmode;
        private System.Windows.Forms.Label labelmonitor;
        private System.Windows.Forms.Label labelinterval;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnviewgraph;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button6;
    }
}

