namespace T15
{
    partial class SekkariForm
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
            components = new System.ComponentModel.Container();
            AikaLB = new Label();
            KaynnistaBT = new Button();
            TyhjennaBT = new Button();
            LopetaBT = new Button();
            AjanottoTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            AikaLB.Location = new Point(189, 36);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(585, 128);
            AikaLB.TabIndex = 0;
            AikaLB.Text = "00:00:00.000";
            // 
            // KaynnistaBT
            // 
            KaynnistaBT.Location = new Point(92, 213);
            KaynnistaBT.Name = "KaynnistaBT";
            KaynnistaBT.Size = new Size(130, 49);
            KaynnistaBT.TabIndex = 1;
            KaynnistaBT.Text = "Käynnistä";
            KaynnistaBT.UseVisualStyleBackColor = true;
            KaynnistaBT.Click += KaynnistaBT_Click;
            // 
            // TyhjennaBT
            // 
            TyhjennaBT.Location = new Point(694, 213);
            TyhjennaBT.Name = "TyhjennaBT";
            TyhjennaBT.Size = new Size(130, 49);
            TyhjennaBT.TabIndex = 2;
            TyhjennaBT.Text = "Tyhjennä";
            TyhjennaBT.UseVisualStyleBackColor = true;
            TyhjennaBT.Click += TyhjennaBT_Click;
            // 
            // LopetaBT
            // 
            LopetaBT.Location = new Point(393, 213);
            LopetaBT.Name = "LopetaBT";
            LopetaBT.Size = new Size(130, 49);
            LopetaBT.TabIndex = 3;
            LopetaBT.Text = "Lopeta";
            LopetaBT.UseVisualStyleBackColor = true;
            LopetaBT.Click += LopetaBT_Click;
            // 
            // AjanottoTM
            // 
            AjanottoTM.Enabled = true;
            AjanottoTM.Interval = 1000;
            AjanottoTM.Tick += AjanottoTM_Tick;
            // 
            // SekkariForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 389);
            Controls.Add(LopetaBT);
            Controls.Add(TyhjennaBT);
            Controls.Add(KaynnistaBT);
            Controls.Add(AikaLB);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "SekkariForm";
            Text = "Sekkarri";
            Load += SekkariForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AikaLB;
        private Button KaynnistaBT;
        private Button TyhjennaBT;
        private Button LopetaBT;
        private System.Windows.Forms.Timer AjanottoTM;
    }
}
