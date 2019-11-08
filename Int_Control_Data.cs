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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace _1._1_New_Device_Identification
{
    public partial class Int_Control_Data : Form
    {
        public void Kayit()
        {
            int counter = 0;
            foreach(System.Windows.Forms.TextBox x in groupBox1.Controls.OfType<System.Windows.Forms.TextBox>())
            {                
                if (x.Text != "")
                {
                    counter++;
                    if (counter == 10)

                    {
                        button2.Enabled = true;
                    }
                    else
                    {
                        button2.Enabled = false;
                    }
                }   
            }
        }
        #region
        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void TextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void TextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void TextBox5_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void TextBox6_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void TextBox7_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void TextBox8_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void TextBox9_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void TextBox10_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }
        #endregion

        public Int_Control_Data()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string seri = textBox6.Text;
            Excel.Application xls = new Excel.Application();
            xls.Visible = false;
            Workbook wrbk = xls.Workbooks.Open("C:\\Users\\etanik\\Desktop\\F.557_0   İvmeölçer Ara Kontrol Formu.xlsx");
            #region
            // F.557 kodlu ivmeolcer ara kontrol formu doldurulur.

            xls.Range["I4"].Value = textBox1.Text;
            xls.Range["I5"].Value = textBox2.Text;
            xls.Range["I6"].Value = textBox3.Text;
            xls.Range["I8"].Value = textBox4.Text;
            xls.Range["U4"].Value = textBox5.Text;
            xls.Range["U5"].Value = textBox6.Text;
            xls.Range["U6"].Value = textBox7.Text;
            xls.Range["U7"].Value = textBox8.Text;
            xls.Range["J26"].Value = textBox9.Text;
            xls.Range["N26"].Value = textBox10.Text;
            xls.Range["B12"].Value = dataGridView1[0, 0].Value;
            xls.Range["B13"].Value = dataGridView1[0, 1].Value;
            xls.Range["C12"].Value = dataGridView1[1, 0].Value;
            xls.Range["C13"].Value = dataGridView1[1, 1].Value;
            xls.Range["F12"].Value = dataGridView1[2, 0].Value;
            xls.Range["F13"].Value = dataGridView1[2, 1].Value;
            xls.Range["K12"].Value = dataGridView1[3, 0].Value;
            xls.Range["K13"].Value = dataGridView1[3, 1].Value;
            xls.Range["P12"].Value = dataGridView1[4, 0].Value;
            xls.Range["P13"].Value = dataGridView1[4, 1].Value;
            xls.Range["T12"].Value = dataGridView1[5, 0].Value;
            xls.Range["T13"].Value = dataGridView1[5, 1].Value;
            xls.Range["F19"].Value = dataGridView2[1, 0].Value;
            xls.Range["H19"].Value = dataGridView2[1, 1].Value;
            xls.Range["J19"].Value = dataGridView2[1, 2].Value;
            xls.Range["L19"].Value = dataGridView2[1, 3].Value;
            xls.Range["N19"].Value = dataGridView2[1, 4].Value;
            xls.Range["P19"].Value = dataGridView2[1, 5].Value;
            xls.Range["R19"].Value = dataGridView2[1, 6].Value;
            xls.Range["T19"].Value = dataGridView2[1, 7].Value;
            xls.Range["V19"].Value = dataGridView2[1, 8].Value;
            xls.Range["X19"].Value = dataGridView2[1, 9].Value;

            #endregion

            wrbk.SaveAs("C:\\Users\\etanik\\Desktop\\" + seri + ".xlsx");

            xls.Workbooks.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView2.ColumnHeadersVisible = true;
            groupBox3.Enabled = true;

            dataGridView2.Rows.Add(10);
            double[] frekans = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = 0;

            foreach (double sayi in frekans)
            {
                dataGridView2[0, i].Value = sayi;
                i++;
            }

            dataGridView2.AllowUserToAddRows = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.AllowUserToAddRows = true;
        }
        
        private void DataGridView2_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        button4.Enabled = false;
                    }
                    else
                    {
                        button4.Enabled = true;
                    }
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView4.ColumnHeadersVisible = true;
            onay.Enabled = true;
            dataGridView4.Rows.Add(1);
            dataGridView4.AllowUserToAddRows = false;
            // Formulasyonlar. ===================================================================================================================================
            double average, intctrl, firstcal, lastcal, fdev, ldev;

            average = (Convert.ToDouble(dataGridView2[1, 0].Value) + Convert.ToDouble(dataGridView2[1, 1].Value) + Convert.ToDouble(dataGridView2[1, 2].Value) +
                        Convert.ToDouble(dataGridView2[1, 3].Value) + Convert.ToDouble(dataGridView2[1, 4].Value) + Convert.ToDouble(dataGridView2[1, 5].Value)
                        + Convert.ToDouble(dataGridView2[1, 6].Value) + Convert.ToDouble(dataGridView2[1, 7].Value) + Convert.ToDouble(dataGridView2[1, 8].Value)
                        + Convert.ToDouble(dataGridView2[1, 9].Value))/10;

            dataGridView4[0, 0].Value = average;
            intctrl = average / (10 / 9.81);
            dataGridView4[1, 0].Value = intctrl;
            firstcal = Convert.ToDouble(textBox9.Text);
            dataGridView4[2, 0].Value = firstcal;
            lastcal = Convert.ToDouble(textBox10.Text);
            dataGridView4[3, 0].Value = lastcal;
            fdev = (intctrl - firstcal) / firstcal;
            dataGridView4[4, 0].Value = fdev;
            ldev = (intctrl - lastcal) / lastcal;
            dataGridView4[5, 0].Value = ldev;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Red;
            style.ForeColor = Color.Black;

            DataGridViewCellStyle stayla = new DataGridViewCellStyle();
            stayla.BackColor = Color.Green;
            stayla.ForeColor = Color.Black;
            
                if (fdev>0.12)
                {
                    dataGridView4.Rows[0].Cells[4].Style = style;
                }
                else
                {
                    dataGridView4.Rows[0].Cells[4].Style = stayla;
                }

                if (ldev > 0.06)
                {
                dataGridView4.Rows[0].Cells[5].Style = style;
                }
                else
                {
                dataGridView4.Rows[0].Cells[5].Style = stayla;
                }            
           //=========================================================================================================================================================     
        }

        private void Onay_Click(object sender, EventArgs e)
        {
            Kaydet.Enabled = true;
        }       
    }
}