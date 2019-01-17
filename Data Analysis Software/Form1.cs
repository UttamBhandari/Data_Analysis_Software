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
using System.Globalization;
using System.Text.RegularExpressions;

namespace Data_Analysis_Software
{
    public partial class btnindividualform : Form
    {

        private int count = 0;
        private Dictionary<string, List<string>> _HRdata = new Dictionary<string, List<string>>();
        private Dictionary<string, string> _parameter = new Dictionary<string, string>();
        private string endTime;
        private List<int> smode = new List<int>();

        public btnindividualform()
        {
            InitializeComponent();
            GridFormat();

        }
        //spliting the data according to their heading
        private static string[] SplitData(string text)
        {


            var split = new string[] { "[Params]", "[Note]", "[IntTimes]",
                "[IntNotes]", "[ExtraData]", "[LapNames]", "[Summary-123]",
                "[Summary-TH]", "[HRZones]", "[SwapTimes]", "[Trip]", "[HRData]" };
            var splitted = text.Split(split, StringSplitOptions.RemoveEmptyEntries);
            return splitted;

        }
        //split the data by space 
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
                Cursor.Current = Cursors.WaitCursor;
                _parameter = new Dictionary<string, string>();
                _HRdata = new Dictionary<string, List<string>>();
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

                DateTime date1 = new DateTime(Convert.ToInt64(_parameter["Date"]));
                CultureInfo ci = CultureInfo.InvariantCulture;

                /* foreach (var a in _parameter)
                 {
                     Console.WriteLine(a.Key);
                 }*/
                //StreamReader sr = new StreamReader(Application.StartupPath +);
                //richTextBox2.Text = sr.ReadToEnd();
                //sr.Close();
                labelstarttime.Text = labelstarttime.Text + "= " + _parameter["StartTime"];
                labelinterval.Text = labelinterval.Text + "= " + Regex.Replace(_parameter["Interval"], @"\t|\n|\r", "") + " sec";
                labelmonitor.Text = labelmonitor.Text + "= " + _parameter["Monitor"];
                labelsmode.Text = labelsmode.Text + "= " + _parameter["SMode"];
                labeldate.Text = labeldate.Text + "= " + ConvertToDate(_parameter["Date"]);
                labellength.Text = labellength.Text + "= " + _parameter["Length"];
                labelweight.Text = labelweight.Text + "= " + Regex.Replace(_parameter["Weight"], @"\t|\n|\r", "") + " kg";
                 
                //smode is declared and used in the system 
                var sMode = _parameter["SMode"];
                for (int i = 0; i < sMode.Length; i++)
                {
                    smode.Add((int)Char.GetNumericValue(_parameter["SMode"][i]));
                }

                List<string> cadence = new List<string>();
                List<string> altitude = new List<string>();
                List<string> heartRate = new List<string>();
                List<string> watt = new List<string>();
                List<string> speed = new List<string>();

                //displaying data in data grid.
                var splittedHrData = SplitDataByEnter(splittedString[11]);
                DateTime dateTime = DateTime.Parse(_parameter["StartTime"]);

                int temp = 0;
                foreach (var data in splittedHrData)
                {
                    temp++;
                    var value = SplitStringBySpace(data);

                    if (value.Length >= 5)
                    {
                        cadence.Add(value[0]);
                        altitude.Add(value[1]);
                        heartRate.Add(value[2]);
                        watt.Add(value[3]);
                        speed.Add(value[4]);

                        if (temp > 2) dateTime = dateTime.AddSeconds(Convert.ToInt32(_parameter["Interval"]));
                        endTime = dateTime.TimeOfDay.ToString();

                        //string[] HRdata = new string[] { value[0], value[1], value[2], value[3], value[4], dateTime.TimeOfDay.ToString() };
                        List<string> hrData = new List<string>();
                        hrData.Add(value[0]);
                        hrData.Add(value[1]);
                        hrData.Add(value[2]);
                        hrData.Add(value[3]);
                        hrData.Add(value[4]);
                        hrData.Add(dateTime.TimeOfDay.ToString());
                        dataGridView1.Rows.Add(hrData.ToArray());
                    }
                }


                _HRdata.Add("cadence", cadence);
                _HRdata.Add("altitude", altitude);
                _HRdata.Add("heartRate", heartRate);
                _HRdata.Add("watt", watt);
                _HRdata.Add("speed", speed);
                //smode is checked from the smode given in the file.
                if (smode[0] == 0)
                {
                    dataGridView1.Columns[0].Visible = false;
                }
                else if (smode[1] == 0)
                {
                    dataGridView1.Columns[1].Visible = false;
                }
                else if (smode[2] == 0)
                {
                    dataGridView1.Columns[2].Visible = false;
                }
                else if (smode[3] == 0)
                {
                    dataGridView1.Columns[3].Visible = false;
                }
                else if (smode[4] == 0)
                {
                    dataGridView1.Columns[4].Visible = false;
                }

                //to display value in label
                double startDate = TimeSpan.Parse(_parameter["StartTime"]).TotalSeconds;
                double endDate = TimeSpan.Parse(endTime).TotalSeconds;
                double totalTime = endDate - startDate;

                string averageSpeed = Abstract.FindAverage(_HRdata["cadence"]).ToString();
                lblAverageSpeed.Text = "Average Speed = " + averageSpeed;

                string totalDistanceCovered = (Convert.ToDouble(averageSpeed) * totalTime).ToString();
                lbltotalDistanceCovered.Text = "Total Distance Cover = " + totalDistanceCovered;
                
                string maxSpeed = Abstract.FindMax(_HRdata["cadence"]).ToString();
                lblmaxSpeed.Text = "Maximum Speed = " + maxSpeed;

                string averageHeartRate = Abstract.FindAverage(_HRdata["heartRate"]).ToString();
                lblaverageHeartRate.Text = "Average heart Rate (bpm)= " + averageHeartRate;
                string maximumHeartRate = Abstract.FindMax(_HRdata["heartRate"]).ToString();
                lblmaximumHeartRate.Text = "MAximum Heart Rate (bpm) = " + maximumHeartRate;
                string minHeartRate = Abstract.FindMin(_HRdata["heartRate"]).ToString();
                lblminHeartRate.Text = "Mimimum Heart Rate (bpm)= " + minHeartRate;

                string averagePower = Abstract.FindAverage(_HRdata["watt"]).ToString();
                lblaveragePower.Text = "Average Power (watts) = " + averagePower;
                string maxPower = Abstract.FindMax(_HRdata["watt"]).ToString();
                lblmaxPower.Text = "MAximum Power (watts) = " + maxPower;

                string averageAltitude = Abstract.FindAverage(_HRdata["altitude"]).ToString();
                lblaverageAltitude.Text = "Average Altitude (m/ft) = " + averageAltitude;
                string maximumAltitude = Abstract.FindAverage(_HRdata["altitude"]).ToString();
                lblmaximumAltitude.Text = "MAximum Altitude (m/ft) = " + maximumAltitude;

            }
        }
        // display the selected data in list view.
        private void GridFormat()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Cadence(rpm)";
            dataGridView1.Columns[1].Name = "Altitude(m/ft)";
            dataGridView1.Columns[2].Name = "Heart rate(bpm)";
            dataGridView1.Columns[3].Name = "Power(watts)";
            dataGridView1.Columns[4].Name = "Speed(Mile/hr)";
            dataGridView1.Columns[5].Name = "Time";
        }
        //calculate speed according to the user choice (KM / Miles)
        private void CalculateSpeed(string type)
        {
            if (_HRdata.Count > 0)
            {
                List<string> data = new List<string>();
                if (type == "mile")
                {
                    dataGridView1.Columns[4].Name = "Speed(Mile/hr)";

                    data.Clear();

                    for (int i = 0; i < _HRdata["cadence"].Count; i++)
                    {
                        string temp = (Convert.ToDouble(_HRdata["speed"][i]) * 1.60934).ToString();
                        data.Add(temp);
                    }

                    //_hrData["speed"].Clear();
                    _HRdata["speed"] = data;

                    dataGridView1.Rows.Clear();
                    DateTime dateTime = DateTime.Parse(_parameter["StartTime"]);
                    for (int i = 0; i < _HRdata["cadence"].Count; i++)
                    {
                        if (i > 0) dateTime = dateTime.AddSeconds(Convert.ToInt32(_parameter["Interval"]));
                        string[] hrData = new string[] { _HRdata["cadence"][i], _HRdata["altitude"][i], _HRdata["heartRate"][i], _HRdata["watt"][i], _HRdata["speed"][i], dateTime.TimeOfDay.ToString() };
                        dataGridView1.Rows.Add(hrData);
                    }
                }
                else
                {
                    dataGridView1.Columns[4].Name = "Speed(km/hr)";

                    data.Clear();
                    for (int i = 0; i < _HRdata["cadence"].Count; i++)
                    {
                        string temp = (Convert.ToDouble(_HRdata["speed"][i]) / 1.60934).ToString();
                        data.Add(temp);
                    }

                    //_hrData["speed"].Clear();
                    _HRdata["speed"] = data;

                    dataGridView1.Rows.Clear();

                    DateTime dateTime = DateTime.Parse(_parameter["StartTime"]);
                    for (int i = 0; i < _HRdata["cadence"].Count; i++)
                    {
                        if (i > 0) dateTime = dateTime.AddSeconds(Convert.ToInt32(_parameter["Interval"]));
                        string[] hrData = new string[] { _HRdata["cadence"][i], _HRdata["altitude"][i], _HRdata["heartRate"][i], _HRdata["watt"][i], _HRdata["speed"][i], dateTime.TimeOfDay.ToString() };
                        dataGridView1.Rows.Add(hrData);
                    }
                }
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnviewgraph_Click(object sender, EventArgs e)
        {
            if (_HRdata.Count < 1)
            {
                MessageBox.Show("Must select a file first");
            }
            else
            {
                GraphViewer._HRdata = _HRdata;
                new GraphViewer().Show();
            }
        }

        private string ConvertToDate(string date)
        {
            string year = "";
            string month = "";
            string day = "";

            for (int i = 0; i < 4; i++)
            {
                year = year + date[i];
            };

            for (int i = 4; i < 6; i++)
            {
                month = month + date[i];
            };

            for (int i = 6; i < 8; i++)
            {
                day = day + date[i];
            };

            string convertedDate = year + "-" + month + "-" + day;

            return convertedDate;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            if (_HRdata.Count < 1)
            {
                MessageBox.Show("Please select a file first");
            }
            else
            {
                individualGraph._HRdata = _HRdata;
                new individualGraph().Show();
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count > 1) CalculateSpeed("mile");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalculateSpeed("km");
        }
    }
}