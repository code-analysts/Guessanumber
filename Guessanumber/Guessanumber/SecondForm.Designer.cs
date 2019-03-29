namespace Guessanumber
{
    partial class SecondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondForm));
            this.TitleName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtGuessNumber = new System.Windows.Forms.TextBox();
            this.Buttonresult1to10 = new System.Windows.Forms.Button();
            this.Label1to10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleName
            // 
            this.TitleName.AutoSize = true;
            this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleName.ForeColor = System.Drawing.Color.Lime;
            this.TitleName.Location = new System.Drawing.Point(98, 98);
            this.TitleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(415, 31);
            this.TitleName.TabIndex = 0;
            this.TitleName.Text = "Three Attempts for each Level!\r\n";
            this.TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 73);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TxtGuessNumber
            // 
            this.TxtGuessNumber.Location = new System.Drawing.Point(274, 142);
            this.TxtGuessNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGuessNumber.Name = "TxtGuessNumber";
            this.TxtGuessNumber.Size = new System.Drawing.Size(125, 20);
            this.TxtGuessNumber.TabIndex = 2;
            // 
            // Buttonresult1to10
            // 
            this.Buttonresult1to10.BackColor = System.Drawing.Color.Maroon;
            this.Buttonresult1to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonresult1to10.ForeColor = System.Drawing.Color.Gold;
            this.Buttonresult1to10.Location = new System.Drawing.Point(440, 136);
            this.Buttonresult1to10.Margin = new System.Windows.Forms.Padding(2);
            this.Buttonresult1to10.Name = "Buttonresult1to10";
            this.Buttonresult1to10.Size = new System.Drawing.Size(123, 25);
            this.Buttonresult1to10.TabIndex = 5;
            this.Buttonresult1to10.Text = "Check Answer";
            this.Buttonresult1to10.UseVisualStyleBackColor = false;
            this.Buttonresult1to10.Click += new System.EventHandler(this.Buttonresult1to10_Click);
            // 
            // Label1to10
            // 
            this.Label1to10.AutoSize = true;
            this.Label1to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1to10.ForeColor = System.Drawing.Color.Gold;
            this.Label1to10.Location = new System.Drawing.Point(42, 141);
            this.Label1to10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1to10.Name = "Label1to10";
            this.Label1to10.Size = new System.Drawing.Size(144, 17);
            this.Label1to10.TabIndex = 8;
            this.Label1to10.Text = "Enter number 1-10";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(441, 17);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(257, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(597, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Label1to10);
            this.Controls.Add(this.Buttonresult1to10);
            this.Controls.Add(this.TxtGuessNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SecondForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtGuessNumber;
        private System.Windows.Forms.Button Buttonresult1to10;
        private System.Windows.Forms.Label Label1to10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}

