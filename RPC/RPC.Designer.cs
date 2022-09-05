namespace RPCs
{
    partial class RPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox logo;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPC));
            this.logo = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.draw = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.redTrack = new System.Windows.Forms.TrackBar();
            this.blueTrack = new System.Windows.Forms.TrackBar();
            this.greenTrack = new System.Windows.Forms.TrackBar();
            this.Red = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.redBox = new System.Windows.Forms.TextBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.curColor = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.alphaTrack = new System.Windows.Forms.TrackBar();
            this.alphaBox = new System.Windows.Forms.TextBox();
            this.Alpha = new System.Windows.Forms.Label();
            this.history0 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.history2 = new System.Windows.Forms.Panel();
            this.history1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.history3 = new System.Windows.Forms.Panel();
            this.history4 = new System.Windows.Forms.Panel();
            this.history5 = new System.Windows.Forms.Panel();
            this.history6 = new System.Windows.Forms.Panel();
            this.history7 = new System.Windows.Forms.Panel();
            this.history8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrack)).BeginInit();
            this.history0.SuspendLayout();
            this.history1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(317, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(128, 128);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseClick);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(192, 201);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New Pack";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NewButton_MouseClick);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(192, 251);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(100, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Pack";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoadButton_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.FloralWhite;
            this.draw.Location = new System.Drawing.Point(218, 186);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(512, 512);
            this.draw.TabIndex = 3;
            this.draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draw_MouseDown);
            this.draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draw_MouseMove);
            this.draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draw_MouseUp);
            // 
            // redTrack
            // 
            this.redTrack.Location = new System.Drawing.Point(241, 0);
            this.redTrack.Margin = new System.Windows.Forms.Padding(0);
            this.redTrack.Maximum = 255;
            this.redTrack.Name = "redTrack";
            this.redTrack.Size = new System.Drawing.Size(512, 45);
            this.redTrack.TabIndex = 5;
            this.redTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.redTrack.ValueChanged += new System.EventHandler(this.RedTrack_ValueChanged);
            // 
            // blueTrack
            // 
            this.blueTrack.Location = new System.Drawing.Point(241, 90);
            this.blueTrack.Margin = new System.Windows.Forms.Padding(0);
            this.blueTrack.Maximum = 255;
            this.blueTrack.Name = "blueTrack";
            this.blueTrack.Size = new System.Drawing.Size(512, 45);
            this.blueTrack.TabIndex = 6;
            this.blueTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blueTrack.ValueChanged += new System.EventHandler(this.BlueTrack_ValueChanged);
            // 
            // greenTrack
            // 
            this.greenTrack.Location = new System.Drawing.Point(241, 45);
            this.greenTrack.Margin = new System.Windows.Forms.Padding(0);
            this.greenTrack.Maximum = 255;
            this.greenTrack.Name = "greenTrack";
            this.greenTrack.Size = new System.Drawing.Size(512, 45);
            this.greenTrack.TabIndex = 7;
            this.greenTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.greenTrack.ValueChanged += new System.EventHandler(this.GreenTrack_ValueChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(189, 0);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(27, 13);
            this.Red.TabIndex = 8;
            this.Red.Text = "Red";
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(189, 45);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(36, 13);
            this.Green.TabIndex = 9;
            this.Green.Text = "Green";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(189, 90);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(28, 13);
            this.Blue.TabIndex = 10;
            this.Blue.Text = "Blue";
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Black;
            this.redBox.ForeColor = System.Drawing.SystemColors.Info;
            this.redBox.Location = new System.Drawing.Point(192, 17);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(33, 20);
            this.redBox.TabIndex = 11;
            this.redBox.Text = "0";
            this.redBox.TextChanged += new System.EventHandler(this.RedBox_TextChanged);
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Black;
            this.blueBox.ForeColor = System.Drawing.SystemColors.Info;
            this.blueBox.Location = new System.Drawing.Point(192, 105);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(33, 20);
            this.blueBox.TabIndex = 12;
            this.blueBox.Text = "0";
            this.blueBox.TextChanged += new System.EventHandler(this.BlueBox_TextChanged);
            // 
            // greenBox
            // 
            this.greenBox.BackColor = System.Drawing.Color.Black;
            this.greenBox.ForeColor = System.Drawing.SystemColors.Info;
            this.greenBox.Location = new System.Drawing.Point(192, 61);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(33, 20);
            this.greenBox.TabIndex = 13;
            this.greenBox.Text = "0";
            this.greenBox.TextChanged += new System.EventHandler(this.GreenBox_TextChanged);
            // 
            // curColor
            // 
            this.curColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.curColor.Location = new System.Drawing.Point(756, 0);
            this.curColor.Name = "curColor";
            this.curColor.Size = new System.Drawing.Size(32, 180);
            this.curColor.TabIndex = 14;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // alphaTrack
            // 
            this.alphaTrack.Location = new System.Drawing.Point(241, 135);
            this.alphaTrack.Margin = new System.Windows.Forms.Padding(0);
            this.alphaTrack.Maximum = 255;
            this.alphaTrack.Name = "alphaTrack";
            this.alphaTrack.Size = new System.Drawing.Size(512, 45);
            this.alphaTrack.TabIndex = 15;
            this.alphaTrack.TickFrequency = -1;
            this.alphaTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.alphaTrack.Value = 255;
            this.alphaTrack.ValueChanged += new System.EventHandler(this.AlphaTrack_ValueChanged);
            // 
            // alphaBox
            // 
            this.alphaBox.BackColor = System.Drawing.Color.Black;
            this.alphaBox.ForeColor = System.Drawing.SystemColors.Info;
            this.alphaBox.Location = new System.Drawing.Point(193, 151);
            this.alphaBox.Name = "alphaBox";
            this.alphaBox.Size = new System.Drawing.Size(33, 20);
            this.alphaBox.TabIndex = 16;
            this.alphaBox.Text = "255";
            // 
            // Alpha
            // 
            this.Alpha.AutoSize = true;
            this.Alpha.Location = new System.Drawing.Point(190, 135);
            this.Alpha.Name = "Alpha";
            this.Alpha.Size = new System.Drawing.Size(34, 13);
            this.Alpha.TabIndex = 17;
            this.Alpha.Text = "Alpha";
            // 
            // history0
            // 
            this.history0.Controls.Add(this.panel2);
            this.history0.Location = new System.Drawing.Point(0, 0);
            this.history0.Margin = new System.Windows.Forms.Padding(0);
            this.history0.Name = "history0";
            this.history0.Size = new System.Drawing.Size(50, 50);
            this.history0.TabIndex = 18;
            this.history0.Click += new System.EventHandler(this.History0_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(47, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 19;
            // 
            // history2
            // 
            this.history2.Location = new System.Drawing.Point(110, 0);
            this.history2.Margin = new System.Windows.Forms.Padding(0);
            this.history2.Name = "history2";
            this.history2.Size = new System.Drawing.Size(50, 50);
            this.history2.TabIndex = 20;
            this.history2.Click += new System.EventHandler(this.History2_Click);
            // 
            // history1
            // 
            this.history1.Controls.Add(this.panel5);
            this.history1.Location = new System.Drawing.Point(55, 0);
            this.history1.Margin = new System.Windows.Forms.Padding(0);
            this.history1.Name = "history1";
            this.history1.Size = new System.Drawing.Size(50, 50);
            this.history1.TabIndex = 20;
            this.history1.Click += new System.EventHandler(this.History1_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(47, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 50);
            this.panel5.TabIndex = 19;
            // 
            // history3
            // 
            this.history3.Location = new System.Drawing.Point(0, 55);
            this.history3.Margin = new System.Windows.Forms.Padding(0);
            this.history3.Name = "history3";
            this.history3.Size = new System.Drawing.Size(50, 50);
            this.history3.TabIndex = 21;
            this.history3.Click += new System.EventHandler(this.History3_Click);
            // 
            // history4
            // 
            this.history4.Location = new System.Drawing.Point(55, 55);
            this.history4.Margin = new System.Windows.Forms.Padding(0);
            this.history4.Name = "history4";
            this.history4.Size = new System.Drawing.Size(50, 50);
            this.history4.TabIndex = 22;
            this.history4.Click += new System.EventHandler(this.History4_Click);
            // 
            // history5
            // 
            this.history5.Location = new System.Drawing.Point(110, 55);
            this.history5.Margin = new System.Windows.Forms.Padding(0);
            this.history5.Name = "history5";
            this.history5.Size = new System.Drawing.Size(50, 50);
            this.history5.TabIndex = 23;
            this.history5.Click += new System.EventHandler(this.History5_Click);
            // 
            // history6
            // 
            this.history6.Location = new System.Drawing.Point(0, 110);
            this.history6.Margin = new System.Windows.Forms.Padding(0);
            this.history6.Name = "history6";
            this.history6.Size = new System.Drawing.Size(50, 50);
            this.history6.TabIndex = 22;
            this.history6.Click += new System.EventHandler(this.History6_Click);
            // 
            // history7
            // 
            this.history7.Location = new System.Drawing.Point(55, 110);
            this.history7.Margin = new System.Windows.Forms.Padding(0);
            this.history7.Name = "history7";
            this.history7.Size = new System.Drawing.Size(50, 50);
            this.history7.TabIndex = 23;
            this.history7.Click += new System.EventHandler(this.History7_Click);
            // 
            // history8
            // 
            this.history8.Location = new System.Drawing.Point(110, 110);
            this.history8.Margin = new System.Windows.Forms.Padding(0);
            this.history8.Name = "history8";
            this.history8.Size = new System.Drawing.Size(50, 50);
            this.history8.TabIndex = 24;
            this.history8.Click += new System.EventHandler(this.History8_Click);
            // 
            // RPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.history8);
            this.Controls.Add(this.history7);
            this.Controls.Add(this.history6);
            this.Controls.Add(this.history5);
            this.Controls.Add(this.history4);
            this.Controls.Add(this.history3);
            this.Controls.Add(this.history1);
            this.Controls.Add(this.history2);
            this.Controls.Add(this.history0);
            this.Controls.Add(this.Alpha);
            this.Controls.Add(this.alphaBox);
            this.Controls.Add(this.alphaTrack);
            this.Controls.Add(this.curColor);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.blueTrack);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.greenTrack);
            this.Controls.Add(this.redTrack);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "RPC";
            this.Text = "Resource Pack Creator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RPC_Paint);
            this.Resize += new System.EventHandler(this.RPC_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrack)).EndInit();
            this.history0.ResumeLayout(false);
            this.history1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel draw;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar redTrack;
        private System.Windows.Forms.TrackBar blueTrack;
        private System.Windows.Forms.TrackBar greenTrack;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.TextBox redBox;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.Panel curColor;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TrackBar alphaTrack;
        private System.Windows.Forms.TextBox alphaBox;
        private System.Windows.Forms.Label Alpha;
        private System.Windows.Forms.Panel history0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel history2;
        private System.Windows.Forms.Panel history1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel history3;
        private System.Windows.Forms.Panel history4;
        private System.Windows.Forms.Panel history5;
        private System.Windows.Forms.Panel history6;
        private System.Windows.Forms.Panel history7;
        private System.Windows.Forms.Panel history8;
    }
}

