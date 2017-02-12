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
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//throw new Exception();
			if (radioButton1.Checked)
			{
				SelectMen = new CtrlData();
				SelectMen.InDataByCalendar = monthCalendar1.SelectionStart.ToString();
				
			}
			else
			{
				SelectMen = new CtrlData();
				SelectMen.InDataByOther = textBox1.Text;
			}
			var hoge = new Form2(SelectMen);
				hoge.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			label1.Text = this.Height + "   " + Width;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Height = 450;
			Width = 400;
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			label1.Text = monthCalendar1.SelectionStart.ToString();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			button1.Enabled = true;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

			button1.Enabled = true;
		}
		CtrlData SelectMen;//= new CtrlData();
	}
}
