namespace Design_Highlands.components
{
    partial class DrinkWidget
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
            this.lb_drinkTitle = new System.Windows.Forms.Label();
            this.pb_drinkThumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_drinkThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_drinkTitle
            // 
            this.lb_drinkTitle.AutoSize = true;
            this.lb_drinkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_drinkTitle.Location = new System.Drawing.Point(8, 221);
            this.lb_drinkTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_drinkTitle.MaximumSize = new System.Drawing.Size(333, 0);
            this.lb_drinkTitle.Name = "lb_drinkTitle";
            this.lb_drinkTitle.Size = new System.Drawing.Size(87, 24);
            this.lb_drinkTitle.TabIndex = 1;
            this.lb_drinkTitle.Text = "Tên món";
            this.lb_drinkTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_drinkThumbnail
            // 
            this.pb_drinkThumbnail.BackColor = System.Drawing.Color.Transparent;
            this.pb_drinkThumbnail.Location = new System.Drawing.Point(12, 14);
            this.pb_drinkThumbnail.Margin = new System.Windows.Forms.Padding(4);
            this.pb_drinkThumbnail.Name = "pb_drinkThumbnail";
            this.pb_drinkThumbnail.Size = new System.Drawing.Size(286, 192);
            this.pb_drinkThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_drinkThumbnail.TabIndex = 0;
            this.pb_drinkThumbnail.TabStop = false;
            this.pb_drinkThumbnail.DoubleClick += new System.EventHandler(this.pb_drinkThumbnail_DoubleClick);
            // 
            // DrinkWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lb_drinkTitle);
            this.Controls.Add(this.pb_drinkThumbnail);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(32, 30, 32, 30);
            this.Name = "DrinkWidget";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Size = new System.Drawing.Size(315, 260);
            this.Load += new System.EventHandler(this.DrinkWidget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_drinkThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_drinkThumbnail;
        private System.Windows.Forms.Label lb_drinkTitle;
    }
}
