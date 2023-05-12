namespace VanPhap
{
    partial class form_manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_manage));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inSớToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inSớCầuSiêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sơCầuAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sớCầuAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sớCầuSiêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_SoCauSieu = new System.Windows.Forms.Button();
            this.btn_SoCauAn = new System.Windows.Forms.Button();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_buttom = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Component = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Logo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChọnToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1443, 27);
            this.Menu.TabIndex = 19;
            this.Menu.Text = "menuStrip1";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoátToolStripMenuItem2});
            this.tùyChọnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem2
            // 
            this.thoátToolStripMenuItem2.Name = "thoátToolStripMenuItem2";
            this.thoátToolStripMenuItem2.Size = new System.Drawing.Size(159, 24);
            this.thoátToolStripMenuItem2.Text = "Thoát";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inSớToolStripMenuItem,
            this.inSớCầuSiêuToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShowShortcutKeys = false;
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.thoátToolStripMenuItem.Text = "Tùy chọn";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // inSớToolStripMenuItem
            // 
            this.inSớToolStripMenuItem.Name = "inSớToolStripMenuItem";
            this.inSớToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.inSớToolStripMenuItem.Text = "In sớ cầu an";
            this.inSớToolStripMenuItem.Click += new System.EventHandler(this.inSớToolStripMenuItem_Click);
            // 
            // inSớCầuSiêuToolStripMenuItem
            // 
            this.inSớCầuSiêuToolStripMenuItem.Name = "inSớCầuSiêuToolStripMenuItem";
            this.inSớCầuSiêuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.inSớCầuSiêuToolStripMenuItem.Text = "In sớ cầu siêu";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            // 
            // sơCầuAnToolStripMenuItem
            // 
            this.sơCầuAnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sớCầuAnToolStripMenuItem,
            this.sớCầuSiêuToolStripMenuItem});
            this.sơCầuAnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sơCầuAnToolStripMenuItem.Name = "sơCầuAnToolStripMenuItem";
            this.sơCầuAnToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.sơCầuAnToolStripMenuItem.Text = "Sớ cầu";
            this.sơCầuAnToolStripMenuItem.Click += new System.EventHandler(this.sơCầuAnToolStripMenuItem_Click);
            // 
            // sớCầuAnToolStripMenuItem
            // 
            this.sớCầuAnToolStripMenuItem.Name = "sớCầuAnToolStripMenuItem";
            this.sớCầuAnToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sớCầuAnToolStripMenuItem.Text = "Sớ cầu an";
            this.sớCầuAnToolStripMenuItem.Click += new System.EventHandler(this.sớCầuAnToolStripMenuItem_Click);
            // 
            // sớCầuSiêuToolStripMenuItem
            // 
            this.sớCầuSiêuToolStripMenuItem.Name = "sớCầuSiêuToolStripMenuItem";
            this.sớCầuSiêuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sớCầuSiêuToolStripMenuItem.Text = "Sớ cầu siêu";
            this.sớCầuSiêuToolStripMenuItem.Click += new System.EventHandler(this.sớCầuSiêuToolStripMenuItem_Click);
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.giúpĐỡToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Image = global::VanPhap.Properties.Resources.guide_icon01;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Button-Refresh-icon.png");
            this.imageList1.Images.SetKeyName(2, "delete-icon.png");
            this.imageList1.Images.SetKeyName(3, "Pencil-icon.png");
            this.imageList1.Images.SetKeyName(4, "search-icon.png");
            this.imageList1.Images.SetKeyName(5, "guide_icon.png");
            // 
            // icon
            // 
            this.icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon.ImageStream")));
            this.icon.TransparentColor = System.Drawing.Color.Transparent;
            this.icon.Images.SetKeyName(0, "find_icon.png");
            this.icon.Images.SetKeyName(1, "find_icon1.png");
            this.icon.Images.SetKeyName(2, "computer_icon.png");
            this.icon.Images.SetKeyName(3, "add-icon.png");
            this.icon.Images.SetKeyName(4, "delete-icon.png");
            this.icon.Images.SetKeyName(5, "Pencil-icon.png");
            this.icon.Images.SetKeyName(6, "search-icon.png");
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.pnl_Menu.Controls.Add(this.btn_SoCauSieu);
            this.pnl_Menu.Controls.Add(this.btn_SoCauAn);
            this.pnl_Menu.Controls.Add(this.pnl_Logo);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 27);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(204, 696);
            this.pnl_Menu.TabIndex = 31;
            // 
            // btn_SoCauSieu
            // 
            this.btn_SoCauSieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.btn_SoCauSieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SoCauSieu.FlatAppearance.BorderSize = 0;
            this.btn_SoCauSieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SoCauSieu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SoCauSieu.Location = new System.Drawing.Point(0, 147);
            this.btn_SoCauSieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SoCauSieu.Name = "btn_SoCauSieu";
            this.btn_SoCauSieu.Size = new System.Drawing.Size(204, 49);
            this.btn_SoCauSieu.TabIndex = 34;
            this.btn_SoCauSieu.Text = "Sớ cầu siêu";
            this.btn_SoCauSieu.UseVisualStyleBackColor = false;
            this.btn_SoCauSieu.Click += new System.EventHandler(this.btn_SoCauSieu_Click);
            // 
            // btn_SoCauAn
            // 
            this.btn_SoCauAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.btn_SoCauAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SoCauAn.FlatAppearance.BorderSize = 0;
            this.btn_SoCauAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SoCauAn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SoCauAn.Location = new System.Drawing.Point(0, 98);
            this.btn_SoCauAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SoCauAn.Name = "btn_SoCauAn";
            this.btn_SoCauAn.Size = new System.Drawing.Size(204, 49);
            this.btn_SoCauAn.TabIndex = 33;
            this.btn_SoCauAn.Text = "Sớ cầu an";
            this.btn_SoCauAn.UseVisualStyleBackColor = false;
            this.btn_SoCauAn.Click += new System.EventHandler(this.btn_SoCauAn_Click);
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.pnl_Logo.Controls.Add(this.label2);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(204, 98);
            this.pnl_Logo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 2;
            this.label2.ImageList = this.imageList2;
            this.label2.Location = new System.Drawing.Point(60, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 73);
            this.label2.TabIndex = 0;
            this.label2.Text = "   ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "4791023_buddha_building_china_landmark_pagoda_icon.png");
            this.imageList2.Images.SetKeyName(1, "4791023_buddha_building_china_landmark_pagoda_icon (1).png");
            this.imageList2.Images.SetKeyName(2, "pagoda_128_icon.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1239, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 696);
            this.panel1.TabIndex = 35;
            // 
            // pnl_buttom
            // 
            this.pnl_buttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.pnl_buttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttom.Location = new System.Drawing.Point(204, 644);
            this.pnl_buttom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_buttom.Name = "pnl_buttom";
            this.pnl_buttom.Size = new System.Drawing.Size(1035, 79);
            this.pnl_buttom.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.panel3.Controls.Add(this.lbl_Title);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(204, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1035, 98);
            this.panel3.TabIndex = 37;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(439, 34);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(134, 32);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Pháp Vân";
            // 
            // pnl_Component
            // 
            this.pnl_Component.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Component.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Component.Location = new System.Drawing.Point(204, 125);
            this.pnl_Component.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Component.Name = "pnl_Component";
            this.pnl_Component.Size = new System.Drawing.Size(1035, 519);
            this.pnl_Component.TabIndex = 38;
            // 
            // form_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1443, 723);
            this.Controls.Add(this.pnl_Component);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_buttom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "form_manage";
            this.Text = "Quản lý sớ cầu";
            this.Load += new System.EventHandler(this.Form_SoThongTin_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Logo.ResumeLayout(false);
            this.pnl_Logo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.ImageList icon;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Button btn_SoCauAn;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sơCầuAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sớCầuAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sớCầuSiêuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inSớToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inSớCầuSiêuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Button btn_SoCauSieu;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_buttom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Component;
    }
}

