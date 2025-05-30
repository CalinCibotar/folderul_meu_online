using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati
{
    [Serializable]
    public class Proiect: ICloneable
    {
        //atribute
        private string denumire;
        private DateTime dataInceput;
        private DateTime dataFinalizare;
        
        //constructor
        public Proiect(string denumire, DateTime dataInceput, DateTime dataFinalizare)
        {
            this.denumire = denumire;
            this.dataInceput = dataInceput;
            this.dataFinalizare = dataFinalizare;
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
        public DateTime DataFinalizare
        {
            get { return dataFinalizare; }
            set
            {
                if (value < DataInceput)
                    throw new ArgumentException("DataFinalizare cannot be before DataInceput");
                dataFinalizare = value;
            }
        }

        //override
        public object Clone() => new Proiect(Denumire, DataInceput, DataFinalizare);
    }
}
