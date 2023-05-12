using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VanPhap.View
{
    public partial class TimChuBai : Form
    {
        private Form activeForm;

        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Github\\oppp\\VanPhap\\VanPhap\\VanPhap\\bin\\Debug\\Demo.accdb";
        OleDbConnection sqlCon = null;
        //Hàm mở kết nối db
        public void OpenConection()
        {
            if (sqlCon == null)
            {
                sqlCon = new OleDbConnection(strCon);
            }
            if (sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }

        }
        public void CloseConection()
        {
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
            {
                sqlCon.Close();
            }
        }
        public TimChuBai()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals("1"))
            {
                MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn một chủ bái bên dưới để xóa!");

            }
            else
            {

                DialogResult result = MessageBox.Show("Xóa hết dữ liệu chủ bái?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (lsv_timchubai.SelectedItems.Count > 0)
                    {
                        // Lấy giá trị khóa chính từ dòng đang chọn

                        string id = lsv_timchubai.SelectedItems[0].SubItems[0].Text; // Giả sử khóa chính ở cột đầu tiên


                        using (OleDbConnection connection = new OleDbConnection(strCon))
                        {
                            connection.Open();

                            string query1 = "DELETE FROM tblchitietso where idso = @id";
                            using (OleDbCommand command = new OleDbCommand(query1, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);

                                command.ExecuteNonQuery();
                            }

                            string query = "DELETE FROM tblso WHERE id = @id ";

                            using (OleDbCommand command = new OleDbCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);

                                command.ExecuteNonQuery();
                            }



                            // Thực hiện câu lệnh DELETE
                            string query2 = "DELETE FROM tblphattu WHERE id = @id ";

                            using (OleDbCommand command = new OleDbCommand(query2, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);

                                command.ExecuteNonQuery();
                            }
                            if (lsv_timchubai.SelectedItems.Count > 0)
                            {
                                // Xóa thành công
                                MessageBox.Show("Xóa thành công");
                                HienDanhSach();

                            }
                            else
                            {
                                // Không có dòng nào được xóa
                                MessageBox.Show("Không có dòng nào được xóa");
                            }
                            
                        }
                    }//Dong if
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một người bên dưới để xóa!");

                    }
                }
                else if (result == DialogResult.No)
                {
                    
                }

                


            }
        }

        private void btn_huy_bo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string loaiso { get; set; }
        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {

            if (txt_name.Text.Equals("") && txt_diachi.Text.Equals("") && txt_nguyenquan.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng tìm kiếm theo các cách sau\nNhập tên chủ bái || Nhập địa chỉ cần tìm || Nhập nguyên quán");
            }
            else
            {
                lsv_timchubai.Items.Clear();
                string name = txt_name.Text;
                string diachi1 = txt_diachi.Text;
                string nguyenquan1 = txt_nguyenquan.Text;
                string phapdanh1 = txt_nickname.Text;

                OpenConection();

                OleDbCommand sqlCmd = new OleDbCommand();
                sqlCmd.CommandType = System.Data.CommandType.Text;

                //sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%"+name+"%'";
                sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%" + name + "%'  AND DiaChiUni LIKE '%" + diachi1 + "%' AND NguyenQuanUni LIKE '%" + nguyenquan1 + "%' AND PhapDanhUni LIKE '%" + phapdanh1 + "%'  ORDER BY ID DESC ";
                sqlCmd.Connection = sqlCon;

                OleDbDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {

                    double idSo = reader.GetDouble(0);
                    string hoten = reader.GetString(1);
                    string phapdanh = reader.GetString(2);
                    string diachi = reader.GetString(3);
                    string nguyenquan = reader.GetString(4);

                    txt_id_chu_bai.Text = idSo.ToString();
                    ListViewItem lvi = new ListViewItem(idSo.ToString());
                    lvi.SubItems.Add(hoten);
                    lvi.SubItems.Add(phapdanh);
                    lvi.SubItems.Add(diachi);
                    lvi.SubItems.Add(nguyenquan);

                    lsv_timchubai.Items.Add(lvi);
                }
            }
        }
        private void TimChuBai_Load(object sender, EventArgs e)
        {
        }
        public async void HienDanhSach()
        {

            {

                if (txt_name.Text.Equals("") && txt_diachi.Text.Equals("") && txt_nguyenquan.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng tìm kiếm theo các cách sau\nNhập tên chủ bái || Nhập địa chỉ cần tìm || Nhập nguyên quán");
                }
                else
                {
                    lsv_timchubai.Items.Clear();
                    string name = txt_name.Text;
                    string diachi1 = txt_diachi.Text;
                    string nguyenquan1 = txt_nguyenquan.Text;
                    string phapdanh1 = txt_nickname.Text;

                    OpenConection();

                    OleDbCommand sqlCmd = new OleDbCommand();
                    sqlCmd.CommandType = System.Data.CommandType.Text;

                    //sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%"+name+"%'";
                    sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%" + name + "%'  AND DiaChiUni LIKE '%" + diachi1 + "%' AND NguyenQuanUni LIKE '%" + nguyenquan1 + "%' AND PhapDanhUni LIKE '%" + phapdanh1 + "%'  ORDER BY ID DESC";
                    sqlCmd.Connection = sqlCon;

                    OleDbDataReader reader = sqlCmd.ExecuteReader();

                    while (reader.Read())
                    {

                        double idSo = reader.GetDouble(0);
                        string hoten = reader.GetString(1);
                        string phapdanh = reader.GetString(2);
                        string diachi = reader.GetString(3);
                        string nguyenquan = reader.GetString(4);

                        txt_id_chu_bai.Text = idSo.ToString();
                        ListViewItem lvi = new ListViewItem(idSo.ToString());
                        lvi.SubItems.Add(hoten);
                        lvi.SubItems.Add(phapdanh);
                        lvi.SubItems.Add(diachi);
                        lvi.SubItems.Add(nguyenquan);

                        lsv_timchubai.Items.Add(lvi);
                    }
                }
            }

        }

        //private void OpentChildForm(Form childForm, object btnSender)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //    }
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

        private void lsv_timchubai_ItemActivate(object sender, EventArgs e)
        {
            if (lsv_timchubai.SelectedItems.Count > 0)
            {
                // Lấy item được kích hoạt (được nhấp vào)
                ListViewItem activatedItem = lsv_timchubai.SelectedItems[0];

                //Hiển thị thông tin từ item vào TextBox
                string id = activatedItem.SubItems[0].Text;
                string chubai = activatedItem.SubItems[1].Text;
                string phapdanh = activatedItem.SubItems[2].Text;
                string diachi = activatedItem.SubItems[3].Text;
                string nguyenquan = activatedItem.SubItems[4].Text;

                /*SoCauAn form2 = new SoCauAn();
                form2.id = id;
                form2.chubai = chubai;
                form2.phapdanh = phapdanh;
                form2.diachi = diachi;
                form2.nguyenquan = nguyenquan;*/
                //OpentChildForm(new View.SoCauAn(), null);
                if (loaiso.Equals("CauAn"))
                {
                    SoCauAn form1 = Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
                    if (form1 != null)
                    {
                        form1.id = id;
                        form1.chubai = chubai;
                        form1.phapdanh = phapdanh;
                        form1.diachi = diachi;
                        form1.nguyenquan = nguyenquan;
                        form1.UpdateData("Cuong");
                        this.Close();
                    }
                }
                else
                {
                    SoCauSieu form2 = Application.OpenForms.OfType<SoCauSieu>().FirstOrDefault();
                    if (form2 != null)
                    {
                        form2.id = id;
                        form2.chubai = chubai;
                        form2.phapdanh = phapdanh;
                        form2.diachi = diachi;
                        form2.nguyenquan = nguyenquan;
                        form2.UpdateData("Cuong");
                        this.Close();
                    }
                }
                



                // Hiển thị Form 2
                /*form2.Show();*/
            }
        }

        private void lbl_Birthday_Click(object sender, EventArgs e)
        {

        }

        private void lsv_timchubai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_xem_Click(object sender, EventArgs e)
        {

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");
            }
            else
            {
                lsv_timchubai.Items.Clear();
                HienDanhSach();
            }
        }
    }
}