namespace XeDapShop
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ptbSetting = new System.Windows.Forms.PictureBox();
            this.ptbBaocao = new System.Windows.Forms.PictureBox();
            this.ptbUser = new System.Windows.Forms.PictureBox();
            this.ptbXedap = new System.Windows.Forms.PictureBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXedap)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbSetting
            // 
            this.ptbSetting.Image = global::XeDapShop.Properties.Resources.setting;
            this.ptbSetting.Location = new System.Drawing.Point(1193, 12);
            this.ptbSetting.Name = "ptbSetting";
            this.ptbSetting.Size = new System.Drawing.Size(111, 86);
            this.ptbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSetting.TabIndex = 5;
            this.ptbSetting.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbSetting, "Setting");
            this.ptbSetting.Click += new System.EventHandler(this.ptbSetting_Click);
            // 
            // ptbBaocao
            // 
            this.ptbBaocao.Image = global::XeDapShop.Properties.Resources.pie_chart;
            this.ptbBaocao.Location = new System.Drawing.Point(935, 12);
            this.ptbBaocao.Name = "ptbBaocao";
            this.ptbBaocao.Size = new System.Drawing.Size(111, 86);
            this.ptbBaocao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBaocao.TabIndex = 4;
            this.ptbBaocao.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbBaocao, "Báo cáo");
            this.ptbBaocao.Click += new System.EventHandler(this.ptbBaocao_Click);
            // 
            // ptbUser
            // 
            this.ptbUser.Image = global::XeDapShop.Properties.Resources.group;
            this.ptbUser.Location = new System.Drawing.Point(603, 12);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(111, 86);
            this.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUser.TabIndex = 3;
            this.ptbUser.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbUser, "Quản Lý Người Dùng");
            this.ptbUser.Click += new System.EventHandler(this.ptbUser_Click);
            // 
            // ptbXedap
            // 
            this.ptbXedap.Image = global::XeDapShop.Properties.Resources.bicycle;
            this.ptbXedap.Location = new System.Drawing.Point(330, 12);
            this.ptbXedap.Name = "ptbXedap";
            this.ptbXedap.Size = new System.Drawing.Size(111, 86);
            this.ptbXedap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbXedap.TabIndex = 2;
            this.ptbXedap.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbXedap, "Quản Lý Xe Đạp");
            this.ptbXedap.Click += new System.EventHandler(this.ptbXedap_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(100, 38);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(187, 40);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Trang Chủ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ptbSetting);
            this.panel1.Controls.Add(this.ptbBaocao);
            this.panel1.Controls.Add(this.ptbUser);
            this.panel1.Controls.Add(this.ptbXedap);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 113);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XeDapShop.Properties.Resources.store;
            this.pictureBox1.Location = new System.Drawing.Point(13, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 592);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ptbMain
            // 
            this.ptbMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ptbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbMain.Image = global::XeDapShop.Properties.Resources.Welcome_Wallpapers;
            this.ptbMain.Location = new System.Drawing.Point(3, 18);
            this.ptbMain.Name = "ptbMain";
            this.ptbMain.Size = new System.Drawing.Size(1340, 571);
            this.ptbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMain.TabIndex = 0;
            this.ptbMain.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 705);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.ptbSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBaocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXedap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbXedap;
        private System.Windows.Forms.PictureBox ptbUser;
        private System.Windows.Forms.PictureBox ptbBaocao;
        private System.Windows.Forms.PictureBox ptbSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptbMain;
    }
}