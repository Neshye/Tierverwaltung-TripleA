using System;
using System.Windows.Forms;

namespace TripleA
{
    static class Program
    {
        [STAThread]

        static void Main()
        {
            Afrika afrika = new Afrika();
            Asien asien = new Asien();
            Alaska alaska = new Alaska();
            Tiere tiere = new Tiere();
            Tierpfleger tierpflegerKevin = new Tierpfleger("Kevin");
            Tierpfleger tierpflegerJaqueline = new Tierpfleger("Jaqueline");
            
            asien.setzeAsienTiere(tiere.fuelleAsienTiere());
            afrika.setzteAfrikaTiere(tiere.fuelleAfrikaTierliste());
            alaska.setzeAlaskaTiere(tiere.fuelleAlaskaTiere());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 Hauptform = new Form1(afrika, asien, alaska, tierpflegerKevin, tierpflegerJaqueline, tiere);
            Application.Run(Hauptform);

        }
    }
}
