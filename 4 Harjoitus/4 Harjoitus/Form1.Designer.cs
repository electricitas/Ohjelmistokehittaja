namespace _4_Harjoitus
{
    partial class IkaForm
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
            SyntymaAikaDT = new DateTimePicker();
            LaskeIkaBT = new Button();
            VuosinaLB = new Label();
            TunteinaLB = new Label();
            KuukausinaLB = new Label();
            MinuutteinaLB = new Label();
            PaivinaLB = new Label();
            SekunteinaLB = new Label();
            SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            SyntymaAikaDT.Location = new Point(86, 132);
            SyntymaAikaDT.Margin = new Padding(5, 6, 5, 6);
            SyntymaAikaDT.Name = "SyntymaAikaDT";
            SyntymaAikaDT.Size = new Size(386, 36);
            SyntymaAikaDT.TabIndex = 0;
            // 
            // LaskeIkaBT
            // 
            LaskeIkaBT.Location = new Point(511, 122);
            LaskeIkaBT.Margin = new Padding(5, 6, 5, 6);
            LaskeIkaBT.Name = "LaskeIkaBT";
            LaskeIkaBT.Size = new Size(129, 46);
            LaskeIkaBT.TabIndex = 1;
            LaskeIkaBT.Text = "Laske ikä";
            LaskeIkaBT.UseVisualStyleBackColor = true;
            LaskeIkaBT.Click += LaskeIkaBT_Click;
            // 
            // VuosinaLB
            // 
            VuosinaLB.AutoSize = true;
            VuosinaLB.Location = new Point(86, 214);
            VuosinaLB.Margin = new Padding(5, 0, 5, 0);
            VuosinaLB.Name = "VuosinaLB";
            VuosinaLB.Size = new Size(88, 30);
            VuosinaLB.TabIndex = 2;
            VuosinaLB.Text = "Vuosina";
            VuosinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            TunteinaLB.AutoSize = true;
            TunteinaLB.Location = new Point(376, 214);
            TunteinaLB.Margin = new Padding(5, 0, 5, 0);
            TunteinaLB.Name = "TunteinaLB";
            TunteinaLB.Size = new Size(96, 30);
            TunteinaLB.TabIndex = 3;
            TunteinaLB.Text = "Tunteina";
            TunteinaLB.Visible = false;
            // 
            // KuukausinaLB
            // 
            KuukausinaLB.AutoSize = true;
            KuukausinaLB.Location = new Point(86, 286);
            KuukausinaLB.Margin = new Padding(5, 0, 5, 0);
            KuukausinaLB.Name = "KuukausinaLB";
            KuukausinaLB.Size = new Size(121, 30);
            KuukausinaLB.TabIndex = 4;
            KuukausinaLB.Text = "Kuukausina";
            KuukausinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            MinuutteinaLB.AutoSize = true;
            MinuutteinaLB.Location = new Point(376, 286);
            MinuutteinaLB.Margin = new Padding(5, 0, 5, 0);
            MinuutteinaLB.Name = "MinuutteinaLB";
            MinuutteinaLB.Size = new Size(128, 30);
            MinuutteinaLB.TabIndex = 5;
            MinuutteinaLB.Text = "Minuutteina";
            MinuutteinaLB.Visible = false;
            // 
            // PaivinaLB
            // 
            PaivinaLB.AutoSize = true;
            PaivinaLB.Location = new Point(86, 364);
            PaivinaLB.Margin = new Padding(5, 0, 5, 0);
            PaivinaLB.Name = "PaivinaLB";
            PaivinaLB.Size = new Size(79, 30);
            PaivinaLB.TabIndex = 6;
            PaivinaLB.Text = "Päivinä";
            PaivinaLB.Visible = false;
            // 
            // SekunteinaLB
            // 
            SekunteinaLB.AutoSize = true;
            SekunteinaLB.Location = new Point(376, 364);
            SekunteinaLB.Margin = new Padding(5, 0, 5, 0);
            SekunteinaLB.Name = "SekunteinaLB";
            SekunteinaLB.Size = new Size(119, 30);
            SekunteinaLB.TabIndex = 7;
            SekunteinaLB.Text = "Sekunteina";
            SekunteinaLB.Visible = false;
            // 
            // IkaForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(SekunteinaLB);
            Controls.Add(PaivinaLB);
            Controls.Add(MinuutteinaLB);
            Controls.Add(KuukausinaLB);
            Controls.Add(TunteinaLB);
            Controls.Add(VuosinaLB);
            Controls.Add(LaskeIkaBT);
            Controls.Add(SyntymaAikaDT);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "IkaForm";
            Text = "ikälaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button LaskeIkaBT;
        private Label VuosinaLB;
        private Label TunteinaLB;
        private Label KuukausinaLB;
        private Label MinuutteinaLB;
        private Label PaivinaLB;
        private Label SekunteinaLB;
    }
}
