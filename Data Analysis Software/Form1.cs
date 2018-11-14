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
        private Dictionary<string, string> _HRdata = new Dictionary<string, string>();
        private Dictionary<string, string> _parameter = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }
        private static string[] SplitData(string text)
        {


            var split = new string[] { "[Params]", "[Note]", "[IntTimes]",
                "[IntNotes]", "[ExtraData]", "[LapNames]", "[Summary-123]",
                "[Summary-TH]", "[HRZones]", "[SwapTimes]", "[Trip]", "[HRData]" };
            var splitted = text.Split(split, StringSplitOptions.RemoveEmptyEntries);
            return splitted;

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
                foreach (var a in _parameter)
                {
                    Console.WriteLine(a.Key);
                }
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
            }
        }
    }
}
