using Dopamin.Statistics.Core.Distributions;
using Dopamin.Statistics.Core.RandomNumbers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dopamin.Statistics.WinformsUI
{
    public partial class frmLognormalDistribution : Form
    {
        #region Private Fields

        private int _iterationNumber;
        private double _inputMean;
        private double _inputStdDev; //Standard Deviation

        private List<double> _randomNumberList;
        private List<double> _pdfList;
        private List<double> _cdfList;

        #endregion

        #region Constructor

        public frmLognormalDistribution()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Load

        private void frmLognormalDistribution_Load(object sender, EventArgs e)
        {
            cmbbxIterationNumber.SelectedIndex = 1;
            chrtRandomNumbers.Legends.Clear();
            chrtPDF.Legends.Clear();
            chrtCDF.Legends.Clear();
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

        #region CheckBox

        private void chckbxDisplayOutputs_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxDisplayOutputs.Checked)
            {
                lblUniformRandomNumbers.Enabled = true;
                lblPDF.Enabled = true;
                lblUniformCDF.Enabled = true;

                lstbxRandomNumbers.Enabled = true;
                lstbxPDF.Enabled = true;
                lstbxCDF.Enabled = true;
            }
            else
            {
                lblUniformRandomNumbers.Enabled = false;
                lblPDF.Enabled = false;
                lblUniformCDF.Enabled = false;

                lstbxRandomNumbers.Enabled = false;
                lstbxPDF.Enabled = false;
                lstbxCDF.Enabled = false;

                lstbxRandomNumbers.DataSource = null;
                lstbxPDF.DataSource = null;
                lstbxCDF.DataSource = null;
            }
        }

        #endregion

        private void Run()
        {
            GetInputs();

            _randomNumberList = new List<double>();
            _pdfList = new List<double>();
            _cdfList = new List<double>();

            lstbxRandomNumbers.DataSource = null;
            lstbxPDF.DataSource = null;
            lstbxCDF.DataSource = null;

            GetOutputs();

            if (chckbxDisplayOutputs.Checked)
                PopulateListBoxes();

            GetStatistics();
            DisplayHistogram();
            DisplayPDF();
            DisplayCDF();
        }

        private void GetInputs()
        {
            _iterationNumber = Convert.ToInt32(cmbbxIterationNumber.SelectedItem.ToString());
            _inputMean = Convert.ToDouble(txtbxMean.Text);
            _inputStdDev = Convert.ToDouble(txtbxStdDev.Text);
        }

        private void GetOutputs()
        {
            _randomNumberList = RandomNumberGenerator.GetListOfLognormalDistributedRandomNumbers(_iterationNumber, _inputMean, _inputStdDev);
            _pdfList = LognormalDistribution.GetListOfPDF(_inputMean, _inputStdDev, _randomNumberList);
            _cdfList = LognormalDistribution.GetListOfCDF(_inputMean, _inputStdDev, _randomNumberList);
        }

        private void PopulateListBoxes()
        {
            var randomList = _randomNumberList.ToList();
            randomList.RemoveRange(1000, randomList.Count - 1000);

            var pdfList = _pdfList.ToList();
            pdfList.RemoveRange(1000, pdfList.Count - 1000);

            var cdfList = _cdfList.ToList();
            cdfList.RemoveRange(1000, cdfList.Count - 1000);

            lstbxRandomNumbers.DataSource = randomList;
            lstbxPDF.DataSource = pdfList;
            lstbxCDF.DataSource = cdfList;
        }

        private void GetStatistics()
        {
            //lblMean.Text = $"Mean: {Math.Round(NormalDistribution.GetMean(_inputMean), 2)}";
            //lblStandardError.Text = $"Standard Error: ";
            //lblMedian.Text = $"Median: {Math.Round(NormalDistribution.GetMedian(_inputMean), 2)}";
            //lblMode.Text = $"Mode: {Math.Round(NormalDistribution.GetMode(_inputMean), 2)}";
            //lblStandardDeviation.Text = $"Standard Deviation: {Math.Round(NormalDistribution.GetStandardDeviation(_inputStdDev), 2)}";
            //lblVariance.Text = $"Variance: {Math.Round(NormalDistribution.GetVariance(_inputStdDev), 2)}";
            lblKurtosis.Text = $"Kurtosis: ";
            lblSkewness.Text = $"Skewness: ";
            lblMinimum.Text = $"Minimum: {_randomNumberList.Min()}";
            lblMaximum.Text = $"Maximum: {_randomNumberList.Max()}";
            lblRange.Text = $"Range: {_randomNumberList.Min()} - {_randomNumberList.Max()}";
            lblTrials.Text = $"Trials: {_iterationNumber}";
        }

        private void DisplayHistogram()
        {
            chrtRandomNumbers.ChartAreas.Clear();
            chrtRandomNumbers.ChartAreas.Add(new ChartArea());
            chrtRandomNumbers.Series.Clear();
            chrtRandomNumbers.Series.Add("RandomNumbers");

            chrtRandomNumbers.Series["RandomNumbers"].ChartType = SeriesChartType.Column;
            chrtRandomNumbers.Series["RandomNumbers"].BorderWidth = 1;
            chrtRandomNumbers.Series["RandomNumbers"].BorderColor = Color.Black;
            chrtRandomNumbers.Series[0]["PointWidth"] = "1";

            chrtRandomNumbers.Legends.Clear();

            // *** Below code is to create histogram ***
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
            // *** ----- ***

            //chrtRandomNumbers.ChartAreas[0].AxisX.Minimum = _inputMean - (3 * _inputStdDev); ;
            //chrtRandomNumbers.ChartAreas[0].AxisX.Maximum = _inputMean + (3 * _inputStdDev);
            //chrtRandomNumbers.ChartAreas[0].AxisY.Minimum = 0;
            //chrtRandomNumbers.ChartAreas[0].AxisY.Maximum = buckets.Max();

            chrtRandomNumbers.ChartAreas[0].AxisX.Title = "Random Numbers";
            chrtRandomNumbers.ChartAreas[0].AxisY.Title = "Frequency";

            chrtRandomNumbers.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chrtRandomNumbers.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
        }

        private void DisplayPDF()
        {
            chrtPDF.Series.Clear();
            chrtPDF.Series.Add("RandomNumbers");
            chrtPDF.Series.Add("PDF");

            chrtPDF.Series["RandomNumbers"].ChartType = SeriesChartType.Column;
            chrtPDF.Series["RandomNumbers"].BorderWidth = 1;
            chrtPDF.Series["RandomNumbers"].BorderColor = Color.Black;
            chrtPDF.Series[0]["PointWidth"] = "1";
            chrtPDF.Series["RandomNumbers"].YAxisType = AxisType.Primary;

            chrtPDF.Series["PDF"].ChartType = SeriesChartType.StackedColumn;
            chrtPDF.Series["PDF"]["PointWidth"] = "1";
            chrtPDF.Series["PDF"].YAxisType = AxisType.Secondary;

            chrtPDF.ChartAreas[0].AxisY2.LineColor = Color.Transparent;
            chrtPDF.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;

            chrtPDF.ChartAreas[0].AxisX.Title = "Random Numbers";
            chrtPDF.ChartAreas[0].AxisY.Title = "Frequency";
            chrtPDF.ChartAreas[0].AxisY2.Title = "PDF";

            chrtPDF.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chrtPDF.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
            chrtPDF.ChartAreas[0].AxisY2.LabelStyle.Format = "0.00";

            chrtPDF.Legends.Clear();

            // *** Below code is to create histogram ***
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

                chrtPDF.Series["RandomNumbers"].Points.AddXY(x, y);
            }

            chrtPDF.Series["PDF"].Points.AddXY(_randomNumberList.Min(), buckets.Min());
            // *** ----- ***

            //chrtPDF.ChartAreas[0].AxisX.Minimum = _inputMean - (3 * _inputStdDev);
            //chrtPDF.ChartAreas[0].AxisX.Maximum = _inputMean + (3 * _inputStdDev);
            //chrtPDF.ChartAreas[0].AxisY.Minimum = 0;
            //chrtPDF.ChartAreas[0].AxisY.Maximum = buckets.Max();
            //chrtPDF.ChartAreas[0].AxisY2.Minimum = 0;
            //chrtPDF.ChartAreas[0].AxisY2.Maximum = _pdfList.Max();
        }

        private void DisplayCDF()
        {
            chrtCDF.Series.Clear();
            chrtCDF.Series.Add("CDF");

            chrtCDF.Series["CDF"].ChartType = SeriesChartType.Point;
            chrtCDF.Series["CDF"].BorderWidth = 1;

            //chrtCDF.ChartAreas[0].AxisX.Minimum = _inputMean - (3 * _inputStdDev);
            //chrtCDF.ChartAreas[0].AxisX.Maximum = _inputMean + (3 * _inputStdDev);

            chrtCDF.ChartAreas[0].AxisX.Title = "Random Numbers";
            chrtCDF.ChartAreas[0].AxisY.Title = "CDF";

            chrtCDF.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chrtCDF.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";

            chrtCDF.Legends.Clear();

            var cdfList = new List<double>();
            var randomNumberList = new List<double>();

            if (_cdfList.Count() > 10000)
            {
                var skipNumber = _cdfList.Count() / 10000;

                for (int i = 0; i < _cdfList.Count; i = i + skipNumber)
                {
                    cdfList.Add(_cdfList[i]);
                    randomNumberList.Add(_randomNumberList[i]);
                }
            }
            else
            {
                cdfList = _cdfList;
                randomNumberList = _randomNumberList;
            }

            for (int i = 0; i < cdfList.Count; i++)
            {
                chrtCDF.Series[0].Points.AddXY(randomNumberList[i], cdfList[i]);
            }
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
