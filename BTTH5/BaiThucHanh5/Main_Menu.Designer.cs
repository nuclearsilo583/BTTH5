namespace BaiThucHanh5
{
    partial class Main_Menu
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
            this.Old = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Label();
            this.Subtracted = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.VatTotal = new System.Windows.Forms.Label();
            this.TinhTien = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Label();
            this.OldText = new System.Windows.Forms.TextBox();
            this.NewText = new System.Windows.Forms.TextBox();
            this.Subtracted_Text = new System.Windows.Forms.TextBox();
            this.ToTalText = new System.Windows.Forms.TextBox();
            this.VAT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Old
            // 
            this.Old.AutoSize = true;
            this.Old.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Old.Location = new System.Drawing.Point(50, 142);
            this.Old.Name = "Old";
            this.Old.Size = new System.Drawing.Size(85, 22);
            this.Old.TabIndex = 0;
            this.Old.Text = "Chỉ số cũ";
            this.Old.Click += new System.EventHandler(this.Old_Click);
            // 
            // New
            // 
            this.New.AutoSize = true;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.New.Location = new System.Drawing.Point(50, 181);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(94, 22);
            this.New.TabIndex = 0;
            this.New.Text = "Chỉ số mới";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Subtracted
            // 
            this.Subtracted.AutoSize = true;
            this.Subtracted.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Subtracted.Location = new System.Drawing.Point(50, 224);
            this.Subtracted.Name = "Subtracted";
            this.Subtracted.Size = new System.Drawing.Size(156, 22);
            this.Subtracted.TabIndex = 3;
            this.Subtracted.Text = "Điện năng tiêu thụ";
            this.Subtracted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Subtracted.Click += new System.EventHandler(this.DaSuDung_Text);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Total.Location = new System.Drawing.Point(50, 264);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(96, 22);
            this.Total.TabIndex = 3;
            this.Total.Text = "Thành tiền";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // VatTotal
            // 
            this.VatTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.VatTotal.Location = new System.Drawing.Point(50, 302);
            this.VatTotal.Name = "VatTotal";
            this.VatTotal.Size = new System.Drawing.Size(186, 27);
            this.VatTotal.TabIndex = 13;
            this.VatTotal.Text = "Tổng tiền đã có VAT";
            this.VatTotal.TextChanged += new System.EventHandler(this.VAT_Click);
            // 
            // TinhTien
            // 
            this.TinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.TinhTien.Location = new System.Drawing.Point(54, 381);
            this.TinhTien.Name = "TinhTien";
            this.TinhTien.Size = new System.Drawing.Size(152, 39);
            this.TinhTien.TabIndex = 5;
            this.TinhTien.Text = "Tính tiền điện";
            this.TinhTien.UseVisualStyleBackColor = true;
            this.TinhTien.Click += new System.EventHandler(this.TinhTien_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Reset.Location = new System.Drawing.Point(238, 381);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(133, 39);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Tiếp tục";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Exit.Location = new System.Drawing.Point(401, 381);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 39);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Menu.Location = new System.Drawing.Point(144, 53);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(304, 25);
            this.Menu.TabIndex = 8;
            this.Menu.Text = "Tính tiền điện sinh hoạt bậc thang";
            // 
            // OldText
            // 
            this.OldText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.OldText.Location = new System.Drawing.Point(336, 142);
            this.OldText.Name = "OldText";
            this.OldText.Size = new System.Drawing.Size(173, 27);
            this.OldText.TabIndex = 9;
            this.OldText.TextChanged += new System.EventHandler(this.Nhap_Text);
            // 
            // NewText
            // 
            this.NewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.NewText.Location = new System.Drawing.Point(336, 181);
            this.NewText.Name = "NewText";
            this.NewText.Size = new System.Drawing.Size(173, 27);
            this.NewText.TabIndex = 10;
            this.NewText.TextChanged += new System.EventHandler(this.SuDung_Text);
            // 
            // Subtracted_Text
            // 
            this.Subtracted_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Subtracted_Text.Location = new System.Drawing.Point(336, 224);
            this.Subtracted_Text.Name = "Subtracted_Text";
            this.Subtracted_Text.Size = new System.Drawing.Size(173, 27);
            this.Subtracted_Text.TabIndex = 11;
            this.Subtracted_Text.TextChanged += new System.EventHandler(this.DaSuDung_Text);
            // 
            // ToTalText
            // 
            this.ToTalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ToTalText.Location = new System.Drawing.Point(336, 264);
            this.ToTalText.Name = "ToTalText";
            this.ToTalText.Size = new System.Drawing.Size(173, 27);
            this.ToTalText.TabIndex = 12;
            this.ToTalText.TextChanged += new System.EventHandler(this.ToTal_Text);
            // 
            // VAT
            // 
            this.VAT.Location = new System.Drawing.Point(336, 302);
            this.VAT.Multiline = true;
            this.VAT.Name = "VAT";
            this.VAT.Size = new System.Drawing.Size(173, 27);
            this.VAT.TabIndex = 14;
            this.VAT.TextChanged += new System.EventHandler(this.VAT_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.Old);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Subtracted);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.VatTotal);
            this.Controls.Add(this.TinhTien);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.OldText);
            this.Controls.Add(this.NewText);
            this.Controls.Add(this.Subtracted_Text);
            this.Controls.Add(this.ToTalText);
            this.Controls.Add(this.VAT);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Text = "BT TH5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Old;
        private System.Windows.Forms.Label New;
        private System.Windows.Forms.Label Subtracted;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label VatTotal;
        private System.Windows.Forms.Button TinhTien;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.TextBox OldText;
        private System.Windows.Forms.TextBox NewText;
        private System.Windows.Forms.TextBox Subtracted_Text;
        private System.Windows.Forms.TextBox ToTalText;
        private System.Windows.Forms.TextBox VAT;
    }
}

