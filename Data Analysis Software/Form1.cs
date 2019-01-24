using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Data_Analysis_Software.Action;

namespace Data_Analysis_Software
{
    public partial class btnindividualform : Form
    {

        private int count = 0;
        private Dictionary<string, List<string>> _hrData = new Dictionary<string, List<string>>();
        private Dictionary<string, string> _param = new Dictionary<string, string>();
        private List<int> smode = new List<int>();
        private FileConvertor c = new FileConvertor();

        public btnindividualform()
        {
            InitializeComponent();
            GridFormat();
            dataGridView1.MultiSelect = true;
        }


        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                //_param = new Dictionary<string, string>();
                //_hrData = new Dictionary<string, List<string>>();
                string text = File.ReadAllText(openFileDialog1.FileName);
                Dictionary<string, object> hrData = new TableFiller().FillTable(text, dataGridView1);
                _hrData = hrData.ToDictionary(k => k.Key, k => k.Value as List<string>);


                //var splittedString = SplitData(text);
                //var splittedParaData = SplitDataByEnter(splittedString[0]);
                /*foreach (var data in splittedParaData)
                {
                    if (data != "\r")
                    {
                        string[] parts = data.Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                        _param.Add(parts[0], parts[1]);
                    }
                }*/

                /*DateTime date1 = new DateTime(Convert.ToInt64(_param["Date"]));
                CultureInfo ci = CultureInfo.InvariantCulture;
                */
                /* foreach (var a in _parameter)
                 {
                     Console.WriteLine(a.Key);
                 }*/
                //StreamReader sr = new StreamReader(Application.StartupPath +);
                //richTextBox2.Text = sr.ReadToEnd();
                //sr.Close();

                /*labelstarttime.Text = labelstarttime.Text + "= " + _param["StartTime"];
                labelinterval.Text = labelinterval.Text + "= " + Regex.Replace(_param["Interval"], @"\t|\n|\r", "") + " sec";
                labelmonitor.Text = labelmonitor.Text + "= " + _param["Monitor"];
                labelsmode.Text = labelsmode.Text + "= " + _param["SMode"];
                labeldate.Text = labeldate.Text + "= " + ConvertToDate(_param["Date"]);
                labellength.Text = labellength.Text + "= " + _param["Length"];
                labelweight.Text = labelweight.Text + "= " + Regex.Replace(_param["Weight"], @"\t|\n|\r", "") + " kg";
                */

                var param = hrData["params"] as Dictionary<string, string>;
                //smode is declared and used in the system 
                var sMode = _param["SMode"];
                for (int i = 0; i < sMode.Length; i++)
                {
                    smode.Add((int)Char.GetNumericValue(_param["SMode"][i]));
                }
                /*
                List<string> cadence = new List<string>();
                List<string> altitude = new List<string>();
                List<string> heartRate = new List<string>();
                List<string> watt = new List<string>();
                List<string> speed = new List<string>();
                
                //displaying data in data grid.
                var splittedHrData = SplitDataByEnter(splittedString[11]);
                DateTime dateTime = DateTime.Parse(_param["StartTime"]);

                int temp = 0;
                */
                /*foreach (var data in splittedHrData)
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

                        if (temp > 2) dateTime = dateTime.AddSeconds(Convert.ToInt32(_param["Interval"]));
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


                _hrData.Add("cadence", cadence);
                _hrData.Add("altitude", altitude);
                _hrData.Add("heartRate", heartRate);
                _hrData.Add("watt", watt);
                _hrData.Add("speed", speed);
                */
                //smode is checked from the smode given in the file.
                for (int i = 0; i < sMode.Length; i++)
                {
                    smode.Add((int)Char.GetNumericValue(param["SMode"][i]));
                }
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
                /*double startDate = TimeSpan.Parse(_param["StartTime"]).TotalSeconds;
                double endDate = TimeSpan.Parse(endTime).TotalSeconds;
                double totalTime = endDate - startDate;

                string averageSpeed = Summary.FindAverage(_hrData["cadence"]).ToString();
                lblAverageSpeed.Text = "Average Speed = " + averageSpeed;

                string totalDistanceCovered = (Convert.ToDouble(averageSpeed) * totalTime).ToString();
                lbltotalDistanceCovered.Text = "Total Distance Cover = " + totalDistanceCovered;

                string maxSpeed = Summary.FindMax(_hrData["cadence"]).ToString();
                lblmaxSpeed.Text = "Maximum Speed = " + maxSpeed;

                string averageHeartRate = Summary.FindAverage(_hrData["heartRate"]).ToString();
                lblaverageHeartRate.Text = "Average heart Rate (bpm)= " + averageHeartRate;
                string maximumHeartRate = Summary.FindMax(_hrData["heartRate"]).ToString();
                lblmaximumHeartRate.Text = "MAximum Heart Rate (bpm) = " + maximumHeartRate;
                string minHeartRate = Summary.FindMin(_hrData["heartRate"]).ToString();
                lblminHeartRate.Text = "Mimimum Heart Rate (bpm)= " + minHeartRate;

                string averagePower = Summary.FindAverage(_hrData["watt"]).ToString();
                lblaveragePower.Text = "Average Power (watts) = " + averagePower;
                string maxPower = Summary.FindMax(_hrData["watt"]).ToString();
                lblmaxPower.Text = "MAximum Power (watts) = " + maxPower;

                string averageAltitude = Summary.FindAverage(_hrData["altitude"]).ToString();
                lblaverageAltitude.Text = "Average Altitude (m/ft) = " + averageAltitude;
                string maximumAltitude = Summary.FindAverage(_hrData["altitude"]).ToString();
                lblmaximumAltitude.Text = "MAximum Altitude (m/ft) = " + maximumAltitude;
                */
            }
        }
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

        private void btnviewgraph_Click(object sender, EventArgs e)
        {
            if (_hrData.Count < 1)
            {
                MessageBox.Show("Must select a file first");
            }
            else
            {
                GraphViewer._hrData = _hrData;
                new GraphViewer().Show();
            }
        }

        //calculate speed according to the user choice (KM / Miles)
        private void CalculateSpeed(string type)
        {
            if (_hrData.Count > 0)
            {
                List<string> data = new List<string>();
                if (type == "mile")
                {
                    dataGridView1.Columns[4].Name = "Speed(Mile/hr)";

                    data.Clear();

                    for (int i = 0; i < _hrData["cadence"].Count; i++)
                    {
                        string temp = (Convert.ToDouble(_hrData["speed"][i]) * 1.60934).ToString();
                        data.Add(temp);
                    }

                    //_hrData["speed"].Clear();
                    _hrData["speed"] = data;

                    dataGridView1.Rows.Clear();
                    DateTime dateTime = DateTime.Parse(_param["StartTime"]);
                    for (int i = 0; i < _hrData["cadence"].Count; i++)
                    {
                        if (i > 0) dateTime = dateTime.AddSeconds(Convert.ToInt32(_param["Interval"]));
                        string[] hrData = new string[] { _hrData["cadence"][i], _hrData["altitude"][i], _hrData["heartRate"][i], _hrData["watt"][i], _hrData["speed"][i], dateTime.TimeOfDay.ToString() };
                        dataGridView1.Rows.Add(hrData);
                    }
                }
                else
                {
                    dataGridView1.Columns[4].Name = "Speed(km/hr)";

                    data.Clear();
                    for (int i = 0; i < _hrData["cadence"].Count; i++)
                    {
                        string temp = (Convert.ToDouble(_hrData["speed"][i]) / 1.60934).ToString();
                        data.Add(temp);
                    }

                    //_hrData["speed"].Clear();
                    _hrData["speed"] = data;

                    dataGridView1.Rows.Clear();

                    DateTime dateTime = DateTime.Parse(_param["StartTime"]);
                    for (int i = 0; i < _hrData["cadence"].Count; i++)
                    {
                        if (i > 0) dateTime = dateTime.AddSeconds(Convert.ToInt32(_param["Interval"]));
                        string[] hrData = new string[] { _hrData["cadence"][i], _hrData["altitude"][i], _hrData["heartRate"][i], _hrData["watt"][i], _hrData["speed"][i], dateTime.TimeOfDay.ToString() };
                        dataGridView1.Rows.Add(hrData);
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count > 1) CalculateSpeed("mile");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalculateSpeed("km");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FileCompare().Show();
        }
        


        //spliting the data according to their heading
        /*private static string[] SplitData(string text)
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
        
         */



        // display the selected data in list view.
        
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        
        private Dictionary<string, object> data = new Dictionary<string, object>();
        List<string> listCadence = new List<string>();
        List<string> listAltitude = new List<string>();
        List<string> listHeartRate = new List<string>();
        List<string> listPower = new List<string>();
        List<string> listSpeed = new List<string>();
        List<string> listTime = new List<string>();
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            int index = Convert.ToInt32(e.Row.Index.ToString());

            string cadence = dataGridView1.Rows[index].Cells[0].Value.ToString();
            listCadence.Add(cadence);

            //_hrData.Add("cadence", new List());
            string altitude = dataGridView1.Rows[index].Cells[1].Value.ToString();
            listAltitude.Add(altitude);

            string heartRate = dataGridView1.Rows[index].Cells[2].Value.ToString();
            listHeartRate.Add(heartRate);

            string power = dataGridView1.Rows[index].Cells[3].Value.ToString();
            listPower.Add(power);

            string speed = dataGridView1.Rows[index].Cells[4].Value.ToString();
            listSpeed.Add(speed);

            string time = dataGridView1.Rows[index].Cells[5].Value.ToString();
            listTime.Add(time);

            Console.WriteLine(cadence + "/" + altitude + "/" + heartRate + "/" + power + "/" + speed + "/" + time);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data.Add("cadence", listCadence);
            data.Add("altitude", listAltitude);
            data.Add("heartRate", listHeartRate);
            data.Add("watt", listPower);
            data.Add("speed", listSpeed);
            data.Add("time", listTime);

            var endTime = data["time"] as List<string>;
            int count = endTime.Count();
            Dictionary<string, string> _param = new Dictionary<string, string>();
            _param.Add("StartTime", endTime[0]);

            //dataGridView2.Rows.Clear();
            //dataGridView2.Rows.Add(new TableFiller().FillDataInSumaryTable(data, endTime[count - 1], _param));

        }
    }
}