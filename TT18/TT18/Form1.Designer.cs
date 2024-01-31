namespace TT18
{
    partial class AvainhenkilotForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.osoiteLB = new System.Windows.Forms.Label();
            this.postinumeroLB = new System.Windows.Forms.Label();
            this.postitoimipaikkaLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.osastoLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.vastuuhloCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(68, 165);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(154, 33);
            this.oppilaitosCB.TabIndex = 2;
            this.oppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // osoiteLB
            // 
            this.osoiteLB.AutoSize = true;
            this.osoiteLB.Location = new System.Drawing.Point(71, 217);
            this.osoiteLB.Name = "osoiteLB";
            this.osoiteLB.Size = new System.Drawing.Size(66, 25);
            this.osoiteLB.TabIndex = 3;
            this.osoiteLB.Text = "Osoite";
            // 
            // postinumeroLB
            // 
            this.postinumeroLB.AutoSize = true;
            this.postinumeroLB.Location = new System.Drawing.Point(71, 261);
            this.postinumeroLB.Name = "postinumeroLB";
            this.postinumeroLB.Size = new System.Drawing.Size(118, 25);
            this.postinumeroLB.TabIndex = 4;
            this.postinumeroLB.Text = "Postinumero";
            // 
            // postitoimipaikkaLB
            // 
            this.postitoimipaikkaLB.AutoSize = true;
            this.postitoimipaikkaLB.Location = new System.Drawing.Point(71, 305);
            this.postitoimipaikkaLB.Name = "postitoimipaikkaLB";
            this.postitoimipaikkaLB.Size = new System.Drawing.Size(149, 25);
            this.postitoimipaikkaLB.TabIndex = 5;
            this.postitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Location = new System.Drawing.Point(71, 349);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(76, 25);
            this.puhelinLB.TabIndex = 6;
            this.puhelinLB.Text = "Puhelin";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Location = new System.Drawing.Point(469, 349);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(76, 25);
            this.puhLB.TabIndex = 12;
            this.puhLB.Text = "Puhelin";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(469, 305);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(104, 25);
            this.emailLB.TabIndex = 11;
            this.emailLB.Text = "Sähköposti";
            // 
            // osastoLB
            // 
            this.osastoLB.AutoSize = true;
            this.osastoLB.Location = new System.Drawing.Point(469, 261);
            this.osastoLB.Name = "osastoLB";
            this.osastoLB.Size = new System.Drawing.Size(69, 25);
            this.osastoLB.TabIndex = 10;
            this.osastoLB.Text = "Osasto";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Location = new System.Drawing.Point(469, 217);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(59, 25);
            this.titteliLB.TabIndex = 9;
            this.titteliLB.Text = "Tittlei";
            // 
            // vastuuhloCB
            // 
            this.vastuuhloCB.FormattingEnabled = true;
            this.vastuuhloCB.Location = new System.Drawing.Point(466, 165);
            this.vastuuhloCB.Name = "vastuuhloCB";
            this.vastuuhloCB.Size = new System.Drawing.Size(254, 33);
            this.vastuuhloCB.TabIndex = 8;
            this.vastuuhloCB.SelectedIndexChanged += new System.EventHandler(this.vastuuhloCB_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Valitse vastuuhenkilö";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 750);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.osastoLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.vastuuhloCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.postitoimipaikkaLB);
            this.Controls.Add(this.postinumeroLB);
            this.Controls.Add(this.osoiteLB);
            this.Controls.Add(this.oppilaitosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AvainhenkilotForm";
            this.Text = "Uusiks kaikki";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox oppilaitosCB;
        private Label osoiteLB;
        private Label postinumeroLB;
        private Label postitoimipaikkaLB;
        private Label puhelinLB;
        private Label puhLB;
        private Label emailLB;
        private Label osastoLB;
        private Label titteliLB;
        private ComboBox vastuuhloCB;
        private Label label11;
    }
}