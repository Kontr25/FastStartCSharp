namespace Удвоитель1
{
    partial class FormLose
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
            this.loseLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loseLbl
            // 
            this.loseLbl.AutoSize = true;
            this.loseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loseLbl.Location = new System.Drawing.Point(-2, 85);
            this.loseLbl.Name = "loseLbl";
            this.loseLbl.Size = new System.Drawing.Size(474, 39);
            this.loseLbl.TabIndex = 0;
            this.loseLbl.Text = "К сожалению вы проиграли:(";
            this.loseLbl.Click += new System.EventHandler(this.loseLbl_Click);
            // 
            // FormLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 221);
            this.Controls.Add(this.loseLbl);
            this.Name = "FormLose";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loseLbl;
    }
}