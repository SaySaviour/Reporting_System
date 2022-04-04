using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace Reporting_System
{
    class Fonksiyonlar
    {
        public DataTable searchInOneColumn(ComboBox tableNameCmbbx, string columnName, string value, NpgsqlConnection baglan)
        {
            baglan.Open();
            string sorgu;
            NpgsqlDataAdapter da;
            DataTable dTable = new DataTable();

            switch (tableNameCmbbx.SelectedIndex)
            {
                case 0:
                    dTable.Clear();
                    sorgu = "Select * from \"User_Login\" Where \"" + columnName + "\"='" + value + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 1:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Buy\" Where \"" + columnName + "\"='" + value + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 2:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Sell\" Where \"" + columnName + "\"='" + value + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 3:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Infmtn\" Where \"" + columnName + "\"='" + value + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                default:
                    baglan.Close();
                    return dTable;
            }
        }
        public DataTable searchInTwoColumn(ComboBox tableNameCmbbx, string columnName1, string value1, string columnName2, string value2, NpgsqlConnection baglan)
        {
            baglan.Open();
            string sorgu;
            NpgsqlDataAdapter da;
            DataTable dTable = new DataTable();

            switch (tableNameCmbbx.SelectedIndex)
            {
                case 0:
                    dTable.Clear();
                    sorgu = "Select * from \"User_Login\" Where \"" + columnName1 + "\"='" + value1 + "' and \"" + columnName2 + "\"='" + value2 + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 1:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Buy\" Where \"" + columnName1 + "\"='" + value1 + "'and \"" + columnName2 + "\"='" + value2 + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 2:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Sell\" Where \"" + columnName1 + "\"='" + value1 + "'and \"'" + columnName2 + "'\"='" + value2 + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 3:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Infmtn\" Where \"" + columnName1 + "\"='" + value1 + "'and \"'" + columnName2 + "'\"='" + value2 + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                default:
                    baglan.Close();
                    return dTable;
            }
        }
        public DataTable searchInTwoColumnOR(ComboBox tableNameCmbbx, string columnName1, string value1, string columnName2, string value2, NpgsqlConnection baglan)
        {
            baglan.Open();
            string sorgu;
            NpgsqlDataAdapter da;
            DataTable dTable = new DataTable();

            switch (tableNameCmbbx.SelectedIndex)
            {
                case 0:
                    dTable.Clear();
                    sorgu = "Select * from \"User_Login\" Where \"" + columnName1 + "\"='" + value1 + "' or \"" + columnName2 + "\"='" + value2 + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 1:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Buy\" Where \"" + columnName1 + "\"='" + value1 + "'or \"" + columnName2 + "\"='" + value2 + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 2:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Sell\" Where \"" + columnName1 + "\"='" + value1 + "'or \"" + columnName2 + "\"='" + value2 + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 3:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Infmtn\" Where \"" + columnName1 + "\"='" + value1 + "'or \"" + columnName2 + "\"='" + value2 + "'";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                default:
                    baglan.Close();
                    return dTable;
            }
        }
        public DataTable getOneColumn(ComboBox tableComboBox,string columnName, NpgsqlConnection baglan)
        {
            baglan.Open();
            string sorgu;
            NpgsqlDataAdapter da;
            DataTable dTable = new DataTable();

            switch (tableComboBox.SelectedIndex)
            {
                case 0:
                    dTable.Clear();
                    sorgu = "Select \""+columnName+"\" from \"User_Login\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 1:
                    dTable.Clear();
                    sorgu = "Select \"" + columnName + "\" from \"Product_Buy\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 2:
                    dTable.Clear();
                    sorgu = "Select \"" + columnName + "\" from \"Product_Sell\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 3:
                    dTable.Clear();
                    sorgu = "Select \"" + columnName + "\" from \"Product_Infmtn\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                default:
                    baglan.Close();
                    return dTable;
            }
        }
        public DataTable getOneColumnSUM(ComboBox tableComboBox, string columnName, NpgsqlConnection baglan)
        {
            baglan.Open();
            string sorgu;
            NpgsqlDataAdapter da;
            DataTable dTable = new DataTable();

            switch (tableComboBox.SelectedIndex)
            {
                case 0:
                    dTable.Clear();
                    sorgu = "Select SUM(\"" + columnName + "\") from \"User_Login\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 1:
                    dTable.Clear();
                    sorgu = "Select SUM(\"" + columnName + "\") from \"Product_Buy\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 2:
                    dTable.Clear();
                    sorgu = "Select SUM(\"" + columnName + "\") from \"Product_Sell\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 3:
                    dTable.Clear();
                    sorgu = "Select SUM(\"" + columnName + "\") from \"Product_Infmtn\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                default:
                    baglan.Close();
                    return dTable;
            }
        }
    }
}

