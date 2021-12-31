using System;
using System.Windows.Forms;

namespace AlahliBankSystem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Account.Depsit(int.Parse(textBox1.Text));
                Account.checkBalance();
                this.Hide();
                Form2 x = new Form2();
                x.ShowDialog();
            }
            catch (FormatException)
                {
                    MessageBox.Show("Wrong Input");
                } 
            
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
