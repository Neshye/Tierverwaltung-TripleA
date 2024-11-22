using System.Collections.Generic;

namespace TripleA
{
    public class Asien
    {
        private string name;
        Tierpfleger tierpfleger;
        private List<Tier> asienTiere;

        public Asien(string name)
        {
            this.name = name;
        }

        public Asien(){ }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string getTierName(int i)
        {
            return asienTiere[i].getName();
        }

        public int getTierAnzahl(int i)
        {
            return asienTiere[i].getAnzahl();
        }

        public string getTierGeschlecht(int i)
        {
            return asienTiere[i].getGeschlecht();
        }

        public int getTierZustand(int i)
        {
            return asienTiere[i].getZustand();
        }

        public void setTierZustand(int i)
        {
            asienTiere[i].setZustand();
        }

        public void setzeAsienTiere(List<Tier> asiaTiere)
        {
            this.asienTiere = asiaTiere;
        }

        public void fuetterTiere(int i)
        {
            asienTiere[i].zustandVollmachen();
        }

        public List<Tier> getTiere()
        {
            return asienTiere;
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
