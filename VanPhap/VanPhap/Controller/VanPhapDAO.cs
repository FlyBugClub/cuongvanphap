using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VanPhap.Controller;
using VanPhap.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace VanPhap
{
    internal class VanPhapDAO
    {
        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Git\\V-n-Ph-p\\VanPhap\\VanPhap\\bin\\Debug\\Demo.mdb";
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
        public void HienDanhSachVatTu()
        {
            OpenConection();


            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tblChiTietSo";
            sqlCmd.Connection = sqlCon;

            OleDbDataReader reader = sqlCmd.ExecuteReader();

            List<ChiTietSo> humans = new List<ChiTietSo>();

            while (reader.Read())
            {

                string idSo = reader.GetString(1);
                string hoten = reader.GetString(10);
                string phapdanh = reader.GetString(11);
                int gioitinh = reader.GetInt32(4);
                int namsinh = reader.GetInt32(6);
                string tuoiam = reader.GetString(7);
                string sao = reader.GetString(8);
                string han = reader.GetString(9);




                ListViewItem lvi = new ListViewItem(idSo);
                lvi.SubItems.Add(hoten);
                lvi.SubItems.Add(phapdanh);
                lvi.SubItems.Add(gioitinh.ToString());
                lvi.SubItems.Add(namsinh.ToString());
                lvi.SubItems.Add(tuoiam);
                lvi.SubItems.Add(sao);
                lvi.SubItems.Add(han);

            }


            /*public List<PhatTu> SelectAllPhatTu()
            {
                List<PhatTu> humans = db.PhatTus.ToList();
                return humans;
            }
            public ChiTietSo SelectByID(int ID)
            {
                ChiTietSo human = db.ChiTietSos.SingleOrDefault(b => b.ID == ID);
                return human;
            }



            public List<ChiTietSo> SelectByKeyword(String keyword)
            {
                List<ChiTietSo> humans = db.ChiTietSos.Where(b => b.HoTen.Contains(keyword)).ToList();
                return humans;
            }
            public bool Insert(ChiTietSo newHuman)

            {
                try
                {
                    db.ChiTietSos.InsertOnSubmit(newHuman);
                    db.SubmitChanges();
                    return true;
                }
                catch 
                {
                    return false;
                }
            }
            public bool Update(ChiTietSo newHuman)
            {

                ChiTietSo dbHuman = db.ChiTietSos.SingleOrDefault(b => b.ID == newHuman.ID);

                if (dbHuman != null)
                {
                    try
                    {
                        dbHuman.HoTen = newHuman.HoTen;

                        db.SubmitChanges();
                        return true;
                    }
                    catch { return false; }
                }
                return false;
            }
            public bool Delete(int humanID)
            {
                ChiTietSo dbHuman = db.ChiTietSos.SingleOrDefault(b => b.ID== humanID);
                if (dbHuman != null)
                {
                    try
                    {
                        db.ChiTietSos.DeleteOnSubmit(dbHuman);
                        db.SubmitChanges();
                        return true;

                    }
                    catch { return false; }
                }
                return false;
            }*/

        }

    }
}

