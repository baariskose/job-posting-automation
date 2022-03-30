
namespace IsIlaniOtomasyonu.Yonetici
{
    partial class YoneticiIsler
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgwIsVeren = new System.Windows.Forms.DataGridView();
            this.btnIsVerenSil = new System.Windows.Forms.Button();
            this.btnAliciSil = new System.Windows.Forms.Button();
            this.dgwIsArayan = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTarife = new System.Windows.Forms.Button();
            this.btnMeslek = new System.Windows.Forms.Button();
            this.btnSektor = new System.Windows.Forms.Button();
            this.btnHizmet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIsVeren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIsArayan)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 554);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgwIsVeren);
            this.tabPage1.Controls.Add(this.btnIsVerenSil);
            this.tabPage1.Controls.Add(this.btnAliciSil);
            this.tabPage1.Controls.Add(this.dgwIsArayan);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Üye İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgwIsVeren
            // 
            this.dgwIsVeren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIsVeren.Location = new System.Drawing.Point(26, 20);
            this.dgwIsVeren.Margin = new System.Windows.Forms.Padding(4);
            this.dgwIsVeren.Name = "dgwIsVeren";
            this.dgwIsVeren.Size = new System.Drawing.Size(813, 217);
            this.dgwIsVeren.TabIndex = 0;
            this.dgwIsVeren.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIsVeren_CellContentClick);
            // 
            // btnIsVerenSil
            // 
            this.btnIsVerenSil.BackColor = System.Drawing.Color.MintCream;
            this.btnIsVerenSil.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsVerenSil.Location = new System.Drawing.Point(134, 468);
            this.btnIsVerenSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnIsVerenSil.Name = "btnIsVerenSil";
            this.btnIsVerenSil.Size = new System.Drawing.Size(287, 46);
            this.btnIsVerenSil.TabIndex = 2;
            this.btnIsVerenSil.Text = "İŞ VERENİ SİL";
            this.btnIsVerenSil.UseVisualStyleBackColor = false;
            this.btnIsVerenSil.Click += new System.EventHandler(this.btnIsVerenSil_Click_1);
            // 
            // btnAliciSil
            // 
            this.btnAliciSil.BackColor = System.Drawing.Color.MintCream;
            this.btnAliciSil.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAliciSil.Location = new System.Drawing.Point(471, 468);
            this.btnAliciSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnAliciSil.Name = "btnAliciSil";
            this.btnAliciSil.Size = new System.Drawing.Size(273, 46);
            this.btnAliciSil.TabIndex = 3;
            this.btnAliciSil.Text = "İŞ BAŞVURANI SİL";
            this.btnAliciSil.UseVisualStyleBackColor = false;
            this.btnAliciSil.Click += new System.EventHandler(this.btnAliciSil_Click_1);
            // 
            // dgwIsArayan
            // 
            this.dgwIsArayan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIsArayan.Location = new System.Drawing.Point(26, 243);
            this.dgwIsArayan.Margin = new System.Windows.Forms.Padding(4);
            this.dgwIsArayan.Name = "dgwIsArayan";
            this.dgwIsArayan.Size = new System.Drawing.Size(813, 217);
            this.dgwIsArayan.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnTarife);
            this.tabPage2.Controls.Add(this.btnMeslek);
            this.tabPage2.Controls.Add(this.btnSektor);
            this.tabPage2.Controls.Add(this.btnHizmet);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Site Hakkında";
            // 
            // btnTarife
            // 
            this.btnTarife.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTarife.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTarife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarife.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarife.Location = new System.Drawing.Point(503, 287);
            this.btnTarife.Margin = new System.Windows.Forms.Padding(4);
            this.btnTarife.Name = "btnTarife";
            this.btnTarife.Size = new System.Drawing.Size(215, 154);
            this.btnTarife.TabIndex = 7;
            this.btnTarife.Text = "TARİFE İŞLEMLERİ";
            this.btnTarife.UseVisualStyleBackColor = false;
            this.btnTarife.Click += new System.EventHandler(this.btnTarife_Click);
            // 
            // btnMeslek
            // 
            this.btnMeslek.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMeslek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMeslek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeslek.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMeslek.Location = new System.Drawing.Point(503, 78);
            this.btnMeslek.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeslek.Name = "btnMeslek";
            this.btnMeslek.Size = new System.Drawing.Size(215, 153);
            this.btnMeslek.TabIndex = 6;
            this.btnMeslek.Text = "MESLEK İŞLEMLERİ";
            this.btnMeslek.UseVisualStyleBackColor = false;
            this.btnMeslek.Click += new System.EventHandler(this.btnMeslek_Click);
            // 
            // btnSektor
            // 
            this.btnSektor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSektor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSektor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSektor.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSektor.Location = new System.Drawing.Point(174, 287);
            this.btnSektor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSektor.Name = "btnSektor";
            this.btnSektor.Size = new System.Drawing.Size(224, 154);
            this.btnSektor.TabIndex = 5;
            this.btnSektor.Text = "SEKTÖR İŞLEMLERİ";
            this.btnSektor.UseVisualStyleBackColor = false;
            this.btnSektor.Click += new System.EventHandler(this.btnSektor_Click);
            // 
            // btnHizmet
            // 
            this.btnHizmet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHizmet.FlatAppearance.BorderSize = 0;
            this.btnHizmet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHizmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizmet.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmet.Location = new System.Drawing.Point(174, 78);
            this.btnHizmet.Margin = new System.Windows.Forms.Padding(4);
            this.btnHizmet.Name = "btnHizmet";
            this.btnHizmet.Size = new System.Drawing.Size(224, 153);
            this.btnHizmet.TabIndex = 4;
            this.btnHizmet.Text = "HİZMET İŞLEMLERİ";
            this.btnHizmet.UseVisualStyleBackColor = false;
            this.btnHizmet.Click += new System.EventHandler(this.btnHizmet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::IsIlaniOtomasyonu.Properties.Resources.gecis;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = global::IsIlaniOtomasyonu.Properties.Resources.reply_message__2_;
            this.button1.Location = new System.Drawing.Point(810, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // YoneticiIsler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YoneticiIsler";
            this.Text = "YoneticiIsler";
            this.Load += new System.EventHandler(this.YoneticiIsler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIsVeren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIsArayan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgwIsVeren;
        public System.Windows.Forms.DataGridView dgwIsArayan;
        private System.Windows.Forms.Button btnIsVerenSil;
        private System.Windows.Forms.Button btnAliciSil;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTarife;
        private System.Windows.Forms.Button btnMeslek;
        private System.Windows.Forms.Button btnSektor;
        private System.Windows.Forms.Button btnHizmet;
        private System.Windows.Forms.Button button1;
    }
}