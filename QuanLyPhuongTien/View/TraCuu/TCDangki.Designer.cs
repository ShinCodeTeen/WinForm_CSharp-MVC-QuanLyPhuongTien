namespace QuanLyPhuongTien.Forms.TraCuu
{
    partial class TCDangki
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
            this.panelTCDangKi = new System.Windows.Forms.Panel();
            this.listViewTCDangKi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btXem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.panelTCDangKi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTCDangKi
            // 
            this.panelTCDangKi.Controls.Add(this.listViewTCDangKi);
            this.panelTCDangKi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTCDangKi.Location = new System.Drawing.Point(0, 62);
            this.panelTCDangKi.Name = "panelTCDangKi";
            this.panelTCDangKi.Size = new System.Drawing.Size(935, 700);
            this.panelTCDangKi.TabIndex = 0;
            // 
            // listViewTCDangKi
            // 
            this.listViewTCDangKi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewTCDangKi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTCDangKi.FullRowSelect = true;
            this.listViewTCDangKi.GridLines = true;
            this.listViewTCDangKi.HideSelection = false;
            this.listViewTCDangKi.Location = new System.Drawing.Point(0, 0);
            this.listViewTCDangKi.Name = "listViewTCDangKi";
            this.listViewTCDangKi.Size = new System.Drawing.Size(935, 700);
            this.listViewTCDangKi.TabIndex = 0;
            this.listViewTCDangKi.UseCompatibleStateImageBehavior = false;
            this.listViewTCDangKi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Biển Số";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 194;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chủ Sở Hữu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 221;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Đăng Kí";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Đăng Kí";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 208;
            // 
            // btXem
            // 
            this.btXem.BackColor = System.Drawing.Color.White;
            this.btXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btXem.Location = new System.Drawing.Point(789, 12);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(75, 30);
            this.btXem.TabIndex = 26;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = false;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "(Mã Đăng Kí)";
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.White;
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btTimKiem.Location = new System.Drawing.Point(623, 13);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(134, 29);
            this.btTimKiem.TabIndex = 23;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nhập biển số:";
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txbTimKiem.Location = new System.Drawing.Point(283, 12);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(299, 30);
            this.txbTimKiem.TabIndex = 22;
            // 
            // TCDangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(935, 762);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.panelTCDangKi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(935, 762);
            this.Name = "TCDangki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCDangki";
            this.Load += new System.EventHandler(this.TCDangki_Load);
            this.panelTCDangKi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTCDangKi;
        private System.Windows.Forms.ListView listViewTCDangKi;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}