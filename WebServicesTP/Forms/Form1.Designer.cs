namespace Forms
{
    partial class Form1
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
            this.textTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.listResponse = new System.Windows.Forms.ListBox();
            this.listType = new System.Windows.Forms.ListBox();
            this.listYear = new System.Windows.Forms.ListBox();
            this.PageIndicator = new System.Windows.Forms.TextBox();
            this.GoLeft = new System.Windows.Forms.Button();
            this.GoRight = new System.Windows.Forms.Button();
            this.GoToLastPage = new System.Windows.Forms.Button();
            this.GoToFirstPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(84, 25);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(219, 20);
            this.textTitle.TabIndex = 0;
            this.textTitle.TextChanged += new System.EventHandler(this.textTitle_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(51, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(43, 131);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(39, 13);
            this.Output.TabIndex = 4;
            this.Output.Text = "Output";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(51, 48);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 5;
            this.Type.Text = "Type";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(84, 48);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(219, 20);
            this.textType.TabIndex = 6;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(51, 71);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 7;
            this.Year.Text = "Year";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(84, 71);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(219, 20);
            this.textYear.TabIndex = 8;
            // 
            // listResponse
            // 
            this.listResponse.FormattingEnabled = true;
            this.listResponse.Location = new System.Drawing.Point(84, 131);
            this.listResponse.Name = "listResponse";
            this.listResponse.Size = new System.Drawing.Size(140, 147);
            this.listResponse.TabIndex = 9;
            this.listResponse.SelectedIndexChanged += new System.EventHandler(this.listResponse_SelectedIndexChanged);
            // 
            // listType
            // 
            this.listType.FormattingEnabled = true;
            this.listType.Location = new System.Drawing.Point(221, 131);
            this.listType.Name = "listType";
            this.listType.Size = new System.Drawing.Size(82, 147);
            this.listType.TabIndex = 10;
            this.listType.SelectedIndexChanged += new System.EventHandler(this.listType_SelectedIndexChanged_1);
            // 
            // listYear
            // 
            this.listYear.FormattingEnabled = true;
            this.listYear.Location = new System.Drawing.Point(300, 131);
            this.listYear.Name = "listYear";
            this.listYear.Size = new System.Drawing.Size(84, 147);
            this.listYear.TabIndex = 11;
            this.listYear.SelectedIndexChanged += new System.EventHandler(this.listYear_SelectedIndexChanged_1);
            // 
            // PageIndicator
            // 
            this.PageIndicator.Location = new System.Drawing.Point(149, 286);
            this.PageIndicator.Name = "PageIndicator";
            this.PageIndicator.Size = new System.Drawing.Size(43, 20);
            this.PageIndicator.TabIndex = 12;
            // 
            // GoLeft
            // 
            this.GoLeft.Location = new System.Drawing.Point(112, 284);
            this.GoLeft.Name = "GoLeft";
            this.GoLeft.Size = new System.Drawing.Size(31, 23);
            this.GoLeft.TabIndex = 13;
            this.GoLeft.Text = "<";
            this.GoLeft.UseVisualStyleBackColor = true;
            // 
            // GoRight
            // 
            this.GoRight.Location = new System.Drawing.Point(198, 284);
            this.GoRight.Name = "GoRight";
            this.GoRight.Size = new System.Drawing.Size(31, 23);
            this.GoRight.TabIndex = 14;
            this.GoRight.Text = ">";
            this.GoRight.UseVisualStyleBackColor = true;
            // 
            // GoToLastPage
            // 
            this.GoToLastPage.Location = new System.Drawing.Point(235, 283);
            this.GoToLastPage.Name = "GoToLastPage";
            this.GoToLastPage.Size = new System.Drawing.Size(31, 23);
            this.GoToLastPage.TabIndex = 15;
            this.GoToLastPage.Text = ">>";
            this.GoToLastPage.UseVisualStyleBackColor = true;
            // 
            // GoToFirstPage
            // 
            this.GoToFirstPage.Location = new System.Drawing.Point(75, 283);
            this.GoToFirstPage.Name = "GoToFirstPage";
            this.GoToFirstPage.Size = new System.Drawing.Size(31, 23);
            this.GoToFirstPage.TabIndex = 16;
            this.GoToFirstPage.Text = "<<";
            this.GoToFirstPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GoToFirstPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 422);
            this.Controls.Add(this.GoToFirstPage);
            this.Controls.Add(this.GoToLastPage);
            this.Controls.Add(this.GoRight);
            this.Controls.Add(this.GoLeft);
            this.Controls.Add(this.PageIndicator);
            this.Controls.Add(this.listYear);
            this.Controls.Add(this.listType);
            this.Controls.Add(this.listResponse);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.ListBox listResponse;
        private System.Windows.Forms.ListBox listType;
        private System.Windows.Forms.ListBox listYear;
        private System.Windows.Forms.TextBox PageIndicator;
        private System.Windows.Forms.Button GoLeft;
        private System.Windows.Forms.Button GoRight;
        private System.Windows.Forms.Button GoToLastPage;
        private System.Windows.Forms.Button GoToFirstPage;
    }
}

