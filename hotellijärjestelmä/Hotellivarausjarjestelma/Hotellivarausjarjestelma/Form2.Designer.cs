namespace Hotellivarausjarjestelma
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VarausNroTB = new System.Windows.Forms.TextBox();
            this.SisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.UlosDTB = new System.Windows.Forms.DateTimePicker();
            this.AsiakasCB = new System.Windows.Forms.ComboBox();
            this.HuonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.HuoneNroCB = new System.Windows.Forms.ComboBox();
            this.UusiVarausPainike = new System.Windows.Forms.Button();
            this.MuokkaaVaraustaPainike = new System.Windows.Forms.Button();
            this.PoistaVarausPainike = new System.Windows.Forms.Button();
            this.TyhjennaVarausPainike = new System.Windows.Forms.Button();
            this.VarauksetDG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.VarauksetDG);
            this.panel1.Controls.Add(this.TyhjennaVarausPainike);
            this.panel1.Controls.Add(this.PoistaVarausPainike);
            this.panel1.Controls.Add(this.MuokkaaVaraustaPainike);
            this.panel1.Controls.Add(this.UusiVarausPainike);
            this.panel1.Controls.Add(this.HuoneNroCB);
            this.panel1.Controls.Add(this.HuonetyyppiCB);
            this.panel1.Controls.Add(this.AsiakasCB);
            this.panel1.Controls.Add(this.UlosDTB);
            this.panel1.Controls.Add(this.SisaanDTP);
            this.panel1.Controls.Add(this.VarausNroTB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 871);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1275, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(107, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varaus nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(99, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asiakas nro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(92, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Huonetyyppi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(88, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Huoneen nro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(146, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sisään:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(169, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ulos:";
            // 
            // VarausNroTB
            // 
            this.VarausNroTB.Location = new System.Drawing.Point(283, 160);
            this.VarausNroTB.Name = "VarausNroTB";
            this.VarausNroTB.Size = new System.Drawing.Size(299, 31);
            this.VarausNroTB.TabIndex = 7;
            // 
            // SisaanDTP
            // 
            this.SisaanDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SisaanDTP.Location = new System.Drawing.Point(283, 336);
            this.SisaanDTP.Name = "SisaanDTP";
            this.SisaanDTP.Size = new System.Drawing.Size(299, 31);
            this.SisaanDTP.TabIndex = 8;
            // 
            // UlosDTB
            // 
            this.UlosDTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UlosDTB.Location = new System.Drawing.Point(283, 379);
            this.UlosDTB.Name = "UlosDTB";
            this.UlosDTB.Size = new System.Drawing.Size(299, 31);
            this.UlosDTB.TabIndex = 9;
            // 
            // AsiakasCB
            // 
            this.AsiakasCB.FormattingEnabled = true;
            this.AsiakasCB.Location = new System.Drawing.Point(283, 203);
            this.AsiakasCB.Name = "AsiakasCB";
            this.AsiakasCB.Size = new System.Drawing.Size(299, 33);
            this.AsiakasCB.TabIndex = 10;
            // 
            // HuonetyyppiCB
            // 
            this.HuonetyyppiCB.FormattingEnabled = true;
            this.HuonetyyppiCB.Location = new System.Drawing.Point(283, 249);
            this.HuonetyyppiCB.Name = "HuonetyyppiCB";
            this.HuonetyyppiCB.Size = new System.Drawing.Size(299, 33);
            this.HuonetyyppiCB.TabIndex = 11;
            this.HuonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.HuonetyyppiCB_SelectedIndexChanged);
            // 
            // HuoneNroCB
            // 
            this.HuoneNroCB.FormattingEnabled = true;
            this.HuoneNroCB.Location = new System.Drawing.Point(283, 289);
            this.HuoneNroCB.Name = "HuoneNroCB";
            this.HuoneNroCB.Size = new System.Drawing.Size(299, 33);
            this.HuoneNroCB.TabIndex = 12;
            // 
            // UusiVarausPainike
            // 
            this.UusiVarausPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiVarausPainike.Location = new System.Drawing.Point(129, 430);
            this.UusiVarausPainike.Name = "UusiVarausPainike";
            this.UusiVarausPainike.Size = new System.Drawing.Size(198, 29);
            this.UusiVarausPainike.TabIndex = 13;
            this.UusiVarausPainike.Text = "Lisää uusi varaus";
            this.UusiVarausPainike.UseVisualStyleBackColor = true;
            this.UusiVarausPainike.Click += new System.EventHandler(this.UusiVarausPainike_Click);
            // 
            // MuokkaaVaraustaPainike
            // 
            this.MuokkaaVaraustaPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuokkaaVaraustaPainike.Location = new System.Drawing.Point(349, 430);
            this.MuokkaaVaraustaPainike.Name = "MuokkaaVaraustaPainike";
            this.MuokkaaVaraustaPainike.Size = new System.Drawing.Size(107, 29);
            this.MuokkaaVaraustaPainike.TabIndex = 14;
            this.MuokkaaVaraustaPainike.Text = "Muokkaa";
            this.MuokkaaVaraustaPainike.UseVisualStyleBackColor = true;
            this.MuokkaaVaraustaPainike.Click += new System.EventHandler(this.MuokkaaVaraustaPainike_Click);
            // 
            // PoistaVarausPainike
            // 
            this.PoistaVarausPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaVarausPainike.Location = new System.Drawing.Point(480, 430);
            this.PoistaVarausPainike.Name = "PoistaVarausPainike";
            this.PoistaVarausPainike.Size = new System.Drawing.Size(103, 29);
            this.PoistaVarausPainike.TabIndex = 15;
            this.PoistaVarausPainike.Text = "Poista";
            this.PoistaVarausPainike.UseVisualStyleBackColor = true;
            this.PoistaVarausPainike.Click += new System.EventHandler(this.PoistaVarausPainike_Click);
            // 
            // TyhjennaVarausPainike
            // 
            this.TyhjennaVarausPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaVarausPainike.Location = new System.Drawing.Point(409, 466);
            this.TyhjennaVarausPainike.Name = "TyhjennaVarausPainike";
            this.TyhjennaVarausPainike.Size = new System.Drawing.Size(174, 27);
            this.TyhjennaVarausPainike.TabIndex = 16;
            this.TyhjennaVarausPainike.Text = "Tyhjennä kentät";
            this.TyhjennaVarausPainike.UseVisualStyleBackColor = true;
            // 
            // VarauksetDG
            // 
            this.VarauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VarauksetDG.Location = new System.Drawing.Point(608, 160);
            this.VarauksetDG.Name = "VarauksetDG";
            this.VarauksetDG.Size = new System.Drawing.Size(664, 454);
            this.VarauksetDG.TabIndex = 17;
           
            this.VarauksetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 871);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsiakkaidenHallinta";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VarausNroTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker SisaanDTP;
        private System.Windows.Forms.DateTimePicker UlosDTB;
        private System.Windows.Forms.Button UusiVarausPainike;
        private System.Windows.Forms.ComboBox HuoneNroCB;
        private System.Windows.Forms.ComboBox HuonetyyppiCB;
        private System.Windows.Forms.ComboBox AsiakasCB;
        private System.Windows.Forms.Button TyhjennaVarausPainike;
        private System.Windows.Forms.Button PoistaVarausPainike;
        private System.Windows.Forms.Button MuokkaaVaraustaPainike;
        private System.Windows.Forms.DataGridView VarauksetDG;
    }
}