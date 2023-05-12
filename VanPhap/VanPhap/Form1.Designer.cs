namespace VanPhap
{
    partial class Form_SoCauAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SoCauAn));
            this.lbl_title = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.txt_NickName = new System.Windows.Forms.TextBox();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.date_Birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.txt_ConGiap = new System.Windows.Forms.TextBox();
            this.lbl_ConGiap = new System.Windows.Forms.Label();
            this.txt_Sao = new System.Windows.Forms.TextBox();
            this.lbl_Sao = new System.Windows.Forms.Label();
            this.txt_Han = new System.Windows.Forms.TextBox();
            this.bl_Han = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.btn_find = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rbm_Woman = new System.Windows.Forms.RadioButton();
            this.rbm_other = new System.Windows.Forms.RadioButton();
            this.rbm_Man = new System.Windows.Forms.RadioButton();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tabale_List = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_findIcon = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.pnl_List = new System.Windows.Forms.Panel();
            this.lbl_List = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.pnl_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabale_List)).BeginInit();
            this.pnl_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 46);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(250, 31);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Phiếu điền thông tin";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(27, 27);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(97, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Họ và tên";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Name.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(132, 23);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(353, 32);
            this.txt_Name.TabIndex = 3;
            // 
            // lbl_sex
            // 
            this.lbl_sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(32, 106);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(90, 25);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "Giới tính";
            // 
            // txt_NickName
            // 
            this.txt_NickName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NickName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NickName.Location = new System.Drawing.Point(132, 64);
            this.txt_NickName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NickName.Name = "txt_NickName";
            this.txt_NickName.Size = new System.Drawing.Size(353, 32);
            this.txt_NickName.TabIndex = 10;
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(27, 68);
            this.lbl_NickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(102, 25);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_Birthday
            // 
            this.date_Birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_Birthday.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Birthday.Location = new System.Drawing.Point(133, 142);
            this.date_Birthday.Margin = new System.Windows.Forms.Padding(4);
            this.date_Birthday.Name = "date_Birthday";
            this.date_Birthday.Size = new System.Drawing.Size(353, 32);
            this.date_Birthday.TabIndex = 11;
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(28, 146);
            this.lbl_Birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(103, 25);
            this.lbl_Birthday.TabIndex = 12;
            this.lbl_Birthday.Text = "Ngày Sinh";
            this.lbl_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ConGiap
            // 
            this.txt_ConGiap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ConGiap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConGiap.Location = new System.Drawing.Point(669, 23);
            this.txt_ConGiap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ConGiap.Name = "txt_ConGiap";
            this.txt_ConGiap.Size = new System.Drawing.Size(353, 32);
            this.txt_ConGiap.TabIndex = 14;
            // 
            // lbl_ConGiap
            // 
            this.lbl_ConGiap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ConGiap.AutoSize = true;
            this.lbl_ConGiap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConGiap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ConGiap.Location = new System.Drawing.Point(564, 27);
            this.lbl_ConGiap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ConGiap.Name = "lbl_ConGiap";
            this.lbl_ConGiap.Size = new System.Drawing.Size(91, 25);
            this.lbl_ConGiap.TabIndex = 13;
            this.lbl_ConGiap.Text = "Con giáp";
            this.lbl_ConGiap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Sao
            // 
            this.txt_Sao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Sao.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sao.Location = new System.Drawing.Point(669, 64);
            this.txt_Sao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Sao.Name = "txt_Sao";
            this.txt_Sao.Size = new System.Drawing.Size(353, 32);
            this.txt_Sao.TabIndex = 16;
            // 
            // lbl_Sao
            // 
            this.lbl_Sao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sao.AutoSize = true;
            this.lbl_Sao.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Sao.Location = new System.Drawing.Point(564, 68);
            this.lbl_Sao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sao.Name = "lbl_Sao";
            this.lbl_Sao.Size = new System.Drawing.Size(45, 25);
            this.lbl_Sao.TabIndex = 15;
            this.lbl_Sao.Text = "Sao";
            this.lbl_Sao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Han
            // 
            this.txt_Han.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Han.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Han.Location = new System.Drawing.Point(669, 105);
            this.txt_Han.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Han.Name = "txt_Han";
            this.txt_Han.Size = new System.Drawing.Size(353, 32);
            this.txt_Han.TabIndex = 18;
            // 
            // bl_Han
            // 
            this.bl_Han.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bl_Han.AutoSize = true;
            this.bl_Han.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_Han.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bl_Han.Location = new System.Drawing.Point(564, 108);
            this.bl_Han.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bl_Han.Name = "bl_Han";
            this.bl_Han.Size = new System.Drawing.Size(47, 25);
            this.bl_Han.TabIndex = 17;
            this.bl_Han.Text = "Hạn";
            this.bl_Han.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.giúpĐỡToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1124, 29);
            this.Menu.TabIndex = 19;
            this.Menu.Text = "menuStrip1";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.ShowShortcutKeys = false;
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.tìmToolStripMenuItem,
            this.lưuLạiToolStripMenuItem,
            this.inSổToolStripMenuItem,
            this.xóaSổToolStripMenuItem});
            this.chỉnhSửaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.AccessibleDescription = "";
            this.thêmToolStripMenuItem.AccessibleName = "ctrl +n";
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.thêmToolStripMenuItem.Tag = "ctrl +n";
            this.thêmToolStripMenuItem.Text = "Thêm sổ mới";
            this.thêmToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.thêmToolStripMenuItem.ToolTipText = "ctrl +n";
            // 
            // tìmToolStripMenuItem
            // 
            this.tìmToolStripMenuItem.Name = "tìmToolStripMenuItem";
            this.tìmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.tìmToolStripMenuItem.Text = "Tìm";
            // 
            // lưuLạiToolStripMenuItem
            // 
            this.lưuLạiToolStripMenuItem.Name = "lưuLạiToolStripMenuItem";
            this.lưuLạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuLạiToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.lưuLạiToolStripMenuItem.Text = "Lưu lại";
            // 
            // inSổToolStripMenuItem
            // 
            this.inSổToolStripMenuItem.Name = "inSổToolStripMenuItem";
            this.inSổToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.inSổToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.inSổToolStripMenuItem.Text = "In sổ";
            // 
            // xóaSổToolStripMenuItem
            // 
            this.xóaSổToolStripMenuItem.Name = "xóaSổToolStripMenuItem";
            this.xóaSổToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaSổToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.xóaSổToolStripMenuItem.Text = "Xóa sổ";
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
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // pnl_Form
            // 
            this.pnl_Form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Form.Controls.Add(this.btn_find);
            this.pnl_Form.Controls.Add(this.rbm_Woman);
            this.pnl_Form.Controls.Add(this.rbm_other);
            this.pnl_Form.Controls.Add(this.rbm_Man);
            this.pnl_Form.Controls.Add(this.btn_Update);
            this.pnl_Form.Controls.Add(this.btn_Delete);
            this.pnl_Form.Controls.Add(this.btn_Add);
            this.pnl_Form.Controls.Add(this.txt_Han);
            this.pnl_Form.Controls.Add(this.lbl_name);
            this.pnl_Form.Controls.Add(this.bl_Han);
            this.pnl_Form.Controls.Add(this.txt_Name);
            this.pnl_Form.Controls.Add(this.txt_Sao);
            this.pnl_Form.Controls.Add(this.lbl_sex);
            this.pnl_Form.Controls.Add(this.lbl_Sao);
            this.pnl_Form.Controls.Add(this.txt_ConGiap);
            this.pnl_Form.Controls.Add(this.lbl_ConGiap);
            this.pnl_Form.Controls.Add(this.lbl_Birthday);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.date_Birthday);
            this.pnl_Form.Controls.Add(this.txt_NickName);
            this.pnl_Form.Location = new System.Drawing.Point(8, 80);
            this.pnl_Form.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(1104, 202);
            this.pnl_Form.TabIndex = 20;
            // 
            // btn_find
            // 
            this.btn_find.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_find.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.ImageIndex = 4;
            this.btn_find.ImageList = this.imageList1;
            this.btn_find.Location = new System.Drawing.Point(959, 164);
            this.btn_find.Margin = new System.Windows.Forms.Padding(4);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(100, 32);
            this.btn_find.TabIndex = 25;
            this.btn_find.Text = "Tìm";
            this.btn_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_find.UseVisualStyleBackColor = true;
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
            // 
            // rbm_Woman
            // 
            this.rbm_Woman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbm_Woman.AutoSize = true;
            this.rbm_Woman.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Woman.Location = new System.Drawing.Point(275, 103);
            this.rbm_Woman.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Woman.Name = "rbm_Woman";
            this.rbm_Woman.Size = new System.Drawing.Size(61, 29);
            this.rbm_Woman.TabIndex = 24;
            this.rbm_Woman.TabStop = true;
            this.rbm_Woman.Text = "Nữ";
            this.rbm_Woman.UseVisualStyleBackColor = true;
            // 
            // rbm_other
            // 
            this.rbm_other.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbm_other.AutoSize = true;
            this.rbm_other.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_other.Location = new System.Drawing.Point(361, 103);
            this.rbm_other.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_other.Name = "rbm_other";
            this.rbm_other.Size = new System.Drawing.Size(78, 29);
            this.rbm_other.TabIndex = 23;
            this.rbm_other.TabStop = true;
            this.rbm_other.Text = "Khác";
            this.rbm_other.UseVisualStyleBackColor = true;
            // 
            // rbm_Man
            // 
            this.rbm_Man.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbm_Man.AutoSize = true;
            this.rbm_Man.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Man.Location = new System.Drawing.Point(173, 103);
            this.rbm_Man.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Man.Name = "rbm_Man";
            this.rbm_Man.Size = new System.Drawing.Size(75, 29);
            this.rbm_Man.TabIndex = 22;
            this.rbm_Man.TabStop = true;
            this.rbm_Man.Text = "Nam";
            this.rbm_Man.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ImageIndex = 1;
            this.btn_Update.ImageList = this.imageList1;
            this.btn_Update.Location = new System.Drawing.Point(743, 164);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 32);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ImageIndex = 2;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(851, 164);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 32);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageKey = "add-icon.png";
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(635, 164);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 32);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tabale_List
            // 
            this.tabale_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabale_List.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tabale_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabale_List.Location = new System.Drawing.Point(5, 53);
            this.tabale_List.Margin = new System.Windows.Forms.Padding(4);
            this.tabale_List.Name = "tabale_List";
            this.tabale_List.RowHeadersWidth = 51;
            this.tabale_List.Size = new System.Drawing.Size(1092, 447);
            this.tabale_List.TabIndex = 21;
            this.tabale_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabale_List_CellContentClick);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_search.Location = new System.Drawing.Point(680, 11);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(353, 29);
            this.txt_search.TabIndex = 26;
            this.txt_search.Tag = "";
            // 
            // btn_findIcon
            // 
            this.btn_findIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_findIcon.ImageIndex = 1;
            this.btn_findIcon.ImageList = this.icon;
            this.btn_findIcon.Location = new System.Drawing.Point(1043, 11);
            this.btn_findIcon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_findIcon.Name = "btn_findIcon";
            this.btn_findIcon.Size = new System.Drawing.Size(45, 33);
            this.btn_findIcon.TabIndex = 27;
            this.btn_findIcon.UseVisualStyleBackColor = true;
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
            // pnl_List
            // 
            this.pnl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_List.Controls.Add(this.btn_findIcon);
            this.pnl_List.Controls.Add(this.tabale_List);
            this.pnl_List.Controls.Add(this.txt_search);
            this.pnl_List.Location = new System.Drawing.Point(8, 341);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(1104, 505);
            this.pnl_List.TabIndex = 28;
            // 
            // lbl_List
            // 
            this.lbl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_List.AutoSize = true;
            this.lbl_List.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_List.Location = new System.Drawing.Point(12, 308);
            this.lbl_List.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_List.Name = "lbl_List";
            this.lbl_List.Size = new System.Drawing.Size(137, 31);
            this.lbl_List.TabIndex = 29;
            this.lbl_List.Text = "Danh sách";
            // 
            // Form_SoCauAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1124, 864);
            this.Controls.Add(this.lbl_List);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_SoCauAn";
            this.Text = "Quản lý cầu an";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabale_List)).EndInit();
            this.pnl_List.ResumeLayout(false);
            this.pnl_List.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.TextBox txt_NickName;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.DateTimePicker date_Birthday;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.TextBox txt_ConGiap;
        private System.Windows.Forms.Label lbl_ConGiap;
        private System.Windows.Forms.TextBox txt_Sao;
        private System.Windows.Forms.Label lbl_Sao;
        private System.Windows.Forms.TextBox txt_Han;
        private System.Windows.Forms.Label bl_Han;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView tabale_List;
        private System.Windows.Forms.RadioButton rbm_Man;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.RadioButton rbm_Woman;
        private System.Windows.Forms.RadioButton rbm_other;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_findIcon;
        private System.Windows.Forms.ImageList icon;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.Label lbl_List;
        private System.Windows.Forms.ToolStripMenuItem xóaSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}

