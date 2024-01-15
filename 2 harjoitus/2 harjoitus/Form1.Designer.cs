namespace _2_harjoitus
{
    partial class Form1
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
            OtsikkoLB = new Label();
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point);
            OtsikkoLB.Location = new Point(78, 113);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(300, 35);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Anna tulostettava teksti:";
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TulostusLB.Location = new Point(78, 172);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(76, 35);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxx";
            TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ViestiTB.Location = new Point(384, 110);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(495, 41);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TulostaBT.Location = new Point(669, 173);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(190, 37);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tulosta teksti";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(914, 570);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(OtsikkoLB);
            Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.MintCream;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Harjoitus 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}
