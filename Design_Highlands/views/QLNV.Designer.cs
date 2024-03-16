namespace Design_Highlands
{
    partial class QLNV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.staffsGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btn_updateStaff = new System.Windows.Forms.Button();
            this.btn_createStaff = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_deleteStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.staffsGridView);
            this.panel2.Location = new System.Drawing.Point(3, 176);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1896, 758);
            this.panel2.TabIndex = 10;
            // 
            // staffsGridView
            // 
            this.staffsGridView.AllowUserToAddRows = false;
            this.staffsGridView.AllowUserToDeleteRows = false;
            this.staffsGridView.AllowUserToOrderColumns = true;
            this.staffsGridView.AllowUserToResizeRows = false;
            this.staffsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffsGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.staffsGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlCustom1;
            this.staffsGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.staffsGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.staffsGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.staffsGridView.Location = new System.Drawing.Point(0, 0);
            this.staffsGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffsGridView.Name = "staffsGridView";
            this.staffsGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffsGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.staffsGridView.Size = new System.Drawing.Size(1898, 758);
            this.staffsGridView.StateCommon.Background.Image = global::Design_Highlands.Properties.Resources.background;
            this.staffsGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlCustom1;
            this.staffsGridView.TabIndex = 0;
            this.staffsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffsGridView_CellDoubleClick);
            // 
            // btn_updateStaff
            // 
            this.btn_updateStaff.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateStaff.BackgroundImage = global::Design_Highlands.Properties.Resources.backgroundbtn;
            this.btn_updateStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateStaff.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateStaff.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_updateStaff.Location = new System.Drawing.Point(32, 22);
            this.btn_updateStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_updateStaff.Name = "btn_updateStaff";
            this.btn_updateStaff.Size = new System.Drawing.Size(227, 50);
            this.btn_updateStaff.TabIndex = 21;
            this.btn_updateStaff.Text = "SỬA THÔNG TIN";
            this.btn_updateStaff.UseVisualStyleBackColor = false;
            this.btn_updateStaff.Click += new System.EventHandler(this.btn_updateStaff_Click);
            // 
            // btn_createStaff
            // 
            this.btn_createStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_createStaff.BackgroundImage = global::Design_Highlands.Properties.Resources.backgroundbtn;
            this.btn_createStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createStaff.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createStaff.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_createStaff.Location = new System.Drawing.Point(552, 22);
            this.btn_createStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createStaff.Name = "btn_createStaff";
            this.btn_createStaff.Size = new System.Drawing.Size(237, 50);
            this.btn_createStaff.TabIndex = 20;
            this.btn_createStaff.Text = "THÊM NHÂN VIÊN";
            this.btn_createStaff.UseVisualStyleBackColor = false;
            this.btn_createStaff.Click += new System.EventHandler(this.btn_createStaff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tan;
            this.label7.Image = global::Design_Highlands.Properties.Resources.background;
            this.label7.Location = new System.Drawing.Point(47, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Trở về";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Design_Highlands.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(5, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(33, 973);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 39);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.btn_deleteStaff);
            this.panel4.Controls.Add(this.btn_updateStaff);
            this.panel4.Controls.Add(this.btn_createStaff);
            this.panel4.Location = new System.Drawing.Point(1016, 940);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(885, 97);
            this.panel4.TabIndex = 23;
            // 
            // btn_deleteStaff
            // 
            this.btn_deleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_deleteStaff.BackgroundImage = global::Design_Highlands.Properties.Resources.backgroundbtn;
            this.btn_deleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteStaff.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteStaff.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_deleteStaff.Location = new System.Drawing.Point(283, 22);
            this.btn_deleteStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteStaff.Name = "btn_deleteStaff";
            this.btn_deleteStaff.Size = new System.Drawing.Size(245, 50);
            this.btn_deleteStaff.TabIndex = 23;
            this.btn_deleteStaff.Text = "XÓA NHÂN VIÊN";
            this.btn_deleteStaff.UseVisualStyleBackColor = false;
            this.btn_deleteStaff.Click += new System.EventHandler(this.btn_deleteStaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Design_Highlands.Properties.Resources.background;
            this.label1.Location = new System.Drawing.Point(247, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.ptb_logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptb_logo.Image = global::Design_Highlands.Properties.Resources.logo;
            this.ptb_logo.Location = new System.Drawing.Point(3, 3);
            this.ptb_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(225, 155);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_logo.TabIndex = 33;
            this.ptb_logo.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Design_Highlands.Properties.Resources.ask;
            this.pictureBox5.Location = new System.Drawing.Point(824, 45);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ptb_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLNV_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_updateStaff;
        private System.Windows.Forms.Button btn_createStaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_deleteStaff;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView staffsGridView;
        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}