namespace market
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            btncikis = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btntoplam = new Button();
            btnBack = new Button();
            btnsil = new Button();
            lblToplamFiyat = new Label();
            btnTemizle = new Button();
            btnAltaAl = new Button();
            btnKucult = new Button();
            btn2Carp = new Button();
            btn3Carp = new Button();
            btn5Carp = new Button();
            btn8Carp = new Button();
            btn10Carp = new Button();
            flowLayoutCarpan = new FlowLayoutPanel();
            flowLayoutCategories = new FlowLayoutPanel();
            CategoryButton = new Button();
            txtFiyat = new TextBox();
            btnSepeteEkle = new Button();
            flowLayoutCarpan.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(1641, 262);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(276, 579);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(1641, 148);
            label1.Name = "label1";
            label1.Size = new Size(276, 90);
            label1.TabIndex = 2;
            label1.Text = "SEPET";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btncikis
            // 
            btncikis.Anchor = AnchorStyles.None;
            btncikis.BackColor = Color.Transparent;
            btncikis.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btncikis.Location = new Point(1884, 12);
            btncikis.Name = "btncikis";
            btncikis.Size = new Size(33, 35);
            btncikis.TabIndex = 3;
            btncikis.Text = "X";
            btncikis.TextAlign = ContentAlignment.BottomCenter;
            btncikis.UseVisualStyleBackColor = false;
            btncikis.Click += btncikis_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(240, 148);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1252, 770);
            tableLayoutPanel1.TabIndex = 11;
            tableLayoutPanel1.Visible = false;
            // 
            // btntoplam
            // 
            btntoplam.Anchor = AnchorStyles.None;
            btntoplam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btntoplam.ImageAlign = ContentAlignment.MiddleLeft;
            btntoplam.Location = new Point(1641, 892);
            btntoplam.Name = "btntoplam";
            btntoplam.Size = new Size(114, 52);
            btntoplam.TabIndex = 12;
            btntoplam.Text = "Siparişi Bitir";
            btntoplam.UseVisualStyleBackColor = true;
            btntoplam.Click += btntoplam_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.Location = new Point(243, 61);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 45);
            btnBack.TabIndex = 21;
            btnBack.Text = "Ana Sayfa";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnsil
            // 
            btnsil.Anchor = AnchorStyles.None;
            btnsil.Location = new Point(1566, 559);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(69, 282);
            btnsil.TabIndex = 22;
            btnsil.Text = "Seçili öğeyi kaldır";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.Anchor = AnchorStyles.None;
            lblToplamFiyat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblToplamFiyat.Location = new Point(1761, 889);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(156, 52);
            lblToplamFiyat.TabIndex = 25;
            // 
            // btnTemizle
            // 
            btnTemizle.Anchor = AnchorStyles.None;
            btnTemizle.Location = new Point(1566, 262);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(69, 291);
            btnTemizle.TabIndex = 27;
            btnTemizle.Text = "Bütün Ürünleri Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnAltaAl
            // 
            btnAltaAl.Anchor = AnchorStyles.None;
            btnAltaAl.BackColor = Color.Transparent;
            btnAltaAl.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnAltaAl.Location = new Point(1806, 12);
            btnAltaAl.Name = "btnAltaAl";
            btnAltaAl.Size = new Size(33, 35);
            btnAltaAl.TabIndex = 28;
            btnAltaAl.Text = "-";
            btnAltaAl.TextAlign = ContentAlignment.TopCenter;
            btnAltaAl.UseVisualStyleBackColor = false;
            btnAltaAl.Click += btnAltaAl_Click;
            // 
            // btnKucult
            // 
            btnKucult.Anchor = AnchorStyles.None;
            btnKucult.BackColor = Color.Transparent;
            btnKucult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnKucult.Location = new Point(1845, 12);
            btnKucult.Name = "btnKucult";
            btnKucult.Size = new Size(33, 35);
            btnKucult.TabIndex = 29;
            btnKucult.Text = "□";
            btnKucult.TextAlign = ContentAlignment.TopCenter;
            btnKucult.UseVisualStyleBackColor = false;
            // 
            // btn2Carp
            // 
            btn2Carp.Anchor = AnchorStyles.None;
            btn2Carp.Location = new Point(3, 3);
            btn2Carp.Name = "btn2Carp";
            btn2Carp.Size = new Size(100, 40);
            btn2Carp.TabIndex = 30;
            btn2Carp.Text = "x2";
            btn2Carp.UseVisualStyleBackColor = true;
            btn2Carp.Click += btn2Carp_Click;
            // 
            // btn3Carp
            // 
            btn3Carp.Anchor = AnchorStyles.None;
            btn3Carp.Location = new Point(109, 3);
            btn3Carp.Name = "btn3Carp";
            btn3Carp.Size = new Size(100, 40);
            btn3Carp.TabIndex = 31;
            btn3Carp.Text = "x3";
            btn3Carp.UseVisualStyleBackColor = true;
            btn3Carp.Click += btn3Carp_Click;
            // 
            // btn5Carp
            // 
            btn5Carp.Anchor = AnchorStyles.None;
            btn5Carp.Location = new Point(215, 3);
            btn5Carp.Name = "btn5Carp";
            btn5Carp.Size = new Size(100, 40);
            btn5Carp.TabIndex = 32;
            btn5Carp.Text = "x5";
            btn5Carp.UseVisualStyleBackColor = true;
            btn5Carp.Click += btn5Carp_Click;
            // 
            // btn8Carp
            // 
            btn8Carp.Anchor = AnchorStyles.None;
            btn8Carp.Location = new Point(321, 3);
            btn8Carp.Name = "btn8Carp";
            btn8Carp.Size = new Size(100, 40);
            btn8Carp.TabIndex = 33;
            btn8Carp.Text = "x8";
            btn8Carp.UseVisualStyleBackColor = true;
            btn8Carp.Click += btn8Carp_Click;
            // 
            // btn10Carp
            // 
            btn10Carp.Anchor = AnchorStyles.None;
            btn10Carp.Location = new Point(427, 3);
            btn10Carp.Name = "btn10Carp";
            btn10Carp.Size = new Size(100, 40);
            btn10Carp.TabIndex = 34;
            btn10Carp.Text = "x10";
            btn10Carp.UseVisualStyleBackColor = true;
            btn10Carp.Click += btn10Carp_Click;
            // 
            // flowLayoutCarpan
            // 
            flowLayoutCarpan.Anchor = AnchorStyles.None;
            flowLayoutCarpan.Controls.Add(btn2Carp);
            flowLayoutCarpan.Controls.Add(btn3Carp);
            flowLayoutCarpan.Controls.Add(btn5Carp);
            flowLayoutCarpan.Controls.Add(btn8Carp);
            flowLayoutCarpan.Controls.Add(btn10Carp);
            flowLayoutCarpan.Location = new Point(584, 928);
            flowLayoutCarpan.Name = "flowLayoutCarpan";
            flowLayoutCarpan.Size = new Size(533, 49);
            flowLayoutCarpan.TabIndex = 35;
            // 
            // flowLayoutCategories
            // 
            flowLayoutCategories.Anchor = AnchorStyles.None;
            flowLayoutCategories.AutoScroll = true;
            flowLayoutCategories.Location = new Point(37, 148);
            flowLayoutCategories.Name = "flowLayoutCategories";
            flowLayoutCategories.Size = new Size(134, 770);
            flowLayoutCategories.TabIndex = 26;
            // 
            // CategoryButton
            // 
            CategoryButton.Location = new Point(995, 96);
            CategoryButton.Name = "CategoryButton";
            CategoryButton.Size = new Size(10, 10);
            CategoryButton.TabIndex = 36;
            CategoryButton.UseVisualStyleBackColor = true;
            CategoryButton.Visible = false;
            CategoryButton.Click += CategoryButton_Click;
            // 
            // txtFiyat
            // 
            txtFiyat.Anchor = AnchorStyles.None;
            txtFiyat.Font = new Font("Segoe UI", 14F);
            txtFiyat.Location = new Point(1641, 847);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(164, 39);
            txtFiyat.TabIndex = 37;
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.Anchor = AnchorStyles.None;
            btnSepeteEkle.Location = new Point(1815, 847);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(97, 39);
            btnSepeteEkle.TabIndex = 38;
            btnSepeteEkle.Text = "Sepete Ekle";
            btnSepeteEkle.UseVisualStyleBackColor = true;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnSepeteEkle);
            Controls.Add(txtFiyat);
            Controls.Add(CategoryButton);
            Controls.Add(flowLayoutCarpan);
            Controls.Add(btnKucult);
            Controls.Add(btnAltaAl);
            Controls.Add(btnTemizle);
            Controls.Add(flowLayoutCategories);
            Controls.Add(lblToplamFiyat);
            Controls.Add(btnsil);
            Controls.Add(btntoplam);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btncikis);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnBack);
            Name = "Form1";
            Text = "Serkon Market";
            Load += Form1_Load;
            flowLayoutCarpan.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Label label1;
        private Button btncikis;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btntoplam;
        private Button btnBack;
        private Button btnsil;
        private Label lblToplamFiyat;
        private Button btnTemizle;
        private Button btnAltaAl;
        private Button btnKucult;
        private Button btn2Carp;
        private Button btn3Carp;
        private Button btn5Carp;
        private Button btn8Carp;
        private Button btn10Carp;
        private FlowLayoutPanel flowLayoutCarpan;
        private FlowLayoutPanel flowLayoutCategories;
        private Button CategoryButton;
        private TextBox txtFiyat;
        private Button btnSepeteEkle;
    }
}