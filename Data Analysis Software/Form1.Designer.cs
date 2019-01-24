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
            this.lbltotalDistanceCovered = new System.Windows.Forms.Label();
            this.lblAverageSpeed = new System.Windows.Forms.Label();
            this.lblmaxSpeed = new System.Windows.Forms.Label();
            this.lblaverageHeartRate = new System.Windows.Forms.Label();
            this.lblmaximumHeartRate = new System.Windows.Forms.Label();
            this.lblminHeartRate = new System.Windows.Forms.Label();
            this.lblaveragePower = new System.Windows.Forms.Label();
            this.lblmaxPower = new System.Windows.Forms.Label();
            this.lblaverageAltitude = new System.Windows.Forms.Label();
            this.lblmaximumAltitude = new System.Windows.Forms.Label();
            this.btnviewgraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
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
            this.labelstarttime.Location = new System.Drawing.Point(686, 33);
            this.labelstarttime.Name = "labelstarttime";
            this.labelstarttime.Size = new System.Drawing.Size(55, 13);
            this.labelstarttime.TabIndex = 3;
            this.labelstarttime.Text = "Start Time";
            // 
            // labelweight
            // 
            this.labelweight.AutoSize = true;
            this.labelweight.Location = new System.Drawing.Point(689, 172);
            this.labelweight.Name = "labelweight";
            this.labelweight.Size = new System.Drawing.Size(41, 13);
            this.labelweight.TabIndex = 13;
            this.labelweight.Text = "Weight";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(688, 126);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(30, 13);
            this.labeldate.TabIndex = 12;
            this.labeldate.Text = "Date";
            // 
            // labellength
            // 
            this.labellength.AutoSize = true;
            this.labellength.Location = new System.Drawing.Point(689, 149);
            this.labellength.Name = "labellength";
            this.labellength.Size = new System.Drawing.Size(40, 13);
            this.labellength.TabIndex = 10;
            this.labellength.Text = "Length";
            // 
            // labelsmode
            // 
            this.labelsmode.AutoSize = true;
            this.labelsmode.Location = new System.Drawing.Point(688, 103);
            this.labelsmode.Name = "labelsmode";
            this.labelsmode.Size = new System.Drawing.Size(41, 13);
            this.labelsmode.TabIndex = 11;
            this.labelsmode.Text = "SMode";
            // 
            // labelmonitor
            // 
            this.labelmonitor.AutoSize = true;
            this.labelmonitor.Location = new System.Drawing.Point(687, 80);
            this.labelmonitor.Name = "labelmonitor";
            this.labelmonitor.Size = new System.Drawing.Size(42, 13);
            this.labelmonitor.TabIndex = 9;
            this.labelmonitor.Text = "Monitor";
            // 
            // labelinterval
            // 
            this.labelinterval.AutoSize = true;
            this.labelinterval.Location = new System.Drawing.Point(687, 56);
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
            this.dataGridView1.Size = new System.Drawing.Size(634, 392);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbltotalDistanceCovered
            // 
            this.lbltotalDistanceCovered.AutoSize = true;
            this.lbltotalDistanceCovered.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbltotalDistanceCovered.Location = new System.Drawing.Point(686, 217);
            this.lbltotalDistanceCovered.Name = "lbltotalDistanceCovered";
            this.lbltotalDistanceCovered.Size = new System.Drawing.Size(119, 13);
            this.lbltotalDistanceCovered.TabIndex = 15;
            this.lbltotalDistanceCovered.Text = "Total Distance Covered";
            // 
            // lblAverageSpeed
            // 
            this.lblAverageSpeed.AutoSize = true;
            this.lblAverageSpeed.Location = new System.Drawing.Point(686, 242);
            this.lblAverageSpeed.Name = "lblAverageSpeed";
            this.lblAverageSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAverageSpeed.Size = new System.Drawing.Size(81, 13);
            this.lblAverageSpeed.TabIndex = 16;
            this.lblAverageSpeed.Text = "Average Speed";
            // 
            // lblmaxSpeed
            // 
            this.lblmaxSpeed.AutoSize = true;
            this.lblmaxSpeed.Location = new System.Drawing.Point(686, 269);
            this.lblmaxSpeed.Name = "lblmaxSpeed";
            this.lblmaxSpeed.Size = new System.Drawing.Size(85, 13);
            this.lblmaxSpeed.TabIndex = 17;
            this.lblmaxSpeed.Text = "Maximum Speed";
            // 
            // lblaverageHeartRate
            // 
            this.lblaverageHeartRate.AutoSize = true;
            this.lblaverageHeartRate.Location = new System.Drawing.Point(686, 292);
            this.lblaverageHeartRate.Name = "lblaverageHeartRate";
            this.lblaverageHeartRate.Size = new System.Drawing.Size(131, 13);
            this.lblaverageHeartRate.TabIndex = 18;
            this.lblaverageHeartRate.Text = "Average Heart Rate (bpm)";
            // 
            // lblmaximumHeartRate
            // 
            this.lblmaximumHeartRate.AutoSize = true;
            this.lblmaximumHeartRate.Location = new System.Drawing.Point(685, 317);
            this.lblmaximumHeartRate.Name = "lblmaximumHeartRate";
            this.lblmaximumHeartRate.Size = new System.Drawing.Size(135, 13);
            this.lblmaximumHeartRate.TabIndex = 19;
            this.lblmaximumHeartRate.Text = "Maximum Heart Rate (bpm)";
            this.lblmaximumHeartRate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblminHeartRate
            // 
            this.lblminHeartRate.AutoSize = true;
            this.lblminHeartRate.Location = new System.Drawing.Point(686, 341);
            this.lblminHeartRate.Name = "lblminHeartRate";
            this.lblminHeartRate.Size = new System.Drawing.Size(134, 13);
            this.lblminHeartRate.TabIndex = 20;
            this.lblminHeartRate.Text = "Mimimum Heart Rate (bpm)";
            // 
            // lblaveragePower
            // 
            this.lblaveragePower.AutoSize = true;
            this.lblaveragePower.Location = new System.Drawing.Point(686, 363);
            this.lblaveragePower.Name = "lblaveragePower";
            this.lblaveragePower.Size = new System.Drawing.Size(114, 13);
            this.lblaveragePower.TabIndex = 21;
            this.lblaveragePower.Text = "Average Power (watts)";
            // 
            // lblmaxPower
            // 
            this.lblmaxPower.AutoSize = true;
            this.lblmaxPower.Location = new System.Drawing.Point(686, 387);
            this.lblmaxPower.Name = "lblmaxPower";
            this.lblmaxPower.Size = new System.Drawing.Size(118, 13);
            this.lblmaxPower.TabIndex = 22;
            this.lblmaxPower.Text = "Maximum Power (watts)";
            // 
            // lblaverageAltitude
            // 
            this.lblaverageAltitude.AutoSize = true;
            this.lblaverageAltitude.Location = new System.Drawing.Point(686, 410);
            this.lblaverageAltitude.Name = "lblaverageAltitude";
            this.lblaverageAltitude.Size = new System.Drawing.Size(113, 13);
            this.lblaverageAltitude.TabIndex = 23;
            this.lblaverageAltitude.Text = "Average Altitude (m/ft)";
            // 
            // lblmaximumAltitude
            // 
            this.lblmaximumAltitude.AutoSize = true;
            this.lblmaximumAltitude.Location = new System.Drawing.Point(686, 435);
            this.lblmaximumAltitude.Name = "lblmaximumAltitude";
            this.lblmaximumAltitude.Size = new System.Drawing.Size(117, 13);
            this.lblmaximumAltitude.TabIndex = 24;
            this.lblmaximumAltitude.Text = "Maximum Altitude (m/ft)";
            // 
            // btnviewgraph
            // 
            this.btnviewgraph.Location = new System.Drawing.Point(395, 27);
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
            this.button3.Location = new System.Drawing.Point(496, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 25);
            this.button3.TabIndex = 30;
            this.button3.Text = "Compare File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(571, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Result";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnindividualform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 506);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnviewgraph);
            this.Controls.Add(this.lblmaximumAltitude);
            this.Controls.Add(this.lblaverageAltitude);
            this.Controls.Add(this.lblmaxPower);
            this.Controls.Add(this.lblaveragePower);
            this.Controls.Add(this.lblminHeartRate);
            this.Controls.Add(this.lblmaximumHeartRate);
            this.Controls.Add(this.lblaverageHeartRate);
            this.Controls.Add(this.lblmaxSpeed);
            this.Controls.Add(this.lblAverageSpeed);
            this.Controls.Add(this.lbltotalDistanceCovered);
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
        private System.Windows.Forms.Label lbltotalDistanceCovered;
        private System.Windows.Forms.Label lblAverageSpeed;
        private System.Windows.Forms.Label lblmaxSpeed;
        private System.Windows.Forms.Label lblaverageHeartRate;
        private System.Windows.Forms.Label lblmaximumHeartRate;
        private System.Windows.Forms.Label lblminHeartRate;
        private System.Windows.Forms.Label lblaveragePower;
        private System.Windows.Forms.Label lblmaxPower;
        private System.Windows.Forms.Label lblaverageAltitude;
        private System.Windows.Forms.Label lblmaximumAltitude;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnviewgraph;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

