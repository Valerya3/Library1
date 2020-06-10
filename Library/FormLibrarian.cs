using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormLibrarian : Form
    {
        public FormLibrarian()
        {
            InitializeComponent();
            ShowLibrarian();
        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LibrarianSet librarianSet = new LibrarianSet();
            librarianSet.FirstName = textBoxFirstName.Text;
            librarianSet.MiddleName = textBoxMiddleName.Text;
            librarianSet.LastName = textBoxLastName.Text;
            librarianSet.Phone = textBoxPhone.Text;
            librarianSet.DoB = dateTimePickerDoB.Value;
            Program.qwer.LibrarianSet.Add(librarianSet);
            Program.qwer.SaveChanges();
            ShowLibrarian();
        }
        void ShowLibrarian()
        {
            listViewLibrarian.Items.Clear();
            foreach (LibrarianSet librarianSet in Program.qwer.LibrarianSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    librarianSet.ID.ToString(),
                    librarianSet.FirstName,
                    librarianSet.MiddleName,
                    librarianSet.LastName, 
                    librarianSet.Phone, 
                    librarianSet.DoB.ToString().Substring(0, librarianSet.DoB.ToString().Length - 8)
            });
                item.Tag = librarianSet;
                listViewLibrarian.Items.Add(item);
            }
            listViewLibrarian.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewLibrarian.SelectedItems.Count == 1)
            {
                LibrarianSet librarianSet = listViewLibrarian.SelectedItems[0].Tag as LibrarianSet;
                librarianSet.FirstName = textBoxFirstName.Text;
                librarianSet.MiddleName = textBoxMiddleName.Text;
                librarianSet.LastName = textBoxLastName.Text;
                librarianSet.Phone = textBoxPhone.Text;
                librarianSet.DoB = dateTimePickerDoB.Value;
                Program.qwer.SaveChanges();
                ShowLibrarian();
            }

        }

        private void listViewLibrarian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLibrarian.SelectedItems.Count == 1)
            {
                LibrarianSet librarianSet = listViewLibrarian.SelectedItems[0].Tag as LibrarianSet;
                textBoxFirstName.Text = librarianSet.FirstName;
                textBoxMiddleName.Text = librarianSet.MiddleName;
                textBoxLastName.Text = librarianSet.LastName;
                textBoxPhone.Text = librarianSet.Phone;
                dateTimePickerDoB.Value = librarianSet.DoB;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                dateTimePickerDoB.Text = "";
            }
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewLibrarian.SelectedItems.Count == 1)
                {
                    LibrarianSet librarianSet = listViewLibrarian.SelectedItems[0].Tag as LibrarianSet;
                    Program.qwer.LibrarianSet.Remove(librarianSet);
                    Program.qwer.SaveChanges();
                    ShowLibrarian();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                dateTimePickerDoB.Text = "";
            }

            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLibrarian_Load(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
