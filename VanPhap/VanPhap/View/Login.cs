using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace VanPhap
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void lbl_Account_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Account acc = new Account();
            String title = "Lưu ý";

            try
            {
                String account = txt_Account.Text.ToString();
                String password = txt_Password.Text.ToString();

                if (account.Equals("ABC") & password.Equals("123"))
                {
                    form_manage Mform = new form_manage();
                    Mform.Show();
                }
                else if (account.Equals("") || password.Equals(""))
                {
                    String messege = "Vui lòng nhập tài khoản và mật khẩu";
                    MessageBox.Show(messege, title);
                }
                else
                {
                    String messege = "Mật khẩu và tài khoản không đúng. Xin vui lòng nhập lại";
                    MessageBox.Show(messege, title);
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            //this.Hide();
        }

        private void pressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(this, new EventArgs());
                form_manage Mform = new form_manage();
                Mform.Show();
                Mform.BringToFront();
            }
        }

        private void txt_Account_TextChanged(object sender, EventArgs e)
        { 

        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_Login_Click(sender, e);
            }
        }

        private void txt_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                txt_Password.Focus();
            }
        }
    }
}
