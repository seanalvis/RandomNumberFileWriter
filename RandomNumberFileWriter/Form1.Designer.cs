namespace RandomNumberFileWriter
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
            this.label1 = new System.Windows.Forms.Label();
            this.showNumbersListBox = new System.Windows.Forms.ListBox();
            this.showNumbersButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.numOfNumbersTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveRandomNumFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Number Generator";
            // 
            // showNumbersListBox
            // 
            this.showNumbersListBox.FormattingEnabled = true;
            this.showNumbersListBox.ItemHeight = 20;
            this.showNumbersListBox.Location = new System.Drawing.Point(113, 153);
            this.showNumbersListBox.Name = "showNumbersListBox";
            this.showNumbersListBox.Size = new System.Drawing.Size(402, 184);
            this.showNumbersListBox.TabIndex = 1;
            // 
            // showNumbersButton
            // 
            this.showNumbersButton.Location = new System.Drawing.Point(48, 387);
            this.showNumbersButton.Name = "showNumbersButton";
            this.showNumbersButton.Size = new System.Drawing.Size(113, 53);
            this.showNumbersButton.TabIndex = 2;
            this.showNumbersButton.Text = "&Show Numbers";
            this.showNumbersButton.UseVisualStyleBackColor = true;
            this.showNumbersButton.Click += new System.EventHandler(this.showNumbersButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(192, 387);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 53);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(346, 387);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 53);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // numOfNumbersTextBox
            // 
            this.numOfNumbersTextBox.Location = new System.Drawing.Point(440, 93);
            this.numOfNumbersTextBox.Name = "numOfNumbersTextBox";
            this.numOfNumbersTextBox.Size = new System.Drawing.Size(100, 26);
            this.numOfNumbersTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter how many random numbers you want:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(490, 387);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 53);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 593);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOfNumbersTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showNumbersButton);
            this.Controls.Add(this.showNumbersListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox showNumbersListBox;
        private System.Windows.Forms.Button showNumbersButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox numOfNumbersTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.SaveFileDialog saveRandomNumFile;
    }
}

