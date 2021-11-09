
namespace QLKS
{
    partial class FrmBaoCao
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
            this.crvTest = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTest
            // 
            this.crvTest.ActiveViewIndex = -1;
            this.crvTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTest.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTest.Location = new System.Drawing.Point(0, 0);
            this.crvTest.Name = "crvTest";
            this.crvTest.Size = new System.Drawing.Size(800, 450);
            this.crvTest.TabIndex = 0;
            this.crvTest.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvTest);
            this.Name = "FrmBaoCao";
            this.Text = "FrmBaoCao";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTest;
    }
}