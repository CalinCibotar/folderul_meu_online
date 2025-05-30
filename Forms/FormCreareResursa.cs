using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaActivitati.Forms
{
    public partial class FormCreareResursa: Form
    {
        public Resursa ResursaCreata { get; private set; }


        public FormCreareResursa()
        {
            InitializeComponent();
            rbPersoana.Checked = true;
        }


        // Butoane de salvare și anulare
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!ValideazaDate()) return;

            try
            {
                if (rbPersoana.Checked)
                {
                    ResursaCreata = new Persoana(
                        txtNume.Text.Trim(),
                        txtFunctieTip.Text.Trim()
                    );
                }
                else
                {
                    ResursaCreata = new Echipament(
                        txtNume.Text.Trim(),
                        txtFunctieTip.Text.Trim()
                    );
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Eroare validare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValideazaDate()
        {
            if (!rbPersoana.Checked && !rbEchipament.Checked)
            {
                MessageBox.Show("Selectați tipul resursei!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                MessageBox.Show("Introduceți numele resursei!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNume.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFunctieTip.Text))
            {
                string campNecesar = rbPersoana.Checked ? "funcția" : "tipul echipamentului";
                MessageBox.Show($"Introduceți {campNecesar}!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFunctieTip.Focus();
                return false;
            }

            return true;
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
