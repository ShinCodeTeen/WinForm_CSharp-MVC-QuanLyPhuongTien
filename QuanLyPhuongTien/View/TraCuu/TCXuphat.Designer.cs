namespace QuanLyPhuongTien.Forms.TraCuu
{
    partial class TCXuphat
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
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.panelHienthi = new System.Windows.Forms.Panel();
            this.lvXuPhat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHienthi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.White;
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btTimKiem.Location = new System.Drawing.Point(645, 13);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(134, 29);
            this.btTimKiem.TabIndex = 8;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txbTimKiem.Location = new System.Drawing.Point(305, 12);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(299, 30);
            this.txbTimKiem.TabIndex = 6;
            // 
            // panelHienthi
            // 
            this.panelHienthi.Controls.Add(this.lvXuPhat);
            this.panelHienthi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHienthi.Location = new System.Drawing.Point(0, 62);
            this.panelHienthi.Name = "panelHienthi";
            this.panelHienthi.Size = new System.Drawing.Size(935, 700);
            this.panelHienthi.TabIndex = 9;
            // 
            // lvXuPhat
            // 
            this.lvXuPhat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvXuPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvXuPhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvXuPhat.FullRowSelect = true;
            this.lvXuPhat.GridLines = true;
            this.lvXuPhat.HideSelection = false;
            this.lvXuPhat.Location = new System.Drawing.Point(0, 0);
            this.lvXuPhat.Name = "lvXuPhat";
            this.lvXuPhat.Size = new System.Drawing.Size(935, 700);
            this.lvXuPhat.TabIndex = 1;
            this.lvXuPhat.UseCompatibleStateImageBehavior = false;
            this.lvXuPhat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Biển Số";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 222;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Người Điều Khiển";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 210;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Biên Bản";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 158;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thời Gian Lập";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 163;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 762);
            this.panel1.TabIndex = 10;
            // 
            // btXem
            // 
            this.btXem.BackColor = System.Drawing.Color.White;
            this.btXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.btXem.Location = new System.Drawing.Point(811, 12);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(75, 30);
            this.btXem.TabIndex = 21;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = false;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "(Mã Biên Bản)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nhập biển số:";
            // 
            // TCXuphat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(935, 762);
            this.Controls.Add(this.panelHienthi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(935, 762);
            this.Name = "TCXuphat";
            this.Text = "TCXuphat";
            this.panelHienthi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Panel panelHienthi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvXuPhat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btXem;
    }
}