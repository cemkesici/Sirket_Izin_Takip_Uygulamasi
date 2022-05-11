
namespace Sirket_Takip_Uygulamasi
{
    partial class Personel
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOYAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BİRİM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNVAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOĞUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BASLAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAAŞ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAİL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db1DataSet = new Sirket_Takip_Uygulamasi.Db1DataSet();
            this.birimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unvanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimTableAdapter = new Sirket_Takip_Uygulamasi.Db1DataSetTableAdapters.birimTableAdapter();
            this.unvanTableAdapter = new Sirket_Takip_Uygulamasi.Db1DataSetTableAdapters.unvanTableAdapter();
            this.durumTableAdapter = new Sirket_Takip_Uygulamasi.Db1DataSetTableAdapters.durumTableAdapter();
            this.geriButton = new System.Windows.Forms.Button();
            this.AratextBox = new System.Windows.Forms.TextBox();
            this.Arabutton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.baslamaTarih = new System.Windows.Forms.DateTimePicker();
            this.dogumTarih = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDurum = new System.Windows.Forms.ComboBox();
            this.comboBoxUnvan = new System.Windows.Forms.ComboBox();
            this.comboBoxBirim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.güncelleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.ekleButton = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxMaas = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.buttonYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AD,
            this.SOYAD,
            this.BİRİM,
            this.UNVAN,
            this.DOĞUM,
            this.BASLAMA,
            this.MAAŞ,
            this.TC,
            this.TEL,
            this.MAİL,
            this.DURUM});
            this.dataGridView1.Location = new System.Drawing.Point(2, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(659, 422);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "personel_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // AD
            // 
            this.AD.DataPropertyName = "ad";
            this.AD.HeaderText = "AD";
            this.AD.Name = "AD";
            this.AD.ReadOnly = true;
            this.AD.Width = 50;
            // 
            // SOYAD
            // 
            this.SOYAD.DataPropertyName = "soyad";
            this.SOYAD.HeaderText = "SOYAD";
            this.SOYAD.Name = "SOYAD";
            this.SOYAD.ReadOnly = true;
            this.SOYAD.Width = 50;
            // 
            // BİRİM
            // 
            this.BİRİM.DataPropertyName = "birim_id";
            this.BİRİM.HeaderText = "BİRİM";
            this.BİRİM.Name = "BİRİM";
            this.BİRİM.ReadOnly = true;
            this.BİRİM.Width = 40;
            // 
            // UNVAN
            // 
            this.UNVAN.DataPropertyName = "unvan_id";
            this.UNVAN.HeaderText = "UNVAN";
            this.UNVAN.Name = "UNVAN";
            this.UNVAN.ReadOnly = true;
            this.UNVAN.Width = 50;
            // 
            // DOĞUM
            // 
            this.DOĞUM.DataPropertyName = "dogum_tarih";
            this.DOĞUM.HeaderText = "DOĞUM";
            this.DOĞUM.Name = "DOĞUM";
            this.DOĞUM.ReadOnly = true;
            this.DOĞUM.Width = 60;
            // 
            // BASLAMA
            // 
            this.BASLAMA.DataPropertyName = "baslama_tarih";
            this.BASLAMA.HeaderText = "BASLAMA";
            this.BASLAMA.Name = "BASLAMA";
            this.BASLAMA.ReadOnly = true;
            this.BASLAMA.Width = 60;
            // 
            // MAAŞ
            // 
            this.MAAŞ.DataPropertyName = "maas";
            this.MAAŞ.HeaderText = "MAAŞ";
            this.MAAŞ.Name = "MAAŞ";
            this.MAAŞ.ReadOnly = true;
            this.MAAŞ.Width = 40;
            // 
            // TC
            // 
            this.TC.DataPropertyName = "Tc";
            this.TC.HeaderText = "TC";
            this.TC.Name = "TC";
            this.TC.ReadOnly = true;
            this.TC.Width = 60;
            // 
            // TEL
            // 
            this.TEL.DataPropertyName = "tel";
            this.TEL.HeaderText = "TEL";
            this.TEL.Name = "TEL";
            this.TEL.ReadOnly = true;
            this.TEL.Width = 60;
            // 
            // MAİL
            // 
            this.MAİL.DataPropertyName = "mail";
            this.MAİL.HeaderText = "MAİL";
            this.MAİL.Name = "MAİL";
            this.MAİL.ReadOnly = true;
            this.MAİL.Width = 60;
            // 
            // DURUM
            // 
            this.DURUM.DataPropertyName = "durum_id";
            this.DURUM.HeaderText = "DURUM";
            this.DURUM.Name = "DURUM";
            this.DURUM.ReadOnly = true;
            this.DURUM.Width = 50;
            // 
            // db1DataSet
            // 
            this.db1DataSet.DataSetName = "Db1DataSet";
            this.db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birimBindingSource
            // 
            this.birimBindingSource.DataMember = "birim";
            this.birimBindingSource.DataSource = this.db1DataSet;
            // 
            // unvanBindingSource
            // 
            this.unvanBindingSource.DataMember = "unvan";
            this.unvanBindingSource.DataSource = this.db1DataSet;
            // 
            // durumBindingSource
            // 
            this.durumBindingSource.DataMember = "durum";
            this.durumBindingSource.DataSource = this.db1DataSet;
            // 
            // birimTableAdapter
            // 
            this.birimTableAdapter.ClearBeforeFill = true;
            // 
            // unvanTableAdapter
            // 
            this.unvanTableAdapter.ClearBeforeFill = true;
            // 
            // durumTableAdapter
            // 
            this.durumTableAdapter.ClearBeforeFill = true;
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(2, 1);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(65, 23);
            this.geriButton.TabIndex = 8;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // AratextBox
            // 
            this.AratextBox.Location = new System.Drawing.Point(171, 3);
            this.AratextBox.Name = "AratextBox";
            this.AratextBox.Size = new System.Drawing.Size(236, 20);
            this.AratextBox.TabIndex = 9;
            // 
            // Arabutton
            // 
            this.Arabutton.Location = new System.Drawing.Point(427, 3);
            this.Arabutton.Name = "Arabutton";
            this.Arabutton.Size = new System.Drawing.Size(52, 20);
            this.Arabutton.TabIndex = 8;
            this.Arabutton.Text = "Ara";
            this.Arabutton.UseVisualStyleBackColor = true;
            this.Arabutton.Click += new System.EventHandler(this.Arabutton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(675, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(752, 67);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(144, 20);
            this.textBoxId.TabIndex = 35;
            // 
            // baslamaTarih
            // 
            this.baslamaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baslamaTarih.Location = new System.Drawing.Point(752, 249);
            this.baslamaTarih.Name = "baslamaTarih";
            this.baslamaTarih.Size = new System.Drawing.Size(144, 20);
            this.baslamaTarih.TabIndex = 34;
            // 
            // dogumTarih
            // 
            this.dogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dogumTarih.Location = new System.Drawing.Point(753, 171);
            this.dogumTarih.Name = "dogumTarih";
            this.dogumTarih.Size = new System.Drawing.Size(143, 20);
            this.dogumTarih.TabIndex = 33;
            this.dogumTarih.Value = new System.DateTime(2022, 4, 13, 2, 34, 53, 0);
            // 
            // comboBoxDurum
            // 
            this.comboBoxDurum.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.db1DataSet, "unvan.unvan_id", true));
            this.comboBoxDurum.DataSource = this.durumBindingSource;
            this.comboBoxDurum.DisplayMember = "durum_ad";
            this.comboBoxDurum.FormattingEnabled = true;
            this.comboBoxDurum.Location = new System.Drawing.Point(751, 356);
            this.comboBoxDurum.Name = "comboBoxDurum";
            this.comboBoxDurum.Size = new System.Drawing.Size(145, 21);
            this.comboBoxDurum.TabIndex = 32;
            this.comboBoxDurum.ValueMember = "durum_id";
            // 
            // comboBoxUnvan
            // 
            this.comboBoxUnvan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.db1DataSet, "unvan.unvan_id", true));
            this.comboBoxUnvan.DataSource = this.unvanBindingSource;
            this.comboBoxUnvan.DisplayMember = "unvan_ad";
            this.comboBoxUnvan.FormattingEnabled = true;
            this.comboBoxUnvan.Location = new System.Drawing.Point(751, 301);
            this.comboBoxUnvan.Name = "comboBoxUnvan";
            this.comboBoxUnvan.Size = new System.Drawing.Size(145, 21);
            this.comboBoxUnvan.TabIndex = 31;
            this.comboBoxUnvan.ValueMember = "unvan_id";
            // 
            // comboBoxBirim
            // 
            this.comboBoxBirim.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.db1DataSet, "birim.birim_id", true));
            this.comboBoxBirim.DataSource = this.birimBindingSource;
            this.comboBoxBirim.DisplayMember = "birim_ad";
            this.comboBoxBirim.FormattingEnabled = true;
            this.comboBoxBirim.Location = new System.Drawing.Point(751, 274);
            this.comboBoxBirim.Name = "comboBoxBirim";
            this.comboBoxBirim.Size = new System.Drawing.Size(145, 21);
            this.comboBoxBirim.TabIndex = 30;
            this.comboBoxBirim.ValueMember = "birim_id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(675, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Doğum Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(675, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Durum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ünvan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(675, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Maaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Birim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(675, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Başlama Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ad";
            // 
            // güncelleButton
            // 
            this.güncelleButton.Location = new System.Drawing.Point(686, 409);
            this.güncelleButton.Name = "güncelleButton";
            this.güncelleButton.Size = new System.Drawing.Size(63, 35);
            this.güncelleButton.TabIndex = 18;
            this.güncelleButton.Text = "Güncelle";
            this.güncelleButton.UseVisualStyleBackColor = true;
            this.güncelleButton.Click += new System.EventHandler(this.güncelleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(755, 409);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(63, 35);
            this.silButton.TabIndex = 17;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(824, 409);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(63, 35);
            this.ekleButton.TabIndex = 16;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(753, 223);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(143, 20);
            this.textBoxEmail.TabIndex = 14;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(753, 197);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(143, 20);
            this.textBoxTel.TabIndex = 13;
            this.textBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTc_KeyPress);
            // 
            // textBoxMaas
            // 
            this.textBoxMaas.Location = new System.Drawing.Point(751, 330);
            this.textBoxMaas.Name = "textBoxMaas";
            this.textBoxMaas.Size = new System.Drawing.Size(145, 20);
            this.textBoxMaas.TabIndex = 12;
            this.textBoxMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaas_KeyPress);
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(752, 119);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(144, 20);
            this.textBoxSoyad.TabIndex = 11;
            this.textBoxSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoyad_KeyPress);
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(752, 145);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(144, 20);
            this.textBoxTc.TabIndex = 15;
            this.textBoxTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTc_KeyPress);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(752, 93);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(144, 20);
            this.textBoxAd.TabIndex = 10;
            this.textBoxAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAd_KeyPress);
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(73, 2);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(65, 23);
            this.buttonYenile.TabIndex = 8;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 456);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.baslamaTarih);
            this.Controls.Add(this.dogumTarih);
            this.Controls.Add(this.comboBoxDurum);
            this.Controls.Add(this.comboBoxUnvan);
            this.Controls.Add(this.comboBoxBirim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.güncelleButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxMaas);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.AratextBox);
            this.Controls.Add(this.Arabutton);
            this.Controls.Add(this.buttonYenile);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Db1DataSet db1DataSet;
        private System.Windows.Forms.BindingSource birimBindingSource;
        private Db1DataSetTableAdapters.birimTableAdapter birimTableAdapter;
        private System.Windows.Forms.BindingSource unvanBindingSource;
        private Db1DataSetTableAdapters.unvanTableAdapter unvanTableAdapter;
        private System.Windows.Forms.BindingSource durumBindingSource;
        private Db1DataSetTableAdapters.durumTableAdapter durumTableAdapter;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.TextBox AratextBox;
        private System.Windows.Forms.Button Arabutton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DateTimePicker baslamaTarih;
        private System.Windows.Forms.DateTimePicker dogumTarih;
        private System.Windows.Forms.ComboBox comboBoxDurum;
        private System.Windows.Forms.ComboBox comboBoxUnvan;
        private System.Windows.Forms.ComboBox comboBoxBirim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button güncelleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxMaas;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOYAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn BİRİM;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNVAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOĞUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BASLAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAAŞ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAİL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURUM;
        private System.Windows.Forms.Button buttonYenile;
    }
}

