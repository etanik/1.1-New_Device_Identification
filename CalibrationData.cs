using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1_New_Device_Identification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalDataEntry.Rows.Add(13);
            double[] frekans = { 5, 10, 20, 31.5, 50, 80, 100, 160, 315, 500, 1000, 2000, 3150 };
            int i = 0;

            foreach(double sayi in frekans)
            {
                CalDataEntry[0, i].Value = sayi;
                i++;
            }

            CalDataEntry.AllowUserToAddRows = false;
                         
        }

        private void CalDataEntry_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in CalDataEntry.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        kalibrasyonverisi.Enabled = false;
                    }
                    else
                    {
                        kalibrasyonverisi.Enabled = true;
                    }
                }
            }
        }

        #region
        private void Kalibrasyonverisi_Click(object sender, EventArgs e)
        {
            sertifikayukleme.Visible = true;
           
        }

        private void İvmserino_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }


        #endregion

       
    }
}
