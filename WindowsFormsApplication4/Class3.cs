using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rand
{
	public class GENERATOR
	{
		public string[] Stres;
		public GENERATOR()
		{
			Stres = new string[10];

			var random = new Random();
			//var data = new bool[10];
			for (int i = 0; i < Stres.Length; i++)
			{
				for (int j = 0; j < 20; j++)
				{
					var data = random.NextDouble() > 0.5;
					Stres[i] += "" + Convert.ToInt32(data);
				}
			}
		}


	}
}
