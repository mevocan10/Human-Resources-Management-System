using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjoe1
{
    public partial class uyelik : Form
    {
        public uyelik()
        {
            InitializeComponent();
        }

        private void isim_Enter(object sender, EventArgs e)
        {
            if (isim.Text == "isim")
            {
                isim.Text = string.Empty;

            }
        }

        private void isim_Leave(object sender, EventArgs e)
        {
            if (isim.Text == "")
            {
                isim.Text = "isim";

            }
        }

        private void soyisim_Enter(object sender, EventArgs e)
        {
            if (soyisim.Text == "soyisim")
            {
                soyisim.Text = string.Empty;

            }
        }

        private void soyisim_Leave(object sender, EventArgs e)
        {
            if (soyisim.Text == "")
            {
                soyisim.Text = "soyisim";

            }
        }

        private void epostaadresi_Enter(object sender, EventArgs e)
        {
            if (epostaadresi.Text=="e-posta adresi")
            {
                epostaadresi.Text = string.Empty;

            }
        }

        private void epostaadresi_Leave(object sender, EventArgs e)
        {
            if (epostaadresi.Text == "")
            {
                epostaadresi.Text = "e-posta adresi";

            }
        }

        private void sifre_Enter(object sender, EventArgs e)
        {
            if (sifre.Text == "şifre")
            {
                sifre.Text = string.Empty;
                sifre.PasswordChar = '*';

            }
        }
        char? none = null;
        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "şifre";
                sifre.PasswordChar = Convert.ToChar(none);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sifre.PasswordChar = Convert.ToChar(none);
            pictureBox2.Visible= false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sifre.PasswordChar = '*';
            pictureBox3.Visible= false;
            pictureBox2.Visible = true;
        }

        private void kaydol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isverenuyelik form4 = new isverenuyelik();//açılacak form
            form4.Show(); //form isverenuyelik açılıyor.
        }
    }
}
