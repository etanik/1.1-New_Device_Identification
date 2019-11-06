namespace _1._1_New_Device_Identification
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalDataEntry = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalibrasyonverisi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sertifikayukleme = new System.Windows.Forms.GroupBox();
            this.degistir = new System.Windows.Forms.Button();
            this.dokuman = new System.Windows.Forms.Label();
            this.kntrl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.kaltarih = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ivmserino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.todatabase = new System.Windows.Forms.Button();
            this.certificate = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CalDataEntry)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.sertifikayukleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalDataEntry
            // 
            this.CalDataEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalDataEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.CalDataEntry.Location = new System.Drawing.Point(4, 30);
            this.CalDataEntry.Name = "CalDataEntry";
            this.CalDataEntry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CalDataEntry.Size = new System.Drawing.Size(644, 323);
            this.CalDataEntry.TabIndex = 0;
            this.CalDataEntry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CalDataEntry_KeyUp);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Frekans";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Uygulanan İvme";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hassasiyet Katsayısı";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sapma";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Standart Sapma";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Faz Açısı";
            this.Column6.Name = "Column6";
            // 
            // kalibrasyonverisi
            // 
            this.kalibrasyonverisi.Enabled = false;
            this.kalibrasyonverisi.Location = new System.Drawing.Point(4, 371);
            this.kalibrasyonverisi.Name = "kalibrasyonverisi";
            this.kalibrasyonverisi.Size = new System.Drawing.Size(645, 23);
            this.kalibrasyonverisi.TabIndex = 1;
            this.kalibrasyonverisi.Text = "Devam";
            this.kalibrasyonverisi.UseVisualStyleBackColor = true;
            this.kalibrasyonverisi.Click += new System.EventHandler(this.Kalibrasyonverisi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CalDataEntry);
            this.groupBox1.Controls.Add(this.kalibrasyonverisi);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 400);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kalibrasyon Veri Tablosu";
            // 
            // sertifikayukleme
            // 
            this.sertifikayukleme.Controls.Add(this.degistir);
            this.sertifikayukleme.Controls.Add(this.dokuman);
            this.sertifikayukleme.Controls.Add(this.kntrl);
            this.sertifikayukleme.Controls.Add(this.pictureBox1);
            this.sertifikayukleme.Controls.Add(this.button3);
            this.sertifikayukleme.Controls.Add(this.kaltarih);
            this.sertifikayukleme.Controls.Add(this.button2);
            this.sertifikayukleme.Controls.Add(this.label2);
            this.sertifikayukleme.Controls.Add(this.button1);
            this.sertifikayukleme.Controls.Add(this.ivmserino);
            this.sertifikayukleme.Controls.Add(this.label1);
            this.sertifikayukleme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sertifikayukleme.Location = new System.Drawing.Point(674, 12);
            this.sertifikayukleme.Name = "sertifikayukleme";
            this.sertifikayukleme.Size = new System.Drawing.Size(392, 209);
            this.sertifikayukleme.TabIndex = 4;
            this.sertifikayukleme.TabStop = false;
            this.sertifikayukleme.Text = "Sertifika Yükleme";
            this.sertifikayukleme.Visible = false;
            // 
            // degistir
            // 
            this.degistir.Enabled = false;
            this.degistir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degistir.Location = new System.Drawing.Point(149, 170);
            this.degistir.Name = "degistir";
            this.degistir.Size = new System.Drawing.Size(237, 23);
            this.degistir.TabIndex = 10;
            this.degistir.Text = "Değiştir";
            this.degistir.UseVisualStyleBackColor = true;
            this.degistir.Visible = false;
            // 
            // dokuman
            // 
            this.dokuman.AutoSize = true;
            this.dokuman.Location = new System.Drawing.Point(47, 145);
            this.dokuman.Name = "dokuman";
            this.dokuman.Size = new System.Drawing.Size(42, 14);
            this.dokuman.TabIndex = 9;
            this.dokuman.Text = "label3";
            this.dokuman.Visible = false;
            // 
            // kntrl
            // 
            this.kntrl.Location = new System.Drawing.Point(149, 140);
            this.kntrl.Name = "kntrl";
            this.kntrl.Size = new System.Drawing.Size(237, 23);
            this.kntrl.TabIndex = 8;
            this.kntrl.Text = "Kontrol Et";
            this.kntrl.UseVisualStyleBackColor = true;
            this.kntrl.Visible = false;
            this.kntrl.Click += new System.EventHandler(this.Kntrl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(9, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(377, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sertifika Yükle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // kaltarih
            // 
            this.kaltarih.CustomFormat = "dd_MM_yyyy";
            this.kaltarih.Enabled = false;
            this.kaltarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kaltarih.Location = new System.Drawing.Point(189, 59);
            this.kaltarih.Name = "kaltarih";
            this.kaltarih.Size = new System.Drawing.Size(121, 22);
            this.kaltarih.TabIndex = 5;
            this.kaltarih.Value = new System.DateTime(2019, 10, 17, 0, 0, 0, 0);
            this.kaltarih.ValueChanged += new System.EventHandler(this.kaltarih_ValueChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(316, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "Devam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "İvmeölçer Kalibrasyon Tarihi:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(316, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Devam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ivmserino
            // 
            this.ivmserino.Location = new System.Drawing.Point(189, 27);
            this.ivmserino.Name = "ivmserino";
            this.ivmserino.Size = new System.Drawing.Size(121, 22);
            this.ivmserino.TabIndex = 1;
            this.ivmserino.TextChanged += new System.EventHandler(this.İvmserino_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "İvmeölçer Seri Numarası:";
            // 
            // todatabase
            // 
            this.todatabase.Enabled = false;
            this.todatabase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.todatabase.Location = new System.Drawing.Point(674, 227);
            this.todatabase.Name = "todatabase";
            this.todatabase.Size = new System.Drawing.Size(386, 23);
            this.todatabase.TabIndex = 5;
            this.todatabase.Text = "TÜMÜNÜ KAYDET";
            this.todatabase.UseVisualStyleBackColor = true;
            this.todatabase.Visible = false;
            this.todatabase.Click += new System.EventHandler(this.Todatabase_Click);
            // 
            // certificate
            // 
            this.certificate.FileName = "openFileDialog1";
            this.certificate.Filter = "Adobe Acrobat Document|*.pdf*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 420);
            this.Controls.Add(this.todatabase);
            this.Controls.Add(this.sertifikayukleme);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CALIBRATION DATA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalDataEntry)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.sertifikayukleme.ResumeLayout(false);
            this.sertifikayukleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CalDataEntry;
        private System.Windows.Forms.Button kalibrasyonverisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox sertifikayukleme;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker kaltarih;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ivmserino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button todatabase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dokuman;
        private System.Windows.Forms.Button kntrl;
        private System.Windows.Forms.OpenFileDialog certificate;
        private System.Windows.Forms.Button degistir;
    }
}