using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using Npgsql;

namespace Reporting_System
{
    public partial class ExcelTabloAktarForm : Form
    {
        public ExcelTabloAktarForm()
        {
            InitializeComponent();
        }
        Database_Process dtBaseProcss = new Database_Process();
        NpgsqlConnection baglan = new  Database_Process().db_Baglanti("localhost","db_Reporting_System","postgres","1234");
        Microsoft.Office.Interop.Excel.Application excel= new Microsoft.Office.Interop.Excel.Application();
        object missing = Type.Missing;
        Workbook workbook;
        Worksheet sheet1;
        Range range;
        bool durum=false;
        //int satir=1, sutun=1;
        private void ExcelAktarButton_Click(object sender, EventArgs e)
        {
            int starting_Column = 1;
            int start_Line = 1;
            int inHeaderLength = 3;
            if(durum==false)
            {
                workbook = excel.Workbooks.Add(missing);
                sheet1 = (Worksheet)workbook.Sheets[1];
            }
            
            start_Line++;
            Range cellRang = sheet1.get_Range("A1", "E3");
            cellRang.Merge(false);
            cellRang.Interior.Color = System.Drawing.Color.White;
            cellRang.Font.Color = System.Drawing.Color.Gray;
            cellRang.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            cellRang.VerticalAlignment = XlVAlign.xlVAlignCenter;
            cellRang.Font.Size = 26;
            sheet1.Cells[1, 1] = TabloComboBox.Text;
            //Style table column names
            cellRang = sheet1.get_Range("A1", "E4");
            cellRang.Font.Bold = true;
            cellRang.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            cellRang.Interior.Color = System.Drawing.ColorTranslator.FromHtml("#ED7D31");
            sheet1.get_Range("F4").EntireColumn.HorizontalAlignment = XlHAlign.xlHAlignRight;
            //Formate price column
            sheet1.get_Range("F5").EntireColumn.NumberFormat = "0.00";
            //Auto fit columns
            sheet1.Columns.AutoFit();
            for (int i = 0; i < dtBaseProcss.Db_Tables(TabloComboBox,baglan).Columns.Count; i++)
                sheet1.Cells[inHeaderLength + 1, i + 1] = dtBaseProcss.Db_Tables(TabloComboBox,baglan).Columns[i].ColumnName.ToUpper();
            for (int i = 0; i < dtBaseProcss.Db_Tables(TabloComboBox, baglan).Rows.Count; i++)
            {
                for (int j = 0; j < dtBaseProcss.Db_Tables(TabloComboBox,baglan).Columns.Count; j++)
                {
                    starting_Column = j + 1;
                    start_Line = inHeaderLength + 2 + i;
                    sheet1.Cells[start_Line,starting_Column] = dtBaseProcss.Db_Tables(TabloComboBox,baglan).Rows[i].ItemArray[j].ToString();
                    if (i % 2 == 0)
                        sheet1.get_Range("A" + start_Line.ToString(), "E" + start_Line.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#FCE4D6");
                }
            }
            excel.Visible = true;
        }
        private void TabloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabloListeDataGrid.DataSource = dtBaseProcss.Db_Tables(TabloComboBox, baglan).DefaultView;
        }
        private void Cik_MenuStrip_Cliick(object sender, EventArgs e)
        {
            KullaniciGirisForm kgirisfrm = new KullaniciGirisForm();
            this.Close();
            kgirisfrm.Show();
        }

        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                workbook.SaveAs("Reporting_System.xlsx", XlFileFormat.xlWorkbookDefault, missing, missing, false, missing, XlSaveAsAccessMode.xlNoChange);
                workbook.Close(true, missing, missing);
                excel.Quit();
                MessageBox.Show("Dosya Başarıyla Kaydedildi.");
            }
            catch
            {

                MessageBox.Show("Uygulama Açık Olmalıdır.", "Uygulama Kaydet Hata");
            }
            
        }
        private void AcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durum = true;
            openFileDialog1.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            DialogResult result = openFileDialog1.ShowDialog();
            workbook = excel.Workbooks.Open(openFileDialog1.FileName);
            sheet1 = (Worksheet)workbook.Sheets[1];
            range = sheet1.UsedRange;
            sheet1 = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            excel.AlertBeforeOverwriting = false;
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
                workbook.SaveCopyAs(saveFileDialog1.FileName);
                workbook.Close(true, missing, missing);
                excel.Quit();
                MessageBox.Show("Dosya Başarıyla Kaydedildi.");
            }
            catch
            {

                MessageBox.Show("Uygulama Açık Olmalıdır.", "Uygulama Kaydet Hata");
            }
        }

        private void cikBttn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ExcelT_AlanAktar_BTN_Click(object sender, EventArgs e)
        {
            if (TabloListe_CMBBX.Text != "" && TabloAlan_CMBBX.Text != "" && TabloVeri_CMBBX.Text != "")
            {
                if (Rows_CMBBX.Text != "" && Columns_CMBBX.Text != "")
                {
                    workbook = excel.Workbooks.Add(missing);
                    sheet1 = (Worksheet)workbook.Sheets[1];
                    sheet1.Cells[int.Parse(Rows_CMBBX.Text), int.Parse(Columns_CMBBX.Text)] = TabloVeri_CMBBX.Text;
                    excel.Visible = true;
                }
                else
                    MessageBox.Show("Satır ve Sütun alanları boş geçilemez..!!! ", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
                MessageBox.Show("Tablo,Tablo Alanları veya Tablo verisi bölümleri boş geçilemez..!!! ", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TabloListe_CMBBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabloListeDataGrid.DataSource = dtBaseProcss.Db_Tables(TabloListe_CMBBX, baglan).DefaultView;
            TabloAlan_CMBBX.Items.Clear();
            TabloVeri_CMBBX.Items.Clear();
            for (int i = 0; i < dtBaseProcss.Db_Tables(TabloListe_CMBBX, baglan).Columns.Count; i++)
            {
                TabloAlan_CMBBX.Items.Add(dtBaseProcss.Db_Tables(TabloListe_CMBBX, baglan).Columns[i].ColumnName);
            }
        }

        private void TabloAlan_CMBBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabloListeDataGrid.DataSource = dtBaseProcss.Table_Column_Values(TabloListe_CMBBX, TabloAlan_CMBBX, baglan).DefaultView;
            TabloVeri_CMBBX.Items.Clear();
            for (int i = 0; i < dtBaseProcss.Db_Tables(TabloListe_CMBBX, baglan).Rows.Count; i++)
            {
                TabloVeri_CMBBX.Items.Add(dtBaseProcss.Table_Column_Values(TabloListe_CMBBX, TabloAlan_CMBBX, baglan).Rows[i].ItemArray[0].ToString());
            }
        }

        private void excel_Fonksiyon_MenuStrip_Click(object sender, EventArgs e)
        {
            ExcelFonksiyon frm = new ExcelFonksiyon();
            this.Hide();
            frm.Show();
        }
    }
}
