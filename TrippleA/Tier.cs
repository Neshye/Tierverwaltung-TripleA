using System;

namespace TripleA
{
    public class Tier
    {
        Random random = new Random();

        private string name;
        private int anzahl;
        private string geschlecht;
        public int tierZustand;

        int[] zustand1 = new int[] {100, 75, 50, 25, 0 };

        public Tier(string name, int anzahl, string geschlecht)
        {
            this.name = name;
            this.anzahl = anzahl;
            this.geschlecht = geschlecht;
            setStartZustand();
        }

        public Tier() { }

        public string getName()
        {
            return name;
        }
        public int getAnzahl()
        {
            return anzahl;
        }
        public string getGeschlecht()
        {
            return geschlecht;
        }

        public void setName()
        {
            this.name = name;
        }
        public void setAnzahl()
        {
            this.anzahl = anzahl;
        }
        public void setGeschlecht()
        {
            this.geschlecht = geschlecht;
        }
        public void setStartZustand()
        {
            tierZustand = 100;
        }

        public int getZustand()
        {
            return tierZustand;
        }

        public void setZustand()
        {
            if (this.tierZustand == 0)
            {
                this.tierZustand = 0;
            }
            else
            {
                this.tierZustand -= 25;
            }
        }

        public void zustandVollmachen()
        {
            this.tierZustand = 100;
        }
    }
}