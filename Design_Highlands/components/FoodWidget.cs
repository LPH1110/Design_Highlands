using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Highlands.models;
using Design_Highlands.components;
using static System.Windows.Forms.LinkLabel;
using ZstdSharp.Unsafe;
using DnsClient.Protocol;

namespace Design_Highlands.components
{
    internal partial class FoodWidget : UserControl
    {
        Food food;
        FlowLayoutPanel billPanel;
        TextBox tbt_total;
        public FoodWidget()
        {
            InitializeComponent();
        }

        public FoodWidget(Food food, FlowLayoutPanel billPanel, TextBox tbt_total)
        {
            InitializeComponent();
            this.food = food;
            this.billPanel = billPanel;
            this.tbt_total = tbt_total;
        }

        private void FoodWidget_Load(object sender, EventArgs e)
        {
            if (this.food != null)
            {
                string nameE = food.NameE;

                lb_foodTitle.Text = food.NameE;

                var image = (Bitmap)Properties.Resources.ResourceManager.GetObject(nameE);
                // Gán đối tượng Image vào PictureBox
                pb_foodThumbnail.Image = image;
            }
        }

        

        private void pb_foodThumbnail_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thêm món này vào hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.Yes:
                    FoodDetail foodDetailWidget = new FoodDetail(this.food, billPanel, tbt_total);

                    billPanel.Controls.Add(foodDetailWidget);
                    int price = Int32.Parse(tbt_total.Text) + this.food.Price;
                    tbt_total.Text = price.ToString();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        public static implicit operator Type(FoodWidget v)
        {
            throw new NotImplementedException();
        }
    }
}
