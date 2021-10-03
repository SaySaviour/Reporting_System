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
using MetroSet_UI.Forms;
using Npgsql;

namespace Reporting_System
{
    public partial class KullaniciGirisForm : MetroSetForm
    {
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }
        Database_Process dt_Procs = new Database_Process();
        NpgsqlConnection baglan = new Database_Process().db_Baglanti("localhost", "db_Reporting_System", "postgres", "1234");
        private void Giris_Button_Click(object sender, EventArgs e)
        {
            dt_Procs.GirisYap(K_Adi_TextBox,Sifre_TextBox,baglan);
            if (dt_Procs.durum==true)
            {
                this.Hide();
            }
        }

        private void ParolaGosterSwitch_SwitchedChanged(object sender)
        {
            if (ParolaGosterSwitch.Switched)
                Sifre_TextBox.UseSystemPasswordChar = true;
            else
                Sifre_TextBox.UseSystemPasswordChar = false;
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            SifreUnutForm sfrunut = new SifreUnutForm();
            this.Hide();
            sfrunut.Show();
        }

        private void kayitOl_Btn_Click(object sender, EventArgs e)
        {
            KullaniciKayitForm kayit = new KullaniciKayitForm();
            this.Hide();
            kayit.Show();
        }
    }
}
