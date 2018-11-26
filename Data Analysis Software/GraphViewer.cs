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
    public partial class GraphViewer : Form
    {
        public static List<string> _powerData;
        public GraphViewer()
        {
            InitializeComponent();
        }
        private void GraphViewer_Load(object sender, EventArgs e)
        {
            DrawGraph();
            Size();
        }
        private void DrawGraph()
        {
            GraphPane grpane = zedGraphControl1.GraphPane;
            // Set the Titles
            grpane.Title = "Team A vs Team B Goal Analysis for 2014/2015 Season";
            grpane.XAxis.Title = "Year";
            grpane.YAxis.Title = "No of Goals";


            PointPairList teamAPairList = new PointPairList();
            PointPairList teamBPairList = new PointPairList();

            for (int i = 0; i < 10; i++)
            {
                teamAPairList.Add(i, Convert.ToInt16(_powerData.ElementAt(i)));
                teamBPairList.Add(i, Convert.ToInt16(_powerData.ElementAt(i)) + 12);
            }
            LineItem teamACurve = grpane.AddCurve("Team A",
                   teamAPairList, Color.Red, SymbolType.Diamond);

            LineItem teamBCurve = grpane.AddCurve("Team B",
                  teamBPairList, Color.Blue, SymbolType.Circle);

            zedGraphControl1.AxisChange();
        }
        private void Size()
        {
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

        }
        private void GraphWindow_Resize(object sender, EventArgs e)
        {
            Size();
        }
        private int[] buildTeamAData()
        {
            int[] goalsScored = new int[10];
            for (int i = 0; i < 10; i++)
            {
                goalsScored[i] = (i + 1) * 10;
            }
            return goalsScored;
        }
        private int[] buildTeamBData()
        {
            int[] goalsScored = new int[10];
            for (int i = 0; i < 10; i++)
            {
                goalsScored[i] = (i + 10) * 11;
            }
            return goalsScored;
        }
    }
}
