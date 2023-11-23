using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLSXCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfYear = 0;
            string[] months = new string[]
            {
                "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };
            ExcelPackage calendarBook = new ExcelPackage("Календарь_2023.xlsx");
            //ExcelWorksheet calendarSheet = calendarBook.Workbook.Worksheets.Add("Календарь 2023");
            ExcelWorksheet calendarSheet = calendarBook.Workbook.Worksheets["Календарь 2023"];

            for(int i = 1; i <= 12; i++)
            {
                for(int j = 1; j <= 31; j++)
                {
                    dayOfYear++;
                    calendarSheet.Cells[1, i + 1].Value = months[i - 1];
                    calendarSheet.Cells[j + 1, i + 1].Value = j;
                    if(dayOfYear == 1 || dayOfYear % 7 == 0 || dayOfYear % 7 == 1)
                    {
                        calendarSheet.Cells[j + 1, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.DarkGrid;
                        
                        calendarSheet.Cells[j + 1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.BlueViolet);
                        
                    }
                    if (i == 2 && j == 28) break;
                    if ((i == 4 || i == 6 || i == 9 || i == 11) && j == 30) break;
                }
            }


            calendarBook.Save();
        }
    }
}
