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
            lvSarcini.ItemCheck -= lvSarcini_ItemCheck; // Dezactivează temporar evenimentul

            foreach (var sarcina in sarcini)
            {
                var item = new ListViewItem(sarcina.Descriere);
                item.SubItems.Add(sarcina.PrioritateItem.ToString());
                item.Checked = sarcina.EsteCompletat; // Setează starea checkbox-ului
                item.SubItems.Add(sarcina.EsteCompletat ? "Da" : "Nu"); // Coloana text

                lvSarcini.Items.Add(item);
            }

            lvSarcini.ItemCheck += lvSarcini_ItemCheck; // Reactivează evenimentul
        }
        private void lvSarcini_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < sarcini.Count)
            {
                // Actualizează starea în lista de sarcini
                sarcini[e.Index].EsteCompletat = (e.NewValue == CheckState.Checked);

                // Actualizează textul din coloana "Completat"
                lvSarcini.Items[e.Index].SubItems[2].Text = (e.NewValue == CheckState.Checked) ? "Da" : "Nu";
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

        //pentru afisare domenii in listView
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




    }
}
