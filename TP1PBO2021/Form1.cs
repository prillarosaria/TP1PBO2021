using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void tbUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            User user = new User();
            user.username = Convert.ToString(tbUname.Text);
            user.password = Convert.ToString(tbPassword.Text);
            user.status = false;

            if(user.password == "pbo123")
            {
                user.status = true;
                form2.Show();
                this.Hide();
            }
            else
            {
                string title = "WARNING";
                string pesan = "Maaf, password yang Anda masukkan salah. Silakan periksa kembali password Anda.";
                MessageBox.Show(pesan, title);
                tbUname.Clear();
                tbPassword.Clear();
            }
        }
    }
}
