using System.Collections.Generic;
using System.Drawing;

namespace TripleA
{
    public class Tiere : Tier
    {

        private List<Tier> afrikaTierListe = new List<Tier>();
        private List<Tier> asienTierListe = new List<Tier>();
        private List<Tier> alaskaTierListe = new List<Tier>();

        public List<Tier> fuelleAfrikaTierliste()
        {
            afrikaTierListe.Add(new Tier("Tarzan", 1, "Männchen"));
            afrikaTierListe.Add(new Tier("Orang Utans", 1, "Männchen"));
            afrikaTierListe.Add(new Tier("Orang Utans", 3, "Weibchen"));
            afrikaTierListe.Add(new Tier("Schimpansen", 17, "Männchen"));
            afrikaTierListe.Add(new Tier("Schimpansen", 1, "Weibchen"));
            afrikaTierListe.Add(new Tier("Cheetah", 1, "Männchen"));
            afrikaTierListe.Add(new Tier("Zebras", 10, "Männchen"));
            afrikaTierListe.Add(new Tier("Zebras", 5, "Weibchen"));
            afrikaTierListe.Add(new Tier("Kamele", 7, "Männchen"));
            afrikaTierListe.Add(new Tier("Kamele", 7, "Weibchen"));
            afrikaTierListe.Add(new Tier("Pferde", 10, "Männchen"));
            afrikaTierListe.Add(new Tier("Pferde", 11, "Weibchen"));

            return afrikaTierListe;
        }

        public List<Tier> fuelleAsienTiere()
        {
            asienTierListe.Add(new Tier("Cobras", 1, "Männchen"));
            asienTierListe.Add(new Tier("Cobras", 1, "Weibchen"));
            asienTierListe.Add(new Tier("Pythons", 1, "Männchen"));
            asienTierListe.Add(new Tier("Pythons", 1, "Weibchen"));
            asienTierListe.Add(new Tier("Alligatoren", 3, "Männchen"));
            asienTierListe.Add(new Tier("Alligatoren", 2, "Weibchen"));
            asienTierListe.Add(new Tier("Guppys", 789, "Männchen"));
            asienTierListe.Add(new Tier("Guppys", 1000, "Weibchen"));
            asienTierListe.Add(new Tier("Pandas", 2, "Männchen"));
            asienTierListe.Add(new Tier("Pandas", 6, "Weibchen"));
            asienTierListe.Add(new Tier("Amurtiger", 2, "Männchen"));
            asienTierListe.Add(new Tier("Amurtiger", 5, "Weibchen"));

            return asienTierListe;
        }

        public List<Tier> fuelleAlaskaTiere()
        {
            alaskaTierListe.Add(new Tier("Eisbären", 5, "Männchen"));
            alaskaTierListe.Add(new Tier("Eisbären", 2, "Weibchen"));
            alaskaTierListe.Add(new Tier("Braunbären", 1, "Männchen"));
            alaskaTierListe.Add(new Tier("Braunbären", 1, "Weibchen"));
            alaskaTierListe.Add(new Tier("Grizzlys", 1, "Männchen"));
            alaskaTierListe.Add(new Tier("Grizzlys", 2, "Weibchen"));
            alaskaTierListe.Add(new Tier("Seepferdchen", 18, "Männchen"));
            alaskaTierListe.Add(new Tier("Seepferdchen", 15, "Weibchen"));
            alaskaTierListe.Add(new Tier("Seelöwen", 11, "Männchen"));
            alaskaTierListe.Add(new Tier("Seelöwen", 11, "Weibchen"));
            alaskaTierListe.Add(new Tier("Schnee-Eulen", 12, "Männchen"));
            alaskaTierListe.Add(new Tier("Schnee-Eulen", 14, "Weibchen"));


            return alaskaTierListe;
        }

        public string setTierZustand(int i)
        {
            string sZustandTier = "";
            switch (i)
            {
                case 100:
                    sZustandTier = "sind Satt.";
                    break;

                case 75:
                    sZustandTier = "sind fast satt.";
                    break;

                case 50:
                    sZustandTier = "sind hungrig.";
                    break;

                case 25:
                    sZustandTier = "sind sehr hungrig.";
                    break;

                case 0:
                    sZustandTier = "sind Tot.";
                    break;
            }

            return sZustandTier;
        }

        public Bitmap lebensAnzeige(int flag)
        {
            if (flag == 100 || flag == 125)
            {
                return new Bitmap(@"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Leben100.png");
            }
            else if (flag == 75)
            {
                return new Bitmap(@"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Leben75eckig.png");
            }
            else if (flag == 50)
            {
                return new Bitmap(@"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Leben50.png");
            }
            else if (flag == 25)
            {
                return new Bitmap(@"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Leben25.png");
            }
            else if (flag == 0)
            {
                return new Bitmap(@"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Totenkopf.jpg");
            }
            else
            {
                return null;
            }
        }

        public List<Tier> getAfrikaTiere()
        {
            return afrikaTierListe;
        }

        public List<Tier> getAsienTiere()
        {
            return asienTierListe;
        }

        public List<Tier> getAlaskaTiere()
        {
            return alaskaTierListe;
        }
    }
}
