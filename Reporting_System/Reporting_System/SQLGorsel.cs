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

namespace Reporting_System
{
    public partial class SQLGorsel : UserControl
    {
        public SQLGorsel()
        {
            InitializeComponent();
        }
        Database_Process dbProcss = new Database_Process();
        public NpgsqlConnection baglan;

        private void tabloAdCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabloAlanAdCmbBx.Items.Clear();
            tabloVeriCmboBx.Items.Clear();
            for (int i = 0; i < dbProcss.Db_Tables(tabloAdCmbBx, baglan).Columns.Count; i++)
            {
                tabloAlanAdCmbBx.Items.Add(dbProcss.Db_Tables(tabloAdCmbBx, baglan).Columns[i].ColumnName);
            }
        }

        private void tabloAlanAdCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabloVeriCmboBx.Items.Clear();
            for (int i = 0; i < dbProcss.Db_Tables(tabloAdCmbBx, baglan).Rows.Count; i++)
            {
                tabloVeriCmboBx.Items.Add(dbProcss.Table_Column_Values(tabloAdCmbBx, tabloAlanAdCmbBx, baglan).Rows[i].ItemArray[0].ToString());
            }
        }
    }
}
