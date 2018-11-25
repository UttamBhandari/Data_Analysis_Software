using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Analysis_Software
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> _HRdata = new Dictionary<string, List<string>>();
        private Dictionary<string, string> _parameter = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            GridFormat();
        }
        private static string[] SplitData(string text)
        {


            var split = new string[] { "[Params]", "[Note]", "[IntTimes]",
                "[IntNotes]", "[ExtraData]", "[LapNames]", "[Summary-123]",
                "[Summary-TH]", "[HRZones]", "[SwapTimes]", "[Trip]", "[HRData]" };
            var splitted = text.Split(split, StringSplitOptions.RemoveEmptyEntries);
            return splitted;

        }
        private string[] SplitStringBySpace(string text)
        {
            var TextFormatted = string.Join(" ", text.Split().Where(x => x != ""));
            return TextFormatted.Split(' ');
        }
        private static string[] SplitDataByEnter(string text)
        {
            return text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                _parameter = new Dictionary<string, string>();
                string text = File.ReadAllText(openFileDialog1.FileName);
                var splittedString = SplitData(text);
                var splittedParaData = SplitDataByEnter(splittedString[0]);
                foreach (var data in splittedParaData)
                {
                    if (data != "\r")
                    {
                        string[] parts = data.Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                        _parameter.Add(parts[0], parts[1]);
                    }
                }
               /* foreach (var a in _parameter)
                {
                    Console.WriteLine(a.Key);
                }*/
                //StreamReader sr = new StreamReader(Application.StartupPath +);
                //richTextBox2.Text = sr.ReadToEnd();
                //sr.Close();
                labelstarttime.Text = labelstarttime.Text + "= " + _parameter["StartTime"];
                labelinterval.Text = labelinterval.Text + "= " + _parameter["Interval"];
                labelmonitor.Text = labelmonitor.Text + "= " + _parameter["Monitor"];
                labelsmode.Text = labelsmode.Text + "= " + _parameter["SMode"];
                labeldate.Text = labeldate.Text + "= " + _parameter["Date"];
                labellength.Text = labellength.Text + "= " + _parameter["Length"];
                labelweight.Text = labelweight.Text + "= " + _parameter["Weight"];

                List<string> cadence = new List<string>();
                List<string> altitude = new List<string>();
                List<string>heartRate = new List<string>();
                List<string> watt = new List<string>();


                //displaying data in data grid.
                var splittedHrData = SplitDataByEnter(splittedString[11]);
                foreach (var data in splittedHrData)
                {
                    var value = SplitStringBySpace(data);

                    if (value.Length >= 4)
                    {
                        cadence.Add(value[0]);
                        altitude.Add(value[1]);
                        heartRate.Add(value[2]);
                        watt.Add(value[3]);

                        string[] HRdata = new string[] { value[0], value[1], value[2], value[3] };
                        dataGridView1.Rows.Add(HRdata);
                    }
                }


                _HRdata.Add("cadence", cadence);
                _HRdata.Add("altitude", altitude);
                _HRdata.Add("heartRate", heartRate);
                _HRdata.Add("watt", watt);

                string totalDistanceCovered = Abstract.FindSum(_HRdata["cadence"]).ToString();
                string averageSpeed = Abstract.FindAverage(_HRdata["cadence"]).ToString();
                string maxSpeed = Abstract.FindMax(_HRdata["cadence"]).ToString();

                string averageHeartRate = Abstract.FindAverage(_HRdata["heartRate"]).ToString();
                string maximumHeartRate = Abstract.FindMax(_HRdata["heartRate"]).ToString();
                string minHeartRate = Abstract.FindMin(_HRdata["heartRate"]).ToString();

                string averagePower = Abstract.FindAverage(_HRdata["watt"]).ToString();
                string maxPower = Abstract.FindMax(_HRdata["watt"]).ToString();

                string averageAltitude = Abstract.FindAverage(_HRdata["altitude"]).ToString();
                string maximumAltitude = Abstract.FindAverage(_HRdata["altitude"]).ToString();
                


            }
        }

        private void GridFormat()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Cadence";
            dataGridView1.Columns[1].Name = "Altitude";
            dataGridView1.Columns[2].Name = "Heart rate";
            dataGridView1.Columns[3].Name = "Power in watts";
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
