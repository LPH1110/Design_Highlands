using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands.views.dialogs
{
    internal partial class Money : Form
    {
        Staff staff;
        FlowLayoutPanel billPanel;
        TextBox tbt_total;
        public Money()
        {
            InitializeComponent();

        }
        public Money(Staff staff, FlowLayoutPanel billPanel, TextBox tbt_total)
        {
            InitializeComponent();
            this.staff = staff;
            this.billPanel = billPanel;
            this.tbt_total = tbt_total;
        }

        private string changeInput(String btn_x)
        {
            int temp = int.Parse(tb_input.Text);
            int btn_temp = int.Parse(btn_x);
            int kq = temp * 10 + btn_temp;
            return kq.ToString();
        }

        private Boolean createBill()
        {
            // Connect to db
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("bills");

            // Create BsonDocument
            
               


            return true;
        }

        private void returnToPaymentView()
        {
            this.Hide();
            Payment paymentView = new Payment();
            paymentView.Show();
        }

        private void lb_return_Click(object sender, EventArgs e)
        {
            returnToPaymentView();
        }

        private void ptb_return_Click(object sender, EventArgs e)
        {
            returnToPaymentView();

        }
        private void Money_Load(object sender, EventArgs e)
        {
            tb_total.Text = tbt_total.Text ;   
            //this.tb_total.BackColor = System.Drawing.SystemColors.Control;
        }
        
        
        private void btn_0_Click(object sender, EventArgs e)
        {

            tb_input.Text = changeInput(btn_0.Text);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_input.Text = changeInput(btn_1.Text);

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_input.Text = changeInput(btn_2.Text);

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_input.Text = changeInput(btn_3.Text);

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_input.Text = changeInput(btn_4.Text);

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_input.Text = changeInput(btn_5.Text);

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_input.Text = changeInput(btn_6.Text);

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_input.Text = changeInput(btn_7.Text);

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_input.Text = changeInput(btn_8.Text);

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_input.Text = changeInput(btn_9.Text);

        }
        private String removeDots(String input)
        {
            var array = input.Split('.');
            string firstElem = array.First();
            string restOfArray = string.Join("", array);
            return restOfArray;
        }
        private void btn_10k_Click(object sender, EventArgs e)
        {
            
            tb_input.Text = removeDots(btn_10k.Text);
        }

        private void btn_20k_Click(object sender, EventArgs e)
        {
            tb_input.Text = removeDots(btn_20k.Text);

        }

        private void btn_50k_Click(object sender, EventArgs e)
        {
            tb_input.Text = removeDots(btn_50k.Text);

        }

        private void btn_100k_Click(object sender, EventArgs e)
        {
            tb_input.Text = removeDots(btn_100k.Text);

        }

        private void btn_200k_Click(object sender, EventArgs e)
        {
            tb_input.Text = removeDots(btn_200k.Text);

        }

        private void btn_500k_Click(object sender, EventArgs e)
        {
            tb_input.Text = removeDots(btn_500k.Text);

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(tb_input.Text);
            int kq = temp / 10;
            tb_input.Text = kq.ToString();
        }

        private void tb_input_TextChanged(object sender, EventArgs e)
        {
            tb_givenMoney.Text = tb_input.Text;
            tb_returnMoney.Text = (int.Parse(tb_givenMoney.Text) - int.Parse(tbt_total.Text)).ToString();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (createBill())
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                OrderScreen orderScreen = new OrderScreen();
                orderScreen.Show();
            } else
            {
                MessageBox.Show("Thanh toán thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
