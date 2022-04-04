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
    public partial class SQLGorselFonksiyon : UserControl
    {
        Database_Process dbProcss = new Database_Process();
        public NpgsqlConnection baglan;
        public SQLGorselFonksiyon()
        {
            InitializeComponent();
        }

        private void fonksiyonCmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fonksiyonCmbbx.SelectedIndex == 1)
            {
                bilesenNumaraCmbBx2.Enabled = false;
                alan2DegerTxtBx.Enabled = false;
            }
            else
            {
                bilesenNumaraCmbBx2.Enabled = true;
                alan2DegerTxtBx.Enabled = true;
                alan2DegerTxtBx.BackColor = Color.White;
            }
        }
    }
}
