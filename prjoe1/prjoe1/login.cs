using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjoe1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.Text = "login";
        }

        private void sifre_Enter(object sender, EventArgs e)
        {
            if(sifre.Text=="Şifre")
            {
                sifre.Text = string.Empty;
                sifre.PasswordChar= '*'; 
            }
        }
        char? none = null;
        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "Şifre";
                sifre.PasswordChar = Convert.ToChar(none);
            }
        }

        private void kullaniciadi_Enter(object sender, EventArgs e)
        {
            if (kullaniciadi.Text == "Kullanıcı adı")
            {
                kullaniciadi.Text = string.Empty;

            }
        }

        private void kullaniciadi_Leave(object sender, EventArgs e)
        {
            if (kullaniciadi.Text == "")
            {
                kullaniciadi.Text = "Kullanıcı adı";

            }
        }

        private void uyeol_Click(object sender, EventArgs e)
        {
            uyelik form2 = new uyelik();//açılacak form
            form2.Show(); //form uyelik açılıyor.
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            sifre.PasswordChar = Convert.ToChar(none);
            pb1.Visible = false;
            pb2.Visible = true;
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            sifre.PasswordChar = '*';
            pb1.Visible = true;
            pb2.Visible = false;
        }

        private void uyegiris_Click(object sender, EventArgs e)
        {
            int x = 3;
           if(x==0)
            {
                isveren isveren = new isveren();//açılacak form
                isveren.Show(); //form isveren açılıyor.
            }
           if(x==1)
            {
                isarayan isarayan = new isarayan();//açılacak form
                isarayan.Show(); //form isarayan açılıyor.
            }
           else
            {
                MessageBox.Show("Lütfen tüm bilgilerinizi doğru girdiğinizden emin olun . Üye değilseniz kolayca üye olabilirsiniz");
            }
        }
    }
    
}
