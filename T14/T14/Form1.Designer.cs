namespace T14
{
    partial class KirjaForm
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
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyottoTB
            // 
            this.SyottoTB.Location = new System.Drawing.Point(12, 8);
            this.SyottoTB.Multiline = true;
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(543, 374);
            this.SyottoTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            this.TallennaBT.Location = new System.Drawing.Point(12, 388);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(543, 54);
            this.TallennaBT.TabIndex = 1;
            this.TallennaBT.Text = "Lisää päiväkirjaan";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // KirjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 454);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.SyottoTB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "KirjaForm";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SyottoTB;
        private Button TallennaBT;
    }
}