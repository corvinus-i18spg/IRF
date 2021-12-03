
namespace micro_sim
{
    partial class Form1
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
            this.LblClosingYear = new System.Windows.Forms.Label();
            this.LblPopulationFile = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.numericClosing = new System.Windows.Forms.NumericUpDown();
            this.numericPopulation = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericClosing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClosingYear
            // 
            this.LblClosingYear.AutoSize = true;
            this.LblClosingYear.Location = new System.Drawing.Point(13, 13);
            this.LblClosingYear.Name = "LblClosingYear";
            this.LblClosingYear.Size = new System.Drawing.Size(58, 20);
            this.LblClosingYear.TabIndex = 0;
            this.LblClosingYear.Text = "Záróév";
            // 
            // LblPopulationFile
            // 
            this.LblPopulationFile.AutoSize = true;
            this.LblPopulationFile.Location = new System.Drawing.Point(240, 9);
            this.LblPopulationFile.Name = "LblPopulationFile";
            this.LblPopulationFile.Size = new System.Drawing.Size(110, 20);
            this.LblPopulationFile.TabIndex = 1;
            this.LblPopulationFile.Text = "Népesség Fájl";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(595, 9);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 35);
            this.BtnBrowse.TabIndex = 2;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(677, 9);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 35);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // numericClosing
            // 
            this.numericClosing.Location = new System.Drawing.Point(78, 9);
            this.numericClosing.Name = "numericClosing";
            this.numericClosing.Size = new System.Drawing.Size(120, 26);
            this.numericClosing.TabIndex = 4;
            // 
            // numericPopulation
            // 
            this.numericPopulation.Location = new System.Drawing.Point(365, 7);
            this.numericPopulation.Name = "numericPopulation";
            this.numericPopulation.Size = new System.Drawing.Size(120, 26);
            this.numericPopulation.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericPopulation);
            this.Controls.Add(this.numericClosing);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.LblPopulationFile);
            this.Controls.Add(this.LblClosingYear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericClosing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClosingYear;
        private System.Windows.Forms.Label LblPopulationFile;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.NumericUpDown numericClosing;
        private System.Windows.Forms.NumericUpDown numericPopulation;
    }
}

