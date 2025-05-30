using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati
{
    //clasa abstracta
    [Serializable]
    public abstract class Resursa
    {
        //atribute
        public string nume;
        public string tip;

        //proprietati
        public string Nume
        {
            get { return nume; }
            set
            {
                if (value.Length > 0)
                {
                    nume = value;
                }
                else
                {
                    throw new ArgumentException("Numele nu poate fi gol!");
                }
            }
        }

        public string Tip
        {
            get { return tip; }
            set
            {
                if (value == "Echipament" || value == "Persoana")
                {
                    tip = value;
                }
                else
                {
                    throw new ArgumentException("Tipul trebuie sa fie Echipament sau Persoana!");
                }
            }
        }

        protected Resursa(string nume, string tip)
        {
            this.Nume = nume; 
            this.Tip = tip;   
        }

        public abstract string GetDescriere();
    }



    //clasele care o deriva
    [Serializable]
    public class Persoana : Resursa
    {
        //atribute
        public string functie;

        //proprietati
        public string Functie
        {
            get { return functie; }
            set
            {
                if (value.Length > 0)
                {
                    functie = value;
                }
                else
                {
                    throw new ArgumentException("Functia nu poate fi goala!");
                }
            }
        }

        public Persoana(string nume, string functie)
       : base(nume, "Persoana") 
        {
            this.Functie = functie; 
        }

        //override
        public override string GetDescriere() => $"{Nume} ({Functie})";
    }

    [Serializable]
    public class Echipament : Resursa
    {
        //atribute
        public string tipEchipament;

        //proprietati
        public string TipEchipament
        {
            get { return tipEchipament; }
            set
            {
                if (value.Length > 0)
                {
                    tipEchipament = value;
                }
                else
                {
                    throw new ArgumentException("Tipul echipamentului nu poate fi gol!");
                }
            }
        }

        public Echipament(string nume, string tipEchipament)
        : base(nume, "Echipament") 
        {
            this.TipEchipament = tipEchipament; 
        }


        //override
        public override string GetDescriere() => $"{Nume} ({TipEchipament})";
    }
}
