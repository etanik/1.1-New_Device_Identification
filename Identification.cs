using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _1._1_New_Device_Identification
{
    public partial class Identification : Form
    {
        public void Kayit()
        {
            int counter = 0;
            foreach (TextBox x in groupBox1.Controls.OfType<TextBox>())
            {
                if ( x.Text != "")
                {
                    counter++;
                    if (counter == 6)
                    {
                        Kaydet.Enabled = true;
                    }
                    else
                    {
                        Kaydet.Enabled = false;
                    }

                }
            }
        }

        #region
        private void İstek_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }
               
        private void Uretici_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Tip_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Serial_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Sensitivity_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Company_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }
                      
        #endregion

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\etanik\Desktop\Database1.mdb");
        OleDbCommand komut = new OleDbCommand();
        public Identification()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            Accelerometer yeniivmeolcer = new Accelerometer
            {
                siparis = İstek.Text,
                cihaz_tipi = Cihaz_Sec.Text,
                marka = Uretici.Text,
                model = Tip.Text,
                serial = Serial.Text,
                sensitivity = Sensitivity.Text,
                company = Company.Text,
                caldate = CalDate.Value,/*.ToShortDateString()*/
                nextdate = CalDate.Value.AddYears(2),
            };

            DialogResult dr = MessageBox.Show(
            "Warning: when importing data into the Access database, ensure that the field columns match Access's fields or the file may become corrupt. Do you still wish to proceed?", "Import caution",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                try
                {
                    komut.Connection = baglanti;
                    baglanti.Open();
                    komut.CommandText =
                                        "INSERT INTO CihazBilgileri (İstekNumarası, Cihaz, Marka, Model, SeriNo, Hassasiyet, KalibrasyonuYapan, KalibrasyonTarihi, GelecekKalibrasyonTarihi) " +
                                        "VALUES('" + yeniivmeolcer.siparis + "','" + yeniivmeolcer.cihaz_tipi + "','" + yeniivmeolcer.marka + "','" + yeniivmeolcer.model + "','" + yeniivmeolcer.serial +
                                        "','" + yeniivmeolcer.sensitivity + "','" + yeniivmeolcer.company + "','" + yeniivmeolcer.caldate + "','" + yeniivmeolcer.nextdate + "')";
                    komut.ExecuteNonQuery();
                }
                catch(OleDbException ex)
                {
                    MessageBox.Show("Import Error: " + ex);
                }
                /*
                Hide();
                Form1 cvg = new Form1();
                cvg.Show();*/
            }

            
        }

     
    }
}
