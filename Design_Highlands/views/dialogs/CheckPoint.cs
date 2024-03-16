using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Highlands.views;

namespace Design_Highlands.views.dialogs
{
    internal partial class CheckPoint : Form
    {
        FlowLayoutPanel billPanel;
        Staff staff;
        TextBox tbt_total;
        public CheckPoint()
        {
            InitializeComponent();
        }

        public CheckPoint(Staff staff, FlowLayoutPanel billPanel,TextBox tbt_total)
        {
            InitializeComponent();
            this.billPanel = billPanel;
            this.staff = staff;
            this.tbt_total = tbt_total;
        }

        private void showPayment()
        {
            this.Hide();
            Payment paymentView = new Payment(staff, billPanel, tbt_total);
            paymentView.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            showPayment();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
