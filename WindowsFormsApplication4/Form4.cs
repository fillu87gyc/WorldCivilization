using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
			TopMost = true;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			pictureBox2.BringToFront();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			pictureBox3.BringToFront();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			pictureBox4.BringToFront();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			label1.BringToFront();
			label1.Text = "発表者なし";
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			Height = Width = 4000;
			Width /= 2;
			//WindowState = FormWindowState.Maximized;
			pictureBox4.BringToFront();
			pictureBox3.BringToFront();
			pictureBox2.BringToFront();
			pictureBox1.BringToFront();
			
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
			this.Close();
		}
	}
}
