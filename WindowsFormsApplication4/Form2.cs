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
	public partial class Form2 : Form
	{
		CtrlData  SelectMenber;
		public Form2(CtrlData SelectMen)
		{
			SelectMenber = SelectMen;
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void label2_Click(object sender, EventArgs e)
		{
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < 10; i++)
			{
				label2.Text = "";
				var rand = new Rand.GENERATOR();
				label2.Text += rand.Stres[i];
				
			}
			for (int i = 0; i < 10; i++)
			{
				label3.Text = "";
				var rand = new Rand.GENERATOR();
				label3.Text += rand.Stres[i];
			}
			for (int i = 0; i < 10; i++)
			{
				label4.Text = "";
				var rand = new Rand.GENERATOR();
				label4.Text += rand.Stres[i];
			}
			for (int i = 0; i < 10; i++)
			{
				label5.Text = "";
				var rand = new Rand.GENERATOR();
				label5.Text += rand.Stres[i];
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			label1.Text = "計算終了";
			timer1.Stop();
			timer3.Start();
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			var hoge = new Form3(SelectMenber);
			hoge.Show();
			Close();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Width = 600;
			Height = 400;
		}
	}
}
