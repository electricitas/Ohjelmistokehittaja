namespace Kirjautumisikkuna
{
    partial class Kirjautumisikkuna
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KirjauduLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.KirjauduPainike = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kirjautumisikkuna.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(182, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // KirjauduLB
            // 
            this.KirjauduLB.BackColor = System.Drawing.Color.Yellow;
            this.KirjauduLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduLB.Location = new System.Drawing.Point(115, 10);
            this.KirjauduLB.Name = "KirjauduLB";
            this.KirjauduLB.Size = new System.Drawing.Size(275, 41);
            this.KirjauduLB.TabIndex = 1;
            this.KirjauduLB.Text = "Kirjaudu sisään";
            this.KirjauduLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SalasanaTB);
            this.groupBox1.Controls.Add(this.KayttajaTB);
            this.groupBox1.Controls.Add(this.KirjauduPainike);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalasanaTB.Location = new System.Drawing.Point(170, 99);
            this.SalasanaTB.Multiline = true;
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(284, 32);
            this.SalasanaTB.TabIndex = 4;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KayttajaTB.Location = new System.Drawing.Point(170, 53);
            this.KayttajaTB.Multiline = true;
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(284, 31);
            this.KayttajaTB.TabIndex = 3;
            // 
            // KirjauduPainike
            // 
            this.KirjauduPainike.BackColor = System.Drawing.Color.Tomato;
            this.KirjauduPainike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KirjauduPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduPainike.ForeColor = System.Drawing.Color.White;
            this.KirjauduPainike.Location = new System.Drawing.Point(41, 179);
            this.KirjauduPainike.Name = "KirjauduPainike";
            this.KirjauduPainike.Size = new System.Drawing.Size(413, 53);
            this.KirjauduPainike.TabIndex = 2;
            this.KirjauduPainike.Text = "Kirjaudu";
            this.KirjauduPainike.UseVisualStyleBackColor = false;
            this.KirjauduPainike.Click += new System.EventHandler(this.KirjauduPainike_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salasana: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Käyttäjä: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.KirjauduLB);
            this.panel1.Location = new System.Drawing.Point(12, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 66);
            this.panel1.TabIndex = 3;
            // 
            // Kirjautumisikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(527, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Kirjautumisikkuna";
            this.Text = "Kirjautumisikkuna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label KirjauduLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Button KirjauduPainike;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

