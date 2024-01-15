namespace _3_harjoitus
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
            LaskutoimitusCB = new ComboBox();
            LukuYksiTB = new TextBox();
            LukuKaksiTB = new TextBox();
            label1 = new Label();
            VastausLB = new Label();
            LaskeBT = new Button();
            SuspendLayout();
            // 
            // LaskutoimitusCB
            // 
            LaskutoimitusCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LaskutoimitusCB.FormattingEnabled = true;
            LaskutoimitusCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            LaskutoimitusCB.Location = new Point(213, 152);
            LaskutoimitusCB.Name = "LaskutoimitusCB";
            LaskutoimitusCB.Size = new Size(95, 38);
            LaskutoimitusCB.TabIndex = 0;
            // 
            // LukuYksiTB
            // 
            LukuYksiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LukuYksiTB.Location = new Point(12, 152);
            LukuYksiTB.Name = "LukuYksiTB";
            LukuYksiTB.Size = new Size(195, 36);
            LukuYksiTB.TabIndex = 1;
            // 
            // LukuKaksiTB
            // 
            LukuKaksiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LukuKaksiTB.Location = new Point(314, 152);
            LukuKaksiTB.Name = "LukuKaksiTB";
            LukuKaksiTB.Size = new Size(181, 36);
            LukuKaksiTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(515, 155);
            label1.Name = "label1";
            label1.Size = new Size(28, 30);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            VastausLB.Location = new Point(549, 160);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(26, 30);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "X";
            VastausLB.Visible = false;
            // 
            // LaskeBT
            // 
            LaskeBT.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LaskeBT.Location = new Point(581, 149);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(107, 53);
            LaskeBT.TabIndex = 5;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LaskeBT);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Controls.Add(LukuKaksiTB);
            Controls.Add(LukuYksiTB);
            Controls.Add(LaskutoimitusCB);
            Name = "Form1";
            Text = "yksinkertainen nelilaskin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox LaskutoimitusCB;
        private TextBox LukuYksiTB;
        private TextBox LukuKaksiTB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeBT;
    }
}
