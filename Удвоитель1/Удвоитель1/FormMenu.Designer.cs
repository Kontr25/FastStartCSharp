namespace Удвоитель1
{
    partial class FormMenu
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
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnPlay2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(120, 12);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(218, 44);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.TabStop = false;
            this.BtnPlay.Text = "Играть в игру удвоитель";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnPlay2
            // 
            this.BtnPlay2.Location = new System.Drawing.Point(120, 85);
            this.BtnPlay2.Name = "BtnPlay2";
            this.BtnPlay2.Size = new System.Drawing.Size(218, 47);
            this.BtnPlay2.TabIndex = 1;
            this.BtnPlay2.Text = "Играть в игру \"Угадай число\"";
            this.BtnPlay2.UseVisualStyleBackColor = true;
            this.BtnPlay2.Click += new System.EventHandler(this.BtnPlay2_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 221);
            this.Controls.Add(this.BtnPlay2);
            this.Controls.Add(this.BtnPlay);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnPlay2;
    }
}