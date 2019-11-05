namespace KT
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaLienLac = new System.Windows.Forms.Button();
            this.btnThemLienLac = new System.Windows.Forms.Button();
            this.btnXoaNhom = new System.Windows.Forms.Button();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.dtgvNhom = new System.Windows.Forms.DataGridView();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvLienLac = new System.Windows.Forms.DataGridView();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLienLac)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXoaLienLac);
            this.panel1.Controls.Add(this.btnThemLienLac);
            this.panel1.Controls.Add(this.btnXoaNhom);
            this.panel1.Controls.Add(this.btnThemNhom);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 38);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(580, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 32);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập từ cần tìm";
            // 
            // btnXoaLienLac
            // 
            this.btnXoaLienLac.Image = global::KT.Properties.Resources.delete;
            this.btnXoaLienLac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLienLac.Location = new System.Drawing.Point(306, 0);
            this.btnXoaLienLac.Name = "btnXoaLienLac";
            this.btnXoaLienLac.Size = new System.Drawing.Size(96, 38);
            this.btnXoaLienLac.TabIndex = 3;
            this.btnXoaLienLac.Text = "Xóa liên lạc";
            this.btnXoaLienLac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLienLac.UseVisualStyleBackColor = true;
            this.btnXoaLienLac.Click += new System.EventHandler(this.btnXoaLienLac_Click);
            // 
            // btnThemLienLac
            // 
            this.btnThemLienLac.Image = global::KT.Properties.Resources.edit;
            this.btnThemLienLac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLienLac.Location = new System.Drawing.Point(197, 0);
            this.btnThemLienLac.Name = "btnThemLienLac";
            this.btnThemLienLac.Size = new System.Drawing.Size(103, 38);
            this.btnThemLienLac.TabIndex = 2;
            this.btnThemLienLac.Text = "Thêm liên lạc";
            this.btnThemLienLac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLienLac.UseVisualStyleBackColor = true;
            this.btnThemLienLac.Click += new System.EventHandler(this.btnThemLienLac_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = global::KT.Properties.Resources.delete;
            this.btnXoaNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNhom.Location = new System.Drawing.Point(103, 0);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(88, 38);
            this.btnXoaNhom.TabIndex = 1;
            this.btnXoaNhom.Text = "Xóa nhóm";
            this.btnXoaNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNhom.UseVisualStyleBackColor = true;
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = global::KT.Properties.Resources.plus;
            this.btnThemNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhom.Location = new System.Drawing.Point(0, 0);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(97, 38);
            this.btnThemNhom.TabIndex = 0;
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNhom.UseVisualStyleBackColor = true;
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // dtgvNhom
            // 
            this.dtgvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNhom});
            this.dtgvNhom.Location = new System.Drawing.Point(0, 45);
            this.dtgvNhom.MultiSelect = false;
            this.dtgvNhom.Name = "dtgvNhom";
            this.dtgvNhom.ReadOnly = true;
            this.dtgvNhom.Size = new System.Drawing.Size(240, 347);
            this.dtgvNhom.TabIndex = 1;
            this.dtgvNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhom_CellClick);
            // 
            // TenNhom
            // 
            this.TenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên nhóm";
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.ReadOnly = true;
            // 
            // dtgvLienLac
            // 
            this.dtgvLienLac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLienLac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGoi,
            this.Email,
            this.SoDienThoai});
            this.dtgvLienLac.Location = new System.Drawing.Point(246, 45);
            this.dtgvLienLac.MultiSelect = false;
            this.dtgvLienLac.Name = "dtgvLienLac";
            this.dtgvLienLac.ReadOnly = true;
            this.dtgvLienLac.Size = new System.Drawing.Size(552, 223);
            this.dtgvLienLac.TabIndex = 2;
            this.dtgvLienLac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLienLac_CellClick);
            // 
            // TenGoi
            // 
            this.TenGoi.DataPropertyName = "tenlienhe";
            this.TenGoi.HeaderText = "Tên gọi";
            this.TenGoi.Name = "TenGoi";
            this.TenGoi.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "emaillienhe";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "sdtlienhe";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSoDienThoai);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTenGoi);
            this.panel2.Location = new System.Drawing.Point(246, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 118);
            this.panel2.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(22, 94);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(70, 13);
            this.lblSoDienThoai.TabIndex = 3;
            this.lblSoDienThoai.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(22, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ";
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGoi.Location = new System.Drawing.Point(21, 9);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.Size = new System.Drawing.Size(69, 20);
            this.lblTenGoi.TabIndex = 0;
            this.lblTenGoi.Text = "[Tên gọi]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgvLienLac);
            this.Controls.Add(this.dtgvNhom);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - [Họ tên sinh viên]";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLienLac)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaLienLac;
        private System.Windows.Forms.Button btnThemLienLac;
        private System.Windows.Forms.Button btnXoaNhom;
        private System.Windows.Forms.Button btnThemNhom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtgvNhom;
        private System.Windows.Forms.DataGridView dtgvLienLac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
    }
}

