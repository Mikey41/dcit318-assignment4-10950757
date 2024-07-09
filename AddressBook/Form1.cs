using System;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}", "Address Book Entry");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
