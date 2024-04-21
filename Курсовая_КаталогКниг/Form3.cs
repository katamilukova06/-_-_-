using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая_КаталогКниг
{
    public partial class DisplayForm : Form
    {
        public static short _id = 0;
        public DisplayForm()
        {
            InitializeComponent();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void View_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            short i = 0;
            ListViewItem list;
            listView1.Items.Clear();
            foreach (var item in Greeting.ListOfBooks)
            {
                list = new ListViewItem(Convert.ToString(i));
                list.SubItems.Add(item.Author);
                list.SubItems.Add(item.Name);
                list.SubItems.Add(item.Year);
                list.SubItems.Add(item.PublishingHouse);
                list.SubItems.Add(item.Annotation);
                listView1.Items.Add(list);
                i++;
            }
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Hide();
            Greeting greeting = new Greeting();
            greeting.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt16(textBox1.Text);
            Greeting.ListOfBooks.RemoveAt(_id);

            Writers.Writer.WriteToFiles("Books.txt");

            MessageBox.Show("Удалено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt16(textBox1.Text);
            Hide();
            EditingForm editing = new EditingForm();
            editing.Show();
        }
    }
}
