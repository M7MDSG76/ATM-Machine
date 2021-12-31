using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlahliBankSystem
{
    public partial class ATM : Form
    {
        
        public ATM()
        {
            InitializeComponent();
           
            label1.BackColor = Color.Transparent;
          
            label2.BackColor = Color.Transparent;
        }
       

        private void ATM_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try {
              int PINEntered = Convert.ToInt32(PIN.Text);
              string IDInput = ID.Text;
            
           
                if (ID.Text == "admin" && PINEntered == 1234)
                {
                    MessageBox.Show("Valied Input");
                    
                    this.Hide();
                Form2 x = new Form2();
                x.ShowDialog();

                }
                else 
                    MessageBox.Show($"invalied Input please try agian.");
            } catch (FormatException)
            {
                MessageBox.Show("PIN shuld be a number, please try agian");
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

         void textBox2_TextChanged(object sender, EventArgs e)
        {

           
        }
    }
}
