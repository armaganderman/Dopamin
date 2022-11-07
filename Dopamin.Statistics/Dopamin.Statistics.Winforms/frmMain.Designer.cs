namespace Dopamin.Statistics.Winforms
{
    partial class frmMain
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
            this.btnUniform = new System.Windows.Forms.Button();
            this.btnTriangular = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnLognormal = new System.Windows.Forms.Button();
            this.btnSkewed = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUniform
            // 
            this.btnUniform.Location = new System.Drawing.Point(12, 12);
            this.btnUniform.Name = "btnUniform";
            this.btnUniform.Size = new System.Drawing.Size(255, 23);
            this.btnUniform.TabIndex = 0;
            this.btnUniform.Text = "Uniform Distribution";
            this.btnUniform.UseVisualStyleBackColor = true;
            // 
            // btnTriangular
            // 
            this.btnTriangular.Location = new System.Drawing.Point(12, 41);
            this.btnTriangular.Name = "btnTriangular";
            this.btnTriangular.Size = new System.Drawing.Size(255, 23);
            this.btnTriangular.TabIndex = 1;
            this.btnTriangular.Text = "Triangular Distribution";
            this.btnTriangular.UseVisualStyleBackColor = true;
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(12, 70);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(255, 23);
            this.btnNormal.TabIndex = 2;
            this.btnNormal.Text = "Normal Distribution";
            this.btnNormal.UseVisualStyleBackColor = true;
            // 
            // btnLognormal
            // 
            this.btnLognormal.Location = new System.Drawing.Point(12, 99);
            this.btnLognormal.Name = "btnLognormal";
            this.btnLognormal.Size = new System.Drawing.Size(255, 23);
            this.btnLognormal.TabIndex = 3;
            this.btnLognormal.Text = "Lognormal Distribution";
            this.btnLognormal.UseVisualStyleBackColor = true;
            // 
            // btnSkewed
            // 
            this.btnSkewed.Location = new System.Drawing.Point(12, 128);
            this.btnSkewed.Name = "btnSkewed";
            this.btnSkewed.Size = new System.Drawing.Size(255, 23);
            this.btnSkewed.TabIndex = 4;
            this.btnSkewed.Text = "Skewed Normal Distribution";
            this.btnSkewed.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 172);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 206);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSkewed);
            this.Controls.Add(this.btnLognormal);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnTriangular);
            this.Controls.Add(this.btnUniform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distributions Main Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUniform;
        private Button btnTriangular;
        private Button btnNormal;
        private Button btnLognormal;
        private Button btnSkewed;
        private Button btnClose;
    }
}