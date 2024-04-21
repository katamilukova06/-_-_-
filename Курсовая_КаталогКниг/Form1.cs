using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Курсовая_КаталогКниг.Breakers;
using Курсовая_КаталогКниг.Models;

namespace Курсовая_КаталогКниг
{
    public partial class Greeting : Form
    {
        private static List<Book> listOfBooks = new List<Book>();
        internal static List<Book> ListOfBooks { get => listOfBooks; set => listOfBooks = value; }
        public Greeting()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            listOfBooks.Clear();
            Readers.Reader.ReadingFile("Books.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            AdditionForm additionForm = new AdditionForm();
            additionForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            DisplayForm displayForm = new DisplayForm();
            displayForm.Show();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
