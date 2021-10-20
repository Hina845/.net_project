
namespace QLKS
{
    partial class FrmLoaiPhong
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblma_loai = new System.Windows.Forms.Label();
            this.lblten_loai = new System.Windows.Forms.Label();
            this.lblso_nguoi = new System.Windows.Forms.Label();
            this.lblgia = new System.Windows.Forms.Label();
            this.lblmo_ta = new System.Windows.Forms.Label();
            this.txtten_loai = new System.Windows.Forms.TextBox();
            this.txtmo_ta = new System.Windows.Forms.TextBox();
            this.txtma_loai = new System.Windows.Forms.NumericUpDown();
            this.txtso_nguoi = new System.Windows.Forms.NumericUpDown();
            this.txtgia = new System.Windows.Forms.NumericUpDown();
            this.btntao_moi = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dataGridLoaiPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtma_loai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtso_nguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(365, 21);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(196, 33);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "LOẠI PHÒNG";
            // 
            // lblma_loai
            // 
            this.lblma_loai.AutoSize = true;
            this.lblma_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblma_loai.Location = new System.Drawing.Point(93, 97);
            this.lblma_loai.Name = "lblma_loai";
            this.lblma_loai.Size = new System.Drawing.Size(70, 24);
            this.lblma_loai.TabIndex = 1;
            this.lblma_loai.Text = "Mã loại";
            // 
            // lblten_loai
            // 
            this.lblten_loai.AutoSize = true;
            this.lblten_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten_loai.Location = new System.Drawing.Point(93, 133);
            this.lblten_loai.Name = "lblten_loai";
            this.lblten_loai.Size = new System.Drawing.Size(78, 24);
            this.lblten_loai.TabIndex = 1;
            this.lblten_loai.Text = "Tên loại";
            // 
            // lblso_nguoi
            // 
            this.lblso_nguoi.AutoSize = true;
            this.lblso_nguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblso_nguoi.Location = new System.Drawing.Point(93, 170);
            this.lblso_nguoi.Name = "lblso_nguoi";
            this.lblso_nguoi.Size = new System.Drawing.Size(86, 24);
            this.lblso_nguoi.TabIndex = 1;
            this.lblso_nguoi.Text = "Số người";
            // 
            // lblgia
            // 
            this.lblgia.AutoSize = true;
            this.lblgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgia.Location = new System.Drawing.Point(93, 208);
            this.lblgia.Name = "lblgia";
            this.lblgia.Size = new System.Drawing.Size(38, 24);
            this.lblgia.TabIndex = 1;
            this.lblgia.Text = "Giá";
            // 
            // lblmo_ta
            // 
            this.lblmo_ta.AutoSize = true;
            this.lblmo_ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmo_ta.Location = new System.Drawing.Point(93, 242);
            this.lblmo_ta.Name = "lblmo_ta";
            this.lblmo_ta.Size = new System.Drawing.Size(56, 24);
            this.lblmo_ta.TabIndex = 1;
            this.lblmo_ta.Text = "Mô tả";
            // 
            // txtten_loai
            // 
            this.txtten_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten_loai.Location = new System.Drawing.Point(209, 128);
            this.txtten_loai.Name = "txtten_loai";
            this.txtten_loai.Size = new System.Drawing.Size(493, 29);
            this.txtten_loai.TabIndex = 2;
            // 
            // txtmo_ta
            // 
            this.txtmo_ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmo_ta.Location = new System.Drawing.Point(209, 237);
            this.txtmo_ta.Name = "txtmo_ta";
            this.txtmo_ta.Size = new System.Drawing.Size(493, 29);
            this.txtmo_ta.TabIndex = 2;
            // 
            // txtma_loai
            // 
            this.txtma_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma_loai.Location = new System.Drawing.Point(209, 92);
            this.txtma_loai.Name = "txtma_loai";
            this.txtma_loai.Size = new System.Drawing.Size(492, 29);
            this.txtma_loai.TabIndex = 3;
            // 
            // txtso_nguoi
            // 
            this.txtso_nguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso_nguoi.Location = new System.Drawing.Point(209, 165);
            this.txtso_nguoi.Name = "txtso_nguoi";
            this.txtso_nguoi.Size = new System.Drawing.Size(492, 29);
            this.txtso_nguoi.TabIndex = 3;
            // 
            // txtgia
            // 
            this.txtgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgia.Location = new System.Drawing.Point(209, 200);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(492, 29);
            this.txtgia.TabIndex = 3;
            // 
            // btntao_moi
            // 
            this.btntao_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntao_moi.Location = new System.Drawing.Point(775, 92);
            this.btntao_moi.Name = "btntao_moi";
            this.btntao_moi.Size = new System.Drawing.Size(105, 43);
            this.btntao_moi.TabIndex = 4;
            this.btntao_moi.Text = "Tạo mới";
            this.btntao_moi.UseVisualStyleBackColor = true;
            this.btntao_moi.Click += new System.EventHandler(this.btntao_moi_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(775, 141);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(105, 43);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(775, 190);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(105, 43);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(775, 239);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(105, 43);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(775, 288);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(105, 43);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dataGridLoaiPhong
            // 
            this.dataGridLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLoaiPhong.Location = new System.Drawing.Point(97, 288);
            this.dataGridLoaiPhong.Name = "dataGridLoaiPhong";
            this.dataGridLoaiPhong.Size = new System.Drawing.Size(603, 230);
            this.dataGridLoaiPhong.TabIndex = 5;
            this.dataGridLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLoaiPhong_CellContentClick);
            // 
            // FrmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 536);
            this.Controls.Add(this.dataGridLoaiPhong);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btntao_moi);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtso_nguoi);
            this.Controls.Add(this.txtma_loai);
            this.Controls.Add(this.txtmo_ta);
            this.Controls.Add(this.txtten_loai);
            this.Controls.Add(this.lblmo_ta);
            this.Controls.Add(this.lblgia);
            this.Controls.Add(this.lblso_nguoi);
            this.Controls.Add(this.lblten_loai);
            this.Controls.Add(this.lblma_loai);
            this.Controls.Add(this.lbltitle);
            this.Name = "FrmLoaiPhong";
            this.Text = "FrmLoaiPhong";
            this.Load += new System.EventHandler(this.FrmLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtma_loai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtso_nguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblma_loai;
        private System.Windows.Forms.Label lblten_loai;
        private System.Windows.Forms.Label lblso_nguoi;
        private System.Windows.Forms.Label lblgia;
        private System.Windows.Forms.Label lblmo_ta;
        private System.Windows.Forms.TextBox txtten_loai;
        private System.Windows.Forms.TextBox txtmo_ta;
        private System.Windows.Forms.NumericUpDown txtma_loai;
        private System.Windows.Forms.NumericUpDown txtso_nguoi;
        private System.Windows.Forms.NumericUpDown txtgia;
        private System.Windows.Forms.Button btntao_moi;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dataGridLoaiPhong;
    }
}