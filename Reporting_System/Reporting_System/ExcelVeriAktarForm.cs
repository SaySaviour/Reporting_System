﻿using System;
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
    public partial class ExcelVeriAktarForm : Form
    {
        Database_Process dbProcss = new Database_Process();
        NpgsqlConnection baglan = new Database_Process().db_Baglanti("localhost", "db_Reporting_System", "postgres", "1234");
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        object missing = Type.Missing;
        Workbook workbook;
        Worksheet sheet1;
        public ExcelVeriAktarForm()
        {
            InitializeComponent();
        }
        private void TabloListe_CMBBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabloDataGridView.DataSource = dbProcss.Db_Tables(TabloListe_CMBBX, baglan).DefaultView;
            TabloAlan_CMBBX.Items.Clear();
            TabloVeri_CMBBX.Items.Clear();
            for (int i = 0; i < dbProcss.Db_Tables(TabloListe_CMBBX, baglan).Columns.Count; i++)
            {
                TabloAlan_CMBBX.Items.Add(dbProcss.Db_Tables(TabloListe_CMBBX, baglan).Columns[i].ColumnName);
            }

        }
        private void TabloAlan_CMBBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabloDataGridView.DataSource = dbProcss.Table_Column_Values(TabloListe_CMBBX, TabloAlan_CMBBX, baglan).DefaultView;
            TabloVeri_CMBBX.Items.Clear();
            for (int i = 0; i < dbProcss.Db_Tables(TabloListe_CMBBX, baglan).Rows.Count; i++)
            {
                TabloVeri_CMBBX.Items.Add(dbProcss.Table_Column_Values(TabloListe_CMBBX, TabloAlan_CMBBX, baglan).Rows[i].ItemArray[0].ToString());
            }
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
    }
}