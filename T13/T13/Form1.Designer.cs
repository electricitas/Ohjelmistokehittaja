namespace T13
{
    partial class NimiForm
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
            label1 = new Label();
            VastausLB = new Label();
            NimiTB = new TextBox();
            TarkastaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 44);
            label1.Name = "label1";
            label1.Size = new Size(532, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi, niin tarkasta, onko se 50 suosituimman joukossa:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(49, 113);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(76, 25);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(587, 41);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(185, 33);
            NimiTB.TabIndex = 2;
            // 
            // TarkastaBT
            // 
            TarkastaBT.Location = new Point(636, 105);
            TarkastaBT.Name = "TarkastaBT";
            TarkastaBT.Size = new Size(136, 41);
            TarkastaBT.TabIndex = 3;
            TarkastaBT.Text = "Tarkasta";
            TarkastaBT.UseVisualStyleBackColor = true;
            TarkastaBT.Click += TarkastaBT_Click;
            // 
            // NimiForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(TarkastaBT);
            Controls.Add(NimiTB);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "NimiForm";
            Text = "Suosittuja nimiä";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label VastausLB;
        private TextBox NimiTB;
        private Button TarkastaBT;
    }
}
