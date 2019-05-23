namespace MyCalculator
{
    partial class HomeCalculator
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
            this.FirstNumber = new System.Windows.Forms.Label();
            this.SecondNumber = new System.Windows.Forms.Label();
            this.FinalResult = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.AutoSize = true;
            this.FirstNumber.Location = new System.Drawing.Point(84, 66);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(66, 13);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Text = "First Number";
            // 
            // SecondNumber
            // 
            this.SecondNumber.AutoSize = true;
            this.SecondNumber.Location = new System.Drawing.Point(84, 101);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(84, 13);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.Text = "Second Number";
            // 
            // FinalResult
            // 
            this.FinalResult.AutoSize = true;
            this.FinalResult.Location = new System.Drawing.Point(84, 153);
            this.FinalResult.Name = "FinalResult";
            this.FinalResult.Size = new System.Drawing.Size(37, 13);
            this.FinalResult.TabIndex = 2;
            this.FinalResult.Text = "Result";
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(209, 59);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(211, 20);
            this.firstTextBox.TabIndex = 3;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(209, 98);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(211, 20);
            this.secondTextBox.TabIndex = 4;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(209, 146);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(211, 20);
            this.resultTextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(87, 270);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Location = new System.Drawing.Point(467, 270);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(75, 23);
            this.DivisionButton.TabIndex = 7;
            this.DivisionButton.Text = "Division";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(345, 270);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplyButton.TabIndex = 8;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(209, 270);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(75, 23);
            this.SubtractButton.TabIndex = 9;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // HomeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.FinalResult);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Name = "HomeCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNumber;
        private System.Windows.Forms.Label SecondNumber;
        private System.Windows.Forms.Label FinalResult;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SubtractButton;
    }
}

