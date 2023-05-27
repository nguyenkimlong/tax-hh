namespace App_HoaDon_HaiHau.Screen
{
    partial class ucTaxXML
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.lblTongTienThue = new System.Windows.Forms.Label();
            this.lblTongThanhTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridTotal = new System.Windows.Forms.DataGridView();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnNewData = new System.Windows.Forms.Button();
            this.btnNhapFile = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTongTienThanhToan);
            this.panel2.Controls.Add(this.lblTongTienThue);
            this.panel2.Controls.Add(this.lblTongThanhTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(220, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 51);
            this.panel2.TabIndex = 13;
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.AutoSize = true;
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(673, 17);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(0, 20);
            this.lblTongTienThanhToan.TabIndex = 5;
            // 
            // lblTongTienThue
            // 
            this.lblTongTienThue.AutoSize = true;
            this.lblTongTienThue.Location = new System.Drawing.Point(392, 17);
            this.lblTongTienThue.Name = "lblTongTienThue";
            this.lblTongTienThue.Size = new System.Drawing.Size(0, 20);
            this.lblTongTienThue.TabIndex = 4;
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.AutoSize = true;
            this.lblTongThanhTien.Location = new System.Drawing.Point(135, 17);
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(0, 20);
            this.lblTongThanhTien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Tiền Thanh Toán: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng Tiền Thuế:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Thành Tiền: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridTotal);
            this.groupBox1.Location = new System.Drawing.Point(205, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 226);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm các hóa đơn";
            // 
            // dataGridTotal
            // 
            this.dataGridTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTotal.Location = new System.Drawing.Point(6, 26);
            this.dataGridTotal.Name = "dataGridTotal";
            this.dataGridTotal.RowHeadersWidth = 51;
            this.dataGridTotal.RowTemplate.Height = 29;
            this.dataGridTotal.Size = new System.Drawing.Size(1029, 188);
            this.dataGridTotal.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(205, 91);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.Size = new System.Drawing.Size(1035, 254);
            this.dataGrid.TabIndex = 8;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatFile.Location = new System.Drawing.Point(1145, 640);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(101, 29);
            this.btnXuatFile.TabIndex = 10;
            this.btnXuatFile.Text = "Xuất Excel";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnNewData
            // 
            this.btnNewData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewData.Location = new System.Drawing.Point(1145, 47);
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(101, 29);
            this.btnNewData.TabIndex = 11;
            this.btnNewData.Text = "Làm mới";
            this.btnNewData.UseVisualStyleBackColor = true;
            this.btnNewData.Click += new System.EventHandler(this.btnNewData_Click);
            // 
            // btnNhapFile
            // 
            this.btnNhapFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapFile.Location = new System.Drawing.Point(1035, 47);
            this.btnNhapFile.Name = "btnNhapFile";
            this.btnNhapFile.Size = new System.Drawing.Size(102, 29);
            this.btnNhapFile.TabIndex = 9;
            this.btnNhapFile.Text = "Nhập File";
            this.btnNhapFile.UseVisualStyleBackColor = true;
            this.btnNhapFile.Click += new System.EventHandler(this.btnNhapFile_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(283, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(251, 36);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Nhập Dữ Liệu Hóa Đơn";
            // 
            // ucTaxXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnNewData);
            this.Controls.Add(this.btnNhapFile);
            this.Name = "ucTaxXML";
            this.Size = new System.Drawing.Size(1529, 716);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label lblTongTienThanhToan;
        private Label lblTongTienThue;
        private Label lblTongThanhTien;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridTotal;
        private DataGridView dataGrid;
        private Button btnXuatFile;
        private Button btnNewData;
        private Button btnNhapFile;
        private Label lbTitle;
    }
}
