
namespace QLKS
{
    partial class Frm_Phong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblma_loai = new System.Windows.Forms.Label();
            this.lblten_loai = new System.Windows.Forms.Label();
            this.lblso_nguoi = new System.Windows.Forms.Label();
            this.lblgia = new System.Windows.Forms.Label();
            this.nmrIdLoaiPhong = new System.Windows.Forms.NumericUpDown();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.nmrId = new System.Windows.Forms.NumericUpDown();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btntao_moi = new System.Windows.Forms.Button();
            this.dataGridPhong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIdLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cboTrangthai);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblma_loai);
            this.panel1.Controls.Add(this.lblten_loai);
            this.panel1.Controls.Add(this.lblso_nguoi);
            this.panel1.Controls.Add(this.lblgia);
            this.panel1.Controls.Add(this.nmrIdLoaiPhong);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.nmrId);
            this.panel1.Location = new System.Drawing.Point(56, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 196);
            this.panel1.TabIndex = 7;
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Location = new System.Drawing.Point(294, 115);
            this.cboTrangthai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(392, 28);
            this.cboTrangthai.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 14);
            this.panel2.TabIndex = 4;
            // 
            // lblma_loai
            // 
            this.lblma_loai.AutoSize = true;
            this.lblma_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblma_loai.Location = new System.Drawing.Point(73, 29);
            this.lblma_loai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblma_loai.Name = "lblma_loai";
            this.lblma_loai.Size = new System.Drawing.Size(81, 20);
            this.lblma_loai.TabIndex = 1;
            this.lblma_loai.Text = "Mã Phòng";
            // 
            // lblten_loai
            // 
            this.lblten_loai.AutoSize = true;
            this.lblten_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten_loai.Location = new System.Drawing.Point(288, 29);
            this.lblten_loai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblten_loai.Name = "lblten_loai";
            this.lblten_loai.Size = new System.Drawing.Size(85, 20);
            this.lblten_loai.TabIndex = 1;
            this.lblten_loai.Text = "Tên phòng";
            // 
            // lblso_nguoi
            // 
            this.lblso_nguoi.AutoSize = true;
            this.lblso_nguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblso_nguoi.Location = new System.Drawing.Point(73, 87);
            this.lblso_nguoi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblso_nguoi.Name = "lblso_nguoi";
            this.lblso_nguoi.Size = new System.Drawing.Size(100, 20);
            this.lblso_nguoi.TabIndex = 1;
            this.lblso_nguoi.Text = "Id loại phòng";
            // 
            // lblgia
            // 
            this.lblgia.AutoSize = true;
            this.lblgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgia.Location = new System.Drawing.Point(288, 91);
            this.lblgia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblgia.Name = "lblgia";
            this.lblgia.Size = new System.Drawing.Size(80, 20);
            this.lblgia.TabIndex = 1;
            this.lblgia.Text = "Trạng thái";
            // 
            // nmrIdLoaiPhong
            // 
            this.nmrIdLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrIdLoaiPhong.Location = new System.Drawing.Point(79, 113);
            this.nmrIdLoaiPhong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nmrIdLoaiPhong.Name = "nmrIdLoaiPhong";
            this.nmrIdLoaiPhong.Size = new System.Drawing.Size(170, 26);
            this.nmrIdLoaiPhong.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(294, 55);
            this.txtTen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(392, 26);
            this.txtTen.TabIndex = 2;
            // 
            // nmrId
            // 
            this.nmrId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrId.Location = new System.Drawing.Point(79, 55);
            this.nmrId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nmrId.Name = "nmrId";
            this.nmrId.Size = new System.Drawing.Size(170, 26);
            this.nmrId.TabIndex = 3;
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(829, 204);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 40);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(829, 152);
            this.btnsua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(98, 40);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(829, 100);
            this.btnluu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(98, 40);
            this.btnluu.TabIndex = 10;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btntao_moi
            // 
            this.btntao_moi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntao_moi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            this.btntao_moi.FlatAppearance.BorderSize = 0;
            this.btntao_moi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntao_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntao_moi.Location = new System.Drawing.Point(829, 48);
            this.btntao_moi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btntao_moi.Name = "btntao_moi";
            this.btntao_moi.Size = new System.Drawing.Size(98, 40);
            this.btntao_moi.TabIndex = 11;
            this.btntao_moi.Text = "Tạo mới";
            this.btntao_moi.UseVisualStyleBackColor = false;
            this.btntao_moi.Click += new System.EventHandler(this.btntao_moi_Click);
            // 
            // dataGridPhong
            // 
            this.dataGridPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPhong.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPhong.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.dataGridPhong.Location = new System.Drawing.Point(56, 256);
            this.dataGridPhong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridPhong.Name = "dataGridPhong";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridPhong.Size = new System.Drawing.Size(871, 254);
            this.dataGridPhong.TabIndex = 12;
            // 
            // Frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 557);
            this.Controls.Add(this.dataGridPhong);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btntao_moi);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Phong";
            this.Text = "QUẢN LÝ PHÒNG";
            this.Load += new System.EventHandler(this.Frm_Phong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIdLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblma_loai;
        private System.Windows.Forms.Label lblten_loai;
        private System.Windows.Forms.Label lblso_nguoi;
        private System.Windows.Forms.Label lblgia;
        private System.Windows.Forms.NumericUpDown nmrIdLoaiPhong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.NumericUpDown nmrId;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btntao_moi;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.DataGridView dataGridPhong;
    }
}