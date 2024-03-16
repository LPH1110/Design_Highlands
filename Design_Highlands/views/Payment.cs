using Design_Highlands.views.dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands.views
{
    internal partial class Payment : Form
    {
        Staff staff;
        FlowLayoutPanel billPanel;
        TextBox tbt_total;
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(Staff staff, FlowLayoutPanel billPanel, TextBox tbt_total)
        {
            InitializeComponent();
            this.staff = staff;
            this.billPanel = billPanel;
            this.tbt_total = tbt_total;
        }

        private void showMoneyDialog()
        {
            this.Hide();
            Money moneyDialog = new Money(staff, billPanel, tbt_total);
            moneyDialog.ShowDialog();
        }

         private void returnToOrder()
        {
            this.Hide();
            OrderScreen orderScreen = new OrderScreen(billPanel);
            orderScreen.Show();
        }

        private void ptb_money_Click(object sender, EventArgs e)
        {
            showMoneyDialog();
        }

        private void lb_money_Click(object sender, EventArgs e)
        {
            showMoneyDialog();
        }

        private void lb_return_Click(object sender, EventArgs e)
        {
            returnToOrder();
        }

        private void lb_digitalWallet_Click(object sender, EventArgs e)
        {

        }

        private void ptb_creditCard_Click(object sender, EventArgs e)
        {

        }

        private void ptb_digitalWallet_Click(object sender, EventArgs e)
        {

        }

        private void lb_creditCard_Click(object sender, EventArgs e)
        {

        }
    }
}
