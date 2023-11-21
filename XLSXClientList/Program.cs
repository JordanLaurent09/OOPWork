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
            Client[] clients = new Client[]
            {
                new Client("Archy", "Bender","bender@mail.com"),
                new Client("Tilda", "Richard","tilda@mail.com"),
                new Client("Guy", "Fredson","freed@mail.com"),
                new Client("Tom", "Carr","tommy@mail.com"),
                new Client("Malcolm", "Arthur","macmac@mail.com"),
                new Client("Winston", "Smith","rebel84@mail.com"),
                new Client("Patsy", "Newton","patricia@mail.com"),
                new Client("Loddie", "Miles","lodd@mail.com"),
                new Client("Mike", "Trump","donnie@mail.com"),
                new Client("Moby", "Dick","whale@mail.com"),

            };



            ExcelPackage newBook = new ExcelPackage("Список клиентов.xlsx");
            //ExcelWorksheet newWorkSheet = newBook.Workbook.Worksheets.Add("Клиенты");  // Лист создан, поэтому данная команда закомментирована
            ExcelWorksheet newWorkSheet = newBook.Workbook.Worksheets["Клиенты"];

            for(int i = 0; i < clients.Length; i++)
            {
                newWorkSheet.Cells[i + 1, 1].Value = clients[i].Name;
                newWorkSheet.Cells[i + 1, 2].Value = clients[i].Surname;
                newWorkSheet.Cells[i + 1, 3].Value = clients[i].Email;
                newWorkSheet.Cells[i + 1, 3].AutoFitColumns();
            }

            newBook.Save();
        }
    }

    class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public Client(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }
    }
}
