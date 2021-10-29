
namespace QLKS
{
    partial class Frm_DangKySuDungDv
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
            this.dtaGridDichVu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrID = new System.Windows.Forms.NumericUpDown();
            this.dateNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDichVU = new System.Windows.Forms.TextBox();
            this.nmrIDphong = new System.Windows.Forms.NumericUpDown();
            this.nmrIDdichvu = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIDphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIDdichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(194, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ SỬ DỤNG DỊCH VỤ";
            // 
            // dtaGridDichVu
            // 
            this.dtaGridDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridDichVu.Location = new System.Drawing.Point(91, 242);
            this.dtaGridDichVu.Name = "dtaGridDichVu";
            this.dtaGridDichVu.Size = new System.Drawing.Size(505, 181);
            this.dtaGridDichVu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(363, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID phòng: ";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnThoat.Location = new System.Drawing.Point(669, 301);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 45);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLuu.Location = new System.Drawing.Point(669, 250);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 45);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTaoMoi.Location = new System.Drawing.Point(669, 198);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(100, 45);
            this.btnTaoMoi.TabIndex = 18;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(87, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID:";
            // 
            // nmrID
            // 
            this.nmrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nmrID.Location = new System.Drawing.Point(200, 100);
            this.nmrID.Name = "nmrID";
            this.nmrID.Size = new System.Drawing.Size(120, 27);
            this.nmrID.TabIndex = 24;
            // 
            // dateNgayDat
            // 
            this.dateNgayDat.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dateNgayDat.Checked = false;
            this.dateNgayDat.CustomFormat = "dd-MM-yyy";
            this.dateNgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDat.Location = new System.Drawing.Point(476, 154);
            this.dateNgayDat.Name = "dateNgayDat";
            this.dateNgayDat.Size = new System.Drawing.Size(120, 26);
            this.dateNgayDat.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(363, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày đặt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(87, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID Dịch vụ: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(87, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tên dịch vụ:";
            // 
            // txtDichVU
            // 
            this.txtDichVU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtDichVU.Location = new System.Drawing.Point(201, 198);
            this.txtDichVU.Name = "txtDichVU";
            this.txtDichVU.Size = new System.Drawing.Size(395, 27);
            this.txtDichVU.TabIndex = 30;
            // 
            // nmrIDphong
            // 
            this.nmrIDphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nmrIDphong.Location = new System.Drawing.Point(475, 102);
            this.nmrIDphong.Name = "nmrIDphong";
            this.nmrIDphong.Size = new System.Drawing.Size(120, 27);
            this.nmrIDphong.TabIndex = 31;
            // 
            // nmrIDdichvu
            // 
            this.nmrIDdichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nmrIDdichvu.Location = new System.Drawing.Point(201, 148);
            this.nmrIDdichvu.Name = "nmrIDdichvu";
            this.nmrIDdichvu.Size = new System.Drawing.Size(120, 27);
            this.nmrIDdichvu.TabIndex = 32;
            // 
            // Frm_DangKySuDungDv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nmrIDdichvu);
            this.Controls.Add(this.nmrIDphong);
            this.Controls.Add(this.txtDichVU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateNgayDat);
            this.Controls.Add(this.nmrID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtaGridDichVu);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DangKySuDungDv";
            this.Text = "Frm_DangKySuDungDv";
            this.Load += new System.EventHandler(this.Frm_DangKySuDungDv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIDphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIDdichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtaGridDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrID;
        private System.Windows.Forms.DateTimePicker dateNgayDat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDichVU;
        private System.Windows.Forms.NumericUpDown nmrIDphong;
        private System.Windows.Forms.NumericUpDown nmrIDdichvu;
    }
}