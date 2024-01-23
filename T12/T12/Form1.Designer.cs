namespace T12
{
    partial class VastauksiaForm
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
            KysymysLB = new Label();
            groupBox1 = new GroupBox();
            VastausDRB = new RadioButton();
            VastausCRB = new RadioButton();
            VastausBRB = new RadioButton();
            VastausARB = new RadioButton();
            DummyRB = new RadioButton();
            VastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Location = new Point(33, 39);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(212, 25);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(VastausDRB);
            groupBox1.Controls.Add(VastausCRB);
            groupBox1.Controls.Add(VastausBRB);
            groupBox1.Controls.Add(VastausARB);
            groupBox1.Controls.Add(DummyRB);
            groupBox1.Location = new Point(418, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(100, 172);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "vastaus";
            // 
            // VastausDRB
            // 
            VastausDRB.AutoSize = true;
            VastausDRB.Location = new Point(6, 121);
            VastausDRB.Name = "VastausDRB";
            VastausDRB.Size = new Size(43, 29);
            VastausDRB.TabIndex = 4;
            VastausDRB.TabStop = true;
            VastausDRB.Text = "D";
            VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            VastausCRB.AutoSize = true;
            VastausCRB.Location = new Point(7, 92);
            VastausCRB.Name = "VastausCRB";
            VastausCRB.Size = new Size(42, 29);
            VastausCRB.TabIndex = 3;
            VastausCRB.TabStop = true;
            VastausCRB.Text = "C";
            VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            VastausBRB.AutoSize = true;
            VastausBRB.Location = new Point(8, 63);
            VastausBRB.Name = "VastausBRB";
            VastausBRB.Size = new Size(41, 29);
            VastausBRB.TabIndex = 2;
            VastausBRB.TabStop = true;
            VastausBRB.Text = "B";
            VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausARB
            // 
            VastausARB.AutoSize = true;
            VastausARB.Location = new Point(7, 32);
            VastausARB.Name = "VastausARB";
            VastausARB.Size = new Size(42, 29);
            VastausARB.TabIndex = 1;
            VastausARB.TabStop = true;
            VastausARB.Text = "A";
            VastausARB.UseVisualStyleBackColor = true;
            // 
            // DummyRB
            // 
            DummyRB.AutoCheck = false;
            DummyRB.AutoSize = true;
            DummyRB.Location = new Point(9, 34);
            DummyRB.Name = "DummyRB";
            DummyRB.Size = new Size(40, 29);
            DummyRB.TabIndex = 0;
            DummyRB.TabStop = true;
            DummyRB.Text = "E";
            DummyRB.UseVisualStyleBackColor = true;
            DummyRB.Visible = false;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(33, 200);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(76, 25);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // VastauksiaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 314);
            Controls.Add(VastausLB);
            Controls.Add(groupBox1);
            Controls.Add(KysymysLB);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "VastauksiaForm";
            Text = "Kysymyksiä";
            Load += Vastauksia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private GroupBox groupBox1;
        private RadioButton VastausDRB;
        private RadioButton VastausCRB;
        private RadioButton VastausBRB;
        private RadioButton VastausARB;
        private RadioButton DummyRB;
        private Label VastausLB;
    }
}
