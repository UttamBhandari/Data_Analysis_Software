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
            this.labelstarttime = new System.Windows.Forms.Label();
            this.labelweight = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.labellength = new System.Windows.Forms.Label();
            this.labelsmode = new System.Windows.Forms.Label();
            this.labelmonitor = new System.Windows.Forms.Label();
            this.labelinterval = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalDistanceCovered = new System.Windows.Forms.Label();
            this.averageSpeed = new System.Windows.Forms.Label();
            this.maxSpeed = new System.Windows.Forms.Label();
            this.averageHeartRate = new System.Windows.Forms.Label();
            this.maximumHeartRate = new System.Windows.Forms.Label();
            this.minHeartRate = new System.Windows.Forms.Label();
            this.averagePower = new System.Windows.Forms.Label();
            this.maxPower = new System.Windows.Forms.Label();
            this.averageAltitude = new System.Windows.Forms.Label();
            this.maximumAltitude = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.exitToolStripMenuItem});
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
            // labelstarttime
            // 
            this.labelstarttime.AutoSize = true;
            this.labelstarttime.Location = new System.Drawing.Point(519, 35);
            this.labelstarttime.Name = "labelstarttime";
            this.labelstarttime.Size = new System.Drawing.Size(55, 13);
            this.labelstarttime.TabIndex = 3;
            this.labelstarttime.Text = "Start Time";
            // 
            // labelweight
            // 
            this.labelweight.AutoSize = true;
            this.labelweight.Location = new System.Drawing.Point(522, 174);
            this.labelweight.Name = "labelweight";
            this.labelweight.Size = new System.Drawing.Size(41, 13);
            this.labelweight.TabIndex = 13;
            this.labelweight.Text = "Weight";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(521, 128);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(30, 13);
            this.labeldate.TabIndex = 12;
            this.labeldate.Text = "Date";
            // 
            // labellength
            // 
            this.labellength.AutoSize = true;
            this.labellength.Location = new System.Drawing.Point(522, 151);
            this.labellength.Name = "labellength";
            this.labellength.Size = new System.Drawing.Size(40, 13);
            this.labellength.TabIndex = 10;
            this.labellength.Text = "Length";
            // 
            // labelsmode
            // 
            this.labelsmode.AutoSize = true;
            this.labelsmode.Location = new System.Drawing.Point(521, 105);
            this.labelsmode.Name = "labelsmode";
            this.labelsmode.Size = new System.Drawing.Size(41, 13);
            this.labelsmode.TabIndex = 11;
            this.labelsmode.Text = "SMode";
            // 
            // labelmonitor
            // 
            this.labelmonitor.AutoSize = true;
            this.labelmonitor.Location = new System.Drawing.Point(520, 82);
            this.labelmonitor.Name = "labelmonitor";
            this.labelmonitor.Size = new System.Drawing.Size(42, 13);
            this.labelmonitor.TabIndex = 9;
            this.labelmonitor.Text = "Monitor";
            // 
            // labelinterval
            // 
            this.labelinterval.AutoSize = true;
            this.labelinterval.Location = new System.Drawing.Point(520, 58);
            this.labelinterval.Name = "labelinterval";
            this.labelinterval.Size = new System.Drawing.Size(42, 13);
            this.labelinterval.TabIndex = 8;
            this.labelinterval.Text = "Interval";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 415);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // totalDistanceCovered
            // 
            this.totalDistanceCovered.AutoSize = true;
            this.totalDistanceCovered.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalDistanceCovered.Location = new System.Drawing.Point(519, 219);
            this.totalDistanceCovered.Name = "totalDistanceCovered";
            this.totalDistanceCovered.Size = new System.Drawing.Size(119, 13);
            this.totalDistanceCovered.TabIndex = 15;
            this.totalDistanceCovered.Text = "Total Distance Covered";
            // 
            // averageSpeed
            // 
            this.averageSpeed.AutoSize = true;
            this.averageSpeed.Location = new System.Drawing.Point(519, 244);
            this.averageSpeed.Name = "averageSpeed";
            this.averageSpeed.Size = new System.Drawing.Size(81, 13);
            this.averageSpeed.TabIndex = 16;
            this.averageSpeed.Text = "Average Speed";
            // 
            // maxSpeed
            // 
            this.maxSpeed.AutoSize = true;
            this.maxSpeed.Location = new System.Drawing.Point(519, 271);
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(85, 13);
            this.maxSpeed.TabIndex = 17;
            this.maxSpeed.Text = "Maximum Speed";
            // 
            // averageHeartRate
            // 
            this.averageHeartRate.AutoSize = true;
            this.averageHeartRate.Location = new System.Drawing.Point(519, 294);
            this.averageHeartRate.Name = "averageHeartRate";
            this.averageHeartRate.Size = new System.Drawing.Size(102, 13);
            this.averageHeartRate.TabIndex = 18;
            this.averageHeartRate.Text = "Average Heart Rate";
            // 
            // maximumHeartRate
            // 
            this.maximumHeartRate.AutoSize = true;
            this.maximumHeartRate.Location = new System.Drawing.Point(518, 319);
            this.maximumHeartRate.Name = "maximumHeartRate";
            this.maximumHeartRate.Size = new System.Drawing.Size(106, 13);
            this.maximumHeartRate.TabIndex = 19;
            this.maximumHeartRate.Text = "Maximum Heart Rate";
            this.maximumHeartRate.Click += new System.EventHandler(this.label1_Click);
            // 
            // minHeartRate
            // 
            this.minHeartRate.AutoSize = true;
            this.minHeartRate.Location = new System.Drawing.Point(519, 343);
            this.minHeartRate.Name = "minHeartRate";
            this.minHeartRate.Size = new System.Drawing.Size(105, 13);
            this.minHeartRate.TabIndex = 20;
            this.minHeartRate.Text = "Mimimum Heart Rate";
            // 
            // averagePower
            // 
            this.averagePower.AutoSize = true;
            this.averagePower.Location = new System.Drawing.Point(519, 365);
            this.averagePower.Name = "averagePower";
            this.averagePower.Size = new System.Drawing.Size(80, 13);
            this.averagePower.TabIndex = 21;
            this.averagePower.Text = "Average Power";
            // 
            // maxPower
            // 
            this.maxPower.AutoSize = true;
            this.maxPower.Location = new System.Drawing.Point(519, 389);
            this.maxPower.Name = "maxPower";
            this.maxPower.Size = new System.Drawing.Size(84, 13);
            this.maxPower.TabIndex = 22;
            this.maxPower.Text = "Maximum Power";
            // 
            // averageAltitude
            // 
            this.averageAltitude.AutoSize = true;
            this.averageAltitude.Location = new System.Drawing.Point(519, 412);
            this.averageAltitude.Name = "averageAltitude";
            this.averageAltitude.Size = new System.Drawing.Size(85, 13);
            this.averageAltitude.TabIndex = 23;
            this.averageAltitude.Text = "Average Altitude";
            // 
            // maximumAltitude
            // 
            this.maximumAltitude.AutoSize = true;
            this.maximumAltitude.Location = new System.Drawing.Point(519, 437);
            this.maximumAltitude.Name = "maximumAltitude";
            this.maximumAltitude.Size = new System.Drawing.Size(89, 13);
            this.maximumAltitude.TabIndex = 24;
            this.maximumAltitude.Text = "Maximum Altitude";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 470);
            this.Controls.Add(this.maximumAltitude);
            this.Controls.Add(this.averageAltitude);
            this.Controls.Add(this.maxPower);
            this.Controls.Add(this.averagePower);
            this.Controls.Add(this.minHeartRate);
            this.Controls.Add(this.maximumHeartRate);
            this.Controls.Add(this.averageHeartRate);
            this.Controls.Add(this.maxSpeed);
            this.Controls.Add(this.averageSpeed);
            this.Controls.Add(this.totalDistanceCovered);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label totalDistanceCovered;
        private System.Windows.Forms.Label averageSpeed;
        private System.Windows.Forms.Label maxSpeed;
        private System.Windows.Forms.Label averageHeartRate;
        private System.Windows.Forms.Label maximumHeartRate;
        private System.Windows.Forms.Label minHeartRate;
        private System.Windows.Forms.Label averagePower;
        private System.Windows.Forms.Label maxPower;
        private System.Windows.Forms.Label averageAltitude;
        private System.Windows.Forms.Label maximumAltitude;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

