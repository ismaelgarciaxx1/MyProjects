namespace GarciaHW1
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.JackBox = new System.Windows.Forms.PictureBox();
            this.QueenBox = new System.Windows.Forms.PictureBox();
            this.KingBox = new System.Windows.Forms.PictureBox();
            this.AcePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click A Card Any Card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(162, 258);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(318, 54);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GarciaHW1.Properties.Resources._10_Diamonds;
            this.pictureBox2.Location = new System.Drawing.Point(429, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 73);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // JackBox
            // 
            this.JackBox.Image = global::GarciaHW1.Properties.Resources.Jack_Diamonds;
            this.JackBox.Location = new System.Drawing.Point(334, 112);
            this.JackBox.Name = "JackBox";
            this.JackBox.Size = new System.Drawing.Size(49, 73);
            this.JackBox.TabIndex = 5;
            this.JackBox.TabStop = false;
            this.JackBox.Click += new System.EventHandler(this.JackBox_Click);
            // 
            // QueenBox
            // 
            this.QueenBox.Image = global::GarciaHW1.Properties.Resources.Queen_Diamonds;
            this.QueenBox.Location = new System.Drawing.Point(241, 114);
            this.QueenBox.Name = "QueenBox";
            this.QueenBox.Size = new System.Drawing.Size(52, 71);
            this.QueenBox.TabIndex = 4;
            this.QueenBox.TabStop = false;
            this.QueenBox.Click += new System.EventHandler(this.QueenBox_Click);
            // 
            // KingBox
            // 
            this.KingBox.Image = global::GarciaHW1.Properties.Resources.King_Diamonds1;
            this.KingBox.Location = new System.Drawing.Point(162, 112);
            this.KingBox.Name = "KingBox";
            this.KingBox.Size = new System.Drawing.Size(52, 71);
            this.KingBox.TabIndex = 3;
            this.KingBox.TabStop = false;
            this.KingBox.Click += new System.EventHandler(this.KingBox_Click);
            // 
            // AcePictureBox
            // 
            this.AcePictureBox.Image = global::GarciaHW1.Properties.Resources.Ace_Diamonds;
            this.AcePictureBox.Location = new System.Drawing.Point(70, 114);
            this.AcePictureBox.Name = "AcePictureBox";
            this.AcePictureBox.Size = new System.Drawing.Size(50, 71);
            this.AcePictureBox.TabIndex = 0;
            this.AcePictureBox.TabStop = false;
            this.AcePictureBox.Click += new System.EventHandler(this.AcePictureBox_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(530, 275);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 370);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.JackBox);
            this.Controls.Add(this.QueenBox);
            this.Controls.Add(this.KingBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcePictureBox);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AcePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox KingBox;
        private System.Windows.Forms.PictureBox QueenBox;
        private System.Windows.Forms.PictureBox JackBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ExitButton;
    }
}

