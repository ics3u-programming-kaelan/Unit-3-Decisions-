﻿namespace runningAverageKaelanK
{
    partial class runningAverageForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblTooHigh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(224, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(32, 35);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(177, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Enter a number between  1 and 100";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(35, 87);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(32, 144);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(25, 13);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "???";
            // 
            // lblTooHigh
            // 
            this.lblTooHigh.AutoSize = true;
            this.lblTooHigh.Location = new System.Drawing.Point(161, 97);
            this.lblTooHigh.Name = "lblTooHigh";
            this.lblTooHigh.Size = new System.Drawing.Size(197, 13);
            this.lblTooHigh.TabIndex = 4;
            this.lblTooHigh.Text = "The Value You Inputed Was Above 100";
            this.lblTooHigh.Click += new System.EventHandler(this.Label1_Click);
            // 
            // runningAverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTooHigh);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Name = "runningAverageForm";
            this.Text = "Running Average by Kaelan K";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblTooHigh;
    }
}

