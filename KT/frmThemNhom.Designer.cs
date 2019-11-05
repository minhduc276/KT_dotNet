namespace KT
{
    partial class frmThemNhom
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
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.textThemMaNhom = new System.Windows.Forms.TextBox();
            this.txtThemTenNhom = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhom.Location = new System.Drawing.Point(32, 35);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(66, 16);
            this.lblMaNhom.TabIndex = 0;
            this.lblMaNhom.Text = "Mã nhóm:";
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhom.Location = new System.Drawing.Point(31, 82);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(71, 16);
            this.lblTenNhom.TabIndex = 1;
            this.lblTenNhom.Text = "Tên nhóm:";
            // 
            // textThemMaNhom
            // 
            this.textThemMaNhom.Location = new System.Drawing.Point(105, 31);
            this.textThemMaNhom.Name = "textThemMaNhom";
            this.textThemMaNhom.Size = new System.Drawing.Size(211, 20);
            this.textThemMaNhom.TabIndex = 2;
            // 
            // txtThemTenNhom
            // 
            this.txtThemTenNhom.Location = new System.Drawing.Point(105, 79);
            this.txtThemTenNhom.Name = "txtThemTenNhom";
            this.txtThemTenNhom.Size = new System.Drawing.Size(211, 20);
            this.txtThemTenNhom.TabIndex = 3;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(150, 131);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // frmThemNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 185);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtThemTenNhom);
            this.Controls.Add(this.textThemMaNhom);
            this.Controls.Add(this.lblTenNhom);
            this.Controls.Add(this.lblMaNhom);
            this.Name = "frmThemNhom";
            this.Text = "Thêm mới nhóm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.Label lblTenNhom;
        private System.Windows.Forms.TextBox textThemMaNhom;
        private System.Windows.Forms.TextBox txtThemTenNhom;
        private System.Windows.Forms.Button btnThemMoi;
    }
}