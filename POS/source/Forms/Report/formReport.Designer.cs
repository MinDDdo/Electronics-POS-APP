
namespace POS
{
    partial class formReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.DGVReport = new System.Windows.Forms.DataGridView();
            this.btnGenReport = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Label();
            this.dtPick = new System.Windows.Forms.DateTimePicker();
            this.comboReportType = new System.Windows.Forms.ComboBox();
            this.comboReportDur = new System.Windows.Forms.ComboBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.comboReportDur);
            this.groupBox1.Controls.Add(this.comboReportType);
            this.groupBox1.Controls.Add(this.btnGenReport);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(817, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 426);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(817, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 107);
            this.panel1.TabIndex = 15;
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(89, 61);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(167, 35);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Print";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(65, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(167, 35);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // lblLogout
            // 
            this.lblLogout.BackColor = System.Drawing.Color.DimGray;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(817, 573);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(259, 34);
            this.lblLogout.TabIndex = 16;
            this.lblLogout.Text = "Log out";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // DGVReport
            // 
            this.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReport.Location = new System.Drawing.Point(23, 136);
            this.DGVReport.Name = "DGVReport";
            this.DGVReport.RowHeadersWidth = 51;
            this.DGVReport.RowTemplate.Height = 24;
            this.DGVReport.Size = new System.Drawing.Size(775, 471);
            this.DGVReport.TabIndex = 17;
            // 
            // btnGenReport
            // 
            this.btnGenReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGenReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenReport.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenReport.ForeColor = System.Drawing.Color.Black;
            this.btnGenReport.Location = new System.Drawing.Point(40, 51);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(192, 34);
            this.btnGenReport.TabIndex = 18;
            this.btnGenReport.Text = "SHOW REPORT";
            this.btnGenReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(40, 114);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(192, 34);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "EXPORT TO EXCEL";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dtPick
            // 
            this.dtPick.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPick.Location = new System.Drawing.Point(44, 79);
            this.dtPick.Name = "dtPick";
            this.dtPick.Size = new System.Drawing.Size(203, 32);
            this.dtPick.TabIndex = 19;
            // 
            // comboReportType
            // 
            this.comboReportType.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboReportType.FormattingEnabled = true;
            this.comboReportType.Items.AddRange(new object[] {
            "Net Sale",
            "Net Profit"});
            this.comboReportType.Location = new System.Drawing.Point(29, 187);
            this.comboReportType.Name = "comboReportType";
            this.comboReportType.Size = new System.Drawing.Size(203, 32);
            this.comboReportType.TabIndex = 18;
            this.comboReportType.Text = "Choose report";
            // 
            // comboReportDur
            // 
            this.comboReportDur.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboReportDur.FormattingEnabled = true;
            this.comboReportDur.Items.AddRange(new object[] {
            "Dayly",
            "Weekly",
            "Mountly",
            "Yearly"});
            this.comboReportDur.Location = new System.Drawing.Point(29, 252);
            this.comboReportDur.Name = "comboReportDur";
            this.comboReportDur.Size = new System.Drawing.Size(203, 32);
            this.comboReportDur.TabIndex = 18;
            this.comboReportDur.Text = "Report duration";
            this.comboReportDur.SelectedIndexChanged += new System.EventHandler(this.comboReportDur_SelectedIndexChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(39, 49);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(124, 26);
            this.lbldate.TabIndex = 20;
            this.lbldate.Text = "month / day / year";
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1104, 635);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.dtPick);
            this.Controls.Add(this.DGVReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLogout);
            this.Name = "formReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formReport";
            this.Load += new System.EventHandler(this.formReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label btnExport;
        private System.Windows.Forms.Label btnGenReport;
        private System.Windows.Forms.DataGridView DGVReport;
        private System.Windows.Forms.DateTimePicker dtPick;
        private System.Windows.Forms.ComboBox comboReportDur;
        private System.Windows.Forms.ComboBox comboReportType;
        private System.Windows.Forms.Label lbldate;
    }
}