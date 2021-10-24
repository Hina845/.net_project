
namespace QLKS
{
    partial class FormChiTietThietBi
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
            this.dtaGridChiTietTB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTenPhong = new System.Windows.Forms.ComboBox();
            this.cboTenTb = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cbTenPhong = new System.Windows.Forms.CheckBox();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.cbTenTb = new System.Windows.Forms.CheckBox();
            this.txtID_CTTB = new System.Windows.Forms.TextBox();
            this.cboIdPhong = new System.Windows.Forms.ComboBox();
            this.btnTaiLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridChiTietTB)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridChiTietTB
            // 
            this.dtaGridChiTietTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridChiTietTB.Location = new System.Drawing.Point(74, 192);
            this.dtaGridChiTietTB.Name = "dtaGridChiTietTB";
            this.dtaGridChiTietTB.Size = new System.Drawing.Size(530, 190);
            this.dtaGridChiTietTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(317, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý thiết bị";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnThem.Location = new System.Drawing.Point(676, 171);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChen
            // 
            this.btnChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnChen.Location = new System.Drawing.Point(676, 217);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(80, 40);
            this.btnChen.TabIndex = 3;
            this.btnChen.Text = "Chèn";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSua.Location = new System.Drawing.Point(676, 263);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 40);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnXoa.Location = new System.Drawing.Point(676, 309);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnThoat.Location = new System.Drawing.Point(676, 355);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(643, 45);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 46);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(71, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID PHÒNG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(71, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID CTTB:";
            // 
            // cboTenPhong
            // 
            this.cboTenPhong.FormattingEnabled = true;
            this.cboTenPhong.Location = new System.Drawing.Point(468, 81);
            this.cboTenPhong.Name = "cboTenPhong";
            this.cboTenPhong.Size = new System.Drawing.Size(141, 21);
            this.cboTenPhong.TabIndex = 14;
            // 
            // cboTenTb
            // 
            this.cboTenTb.FormattingEnabled = true;
            this.cboTenTb.Location = new System.Drawing.Point(468, 111);
            this.cboTenTb.Name = "cboTenTb";
            this.cboTenTb.Size = new System.Drawing.Size(141, 21);
            this.cboTenTb.TabIndex = 15;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(468, 143);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(141, 21);
            this.cboTrangThai.TabIndex = 16;
            // 
            // cbTenPhong
            // 
            this.cbTenPhong.AutoSize = true;
            this.cbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTenPhong.Location = new System.Drawing.Point(343, 86);
            this.cbTenPhong.Name = "cbTenPhong";
            this.cbTenPhong.Size = new System.Drawing.Size(114, 21);
            this.cbTenPhong.TabIndex = 21;
            this.cbTenPhong.Text = "TÊN PHÒNG:";
            this.cbTenPhong.UseVisualStyleBackColor = true;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTrangThai.Location = new System.Drawing.Point(343, 143);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(115, 21);
            this.cbTrangThai.TabIndex = 22;
            this.cbTrangThai.Text = "TRẠNG THÁI:";
            this.cbTrangThai.UseVisualStyleBackColor = true;
            // 
            // cbTenTb
            // 
            this.cbTenTb.AutoSize = true;
            this.cbTenTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTenTb.Location = new System.Drawing.Point(343, 113);
            this.cbTenTb.Name = "cbTenTb";
            this.cbTenTb.Size = new System.Drawing.Size(81, 21);
            this.cbTenTb.TabIndex = 23;
            this.cbTenTb.Text = "TÊN TB:";
            this.cbTenTb.UseVisualStyleBackColor = true;
            // 
            // txtID_CTTB
            // 
            this.txtID_CTTB.Enabled = false;
            this.txtID_CTTB.Location = new System.Drawing.Point(157, 87);
            this.txtID_CTTB.Name = "txtID_CTTB";
            this.txtID_CTTB.Size = new System.Drawing.Size(141, 20);
            this.txtID_CTTB.TabIndex = 20;
            // 
            // cboIdPhong
            // 
            this.cboIdPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdPhong.FormattingEnabled = true;
            this.cboIdPhong.Location = new System.Drawing.Point(157, 117);
            this.cboIdPhong.Name = "cboIdPhong";
            this.cboIdPhong.Size = new System.Drawing.Size(141, 21);
            this.cboIdPhong.TabIndex = 24;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaiLai.Location = new System.Drawing.Point(643, 103);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(145, 46);
            this.btnTaiLai.TabIndex = 25;
            this.btnTaiLai.Text = "TẢI LẠI";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // FormChiTietThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.cboIdPhong);
            this.Controls.Add(this.cbTenTb);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.cbTenPhong);
            this.Controls.Add(this.txtID_CTTB);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.cboTenTb);
            this.Controls.Add(this.cboTenPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtaGridChiTietTB);
            this.Name = "FormChiTietThietBi";
            this.Text = "FormChiTietThietBi";
            this.Load += new System.EventHandler(this.FormChiTietThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridChiTietTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridChiTietTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTenPhong;
        private System.Windows.Forms.ComboBox cboTenTb;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.CheckBox cbTenPhong;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.CheckBox cbTenTb;
        private System.Windows.Forms.TextBox txtID_CTTB;
        private System.Windows.Forms.ComboBox cboIdPhong;
        private System.Windows.Forms.Button btnTaiLai;
    }
}