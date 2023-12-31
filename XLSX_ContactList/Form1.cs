﻿using System;
using System.Collections.Generic;
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
            ShowContacts();
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
        }

        // Вывод списка контактов
        private void ShowContacts()
        {
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


        // Создание нового контакта
        private void createContactBTN_Click(object sender, EventArgs e)
        {
            CreateContact(); 
        }

        // Метод с логикой создания нового контакта

        public void CreateContact()
        {
            createContactBTN.Enabled = false;
            saveNewContactBTN.Enabled = true;
            contactNameCB.Items.Clear();
            contactNameCB.Text = string.Empty;
            addressTB.Text = string.Empty;
            phoneTB.Text = string.Empty;
            emailTB.Text = string.Empty;
        } 

        // Проверка существования контакта
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

        // Добавление новых контактов в excel-файл

        private void WriteExcelFile()
        {
            for(int i = 0; i < _contacts.Count; i++)
            {
                contactSheet.Cells[i + 1, 1].AutoFitColumns();
                contactSheet.Cells[i + 1, 1].Value = _contacts[i].Name;
                contactSheet.Cells[i + 1, 2].AutoFitColumns();
                contactSheet.Cells[i + 1, 2].Value = _contacts[i].Address;
                contactSheet.Cells[i + 1, 3].AutoFitColumns();
                contactSheet.Cells[i + 1, 3].Value = _contacts[i].Phone;
                contactSheet.Cells[i + 1, 4].AutoFitColumns();
                contactSheet.Cells[i + 1, 4].Value = _contacts[i].Email;
            }

            contactBook.Save();
        }

        // Перезапись данных в excel-файле в связи с удалением контакта
        private void RewriteExcelFile()
        {
            contactBook = new ExcelPackage("ContactBook.xlsx");
            contactSheet = contactBook.Workbook.Worksheets["Contacts"];
            contactBook.Workbook.Worksheets.Delete(contactSheet);
            contactSheet = contactBook.Workbook.Worksheets.Add("Contacts");

            WriteExcelFile();
        }

        // Сохранение нового контакта
        private void saveNewContactBTN_Click(object sender, EventArgs e)
        {
            SaveContact();
        }

        
        // Метод с логикой сохранения нового контакта
        private void SaveContact()
        {
            if (contactNameCB.Text != string.Empty && addressTB.Text != string.Empty && phoneTB.Text != string.Empty &&
                emailTB.Text != string.Empty)
            {
                bool isExist = IfContactExists(contactNameCB.Text, addressTB.Text, phoneTB.Text, emailTB.Text);

                if (isExist == false)
                {
                    _contacts.Add(new Contact(contactNameCB.Text, addressTB.Text, phoneTB.Text, emailTB.Text));
                    MessageBox.Show("Контакт успешно добавлен");
                    WriteExcelFile();
                    contactNameCB.Text = string.Empty;
                    contactNameCB.Items.Clear();
                    addressTB.Text = string.Empty;
                    phoneTB.Text = string.Empty;
                    emailTB.Text = string.Empty;
                    saveNewContactBTN.Enabled = false;
                    createContactBTN.Enabled = true;
                    ShowContacts();
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


        // Перезапись отдельных ячеек контакта
        private void editContactBTN_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        // Метод с логикой перезаписи отдельных ячеек конкретного контакта
        private void EditContact()
        {
            int index = contactNameCB.SelectedIndex;

            if (contactNameCB.Text != string.Empty && addressTB.Text != string.Empty && phoneTB.Text != string.Empty &&
                emailTB.Text != string.Empty)
            {
                _contacts[index].Name = contactNameCB.Text;
                _contacts[index].Address = addressTB.Text;
                _contacts[index].Phone = phoneTB.Text;
                _contacts[index].Email = emailTB.Text;

                MessageBox.Show("Контакт успешно изменен");
                WriteExcelFile();
                contactNameCB.Items.Clear();
                ShowContacts();
            }
            else
            {
                MessageBox.Show("Сначала добавьте всю необходимую информацию о новом контакте");
            }
        }

        // Удаление выбранного контакта
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }


        // Метод с логикой удаления контакта
        private void DeleteContact()
        {
            foreach (Contact contact in _contacts)
            {
                if (contactNameCB.SelectedItem.ToString() == contact.Name)
                {
                    _contacts.Remove(contact);
                    WriteExcelFile();
                    contactNameCB.Items.Clear();
                    ShowContacts();
                    RewriteExcelFile();
                    contactNameCB.Text = string.Empty;
                    addressTB.Text = string.Empty;
                    phoneTB.Text = string.Empty;
                    emailTB.Text = string.Empty;
                    MessageBox.Show("Контакт успешно удален!");
                    return;
                }
            }
        }
    }
}
