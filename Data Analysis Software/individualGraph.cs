using System;
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
        public static Dictionary<string, List<string>> _HRdata;
        public individualGraph()
        {
            InitializeComponent();
            drawGraph();
        }
        private void drawGraph()
        {

            GraphPane speedPane = zedGraphControl1.GraphPane;
            GraphPane heartRatePane = zedGraphControl2.GraphPane;
            GraphPane cadencePane = zedGraphControl3.GraphPane;
            GraphPane powerPane = zedGraphControl4.GraphPane; 


            // Set the Titles
            speedPane.Title = "Overview";
            speedPane.XAxis.Title = "Time in second";
            speedPane.YAxis.Title = "Data";

            heartRatePane.Title = "Overview";
            heartRatePane.XAxis.Title = "Time in second";
            heartRatePane.YAxis.Title = "Data";

            cadencePane.Title = "Overview";
            cadencePane.XAxis.Title = "Time in second";
            cadencePane.YAxis.Title = "Data";

            powerPane.Title = "Overview";
            powerPane.XAxis.Title = "Time in second";
            powerPane.YAxis.Title = "Data";

            PointPairList cadencePairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();
            PointPairList heartPairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();


            for (int i = 0; i < _HRdata["cadence"].Count; i++)
            {
                cadencePairList.Add(i, Convert.ToInt16(_HRdata["cadence"][i]));
            }

            for (int i = 0; i < _HRdata["altitude"].Count; i++)
            {
                altitudePairList.Add(i, Convert.ToInt16(_HRdata["altitude"][i]));
            }

            for (int i = 0; i < _HRdata["heartRate"].Count; i++)
            {
                heartPairList.Add(i, Convert.ToInt16(_HRdata["heartRate"][i]));
            }

            for (int i = 0; i < _HRdata["watt"].Count; i++)
            {
                powerPairList.Add(i, Convert.ToInt16(_HRdata["watt"][i]));
            }

            LineItem cadence = cadencePane.AddCurve("Cadence",
                   cadencePairList, Color.Blue, SymbolType.None);
            //cadence.Symbol.Fill = new Fill(new Color[] { Color.Blue, Color.Green, Color.Red });

            LineItem altitude = speedPane.AddCurve("Altitude",
                  altitudePairList, Color.Pink, SymbolType.None);

            LineItem heart = heartRatePane.AddCurve("Heart",
                   heartPairList, Color.Red, SymbolType.None);

            LineItem power = powerPane.AddCurve("Power",
                  powerPairList, Color.Green, SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl2.AxisChange();
            zedGraphControl3.AxisChange();
            zedGraphControl4.AxisChange();
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
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = true;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = true;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = true;
            zedGraphControl4.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = false;
            zedGraphControl2.Visible = false;
            zedGraphControl3.Visible = false;
            zedGraphControl4.Visible = true;
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
    }
}
