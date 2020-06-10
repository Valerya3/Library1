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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
            ShowBooks();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BooksSet booksSet = new BooksSet();
            booksSet.Name = textBoxName.Text;
            booksSet.Year = textBoxYear.Text;
            booksSet.Author = textBoxAuthor.Text;
            Program.qwer.BooksSet.Add(booksSet);
            Program.qwer.SaveChanges();
            ShowBooks();
        }
        void ShowBooks()
        {
            listViewBooks.Items.Clear(); 
            foreach (BooksSet booksSet in Program.qwer.BooksSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    booksSet.ID.ToString(), booksSet.Name, booksSet.Year,
                     booksSet.Author
                });
                item.Tag = booksSet;
                listViewBooks.Items.Add(item);
            }
            listViewBooks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBooks.SelectedItems.Count == 1)
                {
                    BooksSet booksSet = listViewBooks.SelectedItems[0].Tag as BooksSet;
                    Program.qwer.BooksSet.Remove(booksSet);
                    Program.qwer.SaveChanges();
                    ShowBooks();
                }
                textBoxName.Text = "";
                textBoxAuthor.Text = "";
                textBoxYear.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 1)
            {
                BooksSet booksSet = listViewBooks.SelectedItems[0].Tag as BooksSet;
                booksSet.Name = textBoxName.Text;
                booksSet.Year = textBoxYear.Text;
                booksSet.Author = textBoxAuthor.Text;
                Program.qwer.SaveChanges();
                ShowBooks();
            }
        }

        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 1)
            {
                BooksSet booksSet = listViewBooks.SelectedItems[0].Tag as BooksSet;
                textBoxName.Text = booksSet.Name;
                textBoxAuthor.Text = booksSet.Author;
                textBoxYear.Text = booksSet.Year;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAuthor.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
