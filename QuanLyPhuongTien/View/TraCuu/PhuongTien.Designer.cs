namespace QuanLyPhuongTien.View.TraCuu
{
    partial class PhuongTien
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
            this.panelHienThi = new System.Windows.Forms.Panel();
            this.lvPhuongTien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.panelHienThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHienThi
            // 
            this.panelHienThi.Controls.Add(this.lvPhuongTien);
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHienThi.Location = new System.Drawing.Point(0, 62);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(935, 700);
            this.panelHienThi.TabIndex = 1;
            // 
            // lvPhuongTien
            // 
            this.lvPhuongTien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPhuongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhuongTien.FullRowSelect = true;
            this.lvPhuongTien.GridLines = true;
            this.lvPhuongTien.HideSelection = false;
            this.lvPhuongTien.Location = new System.Drawing.Point(0, 0);
            this.lvPhuongTien.Name = "lvPhuongTien";
            this.lvPhuongTien.Size = new System.Drawing.Size(935, 700);
            this.lvPhuongTien.TabIndex = 0;
            this.lvPhuongTien.UseCompatibleStateImageBehavior = false;
            this.lvPhuongTien.View = System.Windows.Forms.View.Details;
            this.lvPhuongTien.SelectedIndexChanged += new System.EventHandler(this.lvPhuongTien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Biển Số";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 266;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Phương Tiện";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chủ Sở Hữu";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 350;
            // 
            // btXem
            // 
            this.btXem.BackColor = System.Drawing.Color.White;
            this.btXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btXem.Location = new System.Drawing.Point(772, 12);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(87, 30);
            this.btXem.TabIndex = 18;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = false;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nhập biển số:";
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.White;
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btTimKiem.Location = new System.Drawing.Point(619, 13);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(134, 29);
            this.btTimKiem.TabIndex = 16;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txbTimKiem.Location = new System.Drawing.Point(279, 12);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(299, 30);
            this.txbTimKiem.TabIndex = 15;
            // 
            // PhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(935, 762);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.panelHienThi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(935, 762);
            this.MinimumSize = new System.Drawing.Size(935, 762);
            this.Name = "PhuongTien";
            this.Text = "PhuongTien";
            this.panelHienThi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHienThi;
        private System.Windows.Forms.ListView lvPhuongTien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txbTimKiem;
    }
}