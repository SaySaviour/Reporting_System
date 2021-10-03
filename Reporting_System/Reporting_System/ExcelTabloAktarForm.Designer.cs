namespace Reporting_System
{
    partial class ExcelTabloAktarForm
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
            this.TabloListeDataGrid = new System.Windows.Forms.DataGridView();
            this.TabloComboBox = new MetroSet_UI.Controls.MetroSetComboBox();
            this.TabloLable = new MetroSet_UI.Controls.MetroSetLabel();
            this.ExcelAktarButton = new MetroSet_UI.Controls.MetroSetButton();
            this.tablo_AktarGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TabloListeDataGrid)).BeginInit();
            this.tablo_AktarGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabloListeDataGrid
            // 
            this.TabloListeDataGrid.AllowUserToAddRows = false;
            this.TabloListeDataGrid.AllowUserToDeleteRows = false;
            this.TabloListeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabloListeDataGrid.Location = new System.Drawing.Point(14, 267);
            this.TabloListeDataGrid.Name = "TabloListeDataGrid";
            this.TabloListeDataGrid.ReadOnly = true;
            this.TabloListeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabloListeDataGrid.Size = new System.Drawing.Size(377, 223);
            this.TabloListeDataGrid.TabIndex = 0;
            // 
            // TabloComboBox
            // 
            this.TabloComboBox.AllowDrop = true;
            this.TabloComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TabloComboBox.BackColor = System.Drawing.Color.Transparent;
            this.TabloComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabloComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TabloComboBox.CausesValidation = false;
            this.TabloComboBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TabloComboBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TabloComboBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TabloComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TabloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TabloComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TabloComboBox.FormattingEnabled = true;
            this.TabloComboBox.IsDerivedStyle = true;
            this.TabloComboBox.ItemHeight = 20;
            this.TabloComboBox.Items.AddRange(new object[] {
            "User Login Table",
            "Product Buy Table",
            "Product Sell Table",
            "Product Information Table"});
            this.TabloComboBox.Location = new System.Drawing.Point(95, 43);
            this.TabloComboBox.Name = "TabloComboBox";
            this.TabloComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TabloComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.TabloComboBox.Size = new System.Drawing.Size(160, 26);
            this.TabloComboBox.Style = MetroSet_UI.Enums.Style.Light;
            this.TabloComboBox.StyleManager = null;
            this.TabloComboBox.TabIndex = 1;
            this.TabloComboBox.ThemeAuthor = "Narwin";
            this.TabloComboBox.ThemeName = "MetroLite";
            this.TabloComboBox.SelectedIndexChanged += new System.EventHandler(this.TabloComboBox_SelectedIndexChanged);
            // 
            // TabloLable
            // 
            this.TabloLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TabloLable.IsDerivedStyle = true;
            this.TabloLable.Location = new System.Drawing.Point(138, 17);
            this.TabloLable.Name = "TabloLable";
            this.TabloLable.Size = new System.Drawing.Size(100, 23);
            this.TabloLable.Style = MetroSet_UI.Enums.Style.Light;
            this.TabloLable.StyleManager = null;
            this.TabloLable.TabIndex = 2;
            this.TabloLable.Text = "Tablolar";
            this.TabloLable.ThemeAuthor = "Narwin";
            this.TabloLable.ThemeName = "MetroLite";
            // 
            // ExcelAktarButton
            // 
            this.ExcelAktarButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelAktarButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelAktarButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.ExcelAktarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExcelAktarButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ExcelAktarButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ExcelAktarButton.HoverTextColor = System.Drawing.Color.White;
            this.ExcelAktarButton.IsDerivedStyle = true;
            this.ExcelAktarButton.Location = new System.Drawing.Point(96, 84);
            this.ExcelAktarButton.Name = "ExcelAktarButton";
            this.ExcelAktarButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelAktarButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelAktarButton.NormalTextColor = System.Drawing.Color.White;
            this.ExcelAktarButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ExcelAktarButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ExcelAktarButton.PressTextColor = System.Drawing.Color.White;
            this.ExcelAktarButton.Size = new System.Drawing.Size(159, 26);
            this.ExcelAktarButton.Style = MetroSet_UI.Enums.Style.Light;
            this.ExcelAktarButton.StyleManager = null;
            this.ExcelAktarButton.TabIndex = 3;
            this.ExcelAktarButton.Text = "Tabloyu Excele Aktar";
            this.ExcelAktarButton.ThemeAuthor = "Narwin";
            this.ExcelAktarButton.ThemeName = "MetroLite";
            this.ExcelAktarButton.Click += new System.EventHandler(this.ExcelAktarButton_Click);
            // 
            // tablo_AktarGroupBox
            // 
            this.tablo_AktarGroupBox.Controls.Add(this.ExcelAktarButton);
            this.tablo_AktarGroupBox.Controls.Add(this.TabloComboBox);
            this.tablo_AktarGroupBox.Controls.Add(this.TabloLable);
            this.tablo_AktarGroupBox.Location = new System.Drawing.Point(14, 130);
            this.tablo_AktarGroupBox.Name = "tablo_AktarGroupBox";
            this.tablo_AktarGroupBox.Size = new System.Drawing.Size(377, 131);
            this.tablo_AktarGroupBox.TabIndex = 4;
            this.tablo_AktarGroupBox.TabStop = false;
            this.tablo_AktarGroupBox.Text = "Tabloyu Excele Aktar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcToolStripMenuItem,
            this.kaydetToolStripMenuItem1,
            this.farklıKaydetToolStripMenuItem,
            this.çıkToolStripMenuItem});
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.açToolStripMenuItem.Text = "Dosya";
            // 
            // AcToolStripMenuItem
            // 
            this.AcToolStripMenuItem.Name = "AcToolStripMenuItem";
            this.AcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AcToolStripMenuItem.Text = "Aç";
            this.AcToolStripMenuItem.Click += new System.EventHandler(this.AcToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem1
            // 
            this.kaydetToolStripMenuItem1.Name = "kaydetToolStripMenuItem1";
            this.kaydetToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem1.Text = "Kaydet";
            this.kaydetToolStripMenuItem1.Click += new System.EventHandler(this.kaydetToolStripMenuItem1_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // çıkToolStripMenuItem
            // 
            this.çıkToolStripMenuItem.Name = "çıkToolStripMenuItem";
            this.çıkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkToolStripMenuItem.Text = "Çık";
            this.çıkToolStripMenuItem.Click += new System.EventHandler(this.Cik_MenuStrip_Cliick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ExcelTabloAktarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 502);
            this.Controls.Add(this.tablo_AktarGroupBox);
            this.Controls.Add(this.TabloListeDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ExcelTabloAktarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel_Icerik";
            ((System.ComponentModel.ISupportInitialize)(this.TabloListeDataGrid)).EndInit();
            this.tablo_AktarGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TabloListeDataGrid;
        private MetroSet_UI.Controls.MetroSetComboBox TabloComboBox;
        private MetroSet_UI.Controls.MetroSetLabel TabloLable;
        private MetroSet_UI.Controls.MetroSetButton ExcelAktarButton;
        private System.Windows.Forms.GroupBox tablo_AktarGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}