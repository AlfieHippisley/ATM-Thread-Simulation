using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    class Program
    {
        private Account[] ac = new Account[3];

        private ATMForm atm1;
        private ATMForm atm2;

        public Program()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

            // This needs to be first
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread thr1 = new Thread(new ThreadStart(generateATM));
            thr1.Start();
            Thread thr2 = new Thread(new ThreadStart(generateATM));
            thr2.Start();
            Thread thr3 = new Thread(new ThreadStart(generateATM));
            thr3.Start();
            Thread thr4 = new Thread(new ThreadStart(generateATM));
            thr4.Start();
        }

        private void generateATM()
        {
            atm1 = new ATMForm();
            Application.Run(atm1);
        }

        static void Main()
        {
            new Program();
        }
    }

    public partial class ATMForm : Form
    {


    }

    /*
     *   The Account class encapusulates all features of a simple bank account
     */

    class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   reurns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean decrementBalance(int amount)
        {
            if (this.balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getAccountNum()
        {
            return accountNum;
        }

    }

}
