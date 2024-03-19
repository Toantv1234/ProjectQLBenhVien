using CSDLNC.ThongKe;
using DoAnHEQUANTRI;
using NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuoc
{
    partial class DanhSachThuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.ThemThuoc = new System.Windows.Forms.Button();
            this.ListThuoc = new System.Windows.Forms.DataGridView();
            this.updateOrDeleteThuoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Thuốc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ThemThuoc
            // 
            this.ThemThuoc.AutoSize = true;
            this.ThemThuoc.BackColor = System.Drawing.Color.Tan;
            this.ThemThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemThuoc.Location = new System.Drawing.Point(479, 375);
            this.ThemThuoc.Name = "ThemThuoc";
            this.ThemThuoc.Size = new System.Drawing.Size(135, 35);
            this.ThemThuoc.TabIndex = 2;
            this.ThemThuoc.Text = "Thêm Thuốc";
            this.ThemThuoc.UseVisualStyleBackColor = false;
            this.ThemThuoc.Click += new System.EventHandler(this.ThemThuoc_Click);
            // 
            // ListThuoc
            // 
            this.ListThuoc.AllowUserToOrderColumns = true;
            this.ListThuoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ListThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListThuoc.GridColor = System.Drawing.Color.Chocolate;
            this.ListThuoc.Location = new System.Drawing.Point(68, 88);
            this.ListThuoc.Name = "ListThuoc";
            this.ListThuoc.RowHeadersWidth = 51;
            this.ListThuoc.Size = new System.Drawing.Size(545, 281);
            this.ListThuoc.TabIndex = 3;
            // 
            // updateOrDeleteThuoc
            // 
            this.updateOrDeleteThuoc.AutoSize = true;
            this.updateOrDeleteThuoc.BackColor = System.Drawing.Color.Tan;
            this.updateOrDeleteThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOrDeleteThuoc.Location = new System.Drawing.Point(68, 375);
            this.updateOrDeleteThuoc.Name = "updateOrDeleteThuoc";
            this.updateOrDeleteThuoc.Size = new System.Drawing.Size(215, 35);
            this.updateOrDeleteThuoc.TabIndex = 4;
            this.updateOrDeleteThuoc.Text = "Cập Nhật / Xóa Thuốc";
            this.updateOrDeleteThuoc.UseVisualStyleBackColor = false;
            this.updateOrDeleteThuoc.Click += new System.EventHandler(this.updateOrDeleteThuoc_Click);
            // 
            // DanhSachThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(675, 420);
            this.Controls.Add(this.updateOrDeleteThuoc);
            this.Controls.Add(this.ListThuoc);
            this.Controls.Add(this.ThemThuoc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DanhSachThuoc";
            this.Text = "DanhSachThuoc";
            this.Load += new System.EventHandler(this.DanhSachThuoc_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ListThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private Button ThemThuoc;
        private DataGridView ListThuoc;
        private Button updateOrDeleteThuoc;
    }
}