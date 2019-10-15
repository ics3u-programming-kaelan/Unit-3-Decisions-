namespace PerfectSquareWhileLoop
{
    partial class frmPerfectSquareLoop
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
            this.lstPerfectSquare = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudUserInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPerfectSquare
            // 
            this.lstPerfectSquare.FormattingEnabled = true;
            this.lstPerfectSquare.Location = new System.Drawing.Point(218, 167);
            this.lstPerfectSquare.Name = "lstPerfectSquare";
            this.lstPerfectSquare.Size = new System.Drawing.Size(197, 160);
            this.lstPerfectSquare.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(272, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // nudUserInput
            // 
            this.nudUserInput.Location = new System.Drawing.Point(254, 104);
            this.nudUserInput.Name = "nudUserInput";
            this.nudUserInput.Size = new System.Drawing.Size(120, 20);
            this.nudUserInput.TabIndex = 2;
            // 
            // frmPerfectSquareLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudUserInput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstPerfectSquare);
            this.Name = "frmPerfectSquareLoop";
            this.Text = "Perfect Sqaure Loop by ";
            ((System.ComponentModel.ISupportInitialize)(this.nudUserInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPerfectSquare;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudUserInput;
    }
}

