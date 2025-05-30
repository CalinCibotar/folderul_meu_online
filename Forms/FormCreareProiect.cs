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
    public partial class FormCreareProiect: Form
    {
        public Proiect ProiectCreat { get; private set; }

        public FormCreareProiect()
        {
            InitializeComponent();
            dtpInceput.Value = DateTime.Today;
            dtpFinalizare.Value = DateTime.Today.AddDays(1);
        }



        // Butoane de salvare și anulare
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!ValideazaDate())
                return;

            try
            {
                ProiectCreat = new Proiect(
                    txtDenumire.Text.Trim(),
                    dtpInceput.Value,
                    dtpFinalizare.Value
                );

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
            if (string.IsNullOrWhiteSpace(txtDenumire.Text))
            {
                MessageBox.Show("Introduceți denumirea proiectului!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDenumire.Focus();
                return false;
            }

            if (dtpFinalizare.Value < dtpInceput.Value)
            {
                MessageBox.Show("Data finalizării trebuie să fie după data începerii!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
