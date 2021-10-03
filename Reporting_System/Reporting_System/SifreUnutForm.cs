using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Npgsql;

namespace Reporting_System
{
    public partial class SifreUnutForm : MetroSetForm
    {
        public SifreUnutForm()
        {
            InitializeComponent();
        }
        Database_Process dt_Procs = new Database_Process();
        NpgsqlConnection baglan = new Database_Process().db_Baglanti("localhost", "db_Reporting_System", "postgres", "1234");
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            if (kadi_TxtBx.Text != "" || sifre_TxtBx.Text != "" || sifreO_TxtBx.Text != "")
            {
                if (sifre_TxtBx.Text == sifreO_TxtBx.Text)
                {
                    dt_Procs.SifreUnuttum(kadi_TxtBx, sifre_TxtBx, baglan);
                    KullaniciGirisForm frm = new KullaniciGirisForm();
                    this.Hide();
                    frm.Show();
                }
                else
                    MessageBox.Show("Şifre ile Şifre Onay Alanları Birbiri ile Uyuşmamaktadır.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Alanlar Boş Geçilemez......","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
        }

        private void cikBttn_Click(object sender, EventArgs e)
        {
            KullaniciGirisForm frm = new KullaniciGirisForm();
            this.Hide();
            frm.Show();
        }
    }
}
