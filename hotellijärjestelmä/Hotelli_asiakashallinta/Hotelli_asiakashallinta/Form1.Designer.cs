namespace Hotelli_asiakashallinta
{
    partial class ahForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.AsiakkaatDG = new System.Windows.Forms.DataGridView();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.lisaauusiBT = new System.Windows.Forms.Button();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.kayttajaLB = new System.Windows.Forms.Label();
            this.salasTB = new System.Windows.Forms.TextBox();
            this.salasLB = new System.Windows.Forms.Label();
            this.ptpTB = new System.Windows.Forms.TextBox();
            this.ptpLB = new System.Windows.Forms.Label();
            this.pnroTB = new System.Windows.Forms.TextBox();
            this.pnroLB = new System.Windows.Forms.Label();
            this.lahioTB = new System.Windows.Forms.TextBox();
            this.lahioLB = new System.Windows.Forms.Label();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.snimiLB = new System.Windows.Forms.Label();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.enimiLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.otsikkoLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 63);
            this.panel1.TabIndex = 0;
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikkoLB.Location = new System.Drawing.Point(223, 9);
            this.otsikkoLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(426, 42);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Asiakkaiden hallinta";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.tyhjennaBT);
            this.panel2.Controls.Add(this.poistaBT);
            this.panel2.Controls.Add(this.AsiakkaatDG);
            this.panel2.Controls.Add(this.muokkaaBT);
            this.panel2.Controls.Add(this.lisaauusiBT);
            this.panel2.Controls.Add(this.kayttajaTB);
            this.panel2.Controls.Add(this.kayttajaLB);
            this.panel2.Controls.Add(this.salasTB);
            this.panel2.Controls.Add(this.salasLB);
            this.panel2.Controls.Add(this.ptpTB);
            this.panel2.Controls.Add(this.ptpLB);
            this.panel2.Controls.Add(this.pnroTB);
            this.panel2.Controls.Add(this.pnroLB);
            this.panel2.Controls.Add(this.lahioTB);
            this.panel2.Controls.Add(this.lahioLB);
            this.panel2.Controls.Add(this.snimiTB);
            this.panel2.Controls.Add(this.snimiLB);
            this.panel2.Controls.Add(this.enimiTB);
            this.panel2.Controls.Add(this.enimiLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 376);
            this.panel2.TabIndex = 1;
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.BackColor = System.Drawing.Color.MintCream;
            this.tyhjennaBT.Location = new System.Drawing.Point(230, 300);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(196, 33);
            this.tyhjennaBT.TabIndex = 18;
            this.tyhjennaBT.Text = "Tyhjennä kentät";
            this.tyhjennaBT.UseVisualStyleBackColor = false;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.BackColor = System.Drawing.Color.MintCream;
            this.poistaBT.Location = new System.Drawing.Point(331, 261);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(95, 33);
            this.poistaBT.TabIndex = 17;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = false;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // AsiakkaatDG
            // 
            this.AsiakkaatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsiakkaatDG.Location = new System.Drawing.Point(440, 19);
            this.AsiakkaatDG.Name = "AsiakkaatDG";
            this.AsiakkaatDG.Size = new System.Drawing.Size(410, 345);
            this.AsiakkaatDG.TabIndex = 16;
            this.AsiakkaatDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsiakkaatDG_CellContentClick);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.BackColor = System.Drawing.Color.MintCream;
            this.muokkaaBT.Location = new System.Drawing.Point(230, 261);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(95, 33);
            this.muokkaaBT.TabIndex = 15;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = false;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // lisaauusiBT
            // 
            this.lisaauusiBT.BackColor = System.Drawing.Color.MintCream;
            this.lisaauusiBT.Location = new System.Drawing.Point(45, 261);
            this.lisaauusiBT.Name = "lisaauusiBT";
            this.lisaauusiBT.Size = new System.Drawing.Size(179, 33);
            this.lisaauusiBT.TabIndex = 14;
            this.lisaauusiBT.Text = "Lisää uusi asiakas";
            this.lisaauusiBT.UseVisualStyleBackColor = false;
            this.lisaauusiBT.Click += new System.EventHandler(this.lisaauusiBT_Click);
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(219, 179);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(207, 26);
            this.kayttajaTB.TabIndex = 13;
            // 
            // kayttajaLB
            // 
            this.kayttajaLB.AutoSize = true;
            this.kayttajaLB.Location = new System.Drawing.Point(55, 186);
            this.kayttajaLB.Name = "kayttajaLB";
            this.kayttajaLB.Size = new System.Drawing.Size(158, 19);
            this.kayttajaLB.TabIndex = 12;
            this.kayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // salasTB
            // 
            this.salasTB.Location = new System.Drawing.Point(219, 211);
            this.salasTB.Name = "salasTB";
            this.salasTB.Size = new System.Drawing.Size(207, 26);
            this.salasTB.TabIndex = 11;
            // 
            // salasLB
            // 
            this.salasLB.AutoSize = true;
            this.salasLB.Location = new System.Drawing.Point(121, 218);
            this.salasLB.Name = "salasLB";
            this.salasLB.Size = new System.Drawing.Size(92, 19);
            this.salasLB.TabIndex = 10;
            this.salasLB.Text = "Salasana:";
            // 
            // ptpTB
            // 
            this.ptpTB.Location = new System.Drawing.Point(219, 147);
            this.ptpTB.Name = "ptpTB";
            this.ptpTB.Size = new System.Drawing.Size(207, 26);
            this.ptpTB.TabIndex = 9;
            // 
            // ptpLB
            // 
            this.ptpLB.AutoSize = true;
            this.ptpLB.Location = new System.Drawing.Point(49, 154);
            this.ptpLB.Name = "ptpLB";
            this.ptpLB.Size = new System.Drawing.Size(164, 19);
            this.ptpLB.TabIndex = 8;
            this.ptpLB.Text = "Postitoimipaikka:";
            // 
            // pnroTB
            // 
            this.pnroTB.Location = new System.Drawing.Point(219, 115);
            this.pnroTB.Name = "pnroTB";
            this.pnroTB.Size = new System.Drawing.Size(207, 26);
            this.pnroTB.TabIndex = 7;
            // 
            // pnroLB
            // 
            this.pnroLB.AutoSize = true;
            this.pnroLB.Location = new System.Drawing.Point(89, 122);
            this.pnroLB.Name = "pnroLB";
            this.pnroLB.Size = new System.Drawing.Size(124, 19);
            this.pnroLB.TabIndex = 6;
            this.pnroLB.Text = "Postinumero:";
            // 
            // lahioTB
            // 
            this.lahioTB.Location = new System.Drawing.Point(219, 83);
            this.lahioTB.Name = "lahioTB";
            this.lahioTB.Size = new System.Drawing.Size(207, 26);
            this.lahioTB.TabIndex = 5;
            // 
            // lahioLB
            // 
            this.lahioLB.AutoSize = true;
            this.lahioLB.Location = new System.Drawing.Point(108, 90);
            this.lahioLB.Name = "lahioLB";
            this.lahioLB.Size = new System.Drawing.Size(105, 19);
            this.lahioLB.TabIndex = 4;
            this.lahioLB.Text = "Lähiosoite:";
            // 
            // snimiTB
            // 
            this.snimiTB.Location = new System.Drawing.Point(219, 51);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(207, 26);
            this.snimiTB.TabIndex = 3;
            // 
            // snimiLB
            // 
            this.snimiLB.AutoSize = true;
            this.snimiLB.Location = new System.Drawing.Point(120, 58);
            this.snimiLB.Name = "snimiLB";
            this.snimiLB.Size = new System.Drawing.Size(93, 19);
            this.snimiLB.TabIndex = 2;
            this.snimiLB.Text = "Sukunimi:";
            // 
            // enimiTB
            // 
            this.enimiTB.Location = new System.Drawing.Point(219, 19);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(207, 26);
            this.enimiTB.TabIndex = 1;
            // 
            // enimiLB
            // 
            this.enimiLB.AutoSize = true;
            this.enimiLB.Location = new System.Drawing.Point(133, 26);
            this.enimiLB.Name = "enimiLB";
            this.enimiLB.Size = new System.Drawing.Size(80, 19);
            this.enimiLB.TabIndex = 0;
            this.enimiLB.Text = "Etunimi:";
            // 
            // ahForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ahForm";
            this.Text = "AsiakkaidenHallinta";
            this.Load += new System.EventHandler(this.ahForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label otsikkoLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ptpTB;
        private System.Windows.Forms.Label ptpLB;
        private System.Windows.Forms.TextBox pnroTB;
        private System.Windows.Forms.Label pnroLB;
        private System.Windows.Forms.TextBox lahioTB;
        private System.Windows.Forms.Label lahioLB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.Label snimiLB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.Label enimiLB;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.Label kayttajaLB;
        private System.Windows.Forms.TextBox salasTB;
        private System.Windows.Forms.Label salasLB;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.DataGridView AsiakkaatDG;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.Button lisaauusiBT;
    }
}

