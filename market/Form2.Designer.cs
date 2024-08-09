namespace market
{
    partial class Form2
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
            btnUrunler = new Button();
            btnDepo = new Button();
            btnAyarlar = new Button();
            SuspendLayout();
            // 
            // btnUrunler
            // 
            btnUrunler.Anchor = AnchorStyles.None;
            btnUrunler.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnUrunler.Location = new Point(135, 123);
            btnUrunler.Name = "btnUrunler";
            btnUrunler.Size = new Size(150, 50);
            btnUrunler.TabIndex = 0;
            btnUrunler.Text = "Kasa";
            btnUrunler.UseVisualStyleBackColor = true;
            btnUrunler.Click += btnUrunler_Click;
            // 
            // btnDepo
            // 
            btnDepo.Anchor = AnchorStyles.None;
            btnDepo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnDepo.Location = new Point(291, 123);
            btnDepo.Name = "btnDepo";
            btnDepo.Size = new Size(150, 50);
            btnDepo.TabIndex = 1;
            btnDepo.Text = "Depo";
            btnDepo.UseVisualStyleBackColor = true;
            btnDepo.Click += btnDepo_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.Anchor = AnchorStyles.None;
            btnAyarlar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnAyarlar.Location = new Point(211, 179);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(150, 50);
            btnAyarlar.TabIndex = 2;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = true;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 345);
            Controls.Add(btnAyarlar);
            Controls.Add(btnDepo);
            Controls.Add(btnUrunler);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUrunler;
        private Button btnDepo;
        private Button btnAyarlar;
    }
}