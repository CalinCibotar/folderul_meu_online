using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati
{
    [Serializable]
    public class TodoItem
    {
        //enum pentru prioritate  
        public enum Prioritate { Low, Medium, High }

        //atribute  
        private string descriere;
        private bool esteCompletat;
        private Prioritate prioritate;

        //constructor  
        public TodoItem(string descriere, Prioritate prioritate)
        {
            this.descriere = descriere;
            this.esteCompletat = false;
            this.prioritate = prioritate;
        }

        //proprietati  
        public string Descriere
        {
            get { return descriere; }
            set { descriere = value; }
        }

        public bool EsteCompletat
        {
            get { return esteCompletat; }
            set { esteCompletat = value; }
        }
        public Prioritate PrioritateItem
        {
            get { return prioritate; }
            set
            {
                if (!Enum.IsDefined(typeof(Prioritate), value))
                    throw new ArgumentException("Valoare de prioritate invalidă.");
                prioritate = value;
            }
        }

        //override  
        public override string ToString() => $"{Descriere} - {PrioritateItem} - {(EsteCompletat ? "Da" : "Nu")}";

    }
}
