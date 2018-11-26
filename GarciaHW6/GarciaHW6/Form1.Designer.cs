namespace GarciaHW6
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
            this.InfoListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.greatestLabel = new System.Windows.Forms.Label();
            this.lowestLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.IncreaseListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // InfoListBox
            // 
            this.InfoListBox.FormattingEnabled = true;
            this.InfoListBox.Location = new System.Drawing.Point(15, 12);
            this.InfoListBox.Name = "InfoListBox";
            this.InfoListBox.Size = new System.Drawing.Size(120, 95);
            this.InfoListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Average Annual Change:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(65, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Greatest Increase:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(65, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lowest Increase:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.averageLabel.Location = new System.Drawing.Point(170, 125);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(66, 23);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greatestLabel
            // 
            this.greatestLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greatestLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.greatestLabel.Location = new System.Drawing.Point(170, 167);
            this.greatestLabel.Name = "greatestLabel";
            this.greatestLabel.Size = new System.Drawing.Size(117, 23);
            this.greatestLabel.TabIndex = 5;
            this.greatestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowestLabel
            // 
            this.lowestLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lowestLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lowestLabel.Location = new System.Drawing.Point(170, 206);
            this.lowestLabel.Name = "lowestLabel";
            this.lowestLabel.Size = new System.Drawing.Size(117, 23);
            this.lowestLabel.TabIndex = 6;
            this.lowestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(212, 241);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(57, 241);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // IncreaseListBox
            // 
            this.IncreaseListBox.FormattingEnabled = true;
            this.IncreaseListBox.Location = new System.Drawing.Point(167, 12);
            this.IncreaseListBox.Name = "IncreaseListBox";
            this.IncreaseListBox.Size = new System.Drawing.Size(120, 95);
            this.IncreaseListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 267);
            this.Controls.Add(this.IncreaseListBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lowestLabel);
            this.Controls.Add(this.greatestLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoListBox);
            this.Name = "Form1";
            this.Text = "Population Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InfoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label greatestLabel;
        private System.Windows.Forms.Label lowestLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.ListBox IncreaseListBox;
    }
}

