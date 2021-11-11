
namespace QLKS
{
    partial class FrmChiTietSuDungDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.cboIdPhong = new System.Windows.Forms.ComboBox();
            this.cbTenDV = new System.Windows.Forms.CheckBox();
            this.cbNgayDung = new System.Windows.Forms.CheckBox();
            this.cbTenPhong = new System.Windows.Forms.CheckBox();
            this.txtID_CTSD = new System.Windows.Forms.TextBox();
            this.cboTenDV = new System.Windows.Forms.ComboBox();
            this.cboTenPhong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtaGridChiTietSD = new System.Windows.Forms.DataGridView();
            this.dateNgayDat = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridChiTietSD)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaiLai.Location = new System.Drawing.Point(843, 317);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(120, 50);
            this.btnTaiLai.TabIndex = 44;
            this.btnTaiLai.Text = "TẢI LẠI";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // cboIdPhong
            // 
            this.cboIdPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIdPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIdPhong.FormattingEnabled = true;
            this.cboIdPhong.Location = new System.Drawing.Point(514, 44);
            this.cboIdPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboIdPhong.Name = "cboIdPhong";
            this.cboIdPhong.Size = new System.Drawing.Size(210, 28);
            this.cboIdPhong.TabIndex = 43;
            // 
            // cbTenDV
            // 
            this.cbTenDV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTenDV.AutoSize = true;
            this.cbTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTenDV.Location = new System.Drawing.Point(442, 29);
            this.cbTenDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTenDV.Name = "cbTenDV";
            this.cbTenDV.Size = new System.Drawing.Size(108, 24);
            this.cbTenDV.TabIndex = 42;
            this.cbTenDV.Text = "Tên dịch vụ";
            this.cbTenDV.UseVisualStyleBackColor = true;
            // 
            // cbNgayDung
            // 
            this.cbNgayDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNgayDung.AutoSize = true;
            this.cbNgayDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbNgayDung.Location = new System.Drawing.Point(684, 31);
            this.cbNgayDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNgayDung.Name = "cbNgayDung";
            this.cbNgayDung.Size = new System.Drawing.Size(104, 24);
            this.cbNgayDung.TabIndex = 41;
            this.cbNgayDung.Text = "Ngày dùng";
            this.cbNgayDung.UseVisualStyleBackColor = true;
            this.cbNgayDung.CheckedChanged += new System.EventHandler(this.cbNgayDung_CheckedChanged);
            // 
            // cbTenPhong
            // 
            this.cbTenPhong.AutoSize = true;
            this.cbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTenPhong.Location = new System.Drawing.Point(202, 29);
            this.cbTenPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTenPhong.Name = "cbTenPhong";
            this.cbTenPhong.Size = new System.Drawing.Size(104, 24);
            this.cbTenPhong.TabIndex = 40;
            this.cbTenPhong.Text = "Tên phòng";
            this.cbTenPhong.UseVisualStyleBackColor = true;
            // 
            // txtID_CTSD
            // 
            this.txtID_CTSD.Enabled = false;
            this.txtID_CTSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_CTSD.Location = new System.Drawing.Point(201, 46);
            this.txtID_CTSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID_CTSD.Name = "txtID_CTSD";
            this.txtID_CTSD.Size = new System.Drawing.Size(210, 26);
            this.txtID_CTSD.TabIndex = 39;
            // 
            // cboTenDV
            // 
            this.cboTenDV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenDV.FormattingEnabled = true;
            this.cboTenDV.Location = new System.Drawing.Point(442, 55);
            this.cboTenDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTenDV.Name = "cboTenDV";
            this.cboTenDV.Size = new System.Drawing.Size(210, 28);
            this.cboTenDV.TabIndex = 37;
            // 
            // cboTenPhong
            // 
            this.cboTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenPhong.FormattingEnabled = true;
            this.cboTenPhong.Location = new System.Drawing.Point(201, 55);
            this.cboTenPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTenPhong.Name = "cboTenPhong";
            this.cboTenPhong.Size = new System.Drawing.Size(210, 28);
            this.cboTenPhong.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(197, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "ID CTSD";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(510, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID Phòng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(843, 259);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 50);
            this.btnTimKiem.TabIndex = 33;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(843, 375);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 38);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtaGridChiTietSD
            // 
            this.dtaGridChiTietSD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGridChiTietSD.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridChiTietSD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaGridChiTietSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridChiTietSD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtaGridChiTietSD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.dtaGridChiTietSD.Location = new System.Drawing.Point(31, 259);
            this.dtaGridChiTietSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtaGridChiTietSD.Name = "dtaGridChiTietSD";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridChiTietSD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtaGridChiTietSD.Size = new System.Drawing.Size(797, 285);
            this.dtaGridChiTietSD.TabIndex = 26;
            // 
            // dateNgayDat
            // 
            this.dateNgayDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNgayDat.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dateNgayDat.Checked = false;
            this.dateNgayDat.CustomFormat = "yyy-MM-dd";
            this.dateNgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDat.Location = new System.Drawing.Point(684, 57);
            this.dateNgayDat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateNgayDat.Name = "dateNgayDat";
            this.dateNgayDat.Size = new System.Drawing.Size(210, 26);
            this.dateNgayDat.TabIndex = 45;
            this.dateNgayDat.ValueChanged += new System.EventHandler(this.dateNgayDat_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateNgayDat);
            this.panel2.Controls.Add(this.cboTenPhong);
            this.panel2.Controls.Add(this.cbTenPhong);
            this.panel2.Controls.Add(this.cbNgayDung);
            this.panel2.Controls.Add(this.cbTenDV);
            this.panel2.Controls.Add(this.cboTenDV);
            this.panel2.Location = new System.Drawing.Point(31, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 120);
            this.panel2.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 10);
            this.panel4.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 37);
            this.label3.TabIndex = 44;
            this.label3.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtID_CTSD);
            this.panel1.Controls.Add(this.cboIdPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 100);
            this.panel1.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 10);
            this.panel3.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID";
            // 
            // FrmChiTietSuDungDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtaGridChiTietSD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmChiTietSuDungDV";
            this.Text = "CHI TIẾT SỬ DỤNG DỊCH VỤ";
            this.Load += new System.EventHandler(this.FrmChiTietSuDungDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridChiTietSD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.ComboBox cboIdPhong;
        private System.Windows.Forms.CheckBox cbTenDV;
        private System.Windows.Forms.CheckBox cbNgayDung;
        private System.Windows.Forms.CheckBox cbTenPhong;
        private System.Windows.Forms.TextBox txtID_CTSD;
        private System.Windows.Forms.ComboBox cboTenDV;
        private System.Windows.Forms.ComboBox cboTenPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtaGridChiTietSD;
        private System.Windows.Forms.DateTimePicker dateNgayDat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}