namespace App_HoaDon_HaiHau.Screen
{
    partial class ucHoaDonGTGT
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportDuLieu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(454, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Web";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.Size = new System.Drawing.Size(1156, 360);
            this.dataGrid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid);
            this.panel1.Location = new System.Drawing.Point(3, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 360);
            this.panel1.TabIndex = 2;
            // 
            // btnImportDuLieu
            // 
            this.btnImportDuLieu.Location = new System.Drawing.Point(1016, 150);
            this.btnImportDuLieu.Name = "btnImportDuLieu";
            this.btnImportDuLieu.Size = new System.Drawing.Size(143, 29);
            this.btnImportDuLieu.TabIndex = 3;
            this.btnImportDuLieu.Text = "Import Dữ Liệu";
            this.btnImportDuLieu.UseVisualStyleBackColor = true;
            this.btnImportDuLieu.Click += new System.EventHandler(this.btnImportDuLieu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(995, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lưu Dữ Liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucHoaDonGTGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImportDuLieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ucHoaDonGTGT";
            this.Size = new System.Drawing.Size(1162, 587);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGrid;
        private Panel panel1;
        private Button btnImportDuLieu;
        private Button button1;
    }
}
