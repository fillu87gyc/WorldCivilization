﻿using System;
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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var hoge = new Form4();
			hoge.Show();
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var hoge = new Form4();
			hoge.Show();
			
		}
	}
}
