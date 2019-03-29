namespace Guessanumber
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TitleName = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Button1to10 = new System.Windows.Forms.Button();
            this.Button1to20 = new System.Windows.Forms.Button();
            this.Button1to50 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 73);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(435, 19);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // TitleName
            // 
            this.TitleName.AutoSize = true;
            this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleName.ForeColor = System.Drawing.Color.Lime;
            this.TitleName.Location = new System.Drawing.Point(146, 110);
            this.TitleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(317, 31);
            this.TitleName.TabIndex = 14;
            this.TitleName.Text = "Guess a Number Game";
            this.TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleName.Click += new System.EventHandler(this.TitleName_Click);
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.ForeColor = System.Drawing.Color.Red;
            this.InstructionLabel.Location = new System.Drawing.Point(27, 150);
            this.InstructionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(250, 20);
            this.InstructionLabel.TabIndex = 15;
            this.InstructionLabel.Text = "Instructions to play this game:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Indigo;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.Lime;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Computer will pick a secret number.",
            "You have to guess this number.",
            "If you guess a wrong number, computer will give you a hint whether number is too " +
                "low or too high.",
            "There are three levels and each level has three attempts."});
            this.checkedListBox1.Location = new System.Drawing.Point(30, 183);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(511, 94);
            this.checkedListBox1.TabIndex = 16;
            // 
            // Button1to10
            // 
            this.Button1to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1to10.Location = new System.Drawing.Point(31, 306);
            this.Button1to10.Name = "Button1to10";
            this.Button1to10.Size = new System.Drawing.Size(121, 23);
            this.Button1to10.TabIndex = 18;
            this.Button1to10.Text = "1 to 10";
            this.Button1to10.UseVisualStyleBackColor = true;
            this.Button1to10.Click += new System.EventHandler(this.Button1to10_Click);
            // 
            // Button1to20
            // 
            this.Button1to20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1to20.Location = new System.Drawing.Point(227, 306);
            this.Button1to20.Name = "Button1to20";
            this.Button1to20.Size = new System.Drawing.Size(121, 23);
            this.Button1to20.TabIndex = 19;
            this.Button1to20.Text = "1 to 20";
            this.Button1to20.UseVisualStyleBackColor = true;
            this.Button1to20.Click += new System.EventHandler(this.Button1to20_Click);
            // 
            // Button1to50
            // 
            this.Button1to50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1to50.Location = new System.Drawing.Point(420, 306);
            this.Button1to50.Name = "Button1to50";
            this.Button1to50.Size = new System.Drawing.Size(121, 23);
            this.Button1to50.TabIndex = 20;
            this.Button1to50.Text = "1 to 50";
            this.Button1to50.UseVisualStyleBackColor = true;
            this.Button1to50.Click += new System.EventHandler(this.Button1to50_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Choose the level to play";
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(595, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button1to50);
            this.Controls.Add(this.Button1to20);
            this.Controls.Add(this.Button1to10);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.TitleName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Button1to10;
        private System.Windows.Forms.Button Button1to20;
        private System.Windows.Forms.Button Button1to50;
        private System.Windows.Forms.Label label1;
    }
}