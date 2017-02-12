using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	class CtrlData
	{
		string SetData;
		public CtrlData()
		{
			SetData = null;
		}
		public string InData
		{
			set
			{
				var str = value.Split(' ');
				var hoge = str[0].Split('/');
				SetData = hoge[1] + hoge[2];
			}
		}
		public ClassMate? Out()
		{
			var intcast = new List<int>(10);
			var Sum = 0;
			var ch = SetData.ToCharArray();
			for (int i = 0; i < ch.Length; i++)
			{
				try
				{
					Sum += ~int.Parse("" + ch[i]);
				}
				catch (Exception)
				{
					return null;
				}
				while (Sum > 43 && Sum < 0)
				{
					Sum -= 43;
					if (Sum < 0)
						Sum += 15;

				}
				return new ClassMate(Sum);
			}
		}
	}
	class ClassMate
	{
		public int Id;
		public string Name;

		public ClassMate(int num)
		{
			Id = num;
			Name = DataBase.Name(num);
		}
	}
	class DataBase
	{
		//public string Name[int index]{			get;set;}
		public DataBase()
		{

		}
		public string  Name(int num)
		{
			return "a";
		}
		string[] data = {
			
		};


	}
}


