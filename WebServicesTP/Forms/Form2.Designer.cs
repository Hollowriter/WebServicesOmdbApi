namespace Forms
{
    partial class Form2
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
            this.secondResponseBox = new System.Windows.Forms.TextBox();
            this.posterBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // secondResponseBox
            // 
            this.secondResponseBox.Location = new System.Drawing.Point(12, 12);
            this.secondResponseBox.Multiline = true;
            this.secondResponseBox.Name = "secondResponseBox";
            this.secondResponseBox.Size = new System.Drawing.Size(340, 493);
            this.secondResponseBox.TabIndex = 0;
            this.secondResponseBox.TextChanged += new System.EventHandler(this.secondResponseBox_TextChanged);
            // 
            // posterBox
            // 
            this.posterBox.Location = new System.Drawing.Point(358, 12);
            this.posterBox.Name = "posterBox";
            this.posterBox.Size = new System.Drawing.Size(282, 405);
            this.posterBox.TabIndex = 1;
            this.posterBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 423);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 82);
            this.textBox1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 517);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.posterBox);
            this.Controls.Add(this.secondResponseBox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.posterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondResponseBox;
        private System.Windows.Forms.PictureBox posterBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}