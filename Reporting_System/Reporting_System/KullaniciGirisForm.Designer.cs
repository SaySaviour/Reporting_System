namespace Reporting_System
{
    partial class KullaniciGirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sifre_TextBox = new System.Windows.Forms.TextBox();
            this.K_Adi_TextBox = new System.Windows.Forms.TextBox();
            this.K_Adi_Label = new System.Windows.Forms.Label();
            this.Sifre_Label = new System.Windows.Forms.Label();
            this.ParolaGosterSwitch = new MetroSet_UI.Controls.MetroSetSwitch();
            this.Giris_Button = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.kayitOl_Btn = new MetroSet_UI.Controls.MetroSetButton();
            this.cikisBttn = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // Sifre_TextBox
            // 
            this.Sifre_TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sifre_TextBox.Location = new System.Drawing.Point(116, 140);
            this.Sifre_TextBox.MaxLength = 16;
            this.Sifre_TextBox.Name = "Sifre_TextBox";
            this.Sifre_TextBox.Size = new System.Drawing.Size(149, 27);
            this.Sifre_TextBox.TabIndex = 1;
            // 
            // K_Adi_TextBox
            // 
            this.K_Adi_TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.K_Adi_TextBox.Location = new System.Drawing.Point(116, 98);
            this.K_Adi_TextBox.MaxLength = 30;
            this.K_Adi_TextBox.Name = "K_Adi_TextBox";
            this.K_Adi_TextBox.Size = new System.Drawing.Size(149, 27);
            this.K_Adi_TextBox.TabIndex = 1;
            // 
            // K_Adi_Label
            // 
            this.K_Adi_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.K_Adi_Label.AutoSize = true;
            this.K_Adi_Label.ForeColor = System.Drawing.Color.Maroon;
            this.K_Adi_Label.Location = new System.Drawing.Point(2, 101);
            this.K_Adi_Label.Name = "K_Adi_Label";
            this.K_Adi_Label.Size = new System.Drawing.Size(108, 22);
            this.K_Adi_Label.TabIndex = 2;
            this.K_Adi_Label.Text = "Kullanıcı Adı";
            // 
            // Sifre_Label
            // 
            this.Sifre_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sifre_Label.AutoSize = true;
            this.Sifre_Label.ForeColor = System.Drawing.Color.Maroon;
            this.Sifre_Label.Location = new System.Drawing.Point(48, 145);
            this.Sifre_Label.Name = "Sifre_Label";
            this.Sifre_Label.Size = new System.Drawing.Size(47, 22);
            this.Sifre_Label.TabIndex = 2;
            this.Sifre_Label.Text = "Şifre";
            // 
            // ParolaGosterSwitch
            // 
            this.ParolaGosterSwitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParolaGosterSwitch.BackColor = System.Drawing.Color.Transparent;
            this.ParolaGosterSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.ParolaGosterSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.ParolaGosterSwitch.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ParolaGosterSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.ParolaGosterSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParolaGosterSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.ParolaGosterSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ParolaGosterSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.ParolaGosterSwitch.IsDerivedStyle = true;
            this.ParolaGosterSwitch.Location = new System.Drawing.Point(271, 145);
            this.ParolaGosterSwitch.Name = "ParolaGosterSwitch";
            this.ParolaGosterSwitch.Size = new System.Drawing.Size(58, 22);
            this.ParolaGosterSwitch.Style = MetroSet_UI.Enums.Style.Light;
            this.ParolaGosterSwitch.StyleManager = null;
            this.ParolaGosterSwitch.Switched = false;
            this.ParolaGosterSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ParolaGosterSwitch.TabIndex = 5;
            this.ParolaGosterSwitch.Text = "metroSetSwitch1";
            this.ParolaGosterSwitch.ThemeAuthor = "Narwin";
            this.ParolaGosterSwitch.ThemeName = "MetroLite";
            this.ParolaGosterSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ParolaGosterSwitch.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.ParolaGosterSwitch_SwitchedChanged);
            // 
            // Giris_Button
            // 
            this.Giris_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Giris_Button.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Giris_Button.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Giris_Button.DisabledForeColor = System.Drawing.Color.Gray;
            this.Giris_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris_Button.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Giris_Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Giris_Button.HoverTextColor = System.Drawing.Color.White;
            this.Giris_Button.IsDerivedStyle = true;
            this.Giris_Button.Location = new System.Drawing.Point(166, 180);
            this.Giris_Button.Name = "Giris_Button";
            this.Giris_Button.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Giris_Button.NormalColor = System.Drawing.Color.DeepSkyBlue;
            this.Giris_Button.NormalTextColor = System.Drawing.Color.White;
            this.Giris_Button.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Giris_Button.PressColor = System.Drawing.Color.Lime;
            this.Giris_Button.PressTextColor = System.Drawing.Color.White;
            this.Giris_Button.Size = new System.Drawing.Size(99, 40);
            this.Giris_Button.Style = MetroSet_UI.Enums.Style.Custom;
            this.Giris_Button.StyleManager = null;
            this.Giris_Button.TabIndex = 6;
            this.Giris_Button.Text = "Giriş";
            this.Giris_Button.ThemeAuthor = "Narwin";
            this.Giris_Button.ThemeName = "MetroLite";
            this.Giris_Button.Click += new System.EventHandler(this.Giris_Button_Click);
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.IsDerivedStyle = true;
            this.metroSetButton1.Location = new System.Drawing.Point(27, 223);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(124, 25);
            this.metroSetButton1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 7;
            this.metroSetButton1.Text = "Şifremi Unuttum";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // kayitOl_Btn
            // 
            this.kayitOl_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kayitOl_Btn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.kayitOl_Btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.kayitOl_Btn.DisabledForeColor = System.Drawing.Color.Gray;
            this.kayitOl_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kayitOl_Btn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.kayitOl_Btn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.kayitOl_Btn.HoverTextColor = System.Drawing.Color.White;
            this.kayitOl_Btn.IsDerivedStyle = true;
            this.kayitOl_Btn.Location = new System.Drawing.Point(27, 181);
            this.kayitOl_Btn.Name = "kayitOl_Btn";
            this.kayitOl_Btn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.kayitOl_Btn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.kayitOl_Btn.NormalTextColor = System.Drawing.Color.White;
            this.kayitOl_Btn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.kayitOl_Btn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.kayitOl_Btn.PressTextColor = System.Drawing.Color.White;
            this.kayitOl_Btn.Size = new System.Drawing.Size(124, 39);
            this.kayitOl_Btn.Style = MetroSet_UI.Enums.Style.Light;
            this.kayitOl_Btn.StyleManager = null;
            this.kayitOl_Btn.TabIndex = 8;
            this.kayitOl_Btn.Text = "Kayıt Ol";
            this.kayitOl_Btn.ThemeAuthor = "Narwin";
            this.kayitOl_Btn.ThemeName = "MetroLite";
            this.kayitOl_Btn.Click += new System.EventHandler(this.kayitOl_Btn_Click);
            // 
            // cikisBttn
            // 
            this.cikisBttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cikisBttn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cikisBttn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cikisBttn.DisabledForeColor = System.Drawing.Color.Gray;
            this.cikisBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cikisBttn.HoverBorderColor = System.Drawing.Color.Red;
            this.cikisBttn.HoverColor = System.Drawing.Color.Red;
            this.cikisBttn.HoverTextColor = System.Drawing.Color.White;
            this.cikisBttn.IsDerivedStyle = true;
            this.cikisBttn.Location = new System.Drawing.Point(293, 2);
            this.cikisBttn.Name = "cikisBttn";
            this.cikisBttn.NormalBorderColor = System.Drawing.Color.Red;
            this.cikisBttn.NormalColor = System.Drawing.Color.Red;
            this.cikisBttn.NormalTextColor = System.Drawing.Color.White;
            this.cikisBttn.PressBorderColor = System.Drawing.Color.Black;
            this.cikisBttn.PressColor = System.Drawing.Color.Black;
            this.cikisBttn.PressTextColor = System.Drawing.Color.White;
            this.cikisBttn.Size = new System.Drawing.Size(36, 29);
            this.cikisBttn.Style = MetroSet_UI.Enums.Style.Light;
            this.cikisBttn.StyleManager = null;
            this.cikisBttn.TabIndex = 9;
            this.cikisBttn.Text = "X";
            this.cikisBttn.ThemeAuthor = "Narwin";
            this.cikisBttn.ThemeName = "MetroLite";
            this.cikisBttn.Click += new System.EventHandler(this.cikisBttn_Click);
            // 
            // KullaniciGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.ControlBox = false;
            this.Controls.Add(this.cikisBttn);
            this.Controls.Add(this.kayitOl_Btn);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.Giris_Button);
            this.Controls.Add(this.ParolaGosterSwitch);
            this.Controls.Add(this.Sifre_Label);
            this.Controls.Add(this.K_Adi_Label);
            this.Controls.Add(this.K_Adi_TextBox);
            this.Controls.Add(this.Sifre_TextBox);
            this.Name = "KullaniciGirisForm";
            this.SmallLineColor1 = System.Drawing.Color.Red;
            this.SmallLineColor2 = System.Drawing.Color.Red;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Custom;
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Sifre_TextBox;
        private System.Windows.Forms.TextBox K_Adi_TextBox;
        private System.Windows.Forms.Label K_Adi_Label;
        private System.Windows.Forms.Label Sifre_Label;
        private MetroSet_UI.Controls.MetroSetSwitch ParolaGosterSwitch;
        private MetroSet_UI.Controls.MetroSetButton Giris_Button;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetButton kayitOl_Btn;
        private MetroSet_UI.Controls.MetroSetButton cikisBttn;
    }
}

