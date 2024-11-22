using System.Collections.Generic;

namespace TripleA
{
    public class Afrika
    {
        private string name;
        Tierpfleger tierpfleger;
        private List<Tier> afrikaTiere;

        public Afrika(string name)
        {
            this.name = name;
        }

        public Afrika(){ }

        public string getTierName(int i)
        {
            return afrikaTiere[i].getName();
        }

        public int getTierAnzahl(int i)
        {
            return afrikaTiere[i].getAnzahl();
        }

        public string getTierGeschlecht(int i)
        {
            return afrikaTiere[i].getGeschlecht();
        }

        public int getTierZustand(int i)
        {
            return afrikaTiere[i].getZustand();
        }

        public void setTierZustand(int i)
        {
            afrikaTiere[i].setZustand();
        }

        public void fuetterTiere(int i)
        {
            afrikaTiere[i].zustandVollmachen();
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setzteAfrikaTiere(List<Tier> afrikaTiere)
        {
            this.afrikaTiere = afrikaTiere;
        }

        public List<Tier> getTiere()
        {
            return afrikaTiere;
        }

        public Tierpfleger GetTierpfleger()
        {
            return tierpfleger;
        }

        public void setTierPfleger(Tierpfleger tf)
        {
            this.tierpfleger = tf;
        }
    }
}
