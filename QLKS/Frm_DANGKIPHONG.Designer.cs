
namespace QLKS
{
    partial class Frm_DANGKIPHONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DANGKIPHONG));
            this.lblID = new System.Windows.Forms.Label();
            this.numPhong = new System.Windows.Forms.NumericUpDown();
            this.DataGrid_Dangkyphong = new System.Windows.Forms.DataGridView();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblIDDatphong = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.numDatphong = new System.Windows.Forms.NumericUpDown();
            this.lblSophong = new System.Windows.Forms.Label();
            this.numSophong = new System.Windows.Forms.NumericUpDown();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Dangkyphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSophong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(43, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID ";
            // 
            // numPhong
            // 
            this.numPhong.BackColor = System.Drawing.SystemColors.Control;
            this.numPhong.Enabled = false;
            this.numPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPhong.Location = new System.Drawing.Point(435, 38);
            this.numPhong.Name = "numPhong";
            this.numPhong.Size = new System.Drawing.Size(120, 26);
            this.numPhong.TabIndex = 4;
            // 
            // DataGrid_Dangkyphong
            // 
            this.DataGrid_Dangkyphong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_Dangkyphong.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Dangkyphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Dangkyphong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.DataGrid_Dangkyphong.Location = new System.Drawing.Point(28, 210);
            this.DataGrid_Dangkyphong.Name = "DataGrid_Dangkyphong";
            this.DataGrid_Dangkyphong.RowHeadersWidth = 51;
            this.DataGrid_Dangkyphong.RowTemplate.Height = 24;
            this.DataGrid_Dangkyphong.Size = new System.Drawing.Size(802, 262);
            this.DataGrid_Dangkyphong.TabIndex = 5;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(431, 15);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(76, 20);
            this.lblPhong.TabIndex = 6;
            this.lblPhong.Text = "ID Phòng";
            // 
            // lblIDDatphong
            // 
            this.lblIDDatphong.AutoSize = true;
            this.lblIDDatphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDDatphong.Location = new System.Drawing.Point(235, 15);
            this.lblIDDatphong.Name = "lblIDDatphong";
            this.lblIDDatphong.Size = new System.Drawing.Size(105, 20);
            this.lblIDDatphong.TabIndex = 7;
            this.lblIDDatphong.Text = "ID Đặt phòng";
            this.lblIDDatphong.Click += new System.EventHandler(this.lblIDDatphong_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(212)))));
            this.btnDangky.FlatAppearance.BorderSize = 0;
            this.btnDangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.ForeColor = System.Drawing.Color.White;
            this.btnDangky.Location = new System.Drawing.Point(697, 478);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(133, 46);
            this.btnDangky.TabIndex = 8;
            this.btnDangky.Text = "Đăng ký phòng";
            this.btnDangky.UseVisualStyleBackColor = false;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(821, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(20, 20);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(212)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(621, 478);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 46);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // numDatphong
            // 
            this.numDatphong.BackColor = System.Drawing.SystemColors.Control;
            this.numDatphong.Enabled = false;
            this.numDatphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDatphong.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numDatphong.Location = new System.Drawing.Point(239, 38);
            this.numDatphong.Name = "numDatphong";
            this.numDatphong.Size = new System.Drawing.Size(120, 26);
            this.numDatphong.TabIndex = 11;
            this.numDatphong.ValueChanged += new System.EventHandler(this.numDatphong_ValueChanged);
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSophong.Location = new System.Drawing.Point(622, 15);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(82, 20);
            this.lblSophong.TabIndex = 12;
            this.lblSophong.Text = "Số phòng ";
            this.lblSophong.Click += new System.EventHandler(this.label2_Click);
            // 
            // numSophong
            // 
            this.numSophong.BackColor = System.Drawing.SystemColors.Control;
            this.numSophong.Enabled = false;
            this.numSophong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSophong.Location = new System.Drawing.Point(626, 38);
            this.numSophong.Name = "numSophong";
            this.numSophong.Size = new System.Drawing.Size(120, 26);
            this.numSophong.TabIndex = 13;
            this.numSophong.ValueChanged += new System.EventHandler(this.numSophong_ValueChanged);
            // 
            // numID
            // 
            this.numID.BackColor = System.Drawing.SystemColors.Control;
            this.numID.Enabled = false;
            this.numID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numID.Location = new System.Drawing.Point(47, 38);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(120, 26);
            this.numID.TabIndex = 15;
            this.numID.ValueChanged += new System.EventHandler(this.numID_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Đăng ký phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.numID);
            this.panel1.Controls.Add(this.numSophong);
            this.panel1.Controls.Add(this.lblSophong);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.numDatphong);
            this.panel1.Controls.Add(this.lblIDDatphong);
            this.panel1.Controls.Add(this.numPhong);
            this.panel1.Controls.Add(this.lblPhong);
            this.panel1.Location = new System.Drawing.Point(28, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 100);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 10);
            this.panel2.TabIndex = 16;
            // 
            // Frm_DANGKIPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 536);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.DataGrid_Dangkyphong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.Name = "Frm_DANGKIPHONG";
            this.Text = "ĐĂNG KÝ PHÒNG";
            this.Load += new System.EventHandler(this.Frm_DANGKIPHONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Dangkyphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSophong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown numPhong;
        private System.Windows.Forms.DataGridView DataGrid_Dangkyphong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblIDDatphong;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.NumericUpDown numDatphong;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.NumericUpDown numSophong;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}