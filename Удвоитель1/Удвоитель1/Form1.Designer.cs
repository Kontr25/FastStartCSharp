namespace Удвоитель1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.informlbl = new System.Windows.Forms.Label();
            this.ConditionLbl = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(406, 12);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(406, 68);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(406, 132);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(222, 117);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            this.lblNumber.TextChanged += new System.EventHandler(this.lblNumber_TextChanged);
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(12, 78);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(35, 13);
            this.Count.TabIndex = 4;
            this.Count.Text = "label1";
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // informlbl
            // 
            this.informlbl.Location = new System.Drawing.Point(12, 31);
            this.informlbl.Name = "informlbl";
            this.informlbl.Size = new System.Drawing.Size(167, 35);
            this.informlbl.TabIndex = 5;
            this.informlbl.Text = "label1";
            this.informlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConditionLbl
            // 
            this.ConditionLbl.AutoSize = true;
            this.ConditionLbl.Location = new System.Drawing.Point(129, 78);
            this.ConditionLbl.Name = "ConditionLbl";
            this.ConditionLbl.Size = new System.Drawing.Size(209, 13);
            this.ConditionLbl.TabIndex = 7;
            this.ConditionLbl.Text = "Вам нужно набрать число 72 за 8 ходов";
            this.ConditionLbl.Click += new System.EventHandler(this.ConditionLbl_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(188, 145);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 8;
            this.checkBtn.Text = "Проверить";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 221);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.ConditionLbl);
            this.Controls.Add(this.informlbl);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label informlbl;
        private System.Windows.Forms.Label ConditionLbl;
        private System.Windows.Forms.Button checkBtn;
    }
}

