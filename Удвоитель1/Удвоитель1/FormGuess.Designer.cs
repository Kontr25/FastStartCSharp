namespace Удвоитель1
{
    partial class FormGuess
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
            this.answerBox = new System.Windows.Forms.TextBox();
            this.checkAnswer = new System.Windows.Forms.Button();
            this.NumberBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerBox
            // 
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerBox.Location = new System.Drawing.Point(16, 58);
            this.answerBox.Multiline = true;
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(62, 58);
            this.answerBox.TabIndex = 1;
            // 
            // checkAnswer
            // 
            this.checkAnswer.Location = new System.Drawing.Point(16, 142);
            this.checkAnswer.Name = "checkAnswer";
            this.checkAnswer.Size = new System.Drawing.Size(75, 23);
            this.checkAnswer.TabIndex = 2;
            this.checkAnswer.Text = "Проверить";
            this.checkAnswer.UseVisualStyleBackColor = true;
            this.checkAnswer.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // NumberBtn
            // 
            this.NumberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberBtn.Location = new System.Drawing.Point(36, 33);
            this.NumberBtn.Name = "NumberBtn";
            this.NumberBtn.Size = new System.Drawing.Size(526, 95);
            this.NumberBtn.TabIndex = 3;
            this.NumberBtn.Text = "Нажмите чтобы сгенерировать число от 1 до 100";
            this.NumberBtn.UseVisualStyleBackColor = true;
            this.NumberBtn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.Location = new System.Drawing.Point(12, 119);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(51, 20);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "label1";
            this.resultLbl.Click += new System.EventHandler(this.resultLbl_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl1.Location = new System.Drawing.Point(12, 21);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(60, 24);
            this.Lbl1.TabIndex = 5;
            this.Lbl1.Text = "label1";
            this.Lbl1.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // FormGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 181);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.NumberBtn);
            this.Controls.Add(this.checkAnswer);
            this.Controls.Add(this.answerBox);
            this.Name = "FormGuess";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Button checkAnswer;
        private System.Windows.Forms.Button NumberBtn;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label Lbl1;
    }
}