namespace QuanLyPhuongTien.Forms.DangKi
{
    partial class FDangKi
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
            this.panelHienthi = new System.Windows.Forms.Panel();
            this.listviewDangki = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txbTimkiem = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelHienthi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHienthi
            // 
            this.panelHienthi.Controls.Add(this.listviewDangki);
            this.panelHienthi.Controls.Add(this.label1);
            this.panelHienthi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHienthi.Location = new System.Drawing.Point(0, 62);
            this.panelHienthi.Name = "panelHienthi";
            this.panelHienthi.Size = new System.Drawing.Size(935, 700);
            this.panelHienthi.TabIndex = 0;
            // 
            // listviewDangki
            // 
            this.listviewDangki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listviewDangki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewDangki.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewDangki.FullRowSelect = true;
            this.listviewDangki.GridLines = true;
            this.listviewDangki.HideSelection = false;
            this.listviewDangki.Location = new System.Drawing.Point(0, 0);
            this.listviewDangki.Name = "listviewDangki";
            this.listviewDangki.Size = new System.Drawing.Size(935, 700);
            this.listviewDangki.TabIndex = 0;
            this.listviewDangki.UseCompatibleStateImageBehavior = false;
            this.listviewDangki.View = System.Windows.Forms.View.Details;
            this.listviewDangki.SelectedIndexChanged += new System.EventHandler(this.listviewDangki_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Biển Số";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 330;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chủ Sở Hữu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 289;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Đăng Kí";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 201;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Đăng Kí";
            this.columnHeader5.Width = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập biển số xe: ";
            // 
            // txbTimkiem
            // 
            this.txbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimkiem.Location = new System.Drawing.Point(177, 9);
            this.txbTimkiem.Name = "txbTimkiem";
            this.txbTimkiem.Size = new System.Drawing.Size(254, 30);
            this.txbTimkiem.TabIndex = 2;
            this.txbTimkiem.TextChanged += new System.EventHandler(this.txbTimkiem_TextChanged);
            // 
            // btSua
            // 
            this.btSua.AutoSize = true;
            this.btSua.BackColor = System.Drawing.Color.White;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btSua.Location = new System.Drawing.Point(632, 7);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(90, 31);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btThem.Location = new System.Drawing.Point(478, 7);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 31);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.BackColor = System.Drawing.Color.White;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btXoa.Location = new System.Drawing.Point(799, 7);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 31);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập biển số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "(Mã đăng kí)";
            // 
            // FDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(935, 762);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txbTimkiem);
            this.Controls.Add(this.panelHienthi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(935, 762);
            this.MinimumSize = new System.Drawing.Size(935, 762);
            this.Name = "FDangKi";
            this.Text = "DangKi";
            this.Load += new System.EventHandler(this.FDangKi_Load);
            this.panelHienthi.ResumeLayout(false);
            this.panelHienthi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHienthi;
        private System.Windows.Forms.ListView listviewDangki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTimkiem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}