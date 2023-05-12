using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanPhap.View
{
    public partial class FormUpdateChuBai : Form
    {
        public FormUpdateChuBai()
        {
            InitializeComponent();
            MaximizeBox = false;
        }



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

        public string idso { get; set; }
        public string name { get; set; }
        public string diachi { get; set; }
        public string nguyenquan { get; set; }
        public string gioitinh { get; set; }
        public string phapdanh { get; set; }
        private void FormUpdateChuBai_Load(object sender, EventArgs e)
        {
            if (gioitinh == "Nam")
            {
                rbm_Man.Checked = true;
                txt_gioi_tinh.Text = gioitinh;
            }
            else
            {
                rbm_Woman.Checked = true;
                txt_gioi_tinh.Text = gioitinh;
            }

            txt_id1.Text = idso.ToString();
            txt_name.Text = name;
            txt_diachi.Text = diachi;
            txt_nguyenquan.Text = nguyenquan;
            txt_nickname.Text = phapdanh;


        }
        




        private void btn_Add_Click(object sender, EventArgs e)
        {

           



           /* if (rbm_Man.Checked)
            {
                txt_gioi_tinh.Text = "1";
            }
            else
            {
                txt_gioi_tinh.Text = "2";
            }
*/

            // Lấy giá trị khóa chính từ dòng đang chọn

                double id = double.Parse(txt_id1.Text);

                //double namnu = double.Parse(txt_gioi_tinh.Text);
                string hoten = txt_name.Text;
                string phapdanh = txt_nickname.Text;
                string nguyenquan = txt_nguyenquan.Text;
                string diachi = txt_diachi.Text;
            try
             {
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();


                    // Thực hiện câu lệnh DELETE
                    // string query = "DELETE FROM tblchitietso WHERE id = @id AND idso = @idso";
                    // string query = "select ID, IDSo, HoTenUni, PhapDanhUni, NamNu,NamSinh,AmLich,Sao,Han from tblchitietso where idso = @idso";
                    string query = "UPDATE tblphattu SET HoTenUni = ?, PhapDanhUni = ?,DiaChiUni = ? ,NguyenQuanUni = ? WHERE ID = ? ";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("?", hoten);
                        command.Parameters.AddWithValue("?", phapdanh);
                        command.Parameters.AddWithValue("?", diachi);
                        command.Parameters.AddWithValue("?", nguyenquan);
                        command.Parameters.AddWithValue("?", id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công");
                        SoCauAn form1 = Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
                        
                        form1.chubai = hoten;
                        form1.phapdanh = phapdanh;
                        form1.diachi = diachi;
                        form1.nguyenquan = nguyenquan;
                        form1.UpdateData("Cuong");
                        this.Close();
                    }

                }
            }
            catch { MessageBox.Show("Cập nhật thất bại"); }
               
            }//Dong if
        
        private void txt_id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_sex_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

