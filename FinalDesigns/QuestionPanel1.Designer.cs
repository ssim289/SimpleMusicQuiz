namespace FinalDesigns
{
    partial class QuestionPanel1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionPanel1));
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.btnQ1A = new System.Windows.Forms.Button();
            this.btnQ1B = new System.Windows.Forms.Button();
            this.btnQ1C = new System.Windows.Forms.Button();
            this.btnQ1D = new System.Windows.Forms.Button();
            this.pnlQuestion1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlQuestion1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLbl.ForeColor = System.Drawing.Color.Black;
            this.QuestionLbl.Location = new System.Drawing.Point(15, 29);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(366, 112);
            this.QuestionLbl.TabIndex = 1;
            this.QuestionLbl.Text = "Which of these is a musical element?";
            // 
            // btnQ1A
            // 
            this.btnQ1A.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQ1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1A.ForeColor = System.Drawing.Color.Black;
            this.btnQ1A.Location = new System.Drawing.Point(510, 8);
            this.btnQ1A.Name = "btnQ1A";
            this.btnQ1A.Size = new System.Drawing.Size(221, 91);
            this.btnQ1A.TabIndex = 2;
            this.btnQ1A.Text = "Feel";
            this.btnQ1A.UseVisualStyleBackColor = false;
            // 
            // btnQ1B
            // 
            this.btnQ1B.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQ1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1B.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQ1B.Location = new System.Drawing.Point(510, 118);
            this.btnQ1B.Name = "btnQ1B";
            this.btnQ1B.Size = new System.Drawing.Size(221, 91);
            this.btnQ1B.TabIndex = 3;
            this.btnQ1B.Text = "Rhythm";
            this.btnQ1B.UseVisualStyleBackColor = false;
            // 
            // btnQ1C
            // 
            this.btnQ1C.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQ1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1C.ForeColor = System.Drawing.Color.Black;
            this.btnQ1C.Location = new System.Drawing.Point(510, 232);
            this.btnQ1C.Name = "btnQ1C";
            this.btnQ1C.Size = new System.Drawing.Size(221, 91);
            this.btnQ1C.TabIndex = 4;
            this.btnQ1C.Text = "Sound";
            this.btnQ1C.UseVisualStyleBackColor = false;
            // 
            // btnQ1D
            // 
            this.btnQ1D.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQ1D.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1D.ForeColor = System.Drawing.Color.Black;
            this.btnQ1D.Location = new System.Drawing.Point(510, 345);
            this.btnQ1D.Name = "btnQ1D";
            this.btnQ1D.Size = new System.Drawing.Size(221, 91);
            this.btnQ1D.TabIndex = 5;
            this.btnQ1D.Text = "Theme";
            this.btnQ1D.UseVisualStyleBackColor = false;
            this.btnQ1D.Click += new System.EventHandler(this.BtnQ1D_Click);
            // 
            // pnlQuestion1
            // 
            this.pnlQuestion1.Controls.Add(this.pictureBox2);
            this.pnlQuestion1.Controls.Add(this.pictureBox1);
            this.pnlQuestion1.Controls.Add(this.btnQ1D);
            this.pnlQuestion1.Controls.Add(this.btnQ1C);
            this.pnlQuestion1.Controls.Add(this.btnQ1B);
            this.pnlQuestion1.Controls.Add(this.btnQ1A);
            this.pnlQuestion1.Controls.Add(this.QuestionLbl);
            this.pnlQuestion1.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestion1.Name = "pnlQuestion1";
            this.pnlQuestion1.Size = new System.Drawing.Size(757, 465);
            this.pnlQuestion1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(409, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // QuestionPanel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQuestion1);
            this.Name = "QuestionPanel1";
            this.Size = new System.Drawing.Size(762, 476);
            this.pnlQuestion1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label QuestionLbl;
        private System.Windows.Forms.Button btnQ1A;
        private System.Windows.Forms.Button btnQ1B;
        private System.Windows.Forms.Button btnQ1C;
        private System.Windows.Forms.Button btnQ1D;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlQuestion1;
    }
}
