using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanPhap.View
{
    public partial class SoCauSieu : Form
    {
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
        public SoCauSieu()
        {
            InitializeComponent();
        }

        private async void SoCauSieu_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            cuon();
            HienDanhSach();
            

        }
        public void UpdateData(string data)
        {
            lsv_danhsach_causieu.Items.Clear();
            HienDanhSach();
        }
        public async Task cuon()
        {
            await Task.Delay(100);
            string cuong = loaiso;
            txt_loaiso.Text = cuong;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");

            }
            else
            {
                //Hiển thị thông tin từ item vào TextBox
                string id = txt_idchubai.Text;


                NguoiNhanCauSieu nncs = new NguoiNhanCauSieu();

                nncs.DataFromForm1 = id;
                nncs.Show();
                nncs.Show();


            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");
            }
            else
            {
                FormUpdateNguoiNhanCauSieu nncs = new FormUpdateNguoiNhanCauSieu();

                nncs.idso = txt_idchubai.Text;
                nncs.Show();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");
            }
            else
            {
                FormUpdateChuBai frm = new FormUpdateChuBai();

                frm.idso = txt_idchubai.Text;
                frm.name = txt_name.Text;
                frm.diachi = txt_diachi.Text;
                frm.nguyenquan = txt_nguyenquan.Text;
                frm.gioitinh = txt_gioi_tinh.Text;
                frm.Show();
            }
        }
        public string id { get; set; }
        public string loaiso { get; set; }
        public string chubai { get; set; }
        public string phapdanh { get; set; }
        public string diachi { get; set; }
        public string nguyenquan { get; set; }

        public string status { get; set; }

        public void HienDanhSach()
        {
            
            lsv_danhsach_causieu.Items.Clear();

            txt_idchubai.Text = id;
            txt_name.Text = chubai;
            txt_nickname.Text = phapdanh;
            txt_diachi.Text = diachi;
            txt_nguyenquan.Text = nguyenquan;

            string idso = txt_idchubai.Text;
            string query = "select ID, IDSo, HoTenUni, PhapDanhUni, NamNu,NamSinh,NamMat,AmLich,Sao,Han from tblchitietso where idso = @idso AND NamMat <> 0";
            //sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%"+name+"%'";


            using (OleDbConnection connection = new OleDbConnection(strCon))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@idso", idso); // Truyền giá trị vào tham số @param
                connection.Open();

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        /*string hoten = reader.GetString(0);
                        string phapdanh1 = reader.GetString(1);
                        double gioitinh = reader.GetDouble(2);
                        double namsinh = reader.GetDouble(3);
                        string amlich = reader.GetString(4);
                        string sao = reader.GetString(5);
                        string han = reader.GetString(6);*/
                        

                        ListViewItem lvi = new ListViewItem();

                        lvi.SubItems.Add(reader["HoTenUni"].ToString());
                        lvi.SubItems.Add(reader["PhapDanhUni"].ToString());
                        lvi.SubItems.Add(reader["NamNu"].ToString());
                        
                        lvi.SubItems.Add(reader["NamSinh"].ToString());
                        lvi.SubItems.Add(reader["NamMat"].ToString());
                        lvi.SubItems.Add(reader["AmLich"].ToString());
                        lvi.SubItems.Add(reader["Sao"].ToString());
                        lvi.SubItems.Add(reader["Han"].ToString());
                        lvi.SubItems.Add(reader["ID"].ToString());
                        lvi.SubItems.Add(reader["IDSo"].ToString());


                        lsv_danhsach_causieu.Items.Add(lvi);
                    }


                }
            }
        }
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");
            }
            else
            {
                lsv_danhsach_causieu.Items.Clear();
                HienDanhSach();
            }
        }

        private void rdbtn_chua_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtn_chua_Click(object sender, EventArgs e)
        {
            ChuBai cb = new ChuBai();
            cb.Show();
        }

        private void rdbtn_coso_Click(object sender, EventArgs e)
        {
            TimChuBai tcb = new TimChuBai();
            tcb.loaiso = loaiso;
            tcb.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");

            }
            else
            {

                if (lsv_danhsach_causieu.SelectedItems.Count > 0)
                {
                    // Lấy giá trị khóa chính từ dòng đang chọn

                    string id = lsv_danhsach_causieu.SelectedItems[0].SubItems[9].Text; // Giả sử khóa chính ở cột đầu tiên
                    string idso = lsv_danhsach_causieu.SelectedItems[0].SubItems[10].Text;

                    using (OleDbConnection connection = new OleDbConnection(strCon))
                    {
                        connection.Open();


                        // Thực hiện câu lệnh DELETE
                        string query = "DELETE FROM tblchitietso WHERE id = @id AND idso = @idso";

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@idso", idso);
                            command.ExecuteNonQuery();
                        }
                        if (lsv_danhsach_causieu.SelectedItems.Count > 0)
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
        }

        /*  private void btn_print_Click(object sender, EventArgs e)
          {

              {
                  List<string> user = new List<string>();
                  List<List<string>> ls = new List<List<string>>();
                  int count = 0;

                  *//*  lsv_danhsach_cauan.SelectedIndexChanged += lsv_danhsach_cauan_SelectedIndexChanged;
                    if (lsv_danhsach_cauan.SelectedItems.Count > 0)
                    {
                        // Xử lý lựa chọn dòng được chọn
                        ListViewItem selectedItem = lsv_danhsach_cauan.SelectedItems[0];
                        string name = selectedItem.SubItems[1].Text; // Lấy giá trị của cột
                        txt_id.Text = name;
                    }*//*
                  foreach (ListViewItem item in lsv_danhsach_causieu.Items)
                  {
                      if (item.Checked)
                      {
                          ls.Add(new List<string>());
                      }

                  }
                  foreach (ListViewItem item in lsv_danhsach_causieu.Items)
                  {
                      if (item.Checked)
                      {
                          ls[count].Add(item.SubItems[1].Text);
                          ls[count].Add(item.SubItems[2].Text);
                          ls[count].Add(item.SubItems[3].Text);
                          ls[count].Add(item.SubItems[4].Text);
                          ls[count].Add(item.SubItems[5].Text);
                          ls[count].Add(item.SubItems[6].Text);
                          ls[count].Add(item.SubItems[7].Text);
                          ls[count].Add(item.SubItems[8].Text);

                          count++;
                      }
                  }
                  try
                  {
                      string filePath = "D:/file.docx";
                      using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                      {
                          // Add a main document part
                          MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                          // Create a new document tree

                          mainPart.Document = new Document();
                          // Create a body for the document

                          DocumentFormat.OpenXml.Wordprocessing.Body body = new DocumentFormat.OpenXml.Wordprocessing.Body();

                          // Add a paragraph to the body
                          Paragraph paragraph = new Paragraph();
                          Run run = new Run();

                          foreach (List<string> sublist in ls)
                          {
                              foreach (string subitem in sublist)
                              {
                                  run.Append(new Text(subitem + "\n"));
                              }
                              run.Append(new Break());
                          }
                          paragraph.Append(run);
                          body.Append(paragraph);

                          // Add the body to the document
                          mainPart.Document.Append(body);

                      }
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.ToString());

                  }


              }
          }*/
        public class ChuBai1
        {
            public String Chubai { get; set; }
            public String Phapdanh { get; set; }
            public String NguyenQuan { get; set; }
            public String DiaChi { get; set; }
        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            List<string> user = new List<string>();
            List<List<string>> ls = new List<List<string>>();
            int count = 0;


            ChuBai1 chu = new ChuBai1();
            {
                chu.Chubai = txt_name.Text;
                chu.Phapdanh = txt_nickname.Text;
                chu.DiaChi = txt_diachi.Text;
                chu.NguyenQuan = txt_nguyenquan.Text;
            }



            /*  lsv_danhsach_cauan.SelectedIndexChanged += lsv_danhsach_cauan_SelectedIndexChanged;
              if (lsv_danhsach_cauan.SelectedItems.Count > 0)
              {
                  // Xử lý lựa chọn dòng được chọn
                  ListViewItem selectedItem = lsv_danhsach_cauan.SelectedItems[0];
                  string name = selectedItem.SubItems[1].Text; // Lấy giá trị của cột
                  txt_id.Text = name;
              }*/

            foreach (ListViewItem item in lsv_danhsach_causieu.Items)
            {
                if (item.Checked)
                {
                    ls.Add(new List<string>());
                }

            }
            foreach (ListViewItem item in lsv_danhsach_causieu.Items)
            {

                if (item.Checked)
                {
                    string kiemTra = item.SubItems[3].Text;//gioi tinh
                    if (kiemTra.Equals("1"))
                    {
                        ls[count].Add("X");
                        ls[count].Add("");
                        ls[count].Add(item.SubItems[1].Text); //name
                        ls[count].Add(item.SubItems[2].Text); // phapdanh
                        ls[count].Add(item.SubItems[4].Text);//nam sinh
                        ls[count].Add(item.SubItems[5].Text);//tuoi
                        ls[count].Add(item.SubItems[6].Text);//sao
                        ls[count].Add(item.SubItems[7].Text);//han
                    }
                    else
                    {
                        ls[count].Add("");
                        ls[count].Add("X");
                        ls[count].Add(item.SubItems[1].Text); //name
                        ls[count].Add(item.SubItems[2].Text); // phapdanh
                        ls[count].Add(item.SubItems[4].Text);//nam sinh
                        ls[count].Add(item.SubItems[5].Text);//tuoi
                        ls[count].Add(item.SubItems[6].Text);//sao
                        ls[count].Add(item.SubItems[7].Text);//han
                    }



                    count++;
                }
            }

            try
            {
                // tạo tệp mới
                string path = @"C:\Git\test.html";
                File.Create(path).Close();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("<html><head><title>So cau an</title></head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"1000\">");
                    sw.WriteLine("<tbody><tr>");
                    sw.WriteLine("<td width=\"998\" colspan=\"3\" height=\"60\">");
                    sw.WriteLine("<p align=\"center\"><b><font size=\"5\" face=\"VNI-Cooper\">DAÂNG LEÃ CAÀU AN</font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("<p style=\"line-height: 150%; margin-bottom: 0\"><b><font size=\"3\" face=\"vni-times\"><i>Chuû baùi&nbsp;</i></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\">");
                    sw.WriteLine("<p style=\"line-height: 100%; margin-bottom: 0\"><b>: " + chu.Chubai + "");
                    sw.WriteLine("<font face=\"VNI-Times\" size=\"2\"><span style=\"text-transform: uppercase\">");
                    sw.WriteLine("</span></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("<p style=\"line-height: 150%; margin-bottom: 0\"><b><font size=\"3\" face=\"vni-times\"><i>Phaùp danh&nbsp;</i></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\"><p style=\"line-height: 100%; margin-bottom: 0\"><b>: " + chu.Phapdanh + "");
                    sw.WriteLine("</b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("<p style=\"line-height: 150%; margin-bottom: 0\"><b><font size=\"3\" face=\"vni-times\"><i>Nguyeân quaùn</i></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\">");
                    sw.WriteLine("<p style=\"line-height: 100%; margin-bottom: 0\"><b>: " + chu.NguyenQuan + "");
                    sw.WriteLine("</b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("<p style=\"line-height: 150%; margin-bottom: 0\"><b><font size=\"3\" face=\"vni-times\"><i>Ñòa chæ</i></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\">");
                    sw.WriteLine("<p style=\"line - height: 100 %; margin - bottom: 0\"><b>: " + chu.DiaChi + "");
                    sw.WriteLine("</b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"><b><font size=\"3\" face=\"vni-times\"><i>&nbsp;</i></font></b></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\">");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr></tbody></table>");
                    sw.WriteLine("<table border=\".1\" width=\"1000\" cellspacing=\"0\" bordercolor=\"#808080\" bordercolorlight=\"#808080\" bordercolordark=\"#FFFFFF\" cellpadding=\"0\" height=\"62\">");
                    sw.WriteLine("<tbody><tr>");
                    sw.WriteLine("<td width=\"60\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">NAM</font></b></td>");
                    sw.WriteLine("<td width=\"60\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">NÖÕ</font></b></td>");
                    sw.WriteLine("<td width=\"350\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">HOÏ VAØ TEÂN</font></b></td>");
                    sw.WriteLine("<td width=\"150\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">PHAÙP DANH</font></b></td>");
                    sw.WriteLine("<td width=\"150\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">NAÊM SINH</font></b></td>");
                    sw.WriteLine("<td width=\"100\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">TUOÅI</font></b></td>");
                    sw.WriteLine("<td width=\"130\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">SAO</font></b></td>");
                    sw.WriteLine("<td width=\"130\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">HẠN</font></b></td>");
                    sw.WriteLine("</tr>");
                    //Dữ liệu thêm vào
                    foreach (List<string> sublist in ls)
                    {
                        sw.WriteLine("<tr>");
                        foreach (string subitem in sublist)
                        {

                            sw.WriteLine("<td width=\"130\" align=\"center\" height=\"39\"><b>" + subitem + "</b></td>"); //name //nam//nu


                        }
                        sw.WriteLine("</tr>");


                    }



                    sw.WriteLine("</body></html>");



                }
                Process.Start("C:\\Git\\test.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }

    }
}
