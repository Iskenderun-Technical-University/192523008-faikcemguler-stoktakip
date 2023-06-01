namespace stok_takip
{
    partial class frmürünlistele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.satışfiyatıtxt = new System.Windows.Forms.TextBox();
            this.alışfiyatıtxt = new System.Windows.Forms.TextBox();
            this.miktarıtxt = new System.Windows.Forms.TextBox();
            this.ürünadıtxt = new System.Windows.Forms.TextBox();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.kategoritxt = new System.Windows.Forms.TextBox();
            this.barkodnotxt = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.txtbarkodara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.COMBOKATEGORİ = new System.Windows.Forms.ComboBox();
            this.COMBOMARKA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmarkagüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(173, 432);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(115, 36);
            this.btngüncelle.TabIndex = 24;
            this.btngüncelle.Text = "GÜNCELLE\r\n";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "SATIŞ FİYATI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "ALIŞ FİYATI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "MİKTARI:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "ÜRÜN ADI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "MARKA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "KATEGORİ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "BARKOD NO:";
            // 
            // satışfiyatıtxt
            // 
            this.satışfiyatıtxt.Location = new System.Drawing.Point(141, 385);
            this.satışfiyatıtxt.Name = "satışfiyatıtxt";
            this.satışfiyatıtxt.Size = new System.Drawing.Size(147, 22);
            this.satışfiyatıtxt.TabIndex = 28;
            // 
            // alışfiyatıtxt
            // 
            this.alışfiyatıtxt.Location = new System.Drawing.Point(141, 329);
            this.alışfiyatıtxt.Name = "alışfiyatıtxt";
            this.alışfiyatıtxt.Size = new System.Drawing.Size(147, 22);
            this.alışfiyatıtxt.TabIndex = 27;
            // 
            // miktarıtxt
            // 
            this.miktarıtxt.Location = new System.Drawing.Point(141, 276);
            this.miktarıtxt.Name = "miktarıtxt";
            this.miktarıtxt.Size = new System.Drawing.Size(147, 22);
            this.miktarıtxt.TabIndex = 26;
            // 
            // ürünadıtxt
            // 
            this.ürünadıtxt.Location = new System.Drawing.Point(141, 226);
            this.ürünadıtxt.Name = "ürünadıtxt";
            this.ürünadıtxt.Size = new System.Drawing.Size(147, 22);
            this.ürünadıtxt.TabIndex = 25;
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(141, 173);
            this.markatxt.Name = "markatxt";
            this.markatxt.ReadOnly = true;
            this.markatxt.Size = new System.Drawing.Size(147, 22);
            this.markatxt.TabIndex = 23;
            // 
            // kategoritxt
            // 
            this.kategoritxt.Location = new System.Drawing.Point(141, 126);
            this.kategoritxt.Name = "kategoritxt";
            this.kategoritxt.ReadOnly = true;
            this.kategoritxt.Size = new System.Drawing.Size(147, 22);
            this.kategoritxt.TabIndex = 22;
            // 
            // barkodnotxt
            // 
            this.barkodnotxt.Location = new System.Drawing.Point(141, 75);
            this.barkodnotxt.Name = "barkodnotxt";
            this.barkodnotxt.Size = new System.Drawing.Size(147, 22);
            this.barkodnotxt.TabIndex = 21;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(909, 75);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(87, 42);
            this.btnsil.TabIndex = 36;
            this.btnsil.Text = "SİL\r\n";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtbarkodara
            // 
            this.txtbarkodara.Location = new System.Drawing.Point(741, 30);
            this.txtbarkodara.Name = "txtbarkodara";
            this.txtbarkodara.Size = new System.Drawing.Size(152, 22);
            this.txtbarkodara.TabIndex = 37;
            this.txtbarkodara.TextChanged += new System.EventHandler(this.txtbarkodara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "BARKOD İLE ARA:";
            // 
            // COMBOKATEGORİ
            // 
            this.COMBOKATEGORİ.FormattingEnabled = true;
            this.COMBOKATEGORİ.Location = new System.Drawing.Point(536, 465);
            this.COMBOKATEGORİ.Name = "COMBOKATEGORİ";
            this.COMBOKATEGORİ.Size = new System.Drawing.Size(147, 24);
            this.COMBOKATEGORİ.TabIndex = 39;
            this.COMBOKATEGORİ.SelectedIndexChanged += new System.EventHandler(this.COMBOKATEGORİ_SelectedIndexChanged);
            // 
            // COMBOMARKA
            // 
            this.COMBOMARKA.FormattingEnabled = true;
            this.COMBOMARKA.Location = new System.Drawing.Point(536, 512);
            this.COMBOMARKA.Name = "COMBOMARKA";
            this.COMBOMARKA.Size = new System.Drawing.Size(147, 24);
            this.COMBOMARKA.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "MARKA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "KATEGORİ:";
            // 
            // btnmarkagüncelle
            // 
            this.btnmarkagüncelle.Location = new System.Drawing.Point(716, 483);
            this.btnmarkagüncelle.Name = "btnmarkagüncelle";
            this.btnmarkagüncelle.Size = new System.Drawing.Size(115, 36);
            this.btnmarkagüncelle.TabIndex = 43;
            this.btnmarkagüncelle.Text = "GÜNCELLE\r\n";
            this.btnmarkagüncelle.UseVisualStyleBackColor = true;
            this.btnmarkagüncelle.Click += new System.EventHandler(this.btnmarkagüncelle_Click);
            // 
            // frmürünlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 597);
            this.Controls.Add(this.btnmarkagüncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COMBOMARKA);
            this.Controls.Add(this.COMBOKATEGORİ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbarkodara);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.satışfiyatıtxt);
            this.Controls.Add(this.alışfiyatıtxt);
            this.Controls.Add(this.miktarıtxt);
            this.Controls.Add(this.ürünadıtxt);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.kategoritxt);
            this.Controls.Add(this.barkodnotxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmürünlistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN LİSTELEME SAYFASI";
            this.Load += new System.EventHandler(this.frmürünlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox satışfiyatıtxt;
        private System.Windows.Forms.TextBox alışfiyatıtxt;
        private System.Windows.Forms.TextBox miktarıtxt;
        private System.Windows.Forms.TextBox ürünadıtxt;
        private System.Windows.Forms.TextBox markatxt;
        private System.Windows.Forms.TextBox kategoritxt;
        private System.Windows.Forms.TextBox barkodnotxt;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txtbarkodara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox COMBOKATEGORİ;
        private System.Windows.Forms.ComboBox COMBOMARKA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmarkagüncelle;
    }
}