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
    public partial class FormBookPlace : Form
    {
        public FormBookPlace()
        {
            InitializeComponent();
            ShowBooks();
            ShowReader();
            ShowLibrarian();
            ShowBookPlace();
        }

        private void labelReader_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxReader_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormBookPlace_Load(object sender, EventArgs e) 
        {

        }

        private void labelLibrarian_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLibrarian_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ShowBooks()
        {
            comboBoxBook.Items.Clear();
            foreach (BooksSet booksSet in Program.qwer.BooksSet)
            {
                string[] item = { booksSet.ID.ToString() + ".", booksSet.Name + ".", booksSet.Author };
                comboBoxBook.Items.Add(string.Join("", item));
            }
        }
        void ShowReader()
        {
            comboBoxReader.Items.Clear();
            foreach (ReaderSet readerSet in Program.qwer.ReaderSet)
            {
                string[] item = { readerSet.ID.ToString() + ".", readerSet.FirstName,
                    readerSet.LastName,readerSet.MiddleName };
                comboBoxReader.Items.Add(string.Join("", item));
            }
        }
        void ShowLibrarian()
        {
            comboBoxLibrarian.Items.Clear();
            foreach (LibrarianSet librarianSet in Program.qwer.LibrarianSet)
            {
                string[] item = { librarianSet.ID.ToString() + ".", librarianSet.FirstName,
                    librarianSet.LastName,librarianSet.MiddleName };
                comboBoxLibrarian.Items.Add(string.Join("", item));
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxBook.SelectedItem != null
                && comboBoxReader.SelectedItem != null
                && comboBoxLibrarian.SelectedItem != null)
            {
                BookPlaceSet bookPlace = new BookPlaceSet();
                bookPlace.IDBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                bookPlace.IDReader = Convert.ToInt32(comboBoxReader.SelectedItem.ToString().Split('.')[0]);
                bookPlace.IDLibrarian = Convert.ToInt32(comboBoxLibrarian.SelectedItem.ToString().Split('.')[0]);
                Program.qwer.BookPlaceSet.Add(bookPlace);
                Program.qwer.SaveChanges();
                ShowBookPlace();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowBookPlace()
        {
            listViewBookPlace.Items.Clear();
            foreach(BookPlaceSet bookPlace in Program.qwer.BookPlaceSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    bookPlace.IDBook.ToString(),
                    bookPlace.BooksSet.Name,
                    bookPlace.BooksSet.Author,
                    bookPlace.IDReader.ToString(),
                    bookPlace.ReaderSet.LastName+""+bookPlace.ReaderSet.FirstName+""+bookPlace.ReaderSet.MiddleName,
                    bookPlace.IDLibrarian.ToString(),
                    bookPlace.LibrarianSet.LastName+""+bookPlace.LibrarianSet.FirstName+""+bookPlace.LibrarianSet.MiddleName,
                });
                item.Tag = bookPlace;
                listViewBookPlace.Items.Add(item);
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBookPlace.SelectedItems.Count == 1)
            {
                BookPlaceSet bookPlace = listViewBookPlace.SelectedItems[0].Tag as BookPlaceSet;
                bookPlace.IDBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                bookPlace.IDReader = Convert.ToInt32(comboBoxReader.SelectedItem.ToString().Split('.')[0]);
                bookPlace.IDLibrarian = Convert.ToInt32(comboBoxLibrarian.SelectedItem.ToString().Split('.')[0]);
                Program.qwer.SaveChanges();
                ShowBookPlace();

            }
        }

        private void listViewBookPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBookPlace.SelectedItems.Count == 1)
            {
                BookPlaceSet bookPlace = listViewBookPlace.SelectedItems[0].Tag as BookPlaceSet;
                comboBoxBook.SelectedIndex = comboBoxBook.FindString(bookPlace.IDBook.ToString());
                comboBoxReader.SelectedIndex = comboBoxReader.FindString(bookPlace.IDReader.ToString());
                comboBoxLibrarian.SelectedIndex = comboBoxLibrarian.FindString(bookPlace.IDLibrarian.ToString());
            }
            else
            {
                comboBoxBook.SelectedItem = null;
                comboBoxReader.SelectedItem = null;
                comboBoxLibrarian.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBookPlace.SelectedItems.Count == 1)
                {
                    BookPlaceSet bookPlace = listViewBookPlace.SelectedItems[0].Tag as BookPlaceSet;
                    Program.qwer.BookPlaceSet.Remove(bookPlace);
                    Program.qwer.SaveChanges();
                    ShowBookPlace();
                }
                comboBoxBook.SelectedItem = null;
                comboBoxReader.SelectedItem = null;
                comboBoxLibrarian.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
