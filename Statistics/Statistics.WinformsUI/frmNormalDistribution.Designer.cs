namespace Statistics.WinformsUI
{
    partial class frmNormalDistribution
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpbxStatistics = new System.Windows.Forms.GroupBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.lblVariance = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblStandardDeviation = new System.Windows.Forms.Label();
            this.lblMedian = new System.Windows.Forms.Label();
            this.grpbxNumbers = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblUniformCDF = new System.Windows.Forms.Label();
            this.lblPDF = new System.Windows.Forms.Label();
            this.lblUniformRandomNumbers = new System.Windows.Forms.Label();
            this.lstbxCDF = new System.Windows.Forms.ListBox();
            this.lstbxPDF = new System.Windows.Forms.ListBox();
            this.lstbxRandomNumbers = new System.Windows.Forms.ListBox();
            this.grpbxInputs = new System.Windows.Forms.GroupBox();
            this.lblMeanHeader = new System.Windows.Forms.Label();
            this.txtbxMean = new System.Windows.Forms.TextBox();
            this.cmbbxIterationNumber = new System.Windows.Forms.ComboBox();
            this.chckbxDisplayOutputs = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblMaximumHeader = new System.Windows.Forms.Label();
            this.lblIterationNumberHeader = new System.Windows.Forms.Label();
            this.txtbxMinimum = new System.Windows.Forms.TextBox();
            this.lblMinimumHeader = new System.Windows.Forms.Label();
            this.txtbxMaximum = new System.Windows.Forms.TextBox();
            this.grpbxCDF = new System.Windows.Forms.GroupBox();
            this.chrtCDF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpbxPDF = new System.Windows.Forms.GroupBox();
            this.chrtPDF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpbxRandomNumbers = new System.Windows.Forms.GroupBox();
            this.chrtRandomNumbers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtbxStdDev = new System.Windows.Forms.TextBox();
            this.lblStdDevHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbxStatistics.SuspendLayout();
            this.grpbxNumbers.SuspendLayout();
            this.grpbxInputs.SuspendLayout();
            this.grpbxCDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCDF)).BeginInit();
            this.grpbxPDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPDF)).BeginInit();
            this.grpbxRandomNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRandomNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxStatistics
            // 
            this.grpbxStatistics.Controls.Add(this.lblMinimum);
            this.grpbxStatistics.Controls.Add(this.lblMaximum);
            this.grpbxStatistics.Controls.Add(this.lblMean);
            this.grpbxStatistics.Controls.Add(this.lblVariance);
            this.grpbxStatistics.Controls.Add(this.lblMode);
            this.grpbxStatistics.Controls.Add(this.lblStandardDeviation);
            this.grpbxStatistics.Controls.Add(this.lblMedian);
            this.grpbxStatistics.Location = new System.Drawing.Point(937, 12);
            this.grpbxStatistics.Name = "grpbxStatistics";
            this.grpbxStatistics.Size = new System.Drawing.Size(318, 266);
            this.grpbxStatistics.TabIndex = 6;
            this.grpbxStatistics.TabStop = false;
            this.grpbxStatistics.Text = "Statistical Outputs";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(6, 38);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(60, 15);
            this.lblMinimum.TabIndex = 32;
            this.lblMinimum.Text = "Minimum";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(6, 71);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(62, 15);
            this.lblMaximum.TabIndex = 31;
            this.lblMaximum.Text = "Maximum";
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(6, 104);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(40, 15);
            this.lblMean.TabIndex = 26;
            this.lblMean.Text = "Mean:";
            // 
            // lblVariance
            // 
            this.lblVariance.AutoSize = true;
            this.lblVariance.Location = new System.Drawing.Point(6, 236);
            this.lblVariance.Name = "lblVariance";
            this.lblVariance.Size = new System.Drawing.Size(51, 15);
            this.lblVariance.TabIndex = 30;
            this.lblVariance.Text = "Variance";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(6, 137);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(41, 15);
            this.lblMode.TabIndex = 27;
            this.lblMode.Text = "Mode:";
            // 
            // lblStandardDeviation
            // 
            this.lblStandardDeviation.AutoSize = true;
            this.lblStandardDeviation.Location = new System.Drawing.Point(6, 203);
            this.lblStandardDeviation.Name = "lblStandardDeviation";
            this.lblStandardDeviation.Size = new System.Drawing.Size(107, 15);
            this.lblStandardDeviation.TabIndex = 29;
            this.lblStandardDeviation.Text = "Standard Deviation";
            // 
            // lblMedian
            // 
            this.lblMedian.AutoSize = true;
            this.lblMedian.Location = new System.Drawing.Point(6, 170);
            this.lblMedian.Name = "lblMedian";
            this.lblMedian.Size = new System.Drawing.Size(47, 15);
            this.lblMedian.TabIndex = 28;
            this.lblMedian.Text = "Median";
            // 
            // grpbxNumbers
            // 
            this.grpbxNumbers.Controls.Add(this.lblInfo);
            this.grpbxNumbers.Controls.Add(this.lblUniformCDF);
            this.grpbxNumbers.Controls.Add(this.lblPDF);
            this.grpbxNumbers.Controls.Add(this.lblUniformRandomNumbers);
            this.grpbxNumbers.Controls.Add(this.lstbxCDF);
            this.grpbxNumbers.Controls.Add(this.lstbxPDF);
            this.grpbxNumbers.Controls.Add(this.lstbxRandomNumbers);
            this.grpbxNumbers.Location = new System.Drawing.Point(261, 12);
            this.grpbxNumbers.Name = "grpbxNumbers";
            this.grpbxNumbers.Size = new System.Drawing.Size(670, 266);
            this.grpbxNumbers.TabIndex = 5;
            this.grpbxNumbers.TabStop = false;
            this.grpbxNumbers.Text = "Generated Random Numbers / PDF / CDF";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 241);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(260, 15);
            this.lblInfo.TabIndex = 27;
            this.lblInfo.Text = "Listboxes display only first thousand data points";
            // 
            // lblUniformCDF
            // 
            this.lblUniformCDF.AutoSize = true;
            this.lblUniformCDF.Location = new System.Drawing.Point(534, 35);
            this.lblUniformCDF.Name = "lblUniformCDF";
            this.lblUniformCDF.Size = new System.Drawing.Size(29, 15);
            this.lblUniformCDF.TabIndex = 31;
            this.lblUniformCDF.Text = "CDF";
            // 
            // lblPDF
            // 
            this.lblPDF.AutoSize = true;
            this.lblPDF.Location = new System.Drawing.Point(316, 38);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(28, 15);
            this.lblPDF.TabIndex = 30;
            this.lblPDF.Text = "PDF";
            // 
            // lblUniformRandomNumbers
            // 
            this.lblUniformRandomNumbers.AutoSize = true;
            this.lblUniformRandomNumbers.Location = new System.Drawing.Point(60, 38);
            this.lblUniformRandomNumbers.Name = "lblUniformRandomNumbers";
            this.lblUniformRandomNumbers.Size = new System.Drawing.Size(104, 15);
            this.lblUniformRandomNumbers.TabIndex = 29;
            this.lblUniformRandomNumbers.Text = "Random Numbers";
            // 
            // lstbxCDF
            // 
            this.lstbxCDF.FormattingEnabled = true;
            this.lstbxCDF.ItemHeight = 15;
            this.lstbxCDF.Location = new System.Drawing.Point(442, 67);
            this.lstbxCDF.Name = "lstbxCDF";
            this.lstbxCDF.Size = new System.Drawing.Size(212, 169);
            this.lstbxCDF.TabIndex = 28;
            // 
            // lstbxPDF
            // 
            this.lstbxPDF.FormattingEnabled = true;
            this.lstbxPDF.ItemHeight = 15;
            this.lstbxPDF.Location = new System.Drawing.Point(224, 67);
            this.lstbxPDF.Name = "lstbxPDF";
            this.lstbxPDF.Size = new System.Drawing.Size(212, 169);
            this.lstbxPDF.TabIndex = 27;
            // 
            // lstbxRandomNumbers
            // 
            this.lstbxRandomNumbers.FormattingEnabled = true;
            this.lstbxRandomNumbers.ItemHeight = 15;
            this.lstbxRandomNumbers.Location = new System.Drawing.Point(6, 67);
            this.lstbxRandomNumbers.Name = "lstbxRandomNumbers";
            this.lstbxRandomNumbers.Size = new System.Drawing.Size(212, 169);
            this.lstbxRandomNumbers.TabIndex = 26;
            // 
            // grpbxInputs
            // 
            this.grpbxInputs.Controls.Add(this.lblStdDevHeader);
            this.grpbxInputs.Controls.Add(this.txtbxStdDev);
            this.grpbxInputs.Controls.Add(this.lblMeanHeader);
            this.grpbxInputs.Controls.Add(this.txtbxMean);
            this.grpbxInputs.Controls.Add(this.cmbbxIterationNumber);
            this.grpbxInputs.Controls.Add(this.chckbxDisplayOutputs);
            this.grpbxInputs.Controls.Add(this.btnRun);
            this.grpbxInputs.Controls.Add(this.lblMaximumHeader);
            this.grpbxInputs.Controls.Add(this.lblIterationNumberHeader);
            this.grpbxInputs.Controls.Add(this.txtbxMinimum);
            this.grpbxInputs.Controls.Add(this.lblMinimumHeader);
            this.grpbxInputs.Controls.Add(this.txtbxMaximum);
            this.grpbxInputs.Location = new System.Drawing.Point(12, 12);
            this.grpbxInputs.Name = "grpbxInputs";
            this.grpbxInputs.Size = new System.Drawing.Size(243, 266);
            this.grpbxInputs.TabIndex = 4;
            this.grpbxInputs.TabStop = false;
            this.grpbxInputs.Text = "Inputs";
            // 
            // lblMeanHeader
            // 
            this.lblMeanHeader.AutoSize = true;
            this.lblMeanHeader.Location = new System.Drawing.Point(6, 125);
            this.lblMeanHeader.Name = "lblMeanHeader";
            this.lblMeanHeader.Size = new System.Drawing.Size(40, 15);
            this.lblMeanHeader.TabIndex = 28;
            this.lblMeanHeader.Text = "Mean:";
            // 
            // txtbxMean
            // 
            this.txtbxMean.Location = new System.Drawing.Point(127, 122);
            this.txtbxMean.Name = "txtbxMean";
            this.txtbxMean.Size = new System.Drawing.Size(110, 23);
            this.txtbxMean.TabIndex = 27;
            this.txtbxMean.Text = "0";
            this.txtbxMean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnlyTextbox);
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
            this.cmbbxIterationNumber.Size = new System.Drawing.Size(110, 23);
            this.cmbbxIterationNumber.TabIndex = 26;
            // 
            // chckbxDisplayOutputs
            // 
            this.chckbxDisplayOutputs.AutoSize = true;
            this.chckbxDisplayOutputs.Location = new System.Drawing.Point(6, 212);
            this.chckbxDisplayOutputs.Name = "chckbxDisplayOutputs";
            this.chckbxDisplayOutputs.Size = new System.Drawing.Size(170, 19);
            this.chckbxDisplayOutputs.TabIndex = 25;
            this.chckbxDisplayOutputs.Text = "Display outputs in listboxes";
            this.chckbxDisplayOutputs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckbxDisplayOutputs.UseVisualStyleBackColor = true;
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
            // lblMaximumHeader
            // 
            this.lblMaximumHeader.AutoSize = true;
            this.lblMaximumHeader.Location = new System.Drawing.Point(6, 96);
            this.lblMaximumHeader.Name = "lblMaximumHeader";
            this.lblMaximumHeader.Size = new System.Drawing.Size(65, 15);
            this.lblMaximumHeader.TabIndex = 23;
            this.lblMaximumHeader.Text = "Maximum:";
            // 
            // lblIterationNumberHeader
            // 
            this.lblIterationNumberHeader.AutoSize = true;
            this.lblIterationNumberHeader.Location = new System.Drawing.Point(6, 38);
            this.lblIterationNumberHeader.Name = "lblIterationNumberHeader";
            this.lblIterationNumberHeader.Size = new System.Drawing.Size(101, 15);
            this.lblIterationNumberHeader.TabIndex = 19;
            this.lblIterationNumberHeader.Text = "Iteration Number:";
            // 
            // txtbxMinimum
            // 
            this.txtbxMinimum.Location = new System.Drawing.Point(127, 64);
            this.txtbxMinimum.Name = "txtbxMinimum";
            this.txtbxMinimum.Size = new System.Drawing.Size(110, 23);
            this.txtbxMinimum.TabIndex = 20;
            this.txtbxMinimum.Text = "-1";
            this.txtbxMinimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnlyTextbox);
            // 
            // lblMinimumHeader
            // 
            this.lblMinimumHeader.AutoSize = true;
            this.lblMinimumHeader.Location = new System.Drawing.Point(6, 67);
            this.lblMinimumHeader.Name = "lblMinimumHeader";
            this.lblMinimumHeader.Size = new System.Drawing.Size(63, 15);
            this.lblMinimumHeader.TabIndex = 22;
            this.lblMinimumHeader.Text = "Minimum:";
            // 
            // txtbxMaximum
            // 
            this.txtbxMaximum.Location = new System.Drawing.Point(127, 93);
            this.txtbxMaximum.Name = "txtbxMaximum";
            this.txtbxMaximum.Size = new System.Drawing.Size(110, 23);
            this.txtbxMaximum.TabIndex = 21;
            this.txtbxMaximum.Text = "1";
            this.txtbxMaximum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnlyTextbox);
            // 
            // grpbxCDF
            // 
            this.grpbxCDF.Controls.Add(this.chrtCDF);
            this.grpbxCDF.Location = new System.Drawing.Point(1072, 284);
            this.grpbxCDF.Name = "grpbxCDF";
            this.grpbxCDF.Size = new System.Drawing.Size(500, 479);
            this.grpbxCDF.TabIndex = 11;
            this.grpbxCDF.TabStop = false;
            this.grpbxCDF.Text = "Cumulative Distribution Function (CDF)";
            // 
            // chrtCDF
            // 
            chartArea19.Name = "ChartArea1";
            this.chrtCDF.ChartAreas.Add(chartArea19);
            this.chrtCDF.Dock = System.Windows.Forms.DockStyle.Fill;
            legend19.Name = "Legend1";
            this.chrtCDF.Legends.Add(legend19);
            this.chrtCDF.Location = new System.Drawing.Point(3, 19);
            this.chrtCDF.Name = "chrtCDF";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.chrtCDF.Series.Add(series19);
            this.chrtCDF.Size = new System.Drawing.Size(494, 457);
            this.chrtCDF.TabIndex = 1;
            this.chrtCDF.Text = "chart3";
            // 
            // grpbxPDF
            // 
            this.grpbxPDF.Controls.Add(this.chrtPDF);
            this.grpbxPDF.Location = new System.Drawing.Point(542, 284);
            this.grpbxPDF.Name = "grpbxPDF";
            this.grpbxPDF.Size = new System.Drawing.Size(500, 479);
            this.grpbxPDF.TabIndex = 10;
            this.grpbxPDF.TabStop = false;
            this.grpbxPDF.Text = "Probability Density Function (PDF)";
            // 
            // chrtPDF
            // 
            chartArea20.Name = "ChartArea1";
            this.chrtPDF.ChartAreas.Add(chartArea20);
            this.chrtPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            legend20.Name = "Legend1";
            this.chrtPDF.Legends.Add(legend20);
            this.chrtPDF.Location = new System.Drawing.Point(3, 19);
            this.chrtPDF.Name = "chrtPDF";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.chrtPDF.Series.Add(series20);
            this.chrtPDF.Size = new System.Drawing.Size(494, 457);
            this.chrtPDF.TabIndex = 1;
            this.chrtPDF.Text = "chart2";
            // 
            // grpbxRandomNumbers
            // 
            this.grpbxRandomNumbers.Controls.Add(this.chrtRandomNumbers);
            this.grpbxRandomNumbers.Location = new System.Drawing.Point(12, 284);
            this.grpbxRandomNumbers.Name = "grpbxRandomNumbers";
            this.grpbxRandomNumbers.Size = new System.Drawing.Size(500, 479);
            this.grpbxRandomNumbers.TabIndex = 9;
            this.grpbxRandomNumbers.TabStop = false;
            this.grpbxRandomNumbers.Text = "Random Numbers";
            // 
            // chrtRandomNumbers
            // 
            chartArea21.Name = "ChartArea1";
            this.chrtRandomNumbers.ChartAreas.Add(chartArea21);
            this.chrtRandomNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            legend21.Name = "Legend1";
            this.chrtRandomNumbers.Legends.Add(legend21);
            this.chrtRandomNumbers.Location = new System.Drawing.Point(3, 19);
            this.chrtRandomNumbers.Name = "chrtRandomNumbers";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.chrtRandomNumbers.Series.Add(series21);
            this.chrtRandomNumbers.Size = new System.Drawing.Size(494, 457);
            this.chrtRandomNumbers.TabIndex = 0;
            this.chrtRandomNumbers.Text = "chart1";
            // 
            // txtbxStdDev
            // 
            this.txtbxStdDev.Location = new System.Drawing.Point(127, 151);
            this.txtbxStdDev.Name = "txtbxStdDev";
            this.txtbxStdDev.Size = new System.Drawing.Size(110, 23);
            this.txtbxStdDev.TabIndex = 29;
            this.txtbxStdDev.Text = "0.35";
            this.txtbxStdDev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnlyTextbox);
            // 
            // lblStdDevHeader
            // 
            this.lblStdDevHeader.AutoSize = true;
            this.lblStdDevHeader.Location = new System.Drawing.Point(6, 154);
            this.lblStdDevHeader.Name = "lblStdDevHeader";
            this.lblStdDevHeader.Size = new System.Drawing.Size(110, 15);
            this.lblStdDevHeader.TabIndex = 30;
            this.lblStdDevHeader.Text = "Standard Deviation:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1494, 826);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNormalDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpbxCDF);
            this.Controls.Add(this.grpbxPDF);
            this.Controls.Add(this.grpbxRandomNumbers);
            this.Controls.Add(this.grpbxStatistics);
            this.Controls.Add(this.grpbxNumbers);
            this.Controls.Add(this.grpbxInputs);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNormalDistribution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNormalDistribution";
            this.Load += new System.EventHandler(this.frmNormalDistribution_Load);
            this.grpbxStatistics.ResumeLayout(false);
            this.grpbxStatistics.PerformLayout();
            this.grpbxNumbers.ResumeLayout(false);
            this.grpbxNumbers.PerformLayout();
            this.grpbxInputs.ResumeLayout(false);
            this.grpbxInputs.PerformLayout();
            this.grpbxCDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtCDF)).EndInit();
            this.grpbxPDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtPDF)).EndInit();
            this.grpbxRandomNumbers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtRandomNumbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxStatistics;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label lblVariance;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblStandardDeviation;
        private System.Windows.Forms.Label lblMedian;
        private System.Windows.Forms.GroupBox grpbxNumbers;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblUniformCDF;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.Label lblUniformRandomNumbers;
        private System.Windows.Forms.ListBox lstbxCDF;
        private System.Windows.Forms.ListBox lstbxPDF;
        private System.Windows.Forms.ListBox lstbxRandomNumbers;
        private System.Windows.Forms.GroupBox grpbxInputs;
        private System.Windows.Forms.Label lblMeanHeader;
        private System.Windows.Forms.TextBox txtbxMean;
        private System.Windows.Forms.ComboBox cmbbxIterationNumber;
        private System.Windows.Forms.CheckBox chckbxDisplayOutputs;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblMaximumHeader;
        private System.Windows.Forms.Label lblIterationNumberHeader;
        private System.Windows.Forms.TextBox txtbxMinimum;
        private System.Windows.Forms.Label lblMinimumHeader;
        private System.Windows.Forms.TextBox txtbxMaximum;
        private System.Windows.Forms.GroupBox grpbxCDF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtCDF;
        private System.Windows.Forms.GroupBox grpbxPDF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPDF;
        private System.Windows.Forms.GroupBox grpbxRandomNumbers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtRandomNumbers;
        private System.Windows.Forms.Label lblStdDevHeader;
        private System.Windows.Forms.TextBox txtbxStdDev;
        private System.Windows.Forms.Button btnClose;
    }
}