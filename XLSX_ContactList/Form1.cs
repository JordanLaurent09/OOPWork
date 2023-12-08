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
            saveNewContactBTN.Enabled = false;
        }


        // Добавление имен контактов в список
        public void GetContacts()
        {
            contactBook = new ExcelPackage("ContactBook.xlsx");
            contactSheet = contactBook.Workbook.Worksheets["Contacts"];

            for (int i = 1; i < contactSheet.Rows.EndRow; i++)
            {

                if (contactSheet.Cells[i, 1].Text == string.Empty) break;
                    string contactName = contactSheet.Cells[i, 1].Text;
                    string contactAddress = contactSheet.Cells[i, 2].Text;
                    string contactPhone = contactSheet.Cells[i, 3].Text;
                    string contactEmail = contactSheet.Cells[i, 4].Text;

                    _contacts.Add(new Contact(contactName, contactAddress, contactPhone, contactEmail));
                
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

        private void createContactBTN_Click(object sender, EventArgs e)
        {
            createContactBTN.Enabled = false;
            saveNewContactBTN.Enabled = true;
            contactNameCB.Text = string.Empty;
            addressTB.Text = string.Empty;
            phoneTB.Text = string.Empty;
            emailTB.Text = string.Empty;

            
        }

        private bool IfContactExists(string name, string address, string phone, string email)
        {
            bool isExist = false;
            foreach(Contact item in _contacts)
            {
                if(item.Name == name && item.Address == address && item.Phone == phone && item.Email == email)
                {
                    isExist = true;
                }
            }

            return isExist;
        }

        private void saveNewContactBTN_Click(object sender, EventArgs e)
        {
            if (contactNameCB.Text != string.Empty && addressTB.Text != string.Empty && phoneTB.Text != string.Empty &&
                emailTB.Text != string.Empty)
            {
                bool isExist = IfContactExists(contactNameCB.Text, addressTB.Text, phoneTB.Text, emailTB.Text);

                if (isExist == false)
                {
                    _contacts.Add(new Contact(contactNameCB.Text, addressTB.Text, phoneTB.Text, emailTB.Text));
                    MessageBox.Show("Контакт успешно добавлен");
                }
                else
                {
                    MessageBox.Show("Такой контакт уже есть");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Сначала добавьте всю необходимую информацию о новом контакте");
            }
        }
    }
}
