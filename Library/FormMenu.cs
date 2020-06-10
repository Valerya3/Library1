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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "librarian") buttonLibra.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            Form formBooks = new FormBooks();
            formBooks.Show();
        }

        private void buttonLibra_Click(object sender, EventArgs e)
        {
            Form formLibrarian = new FormLibrarian();
            formLibrarian.Show();
        }

        private void buttonReader_Click(object sender, EventArgs e)
        {
            Form formReader = new FormReader();
            formReader.Show();
        }

        private void buttonBookPlace_Click(object sender, EventArgs e)
        {
            Form formBookPlace = new FormBookPlace();
            formBookPlace.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
