using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands.components
{
    internal partial class DrinkDetail : UserControl
    {
        Drink drink;
        List<DrinkDetail> invoices;
        FlowLayoutPanel billPanel;
        String size;
        int sweet;
        int ice;
        TextBox tbt_total;
        public DrinkDetail()
        {
            InitializeComponent();
        }

        public DrinkDetail(Drink drink, string size, int sweet, int ice, List<DrinkDetail> invoices, FlowLayoutPanel billPanel, TextBox tbt_total)
        {
            InitializeComponent();
            this.drink = drink;
            this.size = size;
            this.sweet = sweet;
            this.ice = ice;
            this.invoices = invoices;
            this.billPanel = billPanel;
            this.tbt_total = tbt_total;
        }

         public int getActualPrice()
        {
            switch (size)
            {
                case "S":
                    return this.drink.Price.S;
                case "M":
                    return this.drink.Price.M;
                case "L":
                    return this.drink.Price.L;
                default:
                    return 0;
            }
        }

        private void DrinkDetail_Load(object sender, EventArgs e)
        {
            string nameE = drink.NameE;

            var image = (Bitmap)Properties.Resources.ResourceManager.GetObject(nameE);
            // Gán đối tượng Image vào PictureBox
            pb_drinkThumbnail.Image = image;

            txt_drinkName.Text = this.drink.NameV;
            txt_drinkSize.Text = this.size;
            txt_drinkSweet.Text = this.sweet.ToString() + "%";
            txt_drinkIce.Text = this.ice.ToString() + "%";
            txt_drinkPrice.Text = getActualPrice().ToString() + "đ";
        }

        private void lb_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này ra khỏi hóa đơn không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.Yes:
                    
                    foreach (DrinkDetail control in billPanel.Controls.OfType<DrinkDetail>())
                    {
                        if (control.drink != null && control.drink.Id.Equals(this.drink.Id))
                        {
                            int updatedPrice = Int32.Parse(tbt_total.Text) - control.getActualPrice();
                            tbt_total.Text = updatedPrice.ToString();
                            billPanel.Controls.Remove(control);
                            control.Dispose();
                        }
                    }
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
            
        }
    }
}
