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
            this.farkliKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel_Fonksiyon_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cikBttn = new MetroSet_UI.Controls.MetroSetButton();
            this.tablo_StunGroupBox = new System.Windows.Forms.GroupBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.Columns_CMBBX = new MetroSet_UI.Controls.MetroSetComboBox();
            this.Rows_CMBBX = new MetroSet_UI.Controls.MetroSetComboBox();
            this.TabloVeri_CMBBX = new MetroSet_UI.Controls.MetroSetComboBox();
            this.TabloAlan_CMBBX = new MetroSet_UI.Controls.MetroSetComboBox();
            this.TabloListe_CMBBX = new MetroSet_UI.Controls.MetroSetComboBox();
            this.ExcelT_AlanAktar_BTN = new MetroSet_UI.Controls.MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabloListeDataGrid)).BeginInit();
            this.tablo_AktarGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tablo_StunGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabloListeDataGrid
            // 
            this.TabloListeDataGrid.AllowUserToAddRows = false;
            this.TabloListeDataGrid.AllowUserToDeleteRows = false;
            this.TabloListeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabloListeDataGrid.Location = new System.Drawing.Point(12, 262);
            this.TabloListeDataGrid.Name = "TabloListeDataGrid";
            this.TabloListeDataGrid.ReadOnly = true;
            this.TabloListeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabloListeDataGrid.Size = new System.Drawing.Size(747, 223);
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
            this.TabloComboBox.Location = new System.Drawing.Point(34, 93);
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
            this.TabloLable.Location = new System.Drawing.Point(67, 65);
            this.TabloLable.Name = "TabloLable";
            this.TabloLable.Size = new System.Drawing.Size(100, 25);
            this.TabloLable.Style = MetroSet_UI.Enums.Style.Light;
            this.TabloLable.StyleManager = null;
            this.TabloLable.TabIndex = 2;
            this.TabloLable.Text = "Tablolar";
            this.TabloLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ExcelAktarButton.Location = new System.Drawing.Point(34, 125);
            this.ExcelAktarButton.Name = "ExcelAktarButton";
            this.ExcelAktarButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelAktarButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelAktarButton.NormalTextColor = System.Drawing.Color.White;
            this.ExcelAktarButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ExcelAktarButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ExcelAktarButton.PressTextColor = System.Drawing.Color.White;
            this.ExcelAktarButton.Size = new System.Drawing.Size(159, 28);
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
            this.tablo_AktarGroupBox.Location = new System.Drawing.Point(18, 33);
            this.tablo_AktarGroupBox.Name = "tablo_AktarGroupBox";
            this.tablo_AktarGroupBox.Size = new System.Drawing.Size(237, 212);
            this.tablo_AktarGroupBox.TabIndex = 4;
            this.tablo_AktarGroupBox.TabStop = false;
            this.tablo_AktarGroupBox.Text = "Tabloyu Excele Aktar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.excel_Fonksiyon_MenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcToolStripMenuItem,
            this.kaydetToolStripMenuItem1,
            this.farkliKaydetToolStripMenuItem,
            this.cikToolStripMenuItem});
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
            // farkliKaydetToolStripMenuItem
            // 
            this.farkliKaydetToolStripMenuItem.Name = "farkliKaydetToolStripMenuItem";
            this.farkliKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farkliKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farkliKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // cikToolStripMenuItem
            // 
            this.cikToolStripMenuItem.Name = "cikToolStripMenuItem";
            this.cikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cikToolStripMenuItem.Text = "Çık";
            this.cikToolStripMenuItem.Click += new System.EventHandler(this.Cik_MenuStrip_Cliick);
            // 
            // excel_Fonksiyon_MenuStrip
            // 
            this.excel_Fonksiyon_MenuStrip.Name = "excel_Fonksiyon_MenuStrip";
            this.excel_Fonksiyon_MenuStrip.Size = new System.Drawing.Size(103, 20);
            this.excel_Fonksiyon_MenuStrip.Text = "Excel Fonksiyon";
            this.excel_Fonksiyon_MenuStrip.Click += new System.EventHandler(this.excel_Fonksiyon_MenuStrip_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cikBttn
            // 
            this.cikBttn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cikBttn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cikBttn.DisabledForeColor = System.Drawing.Color.Gray;
            this.cikBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cikBttn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cikBttn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.cikBttn.HoverTextColor = System.Drawing.Color.White;
            this.cikBttn.IsDerivedStyle = true;
            this.cikBttn.Location = new System.Drawing.Point(725, 0);
            this.cikBttn.Name = "cikBttn";
            this.cikBttn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cikBttn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cikBttn.NormalTextColor = System.Drawing.Color.White;
            this.cikBttn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cikBttn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.cikBttn.PressTextColor = System.Drawing.Color.White;
            this.cikBttn.Size = new System.Drawing.Size(34, 30);
            this.cikBttn.Style = MetroSet_UI.Enums.Style.Light;
            this.cikBttn.StyleManager = null;
            this.cikBttn.TabIndex = 8;
            this.cikBttn.Text = "X";
            this.cikBttn.ThemeAuthor = "Narwin";
            this.cikBttn.ThemeName = "MetroLite";
            this.cikBttn.Click += new System.EventHandler(this.cikBttn_Click);
            // 
            // tablo_StunGroupBox
            // 
            this.tablo_StunGroupBox.Controls.Add(this.metroSetLabel4);
            this.tablo_StunGroupBox.Controls.Add(this.metroSetLabel3);
            this.tablo_StunGroupBox.Controls.Add(this.metroSetLabel5);
            this.tablo_StunGroupBox.Controls.Add(this.metroSetLabel2);
            this.tablo_StunGroupBox.Controls.Add(this.metroSetLabel1);
            this.tablo_StunGroupBox.Controls.Add(this.Columns_CMBBX);
            this.tablo_StunGroupBox.Controls.Add(this.Rows_CMBBX);
            this.tablo_StunGroupBox.Controls.Add(this.TabloVeri_CMBBX);
            this.tablo_StunGroupBox.Controls.Add(this.TabloAlan_CMBBX);
            this.tablo_StunGroupBox.Controls.Add(this.TabloListe_CMBBX);
            this.tablo_StunGroupBox.Controls.Add(this.ExcelT_AlanAktar_BTN);
            this.tablo_StunGroupBox.Location = new System.Drawing.Point(261, 33);
            this.tablo_StunGroupBox.Name = "tablo_StunGroupBox";
            this.tablo_StunGroupBox.Size = new System.Drawing.Size(498, 218);
            this.tablo_StunGroupBox.TabIndex = 9;
            this.tablo_StunGroupBox.TabStop = false;
            this.tablo_StunGroupBox.Text = "Seçilen Satır-Sütuna Seçilen Veriyi Aktar";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(119, 130);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(47, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 2;
            this.metroSetLabel4.Text = "Sütun";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(35, 130);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(43, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 2;
            this.metroSetLabel3.Text = "Satır ";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(367, 40);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(84, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 2;
            this.metroSetLabel5.Text = "Tablo Verisi";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(215, 40);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(80, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 2;
            this.metroSetLabel2.Text = "Tablo Alanı";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(62, 40);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(60, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 2;
            this.metroSetLabel1.Text = "Tablolar";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // Columns_CMBBX
            // 
            this.Columns_CMBBX.AllowDrop = true;
            this.Columns_CMBBX.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Columns_CMBBX.BackColor = System.Drawing.Color.Transparent;
            this.Columns_CMBBX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Columns_CMBBX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Columns_CMBBX.CausesValidation = false;
            this.Columns_CMBBX.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Columns_CMBBX.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Columns_CMBBX.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Columns_CMBBX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Columns_CMBBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Columns_CMBBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Columns_CMBBX.FormattingEnabled = true;
            this.Columns_CMBBX.IsDerivedStyle = true;
            this.Columns_CMBBX.ItemHeight = 20;
            this.Columns_CMBBX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200"});
            this.Columns_CMBBX.Location = new System.Drawing.Point(102, 156);
            this.Columns_CMBBX.Name = "Columns_CMBBX";
            this.Columns_CMBBX.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Columns_CMBBX.SelectedItemForeColor = System.Drawing.Color.White;
            this.Columns_CMBBX.Size = new System.Drawing.Size(83, 26);
            this.Columns_CMBBX.Style = MetroSet_UI.Enums.Style.Light;
            this.Columns_CMBBX.StyleManager = null;
            this.Columns_CMBBX.TabIndex = 1;
            this.Columns_CMBBX.ThemeAuthor = "Narwin";
            this.Columns_CMBBX.ThemeName = "MetroLite";
            // 
            // Rows_CMBBX
            // 
            this.Rows_CMBBX.AllowDrop = true;
            this.Rows_CMBBX.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Rows_CMBBX.BackColor = System.Drawing.Color.Transparent;
            this.Rows_CMBBX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Rows_CMBBX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Rows_CMBBX.CausesValidation = false;
            this.Rows_CMBBX.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Rows_CMBBX.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Rows_CMBBX.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Rows_CMBBX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Rows_CMBBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rows_CMBBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Rows_CMBBX.FormattingEnabled = true;
            this.Rows_CMBBX.IsDerivedStyle = true;
            this.Rows_CMBBX.ItemHeight = 20;
            this.Rows_CMBBX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200"});
            this.Rows_CMBBX.Location = new System.Drawing.Point(16, 156);
            this.Rows_CMBBX.Name = "Rows_CMBBX";
            this.Rows_CMBBX.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Rows_CMBBX.SelectedItemForeColor = System.Drawing.Color.White;
            this.Rows_CMBBX.Size = new System.Drawing.Size(80, 26);
            this.Rows_CMBBX.Style = MetroSet_UI.Enums.Style.Light;
            this.Rows_CMBBX.StyleManager = null;
            this.Rows_CMBBX.TabIndex = 1;
            this.Rows_CMBBX.ThemeAuthor = "Narwin";
            this.Rows_CMBBX.ThemeName = "MetroLite";
            // 
            // TabloVeri_CMBBX
            // 
            this.TabloVeri_CMBBX.AllowDrop = true;
            this.TabloVeri_CMBBX.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TabloVeri_CMBBX.BackColor = System.Drawing.Color.Transparent;
            this.TabloVeri_CMBBX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabloVeri_CMBBX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TabloVeri_CMBBX.CausesValidation = false;
            this.TabloVeri_CMBBX.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TabloVeri_CMBBX.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TabloVeri_CMBBX.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TabloVeri_CMBBX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TabloVeri_CMBBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TabloVeri_CMBBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TabloVeri_CMBBX.FormattingEnabled = true;
            this.TabloVeri_CMBBX.IsDerivedStyle = true;
            this.TabloVeri_CMBBX.ItemHeight = 20;
            this.TabloVeri_CMBBX.Location = new System.Drawing.Point(333, 66);
            this.TabloVeri_CMBBX.Name = "TabloVeri_CMBBX";
            this.TabloVeri_CMBBX.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TabloVeri_CMBBX.SelectedItemForeColor = System.Drawing.Color.White;
            this.TabloVeri_CMBBX.Size = new System.Drawing.Size(146, 26);
            this.TabloVeri_CMBBX.Style = MetroSet_UI.Enums.Style.Light;
            this.TabloVeri_CMBBX.StyleManager = null;
            this.TabloVeri_CMBBX.TabIndex = 1;
            this.TabloVeri_CMBBX.ThemeAuthor = "Narwin";
            this.TabloVeri_CMBBX.ThemeName = "MetroLite";
            // 
            // TabloAlan_CMBBX
            // 
            this.TabloAlan_CMBBX.AllowDrop = true;
            this.TabloAlan_CMBBX.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TabloAlan_CMBBX.BackColor = System.Drawing.Color.Transparent;
            this.TabloAlan_CMBBX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabloAlan_CMBBX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TabloAlan_CMBBX.CausesValidation = false;
            this.TabloAlan_CMBBX.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TabloAlan_CMBBX.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TabloAlan_CMBBX.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TabloAlan_CMBBX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TabloAlan_CMBBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TabloAlan_CMBBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TabloAlan_CMBBX.FormattingEnabled = true;
            this.TabloAlan_CMBBX.IsDerivedStyle = true;
            this.TabloAlan_CMBBX.ItemHeight = 20;
            this.TabloAlan_CMBBX.Location = new System.Drawing.Point(181, 66);
            this.TabloAlan_CMBBX.Name = "TabloAlan_CMBBX";
            this.TabloAlan_CMBBX.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TabloAlan_CMBBX.SelectedItemForeColor = System.Drawing.Color.White;
            this.TabloAlan_CMBBX.Size = new System.Drawing.Size(146, 26);
            this.TabloAlan_CMBBX.Style = MetroSet_UI.Enums.Style.Light;
            this.TabloAlan_CMBBX.StyleManager = null;
            this.TabloAlan_CMBBX.TabIndex = 1;
            this.TabloAlan_CMBBX.ThemeAuthor = "Narwin";
            this.TabloAlan_CMBBX.ThemeName = "MetroLite";
            this.TabloAlan_CMBBX.SelectedIndexChanged += new System.EventHandler(this.TabloAlan_CMBBX_SelectedIndexChanged);
            // 
            // TabloListe_CMBBX
            // 
            this.TabloListe_CMBBX.AllowDrop = true;
            this.TabloListe_CMBBX.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TabloListe_CMBBX.BackColor = System.Drawing.Color.Transparent;
            this.TabloListe_CMBBX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabloListe_CMBBX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TabloListe_CMBBX.CausesValidation = false;
            this.TabloListe_CMBBX.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TabloListe_CMBBX.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TabloListe_CMBBX.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TabloListe_CMBBX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TabloListe_CMBBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TabloListe_CMBBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TabloListe_CMBBX.FormattingEnabled = true;
            this.TabloListe_CMBBX.IsDerivedStyle = true;
            this.TabloListe_CMBBX.ItemHeight = 20;
            this.TabloListe_CMBBX.Items.AddRange(new object[] {
            "User Login Table",
            "Product Buy Table",
            "Product Sell Table",
            "Product Information Table"});
            this.TabloListe_CMBBX.Location = new System.Drawing.Point(17, 66);
            this.TabloListe_CMBBX.Name = "TabloListe_CMBBX";
            this.TabloListe_CMBBX.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TabloListe_CMBBX.SelectedItemForeColor = System.Drawing.Color.White;
            this.TabloListe_CMBBX.Size = new System.Drawing.Size(158, 26);
            this.TabloListe_CMBBX.Style = MetroSet_UI.Enums.Style.Light;
            this.TabloListe_CMBBX.StyleManager = null;
            this.TabloListe_CMBBX.TabIndex = 1;
            this.TabloListe_CMBBX.ThemeAuthor = "Narwin";
            this.TabloListe_CMBBX.ThemeName = "MetroLite";
            this.TabloListe_CMBBX.SelectedIndexChanged += new System.EventHandler(this.TabloListe_CMBBX_SelectedIndexChanged);
            // 
            // ExcelT_AlanAktar_BTN
            // 
            this.ExcelT_AlanAktar_BTN.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelT_AlanAktar_BTN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelT_AlanAktar_BTN.DisabledForeColor = System.Drawing.Color.Gray;
            this.ExcelT_AlanAktar_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExcelT_AlanAktar_BTN.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ExcelT_AlanAktar_BTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ExcelT_AlanAktar_BTN.HoverTextColor = System.Drawing.Color.White;
            this.ExcelT_AlanAktar_BTN.IsDerivedStyle = true;
            this.ExcelT_AlanAktar_BTN.Location = new System.Drawing.Point(215, 128);
            this.ExcelT_AlanAktar_BTN.Name = "ExcelT_AlanAktar_BTN";
            this.ExcelT_AlanAktar_BTN.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelT_AlanAktar_BTN.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ExcelT_AlanAktar_BTN.NormalTextColor = System.Drawing.Color.White;
            this.ExcelT_AlanAktar_BTN.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ExcelT_AlanAktar_BTN.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.ExcelT_AlanAktar_BTN.PressTextColor = System.Drawing.Color.White;
            this.ExcelT_AlanAktar_BTN.Size = new System.Drawing.Size(264, 84);
            this.ExcelT_AlanAktar_BTN.Style = MetroSet_UI.Enums.Style.Light;
            this.ExcelT_AlanAktar_BTN.StyleManager = null;
            this.ExcelT_AlanAktar_BTN.TabIndex = 0;
            this.ExcelT_AlanAktar_BTN.Text = "Veriyi Excele Aktar";
            this.ExcelT_AlanAktar_BTN.ThemeAuthor = "Narwin";
            this.ExcelT_AlanAktar_BTN.ThemeName = "MetroLite";
            this.ExcelT_AlanAktar_BTN.Click += new System.EventHandler(this.ExcelT_AlanAktar_BTN_Click);
            // 
            // ExcelTabloAktarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 495);
            this.Controls.Add(this.tablo_StunGroupBox);
            this.Controls.Add(this.cikBttn);
            this.Controls.Add(this.tablo_AktarGroupBox);
            this.Controls.Add(this.TabloListeDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ExcelTabloAktarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel_Icerik";
            ((System.ComponentModel.ISupportInitialize)(this.TabloListeDataGrid)).EndInit();
            this.tablo_AktarGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tablo_StunGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem farkliKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem excel_Fonksiyon_MenuStrip;
        private MetroSet_UI.Controls.MetroSetButton cikBttn;
        private System.Windows.Forms.GroupBox tablo_StunGroupBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetComboBox Columns_CMBBX;
        private MetroSet_UI.Controls.MetroSetComboBox Rows_CMBBX;
        private MetroSet_UI.Controls.MetroSetComboBox TabloVeri_CMBBX;
        private MetroSet_UI.Controls.MetroSetComboBox TabloAlan_CMBBX;
        private MetroSet_UI.Controls.MetroSetComboBox TabloListe_CMBBX;
        private MetroSet_UI.Controls.MetroSetButton ExcelT_AlanAktar_BTN;
    }
}