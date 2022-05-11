
namespace Sirket_Takip_Uygulamasi
{
    partial class İzin
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalangün = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MailtextBox = new System.Windows.Forms.TextBox();
            this.TeltextBox = new System.Windows.Forms.TextBox();
            this.TctextBox = new System.Windows.Forms.TextBox();
            this.SoyadtextBox = new System.Windows.Forms.TextBox();
            this.AdtextBox = new System.Windows.Forms.TextBox();
            this.BaslamatextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.KalantextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Geributton = new System.Windows.Forms.Button();
            this.AratextBox = new System.Windows.Forms.TextBox();
            this.Arabutton = new System.Windows.Forms.Button();
            this.İzinbutton = new System.Windows.Forms.Button();
            this.radioButtonPersonel = new System.Windows.Forms.RadioButton();
            this.radioButtonBirim = new System.Windows.Forms.RadioButton();
            this.radioButtonTümü = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.comboBoxBirim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.db1DataSet = new Sirket_Takip_Uygulamasi.Db1DataSet();
            this.db1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimTableAdapter = new Sirket_Takip_Uygulamasi.Db1DataSetTableAdapters.birimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Soyad,
            this.Tc,
            this.Tel,
            this.Mail,
            this.Baslama,
            this.kalangün});
            this.dataGridView1.Location = new System.Drawing.Point(2, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(604, 415);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "personel_id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 45;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "ad";
            this.Ad.HeaderText = "AD";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            this.Ad.Width = 65;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "soyad";
            this.Soyad.HeaderText = "SOYAD";
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            this.Soyad.Width = 65;
            // 
            // Tc
            // 
            this.Tc.DataPropertyName = "tc";
            this.Tc.HeaderText = "TC";
            this.Tc.Name = "Tc";
            this.Tc.ReadOnly = true;
            this.Tc.Width = 70;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "tel";
            this.Tel.HeaderText = "TEL";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 80;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "mail";
            this.Mail.HeaderText = "MAİL";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 70;
            // 
            // Baslama
            // 
            this.Baslama.DataPropertyName = "baslama_tarih";
            this.Baslama.HeaderText = "BASLAMA";
            this.Baslama.Name = "Baslama";
            this.Baslama.ReadOnly = true;
            this.Baslama.Width = 80;
            // 
            // kalangün
            // 
            this.kalangün.DataPropertyName = "yıllıkizin_kalan";
            this.kalangün.HeaderText = "KALAN GÜN";
            this.kalangün.Name = "kalangün";
            this.kalangün.ReadOnly = true;
            this.kalangün.Width = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(624, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personel";
            // 
            // MailtextBox
            // 
            this.MailtextBox.Enabled = false;
            this.MailtextBox.Location = new System.Drawing.Point(734, 299);
            this.MailtextBox.Name = "MailtextBox";
            this.MailtextBox.Size = new System.Drawing.Size(122, 20);
            this.MailtextBox.TabIndex = 3;
            // 
            // TeltextBox
            // 
            this.TeltextBox.Enabled = false;
            this.TeltextBox.Location = new System.Drawing.Point(734, 273);
            this.TeltextBox.Name = "TeltextBox";
            this.TeltextBox.Size = new System.Drawing.Size(122, 20);
            this.TeltextBox.TabIndex = 4;
            // 
            // TctextBox
            // 
            this.TctextBox.Enabled = false;
            this.TctextBox.Location = new System.Drawing.Point(734, 247);
            this.TctextBox.Name = "TctextBox";
            this.TctextBox.Size = new System.Drawing.Size(122, 20);
            this.TctextBox.TabIndex = 5;
            // 
            // SoyadtextBox
            // 
            this.SoyadtextBox.Enabled = false;
            this.SoyadtextBox.Location = new System.Drawing.Point(734, 221);
            this.SoyadtextBox.Name = "SoyadtextBox";
            this.SoyadtextBox.Size = new System.Drawing.Size(122, 20);
            this.SoyadtextBox.TabIndex = 6;
            // 
            // AdtextBox
            // 
            this.AdtextBox.Enabled = false;
            this.AdtextBox.Location = new System.Drawing.Point(734, 195);
            this.AdtextBox.Name = "AdtextBox";
            this.AdtextBox.Size = new System.Drawing.Size(122, 20);
            this.AdtextBox.TabIndex = 7;
            // 
            // BaslamatextBox
            // 
            this.BaslamatextBox.Enabled = false;
            this.BaslamatextBox.Location = new System.Drawing.Point(734, 325);
            this.BaslamatextBox.Name = "BaslamatextBox";
            this.BaslamatextBox.Size = new System.Drawing.Size(122, 20);
            this.BaslamatextBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(652, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Başlama Tarih";
            // 
            // KalantextBox
            // 
            this.KalantextBox.Enabled = false;
            this.KalantextBox.Location = new System.Drawing.Point(734, 351);
            this.KalantextBox.Name = "KalantextBox";
            this.KalantextBox.Size = new System.Drawing.Size(122, 20);
            this.KalantextBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(652, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kalan yıllık izin";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Enabled = false;
            this.IdtextBox.Location = new System.Drawing.Point(734, 169);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(122, 20);
            this.IdtextBox.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(652, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Id";
            // 
            // Geributton
            // 
            this.Geributton.Location = new System.Drawing.Point(2, 3);
            this.Geributton.Name = "Geributton";
            this.Geributton.Size = new System.Drawing.Size(65, 26);
            this.Geributton.TabIndex = 14;
            this.Geributton.Text = "Geri";
            this.Geributton.UseVisualStyleBackColor = true;
            this.Geributton.Click += new System.EventHandler(this.Geributton_Click);
            // 
            // AratextBox
            // 
            this.AratextBox.Location = new System.Drawing.Point(172, 5);
            this.AratextBox.Name = "AratextBox";
            this.AratextBox.Size = new System.Drawing.Size(182, 20);
            this.AratextBox.TabIndex = 15;
            // 
            // Arabutton
            // 
            this.Arabutton.Location = new System.Drawing.Point(371, 3);
            this.Arabutton.Name = "Arabutton";
            this.Arabutton.Size = new System.Drawing.Size(65, 22);
            this.Arabutton.TabIndex = 16;
            this.Arabutton.Text = "Ara";
            this.Arabutton.UseVisualStyleBackColor = true;
            this.Arabutton.Click += new System.EventHandler(this.Arabutton_Click);
            // 
            // İzinbutton
            // 
            this.İzinbutton.Location = new System.Drawing.Point(707, 405);
            this.İzinbutton.Name = "İzinbutton";
            this.İzinbutton.Size = new System.Drawing.Size(122, 41);
            this.İzinbutton.TabIndex = 17;
            this.İzinbutton.Text = "İzin Al";
            this.İzinbutton.UseVisualStyleBackColor = true;
            this.İzinbutton.Click += new System.EventHandler(this.İzinbutton_Click);
            // 
            // radioButtonPersonel
            // 
            this.radioButtonPersonel.AutoSize = true;
            this.radioButtonPersonel.Location = new System.Drawing.Point(655, 60);
            this.radioButtonPersonel.Name = "radioButtonPersonel";
            this.radioButtonPersonel.Size = new System.Drawing.Size(66, 17);
            this.radioButtonPersonel.TabIndex = 18;
            this.radioButtonPersonel.TabStop = true;
            this.radioButtonPersonel.Text = "Personel";
            this.radioButtonPersonel.UseVisualStyleBackColor = true;
            // 
            // radioButtonBirim
            // 
            this.radioButtonBirim.AutoSize = true;
            this.radioButtonBirim.Location = new System.Drawing.Point(745, 60);
            this.radioButtonBirim.Name = "radioButtonBirim";
            this.radioButtonBirim.Size = new System.Drawing.Size(47, 17);
            this.radioButtonBirim.TabIndex = 18;
            this.radioButtonBirim.TabStop = true;
            this.radioButtonBirim.Text = "Birim";
            this.radioButtonBirim.UseVisualStyleBackColor = true;
            // 
            // radioButtonTümü
            // 
            this.radioButtonTümü.AutoSize = true;
            this.radioButtonTümü.Location = new System.Drawing.Point(823, 60);
            this.radioButtonTümü.Name = "radioButtonTümü";
            this.radioButtonTümü.Size = new System.Drawing.Size(52, 17);
            this.radioButtonTümü.TabIndex = 18;
            this.radioButtonTümü.TabStop = true;
            this.radioButtonTümü.Text = "Tümü";
            this.radioButtonTümü.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(624, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "İzin alınacak grup nedir?";
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(73, 3);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(65, 26);
            this.buttonYenile.TabIndex = 20;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // comboBoxBirim
            // 
            this.comboBoxBirim.DataSource = this.birimBindingSource;
            this.comboBoxBirim.DisplayMember = "birim_ad";
            this.comboBoxBirim.FormattingEnabled = true;
            this.comboBoxBirim.Location = new System.Drawing.Point(734, 105);
            this.comboBoxBirim.Name = "comboBoxBirim";
            this.comboBoxBirim.Size = new System.Drawing.Size(122, 21);
            this.comboBoxBirim.TabIndex = 21;
            this.comboBoxBirim.ValueMember = "birim_id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(624, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Birim";
            // 
            // db1DataSet
            // 
            this.db1DataSet.DataSetName = "Db1DataSet";
            this.db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db1DataSetBindingSource
            // 
            this.db1DataSetBindingSource.DataSource = this.db1DataSet;
            this.db1DataSetBindingSource.Position = 0;
            // 
            // birimBindingSource
            // 
            this.birimBindingSource.DataMember = "birim";
            this.birimBindingSource.DataSource = this.db1DataSetBindingSource;
            // 
            // birimTableAdapter
            // 
            this.birimTableAdapter.ClearBeforeFill = true;
            // 
            // İzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 456);
            this.Controls.Add(this.comboBoxBirim);
            this.Controls.Add(this.buttonYenile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButtonTümü);
            this.Controls.Add(this.radioButtonBirim);
            this.Controls.Add(this.radioButtonPersonel);
            this.Controls.Add(this.İzinbutton);
            this.Controls.Add(this.Arabutton);
            this.Controls.Add(this.AratextBox);
            this.Controls.Add(this.Geributton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaslamatextBox);
            this.Controls.Add(this.KalantextBox);
            this.Controls.Add(this.MailtextBox);
            this.Controls.Add(this.TeltextBox);
            this.Controls.Add(this.TctextBox);
            this.Controls.Add(this.SoyadtextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.AdtextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "İzin";
            this.Text = "İzin";
            this.Load += new System.EventHandler(this.İzin_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.İzin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MailtextBox;
        private System.Windows.Forms.TextBox TeltextBox;
        private System.Windows.Forms.TextBox TctextBox;
        private System.Windows.Forms.TextBox SoyadtextBox;
        private System.Windows.Forms.TextBox AdtextBox;
        private System.Windows.Forms.TextBox BaslamatextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox KalantextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Geributton;
        private System.Windows.Forms.TextBox AratextBox;
        private System.Windows.Forms.Button Arabutton;
        private System.Windows.Forms.Button İzinbutton;
        private System.Windows.Forms.RadioButton radioButtonPersonel;
        private System.Windows.Forms.RadioButton radioButtonBirim;
        private System.Windows.Forms.RadioButton radioButtonTümü;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonYenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalangün;
        private System.Windows.Forms.ComboBox comboBoxBirim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource db1DataSetBindingSource;
        private Db1DataSet db1DataSet;
        private System.Windows.Forms.BindingSource birimBindingSource;
        private Db1DataSetTableAdapters.birimTableAdapter birimTableAdapter;
    }
}