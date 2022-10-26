using Statistics.Core.RandomNumbers;
using Statistics.Core.Distributions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Statistics.WinformsUI
{
    public partial class frmUniformDistribution : Form
    {
        #region Private Fields

        private int _iterationNumber;
        private double _inputMinimum;
        private double _inputMaximum;

        private List<double> _randomNumberList;
        private List<double> _pdfList;
        private List<double> _cdfList;

        #endregion

        #region Constructor

        public frmUniformDistribution()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void Run()
        {
            _randomNumberList = new List<double>();
            _pdfList = new List<double>();
            _cdfList = new List<double>();

            lstbxRandomNumbers.DataSource = null;
            lstbxUniformPDF.DataSource = null;
            lstbxUniformCDF.DataSource = null;

            GetInputs();

            _randomNumberList = RandomNumberGenerator.GetListOfUniformlyDistributedRandomNumbers(_iterationNumber, _inputMinimum, _inputMaximum);
            _pdfList = ContinousUniformDistribution.GetListOfPDF(_inputMinimum, _inputMaximum, _randomNumberList);

            if (chckbxDisplayOutputs.Checked)
            {
                lstbxRandomNumbers.DataSource = _randomNumberList;
                lstbxUniformPDF.DataSource = _pdfList;

            }

            GetStatistics();
            DisplayHistogram();
            DisplayPDF();

        }

        private void GetInputs()
        {
            _iterationNumber = Convert.ToInt32(txtbxIterationNumber.Text);
            _inputMinimum = Convert.ToDouble(txtbxMinimum.Text);
            _inputMaximum = Convert.ToDouble(txtbxMaximum.Text);
        }

        private void GetStatistics()
        {
            lblMinimum.Text = _randomNumberList.Min().ToString();
            lblMaximum.Text = _randomNumberList.Max().ToString();
        }

        private void DisplayHistogram()
        {
            chrtRandomNumbers.Series.Clear();
            chrtRandomNumbers.Series.Add("RandomNumbers");

            chrtRandomNumbers.Series["RandomNumbers"].ChartType = SeriesChartType.Column;
            chrtRandomNumbers.Series["RandomNumbers"].BorderWidth = 1;
            chrtRandomNumbers.Series["RandomNumbers"].BorderColor = Color.White;
            chrtRandomNumbers.Series[0]["PointWidth"] = "1";

            chrtRandomNumbers.ChartAreas[0].AxisX.Minimum = _inputMinimum;
            chrtRandomNumbers.ChartAreas[0].AxisX.Maximum = _inputMaximum;

            chrtRandomNumbers.ChartAreas[0].AxisX.Title = "Value";
            chrtRandomNumbers.ChartAreas[0].AxisY.Title = "Count";

            chrtRandomNumbers.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chrtRandomNumbers.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";

            chrtRandomNumbers.Legends.Clear();

            //Below code is to create histogram
            var totalBuckets = 50;
            var buckets = new int[totalBuckets];
            var min = _randomNumberList.Min();
            var max = _randomNumberList.Max();
            var bucketWidth = (max - min) / totalBuckets;

            for (int i = 0; i < _iterationNumber; i++)
            {
                var bucketIndex = (int)((_randomNumberList[i] - min) / bucketWidth);
                if (bucketIndex >= totalBuckets)
                    bucketIndex--;

                buckets[bucketIndex]++;
            }

            for (int i = 0; i < totalBuckets - 1; i++)
            {
                var x = (bucketWidth * (i + 1) + min);
                var y = buckets[i];

                chrtRandomNumbers.Series["RandomNumbers"].Points.AddXY(x, y);
            }
        }

        private void DisplayPDF()
        {
          
        }



        #region Helpers

        //Numeric only method for textboxes
        private void NumericOnlyTextbox(object Sender, KeyPressEventArgs E)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(E.KeyChar) && !char.IsDigit(E.KeyChar) && (E.KeyChar != '.'))
            {
                E.Handled = true;
            }

            // Allow decimal (float) numbers
            if ((E.KeyChar == '.') && ((Sender as TextBox).Text.IndexOf('.') > -1))
            {
                E.Handled = true;
            }
        }

        #endregion


    }
}
