namespace Hotellivarausjarjestelma
{
    partial class HuoneidenHallinta
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
            this.HuoneetDG = new System.Windows.Forms.DataGridView();
            this.TyhjennaHuonePainike = new System.Windows.Forms.Button();
            this.PoistaHuonePainike = new System.Windows.Forms.Button();
            this.MuokkaaHuonePainike = new System.Windows.Forms.Button();
            this.UusiHuonePainike = new System.Windows.Forms.Button();
            this.HuonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.HuoneennroTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KyllaRB = new System.Windows.Forms.RadioButton();
            this.EiRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HuoneetDG
            // 
            this.HuoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HuoneetDG.Location = new System.Drawing.Point(771, 285);
            this.HuoneetDG.Name = "HuoneetDG";
            this.HuoneetDG.Size = new System.Drawing.Size(664, 454);
            this.HuoneetDG.TabIndex = 35;
            this.HuoneetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HuoneetDG_CellClick);
            // 
            // TyhjennaHuonePainike
            // 
            this.TyhjennaHuonePainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaHuonePainike.Location = new System.Drawing.Point(572, 591);
            this.TyhjennaHuonePainike.Name = "TyhjennaHuonePainike";
            this.TyhjennaHuonePainike.Size = new System.Drawing.Size(174, 27);
            this.TyhjennaHuonePainike.TabIndex = 34;
            this.TyhjennaHuonePainike.Text = "Tyhjennä kentät";
            this.TyhjennaHuonePainike.UseVisualStyleBackColor = true;
            this.TyhjennaHuonePainike.Click += new System.EventHandler(this.TyhjennaHuonePainike_Click);
            // 
            // PoistaHuonePainike
            // 
            this.PoistaHuonePainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaHuonePainike.Location = new System.Drawing.Point(643, 555);
            this.PoistaHuonePainike.Name = "PoistaHuonePainike";
            this.PoistaHuonePainike.Size = new System.Drawing.Size(103, 29);
            this.PoistaHuonePainike.TabIndex = 33;
            this.PoistaHuonePainike.Text = "Poista";
            this.PoistaHuonePainike.UseVisualStyleBackColor = true;
            this.PoistaHuonePainike.Click += new System.EventHandler(this.PoistaHuonePainike_Click);
            // 
            // MuokkaaHuonePainike
            // 
            this.MuokkaaHuonePainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuokkaaHuonePainike.Location = new System.Drawing.Point(512, 555);
            this.MuokkaaHuonePainike.Name = "MuokkaaHuonePainike";
            this.MuokkaaHuonePainike.Size = new System.Drawing.Size(107, 29);
            this.MuokkaaHuonePainike.TabIndex = 32;
            this.MuokkaaHuonePainike.Text = "Muokkaa";
            this.MuokkaaHuonePainike.UseVisualStyleBackColor = true;
            this.MuokkaaHuonePainike.Click += new System.EventHandler(this.MuokkaaHuonePainike_Click);
            // 
            // UusiHuonePainike
            // 
            this.UusiHuonePainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiHuonePainike.Location = new System.Drawing.Point(292, 555);
            this.UusiHuonePainike.Name = "UusiHuonePainike";
            this.UusiHuonePainike.Size = new System.Drawing.Size(198, 29);
            this.UusiHuonePainike.TabIndex = 31;
            this.UusiHuonePainike.Text = "Lisää uusi huone";
            this.UusiHuonePainike.UseVisualStyleBackColor = true;
            this.UusiHuonePainike.Click += new System.EventHandler(this.UusiHuonePainike_Click);
            // 
            // HuonetyyppiCB
            // 
            this.HuonetyyppiCB.FormattingEnabled = true;
            this.HuonetyyppiCB.Location = new System.Drawing.Point(447, 328);
            this.HuonetyyppiCB.Name = "HuonetyyppiCB";
            this.HuonetyyppiCB.Size = new System.Drawing.Size(299, 33);
            this.HuonetyyppiCB.TabIndex = 28;
            // 
            // HuoneennroTB
            // 
            this.HuoneennroTB.Location = new System.Drawing.Point(446, 285);
            this.HuoneennroTB.Name = "HuoneennroTB";
            this.HuoneennroTB.Size = new System.Drawing.Size(299, 31);
            this.HuoneennroTB.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(291, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Vapaa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(279, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Puhelin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(227, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(223, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Huoneen nro:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1435, 100);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(396, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huoneiden hallinta";
            // 
            // PuhelinTB
            // 
            this.PuhelinTB.Location = new System.Drawing.Point(447, 371);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(299, 31);
            this.PuhelinTB.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EiRB);
            this.panel1.Controls.Add(this.KyllaRB);
            this.panel1.Location = new System.Drawing.Point(447, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 59);
            this.panel1.TabIndex = 37;
            // 
            // KyllaRB
            // 
            this.KyllaRB.AutoSize = true;
            this.KyllaRB.ForeColor = System.Drawing.Color.LimeGreen;
            this.KyllaRB.Location = new System.Drawing.Point(4, 18);
            this.KyllaRB.Name = "KyllaRB";
            this.KyllaRB.Size = new System.Drawing.Size(77, 29);
            this.KyllaRB.TabIndex = 0;
            this.KyllaRB.TabStop = true;
            this.KyllaRB.Text = "Kyllä";
            this.KyllaRB.UseVisualStyleBackColor = true;
            // 
            // EiRB
            // 
            this.EiRB.AutoSize = true;
            this.EiRB.ForeColor = System.Drawing.Color.Crimson;
            this.EiRB.Location = new System.Drawing.Point(144, 18);
            this.EiRB.Name = "EiRB";
            this.EiRB.Size = new System.Drawing.Size(49, 29);
            this.EiRB.TabIndex = 1;
            this.EiRB.TabStop = true;
            this.EiRB.Text = "Ei";
            this.EiRB.UseVisualStyleBackColor = true;
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1436, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PuhelinTB);
            this.Controls.Add(this.HuoneetDG);
            this.Controls.Add(this.TyhjennaHuonePainike);
            this.Controls.Add(this.PoistaHuonePainike);
            this.Controls.Add(this.MuokkaaHuonePainike);
            this.Controls.Add(this.UusiHuonePainike);
            this.Controls.Add(this.HuonetyyppiCB);
            this.Controls.Add(this.HuoneennroTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "HuoneidenHallinta";
            this.Text = "Huoneidenhallinta";
            this.Load += new System.EventHandler(this.HuoneidenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HuoneetDG;
        private System.Windows.Forms.Button TyhjennaHuonePainike;
        private System.Windows.Forms.Button PoistaHuonePainike;
        private System.Windows.Forms.Button MuokkaaHuonePainike;
        private System.Windows.Forms.Button UusiHuonePainike;
        private System.Windows.Forms.ComboBox HuonetyyppiCB;
        private System.Windows.Forms.TextBox HuoneennroTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PuhelinTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton EiRB;
        private System.Windows.Forms.RadioButton KyllaRB;
    }
}