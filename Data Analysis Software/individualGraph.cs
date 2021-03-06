﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Data_Analysis_Software
{
    public partial class individualGraph : Form
    
    {
        //individual graph is shown
        public static Dictionary<string, List<string>> _hrData;
        public individualGraph()
        {
            InitializeComponent();
            drawGraph();
            this.CenterToScreen();

            zedGraphControl1.Visible = true;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = false;
            zedGraphControl5.Visible = false;

            this.radioButton2.Checked = true;

        }
        private void drawGraph()
        {

            GraphPane speedGraphPanel = zedGraphControl1.GraphPane;
            GraphPane heartRateGraphPanel = zedGraphControl2.GraphPane;
            GraphPane cadenceGraphPanel = zedGraphControl3.GraphPane;
            GraphPane powerGraphPanel = zedGraphControl4.GraphPane;
            GraphPane altituteGraphPanel = zedGraphControl5.GraphPane;

            // Set the Titles
            speedGraphPanel.Title = "Overview";
            speedGraphPanel.XAxis.Title = "Time in second";
            speedGraphPanel.YAxis.Title = "Data";

            heartRateGraphPanel.Title = "Overview";
            heartRateGraphPanel.XAxis.Title = "Time in second";
            heartRateGraphPanel.YAxis.Title = "Data";

            cadenceGraphPanel.Title = "Overview";
            cadenceGraphPanel.XAxis.Title = "Time in second";
            cadenceGraphPanel.YAxis.Title = "Data";

            powerGraphPanel.Title = "Overview";
            powerGraphPanel.XAxis.Title = "Time in second";
            powerGraphPanel.YAxis.Title = "Data";

            altituteGraphPanel.Title = "Altitute";
            altituteGraphPanel.XAxis.Title = "Time in second";
            altituteGraphPanel.YAxis.Title = "Data";


            PointPairList cadencePairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();
            PointPairList heartPairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();
            PointPairList speedPairList = new PointPairList();

            for (int i = 0; i < _hrData["cadence"].Count; i++)
            {
                cadencePairList.Add(i, Convert.ToInt16(_hrData["cadence"][i]));
            }

            for (int i = 0; i < _hrData["altitude"].Count; i++)
            {
                altitudePairList.Add(i, Convert.ToInt16(_hrData["altitude"][i]));
            }

            for (int i = 0; i < _hrData["heartRate"].Count; i++)
            {
                heartPairList.Add(i, Convert.ToInt16(_hrData["heartRate"][i]));
            }

            for (int i = 0; i < _hrData["watt"].Count; i++)
            {
                powerPairList.Add(i, Convert.ToInt16(_hrData["watt"][i]));
            }

            for (int i = 0; i < _hrData["heartRate"].Count; i++)
            {
                speedPairList.Add(i, Convert.ToInt16(_hrData["speed"][i]));
            }

            LineItem cadence = cadenceGraphPanel.AddCurve("Cadence",
                   cadencePairList, Color.Blue, SymbolType.None);
            //cadence.Symbol.Fill = new Fill(new Color[] { Color.Blue, Color.Green, Color.Red });

            LineItem altitude = speedGraphPanel.AddCurve("Altitude",
                  altitudePairList, Color.Pink, SymbolType.None);

            LineItem heart = heartRateGraphPanel.AddCurve("Heart",
                   heartPairList, Color.Red, SymbolType.None);

            LineItem power = powerGraphPanel.AddCurve("Power",
                  powerPairList, Color.Green, SymbolType.None);

            LineItem altitute = altituteGraphPanel.AddCurve("Altitute",
            altitudePairList, Color.Red, SymbolType.None);


            zedGraphControl1.AxisChange();
            zedGraphControl2.AxisChange();
            zedGraphControl3.AxisChange();
            zedGraphControl4.AxisChange();
            zedGraphControl5.AxisChange();
        }
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControl2.Location = new Point(0, 0);
            zedGraphControl2.IsShowPointValues = true;
            zedGraphControl2.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControl3.Location = new Point(0, 0);
            zedGraphControl3.IsShowPointValues = true;
            zedGraphControl3.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControl4.Location = new Point(0, 0);
            zedGraphControl4.IsShowPointValues = true;
            zedGraphControl4.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);


            zedGraphControl5.Location = new Point(0, 0);
            zedGraphControl5.IsShowPointValues = true;
            zedGraphControl5.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

        }
        // radio button is added in the system to view individual graph one by one
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = true;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = false;
            zedGraphControl5.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = true;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = false;
            zedGraphControl5.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = true;
            zedGraphControl4.Visible = false;
            zedGraphControl5.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = true;
            zedGraphControl5.Visible = false;
        }


        private void individualGraph_Load(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // radio button is added in the system to view individual graph one by one
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = true;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = false;
            zedGraphControl5.Visible = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = true;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = false;
            zedGraphControl5.Visible = false;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = true;
            zedGraphControl4.Visible = false;
            zedGraphControl5.Visible = false;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = true;
            zedGraphControl5.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = false;
            zedGraphControl5.Visible = true;
        }
    }
}
