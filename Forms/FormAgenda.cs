using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaActivitati
{
    public partial class FormAgenda: Form
    {
        // Colecții pentru a stoca datele aplicației
        private List<Domeniu> domenii = new List<Domeniu>();
        private List<Activitate> activitati = new List<Activitate>();
        private List<Proiect> proiecte = new List<Proiect>();
        private List<TodoItem> sarcini = new List<TodoItem>();
        private List<Resursa> resurse = new List<Resursa>();

        private List<TodoItem> sarciniArhivate = new List<TodoItem>();
        private Dictionary<TodoItem, string> dateAdaugareSarcini = new Dictionary<TodoItem, string>();


        public FormAgenda()
        {
            InitializeComponent();
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            // Inițializează data și ora
            ActualizeazaOra();
            ConfigureazaListViewSarcini();
            ConfigureazaListViewResurse();

            // Actualizează lista inițială de sarcini
            ActualizeazaDataGridViewDomenii();
            ActualizeazaDataGridViewActivitati();
            ActualizeazaDataGridViewProiecte();
            ActualizeazaListaSarcini();
            ActualizeazaListViewResurse();

            // Configurează un timer pentru actualizare continuă
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 secundă
            timer.Tick += Timer_Tick;
            timer.Start();
        }



        //pentru ora actualizata
        private void Timer_Tick(object sender, EventArgs e)
        {
            ActualizeazaOra();
        }
        private void ActualizeazaOra()
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }


        //Butoane din ToolStrip
        private void tsbAdaugaActivitate_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.FormCreareActivitate(proiecte,resurse,domenii))
            {
                if (form.ShowDialog() == DialogResult.OK && form.ActivitateCreata != null)
                {
                    activitati.Add(form.ActivitateCreata);
                    ActualizeazaDataGridViewDomenii();
                    ActualizeazaDataGridViewActivitati();

                    MessageBox.Show("Activitate adăugată cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbAdaugaDomeniu_Click(object sender, EventArgs e)
        {
            using (Forms.FormCreareDomeniu form = new Forms.FormCreareDomeniu())
            {
                if (form.ShowDialog() == DialogResult.OK && form.DomeniuCreat != null)
                {
                    domenii.Add(form.DomeniuCreat);
                    ActualizeazaDataGridViewDomenii();

                    MessageBox.Show("Domeniu adăugat cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbAdaugaProiect_Click(object sender, EventArgs e)
        {
            using(var form = new Forms.FormCreareProiect())
            {
                if (form.ShowDialog() == DialogResult.OK && form.ProiectCreat != null)
                {
                    proiecte.Add(form.ProiectCreat);
                    ActualizeazaDataGridViewProiecte();

                    MessageBox.Show("Proiect adăugat cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbAdaugaResursa_Click(object sender, EventArgs e)
        {
            using(var form = new Forms.FormCreareResursa())
            {
                if (form.ShowDialog() == DialogResult.OK && form.ResursaCreata != null)
                {
                    resurse.Add(form.ResursaCreata);
                    ActualizeazaListViewResurse();

                    MessageBox.Show("Resursă adăugată cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbAdaugaSarcina_Click(object sender, EventArgs e)
        {
            using(var form = new Forms.FormCreareSarcina())
            {
                if(form.ShowDialog() == DialogResult.OK && form.SarcinaCreata != null)
                {
                    sarcini.Add(form.SarcinaCreata);
                    dateAdaugareSarcini[form.SarcinaCreata] = DateTime.Now.ToShortDateString();
                    ActualizeazaListaSarcini();

                    MessageBox.Show("Sarcină adăugată cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        //pentru afisare sarcini in listView
        private void ActualizeazaListaSarcini()
        {
            lvSarcini.Items.Clear();
            lvSarcini.ItemCheck -= lvSarcini_ItemCheck;

            foreach (var sarcina in sarcini)
            {
                var item = new ListViewItem(sarcina.Descriere);
                item.SubItems.Add(sarcina.PrioritateItem.ToString());
                item.Checked = sarcina.EsteCompletat;

                // Afișează data adăugării dacă există, altfel "Nu"
                string dataAdaugare = dateAdaugareSarcini.ContainsKey(sarcina)
                    ? dateAdaugareSarcini[sarcina]
                    : "Nu";

                item.SubItems.Add(dataAdaugare);

                lvSarcini.Items.Add(item);
            }

            lvSarcini.ItemCheck += lvSarcini_ItemCheck;
        }
        private void lvSarcini_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < sarcini.Count)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    // Salvează sarcina care trebuie arhivată
                    var sarcinaArhivata = sarcini[e.Index];

                    // Folosește BeginInvoke pentru a elimina după ce ListView-ul a terminat procesarea
                    this.BeginInvoke(new Action(() =>
                    {
                        sarciniArhivate.Add(sarcinaArhivata);
                        dateAdaugareSarcini.Remove(sarcinaArhivata);
                        sarcini.RemoveAt(e.Index);
                        ActualizeazaListaSarcini();
                    }));
                }
            }
        }
        private void ConfigureazaListViewSarcini()
        {
            lvSarcini.View = View.Details;
            lvSarcini.CheckBoxes = true;
            lvSarcini.FullRowSelect = true;

            // Șterge coloanele existente
            lvSarcini.Columns.Clear();

            // Adaugă coloane cu dimensiuni adecvate
            lvSarcini.Columns.Add("Descriere", 300);  // Lățime în pixeli
            lvSarcini.Columns.Add("Prioritate", 150);
            lvSarcini.Columns.Add("Completat", 100);

            // Asigură că ListView ocupă tot spațiul disponibil
            lvSarcini.Dock = DockStyle.Fill;
        }

        //pentru afisare resurse in listView
        private void ActualizeazaListViewResurse()
        {
            lvResurse.Items.Clear();

            foreach (var resursa in resurse)
            {
                var item = new ListViewItem(resursa.Nume);
                item.SubItems.Add(resursa.Tip);
                item.SubItems.Add(resursa.GetDescriere());

                lvResurse.Items.Add(item);
            }
        }
        private void ConfigureazaListViewResurse()
        {
            lvResurse.View = View.Details;
            lvResurse.FullRowSelect = true;
            lvResurse.GridLines = true;

            // Șterge coloanele existente și adaugă-le din nou pentru a evita duplicatele
            lvResurse.Columns.Clear();

            lvResurse.Columns.Add("Nume", 200);
            lvResurse.Columns.Add("Tip", 150);
            lvResurse.Columns.Add("Descriere", 300);

            lvResurse.Dock = DockStyle.Fill;
        }

        //pentru afisare domenii in dgvDomenii
        private void ActualizeazaDataGridViewDomenii()
        {
            dgvDomenii.Rows.Clear(); // Șterge rândurile existente

            foreach (var domeniu in domenii)
            {
                // Adaugă un rând nou cu denumirea și numărul de activități
                dgvDomenii.Rows.Add(
                    domeniu.Denumire,
                    domeniu.listaActivitati.Count
                );
            }
        }

        //pentru afisare activitati in dgvActivitati
        private void ActualizeazaDataGridViewActivitati()
        {

            foreach (var activitate in activitati)
            {
                // Adaugă un rând nou cu detaliile activității
                dgvActivitati.Rows.Add(
                    activitate.Denumire,
                    activitate.DataInceput.ToShortDateString(),
                    activitate.Durata,
                    activitate.ProiectAsociat?.Denumire ?? "N/A", // Afișează "N/A" dacă nu există proiect asociat
                    activitate.listaEtape.Count,
                    activitate.listaResurse.Count
                );
            }
        }

        //pentru afisare proiecte in dgvProiecte
        private void ActualizeazaDataGridViewProiecte()
        {
            dgvProiecte.Rows.Clear(); // Șterge rândurile vechi

            foreach (var proiect in proiecte)
            {
                dgvProiecte.Rows.Add(
                    proiect.Denumire,
                    proiect.DataInceput.ToShortDateString(),
                    proiect.DataFinalizare.ToShortDateString()
                );
            }
        }

        //pentru butoane din meniul context
        private void adaugaDomeniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.FormCreareDomeniu form = new Forms.FormCreareDomeniu())
            {
                if (form.ShowDialog() == DialogResult.OK && form.DomeniuCreat != null)
                {
                    domenii.Add(form.DomeniuCreat);
                    ActualizeazaDataGridViewDomenii();

                    MessageBox.Show("Domeniu adăugat cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void adaugaActivitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.FormCreareActivitate(proiecte, resurse, domenii))
            {
                if (form.ShowDialog() == DialogResult.OK && form.ActivitateCreata != null)
                {
                    activitati.Add(form.ActivitateCreata);
                    ActualizeazaDataGridViewDomenii();
                    ActualizeazaDataGridViewActivitati();

                    MessageBox.Show("Activitate adăugată cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void adaugaProiectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.FormCreareProiect())
            {
                if (form.ShowDialog() == DialogResult.OK && form.ProiectCreat != null)
                {
                    proiecte.Add(form.ProiectCreat);
                    ActualizeazaDataGridViewProiecte();

                    MessageBox.Show("Proiect adăugat cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void adaugaResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.FormCreareResursa())
            {
                if (form.ShowDialog() == DialogResult.OK && form.ResursaCreata != null)
                {
                    resurse.Add(form.ResursaCreata);
                    ActualizeazaListViewResurse();

                    MessageBox.Show("Resursă adăugată cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void adaugaSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.FormCreareSarcina())
            {
                if (form.ShowDialog() == DialogResult.OK && form.SarcinaCreata != null)
                {
                    sarcini.Add(form.SarcinaCreata);
                    ActualizeazaListaSarcini();

                    MessageBox.Show("Sarcină adăugată cu succes!", "Succes",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
