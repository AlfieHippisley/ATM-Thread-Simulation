using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{

    // This contains the main program code
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

            CentralComputer centralComputer = new CentralComputer(ac);

            Thread thr1 = new Thread(centralComputer.createForm);
            thr1.Start();
        }

        static void Main()
        {
            new Program();
        }

    }

    // This contains all code relating to the bank accounts
    public class Account
    {
        private int balance;
        private int pin;
        private int accountNum;
        public Semaphore guard;

        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
            guard = new Semaphore(1,1);
        }

        public int getBalance()
        {
            return balance;
        }

        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        public Boolean decrementBalance(int amount)
        {
            if (this.balance > amount)
            {
                var timer = Task.Run(async delegate
                {
                    await Task.Delay(2000);
                    return 0;
                });
                timer.Wait();

                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

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

    // This contains some code realting to the ATM that could not be placed
    public class ATM
    {
        // Atm 'power switch'
        private Boolean atmOn = true;

        // Local accounts reference
        public Account[] accounts { get; private set; }

        public ATM(Account[] ac)
        {
            while (atmOn)
            {
                    atmOn = false;
            }

            accounts = ac;
        }

        public int getMoney()
        {
            return accounts[1].getBalance();
        }

        // Create form with true semaphore setting
        public void createFormTrue()
        {
            ATMForm atmform = new ATMForm(this);
            atmform.setSemaTrue();
            Application.Run(atmform);
        }

        // Create form with false semaphore setting
        public void createFormFalse()
        {
            ATMForm atmform = new ATMForm(this);
            atmform.setSemaFalse();
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

    // This contains the code that controls and launches the ATM's
    public class CentralComputer
    {
        // Atm 'power switch'
        private Boolean centralComputerOn = true;

        // Local accounts reference
        public Account[] accounts { get; private set; }

        public CentralComputer(Account[] ac)
        {
            while (centralComputerOn)
            {
                centralComputerOn = false;
            }

            accounts = ac;
        }

        public void createForm()
        {
            Overview centralComputer = new Overview(this);
            Application.Run(centralComputer);
        }

        public void startATM(int numberToBeStarted, Boolean semaSetting)
        {
            ATM atm1 = new ATM(accounts);
            ATM atm2 = new ATM(accounts);
            ATM atm3 = new ATM(accounts);
            ATM atm4 = new ATM(accounts);

            if (numberToBeStarted == 1 && semaSetting == false)
            {
                Thread thr1 = new Thread(atm1.createFormFalse);
                thr1.Start();
            }
            else if (numberToBeStarted == 2 && semaSetting == false)
            {
                Thread thr1 = new Thread(atm1.createFormFalse);
                thr1.Start();
                Thread thr2 = new Thread(atm1.createFormFalse);
                thr2.Start();
            }
            else if (numberToBeStarted == 3 && semaSetting == false)
            {
                Thread thr1 = new Thread(atm1.createFormFalse);
                thr1.Start();
                Thread thr2 = new Thread(atm1.createFormFalse);
                thr2.Start();
                Thread thr3 = new Thread(atm1.createFormFalse);
                thr3.Start();
            }
            else if (numberToBeStarted == 4 && semaSetting == false)
            {
                Thread thr1 = new Thread(atm1.createFormFalse);
                thr1.Start();
                Thread thr2 = new Thread(atm1.createFormFalse);
                thr2.Start();
                Thread thr3= new Thread(atm1.createFormFalse);
                thr3.Start();
                Thread thr4= new Thread(atm1.createFormFalse);
                thr4.Start();
            }
            else if (numberToBeStarted == 1 && semaSetting == true)
            {
                Thread thr1 = new Thread(atm1.createFormTrue);
                thr1.Start();
            }
            else if (numberToBeStarted == 2 && semaSetting == true)
            {
                Thread thr1 = new Thread(atm1.createFormTrue);
                thr1.Start();
                Thread thr2 = new Thread(atm1.createFormTrue);
                thr2.Start();
            }
            else if (numberToBeStarted == 3 && semaSetting == true)
            {
                Thread thr1 = new Thread(atm1.createFormTrue);
                thr1.Start();
                Thread thr2 = new Thread(atm1.createFormTrue);
                thr2.Start();
                Thread thr3 = new Thread(atm1.createFormTrue);
                thr3.Start();
            }
            else if (numberToBeStarted == 4 && semaSetting == true)
            {
                Thread thr1 = new Thread(atm1.createFormTrue);
                thr1.Start();
                Thread thr2 = new Thread(atm1.createFormTrue);
                thr2.Start();
                Thread thr3 = new Thread(atm1.createFormTrue);
                thr3.Start();
                Thread thr4 = new Thread(atm1.createFormTrue);
                thr4.Start();
            }
        }
    }

    // This contains the code relating to the overview form (CentralComputer UI)
    public partial class Overview : Form
    {
        private CentralComputer centralComputer;

        public Overview (CentralComputer centralComputer)
        {
            this.centralComputer = centralComputer;

            InitializeComponent();
        }
    }

    // This contains the code realting to the ATM form (ATM UI)
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

