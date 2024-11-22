using System.Collections.Generic;

namespace TripleA
{
    public class Alaska
    {
        private string name;
        Tierpfleger tierpfleger;
        private List<Tier> alaskaTiere;

        public Alaska(string name)
        {
            this.name = name;
        }

        public Alaska(){ }

        public string getTierName(int i)
        {
            return alaskaTiere[i].getName();
        }

        public int getTierAnzahl(int i)
        {
            return alaskaTiere[i].getAnzahl();
        }

        public string getTierGeschlecht(int i)
        {
            return alaskaTiere[i].getGeschlecht();
        }

        public int getTierZustand(int i)
        {
            return alaskaTiere[i].getZustand();
        }

        public void setTierZustand(int i)
        {
            alaskaTiere[i].setZustand();
        }

        public void setzeAlaskaTiere(List<Tier> alaskaTiere)
        {
            this.alaskaTiere = alaskaTiere;
        }

        public void fuetterTiere(int i)
        {
            alaskaTiere[i].zustandVollmachen();
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public List<Tier> getTiere()
        {
            return alaskaTiere;
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
