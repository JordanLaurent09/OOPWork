
namespace XLSX_ContactList
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactNameCB = new System.Windows.Forms.ComboBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createContactBTN = new System.Windows.Forms.Button();
            this.saveNewContactBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactNameCB
            // 
            this.contactNameCB.FormattingEnabled = true;
            this.contactNameCB.Location = new System.Drawing.Point(73, 75);
            this.contactNameCB.Name = "contactNameCB";
            this.contactNameCB.Size = new System.Drawing.Size(121, 21);
            this.contactNameCB.TabIndex = 0;
            this.contactNameCB.SelectedIndexChanged += new System.EventHandler(this.contactNameCB_SelectedIndexChanged);
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(76, 136);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(121, 20);
            this.addressTB.TabIndex = 1;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(76, 192);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(121, 20);
            this.phoneTB.TabIndex = 2;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(76, 250);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(121, 20);
            this.emailTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер телефона:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Электронный адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "СПИСОК КОНТАКТОВ";
            // 
            // createContactBTN
            // 
            this.createContactBTN.Location = new System.Drawing.Point(24, 291);
            this.createContactBTN.Name = "createContactBTN";
            this.createContactBTN.Size = new System.Drawing.Size(84, 54);
            this.createContactBTN.TabIndex = 9;
            this.createContactBTN.Text = "Создать новый контакт";
            this.createContactBTN.UseVisualStyleBackColor = true;
            this.createContactBTN.Click += new System.EventHandler(this.createContactBTN_Click);
            // 
            // saveNewContactBTN
            // 
            this.saveNewContactBTN.Location = new System.Drawing.Point(119, 291);
            this.saveNewContactBTN.Name = "saveNewContactBTN";
            this.saveNewContactBTN.Size = new System.Drawing.Size(87, 54);
            this.saveNewContactBTN.TabIndex = 10;
            this.saveNewContactBTN.Text = "Добавить новый контакт";
            this.saveNewContactBTN.UseVisualStyleBackColor = true;
            this.saveNewContactBTN.Click += new System.EventHandler(this.saveNewContactBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 450);
            this.Controls.Add(this.saveNewContactBTN);
            this.Controls.Add(this.createContactBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.contactNameCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox contactNameCB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createContactBTN;
        private System.Windows.Forms.Button saveNewContactBTN;
    }
}

