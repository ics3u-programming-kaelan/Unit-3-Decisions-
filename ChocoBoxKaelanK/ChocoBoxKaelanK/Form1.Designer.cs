namespace ChocoBoxKaelanK
{
    partial class frmChocoBoxes
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
            this.lblAskForBoxes = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.lblPrizeOutput = new System.Windows.Forms.Label();
            this.txtBoxes = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAskForBoxes
            // 
            this.lblAskForBoxes.AutoSize = true;
            this.lblAskForBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskForBoxes.Location = new System.Drawing.Point(12, 75);
            this.lblAskForBoxes.Name = "lblAskForBoxes";
            this.lblAskForBoxes.Size = new System.Drawing.Size(370, 20);
            this.lblAskForBoxes.TabIndex = 0;
            this.lblAskForBoxes.Text = "Insert the amount of chocolate boxes that you sold:";
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(54, 243);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(103, 20);
            this.lblPrize.TabIndex = 1;
            this.lblPrize.Text = "Your Prize Is:";
            // 
            // lblPrizeOutput
            // 
            this.lblPrizeOutput.AutoSize = true;
            this.lblPrizeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrizeOutput.Location = new System.Drawing.Point(188, 243);
            this.lblPrizeOutput.Name = "lblPrizeOutput";
            this.lblPrizeOutput.Size = new System.Drawing.Size(51, 20);
            this.lblPrizeOutput.TabIndex = 2;
            this.lblPrizeOutput.Text = "label3";
            // 
            // txtBoxes
            // 
            this.txtBoxes.Location = new System.Drawing.Point(388, 77);
            this.txtBoxes.Name = "txtBoxes";
            this.txtBoxes.Size = new System.Drawing.Size(100, 20);
            this.txtBoxes.TabIndex = 3;
            this.txtBoxes.TextChanged += new System.EventHandler(this.TxtBoxes_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(126, 139);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 49);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Check";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // frmChocoBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBoxes);
            this.Controls.Add(this.lblPrizeOutput);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblAskForBoxes);
            this.Name = "frmChocoBoxes";
            this.Text = "Chocolate Boxes by Kaelan K";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAskForBoxes;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label lblPrizeOutput;
        private System.Windows.Forms.TextBox txtBoxes;
        private System.Windows.Forms.Button btnCalculate;
    }
}

