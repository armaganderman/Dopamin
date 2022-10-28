using Statistics.Core.Distributions;
using Statistics.Core.RandomNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Statistics.WinformsUI
{
    public partial class frmSkewedNormalDistribution : Form
    {
        #region Private Fields

        private int _iterationNumber;
        private double _inputMean;
        private double _inputSkewness;
        private double _inputStdDev; //Standard Deviation

        private List<double> _randomNumberList;
        private List<double> _pdfList;
        private List<double> _cdfList;

        #endregion

        #region Constructor

        public frmSkewedNormalDistribution()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Load

        private void frmSkewedNormalDistribution_Load(object sender, EventArgs e)
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

            //if (chckbxDisplayOutputs.Checked)
            //    PopulateListBoxes();

            //GetStatistics();
            DisplayHistogram();
            //DisplayPDF();
            //DisplayCDF();
        }


        private void GetInputs()
        {
            _iterationNumber = Convert.ToInt32(cmbbxIterationNumber.SelectedItem.ToString());
            _inputMean = Convert.ToDouble(txtbxMode.Text);
            _inputSkewness = Convert.ToDouble(txtbxSkewness.Text);
            _inputStdDev = Convert.ToDouble(txtbxStdDev.Text);
        }


        private void GetOutputs()
        {
            _randomNumberList = RandomNumberGenerator.GetListOfSkewedNormalRandomNumbers(_iterationNumber, _inputStdDev, _inputSkewness, _inputMean);
            //_pdfList = NormalDistribution.GetListOfPDF(_inputMean, _inputStdDev, _randomNumberList);
            //_cdfList = NormalDistribution.GetListOfCDF(_inputMean, _inputStdDev, _randomNumberList);
        }



        private void DisplayHistogram()
        {
            chrtRandomNumbers.Series.Clear();
            chrtRandomNumbers.Series.Add("RandomNumbers");

            chrtRandomNumbers.Series["RandomNumbers"].ChartType = SeriesChartType.Column;
            chrtRandomNumbers.Series["RandomNumbers"].BorderWidth = 1;
            chrtRandomNumbers.Series["RandomNumbers"].BorderColor = Color.White;
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

            chrtRandomNumbers.ChartAreas[0].AxisX.Minimum = _inputMean - _inputMean * 3;
            chrtRandomNumbers.ChartAreas[0].AxisX.Maximum = _inputMean + _inputStdDev * 3;
            chrtRandomNumbers.ChartAreas[0].AxisY.Minimum = 0;
            chrtRandomNumbers.ChartAreas[0].AxisY.Maximum = buckets.Max();

            chrtRandomNumbers.ChartAreas[0].AxisX.Title = "Value";
            chrtRandomNumbers.ChartAreas[0].AxisY.Title = "Count";

            chrtRandomNumbers.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chrtRandomNumbers.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
        }





        #region Helpers

        //Numeric only method for textboxes
        private void NumericOnlyTextbox(object Sender, KeyPressEventArgs E)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(E.KeyChar) && !char.IsDigit(E.KeyChar) && (E.KeyChar != '.') && (E.KeyChar != '-'))
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
