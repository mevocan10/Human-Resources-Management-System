namespace prjoe1
{
    partial class login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kullanicilabel = new System.Windows.Forms.Label();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uyeol = new System.Windows.Forms.Button();
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.uyegiris = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyegiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanicilabel
            // 
            this.kullanicilabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullanicilabel.AutoSize = true;
            this.kullanicilabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanicilabel.Location = new System.Drawing.Point(236, 278);
            this.kullanicilabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullanicilabel.Name = "kullanicilabel";
            this.kullanicilabel.Size = new System.Drawing.Size(178, 33);
            this.kullanicilabel.TabIndex = 2;
            this.kullanicilabel.Text = "Kullanıcı adı";
            // 
            // sifrelabel
            // 
            this.sifrelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sifrelabel.AutoSize = true;
            this.sifrelabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifrelabel.Location = new System.Drawing.Point(284, 395);
            this.sifrelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifrelabel.Name = "sifrelabel";
            this.sifrelabel.Size = new System.Drawing.Size(81, 33);
            this.sifrelabel.TabIndex = 4;
            this.sifrelabel.Text = "Şifre";
            // 
            // sifre
            // 
            this.sifre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sifre.BackColor = System.Drawing.SystemColors.Control;
            this.sifre.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre.Location = new System.Drawing.Point(228, 443);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(193, 30);
            this.sifre.TabIndex = 5;
            this.sifre.Text = "Şifre";
            this.sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sifre.Enter += new System.EventHandler(this.sifre_Enter);
            this.sifre.Leave += new System.EventHandler(this.sifre_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(207, 669);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Henüz üye değil misin ?";
            // 
            // uyeol
            // 
            this.uyeol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uyeol.BackColor = System.Drawing.Color.Salmon;
            this.uyeol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uyeol.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeol.Location = new System.Drawing.Point(234, 705);
            this.uyeol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uyeol.Name = "uyeol";
            this.uyeol.Size = new System.Drawing.Size(206, 52);
            this.uyeol.TabIndex = 7;
            this.uyeol.Text = "Hemen üye ol";
            this.uyeol.UseVisualStyleBackColor = false;
            this.uyeol.Click += new System.EventHandler(this.uyeol_Click);
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullaniciadi.BackColor = System.Drawing.SystemColors.Control;
            this.kullaniciadi.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciadi.Location = new System.Drawing.Point(212, 335);
            this.kullaniciadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(242, 30);
            this.kullaniciadi.TabIndex = 8;
            this.kullaniciadi.Text = "Kullanıcı adı";
            this.kullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kullaniciadi.Enter += new System.EventHandler(this.kullaniciadi_Enter);
            this.kullaniciadi.Leave += new System.EventHandler(this.kullaniciadi_Leave);
            // 
            // pb1
            // 
            this.pb1.Image = global::prjoe1.Properties.Resources.eye;
            this.pb1.Location = new System.Drawing.Point(432, 443);
            this.pb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(32, 34);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 18;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::prjoe1.Properties.Resources.invisible;
            this.pb2.Location = new System.Drawing.Point(432, 443);
            this.pb2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(32, 34);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 17;
            this.pb2.TabStop = false;
            this.pb2.Visible = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // uyegiris
            // 
            this.uyegiris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uyegiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uyegiris.Image = global::prjoe1.Properties.Resources.uye_giris;
            this.uyegiris.Location = new System.Drawing.Point(270, 506);
            this.uyegiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uyegiris.Name = "uyegiris";
            this.uyegiris.Size = new System.Drawing.Size(132, 123);
            this.uyegiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uyegiris.TabIndex = 1;
            this.uyegiris.TabStop = false;
            this.uyegiris.Click += new System.EventHandler(this.uyegiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::prjoe1.Properties.Resources.Isin_Olsun_Logo_01;
            this.pictureBox1.Location = new System.Drawing.Point(48, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 915);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.uyeol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.sifrelabel);
            this.Controls.Add(this.kullanicilabel);
            this.Controls.Add(this.uyegiris);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyegiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox uyegiris;
        private System.Windows.Forms.Label kullanicilabel;
        private System.Windows.Forms.Label sifrelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uyeol;
        private System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
    }
}

