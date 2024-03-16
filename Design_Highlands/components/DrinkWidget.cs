using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands.components
{
    internal partial class DrinkWidget : UserControl
    {
        Drink drink;
        FlowLayoutPanel billPanel;
        TextBox tbt_total;
        public DrinkWidget(Drink drink, FlowLayoutPanel billPanel, TextBox tbt_total)
        {
            InitializeComponent();
            this.drink = drink;
            this.billPanel = billPanel;
            this.tbt_total = tbt_total;
        }

        private void DrinkWidget_Load(object sender, EventArgs e)
        {
            if (drink != null)
            {
                string nameE = drink.NameE;
                lb_drinkTitle.Text = drink.NameV;

                var image = (Bitmap)Properties.Resources.ResourceManager.GetObject(nameE);
                // Gán đối tượng Image vào PictureBox
                pb_drinkThumbnail.Image = image;
            }
        }

        private void showDrinkDetail(Drink drink)
        {
            DrinkOption drinkOption = new DrinkOption(this.drink, this.billPanel, tbt_total);
            drinkOption.ShowDialog();
        }

        private void pb_drinkThumbnail_DoubleClick(object sender, EventArgs e)
        {
            showDrinkDetail(this.drink);
        }
    }
}
