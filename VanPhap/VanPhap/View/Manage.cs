using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;


using VanPhap.View;




namespace VanPhap
{

    public partial class form_manage : Form
    {
        private Form activeForm;
        public form_manage()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Form_SoThongTin_Load(object sender, EventArgs e)
        {
            //List<ChiTietSo> humans = new VanPhapBUS().GetAll();
            //dgv_list.DataSource = humans;
            OpentChildForm(new View.SoCauAn(), sender);
            lbl_Title.Text = "SỚ CẦU AN";
            Btn_Color(btn_SoCauAn, null);
            this.MaximizeBox= true;
            loaiso = "CauAn";
            SoCauAn sca = Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
            sca.loaiso = loaiso;
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }

        //public int CheckGioiTinh(object sender, EventArgs e)
        //{
        //    int Check;
        //    if (rbm_Man.Checked)
        //    {
        //        Check = 1;
        //    }
        //    else if (rbm_Woman.Checked)
        //    {
        //        Check = 2;
        //    }
        //    return 0;
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbm_Man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tabale_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {
         
        }
        
        public void TinhTuoiSaoHan()
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //ChiTietSo newHuman = new ChiTietSo()
            //{
            //    ID = 0,
            //    IDSo = 0,
            //    HoTen_Unicode = txt_name.Text.Trim(),
            //    PhapDanh_Unicode = txt_nickname.Text.Trim(),
            //    NamNu = 0,
            //    IDNamSinh = int.Parse(txt_birthday.Text.Trim()),
            //    Tuoi = txt_birthday.Text.Trim(),
            //    Sao = txt_sao.Text.Trim(),
            //    Han = txt_han.Text.Trim(),

            //};
            //bool result = new VanPhapBUS().AddNew(newHuman);
            //if (result)
            //{
            //    MessageBox.Show("Them thanh cong");


            //}
            //else { MessageBox.Show("Xin Lỗi Bạn!"); }
        }

        private void txt_sao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_birthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_han_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_luutru_RegionChanged(object sender, EventArgs e)
        {

        }

        private void txt_tuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void OpentChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_Component.Controls.Add(childForm);
            this.pnl_Component.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public string loaiso;
        
        private void btn_SoCauAn_Click(object sender, EventArgs e)
        {
            OpentChildForm(new View.SoCauAn(), sender);
            lbl_Title.Text = "SỚ CẦU AN";
            Btn_Color(btn_SoCauAn, null);
            loaiso = "CauAn";
            SoCauAn sca = Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
            sca.loaiso = loaiso;

            
        }

        private void btn_SoCauSieu_Click(object sender, EventArgs e)
        {
            OpentChildForm(new View.SoCauSieu(), sender);
            lbl_Title.Text = "SỚ CẦU SIÊU";
            Btn_Color(btn_SoCauSieu, null);
            SoCauSieu form2 = Application.OpenForms.OfType<SoCauSieu>().FirstOrDefault();
            loaiso = "CauSieu";
            form2.loaiso = loaiso;
         


        }
        public void check()
        {
            if (loaiso.Equals("CauAn"))
            {
                //SoCauAn scs = Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
                
            }
            else
            {
               
            }
        }

        private void btn_account_Click(object sender, EventArgs e)
        {

        }

        private void sơCầuAnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sớCầuAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoCauAn socauan = new SoCauAn();
            socauan.Show();
        }

        private void sớCầuSiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoCauSieu socausieu = new SoCauSieu();
            socausieu.Show();
        }

        private void inSớToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
           

        }

        private void tìmToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Color(object sender, EventArgs e)
        {
            foreach(Control c in pnl_Menu.Controls)
            {
                c.BackColor= Color.FromArgb(219, 215, 210);
            }

            Control click = (Control)sender;
            click.BackColor = Color.FromArgb(197, 193, 188);
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword tk = new ChangePassword();
            tk.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword();
            c.Show();
        }

        private void pnl_title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }
    } 
}
