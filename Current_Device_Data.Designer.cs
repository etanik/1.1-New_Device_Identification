namespace _1._1_New_Device_Identification
{
    partial class Current_Device_Data
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Current_Device_Data));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentdevice = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mevcutkayit = new System.Windows.Forms.Button();
            this.todatabase = new System.Windows.Forms.Button();
            this.sertifikayukleme = new System.Windows.Forms.GroupBox();
            this.degistir = new System.Windows.Forms.Button();
            this.dokuman = new System.Windows.Forms.Label();
            this.kntrl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.kaltarih = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.certificate = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentdevice)).BeginInit();
            this.sertifikayukleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.currentdevice);
            this.groupBox1.Controls.Add(this.mevcutkayit);
            this.groupBox1.Location = new System.Drawing.Point(213, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 400);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kalibrasyon Veri Tablosu";
            this.groupBox1.Visible = false;
            // 
            // currentdevice
            // 
            this.currentdevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentdevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.currentdevice.Location = new System.Drawing.Point(4, 30);
            this.currentdevice.Name = "currentdevice";
            this.currentdevice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.currentdevice.Size = new System.Drawing.Size(644, 323);
            this.currentdevice.TabIndex = 0;
            this.currentdevice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Currentdevice_KeyUp);
            // 
            // Column1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
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
            // mevcutkayit
            // 
            this.mevcutkayit.Enabled = false;
            this.mevcutkayit.Location = new System.Drawing.Point(4, 371);
            this.mevcutkayit.Name = "mevcutkayit";
            this.mevcutkayit.Size = new System.Drawing.Size(645, 23);
            this.mevcutkayit.TabIndex = 1;
            this.mevcutkayit.Text = "Devam";
            this.mevcutkayit.UseVisualStyleBackColor = true;
            this.mevcutkayit.Click += new System.EventHandler(this.Mevcutkayit_Click);
            // 
            // todatabase
            // 
            this.todatabase.Enabled = false;
            this.todatabase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.todatabase.Location = new System.Drawing.Point(874, 185);
            this.todatabase.Name = "todatabase";
            this.todatabase.Size = new System.Drawing.Size(345, 23);
            this.todatabase.TabIndex = 7;
            this.todatabase.Text = "TÜMÜNÜ KAYDET";
            this.todatabase.UseVisualStyleBackColor = true;
            this.todatabase.Visible = false;
            this.todatabase.Click += new System.EventHandler(this.Todatabase_Click);
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
            this.sertifikayukleme.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sertifikayukleme.Location = new System.Drawing.Point(874, 12);
            this.sertifikayukleme.Name = "sertifikayukleme";
            this.sertifikayukleme.Size = new System.Drawing.Size(351, 167);
            this.sertifikayukleme.TabIndex = 6;
            this.sertifikayukleme.TabStop = false;
            this.sertifikayukleme.Text = "Sertifika Yükleme";
            this.sertifikayukleme.Visible = false;
            // 
            // degistir
            // 
            this.degistir.Enabled = false;
            this.degistir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degistir.Location = new System.Drawing.Point(149, 132);
            this.degistir.Name = "degistir";
            this.degistir.Size = new System.Drawing.Size(196, 23);
            this.degistir.TabIndex = 10;
            this.degistir.Text = "Değiştir";
            this.degistir.UseVisualStyleBackColor = true;
            this.degistir.Visible = false;
            // 
            // dokuman
            // 
            this.dokuman.AutoSize = true;
            this.dokuman.Location = new System.Drawing.Point(47, 107);
            this.dokuman.Name = "dokuman";
            this.dokuman.Size = new System.Drawing.Size(42, 14);
            this.dokuman.TabIndex = 9;
            this.dokuman.Text = "label3";
            this.dokuman.Visible = false;
            // 
            // kntrl
            // 
            this.kntrl.Location = new System.Drawing.Point(149, 102);
            this.kntrl.Name = "kntrl";
            this.kntrl.Size = new System.Drawing.Size(196, 23);
            this.kntrl.TabIndex = 8;
            this.kntrl.Text = "Kontrol Et";
            this.kntrl.UseVisualStyleBackColor = true;
            this.kntrl.Visible = false;
            this.kntrl.Click += new System.EventHandler(this.Kntrl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(9, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(336, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sertifika Yükleyin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // kaltarih
            // 
            this.kaltarih.CustomFormat = "dd_MM_yyyy";
            this.kaltarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kaltarih.Location = new System.Drawing.Point(176, 21);
            this.kaltarih.Name = "kaltarih";
            this.kaltarih.Size = new System.Drawing.Size(106, 22);
            this.kaltarih.TabIndex = 5;
            this.kaltarih.Value = new System.DateTime(2019, 10, 17, 0, 0, 0, 0);
            this.kaltarih.ValueChanged += new System.EventHandler(this.Kaltarih_ValueChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(288, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Devam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "İvmeölçer Kalibrasyon Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İvmeölçer Seri Numarası:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İvmeölçer Seçme";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "416",
            "484"});
            this.comboBox1.Location = new System.Drawing.Point(137, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(10, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Devam";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // certificate
            // 
            this.certificate.FileName = "openFileDialog1";
            // 
            // Current_Device_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.todatabase);
            this.Controls.Add(this.sertifikayukleme);
            this.Controls.Add(this.groupBox1);
            this.Name = "Current_Device_Data";
            this.Text = "Current_Device_Data";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentdevice)).EndInit();
            this.sertifikayukleme.ResumeLayout(false);
            this.sertifikayukleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView currentdevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button mevcutkayit;
        private System.Windows.Forms.Button todatabase;
        private System.Windows.Forms.GroupBox sertifikayukleme;
        private System.Windows.Forms.Button degistir;
        private System.Windows.Forms.Label dokuman;
        private System.Windows.Forms.Button kntrl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker kaltarih;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog certificate;
    }
}