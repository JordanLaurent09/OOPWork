using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace XLSX_ContactList
{
    
    public partial class Form1 : Form
    {
        private static List<Contact> _contacts = new List<Contact>();
        private static ExcelPackage contactBook;
        private static ExcelWorksheet contactSheet;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetContacts();
        }


        // Добавление имен контактов в список
        public void GetContacts()
        {
            contactBook = new ExcelPackage("ContactBook.xlsx");
            contactSheet = contactBook.Workbook.Worksheets["Contacts"];

            for (int i = 1; i < contactSheet.Rows.EndRow; i++)
            {
                for (int j = 1; j < contactSheet.Columns.EndColumn; j++)
                {
                    string contactName = contactSheet.Cells[i, j].Text;
                    string contactAddress = contactSheet.Cells[i, j].Text;
                    string contactPhone = contactSheet.Cells[i, j].Text;
                    string contactEmail = contactSheet.Cells[i, j].Text;

                    _contacts.Add(new Contact(contactName, contactAddress, contactPhone, contactEmail));
                }
            }

            for (int i = 0; i < _contacts.Count; i++)
            {
                contactNameCB.Items.Add(_contacts[i].Name);
            }
        }

        private void contactNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Contact item in _contacts)
            {
                if(contactNameCB.SelectedItem.ToString() == item.Name)
                {
                    addressTB.Text = item.Address;
                    phoneTB.Text = item.Phone;
                    emailTB.Text = item.Email;
                }
            }
        }
    }
}
