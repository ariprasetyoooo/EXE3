using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXE3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            if (username == "Ariii" && password == "12345")
            {
                Form2 form_2 = new Form2();
                form_2.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Login Failed");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
