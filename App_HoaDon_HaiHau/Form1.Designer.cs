namespace App_HoaDon_HaiHau
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDsCongTy = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(808, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(251, 36);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Công Nợ Hóa Đơn";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 5;
            // 
            // btnDsCongTy
            // 
            this.btnDsCongTy.Location = new System.Drawing.Point(3, 38);
            this.btnDsCongTy.Name = "btnDsCongTy";
            this.btnDsCongTy.Size = new System.Drawing.Size(191, 29);
            this.btnDsCongTy.TabIndex = 8;
            this.btnDsCongTy.Text = "Danh Sách Công Ty";
            this.btnDsCongTy.UseVisualStyleBackColor = true;
            this.btnDsCongTy.Click += new System.EventHandler(this.btnDsCongTy_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Location = new System.Drawing.Point(3, 3);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(191, 29);
            this.btnXuatHoaDon.TabIndex = 9;
            this.btnXuatHoaDon.Text = "Xuất Hóa Đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Location = new System.Drawing.Point(215, 98);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(1537, 598);
            this.panelUser.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXuatHoaDon);
            this.panel2.Controls.Add(this.btnDsCongTy);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 598);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Thuế";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private Panel panel1;
        private Button btnDsCongTy;
        private Button btnXuatHoaDon;
        private Panel panelUser;
        private Panel panel2;
    }
}