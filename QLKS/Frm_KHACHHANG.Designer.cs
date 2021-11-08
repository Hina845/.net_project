
namespace QLKS
{
    partial class Frm_KHACHHANG
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCMT = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtCMT = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.dataGridKhachHang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(419, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KHÁCH HÀNG ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(140, 108);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 29);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(140, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "HỌ VÀ TÊN:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(140, 204);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(68, 29);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "SĐT:";
            // 
            // lblCMT
            // 
            this.lblCMT.AutoSize = true;
            this.lblCMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMT.Location = new System.Drawing.Point(140, 300);
            this.lblCMT.Name = "lblCMT";
            this.lblCMT.Size = new System.Drawing.Size(72, 29);
            this.lblCMT.TabIndex = 1;
            this.lblCMT.Text = "CMT:";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmail.Location = new System.Drawing.Point(140, 252);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(91, 29);
            this.lblGmail.TabIndex = 1;
            this.lblGmail.Text = "GMAIL:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(140, 351);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 29);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "ĐỊA CHỈ:";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNation.Location = new System.Drawing.Point(140, 396);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(136, 29);
            this.lblNation.TabIndex = 1;
            this.lblNation.Text = "QUỐC GIA:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtID.Location = new System.Drawing.Point(316, 103);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(473, 34);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(316, 156);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(475, 34);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(316, 204);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(475, 34);
            this.txtPhone.TabIndex = 4;
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(316, 252);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(475, 34);
            this.txtGmail.TabIndex = 5;
            // 
            // txtCMT
            // 
            this.txtCMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMT.Location = new System.Drawing.Point(316, 295);
            this.txtCMT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(475, 34);
            this.txtCMT.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(316, 347);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(475, 34);
            this.txtAddress.TabIndex = 7;
            // 
            // txtNation
            // 
            this.txtNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNation.Location = new System.Drawing.Point(316, 391);
            this.txtNation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(475, 34);
            this.txtNation.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnThoat.Location = new System.Drawing.Point(895, 390);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 55);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnXoa.Location = new System.Drawing.Point(895, 327);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 55);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSua.Location = new System.Drawing.Point(895, 263);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 55);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLuu.Location = new System.Drawing.Point(895, 199);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(133, 55);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTaoMoi.Location = new System.Drawing.Point(895, 135);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(133, 55);
            this.btnTaoMoi.TabIndex = 13;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // dataGridKhachHang
            // 
            this.dataGridKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKhachHang.Location = new System.Drawing.Point(145, 465);
            this.dataGridKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridKhachHang.Name = "dataGridKhachHang";
            this.dataGridKhachHang.RowHeadersWidth = 51;
            this.dataGridKhachHang.RowTemplate.Height = 24;
            this.dataGridKhachHang.Size = new System.Drawing.Size(883, 150);
            this.dataGridKhachHang.TabIndex = 18;
            this.dataGridKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKhachHang_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(883, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Đặt Phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridKhachHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.txtNation);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCMT);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblNation);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblCMT);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_KHACHHANG";
            this.Text = "Frm_KHACHHANG";
            this.Load += new System.EventHandler(this.Frm_KHACHHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCMT;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.NumericUpDown txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtCMT;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.DataGridView dataGridKhachHang;
        private System.Windows.Forms.Button button1;
    }
}