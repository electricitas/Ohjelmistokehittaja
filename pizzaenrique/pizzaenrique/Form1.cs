namespace pizzaenrique
{
    public partial class frm_front : Form
    {
        public frm_front()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Form item = new frm_items();
            item.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Haluatko varmasti poistua järjestelmästä",
                "Toimitusjärjestelmä", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
