using System;
using System.Drawing;
using System.Windows.Forms;

namespace TripleA
{
    public class TierBilder
    {
        Bitmap bild;
        Afrika afrika;
        Asien asien;
        Alaska alaska;

        public void erstelleBilderAsien(Asien asien, Button[] btnArray)
        {
            for (int j = 0; j < 12; j++)
            {
                if (string.Equals(asien.getTierName(j), "Cobras", StringComparison.OrdinalIgnoreCase))
                {
                    string bildCobra = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Cobra.png";
                    btnArray[j].BackgroundImage = new Bitmap(bildCobra);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(asien.getTierName(j), "Pythons", StringComparison.OrdinalIgnoreCase))
                {
                    string bildPython = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Python.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildPython);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(asien.getTierName(j), "Alligatoren", StringComparison.OrdinalIgnoreCase))
                {
                    string bildAlligator = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Alligator.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildAlligator);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(asien.getTierName(j), "Guppys", StringComparison.OrdinalIgnoreCase))
                {
                    string bildGuppys = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Guppys.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildGuppys);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(asien.getTierName(j), "Pandas", StringComparison.OrdinalIgnoreCase))
                {
                    string bildPanda = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Panda.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildPanda);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(asien.getTierName(j), "Amurtiger", StringComparison.OrdinalIgnoreCase))
                {
                    string bildAmurtiger = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Amurtiger.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildAmurtiger);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
        public void erstelleBilderAlaska(Alaska alaska, Button[] btnArray)
        {
            for (int j = 0; j < 12; j++)
            {

                if (string.Equals(alaska.getTierName(j), "Eisbären", StringComparison.OrdinalIgnoreCase))
                {
                    string bildEisbaer = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Eisbaer.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildEisbaer);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(alaska.getTierName(j), "Braunbären", StringComparison.OrdinalIgnoreCase))
                {
                    string bildBraunbaer = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Braunbaer.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildBraunbaer);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(alaska.getTierName(j), "Grizzlys", StringComparison.OrdinalIgnoreCase))
                {
                    string bildGrizzly = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\grizzly.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildGrizzly);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(alaska.getTierName(j), "Seepferdchen", StringComparison.OrdinalIgnoreCase))
                {
                    string bildSeepferdchen = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\seepferdchen.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildSeepferdchen);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(alaska.getTierName(j), "Seelöwen", StringComparison.OrdinalIgnoreCase))
                {
                    string bildSeeloewe = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\seelöwe.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildSeeloewe);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(alaska.getTierName(j), "Schnee-Eulen", StringComparison.OrdinalIgnoreCase))
                {
                    string bildSchneeeule = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Schneeeule.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildSchneeeule);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
        public void erstelleBilderAfrika(Afrika afrika, Button[] btnArray)
        {
            for (int j = 0; j < 12; j++)
            {

                if (string.Equals(afrika.getTierName(j), "Tarzan", StringComparison.OrdinalIgnoreCase))
                {
                    string bildTarzan = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Tarzan.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildTarzan);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(afrika.getTierName(j), "Orang Utans", StringComparison.OrdinalIgnoreCase))
                {
                    string bildOrangUtan = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\OrangUtan.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildOrangUtan);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(afrika.getTierName(j), "Schimpansen", StringComparison.OrdinalIgnoreCase))
                {
                    string bildSchimpansen = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Schimpansen.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildSchimpansen);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(afrika.getTierName(j), "Cheetah", StringComparison.OrdinalIgnoreCase))
                {
                    string bildCheetah = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\cheetah.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildCheetah);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(afrika.getTierName(j), "Zebras", StringComparison.OrdinalIgnoreCase))
                {
                    string bildZebras = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\Zebra.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildZebras);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(afrika.getTierName(j), "Kamele", StringComparison.OrdinalIgnoreCase))
                {
                    string bildKamele = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\kamel.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildKamele);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (string.Equals(afrika.getTierName(j), "Pferde", StringComparison.OrdinalIgnoreCase))
                {
                    string bildPferde = @"C:\Users\cl907\Desktop\OneDrive - BITLC Business IT Learning Center GmbH\Projekt\TrippleA\Properties\pferde.jpg";
                    btnArray[j].BackgroundImage = new Bitmap(bildPferde);
                    btnArray[j].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
    }
}