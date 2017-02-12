namespace WindowsFormsApplication4
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();

			label1.ForeColor = System.Drawing.Color.White;
			label2.ForeColor = System.Drawing.Color.White;
			label3.ForeColor = System.Drawing.Color.White;
			label4.ForeColor = System.Drawing.Color.White;
			label5.ForeColor = System.Drawing.Color.White;

			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
			this.label1.Location = new System.Drawing.Point(161, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 60);
			this.label1.TabIndex = 0;
			this.label1.Text = "計算中!!!!";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
			this.label2.Location = new System.Drawing.Point(12, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 60);
			this.label2.TabIndex = 1;
			this.label2.Text = "";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 120;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 2000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer3
			// 
			this.timer3.Interval = 2000;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
			this.label3.Location = new System.Drawing.Point(12, 280);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 60);
			this.label3.TabIndex = 2;
			this.label3.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20F);
			this.label4.Location = new System.Drawing.Point(12, 360);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 60);
			this.label4.TabIndex = 3;
			this.label4.Text = "";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20F);
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 440);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 27);
			this.label5.TabIndex = 4;
			this.label5.Text = "";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 600);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.BackColor = System.Drawing.Color.Black;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;		
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
	}
}