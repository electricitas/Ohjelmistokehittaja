﻿namespace TT16
{
    partial class CountDownForm
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
            label1 = new Label();
            label2 = new Label();
            MinuutitCB = new ComboBox();
            SekunnitCB = new ComboBox();
            AikaLB = new Label();
            StartBT = new Button();
            StopBT = new Button();
            AjastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 70);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Minuutit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 70);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Sekunnit:";
            // 
            // MinuutitCB
            // 
            MinuutitCB.FormattingEnabled = true;
            MinuutitCB.Location = new Point(91, 153);
            MinuutitCB.Name = "MinuutitCB";
            MinuutitCB.RightToLeft = RightToLeft.Yes;
            MinuutitCB.Size = new Size(121, 33);
            MinuutitCB.TabIndex = 2;
            // 
            // SekunnitCB
            // 
            SekunnitCB.FormattingEnabled = true;
            SekunnitCB.Location = new Point(218, 153);
            SekunnitCB.Name = "SekunnitCB";
            SekunnitCB.RightToLeft = RightToLeft.Yes;
            SekunnitCB.Size = new Size(121, 33);
            SekunnitCB.TabIndex = 3;
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            AikaLB.Location = new Point(99, 229);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(191, 86);
            AikaLB.TabIndex = 4;
            AikaLB.Text = "00:00";
            // 
            // StartBT
            // 
            StartBT.Location = new Point(79, 354);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(122, 48);
            StartBT.TabIndex = 5;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // StopBT
            // 
            StopBT.Location = new Point(227, 354);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(122, 48);
            StopBT.TabIndex = 6;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // AjastinTM
            // 
            AjastinTM.Interval = 1000;
            AjastinTM.Tick += AjastinTM_Tick;
            // 
            // CountDownForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 497);
            Controls.Add(StopBT);
            Controls.Add(StartBT);
            Controls.Add(AikaLB);
            Controls.Add(SekunnitCB);
            Controls.Add(MinuutitCB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CountDownForm";
            Text = "Ajastin";
            Load += CountDownForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox MinuutitCB;
        private ComboBox SekunnitCB;
        private Label AikaLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}
