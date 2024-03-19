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
    partial class CapNhatHoacXoaThuoc
    {

        private Label label1;
        private Label labelMT;
        private TextBox textboxMT;
        private Label labelTT;
        private TextBox textboxTT;
        private Button btnRead;
        private Button btnUpdate;
        private Button btnDelete;
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
            this.labelMT = new System.Windows.Forms.Label();
            this.textboxMT = new System.Windows.Forms.TextBox();
            this.labelTT = new System.Windows.Forms.Label();
            this.textboxTT = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật - Xóa thuốc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMT
            // 
            this.labelMT.AutoSize = true;
            this.labelMT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMT.Location = new System.Drawing.Point(99, 139);
            this.labelMT.Name = "labelMT";
            this.labelMT.Size = new System.Drawing.Size(99, 23);
            this.labelMT.TabIndex = 1;
            this.labelMT.Text = "Mã Thuốc";
            this.labelMT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textboxMT
            // 
            this.textboxMT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMT.Location = new System.Drawing.Point(198, 140);
            this.textboxMT.Name = "textboxMT";
            this.textboxMT.Size = new System.Drawing.Size(201, 27);
            this.textboxMT.TabIndex = 2;
            // 
            // labelTT
            // 
            this.labelTT.AutoSize = true;
            this.labelTT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTT.Location = new System.Drawing.Point(95, 184);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(106, 23);
            this.labelTT.TabIndex = 3;
            this.labelTT.Text = "Tên Thuốc";
            this.labelTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textboxTT
            // 
            this.textboxTT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxTT.Location = new System.Drawing.Point(198, 181);
            this.textboxTT.Name = "textboxTT";
            this.textboxTT.Size = new System.Drawing.Size(201, 27);
            this.textboxTT.TabIndex = 4;
            // 
            // btnRead
            // 
            this.btnRead.AutoSize = true;
            this.btnRead.BackColor = System.Drawing.Color.Tan;
            this.btnRead.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(418, 136);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(108, 33);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Tìm kiếm";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Tan;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(198, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 33);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.Tan;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(324, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CapNhatHoacXoaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(587, 304);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.textboxTT);
            this.Controls.Add(this.labelTT);
            this.Controls.Add(this.textboxMT);
            this.Controls.Add(this.labelMT);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CapNhatHoacXoaThuoc";
            this.Text = "Cập nhật hoặc Xóa thuốc";
            this.Load += new System.EventHandler(this.CapNhatHoacXoaThuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}