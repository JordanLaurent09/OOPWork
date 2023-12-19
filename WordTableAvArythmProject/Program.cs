using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace WordTableAvArythmProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersSum = 0;

            int numbersCount = 0;

            Random random = new Random();

            // Начало работы с Word
            Word.Application wordApp = new Word.Application();

            // Открытие документа
            Word.Document wordDoc = wordApp.Documents.Open($"{Directory.GetCurrentDirectory()}\\DigitsContainer.docx");

            Word.Range range = wordDoc.Content;

            // Создание таблицы
            Word.Table table = wordDoc.Tables.Add(range, NumRows: 10, NumColumns: 10);

            table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            // Заполнение таблицы случайными числами и вычисление среднего арифметического
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int number = random.Next(1, 21);

                    numbersSum += number;

                    table.Cell(i, j).Range.Text = number.ToString();

                    numbersCount++;
                }
            }

            Console.WriteLine($"Среднее арифметическое равно {numbersSum / numbersCount}");

            // Сохранение изменений в файле и завершение работы
            wordDoc.Save();
            wordDoc.Close();

            wordApp.Quit();
        }
    }
}
