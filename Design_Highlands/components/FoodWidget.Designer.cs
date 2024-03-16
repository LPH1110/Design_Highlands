namespace Design_Highlands.components
{
    partial class FoodWidget
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
            this.lb_foodTitle = new System.Windows.Forms.Label();
            this.pb_foodThumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foodThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_foodTitle
            // 
            this.lb_foodTitle.AutoSize = true;
            this.lb_foodTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_foodTitle.Location = new System.Drawing.Point(8, 226);
            this.lb_foodTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_foodTitle.MaximumSize = new System.Drawing.Size(333, 0);
            this.lb_foodTitle.Name = "lb_foodTitle";
            this.lb_foodTitle.Size = new System.Drawing.Size(87, 24);
            this.lb_foodTitle.TabIndex = 2;
            this.lb_foodTitle.Text = "Tên món";
            this.lb_foodTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_foodThumbnail
            // 
            this.pb_foodThumbnail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pb_foodThumbnail.Location = new System.Drawing.Point(12, 14);
            this.pb_foodThumbnail.Margin = new System.Windows.Forms.Padding(4);
            this.pb_foodThumbnail.Name = "pb_foodThumbnail";
            this.pb_foodThumbnail.Size = new System.Drawing.Size(286, 192);
            this.pb_foodThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foodThumbnail.TabIndex = 1;
            this.pb_foodThumbnail.TabStop = false;
            this.pb_foodThumbnail.DoubleClick += new System.EventHandler(this.pb_foodThumbnail_DoubleClick);
            // 
            // FoodWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_foodTitle);
            this.Controls.Add(this.pb_foodThumbnail);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(32, 30, 32, 30);
            this.Name = "FoodWidget";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Size = new System.Drawing.Size(315, 260);
            this.Load += new System.EventHandler(this.FoodWidget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foodThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_foodThumbnail;
        private System.Windows.Forms.Label lb_foodTitle;
    }
}
