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
    public partial class FormCreareSarcina: Form
    {
        public TodoItem SarcinaCreata { get; private set; }

        // Constructorul formularului
        public FormCreareSarcina()
        {
            InitializeComponent();
            IncarcaPrioritati();
        }
        private void IncarcaPrioritati()
        {
            cbPrioritate.DataSource = Enum.GetValues(typeof(TodoItem.Prioritate));
            cbPrioritate.SelectedIndex = 0;
        }

        //Butoane de salvare si anulare
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!ValideazaDate())
                return;

            try
            {
                SarcinaCreata = new TodoItem(
                    txtDescriere.Text.Trim(),
                    (TodoItem.Prioritate)cbPrioritate.SelectedItem
                )
                {
                    EsteCompletat = ckbCompletat.Checked
                };

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
            if (string.IsNullOrWhiteSpace(txtDescriere.Text))
            {
                MessageBox.Show("Introduceți descrierea sarcinii!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescriere.Focus();
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
