namespace Guessanumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txtnumber1To10 = new System.Windows.Forms.TextBox();
            this.Txtnumber20To40 = new System.Windows.Forms.TextBox();
            this.Txtnumber50To100 = new System.Windows.Forms.TextBox();
            this.Buttonresult1to10 = new System.Windows.Forms.Button();
            this.Buttonresult20to40 = new System.Windows.Forms.Button();
            this.Buttonresult50to100 = new System.Windows.Forms.Button();
            this.Label1to10 = new System.Windows.Forms.Label();
            this.Label20to40 = new System.Windows.Forms.Label();
            this.Label50to100 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
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
            this.TitleName.Location = new System.Drawing.Point(201, 137);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(458, 46);
            this.TitleName.TabIndex = 0;
            this.TitleName.Text = "Guess a Number Game";
            this.TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 112);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Txtnumber1To10
            // 
            this.Txtnumber1To10.Location = new System.Drawing.Point(363, 218);
            this.Txtnumber1To10.Name = "Txtnumber1To10";
            this.Txtnumber1To10.Size = new System.Drawing.Size(185, 26);
            this.Txtnumber1To10.TabIndex = 2;
            this.Txtnumber1To10.TextChanged += new System.EventHandler(this.Txtnumber1To10_TextChanged);
            // 
            // Txtnumber20To40
            // 
            this.Txtnumber20To40.Location = new System.Drawing.Point(363, 289);
            this.Txtnumber20To40.Name = "Txtnumber20To40";
            this.Txtnumber20To40.Size = new System.Drawing.Size(185, 26);
            this.Txtnumber20To40.TabIndex = 3;
            this.Txtnumber20To40.TextChanged += new System.EventHandler(this.Txtnumber20To40_TextChanged);
            // 
            // Txtnumber50To100
            // 
            this.Txtnumber50To100.Location = new System.Drawing.Point(363, 366);
            this.Txtnumber50To100.Name = "Txtnumber50To100";
            this.Txtnumber50To100.Size = new System.Drawing.Size(185, 26);
            this.Txtnumber50To100.TabIndex = 4;
            this.Txtnumber50To100.TextChanged += new System.EventHandler(this.Txtnumber50To100_TextChanged);
            // 
            // Buttonresult1to10
            // 
            this.Buttonresult1to10.BackColor = System.Drawing.Color.Maroon;
            this.Buttonresult1to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonresult1to10.ForeColor = System.Drawing.Color.Gold;
            this.Buttonresult1to10.Location = new System.Drawing.Point(596, 210);
            this.Buttonresult1to10.Name = "Buttonresult1to10";
            this.Buttonresult1to10.Size = new System.Drawing.Size(185, 39);
            this.Buttonresult1to10.TabIndex = 5;
            this.Buttonresult1to10.Text = "Check Answer";
            this.Buttonresult1to10.UseVisualStyleBackColor = false;
            this.Buttonresult1to10.Click += new System.EventHandler(this.Buttonresult1to10_Click);
            // 
            // Buttonresult20to40
            // 
            this.Buttonresult20to40.BackColor = System.Drawing.Color.Maroon;
            this.Buttonresult20to40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonresult20to40.ForeColor = System.Drawing.Color.Gold;
            this.Buttonresult20to40.Location = new System.Drawing.Point(596, 276);
            this.Buttonresult20to40.Name = "Buttonresult20to40";
            this.Buttonresult20to40.Size = new System.Drawing.Size(185, 39);
            this.Buttonresult20to40.TabIndex = 6;
            this.Buttonresult20to40.Text = "Check Answer";
            this.Buttonresult20to40.UseVisualStyleBackColor = false;
            this.Buttonresult20to40.Click += new System.EventHandler(this.Buttonresult20to40_Click);
            // 
            // Buttonresult50to100
            // 
            this.Buttonresult50to100.BackColor = System.Drawing.Color.Maroon;
            this.Buttonresult50to100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonresult50to100.ForeColor = System.Drawing.Color.Gold;
            this.Buttonresult50to100.Location = new System.Drawing.Point(596, 353);
            this.Buttonresult50to100.Name = "Buttonresult50to100";
            this.Buttonresult50to100.Size = new System.Drawing.Size(185, 36);
            this.Buttonresult50to100.TabIndex = 7;
            this.Buttonresult50to100.Text = "Check Answer";
            this.Buttonresult50to100.UseVisualStyleBackColor = false;
            this.Buttonresult50to100.Click += new System.EventHandler(this.Buttonresult50to100_Click);
            // 
            // Label1to10
            // 
            this.Label1to10.AutoSize = true;
            this.Label1to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1to10.ForeColor = System.Drawing.Color.Gold;
            this.Label1to10.Location = new System.Drawing.Point(127, 217);
            this.Label1to10.Name = "Label1to10";
            this.Label1to10.Size = new System.Drawing.Size(191, 25);
            this.Label1to10.TabIndex = 8;
            this.Label1to10.Text = "Enter number 1-10";
            // 
            // Label20to40
            // 
            this.Label20to40.AutoSize = true;
            this.Label20to40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20to40.ForeColor = System.Drawing.Color.Gold;
            this.Label20to40.Location = new System.Drawing.Point(115, 288);
            this.Label20to40.Name = "Label20to40";
            this.Label20to40.Size = new System.Drawing.Size(203, 25);
            this.Label20to40.TabIndex = 9;
            this.Label20to40.Text = "Enter number 20-40";
            // 
            // Label50to100
            // 
            this.Label50to100.AutoSize = true;
            this.Label50to100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label50to100.ForeColor = System.Drawing.Color.Gold;
            this.Label50to100.Location = new System.Drawing.Point(115, 364);
            this.Label50to100.Name = "Label50to100";
            this.Label50to100.Size = new System.Drawing.Size(215, 25);
            this.Label50to100.TabIndex = 10;
            this.Label50to100.Text = "Enter number 50-100";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(661, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(896, 491);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Label50to100);
            this.Controls.Add(this.Label20to40);
            this.Controls.Add(this.Label1to10);
            this.Controls.Add(this.Buttonresult50to100);
            this.Controls.Add(this.Buttonresult20to40);
            this.Controls.Add(this.Buttonresult1to10);
            this.Controls.Add(this.Txtnumber50To100);
            this.Controls.Add(this.Txtnumber20To40);
            this.Controls.Add(this.Txtnumber1To10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txtnumber1To10;
        private System.Windows.Forms.TextBox Txtnumber20To40;
        private System.Windows.Forms.TextBox Txtnumber50To100;
        private System.Windows.Forms.Button Buttonresult1to10;
        private System.Windows.Forms.Button Buttonresult20to40;
        private System.Windows.Forms.Button Buttonresult50to100;
        private System.Windows.Forms.Label Label1to10;
        private System.Windows.Forms.Label Label20to40;
        private System.Windows.Forms.Label Label50to100;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

