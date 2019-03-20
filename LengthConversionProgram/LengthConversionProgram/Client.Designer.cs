namespace LengthConversionProgram
{
    partial class Client
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
            this.kiloTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SolutionBox = new System.Windows.Forms.TextBox();
            this.Spinner = new System.Windows.Forms.ComboBox();
            this.ConverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kiloTextBox
            // 
            this.kiloTextBox.Location = new System.Drawing.Point(40, 79);
            this.kiloTextBox.Name = "kiloTextBox";
            this.kiloTextBox.Size = new System.Drawing.Size(113, 20);
            this.kiloTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kilometers";
            // 
            // SolutionBox
            // 
            this.SolutionBox.Location = new System.Drawing.Point(40, 150);
            this.SolutionBox.Name = "SolutionBox";
            this.SolutionBox.Size = new System.Drawing.Size(113, 20);
            this.SolutionBox.TabIndex = 2;
            // 
            // Spinner
            // 
            this.Spinner.FormattingEnabled = true;
            this.Spinner.Location = new System.Drawing.Point(172, 150);
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(99, 21);
            this.Spinner.TabIndex = 3;
            // 
            // ConverBtn
            // 
            this.ConverBtn.Location = new System.Drawing.Point(40, 214);
            this.ConverBtn.Name = "ConverBtn";
            this.ConverBtn.Size = new System.Drawing.Size(75, 23);
            this.ConverBtn.TabIndex = 4;
            this.ConverBtn.Text = "Convert";
            this.ConverBtn.UseVisualStyleBackColor = true;
            this.ConverBtn.Click += new System.EventHandler(this.ConverBtn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.ConverBtn);
            this.Controls.Add(this.Spinner);
            this.Controls.Add(this.SolutionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kiloTextBox);
            this.Name = "Client";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kiloTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SolutionBox;
        private System.Windows.Forms.ComboBox Spinner;
        private System.Windows.Forms.Button ConverBtn;
    }
}

