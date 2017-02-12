namespace WindowsFormsApplication4
{
	partial class Form5
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(145, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(827, 108);
			this.label1.TabIndex = 0;
			this.label1.Text = "Microsoft.NET Framework\nアプリケーションのコンポーネントでハンドルされていない例外が発生しました。\n「続行」をクリックするとアプリケーショ" +
    "ンはこのエラーを無視し続行しようとします。\n「終了」をクリックするとアプリケーションは直ちに終了します。";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(518, 211);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(170, 49);
			this.button1.TabIndex = 1;
			this.button1.Text = "続行";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(745, 211);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(210, 49);
			this.button2.TabIndex = 2;
			this.button2.Text = "無視して続ける";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 65);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(127, 119);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 283);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form5";
			this.Text = "Form5";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}