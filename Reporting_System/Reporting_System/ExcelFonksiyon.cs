using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Microsoft.Office.Interop.Excel;

namespace Reporting_System
{
    public partial class ExcelFonksiyon : Form
    {
        Database_Process dbProcss = new Database_Process();
        NpgsqlConnection baglan = new Database_Process().db_Baglanti("localhost", "db_Reporting_System", "postgres", "1234");
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        object missing = Type.Missing;
        Workbook workbook;
        Worksheet sheet1;
        bool durum=false;
        Range range;
        int x = 0;
        public ExcelFonksiyon()
        {
            InitializeComponent();
        }
        private void geriBtn_Click(object sender, EventArgs e)
        {
            ExcelTabloAktarForm formtablo = new ExcelTabloAktarForm();
            this.Hide();
            formtablo.Show();
        }

        private void cikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGirisForm kgirisfrm = new KullaniciGirisForm();
            this.Close();
            kgirisfrm.Show();
        }

        private void farkliKaydetToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cikBttn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ekleBttn_Click(object sender, EventArgs e)
        {
            SQLGorsel sqlgorsel = new SQLGorsel();
            sqlgorsel.BackColor = Color.Gainsboro;
            sqlgorsel.labelName.Text = "X" + x.ToString();
            x++;
            sqlgorsel.baglan = baglan;
            flowLayoutPanel1.Controls.Add(sqlgorsel);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            foreach (UserControl sqlgorsel in flowLayoutPanel1.Controls)
            {
                SQLGorsel temp = (SQLGorsel)sqlgorsel;
                if (temp.ChckBx.Checked)
                    flowLayoutPanel1.Controls.Remove(temp);
            }
        }

        private void upperButton_Click(object sender, EventArgs e)
        {
            foreach (UserControl sqlgorsel in flowLayoutPanel1.Controls)
            {
                SQLGorsel temp = (SQLGorsel)sqlgorsel;
                if (temp.ChckBx.Checked)
                    flowLayoutPanel1.Controls.SetChildIndex(sqlgorsel,flowLayoutPanel1.Controls.GetChildIndex(sqlgorsel)-1);
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            foreach (UserControl sqlgorsel in flowLayoutPanel1.Controls)
            {
                SQLGorsel temp = (SQLGorsel)sqlgorsel;
                if (temp.ChckBx.Checked)
                    flowLayoutPanel1.Controls.SetChildIndex(sqlgorsel, flowLayoutPanel1.Controls.GetChildIndex(sqlgorsel) + 1);
            }
        }
    }
}
