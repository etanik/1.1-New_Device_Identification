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
using System.IO;
using System.Diagnostics;

namespace _1._1_New_Device_Identification
{
    public partial class Current_Device_Data : Form
    {

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\etanik\Desktop\Database1.mdb");
        OleDbCommand komut = new OleDbCommand();

        public Current_Device_Data()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox1.Visible = true;

            currentdevice.Rows.Add(13);
            double[] frekans = { 5, 10, 20, 31.5, 50, 80, 100, 160, 315, 500, 1000, 2000, 3150 };
            int i = 0;

            foreach (double sayi in frekans)
            {
                currentdevice[0, i].Value = sayi;
                i++;
            }

            currentdevice.AllowUserToAddRows = false;
        }

        private void Currentdevice_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in currentdevice.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        mevcutkayit.Enabled = false;
                    }
                    else
                    {
                        mevcutkayit.Enabled = true;
                    }
                }
            }
        }

        private void Mevcutkayit_Click(object sender, EventArgs e)
        {
            sertifikayukleme.Visible = true;
            todatabase.Visible = true;
            groupBox1.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (certificate.ShowDialog() == DialogResult.OK)
            {
                Accelerometer ivm = new Accelerometer
                {
                    path = certificate.FileName,
                    filename = Path.GetFileName(certificate.FileName),
                };

                //string filename;
                // string path = certificate.FileName;
                //filename = Path.GetFileName(path);
                dokuman.Text = ivm.filename;
            }

            todatabase.Enabled = true;
            pictureBox1.Visible = true;
            kntrl.Visible = true;
            kntrl.Enabled = true;
            dokuman.Visible = true;
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                button4.Enabled = true;
            }
        }

        private void Kaltarih_ValueChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void Kntrl_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo(certificate.FileName);
            Process.Start(start);
        }

        private void Todatabase_Click(object sender, EventArgs e)
        {
            Accelerometer yeniivmeolcer = new Accelerometer
            {
                isim = comboBox1.Text,
                caldate = kaltarih.Text,
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

                    string tableName = yeniivmeolcer.isim + "_" + yeniivmeolcer.caldate;
                    string columns = "[Frekans] Text, [UygulananIvme] Text, [HassasiyetKatsayisi] Text, [Sapma] Text, [StandartSapma] Text, [FazAcisi] Text";
                    komut.Connection = baglanti;
                    komut.CommandText = "CREATE TABLE " + tableName + "(" + columns + ")";
                    komut.ExecuteNonQuery();

                    komut.CommandText =
                                        "INSERT INTO " + tableName + "(Frekans, UygulananIvme, HassasiyetKatsayisi, Sapma, StandartSapma, FazAcisi)"
                                        + "VALUES(@Frekans, @UygulananIvme, @HassasiyetKatsayisi, @Sapma, @StandartSapma, @FazAcisi)";

                    for (int j = 0; j < currentdevice.Rows.Count; j++)
                    {
                        komut.Parameters.Clear();
                        komut.Parameters.AddWithValue("@Frekans", Convert.ToDouble(currentdevice[0, j].Value));
                        komut.Parameters.AddWithValue("@Uygulananİvme", Convert.ToDouble(currentdevice[1, j].Value));
                        komut.Parameters.AddWithValue("@HassasiyetKatsayisi", Convert.ToDouble(currentdevice[2, j].Value));
                        komut.Parameters.AddWithValue("@Sapma", Convert.ToDouble(currentdevice[3, j].Value));
                        komut.Parameters.AddWithValue("@StandartSapma", Convert.ToDouble(currentdevice[4, j].Value));
                        komut.Parameters.AddWithValue("@FazAcisi", Convert.ToDouble(currentdevice[5, j].Value));

                        komut.ExecuteNonQuery();
                    }
                }

                catch (OleDbException ex)
                {
                    MessageBox.Show("Import error: " + ex);
                }
            }
        }
    }
}
