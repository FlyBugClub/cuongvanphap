namespace VanPhap.View
{
    partial class FormUpdateNguoiNhanCauAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateNguoiNhanCauAn));
            this.lsv_danhsach_cauan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_id_so = new System.Windows.Forms.TextBox();
            this.txt_gioi_tinh_1 = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.rbm_Nu = new System.Windows.Forms.RadioButton();
            this.lbl_tuoi = new System.Windows.Forms.Label();
            this.rbm_Nam = new System.Windows.Forms.RadioButton();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.txt_han = new System.Windows.Forms.TextBox();
            this.lbl_Sao = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.bl_Han = new System.Windows.Forms.Label();
            this.txt_sao = new System.Windows.Forms.TextBox();
            this.txt_idchubai = new System.Windows.Forms.TextBox();
            this.txt_GioiTinhThemVaoDb = new System.Windows.Forms.TextBox();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.txt_tuoiii = new System.Windows.Forms.TextBox();
            this.lbl_PhieuDiemThongTin = new System.Windows.Forms.Label();
            this.pnl_list = new System.Windows.Forms.Panel();
            this.lbl_danhsach = new System.Windows.Forms.Label();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.txt_update = new System.Windows.Forms.Button();
            this.pnl_Form.SuspendLayout();
            this.pnl_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsv_danhsach_cauan
            // 
            this.lsv_danhsach_cauan.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lsv_danhsach_cauan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_danhsach_cauan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lsv_danhsach_cauan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_danhsach_cauan.FullRowSelect = true;
            this.lsv_danhsach_cauan.GridLines = true;
            this.lsv_danhsach_cauan.HideSelection = false;
            this.lsv_danhsach_cauan.Location = new System.Drawing.Point(-3, -2);
            this.lsv_danhsach_cauan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsv_danhsach_cauan.Name = "lsv_danhsach_cauan";
            this.lsv_danhsach_cauan.Size = new System.Drawing.Size(1030, 342);
            this.lsv_danhsach_cauan.TabIndex = 23;
            this.lsv_danhsach_cauan.UseCompatibleStateImageBehavior = false;
            this.lsv_danhsach_cauan.View = System.Windows.Forms.View.Details;
            this.lsv_danhsach_cauan.ItemActivate += new System.EventHandler(this.lsv_danhsach_cauan_ItemActivate);
            this.lsv_danhsach_cauan.SelectedIndexChanged += new System.EventHandler(this.lsv_danhsach_cauan_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pháp danh";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Năm sinh";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Âm lịch";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sao";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hạn";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "IDSo";
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
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(554, 166);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(12, 42);
            this.txt_id.TabIndex = 58;
            this.txt_id.TabStop = false;
            this.txt_id.Visible = false;
            // 
            // txt_id_so
            // 
            this.txt_id_so.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id_so.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_so.Location = new System.Drawing.Point(573, 166);
            this.txt_id_so.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_so.Name = "txt_id_so";
            this.txt_id_so.Size = new System.Drawing.Size(12, 42);
            this.txt_id_so.TabIndex = 54;
            this.txt_id_so.TabStop = false;
            this.txt_id_so.Visible = false;
            // 
            // txt_gioi_tinh_1
            // 
            this.txt_gioi_tinh_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_gioi_tinh_1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioi_tinh_1.Location = new System.Drawing.Point(160, 112);
            this.txt_gioi_tinh_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gioi_tinh_1.Name = "txt_gioi_tinh_1";
            this.txt_gioi_tinh_1.Size = new System.Drawing.Size(10, 42);
            this.txt_gioi_tinh_1.TabIndex = 53;
            this.txt_gioi_tinh_1.TabStop = false;
            this.txt_gioi_tinh_1.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(160, 16);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(269, 42);
            this.txt_name.TabIndex = 1;
            // 
            // txt_birthday
            // 
            this.txt_birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_birthday.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday.Location = new System.Drawing.Point(158, 166);
            this.txt_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(271, 42);
            this.txt_birthday.TabIndex = 3;
            this.txt_birthday.Visible = false;
            // 
            // txt_nickname
            // 
            this.txt_nickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(160, 65);
            this.txt_nickname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(269, 42);
            this.txt_nickname.TabIndex = 2;
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(9, 70);
            this.lbl_NickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(141, 34);
            this.lbl_NickName.TabIndex = 39;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(9, 173);
            this.lbl_Birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(135, 34);
            this.lbl_Birthday.TabIndex = 41;
            this.lbl_Birthday.Text = "Năm Sinh";
            this.lbl_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Birthday.Visible = false;
            // 
            // rbm_Nu
            // 
            this.rbm_Nu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbm_Nu.AutoSize = true;
            this.rbm_Nu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Nu.Location = new System.Drawing.Point(325, 116);
            this.rbm_Nu.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Nu.Name = "rbm_Nu";
            this.rbm_Nu.Size = new System.Drawing.Size(74, 38);
            this.rbm_Nu.TabIndex = 49;
            this.rbm_Nu.Text = "Nữ";
            this.rbm_Nu.UseVisualStyleBackColor = true;
            // 
            // lbl_tuoi
            // 
            this.lbl_tuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tuoi.AutoSize = true;
            this.lbl_tuoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tuoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_tuoi.Location = new System.Drawing.Point(483, 20);
            this.lbl_tuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tuoi.Name = "lbl_tuoi";
            this.lbl_tuoi.Size = new System.Drawing.Size(70, 34);
            this.lbl_tuoi.TabIndex = 42;
            this.lbl_tuoi.Text = "Tuổi";
            this.lbl_tuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbm_Nam
            // 
            this.rbm_Nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbm_Nam.AutoSize = true;
            this.rbm_Nam.Checked = true;
            this.rbm_Nam.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Nam.Location = new System.Drawing.Point(190, 116);
            this.rbm_Nam.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Nam.Name = "rbm_Nam";
            this.rbm_Nam.Size = new System.Drawing.Size(94, 38);
            this.rbm_Nam.TabIndex = 48;
            this.rbm_Nam.TabStop = true;
            this.rbm_Nam.Text = "Nam";
            this.rbm_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tuoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuoi.Location = new System.Drawing.Point(554, 15);
            this.txt_tuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.ReadOnly = true;
            this.txt_tuoi.Size = new System.Drawing.Size(269, 42);
            this.txt_tuoi.TabIndex = 43;
            // 
            // txt_han
            // 
            this.txt_han.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_han.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_han.Location = new System.Drawing.Point(554, 116);
            this.txt_han.Margin = new System.Windows.Forms.Padding(4);
            this.txt_han.Name = "txt_han";
            this.txt_han.ReadOnly = true;
            this.txt_han.Size = new System.Drawing.Size(269, 42);
            this.txt_han.TabIndex = 47;
            // 
            // lbl_Sao
            // 
            this.lbl_Sao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sao.AutoSize = true;
            this.lbl_Sao.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Sao.Location = new System.Drawing.Point(483, 70);
            this.lbl_Sao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sao.Name = "lbl_Sao";
            this.lbl_Sao.Size = new System.Drawing.Size(60, 34);
            this.lbl_Sao.TabIndex = 44;
            this.lbl_Sao.Text = "Sao";
            this.lbl_Sao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(9, 20);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(106, 34);
            this.lbl_name.TabIndex = 36;
            this.lbl_name.Text = "Họ Tên";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sex
            // 
            this.lbl_sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(9, 118);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(121, 34);
            this.lbl_sex.TabIndex = 38;
            this.lbl_sex.Text = "Giới tính";
            // 
            // bl_Han
            // 
            this.bl_Han.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bl_Han.AutoSize = true;
            this.bl_Han.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_Han.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bl_Han.Location = new System.Drawing.Point(483, 118);
            this.bl_Han.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bl_Han.Name = "bl_Han";
            this.bl_Han.Size = new System.Drawing.Size(65, 34);
            this.bl_Han.TabIndex = 46;
            this.bl_Han.Text = "Hạn";
            this.bl_Han.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sao
            // 
            this.txt_sao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sao.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sao.Location = new System.Drawing.Point(554, 65);
            this.txt_sao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sao.Name = "txt_sao";
            this.txt_sao.ReadOnly = true;
            this.txt_sao.Size = new System.Drawing.Size(269, 42);
            this.txt_sao.TabIndex = 45;
            // 
            // txt_idchubai
            // 
            this.txt_idchubai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_idchubai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idchubai.Location = new System.Drawing.Point(594, 166);
            this.txt_idchubai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idchubai.Name = "txt_idchubai";
            this.txt_idchubai.Size = new System.Drawing.Size(12, 42);
            this.txt_idchubai.TabIndex = 59;
            this.txt_idchubai.TabStop = false;
            this.txt_idchubai.Visible = false;
            // 
            // txt_GioiTinhThemVaoDb
            // 
            this.txt_GioiTinhThemVaoDb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_GioiTinhThemVaoDb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioiTinhThemVaoDb.Location = new System.Drawing.Point(170, 112);
            this.txt_GioiTinhThemVaoDb.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GioiTinhThemVaoDb.Name = "txt_GioiTinhThemVaoDb";
            this.txt_GioiTinhThemVaoDb.Size = new System.Drawing.Size(12, 42);
            this.txt_GioiTinhThemVaoDb.TabIndex = 63;
            this.txt_GioiTinhThemVaoDb.TabStop = false;
            this.txt_GioiTinhThemVaoDb.Visible = false;
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Form.Controls.Add(this.txt_tuoiii);
            this.pnl_Form.Controls.Add(this.lbl_name);
            this.pnl_Form.Controls.Add(this.txt_idchubai);
            this.pnl_Form.Controls.Add(this.txt_id_so);
            this.pnl_Form.Controls.Add(this.txt_GioiTinhThemVaoDb);
            this.pnl_Form.Controls.Add(this.txt_id);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.txt_sao);
            this.pnl_Form.Controls.Add(this.lbl_Birthday);
            this.pnl_Form.Controls.Add(this.bl_Han);
            this.pnl_Form.Controls.Add(this.txt_nickname);
            this.pnl_Form.Controls.Add(this.lbl_sex);
            this.pnl_Form.Controls.Add(this.rbm_Nu);
            this.pnl_Form.Controls.Add(this.lbl_Sao);
            this.pnl_Form.Controls.Add(this.txt_birthday);
            this.pnl_Form.Controls.Add(this.txt_han);
            this.pnl_Form.Controls.Add(this.lbl_tuoi);
            this.pnl_Form.Controls.Add(this.txt_tuoi);
            this.pnl_Form.Controls.Add(this.txt_name);
            this.pnl_Form.Controls.Add(this.txt_gioi_tinh_1);
            this.pnl_Form.Controls.Add(this.rbm_Nam);
            this.pnl_Form.Location = new System.Drawing.Point(23, 58);
            this.pnl_Form.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(845, 229);
            this.pnl_Form.TabIndex = 65;
            // 
            // txt_tuoiii
            // 
            this.txt_tuoiii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tuoiii.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuoiii.Location = new System.Drawing.Point(644, 166);
            this.txt_tuoiii.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tuoiii.Name = "txt_tuoiii";
            this.txt_tuoiii.Size = new System.Drawing.Size(97, 42);
            this.txt_tuoiii.TabIndex = 64;
<<<<<<< HEAD
            this.txt_tuoiii.Visible = false;
=======
>>>>>>> 6ab327071f3b0ee2ca3ad8e24d69bb99981a2935
            // 
            // lbl_PhieuDiemThongTin
            // 
            this.lbl_PhieuDiemThongTin.AutoSize = true;
            this.lbl_PhieuDiemThongTin.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhieuDiemThongTin.Location = new System.Drawing.Point(31, 12);
            this.lbl_PhieuDiemThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PhieuDiemThongTin.Name = "lbl_PhieuDiemThongTin";
            this.lbl_PhieuDiemThongTin.Size = new System.Drawing.Size(422, 37);
            this.lbl_PhieuDiemThongTin.TabIndex = 102;
            this.lbl_PhieuDiemThongTin.Text = "Thông tin người nhận cầu an";
            this.lbl_PhieuDiemThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_list
            // 
            this.pnl_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_list.Controls.Add(this.lsv_danhsach_cauan);
            this.pnl_list.Location = new System.Drawing.Point(23, 347);
            this.pnl_list.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_list.Name = "pnl_list";
            this.pnl_list.Size = new System.Drawing.Size(1029, 342);
            this.pnl_list.TabIndex = 103;
            // 
            // lbl_danhsach
            // 
            this.lbl_danhsach.AutoSize = true;
            this.lbl_danhsach.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_danhsach.Location = new System.Drawing.Point(33, 303);
            this.lbl_danhsach.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_danhsach.Name = "lbl_danhsach";
            this.lbl_danhsach.Size = new System.Drawing.Size(163, 37);
            this.lbl_danhsach.TabIndex = 104;
            this.lbl_danhsach.Text = "Danh sách";
            this.lbl_danhsach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.FlatAppearance.BorderSize = 0;
            this.btn_xacnhan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xacnhan.ImageKey = "add-icon.png";
            this.btn_xacnhan.ImageList = this.imageList1;
            this.btn_xacnhan.Location = new System.Drawing.Point(884, 121);
            this.btn_xacnhan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_xacnhan.Size = new System.Drawing.Size(180, 49);
            this.btn_xacnhan.TabIndex = 4;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xacnhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xacnhan.UseVisualStyleBackColor = true;
<<<<<<< HEAD
=======
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
>>>>>>> 6ab327071f3b0ee2ca3ad8e24d69bb99981a2935
            // 
            // txt_update
            // 
            this.txt_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_update.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_update.ImageIndex = 1;
            this.txt_update.ImageList = this.imageList1;
            this.txt_update.Location = new System.Drawing.Point(884, 64);
            this.txt_update.Margin = new System.Windows.Forms.Padding(0);
            this.txt_update.Name = "txt_update";
            this.txt_update.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txt_update.Size = new System.Drawing.Size(180, 49);
            this.txt_update.TabIndex = 6;
            this.txt_update.Text = "Cập nhật";
            this.txt_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txt_update.UseVisualStyleBackColor = true;
            this.txt_update.Click += new System.EventHandler(this.txt_update_Click);
            // 
            // FormUpdateNguoiNhanCauAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1074, 709);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.lbl_danhsach);
            this.Controls.Add(this.pnl_list);
            this.Controls.Add(this.lbl_PhieuDiemThongTin);
            this.Controls.Add(this.txt_update);
            this.Controls.Add(this.pnl_Form);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUpdateNguoiNhanCauAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin";
            this.Load += new System.EventHandler(this.FormUpdateNguoiNhanCauAn_Load);
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            this.pnl_list.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsv_danhsach_cauan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        protected System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_id_so;
        private System.Windows.Forms.TextBox txt_gioi_tinh_1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.RadioButton rbm_Nu;
        private System.Windows.Forms.Label lbl_tuoi;
        private System.Windows.Forms.RadioButton rbm_Nam;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.TextBox txt_han;
        private System.Windows.Forms.Label lbl_Sao;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label bl_Han;
        private System.Windows.Forms.TextBox txt_sao;
        private System.Windows.Forms.TextBox txt_idchubai;
        private System.Windows.Forms.Button txt_update;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.TextBox txt_GioiTinhThemVaoDb;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Label lbl_PhieuDiemThongTin;
        private System.Windows.Forms.Panel pnl_list;
        private System.Windows.Forms.Label lbl_danhsach;
        private System.Windows.Forms.TextBox txt_tuoiii;
    }
}