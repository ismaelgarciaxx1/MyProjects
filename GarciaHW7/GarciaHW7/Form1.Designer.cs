namespace GarciaHW7
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
            this.rootPictureBox = new System.Windows.Forms.PictureBox();
            this.LemonPictureBox = new System.Windows.Forms.PictureBox();
            this.grapePictureBox = new System.Windows.Forms.PictureBox();
            this.creamPictureBox = new System.Windows.Forms.PictureBox();
            this.colaPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colaLeftLabel = new System.Windows.Forms.Label();
            this.creamLeftLabel = new System.Windows.Forms.Label();
            this.grapeLeftLabel = new System.Windows.Forms.Label();
            this.lemonLeftLabel = new System.Windows.Forms.Label();
            this.rootLeftLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rootPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LemonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rootPictureBox
            // 
            this.rootPictureBox.Image = global::GarciaHW7.Properties.Resources.RootBeer;
            this.rootPictureBox.Location = new System.Drawing.Point(189, 83);
            this.rootPictureBox.Name = "rootPictureBox";
            this.rootPictureBox.Size = new System.Drawing.Size(181, 74);
            this.rootPictureBox.TabIndex = 4;
            this.rootPictureBox.TabStop = false;
            this.rootPictureBox.Click += new System.EventHandler(this.rootPictureBox_Click);
            // 
            // LemonPictureBox
            // 
            this.LemonPictureBox.Image = global::GarciaHW7.Properties.Resources.LemonLime;
            this.LemonPictureBox.Location = new System.Drawing.Point(189, 3);
            this.LemonPictureBox.Name = "LemonPictureBox";
            this.LemonPictureBox.Size = new System.Drawing.Size(181, 74);
            this.LemonPictureBox.TabIndex = 3;
            this.LemonPictureBox.TabStop = false;
            this.LemonPictureBox.Click += new System.EventHandler(this.LemonPictureBox_Click);
            // 
            // grapePictureBox
            // 
            this.grapePictureBox.Image = global::GarciaHW7.Properties.Resources.GrapeSoda;
            this.grapePictureBox.Location = new System.Drawing.Point(2, 163);
            this.grapePictureBox.Name = "grapePictureBox";
            this.grapePictureBox.Size = new System.Drawing.Size(181, 74);
            this.grapePictureBox.TabIndex = 2;
            this.grapePictureBox.TabStop = false;
            this.grapePictureBox.Click += new System.EventHandler(this.grapPictureBox_Click);
            // 
            // creamPictureBox
            // 
            this.creamPictureBox.Image = global::GarciaHW7.Properties.Resources.CreamSoda;
            this.creamPictureBox.Location = new System.Drawing.Point(2, 83);
            this.creamPictureBox.Name = "creamPictureBox";
            this.creamPictureBox.Size = new System.Drawing.Size(181, 74);
            this.creamPictureBox.TabIndex = 1;
            this.creamPictureBox.TabStop = false;
            this.creamPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // colaPictureBox
            // 
            this.colaPictureBox.Image = global::GarciaHW7.Properties.Resources.Cola;
            this.colaPictureBox.Location = new System.Drawing.Point(2, 3);
            this.colaPictureBox.Name = "colaPictureBox";
            this.colaPictureBox.Size = new System.Drawing.Size(181, 74);
            this.colaPictureBox.TabIndex = 0;
            this.colaPictureBox.TabStop = false;
            this.colaPictureBox.Click += new System.EventHandler(this.cokePictureBox_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(147, 243);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 48);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(189, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Sales:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(253, 191);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(67, 23);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(87, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "$1.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(275, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "$1.00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(275, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "$1.00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(87, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "$1.50";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(87, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "$1.50";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaLeftLabel
            // 
            this.colaLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colaLeftLabel.Location = new System.Drawing.Point(90, 44);
            this.colaLeftLabel.Name = "colaLeftLabel";
            this.colaLeftLabel.Size = new System.Drawing.Size(67, 23);
            this.colaLeftLabel.TabIndex = 13;
            this.colaLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creamLeftLabel
            // 
            this.creamLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.creamLeftLabel.Location = new System.Drawing.Point(90, 121);
            this.creamLeftLabel.Name = "creamLeftLabel";
            this.creamLeftLabel.Size = new System.Drawing.Size(67, 23);
            this.creamLeftLabel.TabIndex = 14;
            this.creamLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grapeLeftLabel
            // 
            this.grapeLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grapeLeftLabel.Location = new System.Drawing.Point(90, 203);
            this.grapeLeftLabel.Name = "grapeLeftLabel";
            this.grapeLeftLabel.Size = new System.Drawing.Size(67, 23);
            this.grapeLeftLabel.TabIndex = 15;
            this.grapeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lemonLeftLabel
            // 
            this.lemonLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lemonLeftLabel.Location = new System.Drawing.Point(275, 44);
            this.lemonLeftLabel.Name = "lemonLeftLabel";
            this.lemonLeftLabel.Size = new System.Drawing.Size(67, 23);
            this.lemonLeftLabel.TabIndex = 16;
            this.lemonLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rootLeftLabel
            // 
            this.rootLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rootLeftLabel.Location = new System.Drawing.Point(275, 121);
            this.rootLeftLabel.Name = "rootLeftLabel";
            this.rootLeftLabel.Size = new System.Drawing.Size(67, 23);
            this.rootLeftLabel.TabIndex = 17;
            this.rootLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 303);
            this.Controls.Add(this.rootLeftLabel);
            this.Controls.Add(this.lemonLeftLabel);
            this.Controls.Add(this.grapeLeftLabel);
            this.Controls.Add(this.creamLeftLabel);
            this.Controls.Add(this.colaLeftLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rootPictureBox);
            this.Controls.Add(this.LemonPictureBox);
            this.Controls.Add(this.grapePictureBox);
            this.Controls.Add(this.creamPictureBox);
            this.Controls.Add(this.colaPictureBox);
            this.Name = "Form1";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rootPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LemonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creamPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox colaPictureBox;
        private System.Windows.Forms.PictureBox creamPictureBox;
        private System.Windows.Forms.PictureBox grapePictureBox;
        private System.Windows.Forms.PictureBox LemonPictureBox;
        private System.Windows.Forms.PictureBox rootPictureBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label colaLeftLabel;
        private System.Windows.Forms.Label creamLeftLabel;
        private System.Windows.Forms.Label grapeLeftLabel;
        private System.Windows.Forms.Label lemonLeftLabel;
        private System.Windows.Forms.Label rootLeftLabel;
    }
}

