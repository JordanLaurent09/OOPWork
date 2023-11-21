using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLSXClientList
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage newBook = new ExcelPackage("Список клиентов.xlsx");
            //ExcelWorksheet newWorkSheet = newBook.Workbook.Worksheets.Add("Клиенты");  // Лист создан, поэтому данная команда закомментирована
            ExcelWorksheet newWorkSheet = newBook.Workbook.Worksheets["Клиенты"];



            newBook.Save();
        }
    }
}
