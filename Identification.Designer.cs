namespace _1._1_New_Device_Identification
{
    partial class Identification
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.İstek = new System.Windows.Forms.TextBox();
            this.Uretici = new System.Windows.Forms.TextBox();
            this.Tip = new System.Windows.Forms.TextBox();
            this.Serial = new System.Windows.Forms.TextBox();
            this.Sensitivity = new System.Windows.Forms.TextBox();
            this.Cihaz_Sec = new System.Windows.Forms.ComboBox();
            this.CalDate = new System.Windows.Forms.DateTimePicker();
            this.Company = new System.Windows.Forms.TextBox();
            this.rfq = new System.Windows.Forms.Label();
            this.cihaz = new System.Windows.Forms.Label();
            this.marka = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.serino = new System.Windows.Forms.Label();
            this.hassasiyet = new System.Windows.Forms.Label();
            this.firma = new System.Windows.Forms.Label();
            this.kalibrasyontarih = new System.Windows.Forms.Label();
            this.Kaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // İstek
            // 
            this.İstek.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İstek.Location = new System.Drawing.Point(144, 27);
            this.İstek.Name = "İstek";
            this.İstek.Size = new System.Drawing.Size(185, 22);
            this.İstek.TabIndex = 0;
            this.İstek.KeyUp += new System.Windows.Forms.KeyEventHandler(this.İstek_KeyUp);
            // 
            // Uretici
            // 
            this.Uretici.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Uretici.Location = new System.Drawing.Point(144, 79);
            this.Uretici.Name = "Uretici";
            this.Uretici.Size = new System.Drawing.Size(185, 22);
            this.Uretici.TabIndex = 1;
            this.Uretici.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Uretici_KeyUp);
            // 
            // Tip
            // 
            this.Tip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tip.Location = new System.Drawing.Point(144, 105);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(185, 22);
            this.Tip.TabIndex = 2;
            this.Tip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tip_KeyUp);
            // 
            // Serial
            // 
            this.Serial.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Serial.Location = new System.Drawing.Point(144, 131);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(185, 22);
            this.Serial.TabIndex = 3;
            this.Serial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Serial_KeyUp);
            // 
            // Sensitivity
            // 
            this.Sensitivity.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sensitivity.Location = new System.Drawing.Point(144, 157);
            this.Sensitivity.Name = "Sensitivity";
            this.Sensitivity.Size = new System.Drawing.Size(185, 22);
            this.Sensitivity.TabIndex = 4;
            this.Sensitivity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Sensitivity_KeyUp);
            // 
            // Cihaz_Sec
            // 
            this.Cihaz_Sec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cihaz_Sec.FormattingEnabled = true;
            this.Cihaz_Sec.Items.AddRange(new object[] {
            "İvmeölçer"});
            this.Cihaz_Sec.Location = new System.Drawing.Point(144, 53);
            this.Cihaz_Sec.Name = "Cihaz_Sec";
            this.Cihaz_Sec.Size = new System.Drawing.Size(185, 22);
            this.Cihaz_Sec.TabIndex = 5;
            // 
            // CalDate
            // 
            this.CalDate.CustomFormat = "dd.MM.yyyy";
            this.CalDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CalDate.Location = new System.Drawing.Point(144, 185);
            this.CalDate.Name = "CalDate";
            this.CalDate.Size = new System.Drawing.Size(185, 22);
            this.CalDate.TabIndex = 6;
            this.CalDate.Value = new System.DateTime(2019, 10, 16, 0, 0, 0, 0);
            // 
            // Company
            // 
            this.Company.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Company.Location = new System.Drawing.Point(144, 213);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(185, 22);
            this.Company.TabIndex = 8;
            this.Company.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Company_KeyUp);
            // 
            // rfq
            // 
            this.rfq.AutoSize = true;
            this.rfq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rfq.Location = new System.Drawing.Point(1, 30);
            this.rfq.Name = "rfq";
            this.rfq.Size = new System.Drawing.Size(80, 13);
            this.rfq.TabIndex = 9;
            this.rfq.Text = "İstek Numarası:";
            // 
            // cihaz
            // 
            this.cihaz.AutoSize = true;
            this.cihaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cihaz.Location = new System.Drawing.Point(1, 56);
            this.cihaz.Name = "cihaz";
            this.cihaz.Size = new System.Drawing.Size(36, 13);
            this.cihaz.TabIndex = 10;
            this.cihaz.Text = "Cihaz:";
            // 
            // marka
            // 
            this.marka.AutoSize = true;
            this.marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marka.Location = new System.Drawing.Point(1, 82);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(40, 13);
            this.marka.TabIndex = 11;
            this.marka.Text = "Marka:";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.model.Location = new System.Drawing.Point(1, 108);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(39, 13);
            this.model.TabIndex = 12;
            this.model.Text = "Model:";
            // 
            // serino
            // 
            this.serino.AutoSize = true;
            this.serino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serino.Location = new System.Drawing.Point(1, 134);
            this.serino.Name = "serino";
            this.serino.Size = new System.Drawing.Size(75, 13);
            this.serino.TabIndex = 13;
            this.serino.Text = "Seri Numarası:";
            // 
            // hassasiyet
            // 
            this.hassasiyet.AutoSize = true;
            this.hassasiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hassasiyet.Location = new System.Drawing.Point(1, 160);
            this.hassasiyet.Name = "hassasiyet";
            this.hassasiyet.Size = new System.Drawing.Size(96, 13);
            this.hassasiyet.TabIndex = 14;
            this.hassasiyet.Text = "Hassasiyet (mV/g):";
            // 
            // firma
            // 
            this.firma.AutoSize = true;
            this.firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firma.Location = new System.Drawing.Point(1, 216);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(104, 13);
            this.firma.TabIndex = 15;
            this.firma.Text = "Kalibrasyonu Yapan:";
            // 
            // kalibrasyontarih
            // 
            this.kalibrasyontarih.AutoSize = true;
            this.kalibrasyontarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalibrasyontarih.Location = new System.Drawing.Point(1, 191);
            this.kalibrasyontarih.Name = "kalibrasyontarih";
            this.kalibrasyontarih.Size = new System.Drawing.Size(93, 13);
            this.kalibrasyontarih.TabIndex = 16;
            this.kalibrasyontarih.Text = "Kalibrasyon Tarihi:";
            // 
            // Kaydet
            // 
            this.Kaydet.Enabled = false;
            this.Kaydet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet.Location = new System.Drawing.Point(4, 241);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(325, 23);
            this.Kaydet.TabIndex = 18;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kaydet);
            this.groupBox1.Controls.Add(this.İstek);
            this.groupBox1.Controls.Add(this.kalibrasyontarih);
            this.groupBox1.Controls.Add(this.Uretici);
            this.groupBox1.Controls.Add(this.firma);
            this.groupBox1.Controls.Add(this.Tip);
            this.groupBox1.Controls.Add(this.hassasiyet);
            this.groupBox1.Controls.Add(this.Serial);
            this.groupBox1.Controls.Add(this.serino);
            this.groupBox1.Controls.Add(this.Sensitivity);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.Cihaz_Sec);
            this.groupBox1.Controls.Add(this.marka);
            this.groupBox1.Controls.Add(this.CalDate);
            this.groupBox1.Controls.Add(this.cihaz);
            this.groupBox1.Controls.Add(this.Company);
            this.groupBox1.Controls.Add(this.rfq);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 275);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İvmeölçer Temel Bilgiler";
            // 
            // Identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(359, 294);
            this.Controls.Add(this.groupBox1);
            this.Name = "Identification";
            this.Text = "IDENTIFICATION";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox İstek;
        private System.Windows.Forms.TextBox Uretici;
        private System.Windows.Forms.TextBox Tip;
        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.TextBox Sensitivity;
        private System.Windows.Forms.ComboBox Cihaz_Sec;
        private System.Windows.Forms.DateTimePicker CalDate;
        private System.Windows.Forms.TextBox Company;
        private System.Windows.Forms.Label rfq;
        private System.Windows.Forms.Label cihaz;
        private System.Windows.Forms.Label marka;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label serino;
        private System.Windows.Forms.Label hassasiyet;
        private System.Windows.Forms.Label firma;
        private System.Windows.Forms.Label kalibrasyontarih;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

