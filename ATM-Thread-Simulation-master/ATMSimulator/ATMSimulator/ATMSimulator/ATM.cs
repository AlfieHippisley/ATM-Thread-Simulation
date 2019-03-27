using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ATMSimulator
{
    public partial class ATMForm : Form
    {
        private Program program;
        //hold account number
        private Account accountnumber;
        //hold atm step
        // 1 - input account number
        // 2 - input pin
        // 3 - select from:
        // 4 - withdrawal
        // 5 - check balance
        // 6 - exit (take card)
        private int step=1;
        //hold number of pin tries
        private int tries=0;
        public ATMForm()
        {
            InitializeComponent();

            // In order to create buttons without padding/margins we need to change the style of each one

            // Line Select Keys
            LineSelectKey8.FlatStyle = FlatStyle.Flat;
            LineSelectKey8.FlatAppearance.BorderSize = 0;
            LineSelectKey7.FlatStyle = FlatStyle.Flat;
            LineSelectKey7.FlatAppearance.BorderSize = 0;
            LineSelectKey6.FlatStyle = FlatStyle.Flat;
            LineSelectKey6.FlatAppearance.BorderSize = 0;
            LineSelectKey5.FlatStyle = FlatStyle.Flat;
            LineSelectKey5.FlatAppearance.BorderSize = 0;
            LineSelectKey4.FlatStyle = FlatStyle.Flat;
            LineSelectKey4.FlatAppearance.BorderSize = 0;
            LineSelectKey3.FlatStyle = FlatStyle.Flat;
            LineSelectKey3.FlatAppearance.BorderSize = 0;
            LineSelectKey2.FlatStyle = FlatStyle.Flat;
            LineSelectKey2.FlatAppearance.BorderSize = 0;
            LineSelectKey1.FlatStyle = FlatStyle.Flat;
            LineSelectKey1.FlatAppearance.BorderSize = 0;

            // Action Buttons
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.FlatAppearance.BorderSize = 0;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.FlatAppearance.BorderSize = 0;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.FlatAppearance.BorderSize = 0;

            // Keypad
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.FlatAppearance.BorderSize = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LineSelectKey8_Click(object sender, EventArgs e)
        {
            if(step == 4)
            {
                step = 3;
                TitleLabel.Text = "Your balance is: " + accountnumber.getBalance().ToString();
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
            }
            
        }

        private void LineSelectKey7_Click(object sender, EventArgs e)
        {
            if(step == 3)
            {
                TitleLabel.Text = "Returning card. Bye!";
                Thread.Sleep(1000);
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                step = 1;
                tries = 0;
                accountnumber = null;
                TitleLabel.Text = "Enter Account Number";
            }
            else if (step == 4)
            {

            }
           
        }

        private void LineSelectKey6_Click(object sender, EventArgs e)
        {
            if (step == 4)
            {
                if (accountnumber.decrementBalance(200))
                {
                    TitleLabel.Text = "Collect your money.";
                    Thread.Sleep(300);
                    TitleLabel.Text = "Your balance is: " + accountnumber.getBalance().ToString();
                }
                else
                {
                    step = 3;
                    tries = 0;
                    TitleLabel.Text = "Insufficient funds";
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                }
            }
        }

        private void LineSelectKey5_Click(object sender, EventArgs e)
        {
            if (step == 4)
            {
                if (accountnumber.decrementBalance(25))
                {
                    TitleLabel.Text = "Collect your money.";
                    Thread.Sleep(300);
                    TitleLabel.Text = "Your balance is: " + accountnumber.getBalance().ToString();
                }
                else
                {
                    tries = 0;
                    step = 3;
                    TitleLabel.Text = "Insufficient funds";
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                }
            }
        }

        private void LineSelectKey4_Click(object sender, EventArgs e)
        {
            if (step == 4)
            {
                if (accountnumber.decrementBalance(100))
                {
                    TitleLabel.Text = "Collect your money.";
                    Thread.Sleep(300);
                    TitleLabel.Text = "Your balance is: " + accountnumber.getBalance().ToString();
                }
                else
                {
                    step = 3;
                    tries = 0;
                    TitleLabel.Text = "Insufficient funds";
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                }
            }
        }

        private void LineSelectKey3_Click(object sender, EventArgs e)
        {
            if (step == 3)
            {
                TitleLabel.Text = "Collect your money.";
                Thread.Sleep(300);
                TitleLabel.Text = "Your balance is: " + accountnumber.getBalance().ToString();
                label1.Text = String.Empty;
            }
            else if (step == 4)
            {
                    if (accountnumber.decrementBalance(10))
                    {
                    TitleLabel.Text = "Collect your money.";
                    Thread.Sleep(300);
                    TitleLabel.Text = "Your balance is: " + accountnumber.getBalance().ToString();
                }
                    else
                    {
                        step = 3;
                    tries = 0;
                    TitleLabel.Text = "Insufficient funds";
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                }
            }
            
        }

        private void LineSelectKey2_Click(object sender, EventArgs e)
        {
            if (step == 4)
            {
                if (accountnumber.decrementBalance(50))
                {
                    TitleLabel.Text = "Collect your money.";
                    Thread.Sleep(300);
                    TitleLabel.Text = "Your balance is: " + accountnumber.getBalance().ToString();
                }
                else
                {
                    step = 3;
                    TitleLabel.Text = "Insufficient funds";
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                }
            }
        }

        private void LineSelectKey1_Click(object sender, EventArgs e)
        {
            if (step == 3)
            {
                TitleLabel.Text = "Your balance is: " + accountnumber.getBalance().ToString();
                step = 4;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
            }
            else if (step == 4)
            {
                if (accountnumber.decrementBalance(5))
                {
                    TitleLabel.Text = "Collect your money.";
                    Thread.Sleep(300);
                    TitleLabel.Text = "Your balance is: " + accountnumber.getBalance().ToString();
                }
                else
                {
                    step = 3;
                    TitleLabel.Text = "Insufficient funds";
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                }
            }
            


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            TitleLabel.Text = "Returning card. Bye!";
            Thread.Sleep(1000);
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            step = 1;
            tries = 0;
            accountnumber = null;
            TitleLabel.Text = "Enter Account Number";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (label1.Text != "") // Are there any characters to remove?
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1); // Remove last character?

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                //enter account number
             case 1:
                    if (accountnumber != null)
                    {
                        TitleLabel.Text = "Enter PIN";
                        label1.Text = String.Empty;
                        step = 2;

                    }
                    else
                    {
                        accountnumber = atm.findAccount(label1.Text);
                        if (accountnumber != null)
                        {
                            step = 2;
                            TitleLabel.Text = "Enter PIN";
                            label1.Text = String.Empty;
                        }
                    }
                    break;
                  //enter pin
             case 2:
                        if (label1.Text != "" && accountnumber.checkPin(Convert.ToInt32(label1.Text)))
                        {
                        TitleLabel.Text = "Hello!";
                            label1.Text = String.Empty;
                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            step = 3;
                        }
                        else
                        {
                            TitleLabel.Text = "Wrong pin";
                            tries++;
                            if (tries > 2)
                            {
                                //i don't prompt user with a warning (3x wrong pin) as for some reason changing label.text before thread.sleep() is ignored and wont be visible to the user
                                TitleLabel.Text = "Enter Account Number";
                                step = 1;
                                accountnumber = null;
                            }
                        }
                    break;
            default:
                    break;
            }
            
            
            
        }

        // Start of buttons
        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        public void TitleLabel_ChangeText(string text)
        {
            TitleLabel.Text = text;
        }

        private void InputLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}