﻿namespace Statistics.WinformsUI
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTriangular = new System.Windows.Forms.Button();
            this.btnUniform = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnSkewed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(147, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTriangular
            // 
            this.btnTriangular.Location = new System.Drawing.Point(12, 41);
            this.btnTriangular.Name = "btnTriangular";
            this.btnTriangular.Size = new System.Drawing.Size(210, 23);
            this.btnTriangular.TabIndex = 1;
            this.btnTriangular.Text = "Triangular Distribution";
            this.btnTriangular.UseVisualStyleBackColor = true;
            this.btnTriangular.Click += new System.EventHandler(this.btnTriangular_Click);
            // 
            // btnUniform
            // 
            this.btnUniform.Location = new System.Drawing.Point(12, 12);
            this.btnUniform.Name = "btnUniform";
            this.btnUniform.Size = new System.Drawing.Size(210, 23);
            this.btnUniform.TabIndex = 2;
            this.btnUniform.Text = "Uniform Distribution";
            this.btnUniform.UseVisualStyleBackColor = true;
            this.btnUniform.Click += new System.EventHandler(this.btnUniform_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(12, 70);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(210, 23);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.Text = "Normal Distribution";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnSkewed
            // 
            this.btnSkewed.Location = new System.Drawing.Point(12, 99);
            this.btnSkewed.Name = "btnSkewed";
            this.btnSkewed.Size = new System.Drawing.Size(210, 23);
            this.btnSkewed.TabIndex = 4;
            this.btnSkewed.Text = "Skewed Normal Distribution";
            this.btnSkewed.UseVisualStyleBackColor = true;
            this.btnSkewed.Click += new System.EventHandler(this.btnSkewed_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 225);
            this.Controls.Add(this.btnSkewed);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnUniform);
            this.Controls.Add(this.btnTriangular);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics Main Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTriangular;
        private System.Windows.Forms.Button btnUniform;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnSkewed;
    }
}