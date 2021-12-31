using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlahliBankSystem
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            Form5 f5 = new Form5();

            if (radioButton1.Checked)
                Account.checkBalance();
            else if (radioButton2.Checked)
            {
                f1.ShowDialog();

                this.Hide();
            }
            else if (radioButton3.Checked)
            {
                f5.ShowDialog();

                this.Hide();
            }
            else if (radioButton4.Checked)
            {

                MessageBox.Show("Thank you for using our services, good bay.");
                this.Hide();
                Environment.Exit(1);


            }





        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    public class Account
    {
        protected static double AccBalance = 20000;
        public static void WithDrow(double InputAmount)
        {
            if (InputAmount <= AccBalance)
            {
                switch (InputAmount % 500)
                {

                    case 0:
                        AccBalance -= InputAmount;
                        break;

                    default:
                        MessageBox.Show("Wrong Input"); //the amount should be in 50 multiplications.
                        break;
                }
            }else
                MessageBox.Show("you dont have inuogh balance");

        }
        public static bool checkID(string x)
        {
            if (x == "admin")
            {
                return true;
            }
            else
            {
                MessageBox.Show("ID is wrong");
                return false;
            }
        }
        public static bool checkPIN(int x)
        {
            if (x == 1234)
                return true;
            else
            {
                MessageBox.Show("ID is wrong");
                return false;
            }

            {

            }
        }
            public static void Depsit(double x) => AccBalance += x;
            public static void checkBalance()
            {
                MessageBox.Show("Your balance is: " + AccBalance + " SR");
            }
        }
    } 
