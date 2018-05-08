namespace RandomNumFunctionTivaR
{
    partial class frmRandNumFunction
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
            this.btnGenerateRandNum = new System.Windows.Forms.Button();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateRandNum
            // 
            this.btnGenerateRandNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateRandNum.Location = new System.Drawing.Point(98, 27);
            this.btnGenerateRandNum.Name = "btnGenerateRandNum";
            this.btnGenerateRandNum.Size = new System.Drawing.Size(127, 94);
            this.btnGenerateRandNum.TabIndex = 0;
            this.btnGenerateRandNum.Text = "Generate Random Number ";
            this.btnGenerateRandNum.UseVisualStyleBackColor = true;
            this.btnGenerateRandNum.Click += new System.EventHandler(this.btnGenerateRandNum_Click);
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.Location = new System.Drawing.Point(99, 166);
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(126, 20);
            this.nudMaxValue.TabIndex = 1;
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Location = new System.Drawing.Point(98, 222);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(35, 13);
            this.lblRandomNumber.TabIndex = 2;
            this.lblRandomNumber.Text = "label1";
            // 
            // frmRandNumFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 289);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.nudMaxValue);
            this.Controls.Add(this.btnGenerateRandNum);
            this.Name = "frmRandNumFunction";
            this.Text = "Random Number Function by Tiva Rait";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateRandNum;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
        private System.Windows.Forms.Label lblRandomNumber;
    }
}

