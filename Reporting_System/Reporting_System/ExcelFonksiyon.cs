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
using System.Collections;
using Microsoft.Office.Interop.Excel;

namespace Reporting_System
{
    public partial class ExcelFonksiyon : Form
    {
        Database_Process dbProcss = new Database_Process();
        Fonksiyonlar fonk = new Fonksiyonlar();
        NpgsqlConnection baglan = new Database_Process().db_Baglanti("localhost", "db_Reporting_System", "postgres", "1234");
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        object missing = Type.Missing;
        Workbook workbook;
        Worksheet sheet1;
        bool durum=false;
        Range range;
        int x = 0;
        ArrayList stliste = new ArrayList();
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
            stliste.Add("X" + x.ToString());
            x++;
            sqlgorsel.baglan = baglan;
            flowLayoutPanel1.Controls.Add(sqlgorsel);
            updateExitNodes();
        }
        private void ekleFonkBttn_Click(object sender, EventArgs e)
        {
            SQLGorselFonksiyon sqlgorselfonksiyon = new SQLGorselFonksiyon();
            sqlgorselfonksiyon.BackColor = Color.LightSteelBlue;
            sqlgorselfonksiyon.baglan = baglan;
            sqlgorselfonksiyon.Tag = "exit_node";
            updateExitNodesOne(sqlgorselfonksiyon);
            flowLayoutPanel1.Controls.Add(sqlgorselfonksiyon);
        }
        private void updateExitNodes()
        {
            foreach (UserControl sqlgorselfonksiyon in flowLayoutPanel1.Controls)
            {
                if (sqlgorselfonksiyon.Tag == "exit_node")
                {
                    SQLGorselFonksiyon temp = (SQLGorselFonksiyon)sqlgorselfonksiyon;
                    addDistinctNames(temp.bilesenNumaraCmbBx1, temp.bilesenNumaraCmbBx2);
                }
            }
        }
        private void updateExitNodesOne(SQLGorselFonksiyon temp)
        {
            addDistinctNames(temp.bilesenNumaraCmbBx1, temp.bilesenNumaraCmbBx2);
        }
        private void addDistinctNames(ComboBox first,ComboBox second)
        {
            first.Items.Clear();
            second.Items.Clear();
            foreach (string st in stliste)
            {
                first.Items.Add(st);
                second.Items.Add(st);
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            foreach (UserControl sqlgorsel in flowLayoutPanel1.Controls)
            {
                if (sqlgorsel.Tag == "exit_node")
                {
                    SQLGorselFonksiyon temp = (SQLGorselFonksiyon)sqlgorsel;
                    if (temp.ChckBx.Checked)
                        flowLayoutPanel1.Controls.Remove(temp);
                }
                else
                {
                    SQLGorsel temp = (SQLGorsel)sqlgorsel;
                    if (temp.ChckBx.Checked)
                        flowLayoutPanel1.Controls.Remove(temp);
                }
            }
        }

        private void upperButton_Click(object sender, EventArgs e)
        {
            foreach (UserControl sqlgorsel in flowLayoutPanel1.Controls)
            {
                if (sqlgorsel.Tag == "exit_node")
                {
                    SQLGorselFonksiyon temp = (SQLGorselFonksiyon)sqlgorsel;
                    if (temp.ChckBx.Checked)
                        flowLayoutPanel1.Controls.SetChildIndex(sqlgorsel,flowLayoutPanel1.Controls.GetChildIndex(sqlgorsel)-1);
                }
                else
                {
                    SQLGorsel temp = (SQLGorsel)sqlgorsel;
                    if (temp.ChckBx.Checked)
                        flowLayoutPanel1.Controls.SetChildIndex(sqlgorsel, flowLayoutPanel1.Controls.GetChildIndex(sqlgorsel) - 1);
                }
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            foreach (UserControl sqlgorsel in flowLayoutPanel1.Controls)
            {
                if (sqlgorsel.Tag == "exit_node")
                {
                    SQLGorselFonksiyon temp = (SQLGorselFonksiyon)sqlgorsel;
                    if (temp.ChckBx.Checked)
                        flowLayoutPanel1.Controls.SetChildIndex(sqlgorsel, flowLayoutPanel1.Controls.GetChildIndex(sqlgorsel) + 1);
                }
                else
                {
                    SQLGorsel temp = (SQLGorsel)sqlgorsel;
                    if (temp.ChckBx.Checked)
                        flowLayoutPanel1.Controls.SetChildIndex(sqlgorsel, flowLayoutPanel1.Controls.GetChildIndex(sqlgorsel) + 1);
                }
            }
        }
        public void ExportToExcel(FlowLayoutPanel tbl)
        {
            byte[] array;
            string str;
            int startChar2;
            int startChar;
            int starting_Column = 1;
            int start_Line = 1;
            System.Data.DataTable dataTable = new System.Data.DataTable();
            start_Line++;
            workbook = excel.Workbooks.Add(missing);
            sheet1 = (Worksheet)workbook.Sheets[1];
            if (tbl == null || tbl.Controls.Count == 0)
                MessageBox.Show("Panel İçeriği boştur. Lütfen Ekleme Yapınız.");
            foreach (SQLGorsel sqlg in tbl.Controls.OfType<SQLGorsel>())
            {
                foreach (SQLGorselFonksiyon sqlgf in tbl.Controls.OfType<SQLGorselFonksiyon>())
                {
                    str = sqlgf.excelCellTxtBx.Text;
                    array = Encoding.ASCII.GetBytes(str);
                    startChar = Convert.ToInt32(array[0]);
                    startChar2 = Convert.ToInt32(str.Substring(1));
                    if (sqlg.labelName.Text == sqlgf.bilesenNumaraCmbBx1.Text)
                    {
                        dataTable = fonk.searchInOneColumn(sqlg.tabloAdCmbBx, sqlg.tabloAlanAdCmbBx.Text, sqlgf.alan1DegerTxtBx.Text, baglan);
                        if (dataTable.Rows.Count<=0)
                        {

                            MessageBox.Show("Lütfen Doğru Değer Giriniz.....");
                        }
                        else
                        {
                            starting_Column = (startChar - 64);
                            start_Line = startChar2;
                            sheet1.Cells[start_Line, starting_Column] = sqlgf.alan1DegerTxtBx.Text;
                            excel.Visible = true;
                        }
                        
                    }
                }
            }
        }

        private void excelAktarBttn_Click(object sender, EventArgs e)
        {
            ExportToExcel(flowLayoutPanel1);
        }
    }
}
