namespace T1
{
    partial class T1FORM
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.VaihdaBT = new System.Windows.Forms.Button();
            this.LaskuriLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(87, 57);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(94, 32);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Otsikko";
            // 
            // VaihdaBT
            // 
            this.VaihdaBT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VaihdaBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VaihdaBT.ForeColor = System.Drawing.SystemColors.Control;
            this.VaihdaBT.Location = new System.Drawing.Point(87, 101);
            this.VaihdaBT.Name = "VaihdaBT";
            this.VaihdaBT.Size = new System.Drawing.Size(195, 41);
            this.VaihdaBT.TabIndex = 1;
            this.VaihdaBT.Text = "Muuta teksti";
            this.VaihdaBT.UseVisualStyleBackColor = false;
            this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
            // 
            // LaskuriLB
            // 
            this.LaskuriLB.AutoSize = true;
            this.LaskuriLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskuriLB.Location = new System.Drawing.Point(87, 159);
            this.LaskuriLB.Name = "LaskuriLB";
            this.LaskuriLB.Size = new System.Drawing.Size(87, 32);
            this.LaskuriLB.TabIndex = 2;
            this.LaskuriLB.Text = "Laskuri";
            // 
            // T1FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LaskuriLB);
            this.Controls.Add(this.VaihdaBT);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "T1FORM";
            this.Text = "Tehtävä1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private Button VaihdaBT;
        private Label LaskuriLB;
    }
}