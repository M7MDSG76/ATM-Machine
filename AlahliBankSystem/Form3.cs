using System;
using System.Windows.Forms;

namespace AlahliBankSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Amount = int.Parse(textBox1.Text);
            Account.WithDrow(Amount);
            Account.checkBalance();
            this.Hide();
            Form2 x = new Form2();
            x.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.ShowDialog();
            this.Hide();
        }
    }
}
