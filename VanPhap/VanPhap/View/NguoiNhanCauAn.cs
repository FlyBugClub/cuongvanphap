using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanPhap.View
{
    public partial class NguoiNhanCauAn : Form
    {
        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Github\\oppp\\VanPhap\\VanPhap\\VanPhap\\bin\\Debug\\Demo.accdb";
        OleDbConnection sqlCon = null;
        //Hàm mở kết nối db


        private SoCauAn formCauAn;

        public NguoiNhanCauAn(SoCauAn formCauAn)
        {
            InitializeComponent();
            this.formCauAn = formCauAn;
            MaximizeBox = false;
        }

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
        public NguoiNhanCauAn()
        {
            InitializeComponent();
            MaximizeBox = false;
        }


        private void txt_birthday_Leave(object sender, EventArgs e)
        {
            if (txt_birthday.Text == "")
            {
                MessageBox.Show("Năm sinh còn trống, vui lòng nhập năm sinh!");
            
            }
            else
            {
                int current_year = 2023;
                int year = int.Parse(txt_birthday.Text);


                // Xác định can và chi 000
                string[] can = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
                string[] chi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

                int canIndex = (year - 4) % 10;
                int chiIndex = (year - 4) % 12;

                string canChi = can[canIndex] + " " + chi[chiIndex];

                // In kết quả
                txt_tuoi.Text = canChi;



                //Check giới tính
                if (rbm_Nam.Checked)
                {
                    txt_gioi_tinh_1.Text = "Nam";
                }
                else if (rbm_Nu.Checked)
                {
                    txt_gioi_tinh_1.Text = "Nữ";
                }

                // Xác định sao
                string[] saoNam = { "La Hầu", "Thổ Tú", "Thủy Diệu", "Thái Bạch", "Thái Dương", "Vân Hớn", "Kế Đô", "Thái Âm", "Mộc Đức" };
                string[] saoNu = { "Kế Đô", "Vân Hớn", "Mộng Đức", "Thái Âm", "Thổ Tú", "La Hầu", "Thái Dương", "Thái Bạch", "Thủy Diệu" };
                // Xác định hạn
                string[] hanNam = { "Huỳnh Thiền", "Tam Kheo", "Ngũ Mộ", "Thiên Tinh", "Tán Tận", "Thiên La", "Địa Võng", "Diêm Vương" };
                string[] hanNu = { "Tán Tận", "Thiên Tinh", "Ngũ Mộ", "Tam Kheo", "Huỳnh Tiền", "Diêm Vương", "Địa Võng", "Thiên La" };
                string tuoi;
                string han;
                //Tính Sao
                int saoIndex = current_year - year;
                if (txt_gioi_tinh_1.Text.Equals("Nữ"))
                {

                    int tuoiIndex = current_year - year + 1;
                    txt_tuoiii.Text = tuoiIndex.ToString();
                    switch (tuoiIndex)
                    {


                        case 10: tuoi = saoNu[0]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 19: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 28: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 37: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 46: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 55: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 64: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 73: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 82: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;




                        case 11: tuoi = saoNu[1]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 20: tuoi = saoNu[1]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 29: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 38: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 47: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 56: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 65: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 74: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 83: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 12: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 21: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 30: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 39: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 48: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 57: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 66: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 75: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 84: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 13: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 22: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 31: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 40: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 49: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 58: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 67: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 76: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 85: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 14: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 23: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 32: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 41: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 50: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 59: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 68: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 77: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 86: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 15: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 24: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 33: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 42: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 51: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 60: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 69: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 78: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 87: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 16: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 25: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 34: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 43: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 52: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 61: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 70: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 79: tuoi = saoNu[6]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 88: tuoi = saoNu[6]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 17: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 26: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 35: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 44: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 53: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 62: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 71: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 80: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 89: tuoi = saoNu[7]; txt_sao.Text = tuoi; break;


                        case 18: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 27: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 36: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 45: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 54: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 63: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 72: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 81: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 90: tuoi = saoNu[8]; txt_sao.Text = tuoi; break;






                    }
                }
                else
                {
                    int tuoiIndex = current_year - year + 1;

                    switch (tuoiIndex)
                    {
                        case 10: tuoi = saoNu[0]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 19: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 28: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 37: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 46: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 55: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 64: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 73: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 82: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;




                        case 11: tuoi = saoNam[1]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 20: tuoi = saoNam[1]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 29: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 38: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 47: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 56: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 65: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 74: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 83: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 12: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 21: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 30: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 39: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 48: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 57: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 66: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 75: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 84: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 13: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 22: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 31: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 40: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 49: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 58: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 67: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 76: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 85: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 14: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 23: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 32: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 41: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 50: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 59: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 68: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 77: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 86: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 15: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 24: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 33: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 42: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 51: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 60: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 69: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 78: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 87: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 16: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 25: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 34: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 43: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 52: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 61: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 70: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 79: tuoi = saoNam[6]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 88: tuoi = saoNam[6]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 17: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 26: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 35: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 44: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 53: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 62: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 71: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 80: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 89: tuoi = saoNam[7]; txt_sao.Text = tuoi; break;


                        case 18: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 27: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 36: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 45: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 54: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 63: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 72: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 81: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 90: tuoi = saoNam[8]; txt_sao.Text = tuoi; break;

                    }
                }
            }
            
            //End tính sao

            //Tính Hạn


        }
        public string DataFromForm11 { get; set; }
        private void NguoiNhanCauAn_Load(object sender, EventArgs e)
        {
            txt_id_so.Text = DataFromForm11;
        }

        private void txt_birthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gioi_tinh_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string iddd = txt_id_so.Text;
            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");
            }
            else
            { 
                // Kiểm tra coi có id chưa
                string query1 = "select ID from tblchitietso where idso = @Id ";
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    OleDbCommand command = new OleDbCommand(query1, connection);
                    command.Parameters.AddWithValue("@Id", iddd);

                    connection.Open();

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double name = reader.GetDouble(0);
                            // Lấy giá trị của cột column1 (vị trí 0 trong kết quả trả về)
                            
                            if (name == null)
                            {
                                txt_id_kiemtra.Text = "";
                            }
                            else
                            {
                                txt_id_kiemtra.Text = name.ToString();
                            }

                        }
                    }
                }
                //Kiểm tra nếu chưa có
                string kiemtra = txt_id_kiemtra.Text;
                if (kiemtra.Equals(""))
                {

                    using (OleDbConnection connection = new OleDbConnection(strCon))
                    {
                        try
                        {
                            // Mở kết nối
                            connection.Open();
                            // Tạo câu lệnh INSERT
                            string query2 = "INSERT INTO tblChiTietSo ( ID, IDSo, NamNu, NamSinh, AmLich , Sao, Han , HoTenUni,  PhapDanhUni)  VALUES (?,?,?,?,?,?,?,?,?)";

                            //double iddd = double.Parse(txt_id.Text);
                            if (txt_gioi_tinh_1.Text.Equals("Nam"))
                            {
                                txt_gioi_tinh_1.Text = "1";
                            }
                            else
                            {
                                txt_gioi_tinh_1.Text = "2";
                            }
                            double namnu = double.Parse(txt_gioi_tinh_1.Text);
                            double namsinh = double.Parse(txt_birthday.Text);
                            string amlich = txt_tuoi.Text;
                            string sao = txt_sao.Text;
                            string han = txt_han.Text;
                            string hoten = txt_name.Text;
                            string phapdanh = txt_nickname.Text;
                            // Tạo đối tượng Command và liên kết với Connection
                            using (OleDbCommand command = new OleDbCommand(query2, connection))
                            {
                                // Gán giá trị cho các tham số trong câu lệnh INSERT
                                command.Parameters.AddWithValue("?", 0);
                                command.Parameters.AddWithValue("?", iddd);
                                command.Parameters.AddWithValue("?", namnu);
                                command.Parameters.AddWithValue("?", namsinh);
                                command.Parameters.AddWithValue("?", amlich);
                                command.Parameters.AddWithValue("?", sao);
                                command.Parameters.AddWithValue("?", han);
                                command.Parameters.AddWithValue("?", hoten);
                                command.Parameters.AddWithValue("?", phapdanh);
                                // Thực thi câu lệnh INSERT
                                int rowsAffected = command.ExecuteNonQuery();
                                // Kiểm tra số dòng bị ảnh hưởng
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Dữ liệu đã được thêm thành công vào cơ sở dữ liệu.");
                                    SoCauAn form1 = Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
                                    form1.UpdateData("Cuong");
                                    this.Close();
                                    // Sử dụng listView để thao tác với ListView
                                }
                                else
                                {
                                    MessageBox.Show("Không thể thêm dữ liệu vào cơ sở dữ liệu.");
                                }
                            }
                        }
                        catch (OleDbException ex)
                        {
                            MessageBox.Show("Lỗi khi thêm dữ liệu vào cơ sở dữ liệu: " + ex.Message);
                        }
                    }
                }
                /// nếu có rồi
                else
                {
                    string query3 = "select MAX(ID) from tblchitietso where idso = @Id ";
                    using (OleDbConnection connection = new OleDbConnection(strCon))
                    {
                        OleDbCommand command = new OleDbCommand(query3, connection);
                        command.Parameters.AddWithValue("@Id", iddd);

                        connection.Open();

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double name = reader.GetDouble(0);
                                txt_id.Text = name.ToString();
                            }
                        }
                    }
                    

                    //double iddd = double.Parse(txt_id.Text);
                    if (txt_gioi_tinh_1.Text.Equals("Nam"))
                    {
                        txt_gioi_tinh_1.Text = "1";
                    }
                    else
                    {
                        txt_gioi_tinh_1.Text = "2";
                    }
                    string idso = txt_id_so.Text;
                    double id = double.Parse(txt_id.Text)+1;
                    double namnu = double.Parse(txt_gioi_tinh_1.Text);
                    double namsinh = double.Parse(txt_birthday.Text);
                    string amlich = txt_tuoi.Text;
                    string sao = txt_sao.Text;
                    string han = txt_han.Text;
                    string hoten = txt_name.Text;
                    string phapdanh = txt_nickname.Text;
                    // Tạo đối tượng Command và liên kết với Connection
                    string query4 = "INSERT INTO tblChiTietSo (ID,IDSo, NamNu,NamSinh, AmLich , Sao, Han , HoTenUni,  PhapDanhUni)   VALUES (?,?,?,?,?,?,?,?,?) ";
                    using (OleDbConnection connection = new OleDbConnection(strCon))
                    {
                        using (OleDbCommand command = new OleDbCommand(query4, connection))
                        {

                            connection.Open();
                            // Gán giá trị cho các tham số trong câu lệnh INSERT

                            command.Parameters.AddWithValue("?", id);
                            command.Parameters.AddWithValue("?", idso);
                            command.Parameters.AddWithValue("?", namnu);
                            command.Parameters.AddWithValue("?", namsinh);
                            command.Parameters.AddWithValue("?", amlich);
                            command.Parameters.AddWithValue("?", sao);
                            command.Parameters.AddWithValue("?", han);
                            command.Parameters.AddWithValue("?", hoten);
                            command.Parameters.AddWithValue("?", phapdanh);
                            
                            // Thực thi câu lệnh INSERT
                            int rowsAffected = command.ExecuteNonQuery();
                            // Kiểm tra số dòng bị ảnh hưởng
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được thêm thành công vào cơ sở dữ liệu.");
                                SoCauAn form1 = Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
                                form1.UpdateData("Cuong");
                                this.Close();
                                // Sử dụng listView để thao tác với ListView
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm dữ liệu vào cơ sở dữ liệu.");
                            }
                        }
                    }           
                }
            }
        }
    

        /////////////////////////
        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txt_id_so.Text;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {

            {
                int current_year = 2023;
                int year = int.Parse(txt_birthday.Text);


                // Xác định can và chi 000
                string[] can = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
                string[] chi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

                int canIndex = (year - 4) % 10;
                int chiIndex = (year - 4) % 12;

                string canChi = can[canIndex] + " " + chi[chiIndex];

                // In kết quả
                txt_tuoi.Text = canChi;



                //Check giới tính
                if (rbm_Nam.Checked)
                {
                    txt_gioi_tinh_1.Text = "Nam";
                }
                else if (rbm_Nu.Checked)
                {
                    txt_gioi_tinh_1.Text = "Nữ";
                }

                // Xác định sao
                string[] saoNam = { "La Hầu", "Thổ Tú", "Thủy Diệu", "Thái Bạch", "Thái Dương", "Vân Hớn", "Kế Đô", "Thái Âm", "Mộc Đức" };
                string[] saoNu = { "Kế Đô", "Vân Hớn", "Mộng Đức", "Thái Âm", "Thổ Tú", "La Hầu", "Thái Dương", "Thái Bạch", "Thủy Diệu" };
                // Xác định hạn
                string[] hanNam = { "Huỳnh Thiền", "Tam Kheo", "Ngũ Mộ", "Thiên Tinh", "Tán Tận", "Thiên La", "Địa Võng", "Diêm Vương" };
                string[] hanNu = { "Tán Tận", "Thiên Tinh", "Ngũ Mộ", "Tam Kheo", "Huỳnh Tiền", "Diêm Vương", "Địa Võng", "Thiên La" };
                string tuoi;
                string han;
                //Tính Sao
                int saoIndex = current_year - year;
                if (txt_gioi_tinh_1.Text.Equals("Nữ"))
                {

                    int tuoiIndex = current_year - year + 1;
                    txt_tuoiii.Text = tuoiIndex.ToString();
                    switch (tuoiIndex)
                    {


                        case 10: tuoi = saoNu[0]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 19: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 28: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 37: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 46: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 55: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 64: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 73: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 82: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;




                        case 11: tuoi = saoNu[1]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 20: tuoi = saoNu[1]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 29: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 38: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 47: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 56: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 65: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 74: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 83: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 12: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 21: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 30: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 39: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 48: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 57: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 66: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 75: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 84: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 13: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 22: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 31: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 40: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 49: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 58: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 67: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 76: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 85: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 14: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 23: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 32: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 41: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 50: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 59: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 68: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 77: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 86: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 15: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 24: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 33: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 42: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 51: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 60: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 69: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 78: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 87: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 16: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 25: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 34: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 43: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 52: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 61: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 70: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 79: tuoi = saoNu[6]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 88: tuoi = saoNu[6]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 17: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 26: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 35: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 44: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 53: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 62: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 71: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 80: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 89: tuoi = saoNu[7]; txt_sao.Text = tuoi; break;


                        case 18: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 27: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 36: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 45: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 54: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 63: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 72: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 81: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 90: tuoi = saoNu[8]; txt_sao.Text = tuoi; break;






                    }
                }
                else
                {
                    int tuoiIndex = current_year - year + 1;

                    switch (tuoiIndex)
                    {
                        case 10: tuoi = saoNu[0]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 19: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 28: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 37: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 46: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 55: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 64: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 73: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 82: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;




                        case 11: tuoi = saoNam[1]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 20: tuoi = saoNam[1]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 29: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 38: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 47: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 56: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 65: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 74: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 83: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 12: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 21: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 30: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 39: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 48: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 57: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 66: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 75: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 84: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 13: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 22: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 31: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 40: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 49: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 58: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 67: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 76: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 85: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 14: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 23: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 32: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 41: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 50: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 59: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 68: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 77: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 86: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 15: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 24: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 33: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 42: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 51: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 60: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 69: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 78: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 87: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 16: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 25: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 34: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 43: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 52: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 61: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 70: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 79: tuoi = saoNam[6]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 88: tuoi = saoNam[6]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                        case 17: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 26: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 35: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 44: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 53: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 62: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 71: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 80: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 89: tuoi = saoNam[7]; txt_sao.Text = tuoi; break;


                        case 18: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 27: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 36: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 45: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 54: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 63: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 72: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 81: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                        case 90: tuoi = saoNam[8]; txt_sao.Text = tuoi; break;

                    }
                }
                //End tính sao

                //Tính Hạn


            }
        }

        private void txt_id_kiemtra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
