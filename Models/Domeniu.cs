using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati
{
    [Serializable]
    public class Domeniu : ICloneable, IComparable, IEnumerable<Activitate>
    {
        //atribute
        private string denumire;
        public List<Activitate> listaActivitati;



        //constructor
        public Domeniu(string denumire)
        {
            this.denumire = denumire;
            this.listaActivitati = new List<Activitate>();
        }
        public Domeniu()
        {
            this.denumire = string.Empty;
            this.listaActivitati = new List<Activitate>();
        }



        //proprietati
        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }
        public Activitate this[int index]
        {
            get { return listaActivitati[index]; }
            set { listaActivitati[index] = value; }
        }


        //implementare interfete
        public object Clone()
        {
            var clone = new Domeniu(Denumire);
            foreach (var activitate in listaActivitati)
                clone.listaActivitati.Add((Activitate)activitate.Clone());
            return clone;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (!(obj is Domeniu other))
                throw new ArgumentException("Object is not a Domeniu");
            other = obj as Domeniu;
            if (other == null)
                throw new ArgumentException("Object is not a Domeniu");

            return this.listaActivitati.Count.CompareTo(other.listaActivitati.Count);
        }
        public IEnumerator<Activitate> GetEnumerator()
        {
            return listaActivitati.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        //metode
        public void AdaugaActivitate(Activitate activitate)
        {
            if (activitate == null) return;

            if (!listaActivitati.Contains(activitate))
            {
                listaActivitati.Add(activitate);
                // Asigură relația inversă
                if (activitate.DomeniuAsociat != this)
                {
                    activitate.DomeniuAsociat = this;
                }
            }
        }
        public void StergeActivitate(Activitate activitate)
        {
            if (activitate == null) return;

            if (listaActivitati.Contains(activitate))
            {
                listaActivitati.Remove(activitate);
                // Asigură relația inversă
                if (activitate.DomeniuAsociat == this)
                {
                    activitate.DomeniuAsociat = null;
                }
            }
        }
    }
}
