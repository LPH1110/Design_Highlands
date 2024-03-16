namespace Design_Highlands.components
{
    partial class FoodDetail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_cancel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_foodPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_foodName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcryptonlabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pb_foodThumbnail = new System.Windows.Forms.PictureBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_foodEngName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_foodClass = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foodThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_cancel
            // 
            this.lb_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_cancel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lb_cancel.Location = new System.Drawing.Point(473, 166);
            this.lb_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.lb_cancel.Name = "lb_cancel";
            this.lb_cancel.Size = new System.Drawing.Size(64, 24);
            this.lb_cancel.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.lb_cancel.StateCommon.LongText.Color2 = System.Drawing.Color.Red;
            this.lb_cancel.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lb_cancel.TabIndex = 25;
            this.lb_cancel.Values.Text = "Hủy bỏ";
            this.lb_cancel.Click += new System.EventHandler(this.lb_cancel_Click);
            // 
            // txt_foodPrice
            // 
            this.txt_foodPrice.Location = new System.Drawing.Point(307, 126);
            this.txt_foodPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_foodPrice.Name = "txt_foodPrice";
            this.txt_foodPrice.Size = new System.Drawing.Size(45, 24);
            this.txt_foodPrice.TabIndex = 24;
            this.txt_foodPrice.Values.Text = "price";
            // 
            // txt_foodName
            // 
            this.txt_foodName.Location = new System.Drawing.Point(307, 31);
            this.txt_foodName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_foodName.Name = "txt_foodName";
            this.txt_foodName.Size = new System.Drawing.Size(88, 24);
            this.txt_foodName.TabIndex = 20;
            this.txt_foodName.Values.Text = "drink name";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(172, 126);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(73, 24);
            this.kryptonLabel4.TabIndex = 19;
            this.kryptonLabel4.Values.Text = "Đơn giá:";
            // 
            // kcryptonlabel
            // 
            this.kcryptonlabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kcryptonlabel.Location = new System.Drawing.Point(172, 31);
            this.kcryptonlabel.Margin = new System.Windows.Forms.Padding(4);
            this.kcryptonlabel.Name = "kcryptonlabel";
            this.kcryptonlabel.Size = new System.Drawing.Size(80, 24);
            this.kcryptonlabel.TabIndex = 15;
            this.kcryptonlabel.Values.Text = "Tên món:";
            // 
            // pb_foodThumbnail
            // 
            this.pb_foodThumbnail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_foodThumbnail.Location = new System.Drawing.Point(19, 31);
            this.pb_foodThumbnail.Margin = new System.Windows.Forms.Padding(4);
            this.pb_foodThumbnail.Name = "pb_foodThumbnail";
            this.pb_foodThumbnail.Size = new System.Drawing.Size(133, 123);
            this.pb_foodThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foodThumbnail.TabIndex = 14;
            this.pb_foodThumbnail.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(172, 62);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(117, 24);
            this.kryptonLabel2.TabIndex = 17;
            this.kryptonLabel2.Values.Text = "Tên Tiếng Anh";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(172, 94);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(83, 24);
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Phân loại:";
            // 
            // txt_foodEngName
            // 
            this.txt_foodEngName.Location = new System.Drawing.Point(307, 62);
            this.txt_foodEngName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_foodEngName.Name = "txt_foodEngName";
            this.txt_foodEngName.Size = new System.Drawing.Size(102, 24);
            this.txt_foodEngName.TabIndex = 22;
            this.txt_foodEngName.Values.Text = "english name";
            // 
            // txt_foodClass
            // 
            this.txt_foodClass.Location = new System.Drawing.Point(307, 94);
            this.txt_foodClass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_foodClass.Name = "txt_foodClass";
            this.txt_foodClass.Size = new System.Drawing.Size(51, 24);
            this.txt_foodClass.TabIndex = 23;
            this.txt_foodClass.Values.Text = "bread";
            // 
            // FoodDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_cancel);
            this.Controls.Add(this.txt_foodPrice);
            this.Controls.Add(this.txt_foodClass);
            this.Controls.Add(this.txt_foodEngName);
            this.Controls.Add(this.txt_foodName);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kcryptonlabel);
            this.Controls.Add(this.pb_foodThumbnail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FoodDetail";
            this.Size = new System.Drawing.Size(555, 202);
            this.Load += new System.EventHandler(this.FoodDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foodThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_foodPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_foodName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kcryptonlabel;
        private System.Windows.Forms.PictureBox pb_foodThumbnail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_foodEngName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_foodClass;
    }
}
