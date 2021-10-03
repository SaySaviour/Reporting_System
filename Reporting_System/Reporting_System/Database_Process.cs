using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Reporting_System
{
    class Database_Process
    {
        public bool durum = false;
        public NpgsqlConnection db_Baglanti(string db_adres,string db_name, string db_ID,string db_Password)
        {
            NpgsqlConnection db_baglanti = new NpgsqlConnection("Server="+db_adres+";port=5432;Database="+db_name+";user ID="+db_ID+";password="+db_Password+"");
            return db_baglanti;
        }
        public bool KullaniciKontrol_ID(TextBox user_ID,TextBox user_Name ,NpgsqlConnection baglan)
        {
            baglan.Open();
            string sorgu= "Select * From \"User_Login\" Where \"User_ID\"='"+int.Parse(user_ID.Text)+"' or \"User_Name\"='"+user_Name.Text+"'";
            NpgsqlCommand cmd = new NpgsqlCommand();
            NpgsqlDataReader dr;
            cmd.CommandText = sorgu;
            cmd.Connection = baglan;
            dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;
        }
        public bool KullaniciKontrol_Name(TextBox user_Name, NpgsqlConnection baglan)
        {
            baglan.Open();
            string sorgu = "Select * From \"User_Login\" Where  \"User_Name\"='" + user_Name.Text + "'";
            NpgsqlCommand cmd = new NpgsqlCommand();
            NpgsqlDataReader dr;
            cmd.CommandText = sorgu;
            cmd.Connection = baglan;
            dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;
        }
        public void SifreUnuttum(TextBox kadi,TextBox sifre,NpgsqlConnection baglan)
        {
            if(KullaniciKontrol_Name(kadi, baglan) == true)
            {
                baglan.Close();
                baglan.Open();
                string sorgu = "UPDATE \"User_Login\" SET \"User_Name\" ='"+kadi.Text+"',\"User_Password\" ='"+sifre.Text+ "' Where \"User_Name\"='"+kadi.Text+"'";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sorgu;
                cmd.Connection = baglan;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Bilgileri Başarı ile Güncellendi.", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adına ait kayıt bulunmamaktadır.", "Güncelleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglan.Close();
            }
        }
        public void GirisYap(TextBox user_Name,TextBox user_Password,NpgsqlConnection baglan)
        {
            
            baglan.Open();
            string sorgu = "Select * From \"User_Login\" Where \"User_Name\"='" + user_Name.Text + "' and \"User_Password\"='" + user_Password.Text + "'";
            NpgsqlCommand cmd = new NpgsqlCommand();
            NpgsqlDataReader dr;
            cmd.CommandText = sorgu;
            cmd.Connection = baglan;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum= true;
                ExcelTabloAktarForm tabloAktar = new ExcelTabloAktarForm();
                tabloAktar.Show();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı adına ait kayıt bulunamadı.","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                durum = false;
            }
            baglan.Close();
        }
        public void KullaniciEkle(bool user_Authority, TextBox user_ID, TextBox user_Name, TextBox user_Password,NpgsqlConnection baglan)
        {
           
            if (KullaniciKontrol_ID(user_ID, user_Name, baglan) != true)
            {
                baglan.Close();
                baglan.Open();
                string sorgu = "INSERT INTO \"User_Login\"(\"User_Authority\", \"User_ID\", \"User_Name\", \"User_Password\")VALUES('" + user_Authority + "','" + int.Parse(user_ID.Text) + "', '" + user_Name.Text + "', '" + user_Password.Text + "')";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sorgu;
                cmd.Connection = baglan;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni Kullanıcı Başarı İle Kaydedildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı ve Id ye ait kayıt bulunmaktadır.","Kayıt Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                baglan.Close();
            }
           
        }
        public DataTable Table_Column_Values(ComboBox tableComboBox, ComboBox tableColumnsnameComboBox, NpgsqlConnection baglan)
        {
            baglan.Open();
            string sorgu;
            NpgsqlDataAdapter da;
            DataTable dTable = new DataTable();

            switch (tableComboBox.SelectedIndex)
            {
                case 0:
                    dTable.Clear();
                    sorgu = "Select \""+tableColumnsnameComboBox.Text+"\" from \"User_Login\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 1:
                    dTable.Clear();
                    sorgu = "Select \"" + tableColumnsnameComboBox.Text + "\" from \"Product_Buy\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 2:
                    dTable.Clear();
                    sorgu = "Select \""+ tableColumnsnameComboBox.Text +"\" from \"Product_Sell\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 3:
                    dTable.Clear();
                    sorgu = "Select \"" + tableColumnsnameComboBox.Text + "\" from \"Product_Infmtn\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                default:
                    MessageBox.Show("Yanlış seçim yaptınız. Lütfen doğru tabloyu veya alanı seçiniz.", "TABLO/ALAN SEÇİM HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglan.Close();
                    return dTable;
            }
        }
        public DataTable Db_Tables(ComboBox tabloComboBox,NpgsqlConnection baglan)
        {
            baglan.Open();
            string sorgu;
            NpgsqlDataAdapter da;
            DataTable dTable = new DataTable();
            
            switch (tabloComboBox.SelectedIndex)
            {
                case 0:
                    dTable.Clear();
                    sorgu = "Select * from \"User_Login\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 1:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Buy\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 2:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Sell\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                case 3:
                    dTable.Clear();
                    sorgu = "Select * from \"Product_Infmtn\"";
                    da = new NpgsqlDataAdapter(sorgu, baglan);
                    da.Fill(dTable);
                    baglan.Close();
                    return dTable;
                default:
                    MessageBox.Show("Yanlış seçim yaptınız. Lütfen doğru tabloyu seçiniz.","TABLO SEÇİM HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    baglan.Close();
                    return dTable;
            }
        }
    }
}
