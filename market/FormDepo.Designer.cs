namespace market
{
    partial class FormDepo
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
            dataGridView1 = new DataGridView();
            cmbCategoryName = new ComboBox();
            btnAddProduct = new Button();
            txtProductName = new TextBox();
            txtAdet = new TextBox();
            txtPrice = new TextBox();
            btnSeciliUrunSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(453, 615);
            dataGridView1.TabIndex = 0;
            // 
            // cmbCategoryName
            // 
            cmbCategoryName.Anchor = AnchorStyles.None;
            cmbCategoryName.Font = new Font("Segoe UI", 15F);
            cmbCategoryName.FormattingEnabled = true;
            cmbCategoryName.Location = new Point(479, 39);
            cmbCategoryName.Name = "cmbCategoryName";
            cmbCategoryName.Size = new Size(253, 43);
            cmbCategoryName.TabIndex = 1;
            cmbCategoryName.Text = "Kategori Adı Seçiniz";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.None;
            btnAddProduct.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAddProduct.Location = new Point(1022, 39);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(180, 88);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Ürün Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.None;
            txtProductName.Font = new Font("Segoe UI", 15F);
            txtProductName.Location = new Point(738, 39);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(253, 41);
            txtProductName.TabIndex = 3;
            txtProductName.Text = "Ürün Adını Giriniz";
            // 
            // txtAdet
            // 
            txtAdet.Anchor = AnchorStyles.None;
            txtAdet.Font = new Font("Segoe UI", 15F);
            txtAdet.Location = new Point(479, 88);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(253, 41);
            txtAdet.TabIndex = 4;
            txtAdet.Text = "Ürün Adetini Giriniz";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.Font = new Font("Segoe UI", 15F);
            txtPrice.Location = new Point(738, 86);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(253, 41);
            txtPrice.TabIndex = 5;
            txtPrice.Text = "Ürün Fiyatını Giriniz";
            // 
            // btnSeciliUrunSil
            // 
            btnSeciliUrunSil.Anchor = AnchorStyles.None;
            btnSeciliUrunSil.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnSeciliUrunSil.Location = new Point(1022, 162);
            btnSeciliUrunSil.Name = "btnSeciliUrunSil";
            btnSeciliUrunSil.Size = new Size(178, 88);
            btnSeciliUrunSil.TabIndex = 6;
            btnSeciliUrunSil.Text = "Seçili Ürünü Sil";
            btnSeciliUrunSil.UseVisualStyleBackColor = true;
            btnSeciliUrunSil.Click += btnSeciliUrunSil_Click_1;
            // 
            // FormDepo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 615);
            Controls.Add(btnSeciliUrunSil);
            Controls.Add(txtPrice);
            Controls.Add(txtAdet);
            Controls.Add(txtProductName);
            Controls.Add(btnAddProduct);
            Controls.Add(cmbCategoryName);
            Controls.Add(dataGridView1);
            Name = "FormDepo";
            Text = "FormDepo";
            Load += FormDepo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbCategoryName;
        private Button btnAddProduct;
        private TextBox txtProductName;
        private TextBox txtAdet;
        private TextBox txtPrice;
        private Button btnSeciliUrunSil;
    }
}