namespace Composite_Structure_by_WAV3SSXSS
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxNumers = new System.Windows.Forms.TextBox();
			this.textBoxProbability = new System.Windows.Forms.TextBox();
			this.radioButtonPoloski = new System.Windows.Forms.RadioButton();
			this.radioButtonRandom = new System.Windows.Forms.RadioButton();
			this.radioButtonPoloskiVertical = new System.Windows.Forms.RadioButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.radioButtonFractale = new System.Windows.Forms.RadioButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBoxTopTemperature = new System.Windows.Forms.TextBox();
			this.textBoxBotTemperature = new System.Windows.Forms.TextBox();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.textBoxLyambda = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(650, 650);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(659, 539);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 100);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxNumers
			// 
			this.textBoxNumers.Location = new System.Drawing.Point(659, 510);
			this.textBoxNumers.Name = "textBoxNumers";
			this.textBoxNumers.PlaceholderText = "Numbers";
			this.textBoxNumers.Size = new System.Drawing.Size(100, 23);
			this.textBoxNumers.TabIndex = 2;
			this.textBoxNumers.Text = "40";
			// 
			// textBoxProbability
			// 
			this.textBoxProbability.Location = new System.Drawing.Point(659, 471);
			this.textBoxProbability.Name = "textBoxProbability";
			this.textBoxProbability.PlaceholderText = "Probability";
			this.textBoxProbability.Size = new System.Drawing.Size(100, 23);
			this.textBoxProbability.TabIndex = 3;
			this.textBoxProbability.Text = "0,44";
			// 
			// radioButtonPoloski
			// 
			this.radioButtonPoloski.AutoSize = true;
			this.radioButtonPoloski.Location = new System.Drawing.Point(659, 37);
			this.radioButtonPoloski.Name = "radioButtonPoloski";
			this.radioButtonPoloski.Size = new System.Drawing.Size(63, 19);
			this.radioButtonPoloski.TabIndex = 4;
			this.radioButtonPoloski.Tag = "1";
			this.radioButtonPoloski.Text = "Poloski";
			this.radioButtonPoloski.UseVisualStyleBackColor = true;
			// 
			// radioButtonRandom
			// 
			this.radioButtonRandom.AutoSize = true;
			this.radioButtonRandom.Checked = true;
			this.radioButtonRandom.Location = new System.Drawing.Point(659, 12);
			this.radioButtonRandom.Name = "radioButtonRandom";
			this.radioButtonRandom.Size = new System.Drawing.Size(92, 19);
			this.radioButtonRandom.TabIndex = 5;
			this.radioButtonRandom.TabStop = true;
			this.radioButtonRandom.Tag = "1";
			this.radioButtonRandom.Text = "Full Random";
			this.radioButtonRandom.UseVisualStyleBackColor = true;
			// 
			// radioButtonPoloskiVertical
			// 
			this.radioButtonPoloskiVertical.AutoSize = true;
			this.radioButtonPoloskiVertical.Location = new System.Drawing.Point(659, 62);
			this.radioButtonPoloskiVertical.Name = "radioButtonPoloskiVertical";
			this.radioButtonPoloskiVertical.Size = new System.Drawing.Size(94, 19);
			this.radioButtonPoloskiVertical.TabIndex = 6;
			this.radioButtonPoloskiVertical.Tag = "1";
			this.radioButtonPoloskiVertical.Text = "PoloskiUverh";
			this.radioButtonPoloskiVertical.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			this.timer1.Interval = 200;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// radioButtonFractale
			// 
			this.radioButtonFractale.AutoSize = true;
			this.radioButtonFractale.Location = new System.Drawing.Point(659, 87);
			this.radioButtonFractale.Name = "radioButtonFractale";
			this.radioButtonFractale.Size = new System.Drawing.Size(66, 19);
			this.radioButtonFractale.TabIndex = 7;
			this.radioButtonFractale.Tag = "1";
			this.radioButtonFractale.Text = "Fractale";
			this.radioButtonFractale.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(770, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(650, 650);
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1429, 539);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 100);
			this.button2.TabIndex = 9;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBoxTopTemperature
			// 
			this.textBoxTopTemperature.Location = new System.Drawing.Point(1429, 471);
			this.textBoxTopTemperature.Name = "textBoxTopTemperature";
			this.textBoxTopTemperature.PlaceholderText = "Top Temperature";
			this.textBoxTopTemperature.Size = new System.Drawing.Size(100, 23);
			this.textBoxTopTemperature.TabIndex = 11;
			this.textBoxTopTemperature.Text = "300";
			// 
			// textBoxBotTemperature
			// 
			this.textBoxBotTemperature.Location = new System.Drawing.Point(1429, 510);
			this.textBoxBotTemperature.Name = "textBoxBotTemperature";
			this.textBoxBotTemperature.PlaceholderText = "Bot Temperature";
			this.textBoxBotTemperature.Size = new System.Drawing.Size(100, 23);
			this.textBoxBotTemperature.TabIndex = 10;
			this.textBoxBotTemperature.Text = "100";
			// 
			// timer2
			// 
			this.timer2.Interval = 500;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// textBoxLyambda
			// 
			this.textBoxLyambda.Location = new System.Drawing.Point(1429, 432);
			this.textBoxLyambda.Name = "textBoxLyambda";
			this.textBoxLyambda.PlaceholderText = "Lyambda";
			this.textBoxLyambda.Size = new System.Drawing.Size(100, 23);
			this.textBoxLyambda.TabIndex = 12;
			this.textBoxLyambda.Text = "0,2";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button3.Location = new System.Drawing.Point(1429, 198);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 100);
			this.button3.TabIndex = 13;
			this.button3.Text = "init";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1539, 649);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBoxLyambda);
			this.Controls.Add(this.textBoxTopTemperature);
			this.Controls.Add(this.textBoxBotTemperature);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.radioButtonFractale);
			this.Controls.Add(this.radioButtonPoloskiVertical);
			this.Controls.Add(this.radioButtonRandom);
			this.Controls.Add(this.radioButtonPoloski);
			this.Controls.Add(this.textBoxProbability);
			this.Controls.Add(this.textBoxNumers);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pictureBox1;
		private Button button1;
		private TextBox textBoxNumers;
		private TextBox textBoxProbability;
		private RadioButton radioButtonPoloski;
		private RadioButton radioButtonRandom;
		private RadioButton radioButtonPoloskiVertical;
		private System.Windows.Forms.Timer timer1;
		private RadioButton radioButtonFractale;
		private PictureBox pictureBox2;
		private Button button2;
		private TextBox textBoxTopTemperature;
		private TextBox textBoxBotTemperature;
		private System.Windows.Forms.Timer timer2;
		private TextBox textBoxLyambda;
		private Button button3;
	}
}