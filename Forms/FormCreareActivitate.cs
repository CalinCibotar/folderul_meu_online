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
    public partial class FormCreareActivitate : Form
    {
        public Activitate ActivitateCreata { get; private set; }
        private List<Proiect> proiecteDisponibile;
        private List<Domeniu> domeniiDisponibile;
        private List<string> etapeActivitate = new List<string>();
        private List<Resursa> resurseDisponibile; // Lista tuturor resurselor
        private List<Resursa> resurseAsociate = new List<Resursa>(); // Resurse selectate


        public FormCreareActivitate(List<Proiect> proiecte, List<Resursa> resurse, List<Domeniu> domenii)
        {
            InitializeComponent();
            this.proiecteDisponibile = proiecte ?? new List<Proiect>();
            this.resurseDisponibile = resurse ?? new List<Resursa>();
            this.domeniiDisponibile = domenii ?? new List<Domeniu>();

            IncarcaProiecte();
            IncarcaResurseDisponibile();
            IncarcaDomenii();
        }

        private void IncarcaProiecte()
        {
            // Creează o listă nouă care include și opțiunea "Niciun proiect"
            var listaProiecte = new List<Proiect>(proiecteDisponibile);
            listaProiecte.Insert(0, new Proiect("Niciun proiect", DateTime.MinValue, DateTime.MaxValue));

            cbProiect.DataSource = listaProiecte;
            cbProiect.DisplayMember = "Denumire";
            cbProiect.SelectedIndex = 0; // Selectează implicit "Niciun proiect"
        }
        private void IncarcaResurseDisponibile()
        {
            clbResurseDisponibile.Items.Clear();
            foreach (Resursa resursa in resurseDisponibile)
            {
                clbResurseDisponibile.Items.Add(resursa.Nume, false); // Afișează numele resursei
            }
        }
        private void IncarcaDomenii()
        {
            cbDomeniu.DataSource = domeniiDisponibile;
            cbDomeniu.DisplayMember = "Denumire"; // Presupunând că clasa Domeniu are o proprietate Denumire
            cbDomeniu.SelectedIndex = -1; // Niciun domeniu selectat implicit
        }




        // Butoane de salvare și anulare
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!ValideazaDate())
                return;

            try
            {
                Proiect proiectAsociat = cbProiect.SelectedIndex > 0 ? (Proiect)cbProiect.SelectedItem : null;
                Domeniu domeniuAsociat = (Domeniu)cbDomeniu.SelectedItem;

                ActivitateCreata = new Activitate(
                    txtDenumire.Text.Trim(),
                    dtpInceput.Value,
                    (int)nudDurata.Value,
                    proiectAsociat,
                    new List<string>(etapeActivitate),
                    new List<Resursa>(resurseAsociate),
                    domeniuAsociat  // Adaugă domeniul asociat
                );

                // Relația bidirecțională este gestionată automat prin proprietatea DomeniuAsociat

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValideazaDate()
        {
            if (string.IsNullOrWhiteSpace(txtDenumire.Text))
            {
                MessageBox.Show("Introduceți denumirea activității!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDenumire.Focus();
                return false;
            }

            if (nudDurata.Value <= 0)
            {
                MessageBox.Show("Durata trebuie să fie mai mare decât 0!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbDomeniu.SelectedIndex < 0)
            {
                MessageBox.Show("Selectați un domeniu!", "Eroare",
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




        // Butoane pentru gestionarea etapelor
        private void btnAdaugaEtapa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEtapa.Text))
            {
                etapeActivitate.Add(txtEtapa.Text.Trim());
                ActualizeazaListaEtape();
                txtEtapa.Clear();
            }
            else
            {
                MessageBox.Show("Introduceți o etapă validă!", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ActualizeazaListaEtape()
        {
            lstEtape.Items.Clear();
            lstEtape.Items.AddRange(etapeActivitate.ToArray());
        }
        private void btnStergeEtapa_Click(object sender, EventArgs e)
        {
            if (etapeActivitate.Count > 0)
            {
                etapeActivitate.RemoveAt(etapeActivitate.Count - 1);
                ActualizeazaListaEtape();
            }
        }


        // Butoane pentru gestionarea resurselor asociate
        private void btnAdaugaResurse_Click(object sender, EventArgs e)
        {
            foreach (var item in clbResurseDisponibile.CheckedItems)
            {
                string numeResursa = item.ToString();
                Resursa resursa = resurseDisponibile.FirstOrDefault(r => r.Nume == numeResursa);
                if (resursa != null && !resurseAsociate.Contains(resursa))
                {
                    resurseAsociate.Add(resursa);
                }
            }
            ActualizeazaListaResurseAsociate();
        }
        private void btnStergeResurse_Click(object sender, EventArgs e)
        {
            if (lstResurseAsociate.SelectedItem != null)
            {
                string numeResursa = lstResurseAsociate.SelectedItem.ToString();
                Resursa resursa = resurseAsociate.FirstOrDefault(r => r.Nume == numeResursa);
                if (resursa != null)
                {
                    resurseAsociate.Remove(resursa);
                    ActualizeazaListaResurseAsociate();
                }
            }
        }
        private void ActualizeazaListaResurseAsociate()
        {
            lstResurseAsociate.Items.Clear();
            lstResurseAsociate.Items.AddRange(resurseAsociate.Select(r => r.Nume).ToArray());
        }
    }
}
