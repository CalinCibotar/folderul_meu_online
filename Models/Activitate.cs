using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati
{
    [Serializable]
    public class Activitate : ICloneable, IComparable, IEnumerable<Resursa>
    {
        //atribute  
        private string denumire;
        private DateTime dataInceput;
        private int durata;
        private Proiect proiectAsociat;
        private List<string> listaEtape;
        private List<Resursa> listaResurse;
        private Domeniu _domeniuAsociat;

        //constructor  
        public Activitate(string denumire, DateTime dataInceput, int durata, Proiect proiectAsociat, 
            List<string> etape = null, List<Resursa> resurse = null, Domeniu domeniuAsociat = null) 
        {
            this.denumire = denumire;
            this.dataInceput = dataInceput;
            this.durata = durata;
            this.proiectAsociat = proiectAsociat;
            this.listaEtape = etape ?? new List<string>();
            this.listaResurse = resurse ?? new List<Resursa>();
            this.DomeniuAsociat = domeniuAsociat;
        }

        //proprietati  
        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }
        public DateTime DataInceput
        {
            get { return dataInceput; }
            set { dataInceput = value; }
        }
        public int Durata
        {
            get { return durata; }
            set { durata = value; }
        }
        public Proiect ProiectAsociat
        {
            get { return proiectAsociat; }
            set { proiectAsociat = value; }
        }
        public string this[int index]
        {
            get { return listaEtape[index]; }
            set { listaEtape[index] = value; }
        }
        public Resursa GetResursa(int index)
        {
            return listaResurse[index];
        }
        public void SetResursa(int index, Resursa value)
        {
            listaResurse[index] = value;
        }
        public Domeniu DomeniuAsociat
        {
            get { return _domeniuAsociat; }
            set
            {
                if (_domeniuAsociat != value)
                {
                    // Elimină activitatea din vechiul domeniu
                    if (_domeniuAsociat != null && _domeniuAsociat.listaActivitati.Contains(this))
                    {
                        _domeniuAsociat.listaActivitati.Remove(this);
                    }

                    // Actualizează referința
                    _domeniuAsociat = value;

                    // Adaugă activitatea la noul domeniu
                    if (_domeniuAsociat != null && !_domeniuAsociat.listaActivitati.Contains(this))
                    {
                        _domeniuAsociat.listaActivitati.Add(this);
                    }
                }
            }
        }




        //metode  
        public void AdaugaEtapa(string etapa)
        {
            listaEtape.Add(etapa);
        }

        public void FinalizeazaEtapa(int index)
        {
            if (index >= 0 && index < listaEtape.Count)
                listaEtape[index] += " (Finalizat)";
        }





        // suprascriere operator  
        public static Activitate operator +(Activitate a, Activitate b)
        {
            DateTime dataInceputComparare = a.DataInceput > b.DataInceput ? b.DataInceput : a.DataInceput;
            int durataComparare = a.Durata > b.Durata ? a.Durata : b.Durata;

            return new Activitate(
                $"{a.Denumire} + {b.Denumire}",
                dataInceputComparare, 
                durataComparare,
                a.ProiectAsociat
            );
        }




        //implementare interfete clone si compare si enumerabil
        public object Clone()
        {
            var clonedActivitate = new Activitate(
                this.Denumire,
                this.DataInceput,
                this.Durata,
                this.ProiectAsociat != null && this.ProiectAsociat is ICloneable
                    ? (Proiect)((ICloneable)this.ProiectAsociat).Clone()
                    : this.ProiectAsociat
            );
            foreach (var etapa in this.listaEtape)
            {
                clonedActivitate.listaEtape.Add(string.Copy(etapa));
            }
            foreach (var resursa in this.listaResurse)
            {
                if (resursa is ICloneable cloneableResursa)
                    clonedActivitate.listaResurse.Add((Resursa)cloneableResursa.Clone());
                else
                    clonedActivitate.listaResurse.Add(resursa); 
            }
            return clonedActivitate;
        }

        public int CompareTo(object obj)
        {
            if (obj is Activitate otherActivitate)
            {
                int durataComparison = this.Durata.CompareTo(otherActivitate.Durata);
                if (durataComparison != 0)
                    return durataComparison;

                int dataInceputComparison = this.DataInceput.CompareTo(otherActivitate.DataInceput);
                if (dataInceputComparison != 0)
                    return dataInceputComparison;

                return this.Denumire.CompareTo(otherActivitate.Denumire);
            }
            throw new ArgumentException("Obiectul nu este o Activitate");
        }

        public IEnumerator<Resursa> GetEnumerator()
        {
            return listaResurse.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
