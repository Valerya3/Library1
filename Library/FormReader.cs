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
    public partial class FormReader : Form
    {
        public FormReader()
        {
            InitializeComponent();
            ShowReader();
        }

        private void FormReader_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ReaderSet readerSet = new ReaderSet();
            readerSet.FirstName = textBoxFirstName.Text;
            readerSet.LastName = textBoxLastName.Text;
            readerSet.MiddleName = textBoxMiddleName.Text;
            readerSet.Phone = textBoxPhone.Text;
            Program.qwer.ReaderSet.Add(readerSet);
            Program.qwer.SaveChanges();
            ShowReader();
        }
        void ShowReader()
        {
            listViewReader.Items.Clear();
            foreach (ReaderSet readerSet in Program.qwer.ReaderSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    readerSet.ID.ToString(),
                    readerSet.FirstName,
                    readerSet.LastName,
                    readerSet.MiddleName,
                    readerSet.Phone
            });
                item.Tag = readerSet;
                listViewReader.Items.Add(item);
            }
            listViewReader.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewReader.SelectedItems.Count == 1)
            {
                ReaderSet readerSet = listViewReader.SelectedItems[0].Tag as ReaderSet;
                readerSet.FirstName = textBoxFirstName.Text;
                readerSet.LastName = textBoxLastName.Text;
                readerSet.MiddleName = textBoxMiddleName.Text;
                readerSet.Phone = textBoxPhone.Text;
                Program.qwer.SaveChanges();
                ShowReader();
            }
        }

        private void listViewReader_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewReader.SelectedItems.Count == 1)
            {
                ReaderSet readerSet = listViewReader.SelectedItems[0].Tag as ReaderSet;
                textBoxFirstName.Text = readerSet.FirstName;
                textBoxLastName.Text = readerSet.LastName;
                textBoxMiddleName.Text = readerSet.MiddleName;
                textBoxPhone.Text = readerSet.Phone;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            try
            {
                if (listViewReader.SelectedItems.Count == 1)
                {
                    ReaderSet readerSet = listViewReader.SelectedItems[0].Tag as ReaderSet;
                    Program.qwer.ReaderSet.Remove(readerSet);
                    Program.qwer.SaveChanges();
                    ShowReader();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
            }

            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
