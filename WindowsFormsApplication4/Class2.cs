using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
	using ClosedXML.Excel;
	class DataBase
	{
		public DataBase()
		{

		}
		static public string Name(int num)
		{
			num = Math.Abs(num);
			var Workbook = new MyXlsx("Book1.xlsx");
			IXLCell cell = Workbook.Cell(num, 0);
			return cell.Value.ToString();
		}
	}
	class MyXlsx : XLWorkbook
	{
		public MyXlsx(string str) : base(str)
		{

		}
		public IXLCell Cell(int row, int column)
		{
			return Worksheet(1).Cell(row + 1, column + 1);
		}
	}
}
