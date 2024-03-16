namespace Design_Highlands
{
    partial class QLTV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.membersGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_updateMem = new System.Windows.Forms.Button();
            this.btn_createMem = new System.Windows.Forms.Button();
            this.lb_back = new System.Windows.Forms.Label();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_deleteMem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.membersGridView);
            this.panel2.Location = new System.Drawing.Point(3, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1896, 760);
            this.panel2.TabIndex = 25;
            // 
            // membersGridView
            // 
            this.membersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.membersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.membersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersGridView.Location = new System.Drawing.Point(0, 0);
            this.membersGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.membersGridView.Name = "membersGridView";
            this.membersGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.membersGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.membersGridView.Size = new System.Drawing.Size(1896, 763);
            this.membersGridView.StateCommon.Background.Image = global::Design_Highlands.Properties.Resources.background;
            this.membersGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.membersGridView.TabIndex = 0;
            this.membersGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersGridView_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.panel1.Controls.Add(this.ptb_logo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 154);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Design_Highlands.Properties.Resources.background;
            this.label1.Location = new System.Drawing.Point(231, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THÀNH VIÊN";
            // 
            // btn_updateMem
            // 
            this.btn_updateMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_updateMem.BackgroundImage = global::Design_Highlands.Properties.Resources.backgroundbtn;
            this.btn_updateMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateMem.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateMem.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_updateMem.Location = new System.Drawing.Point(24, 21);
            this.btn_updateMem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_updateMem.Name = "btn_updateMem";
            this.btn_updateMem.Size = new System.Drawing.Size(239, 50);
            this.btn_updateMem.TabIndex = 21;
            this.btn_updateMem.Text = "SỬA THÔNG TIN";
            this.btn_updateMem.UseVisualStyleBackColor = false;
            this.btn_updateMem.Click += new System.EventHandler(this.btn_updateMem_Click);
            // 
            // btn_createMem
            // 
            this.btn_createMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_createMem.BackgroundImage = global::Design_Highlands.Properties.Resources.backgroundbtn;
            this.btn_createMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createMem.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createMem.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_createMem.Location = new System.Drawing.Point(566, 21);
            this.btn_createMem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createMem.Name = "btn_createMem";
            this.btn_createMem.Size = new System.Drawing.Size(279, 50);
            this.btn_createMem.TabIndex = 20;
            this.btn_createMem.Text = "THÊM THÀNH VIÊN";
            this.btn_createMem.UseVisualStyleBackColor = false;
            this.btn_createMem.Click += new System.EventHandler(this.btn_createMem_Click);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_back.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_back.ForeColor = System.Drawing.Color.Tan;
            this.lb_back.Image = global::Design_Highlands.Properties.Resources.background;
            this.lb_back.Location = new System.Drawing.Point(75, 986);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(83, 25);
            this.lb_back.TabIndex = 19;
            this.lb_back.Text = "Trở về";
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            // 
            // pb_back
            // 
            this.pb_back.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.pb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_back.Image = global::Design_Highlands.Properties.Resources.back;
            this.pb_back.Location = new System.Drawing.Point(28, 984);
            this.pb_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(47, 32);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 18;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.btn_deleteMem);
            this.panel4.Controls.Add(this.btn_updateMem);
            this.panel4.Controls.Add(this.btn_createMem);
            this.panel4.Location = new System.Drawing.Point(957, 940);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(942, 97);
            this.panel4.TabIndex = 27;
            // 
            // btn_deleteMem
            // 
            this.btn_deleteMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_deleteMem.BackgroundImage = global::Design_Highlands.Properties.Resources.backgroundbtn;
            this.btn_deleteMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteMem.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteMem.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_deleteMem.Location = new System.Drawing.Point(283, 21);
            this.btn_deleteMem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteMem.Name = "btn_deleteMem";
            this.btn_deleteMem.Size = new System.Drawing.Size(264, 50);
            this.btn_deleteMem.TabIndex = 23;
            this.btn_deleteMem.Text = "XÓA THÀNH VIÊN";
            this.btn_deleteMem.UseVisualStyleBackColor = false;
            this.btn_deleteMem.Click += new System.EventHandler(this.btn_deleteMem_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.panel3.Location = new System.Drawing.Point(342, 767);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 36);
            this.panel3.TabIndex = 26;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Design_Highlands.Properties.Resources.ask;
            this.pictureBox5.Location = new System.Drawing.Point(886, 36);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.ptb_logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptb_logo.Image = global::Design_Highlands.Properties.Resources.logo;
            this.ptb_logo.Location = new System.Drawing.Point(0, 2);
            this.ptb_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(225, 155);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_logo.TabIndex = 34;
            this.ptb_logo.TabStop = false;
            // 
            // QLTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Design_Highlands.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pb_back);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLTV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLTV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLTV_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membersGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_updateMem;
        private System.Windows.Forms.Button btn_createMem;
        private System.Windows.Forms.Label lb_back;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_deleteMem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView membersGridView;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox ptb_logo;
    }
}