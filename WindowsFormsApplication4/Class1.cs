using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	public class CtrlData
	{

		string SetData;
		public CtrlData()
		{
			//SetData = null;
		}
		public string InDataByCalendar
		{
			set
			{
				var str = value.Split(' ');
				var hoge = str[0].Split('/');
				SetData = hoge[1] + hoge[2];
			}
		}
		public string InDataByOther
		{
			set
			{
				//var str = value.Split(' ');
				SetData = value;
			}
		}
		public ClassMate Out()
		{
			//var intcast = new List<int>(10);
			var Sum = 0;
			var ch = SetData.ToCharArray();
			for (int i = 0; i < ch.Length; i++)
			{
				Sum += Math.Abs((ch[i] - '0' + 1) * (i + 1));
			}
			while (Sum > 43) Sum -= 43;
			return new ClassMate(Filter(Sum));
		}
		int Filter(int data)
		{
			if (data == 34) return 32;
			if (data == 19) return 20;
			return data;
		}
	}

	public class ClassMate
	{
		public int Id;
		public string Name;

		public ClassMate(int num)
		{
			Id = num;
			if (num != 0) Name = DB.DataBase.Name(num);
			else Name = "名無しさん";
		}
	}
}
