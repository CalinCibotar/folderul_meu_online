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
    public partial class FormCreareDomeniu: Form
    {
        public Domeniu DomeniuCreat { get; private set; }

        public FormCreareDomeniu()
        {
            InitializeComponent();
        }

        //butoane de salvare si anulare
        private void btnSalvare_Click_1(object sender, EventArgs e)
        {
            // Validare
            if (string.IsNullOrWhiteSpace(txtDenumire.Text))
            {
                MessageBox.Show("Introduceți denumirea domeniului!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDenumire.Focus();
                return;
            }

            // Creare obiect și închidere formular
            this.DomeniuCreat = new Domeniu(txtDenumire.Text.Trim());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnulare_Click_1(object sender, EventArgs e)
        {
            // Curăță câmpurile și închide
            txtDenumire.Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
