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
                string text = File.ReadAllText(openFileDialog1.FileName);
                Dictionary<string, object> hrData = new TableFiller().FillTable(text, dataGridView1);
                _hrData = hrData.ToDictionary(k => k.Key, k => k.Value as List<string>);

                var param = hrData["params"] as Dictionary<string, string>;
                //smode is declared and used in the system 
                var sMode = param["SMode"];
                for (int i = 0; i < sMode.Length; i++)
                {
                    smode.Add((int)Char.GetNumericValue(param["SMode"][i]));
                }
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
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(new TableFiller().FillDataInSumaryTable(hrData, hrData["endTime"] as string, hrData["params"] as Dictionary<string, string>));
                
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

            dataGridView2.ColumnCount = 10;
            dataGridView2.Columns[0].Name = "Total distance covered";
            dataGridView2.Columns[1].Name = "Average speed(km/hr)";
            dataGridView2.Columns[2].Name = "Maximum speed(km/hr)";
            dataGridView2.Columns[3].Name = "Average heart rate(bpm)";
            dataGridView2.Columns[4].Name = "Maximum heart rate(bpm)";
            dataGridView2.Columns[5].Name = "Minimum heart rate(bpm)";
            dataGridView2.Columns[6].Name = "Average power(watt)";
            dataGridView2.Columns[7].Name = "Maximum power(watt)";
            dataGridView2.Columns[8].Name = "Average altitude(RPM)";
            dataGridView2.Columns[9].Name = "Maximum altitude(RPM)";

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
        private Dictionary<string, object> data = new Dictionary<string, object>();
        List<string> listCadence = new List<string>();
        List<string> listAltitude = new List<string>();
        List<string> listHeartRate = new List<string>();
        List<string> listPower = new List<string>();
        List<string> listSpeed = new List<string>();
        List<string> listTime = new List<string>();
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (e.StateChanged != DataGridViewElementStates.Selected) return;
                int index = Convert.ToInt32(e.Row.Index.ToString());

                string cadence = dataGridView1.Rows[index].Cells[0].Value.ToString();
                listCadence.Add(cadence);

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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            data.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
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

                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(new TableFiller().FillDataInSumaryTable(data, endTime[count - 1], _param));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please click on reset button first");
            }
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            var data = _hrData.ToDictionary(k => k.Key, k => k.Value as object);
            new IntervalDetectionForm(data).Show();
        }




    }
}