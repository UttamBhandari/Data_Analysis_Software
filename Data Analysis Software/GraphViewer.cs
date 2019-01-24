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
    //graph for the system is displayed using this class
    public partial class GraphViewer : Form
    {
        public static Dictionary<string, List<string>> _hrData;
        
        //initialize  
        public GraphViewer()
        {
            InitializeComponent();
        }
        private void GraphViewer_Load(object sender, EventArgs e)
        {
            DrawGraph();
            SetSize();
        }
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

        }
        // button for inserting data from file
        private void button2_Click(object sender, EventArgs e)
        {
            if (_hrData.Count < 1)
            {
                MessageBox.Show("Please select a file first");
            }
            else
            {
                individualGraph._hrData = _hrData;
                new individualGraph().Show();
            }
        }
        //read the data inserted, and helps to display in graph.
        private void DrawGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the Titles
            myPane.Title = "Overview";
            myPane.XAxis.Title = "Time in second";
            myPane.YAxis.Title = "Data";

            

            PointPairList cadencePairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();
            PointPairList heartPairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();
            
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

            LineItem cadence = myPane.AddCurve("Cadence",
                   cadencePairList, Color.Blue, SymbolType.None);

            LineItem altitude = myPane.AddCurve("Altitude",
                  altitudePairList, Color.Violet, SymbolType.None);

            LineItem heart = myPane.AddCurve("Heart",
                   heartPairList, Color.Red, SymbolType.None);

            LineItem power = myPane.AddCurve("Power",
                  powerPairList, Color.Green, SymbolType.None);

            zedGraphControl1.AxisChange();
        }

        

        private void GraphWindow_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
