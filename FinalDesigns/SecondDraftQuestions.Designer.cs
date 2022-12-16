namespace FinalDesigns
{
    partial class SecondDraftQuestions
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
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblQuestionNum = new System.Windows.Forms.Label();
            this.Qpnl1 = new FinalDesigns.QuestionPanel1();
            this.Qpnl2 = new FinalDesigns.QuestionPanel2();
            this.Qpnl3 = new FinalDesigns.QuestionPanel3();
            this.Qpnl4 = new FinalDesigns.QuestionPanel4();
            this.Qpnl5 = new FinalDesigns.QuestionPanel5();
            this.SuspendLayout();
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(376, 517);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(344, 63);
            this.btnNextQuestion.TabIndex = 13;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.BtnNextQuestion_Click);
            // 
            // lblQuestionNum
            // 
            this.lblQuestionNum.AutoSize = true;
            this.lblQuestionNum.BackColor = System.Drawing.Color.SteelBlue;
            this.lblQuestionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNum.ForeColor = System.Drawing.Color.Black;
            this.lblQuestionNum.Location = new System.Drawing.Point(60, 507);
            this.lblQuestionNum.Name = "lblQuestionNum";
            this.lblQuestionNum.Size = new System.Drawing.Size(231, 73);
            this.lblQuestionNum.TabIndex = 12;
            this.lblQuestionNum.Text = "Q 1/10";
            // 
            // Qpnl1
            // 
            this.Qpnl1.Location = new System.Drawing.Point(12, 12);
            this.Qpnl1.Name = "Qpnl1";
            this.Qpnl1.Size = new System.Drawing.Size(786, 453);
            this.Qpnl1.TabIndex = 14;
            // 
            // Qpnl2
            // 
            this.Qpnl2.Location = new System.Drawing.Point(12, 12);
            this.Qpnl2.Name = "Qpnl2";
            this.Qpnl2.Size = new System.Drawing.Size(765, 468);
            this.Qpnl2.TabIndex = 15;
            // 
            // Qpnl3
            // 
            this.Qpnl3.Location = new System.Drawing.Point(12, 12);
            this.Qpnl3.Name = "Qpnl3";
            this.Qpnl3.Size = new System.Drawing.Size(749, 453);
            this.Qpnl3.TabIndex = 16;
            // 
            // Qpnl4
            // 
            this.Qpnl4.Location = new System.Drawing.Point(12, 12);
            this.Qpnl4.Name = "Qpnl4";
            this.Qpnl4.Size = new System.Drawing.Size(749, 453);
            this.Qpnl4.TabIndex = 17;
            // 
            // Qpnl5
            // 
            this.Qpnl5.Location = new System.Drawing.Point(12, 28);
            this.Qpnl5.Name = "Qpnl5";
            this.Qpnl5.Size = new System.Drawing.Size(749, 452);
            this.Qpnl5.TabIndex = 18;
            this.Qpnl5.Load += new System.EventHandler(this.Qpnl5_Load);
            // 
            // SecondDraftQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.lblQuestionNum);
            this.Controls.Add(this.Qpnl5);
            this.Controls.Add(this.Qpnl4);
            this.Controls.Add(this.Qpnl3);
            this.Controls.Add(this.Qpnl2);
            this.Controls.Add(this.Qpnl1);
            this.Name = "SecondDraftQuestions";
            this.Text = "SecondDraftQuestions";
            this.Load += new System.EventHandler(this.SecondDraftQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblQuestionNum;
        private QuestionPanel1 Qpnl1;
        private QuestionPanel2 Qpnl2;
        private QuestionPanel3 Qpnl3;
        private QuestionPanel4 Qpnl4;
        private QuestionPanel5 Qpnl5;
    }
}