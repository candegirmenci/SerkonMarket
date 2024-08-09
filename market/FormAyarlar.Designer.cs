namespace market
{
    partial class FormAyarlar
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
            txtCategory = new TextBox();
            btnAddCategory = new Button();
            dataGridCategories = new DataGridView();
            btnDeleteCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCategories).BeginInit();
            SuspendLayout();
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.None;
            txtCategory.Font = new Font("Segoe UI", 14F);
            txtCategory.Location = new Point(686, 182);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(205, 39);
            txtCategory.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Anchor = AnchorStyles.None;
            btnAddCategory.Location = new Point(718, 227);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(129, 29);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "Kategori Ekle";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // dataGridCategories
            // 
            dataGridCategories.Anchor = AnchorStyles.None;
            dataGridCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategories.Location = new Point(12, 12);
            dataGridCategories.Name = "dataGridCategories";
            dataGridCategories.RowHeadersWidth = 51;
            dataGridCategories.Size = new Size(331, 488);
            dataGridCategories.TabIndex = 2;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Anchor = AnchorStyles.None;
            btnDeleteCategory.Location = new Point(1048, 177);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(160, 55);
            btnDeleteCategory.TabIndex = 3;
            btnDeleteCategory.Text = "Seçili Kategoriyi Sil";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // FormAyarlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 512);
            Controls.Add(btnDeleteCategory);
            Controls.Add(dataGridCategories);
            Controls.Add(btnAddCategory);
            Controls.Add(txtCategory);
            Name = "FormAyarlar";
            Text = "FormAyarlar";
            Load += FormAyarlar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategory;
        private Button btnAddCategory;
        private DataGridView dataGridCategories;
        private Button btnDeleteCategory;
    }
}