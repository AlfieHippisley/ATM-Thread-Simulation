using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class Overview : Form
    {
        private Boolean semSetting = true;

        public Overview()
        {
            InitializeComponent();
        }

        private void Overview_Load(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            centralComputer.startATM(1, semSetting);
            OneButton.Visible = false;
            TwoButton.Visible = false;
            ThreeButton.Visible = false;
            FourButton.Visible = false;
            ConfirmButton.Visible = false;
            NoButton.Visible = false;
            SemaStatus.Visible = false;
            TitleLabel.Text = "You started One ATM Simulation";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            centralComputer.startATM(2, semSetting);
            OneButton.Visible = false;
            TwoButton.Visible = false;
            ThreeButton.Visible = false;
            FourButton.Visible = false;
            ConfirmButton.Visible = false;
            NoButton.Visible = false;
            SemaStatus.Visible = false;
            TitleLabel.Text = "You started Two ATM Simulations";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            centralComputer.startATM(3, semSetting);
            OneButton.Visible = false;
            TwoButton.Visible = false;
            ThreeButton.Visible = false;
            FourButton.Visible = false;
            ConfirmButton.Visible = false;
            NoButton.Visible = false;
            SemaStatus.Visible = false;
            TitleLabel.Text = "You started Three ATM Simulations";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            centralComputer.startATM(4, semSetting);
            OneButton.Visible = false;
            TwoButton.Visible = false;
            ThreeButton.Visible = false;
            FourButton.Visible = false;
            ConfirmButton.Visible = false;
            NoButton.Visible = false;
            SemaStatus.Visible = false;
            TitleLabel.Text = "You started Four ATM Simulations";
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Semaphore Status : On";
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Semaphore Status : Off";
        }

        private void SemaStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
