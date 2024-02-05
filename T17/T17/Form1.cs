using System.Windows.Forms;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace T17
{
    public partial class MuistioForm : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        private string tiedostoPolku = "";

        public MuistioForm()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }

        private void UusiTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    MessageBox.Show("Sinun tulee tallentaa ensin!");

                }
                else
                {
                    TekstiTB.Text = string.Empty;
                    Text = "Nimetön";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }

        }

        private void TallennaTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Tekstitiedosto (*.txt) | *.txt|Rikas tekstiformaatti (*.rtf) | *.rtf";
                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, TekstiTB.Text);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void AvaaTiedosto()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Tekstitiedosto (*.txt) | *.txt|Rikas tekstiformaatti (*.rtf) | *.rtf";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tiedostoPolku = openFileDialog.FileName;

                    if (Path.GetExtension(tiedostoPolku) == ".txt")
                    {
                        TekstiTB.Text = File.ReadAllText(tiedostoPolku);
                    }
                    else if (Path.GetExtension(tiedostoPolku) == ".rtf")
                    {
                        TekstiTB.LoadFile(tiedostoPolku, RichTextBoxStreamType.RichText);
                    }

                    Text = tiedostoPolku;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa! " + ex);
            }
        }



        private void MuistioForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TekstiTB.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                TekstiTB.Text = "";
            }
            else
            {
                TekstiTB.Text = "";
            }
            UusiTiedosto();

        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (openFileDialog)
            {
                openFileDialog.Filter = "Tekstitiedosto (*.txt) | *.txt|Rikas tekstiformaatti (*.rtf) | *.rtf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tiedostoPolku = openFileDialog.FileName;

                    if (Path.GetExtension(tiedostoPolku) == ".txt")
                    {
                        TekstiTB.Text = File.ReadAllText(tiedostoPolku);
                    }
                    else if (Path.GetExtension(tiedostoPolku) == ".rtf")
                    {
                        TekstiTB.LoadFile(tiedostoPolku, RichTextBoxStreamType.RichText);
                    }

                    Text = tiedostoPolku;
                }
            }
        }


        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                {
                    Filter = "Rikastekstiformaatti|*.rtf",
                    ValidateNames = true
                })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.TekstiTB.Rtf);
                        tiedosto.Close();
                        tiedostoPolku = ttk.FileName;
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostoPolku))
                {
                    vk.WriteLineAsync(TekstiTB.Rtf);
                }
            }
        }


        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    TallennaTiedosto();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    TekstiTB.Font = fontDialog.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                {
                    Filter = "TextDocument|*.txt",
                    ValidateNames = true
                })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                        {
                            jonokirjoittaja.WriteLineAsync(TekstiTB.Text);
                        }
                    }
                }
            }
        }
    }
}
