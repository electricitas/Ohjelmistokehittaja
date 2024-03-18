namespace pizzaenrique
{
    partial class frm_front
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
            btn_order = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(341, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(854, 170);
            label1.TabIndex = 0;
            label1.Text = "Tilaus järjestelmä";
            // 
            // btn_order
            // 
            btn_order.Location = new Point(635, 214);
            btn_order.Margin = new Padding(5);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(215, 104);
            btn_order.TabIndex = 1;
            btn_order.Text = "Tilaus sivu";
            btn_order.UseVisualStyleBackColor = true;
            btn_order.Click += btn_order_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(635, 341);
            btn_exit.Margin = new Padding(5);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(215, 112);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // frm_front
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1474, 755);
            Controls.Add(btn_exit);
            Controls.Add(btn_order);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frm_front";
            Text = "Pizzeria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_order;
        private Button btn_exit;
    }
}
