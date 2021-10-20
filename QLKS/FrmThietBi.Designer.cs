
namespace QLKS
{
    partial class FrmThietBi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.nmrID = new System.Windows.Forms.NumericUpDown();
            this.nmrGia = new System.Windows.Forms.NumericUpDown();
            this.dtaGridThietBi = new System.Windows.Forms.DataGridView();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(275, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(91, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(91, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(389, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtTen.Location = new System.Drawing.Point(146, 126);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(182, 27);
            this.txtTen.TabIndex = 4;
            // 
            // nmrID
            // 
            this.nmrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nmrID.Location = new System.Drawing.Point(146, 85);
            this.nmrID.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmrID.Name = "nmrID";
            this.nmrID.Size = new System.Drawing.Size(64, 27);
            this.nmrID.TabIndex = 5;
            // 
            // nmrGia
            // 
            this.nmrGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nmrGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrGia.Location = new System.Drawing.Point(438, 125);
            this.nmrGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmrGia.Name = "nmrGia";
            this.nmrGia.Size = new System.Drawing.Size(120, 27);
            this.nmrGia.TabIndex = 6;
            // 
            // dtaGridThietBi
            // 
            this.dtaGridThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridThietBi.Location = new System.Drawing.Point(95, 182);
            this.dtaGridThietBi.Name = "dtaGridThietBi";
            this.dtaGridThietBi.Size = new System.Drawing.Size(463, 155);
            this.dtaGridThietBi.TabIndex = 7;
            this.dtaGridThietBi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridThietBi_CellContentClick);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTaoMoi.Location = new System.Drawing.Point(617, 74);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(100, 45);
            this.btnTaoMoi.TabIndex = 8;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLuu.Location = new System.Drawing.Point(617, 126);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 45);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSua.Location = new System.Drawing.Point(617, 177);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 45);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnXoa.Location = new System.Drawing.Point(617, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 45);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnThoat.Location = new System.Drawing.Point(617, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 45);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.dtaGridThietBi);
            this.Controls.Add(this.nmrGia);
            this.Controls.Add(this.nmrID);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThietBi";
            this.Text = "FrmThietBi";
            this.Load += new System.EventHandler(this.FrmThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.NumericUpDown nmrID;
        private System.Windows.Forms.NumericUpDown nmrGia;
        private System.Windows.Forms.DataGridView dtaGridThietBi;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}