using Design_Highlands.components;
using Design_Highlands.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands
{
    internal partial class DrinkOption : Form
    {
        Drink drink;
        FlowLayoutPanel billPanel;
        List<DrinkDetail> invoices;
        String size;
        int sweet;
        int ice;
        TextBox tbt_total;

        public DrinkOption()
        {
            InitializeComponent();
            this.size = "S";
            this.sweet = 0;
            this.ice = 0;
            invoices = new List<DrinkDetail>();
        }
        public DrinkOption(Drink drink, FlowLayoutPanel billPanel,TextBox tbt_total)
        {
            InitializeComponent();
            this.drink = drink;
            this.size = "S";
            this.sweet = 0;
            this.ice = 0;
            this.billPanel = billPanel;
            this.tbt_total = tbt_total;
            invoices = new List<DrinkDetail>();
        }

        // Events
        private void btn_sizeS_Click(object sender, EventArgs e)
        {
            this.size = "S";
            txt_size.Text = this.size;
        }
        private void btn_sizeM_Click(object sender, EventArgs e)
        {
            this.size = "M";
            txt_size.Text = this.size;
        }
        private void btn_sizeL_Click(object sender, EventArgs e)
        {
            this.size = "L";
            txt_size.Text = this.size;
        }

        private void btn_optionConfirm_Click(object sender, EventArgs e)
        {
            DrinkDetail drinkDetailWidget = new DrinkDetail(this.drink, size, sweet, ice, invoices, billPanel, tbt_total);
            invoices.Add(drinkDetailWidget);
            int price = drinkDetailWidget.getActualPrice();
            

            foreach (var item in invoices)
            {
                billPanel.Controls.Add(item);
                // price with size

                int updatedPrice = Int32.Parse(tbt_total.Text) + price;
                tbt_total.Text = updatedPrice.ToString();
            }
            this.Hide();
            
        }

        private void DrinkOption_Load(object sender, EventArgs e)
        {
            txt_size.Text = "S";
            txt_sweet.Text = "0%";
            txt_ice.Text = "0%";
        }

        // Sweet option
        private void btn_sweet0_Click(object sender, EventArgs e)
        {
            this.sweet = 0;
            txt_sweet.Text = "0%";
        }
        private void btn_sweet30_Click(object sender, EventArgs e)
        {
            this.sweet = 30;
            txt_sweet.Text = "30%";
        }
        private void btn_sweet50_Click(object sender, EventArgs e)
        {
            this.sweet = 50;
            txt_sweet.Text = "50%";
        }
        private void btn_sweet100_Click(object sender, EventArgs e)
        {
            this.sweet = 100;
            txt_sweet.Text = "100%";
        }

        // Ice option
        private void btn_ice0_Click(object sender, EventArgs e)
        {
            this.ice = 0;
            txt_ice.Text = "0%";
        }
        private void btn_ice30_Click(object sender, EventArgs e)
        {
            this.ice = 30;
            txt_ice.Text = "30%";
        }
        private void btn_ice50_Click(object sender, EventArgs e)
        {
            this.ice = 50;
            txt_ice.Text = "50%";
        }
        private void btn_ice100_Click(object sender, EventArgs e)
        {
            this.ice = 100;
            txt_ice.Text = "100%";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
