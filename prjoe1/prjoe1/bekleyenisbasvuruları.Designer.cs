namespace prjoe1
{
    partial class bekleyenisbasvuruları
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iseal = new System.Windows.Forms.Button();
            this.reddet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(993, 483);
            this.dataGridView1.TabIndex = 3;
            // 
            // iseal
            // 
            this.iseal.BackColor = System.Drawing.Color.LawnGreen;
            this.iseal.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iseal.Location = new System.Drawing.Point(109, 518);
            this.iseal.Name = "iseal";
            this.iseal.Size = new System.Drawing.Size(252, 86);
            this.iseal.TabIndex = 6;
            this.iseal.Text = "İŞE AL";
            this.iseal.UseVisualStyleBackColor = false;
            // 
            // reddet
            // 
            this.reddet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.reddet.BackColor = System.Drawing.Color.Red;
            this.reddet.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reddet.Location = new System.Drawing.Point(414, 518);
            this.reddet.Name = "reddet";
            this.reddet.Size = new System.Drawing.Size(252, 86);
            this.reddet.TabIndex = 7;
            this.reddet.Text = "REDDET";
            this.reddet.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(712, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 86);
            this.button1.TabIndex = 8;
            this.button1.Text = "DETAY";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bekleyenisbasvuruları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reddet);
            this.Controls.Add(this.iseal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "bekleyenisbasvuruları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bekleyenisbasvuruları";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button iseal;
        private System.Windows.Forms.Button reddet;
        private System.Windows.Forms.Button button1;
    }
}