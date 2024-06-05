namespace QuanLyPhuongTien.Forms.DangKiem
{
    partial class FDangKiem
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.txbTimkiem = new System.Windows.Forms.TextBox();
            this.panelDangKiem = new System.Windows.Forms.Panel();
            this.lvDangKiem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelDangKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "(Mã đăng kiểm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhập biển số:";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btThem.Location = new System.Drawing.Point(682, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 30);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txbTimkiem
            // 
            this.txbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimkiem.Location = new System.Drawing.Point(210, 12);
            this.txbTimkiem.Name = "txbTimkiem";
            this.txbTimkiem.Size = new System.Drawing.Size(350, 30);
            this.txbTimkiem.TabIndex = 9;
            this.txbTimkiem.TextChanged += new System.EventHandler(this.txbTimkiem_TextChanged);
            // 
            // panelDangKiem
            // 
            this.panelDangKiem.Controls.Add(this.lvDangKiem);
            this.panelDangKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDangKiem.Location = new System.Drawing.Point(0, 62);
            this.panelDangKiem.Name = "panelDangKiem";
            this.panelDangKiem.Size = new System.Drawing.Size(935, 700);
            this.panelDangKiem.TabIndex = 16;
            // 
            // lvDangKiem
            // 
            this.lvDangKiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDangKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDangKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDangKiem.GridLines = true;
            this.lvDangKiem.HideSelection = false;
            this.lvDangKiem.Location = new System.Drawing.Point(0, 0);
            this.lvDangKiem.Name = "lvDangKiem";
            this.lvDangKiem.Size = new System.Drawing.Size(935, 700);
            this.lvDangKiem.TabIndex = 0;
            this.lvDangKiem.UseCompatibleStateImageBehavior = false;
            this.lvDangKiem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Biển Số";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chủ Sở Hữu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 171;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Đăng Kiểm";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Đăng Kiểm";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 170;
            // 
            // FDangKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(935, 762);
            this.Controls.Add(this.panelDangKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txbTimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(935, 762);
            this.MinimumSize = new System.Drawing.Size(935, 762);
            this.Name = "FDangKiem";
            this.Text = "FDangKiem";
            this.Load += new System.EventHandler(this.FDangKiem_Load);
            this.panelDangKiem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txbTimkiem;
        private System.Windows.Forms.Panel panelDangKiem;
        private System.Windows.Forms.ListView lvDangKiem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}