namespace DogRace_DevelopD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.First_Runner = new System.Windows.Forms.PictureBox();
            this.Second_Runner = new System.Windows.Forms.PictureBox();
            this.Thrd_Runner = new System.Windows.Forms.PictureBox();
            this.Forth_Runner = new System.Windows.Forms.PictureBox();
            this.betArea = new System.Windows.Forms.GroupBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Bet = new System.Windows.Forms.Button();
            this.nm_Amount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Dog = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_Player = new System.Windows.Forms.ComboBox();
            this.pb_Fan = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Runner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Second_Runner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thrd_Runner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forth_Runner)).BeginInit();
            this.betArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // First_Runner
            // 
            this.First_Runner.Image = ((System.Drawing.Image)(resources.GetObject("First_Runner.Image")));
            this.First_Runner.Location = new System.Drawing.Point(29, 429);
            this.First_Runner.Name = "First_Runner";
            this.First_Runner.Size = new System.Drawing.Size(54, 76);
            this.First_Runner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.First_Runner.TabIndex = 1;
            this.First_Runner.TabStop = false;
            // 
            // Second_Runner
            // 
            this.Second_Runner.Image = ((System.Drawing.Image)(resources.GetObject("Second_Runner.Image")));
            this.Second_Runner.Location = new System.Drawing.Point(127, 429);
            this.Second_Runner.Name = "Second_Runner";
            this.Second_Runner.Size = new System.Drawing.Size(54, 76);
            this.Second_Runner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Second_Runner.TabIndex = 2;
            this.Second_Runner.TabStop = false;
            // 
            // Thrd_Runner
            // 
            this.Thrd_Runner.Image = ((System.Drawing.Image)(resources.GetObject("Thrd_Runner.Image")));
            this.Thrd_Runner.Location = new System.Drawing.Point(229, 429);
            this.Thrd_Runner.Name = "Thrd_Runner";
            this.Thrd_Runner.Size = new System.Drawing.Size(54, 76);
            this.Thrd_Runner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Thrd_Runner.TabIndex = 3;
            this.Thrd_Runner.TabStop = false;
            // 
            // Forth_Runner
            // 
            this.Forth_Runner.Image = ((System.Drawing.Image)(resources.GetObject("Forth_Runner.Image")));
            this.Forth_Runner.Location = new System.Drawing.Point(335, 429);
            this.Forth_Runner.Name = "Forth_Runner";
            this.Forth_Runner.Size = new System.Drawing.Size(53, 76);
            this.Forth_Runner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Forth_Runner.TabIndex = 4;
            this.Forth_Runner.TabStop = false;
            // 
            // betArea
            // 
            this.betArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.betArea.Controls.Add(this.btn_Start);
            this.betArea.Controls.Add(this.btn_Bet);
            this.betArea.Controls.Add(this.nm_Amount);
            this.betArea.Controls.Add(this.label3);
            this.betArea.Controls.Add(this.label2);
            this.betArea.Controls.Add(this.cb_Dog);
            this.betArea.Controls.Add(this.label1);
            this.betArea.Controls.Add(this.Cb_Player);
            this.betArea.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betArea.ForeColor = System.Drawing.Color.White;
            this.betArea.Location = new System.Drawing.Point(430, 12);
            this.betArea.Name = "betArea";
            this.betArea.Size = new System.Drawing.Size(414, 280);
            this.betArea.TabIndex = 5;
            this.betArea.TabStop = false;
            this.betArea.Text = "Betting Area";
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(261, 185);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(124, 38);
            this.btn_Start.TabIndex = 12;
            this.btn_Start.Text = "Wait";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Bet
            // 
            this.btn_Bet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Bet.ForeColor = System.Drawing.Color.White;
            this.btn_Bet.Location = new System.Drawing.Point(261, 105);
            this.btn_Bet.Name = "btn_Bet";
            this.btn_Bet.Size = new System.Drawing.Size(124, 38);
            this.btn_Bet.TabIndex = 11;
            this.btn_Bet.Text = "Done";
            this.btn_Bet.UseVisualStyleBackColor = false;
            this.btn_Bet.Click += new System.EventHandler(this.btn_Bet_Click);
            // 
            // nm_Amount
            // 
            this.nm_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nm_Amount.Location = new System.Drawing.Point(14, 223);
            this.nm_Amount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nm_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_Amount.Name = "nm_Amount";
            this.nm_Amount.Size = new System.Drawing.Size(222, 32);
            this.nm_Amount.TabIndex = 10;
            this.nm_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bet Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose The Dog";
            // 
            // cb_Dog
            // 
            this.cb_Dog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_Dog.FormattingEnabled = true;
            this.cb_Dog.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_Dog.Location = new System.Drawing.Point(11, 140);
            this.cb_Dog.Name = "cb_Dog";
            this.cb_Dog.Size = new System.Drawing.Size(225, 33);
            this.cb_Dog.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose The Player";
            // 
            // Cb_Player
            // 
            this.Cb_Player.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cb_Player.FormattingEnabled = true;
            this.Cb_Player.Items.AddRange(new object[] {
            "100 Dollar In Deepak Account",
            "150 Dollar in Sukh Account",
            "130 Dollar in Andy Account"});
            this.Cb_Player.Location = new System.Drawing.Point(11, 56);
            this.Cb_Player.Name = "Cb_Player";
            this.Cb_Player.Size = new System.Drawing.Size(397, 33);
            this.Cb_Player.TabIndex = 6;
            // 
            // pb_Fan
            // 
            this.pb_Fan.Image = ((System.Drawing.Image)(resources.GetObject("pb_Fan.Image")));
            this.pb_Fan.Location = new System.Drawing.Point(430, 298);
            this.pb_Fan.Name = "pb_Fan";
            this.pb_Fan.Size = new System.Drawing.Size(414, 194);
            this.pb_Fan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Fan.TabIndex = 6;
            this.pb_Fan.TabStop = false;
            this.pb_Fan.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(856, 504);
            this.Controls.Add(this.pb_Fan);
            this.Controls.Add(this.betArea);
            this.Controls.Add(this.Forth_Runner);
            this.Controls.Add(this.Thrd_Runner);
            this.Controls.Add(this.Second_Runner);
            this.Controls.Add(this.First_Runner);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Runner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Second_Runner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thrd_Runner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forth_Runner)).EndInit();
            this.betArea.ResumeLayout(false);
            this.betArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox First_Runner;
        private System.Windows.Forms.PictureBox Second_Runner;
        private System.Windows.Forms.PictureBox Thrd_Runner;
        private System.Windows.Forms.PictureBox Forth_Runner;
        private System.Windows.Forms.GroupBox betArea;
        private System.Windows.Forms.ComboBox Cb_Player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Dog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nm_Amount;
        private System.Windows.Forms.Button btn_Bet;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.PictureBox pb_Fan;
        private System.Windows.Forms.Timer timer1;
    }
}

