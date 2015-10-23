namespace RunningAverage
{
    partial class frmRunningAverage
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
            this.lblInstructions1 = new System.Windows.Forms.Label();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.btnEnterNumber = new System.Windows.Forms.Button();
            this.lblAnswertext = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions1
            // 
            this.lblInstructions1.AutoSize = true;
            this.lblInstructions1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions1.Location = new System.Drawing.Point(12, 23);
            this.lblInstructions1.Name = "lblInstructions1";
            this.lblInstructions1.Size = new System.Drawing.Size(191, 16);
            this.lblInstructions1.TabIndex = 0;
            this.lblInstructions1.Text = "Enter the next number (0 to 100)";
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions2.Location = new System.Drawing.Point(12, 39);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(93, 16);
            this.lblInstructions2.TabIndex = 1;
            this.lblInstructions2.Text = "Enter -1 to end";
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Location = new System.Drawing.Point(45, 82);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(122, 20);
            this.txtNumberInput.TabIndex = 2;
            // 
            // btnEnterNumber
            // 
            this.btnEnterNumber.Location = new System.Drawing.Point(62, 108);
            this.btnEnterNumber.Name = "btnEnterNumber";
            this.btnEnterNumber.Size = new System.Drawing.Size(89, 23);
            this.btnEnterNumber.TabIndex = 3;
            this.btnEnterNumber.Text = "Enter Number";
            this.btnEnterNumber.UseVisualStyleBackColor = true;
            this.btnEnterNumber.Click += new System.EventHandler(this.btnEnterNumber_Click);
            // 
            // lblAnswertext
            // 
            this.lblAnswertext.AutoSize = true;
            this.lblAnswertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswertext.Location = new System.Drawing.Point(12, 164);
            this.lblAnswertext.Name = "lblAnswertext";
            this.lblAnswertext.Size = new System.Drawing.Size(148, 16);
            this.lblAnswertext.TabIndex = 4;
            this.lblAnswertext.Text = "The running average is:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(166, 164);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 16);
            this.lblAnswer.TabIndex = 5;
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 192);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAnswertext);
            this.Controls.Add(this.btnEnterNumber);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.lblInstructions2);
            this.Controls.Add(this.lblInstructions1);
            this.Name = "frmRunningAverage";
            this.Text = "Runing Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions1;
        private System.Windows.Forms.Label lblInstructions2;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Button btnEnterNumber;
        private System.Windows.Forms.Label lblAnswertext;
        private System.Windows.Forms.Label lblAnswer;
    }
}

