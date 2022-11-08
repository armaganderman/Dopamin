namespace Dopamin.Statistics.WinformsUI
{
    partial class frmLognormalDistribution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbxCDF = new System.Windows.Forms.GroupBox();
            this.chrtCDF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpbxPDF = new System.Windows.Forms.GroupBox();
            this.chrtPDF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpbxRandomNumbers = new System.Windows.Forms.GroupBox();
            this.chrtRandomNumbers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpbxNumbers = new System.Windows.Forms.GroupBox();
            this.chckbxDisplayOutputs = new System.Windows.Forms.CheckBox();
            this.lblUniformCDF = new System.Windows.Forms.Label();
            this.lblPDF = new System.Windows.Forms.Label();
            this.lblUniformRandomNumbers = new System.Windows.Forms.Label();
            this.lstbxCDF = new System.Windows.Forms.ListBox();
            this.lstbxPDF = new System.Windows.Forms.ListBox();
            this.lstbxRandomNumbers = new System.Windows.Forms.ListBox();
            this.grpbxStatistics = new System.Windows.Forms.GroupBox();
            this.lblTrials = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblSkewness = new System.Windows.Forms.Label();
            this.lblKurtosis = new System.Windows.Forms.Label();
            this.lblStandardError = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.lblVariance = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblStandardDeviation = new System.Windows.Forms.Label();
            this.lblMedian = new System.Windows.Forms.Label();
            this.grpbxInputs = new System.Windows.Forms.GroupBox();
            this.lblStdDevHeader = new System.Windows.Forms.Label();
            this.txtbxStdDev = new System.Windows.Forms.TextBox();
            this.lblMeanHeader = new System.Windows.Forms.Label();
            this.txtbxMean = new System.Windows.Forms.TextBox();
            this.cmbbxIterationNumber = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblIterationNumberHeader = new System.Windows.Forms.Label();
            this.grpbxCDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCDF)).BeginInit();
            this.grpbxPDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPDF)).BeginInit();
            this.grpbxRandomNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRandomNumbers)).BeginInit();
            this.grpbxNumbers.SuspendLayout();
            this.grpbxStatistics.SuspendLayout();
            this.grpbxInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1494, 826);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbxCDF
            // 
            this.grpbxCDF.Controls.Add(this.chrtCDF);
            this.grpbxCDF.Location = new System.Drawing.Point(1072, 284);
            this.grpbxCDF.Name = "grpbxCDF";
            this.grpbxCDF.Size = new System.Drawing.Size(500, 479);
            this.grpbxCDF.TabIndex = 30;
            this.grpbxCDF.TabStop = false;
            this.grpbxCDF.Text = "Cumulative Distribution Function (CDF)";
            // 
            // chrtCDF
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtCDF.ChartAreas.Add(chartArea4);
            this.chrtCDF.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chrtCDF.Legends.Add(legend4);
            this.chrtCDF.Location = new System.Drawing.Point(3, 16);
            this.chrtCDF.Name = "chrtCDF";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrtCDF.Series.Add(series4);
            this.chrtCDF.Size = new System.Drawing.Size(494, 460);
            this.chrtCDF.TabIndex = 1;
            this.chrtCDF.Text = "chart3";
            // 
            // grpbxPDF
            // 
            this.grpbxPDF.Controls.Add(this.chrtPDF);
            this.grpbxPDF.Location = new System.Drawing.Point(542, 284);
            this.grpbxPDF.Name = "grpbxPDF";
            this.grpbxPDF.Size = new System.Drawing.Size(500, 479);
            this.grpbxPDF.TabIndex = 29;
            this.grpbxPDF.TabStop = false;
            this.grpbxPDF.Text = "Probability Density Function (PDF)";
            // 
            // chrtPDF
            // 
            chartArea5.Name = "ChartArea1";
            this.chrtPDF.ChartAreas.Add(chartArea5);
            this.chrtPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chrtPDF.Legends.Add(legend5);
            this.chrtPDF.Location = new System.Drawing.Point(3, 16);
            this.chrtPDF.Name = "chrtPDF";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chrtPDF.Series.Add(series5);
            this.chrtPDF.Size = new System.Drawing.Size(494, 460);
            this.chrtPDF.TabIndex = 1;
            this.chrtPDF.Text = "chart2";
            // 
            // grpbxRandomNumbers
            // 
            this.grpbxRandomNumbers.Controls.Add(this.chrtRandomNumbers);
            this.grpbxRandomNumbers.Location = new System.Drawing.Point(12, 284);
            this.grpbxRandomNumbers.Name = "grpbxRandomNumbers";
            this.grpbxRandomNumbers.Size = new System.Drawing.Size(500, 479);
            this.grpbxRandomNumbers.TabIndex = 28;
            this.grpbxRandomNumbers.TabStop = false;
            this.grpbxRandomNumbers.Text = "Random Numbers";
            // 
            // chrtRandomNumbers
            // 
            chartArea6.Name = "ChartArea1";
            this.chrtRandomNumbers.ChartAreas.Add(chartArea6);
            this.chrtRandomNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chrtRandomNumbers.Legends.Add(legend6);
            this.chrtRandomNumbers.Location = new System.Drawing.Point(3, 16);
            this.chrtRandomNumbers.Name = "chrtRandomNumbers";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chrtRandomNumbers.Series.Add(series6);
            this.chrtRandomNumbers.Size = new System.Drawing.Size(494, 460);
            this.chrtRandomNumbers.TabIndex = 0;
            this.chrtRandomNumbers.Text = "chart1";
            // 
            // grpbxNumbers
            // 
            this.grpbxNumbers.Controls.Add(this.chckbxDisplayOutputs);
            this.grpbxNumbers.Controls.Add(this.lblUniformCDF);
            this.grpbxNumbers.Controls.Add(this.lblPDF);
            this.grpbxNumbers.Controls.Add(this.lblUniformRandomNumbers);
            this.grpbxNumbers.Controls.Add(this.lstbxCDF);
            this.grpbxNumbers.Controls.Add(this.lstbxPDF);
            this.grpbxNumbers.Controls.Add(this.lstbxRandomNumbers);
            this.grpbxNumbers.Location = new System.Drawing.Point(261, 12);
            this.grpbxNumbers.Name = "grpbxNumbers";
            this.grpbxNumbers.Size = new System.Drawing.Size(670, 266);
            this.grpbxNumbers.TabIndex = 27;
            this.grpbxNumbers.TabStop = false;
            this.grpbxNumbers.Text = "Generated Random Numbers / PDF / CDF";
            // 
            // chckbxDisplayOutputs
            // 
            this.chckbxDisplayOutputs.AutoSize = true;
            this.chckbxDisplayOutputs.Location = new System.Drawing.Point(6, 34);
            this.chckbxDisplayOutputs.Name = "chckbxDisplayOutputs";
            this.chckbxDisplayOutputs.Size = new System.Drawing.Size(383, 17);
            this.chckbxDisplayOutputs.TabIndex = 25;
            this.chckbxDisplayOutputs.Text = "Display outputs in listboxes (Listboxes display only first thousand data points)";
            this.chckbxDisplayOutputs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckbxDisplayOutputs.UseVisualStyleBackColor = true;
            this.chckbxDisplayOutputs.CheckedChanged += new System.EventHandler(this.chckbxDisplayOutputs_CheckedChanged);
            // 
            // lblUniformCDF
            // 
            this.lblUniformCDF.AutoSize = true;
            this.lblUniformCDF.Location = new System.Drawing.Point(534, 64);
            this.lblUniformCDF.Name = "lblUniformCDF";
            this.lblUniformCDF.Size = new System.Drawing.Size(28, 13);
            this.lblUniformCDF.TabIndex = 31;
            this.lblUniformCDF.Text = "CDF";
            // 
            // lblPDF
            // 
            this.lblPDF.AutoSize = true;
            this.lblPDF.Location = new System.Drawing.Point(316, 67);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(28, 13);
            this.lblPDF.TabIndex = 30;
            this.lblPDF.Text = "PDF";
            // 
            // lblUniformRandomNumbers
            // 
            this.lblUniformRandomNumbers.AutoSize = true;
            this.lblUniformRandomNumbers.Location = new System.Drawing.Point(60, 67);
            this.lblUniformRandomNumbers.Name = "lblUniformRandomNumbers";
            this.lblUniformRandomNumbers.Size = new System.Drawing.Size(92, 13);
            this.lblUniformRandomNumbers.TabIndex = 29;
            this.lblUniformRandomNumbers.Text = "Random Numbers";
            // 
            // lstbxCDF
            // 
            this.lstbxCDF.FormattingEnabled = true;
            this.lstbxCDF.Location = new System.Drawing.Point(442, 91);
            this.lstbxCDF.Name = "lstbxCDF";
            this.lstbxCDF.Size = new System.Drawing.Size(212, 160);
            this.lstbxCDF.TabIndex = 28;
            // 
            // lstbxPDF
            // 
            this.lstbxPDF.FormattingEnabled = true;
            this.lstbxPDF.Location = new System.Drawing.Point(224, 91);
            this.lstbxPDF.Name = "lstbxPDF";
            this.lstbxPDF.Size = new System.Drawing.Size(212, 160);
            this.lstbxPDF.TabIndex = 27;
            // 
            // lstbxRandomNumbers
            // 
            this.lstbxRandomNumbers.FormattingEnabled = true;
            this.lstbxRandomNumbers.Location = new System.Drawing.Point(6, 91);
            this.lstbxRandomNumbers.Name = "lstbxRandomNumbers";
            this.lstbxRandomNumbers.Size = new System.Drawing.Size(212, 160);
            this.lstbxRandomNumbers.TabIndex = 26;
            // 
            // grpbxStatistics
            // 
            this.grpbxStatistics.Controls.Add(this.lblTrials);
            this.grpbxStatistics.Controls.Add(this.lblRange);
            this.grpbxStatistics.Controls.Add(this.lblSkewness);
            this.grpbxStatistics.Controls.Add(this.lblKurtosis);
            this.grpbxStatistics.Controls.Add(this.lblStandardError);
            this.grpbxStatistics.Controls.Add(this.lblMinimum);
            this.grpbxStatistics.Controls.Add(this.lblMaximum);
            this.grpbxStatistics.Controls.Add(this.lblMean);
            this.grpbxStatistics.Controls.Add(this.lblVariance);
            this.grpbxStatistics.Controls.Add(this.lblMode);
            this.grpbxStatistics.Controls.Add(this.lblStandardDeviation);
            this.grpbxStatistics.Controls.Add(this.lblMedian);
            this.grpbxStatistics.Location = new System.Drawing.Point(937, 12);
            this.grpbxStatistics.Name = "grpbxStatistics";
            this.grpbxStatistics.Size = new System.Drawing.Size(635, 266);
            this.grpbxStatistics.TabIndex = 26;
            this.grpbxStatistics.TabStop = false;
            this.grpbxStatistics.Text = "Descriptive Statistics";
            // 
            // lblTrials
            // 
            this.lblTrials.AutoSize = true;
            this.lblTrials.Location = new System.Drawing.Point(336, 233);
            this.lblTrials.Name = "lblTrials";
            this.lblTrials.Size = new System.Drawing.Size(35, 13);
            this.lblTrials.TabIndex = 37;
            this.lblTrials.Text = "Trials:";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(336, 194);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(47, 13);
            this.lblRange.TabIndex = 36;
            this.lblRange.Text = "Ranges:";
            // 
            // lblSkewness
            // 
            this.lblSkewness.AutoSize = true;
            this.lblSkewness.Location = new System.Drawing.Point(336, 77);
            this.lblSkewness.Name = "lblSkewness";
            this.lblSkewness.Size = new System.Drawing.Size(59, 13);
            this.lblSkewness.TabIndex = 35;
            this.lblSkewness.Text = "Skewness:";
            // 
            // lblKurtosis
            // 
            this.lblKurtosis.AutoSize = true;
            this.lblKurtosis.Location = new System.Drawing.Point(336, 38);
            this.lblKurtosis.Name = "lblKurtosis";
            this.lblKurtosis.Size = new System.Drawing.Size(47, 13);
            this.lblKurtosis.TabIndex = 34;
            this.lblKurtosis.Text = "Kurtosis:";
            // 
            // lblStandardError
            // 
            this.lblStandardError.AutoSize = true;
            this.lblStandardError.Location = new System.Drawing.Point(10, 77);
            this.lblStandardError.Name = "lblStandardError";
            this.lblStandardError.Size = new System.Drawing.Size(78, 13);
            this.lblStandardError.TabIndex = 33;
            this.lblStandardError.Text = "Standard Error:";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(336, 116);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(51, 13);
            this.lblMinimum.TabIndex = 32;
            this.lblMinimum.Text = "Minimum:";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(336, 155);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(54, 13);
            this.lblMaximum.TabIndex = 31;
            this.lblMaximum.Text = "Maximum:";
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(11, 38);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(37, 13);
            this.lblMean.TabIndex = 26;
            this.lblMean.Text = "Mean:";
            // 
            // lblVariance
            // 
            this.lblVariance.AutoSize = true;
            this.lblVariance.Location = new System.Drawing.Point(11, 233);
            this.lblVariance.Name = "lblVariance";
            this.lblVariance.Size = new System.Drawing.Size(52, 13);
            this.lblVariance.TabIndex = 30;
            this.lblVariance.Text = "Variance:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(11, 155);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(37, 13);
            this.lblMode.TabIndex = 27;
            this.lblMode.Text = "Mode:";
            // 
            // lblStandardDeviation
            // 
            this.lblStandardDeviation.AutoSize = true;
            this.lblStandardDeviation.Location = new System.Drawing.Point(11, 194);
            this.lblStandardDeviation.Name = "lblStandardDeviation";
            this.lblStandardDeviation.Size = new System.Drawing.Size(101, 13);
            this.lblStandardDeviation.TabIndex = 29;
            this.lblStandardDeviation.Text = "Standard Deviation:";
            // 
            // lblMedian
            // 
            this.lblMedian.AutoSize = true;
            this.lblMedian.Location = new System.Drawing.Point(11, 116);
            this.lblMedian.Name = "lblMedian";
            this.lblMedian.Size = new System.Drawing.Size(45, 13);
            this.lblMedian.TabIndex = 28;
            this.lblMedian.Text = "Median:";
            // 
            // grpbxInputs
            // 
            this.grpbxInputs.Controls.Add(this.lblStdDevHeader);
            this.grpbxInputs.Controls.Add(this.txtbxStdDev);
            this.grpbxInputs.Controls.Add(this.lblMeanHeader);
            this.grpbxInputs.Controls.Add(this.txtbxMean);
            this.grpbxInputs.Controls.Add(this.cmbbxIterationNumber);
            this.grpbxInputs.Controls.Add(this.btnRun);
            this.grpbxInputs.Controls.Add(this.lblIterationNumberHeader);
            this.grpbxInputs.Location = new System.Drawing.Point(12, 12);
            this.grpbxInputs.Name = "grpbxInputs";
            this.grpbxInputs.Size = new System.Drawing.Size(243, 266);
            this.grpbxInputs.TabIndex = 25;
            this.grpbxInputs.TabStop = false;
            this.grpbxInputs.Text = "Inputs";
            // 
            // lblStdDevHeader
            // 
            this.lblStdDevHeader.AutoSize = true;
            this.lblStdDevHeader.Location = new System.Drawing.Point(6, 94);
            this.lblStdDevHeader.Name = "lblStdDevHeader";
            this.lblStdDevHeader.Size = new System.Drawing.Size(101, 13);
            this.lblStdDevHeader.TabIndex = 30;
            this.lblStdDevHeader.Text = "Standard Deviation:";
            // 
            // txtbxStdDev
            // 
            this.txtbxStdDev.Location = new System.Drawing.Point(127, 91);
            this.txtbxStdDev.Name = "txtbxStdDev";
            this.txtbxStdDev.Size = new System.Drawing.Size(110, 20);
            this.txtbxStdDev.TabIndex = 29;
            this.txtbxStdDev.Text = "0.05";
            // 
            // lblMeanHeader
            // 
            this.lblMeanHeader.AutoSize = true;
            this.lblMeanHeader.Location = new System.Drawing.Point(6, 65);
            this.lblMeanHeader.Name = "lblMeanHeader";
            this.lblMeanHeader.Size = new System.Drawing.Size(37, 13);
            this.lblMeanHeader.TabIndex = 28;
            this.lblMeanHeader.Text = "Mean:";
            // 
            // txtbxMean
            // 
            this.txtbxMean.Location = new System.Drawing.Point(127, 62);
            this.txtbxMean.Name = "txtbxMean";
            this.txtbxMean.Size = new System.Drawing.Size(110, 20);
            this.txtbxMean.TabIndex = 27;
            this.txtbxMean.Text = "1";
            // 
            // cmbbxIterationNumber
            // 
            this.cmbbxIterationNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxIterationNumber.FormattingEnabled = true;
            this.cmbbxIterationNumber.Items.AddRange(new object[] {
            "1000",
            "10000",
            "100000"});
            this.cmbbxIterationNumber.Location = new System.Drawing.Point(127, 35);
            this.cmbbxIterationNumber.Name = "cmbbxIterationNumber";
            this.cmbbxIterationNumber.Size = new System.Drawing.Size(110, 21);
            this.cmbbxIterationNumber.TabIndex = 26;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(150, 237);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 24;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblIterationNumberHeader
            // 
            this.lblIterationNumberHeader.AutoSize = true;
            this.lblIterationNumberHeader.Location = new System.Drawing.Point(6, 38);
            this.lblIterationNumberHeader.Name = "lblIterationNumberHeader";
            this.lblIterationNumberHeader.Size = new System.Drawing.Size(88, 13);
            this.lblIterationNumberHeader.TabIndex = 19;
            this.lblIterationNumberHeader.Text = "Iteration Number:";
            // 
            // frmLognormalDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpbxCDF);
            this.Controls.Add(this.grpbxPDF);
            this.Controls.Add(this.grpbxRandomNumbers);
            this.Controls.Add(this.grpbxNumbers);
            this.Controls.Add(this.grpbxStatistics);
            this.Controls.Add(this.grpbxInputs);
            this.Name = "frmLognormalDistribution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLognormalDistribution";
            this.Load += new System.EventHandler(this.frmLognormalDistribution_Load);
            this.grpbxCDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtCDF)).EndInit();
            this.grpbxPDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtPDF)).EndInit();
            this.grpbxRandomNumbers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtRandomNumbers)).EndInit();
            this.grpbxNumbers.ResumeLayout(false);
            this.grpbxNumbers.PerformLayout();
            this.grpbxStatistics.ResumeLayout(false);
            this.grpbxStatistics.PerformLayout();
            this.grpbxInputs.ResumeLayout(false);
            this.grpbxInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbxCDF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtCDF;
        private System.Windows.Forms.GroupBox grpbxPDF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPDF;
        private System.Windows.Forms.GroupBox grpbxRandomNumbers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtRandomNumbers;
        private System.Windows.Forms.GroupBox grpbxNumbers;
        private System.Windows.Forms.CheckBox chckbxDisplayOutputs;
        private System.Windows.Forms.Label lblUniformCDF;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.Label lblUniformRandomNumbers;
        private System.Windows.Forms.ListBox lstbxCDF;
        private System.Windows.Forms.ListBox lstbxPDF;
        private System.Windows.Forms.ListBox lstbxRandomNumbers;
        private System.Windows.Forms.GroupBox grpbxStatistics;
        private System.Windows.Forms.Label lblTrials;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblSkewness;
        private System.Windows.Forms.Label lblKurtosis;
        private System.Windows.Forms.Label lblStandardError;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label lblVariance;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblStandardDeviation;
        private System.Windows.Forms.Label lblMedian;
        private System.Windows.Forms.GroupBox grpbxInputs;
        private System.Windows.Forms.Label lblStdDevHeader;
        private System.Windows.Forms.TextBox txtbxStdDev;
        private System.Windows.Forms.Label lblMeanHeader;
        private System.Windows.Forms.TextBox txtbxMean;
        private System.Windows.Forms.ComboBox cmbbxIterationNumber;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblIterationNumberHeader;
    }
}