using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public class Program
    {
        // Array of accounts
        public Account[] ac = new Account[3];

        public Program()
        {

            // Accounts
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

            // This needs to be first, due to order of events
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ATM atm1 = new ATM(ac);
            ATM atm2 = new ATM(ac);
            ATM atm3 = new ATM(ac);
            ATM atm4 = new ATM(ac);

            Thread thr1 = new Thread(atm1.createForm);
            thr1.Start();
            Thread thr2 = new Thread(atm2.createForm);
            thr2.Start();
            Thread thr3 = new Thread(atm3.createForm);
            thr3.Start();
            Thread thr4 = new Thread(atm4.createForm);
            thr4.Start();
        }


        static void Main()
        {
            new Program();
        }

    }
        public class Account
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

        public class ATM 
        {


            //this is a referance to the account that is being used
            private Account activeAccount = null;

            // Atm 'power switch'
            private Boolean atmOn = true;

            private ATMForm atmForm;

        public Account[] accounts { get; private set; }

        public ATM(Account[] ac)
            {
                while (atmOn)
                {
                    atmOn = false;
                }

            accounts = ac;
            }

            public void accountLogin()
            {
               //     TitleLabel_ChangeText("dupa");
            }

            public int getMoney()
            {
                return accounts[1].getBalance();
            }

            public void createForm()
            {
                ATMForm atmform = new ATMForm(this);
                Application.Run(atmform);
            }

            public Account findAccount(String input)
            {
                int accnum=0;
                if (input!="")
                {
                    accnum = Convert.ToInt32(input);
                }
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i].getAccountNum() == accnum)
                    {
                        return accounts[i];
                    }
                }

                return null;
            }
    }

    public partial class ATMForm : Form
    {
        private ATM atm;

        public ATMForm(ATM atm)
        {
            this.atm = atm;

            InitializeComponent();
        }
    }
}

