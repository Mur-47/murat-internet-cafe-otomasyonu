namespace murat_internet_cafe_otomasyonu
{
    partial class frmSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.listView1 = new System.Windows.Forms.ListView();
            this.HareketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KullaniciID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._MasaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.masa_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IstekTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBLSaatUcretiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetCafeDataSet1 = new murat_internet_cafe_otomasyonu.InternetCafeDataSet1();
            this.cmbBosMasa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb180 = new System.Windows.Forms.RadioButton();
            this.rb165 = new System.Windows.Forms.RadioButton();
            this.rb150 = new System.Windows.Forms.RadioButton();
            this.rb135 = new System.Windows.Forms.RadioButton();
            this.rb120 = new System.Windows.Forms.RadioButton();
            this.rb105 = new System.Windows.Forms.RadioButton();
            this.rb90 = new System.Windows.Forms.RadioButton();
            this.rb75 = new System.Windows.Forms.RadioButton();
            this.rb60 = new System.Windows.Forms.RadioButton();
            this.rb40 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.rbsuresiz = new System.Windows.Forms.RadioButton();
            this.btnmasaac = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yöneticiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button20 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tBLSaatUcretiTableAdapter = new murat_internet_cafe_otomasyonu.InternetCafeDataSet1TableAdapters.TBLSaatUcretiTableAdapter();
            this.internetCafeDataSet2 = new murat_internet_cafe_otomasyonu.InternetCafeDataSet2();
            this.tBLSaatUcretiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLSaatUcretiTableAdapter1 = new murat_internet_cafe_otomasyonu.InternetCafeDataSet2TableAdapters.TBLSaatUcretiTableAdapter();
            this.cmbSaatUcreti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesapla = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MasaKapat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HareketID,
            this.KullaniciID,
            this._MasaID,
            this.masa_,
            this.IstekTuru,
            this._aciklama,
            this.Tarih_});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 139);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1243, 121);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // HareketID
            // 
            this.HareketID.Text = "İstek ID";
            this.HareketID.Width = 116;
            // 
            // KullaniciID
            // 
            this.KullaniciID.Text = "Kullanıcı ID";
            this.KullaniciID.Width = 164;
            // 
            // _MasaID
            // 
            this._MasaID.Text = "Masa ID";
            this._MasaID.Width = 125;
            // 
            // masa_
            // 
            this.masa_.Text = "Masa";
            this.masa_.Width = 141;
            // 
            // IstekTuru
            // 
            this.IstekTuru.Text = "İstek Türü";
            this.IstekTuru.Width = 222;
            // 
            // _aciklama
            // 
            this._aciklama.Text = "Açıklama";
            this._aciklama.Width = 257;
            // 
            // Tarih_
            // 
            this.Tarih_.Text = "Tarih";
            this.Tarih_.Width = 177;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Masa_ID,
            this._Masa,
            this.AcilisTuru,
            this.BaslamaSaati,
            this.BitisSaati,
            this.Sure,
            this.Tutar,
            this._Tarih,
            this.Hesapla,
            this.MasaKapat});
            this.dataGridView1.Location = new System.Drawing.Point(2, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 263);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tBLSaatUcretiBindingSource
            // 
            this.tBLSaatUcretiBindingSource.DataMember = "TBLSaatUcreti";
            this.tBLSaatUcretiBindingSource.DataSource = this.internetCafeDataSet1;
            // 
            // internetCafeDataSet1
            // 
            this.internetCafeDataSet1.DataSetName = "InternetCafeDataSet1";
            this.internetCafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBosMasa
            // 
            this.cmbBosMasa.FormattingEnabled = true;
            this.cmbBosMasa.Location = new System.Drawing.Point(1271, 215);
            this.cmbBosMasa.Name = "cmbBosMasa";
            this.cmbBosMasa.Size = new System.Drawing.Size(161, 21);
            this.cmbBosMasa.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1267, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Boş Masalar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb180);
            this.panel1.Controls.Add(this.rb165);
            this.panel1.Controls.Add(this.rb150);
            this.panel1.Controls.Add(this.rb135);
            this.panel1.Controls.Add(this.rb120);
            this.panel1.Controls.Add(this.rb105);
            this.panel1.Controls.Add(this.rb90);
            this.panel1.Controls.Add(this.rb75);
            this.panel1.Controls.Add(this.rb60);
            this.panel1.Controls.Add(this.rb40);
            this.panel1.Controls.Add(this.rb30);
            this.panel1.Controls.Add(this.rbsuresiz);
            this.panel1.Location = new System.Drawing.Point(1271, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 216);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rb180
            // 
            this.rb180.AutoSize = true;
            this.rb180.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb180.Location = new System.Drawing.Point(90, 193);
            this.rb180.Name = "rb180";
            this.rb180.Size = new System.Drawing.Size(59, 17);
            this.rb180.TabIndex = 0;
            this.rb180.TabStop = true;
            this.rb180.Text = "180 DK";
            this.rb180.UseVisualStyleBackColor = true;
            this.rb180.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb165
            // 
            this.rb165.AutoSize = true;
            this.rb165.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb165.Location = new System.Drawing.Point(12, 193);
            this.rb165.Name = "rb165";
            this.rb165.Size = new System.Drawing.Size(59, 17);
            this.rb165.TabIndex = 0;
            this.rb165.TabStop = true;
            this.rb165.Text = "165 DK";
            this.rb165.UseVisualStyleBackColor = true;
            this.rb165.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb150
            // 
            this.rb150.AutoSize = true;
            this.rb150.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb150.Location = new System.Drawing.Point(90, 157);
            this.rb150.Name = "rb150";
            this.rb150.Size = new System.Drawing.Size(59, 17);
            this.rb150.TabIndex = 0;
            this.rb150.TabStop = true;
            this.rb150.Text = "150 DK";
            this.rb150.UseVisualStyleBackColor = true;
            this.rb150.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb135
            // 
            this.rb135.AutoSize = true;
            this.rb135.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb135.Location = new System.Drawing.Point(12, 157);
            this.rb135.Name = "rb135";
            this.rb135.Size = new System.Drawing.Size(59, 17);
            this.rb135.TabIndex = 0;
            this.rb135.TabStop = true;
            this.rb135.Text = "135 DK";
            this.rb135.UseVisualStyleBackColor = true;
            this.rb135.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb120
            // 
            this.rb120.AutoSize = true;
            this.rb120.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb120.Location = new System.Drawing.Point(91, 121);
            this.rb120.Name = "rb120";
            this.rb120.Size = new System.Drawing.Size(59, 17);
            this.rb120.TabIndex = 0;
            this.rb120.TabStop = true;
            this.rb120.Text = "120 DK";
            this.rb120.UseVisualStyleBackColor = true;
            this.rb120.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb105
            // 
            this.rb105.AutoSize = true;
            this.rb105.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb105.Location = new System.Drawing.Point(12, 121);
            this.rb105.Name = "rb105";
            this.rb105.Size = new System.Drawing.Size(59, 17);
            this.rb105.TabIndex = 0;
            this.rb105.TabStop = true;
            this.rb105.Text = "105 DK";
            this.rb105.UseVisualStyleBackColor = true;
            this.rb105.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb90
            // 
            this.rb90.AutoSize = true;
            this.rb90.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb90.Location = new System.Drawing.Point(90, 84);
            this.rb90.Name = "rb90";
            this.rb90.Size = new System.Drawing.Size(55, 17);
            this.rb90.TabIndex = 0;
            this.rb90.TabStop = true;
            this.rb90.Text = "90 DK";
            this.rb90.UseVisualStyleBackColor = true;
            this.rb90.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb75
            // 
            this.rb75.AutoSize = true;
            this.rb75.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb75.Location = new System.Drawing.Point(12, 84);
            this.rb75.Name = "rb75";
            this.rb75.Size = new System.Drawing.Size(55, 17);
            this.rb75.TabIndex = 0;
            this.rb75.TabStop = true;
            this.rb75.Text = "75 DK";
            this.rb75.UseVisualStyleBackColor = true;
            this.rb75.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb60
            // 
            this.rb60.AutoSize = true;
            this.rb60.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb60.Location = new System.Drawing.Point(90, 49);
            this.rb60.Name = "rb60";
            this.rb60.Size = new System.Drawing.Size(55, 17);
            this.rb60.TabIndex = 0;
            this.rb60.TabStop = true;
            this.rb60.Text = "60 DK";
            this.rb60.UseVisualStyleBackColor = true;
            this.rb60.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb40
            // 
            this.rb40.AutoSize = true;
            this.rb40.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb40.Location = new System.Drawing.Point(12, 49);
            this.rb40.Name = "rb40";
            this.rb40.Size = new System.Drawing.Size(55, 17);
            this.rb40.TabIndex = 0;
            this.rb40.TabStop = true;
            this.rb40.Text = "45 DK";
            this.rb40.UseVisualStyleBackColor = true;
            this.rb40.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb30.Location = new System.Drawing.Point(91, 11);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(55, 17);
            this.rb30.TabIndex = 0;
            this.rb30.TabStop = true;
            this.rb30.Text = "30 DK";
            this.rb30.UseVisualStyleBackColor = true;
            this.rb30.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // rbsuresiz
            // 
            this.rbsuresiz.AutoSize = true;
            this.rbsuresiz.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbsuresiz.Location = new System.Drawing.Point(12, 11);
            this.rbsuresiz.Name = "rbsuresiz";
            this.rbsuresiz.Size = new System.Drawing.Size(60, 17);
            this.rbsuresiz.TabIndex = 0;
            this.rbsuresiz.TabStop = true;
            this.rbsuresiz.Text = "Süresiz";
            this.rbsuresiz.UseVisualStyleBackColor = true;
            this.rbsuresiz.CheckedChanged += new System.EventHandler(this.RadioButtonSecili);
            // 
            // btnmasaac
            // 
            this.btnmasaac.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmasaac.Location = new System.Drawing.Point(1271, 467);
            this.btnmasaac.Name = "btnmasaac";
            this.btnmasaac.Size = new System.Drawing.Size(161, 63);
            this.btnmasaac.TabIndex = 16;
            this.btnmasaac.Text = "Masa Aç";
            this.btnmasaac.UseVisualStyleBackColor = true;
            this.btnmasaac.Click += new System.EventHandler(this.btnmasaac_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "images.jpeg");
            this.ımageList1.Images.SetKeyName(1, "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
        "onitor-accessory-computer-wallpaper-removebg-preview.png");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiToolStripMenuItem1,
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem1,
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem1,
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(270, 92);
            // 
            // yöneticiToolStripMenuItem1
            // 
            this.yöneticiToolStripMenuItem1.Name = "yöneticiToolStripMenuItem1";
            this.yöneticiToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.yöneticiToolStripMenuItem1.Text = "Yönetici";
            // 
            // süresizMasaAçmaİsteğiGönderToolStripMenuItem1
            // 
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem1.Name = "süresizMasaAçmaİsteğiGönderToolStripMenuItem1";
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem1.Text = "Süresiz masa açma isteği gönder";
            // 
            // süreliMasaAçmaİsteğiGönderToolStripMenuItem1
            // 
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23});
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem1.Name = "süreliMasaAçmaİsteğiGönderToolStripMenuItem1";
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem1.Text = "Süreli masa açma isteği gönder";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem13.Text = "30";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem14.Text = "45";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem15.Text = "60";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem16.Text = "75";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem17.Text = "90";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem18.Text = "105";
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem19.Text = "120";
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem20.Text = "135";
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem21.Text = "150";
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem22.Text = "165";
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem23.Text = "180";
            // 
            // masaDeğiştirmeİsteğiGönderToolStripMenuItem1
            // 
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem1.Name = "masaDeğiştirmeİsteğiGönderToolStripMenuItem1";
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem1.Text = "Masa değiştirme isteği gönder";
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.ContextMenuStrip = this.contextMenuStrip2;
            this.button20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button20.ImageList = this.ımageList1;
            this.button20.Location = new System.Drawing.Point(1136, 536);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(120, 120);
            this.button20.TabIndex = 30;
            this.button20.Text = "Masa-20";
            this.button20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.ContextMenuStrip = this.contextMenuStrip2;
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(1136, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 120);
            this.button10.TabIndex = 30;
            this.button10.Text = "Masa-10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.ContextMenuStrip = this.contextMenuStrip2;
            this.button19.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button19.ImageList = this.ımageList1;
            this.button19.Location = new System.Drawing.Point(1010, 536);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(120, 120);
            this.button19.TabIndex = 30;
            this.button19.Text = "Masa-19";
            this.button19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.ContextMenuStrip = this.contextMenuStrip2;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(1010, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 120);
            this.button9.TabIndex = 30;
            this.button9.Text = "Masa-9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.ContextMenuStrip = this.contextMenuStrip2;
            this.button18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button18.ImageList = this.ımageList1;
            this.button18.Location = new System.Drawing.Point(884, 536);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(120, 120);
            this.button18.TabIndex = 30;
            this.button18.Text = "Masa-18";
            this.button18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.ContextMenuStrip = this.contextMenuStrip2;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(884, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 120);
            this.button8.TabIndex = 30;
            this.button8.Text = "Masa-8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.ContextMenuStrip = this.contextMenuStrip2;
            this.button17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button17.ImageList = this.ımageList1;
            this.button17.Location = new System.Drawing.Point(758, 536);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(120, 120);
            this.button17.TabIndex = 30;
            this.button17.Text = "Masa-17";
            this.button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.ContextMenuStrip = this.contextMenuStrip2;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(758, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 120);
            this.button7.TabIndex = 30;
            this.button7.Text = "Masa-7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.ContextMenuStrip = this.contextMenuStrip2;
            this.button16.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button16.ImageList = this.ımageList1;
            this.button16.Location = new System.Drawing.Point(632, 536);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 120);
            this.button16.TabIndex = 30;
            this.button16.Text = "Masa-16";
            this.button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.ContextMenuStrip = this.contextMenuStrip2;
            this.button15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button15.ImageList = this.ımageList1;
            this.button15.Location = new System.Drawing.Point(506, 536);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 120);
            this.button15.TabIndex = 30;
            this.button15.Text = "Masa-15";
            this.button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.ContextMenuStrip = this.contextMenuStrip2;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(632, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 120);
            this.button6.TabIndex = 30;
            this.button6.Text = "Masa-6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.ContextMenuStrip = this.contextMenuStrip2;
            this.button14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button14.ImageList = this.ımageList1;
            this.button14.Location = new System.Drawing.Point(380, 536);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 120);
            this.button14.TabIndex = 30;
            this.button14.Text = "Masa-14";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.ContextMenuStrip = this.contextMenuStrip2;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(506, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 120);
            this.button5.TabIndex = 30;
            this.button5.Text = "Masa-5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.ContextMenuStrip = this.contextMenuStrip2;
            this.button13.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button13.ImageList = this.ımageList1;
            this.button13.Location = new System.Drawing.Point(254, 536);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 120);
            this.button13.TabIndex = 30;
            this.button13.Text = "Masa-13";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.ContextMenuStrip = this.contextMenuStrip2;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(380, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 120);
            this.button4.TabIndex = 30;
            this.button4.Text = "Masa-4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.ContextMenuStrip = this.contextMenuStrip2;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button12.ImageList = this.ımageList1;
            this.button12.Location = new System.Drawing.Point(128, 536);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 120);
            this.button12.TabIndex = 30;
            this.button12.Text = "Masa-12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.ContextMenuStrip = this.contextMenuStrip2;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(254, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 120);
            this.button3.TabIndex = 30;
            this.button3.Text = "Masa-3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.ContextMenuStrip = this.contextMenuStrip2;
            this.button11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(2, 536);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 120);
            this.button11.TabIndex = 30;
            this.button11.Text = "Masa-11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ContextMenuStrip = this.contextMenuStrip2;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(128, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 120);
            this.button2.TabIndex = 30;
            this.button2.Text = "Masa-2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ContextMenuStrip = this.contextMenuStrip2;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageKey = "png-transparent-computer-icons-computer-monitors-monitor-icon-s-purple-computer-m" +
    "onitor-accessory-computer-wallpaper-removebg-preview.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(2, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 120);
            this.button1.TabIndex = 30;
            this.button1.Text = "Masa-1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // tBLSaatUcretiTableAdapter
            // 
            this.tBLSaatUcretiTableAdapter.ClearBeforeFill = true;
            // 
            // internetCafeDataSet2
            // 
            this.internetCafeDataSet2.DataSetName = "InternetCafeDataSet2";
            this.internetCafeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSaatUcretiBindingSource1
            // 
            this.tBLSaatUcretiBindingSource1.DataMember = "TBLSaatUcreti";
            this.tBLSaatUcretiBindingSource1.DataSource = this.internetCafeDataSet2;
            // 
            // tBLSaatUcretiTableAdapter1
            // 
            this.tBLSaatUcretiTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbSaatUcreti
            // 
            this.cmbSaatUcreti.DataSource = this.tBLSaatUcretiBindingSource;
            this.cmbSaatUcreti.DisplayMember = "SaatUcreti";
            this.cmbSaatUcreti.FormattingEnabled = true;
            this.cmbSaatUcreti.Location = new System.Drawing.Point(1271, 52);
            this.cmbSaatUcreti.Name = "cmbSaatUcreti";
            this.cmbSaatUcreti.Size = new System.Drawing.Size(161, 21);
            this.cmbSaatUcreti.TabIndex = 13;
            this.cmbSaatUcreti.ValueMember = "SaatUcretiID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1267, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Saat Ücreti";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "SepetID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Masa_ID
            // 
            this.Masa_ID.DataPropertyName = "MasaID";
            this.Masa_ID.HeaderText = "Masa ID";
            this.Masa_ID.Name = "Masa_ID";
            this.Masa_ID.ReadOnly = true;
            // 
            // _Masa
            // 
            this._Masa.DataPropertyName = "Masa";
            this._Masa.HeaderText = "Masa";
            this._Masa.Name = "_Masa";
            this._Masa.ReadOnly = true;
            // 
            // AcilisTuru
            // 
            this.AcilisTuru.DataPropertyName = "AcilisTuru";
            this.AcilisTuru.HeaderText = "Açılış Türü";
            this.AcilisTuru.Name = "AcilisTuru";
            this.AcilisTuru.ReadOnly = true;
            // 
            // BaslamaSaati
            // 
            this.BaslamaSaati.DataPropertyName = "Baslangic";
            this.BaslamaSaati.HeaderText = "Başlama Saati";
            this.BaslamaSaati.Name = "BaslamaSaati";
            this.BaslamaSaati.ReadOnly = true;
            // 
            // BitisSaati
            // 
            this.BitisSaati.HeaderText = "Bitiş Saati";
            this.BitisSaati.Name = "BitisSaati";
            this.BitisSaati.ReadOnly = true;
            // 
            // Sure
            // 
            this.Sure.HeaderText = "Süre";
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // _Tarih
            // 
            this._Tarih.DataPropertyName = "Tarih";
            this._Tarih.HeaderText = "Tarih";
            this._Tarih.Name = "_Tarih";
            this._Tarih.ReadOnly = true;
            // 
            // Hesapla
            // 
            this.Hesapla.HeaderText = "Hesapla";
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.ReadOnly = true;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.ToolTipText = "Hesaplama Yapar";
            this.Hesapla.UseColumnTextForButtonValue = true;
            // 
            // MasaKapat
            // 
            this.MasaKapat.HeaderText = "Masa Kapat";
            this.MasaKapat.Name = "MasaKapat";
            this.MasaKapat.ReadOnly = true;
            this.MasaKapat.Text = "Masa Kapat";
            this.MasaKapat.ToolTipText = "Masa Kapatır";
            this.MasaKapat.UseColumnTextForButtonValue = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 673);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmasaac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSaatUcreti);
            this.Controls.Add(this.cmbBosMasa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSatis_FormClosed);
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbBosMasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmasaac;
        private System.Windows.Forms.RadioButton rb180;
        private System.Windows.Forms.RadioButton rb165;
        private System.Windows.Forms.RadioButton rb150;
        private System.Windows.Forms.RadioButton rb135;
        private System.Windows.Forms.RadioButton rb120;
        private System.Windows.Forms.RadioButton rb105;
        private System.Windows.Forms.RadioButton rb90;
        private System.Windows.Forms.RadioButton rb75;
        private System.Windows.Forms.RadioButton rb60;
        private System.Windows.Forms.RadioButton rb40;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rbsuresiz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem süresizMasaAçmaİsteğiGönderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem süreliMasaAçmaİsteğiGönderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem masaDeğiştirmeİsteğiGönderToolStripMenuItem1;
        private InternetCafeDataSet1 internetCafeDataSet1;
        private System.Windows.Forms.BindingSource tBLSaatUcretiBindingSource;
        private InternetCafeDataSet1TableAdapters.TBLSaatUcretiTableAdapter tBLSaatUcretiTableAdapter;
        private InternetCafeDataSet2 internetCafeDataSet2;
        private System.Windows.Forms.BindingSource tBLSaatUcretiBindingSource1;
        private InternetCafeDataSet2TableAdapters.TBLSaatUcretiTableAdapter tBLSaatUcretiTableAdapter1;
        private System.Windows.Forms.ComboBox cmbSaatUcreti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader HareketID;
        private System.Windows.Forms.ColumnHeader KullaniciID;
        private System.Windows.Forms.ColumnHeader _MasaID;
        private System.Windows.Forms.ColumnHeader masa_;
        private System.Windows.Forms.ColumnHeader IstekTuru;
        private System.Windows.Forms.ColumnHeader _aciklama;
        private System.Windows.Forms.ColumnHeader Tarih_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Masa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Tarih;
        private System.Windows.Forms.DataGridViewButtonColumn Hesapla;
        private System.Windows.Forms.DataGridViewButtonColumn MasaKapat;
        private System.Windows.Forms.Timer timer1;
    }
}

