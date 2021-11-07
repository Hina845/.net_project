
namespace QLKS
{
    partial class Frm_DICHVU
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKSDataSet = new QLKS.QLKSDataSet();
            this.dICH_VUTableAdapter = new QLKS.QLKSDataSetTableAdapters.DICH_VUTableAdapter();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT DỊCH VỤ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Dịch Vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Dịch Vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Tiền:";
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Location = new System.Drawing.Point(651, 151);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(94, 38);
            this.btn_TaoMoi.TabIndex = 4;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Location = new System.Drawing.Point(651, 195);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(94, 38);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(651, 242);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 38);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(651, 286);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 38);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(651, 331);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 38);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(513, 148);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICH_VU";
            this.dICHVUBindingSource.DataSource = this.qLKSDataSet;
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dICH_VUTableAdapter
            // 
            this.dICH_VUTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(176, 172);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(432, 26);
            this.txt_Gia.TabIndex = 11;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(176, 138);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(432, 26);
            this.txt_Ten.TabIndex = 12;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(176, 105);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(434, 26);
            this.txt_ID.TabIndex = 13;
            // 
            // Frm_DICHVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_TaoMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DICHVU";
            this.Text = "Frm_DICHVU";
            this.Load += new System.EventHandler(this.Frm_DICHVU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private QLKSDataSetTableAdapters.DICH_VUTableAdapter dICH_VUTableAdapter;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.NumericUpDown txt_ID;
    }
}