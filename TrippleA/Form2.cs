using System;
using System.Drawing;
using System.Windows.Forms;

namespace TripleA
{
    public partial class Form2 : Form
    {
        Afrika afrika;
        Asien asien;
        Alaska alaska;   
        Tiere tiere;
        Tierpfleger tierpfleger;
        Form1 Hauptform;
        TierBilder bild = new TierBilder();        

        string clickedButtonTag;
        Button sendFromForm;

        Button [] btnArray = new Button[15];

        public Form2(object sender, string buttonTag, Afrika afrika1, Asien asien1, Alaska alaska1, Tiere tiere1)
        {
            sendFromForm = sender as Button;
            Hauptform = (Form1)sendFromForm.Parent;

            afrika = afrika1;
            asien = asien1;
            alaska = alaska1;
            clickedButtonTag = buttonTag;
            tiere = tiere1;

            if (buttonTag == "asiaButton")
            {
                tierpfleger = asien.GetTierpfleger();
            }
            else if (buttonTag == "afrikaButton")
            {
                tierpfleger = afrika.GetTierpfleger();
            }
            else if (buttonTag == "alaskaButton")
            {
                tierpfleger = alaska.GetTierpfleger();
            }

            InitializeComponent();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (tierpfleger != null)
            {
                if ((Hauptform.rdbKevin.Enabled == false) || (Hauptform.rdbJaqueline.Enabled == false)){
                    lblTierpfleger.Text = "Kein Tierpfleger verfügbar";
                }
                else
                {
                    lblTierpfleger.Text = tierpfleger.getName().ToString();
                }
            }

            setBereich(clickedButtonTag);
        }

        private void setBereich(string clickedButtonTag)
        {
            switch (clickedButtonTag)
            {
                case "asiaButton":
                    lblform2.Text = "Tiere in der Erlebniswelt Asien";
                    btnFeed.Tag = "Asien";
                    createTierButtons(asien, asien.getTiere().Count);
                    updateZustand();
                    break;

                case "afrikaButton":
                    lblform2.Text = "Tiere in der Erlebniswelt Afrika";
                    btnFeed.Tag = "Afrika";
                    createTierButtons(afrika, afrika.getTiere().Count);
                    updateZustand();
                    break;

                case "alaskaButton":
                    lblform2.Text = "Tiere in der Erlebniswelt Alaska";
                    btnFeed.Tag = "Alaska";
                    createTierButtons(alaska, alaska.getTiere().Count);
                    updateZustand();
                    break;
            }
        }

        private void createTierButtons(object obj, int i)
        {
            for (int j = 0; j < i; j++)
            {
                btnArray[j] = new Button();
                btnArray[j].Height = 150;
                btnArray[j].Width = 120;
                btnArray[j].Font = new Font("Arial", 9, FontStyle.Bold);
                btnArray[j].ForeColor = Color.Fuchsia;

                if (j < 6)
                {
                    btnArray[j].Top = 80;
                    btnArray[j].Left = (j) * 120;
                }
                else
                {
                    btnArray[j].Top = 250;
                    btnArray[j].Left = (j - 6) * 120;
                }

                if (obj.GetType() == typeof(Asien))
                {
                    btnArray[j].Tag = (asien.getTierName(j) + asien.getTierGeschlecht(j));
                    btnArray[j].Text = (asien.getTierName(j) + "\n\nAnzahl: " + asien.getTierAnzahl(j) + "\n\nGeschlecht: " + asien.getTierGeschlecht(j) + "\n\nZustand: " + tiere.setTierZustand(asien.getTierZustand(j)));
                }
                else if (obj.GetType() == typeof(Afrika))
                {
                    btnArray[j].Tag = (afrika.getTierName(j) + afrika.getTierGeschlecht(j));
                    btnArray[j].Text = (afrika.getTierName(j) + "\n\nAnzahl: " + afrika.getTierAnzahl(j) + "\n\nGeschlecht: " + afrika.getTierGeschlecht(j) + "\n\nZustand: " + tiere.setTierZustand(afrika.getTierZustand(j)));
                }
                else if (obj.GetType() == typeof(Alaska))
                {
                    btnArray[j].Tag = (alaska.getTierName(j) + alaska.getTierGeschlecht(j));
                    btnArray[j].Text = (alaska.getTierName(j) + "\n\nAnzahl: " + alaska.getTierAnzahl(j) + "\n\nGeschlecht: " + alaska.getTierGeschlecht(j) + "\n\nZustand: " + tiere.setTierZustand(alaska.getTierZustand(j)));
                }

                this.Controls.Add(btnArray[j]);
            }

            if (obj.GetType() == typeof(Alaska))
            {
                bild.erstelleBilderAlaska(alaska, btnArray);
            }
            else if (obj.GetType() == typeof(Asien))
            {
                bild.erstelleBilderAsien(asien, btnArray);
            }
            else
            {
                bild.erstelleBilderAfrika(afrika, btnArray);
            }
        }

        private void updateZustand()
        {
            for (int i = 0; i < 12; i++)
            {
                asien.setTierZustand(i);
                afrika.setTierZustand(i);
                alaska.setTierZustand(i);
            }
        }

        private void fuetterTiere(object obj)
        {
            Hauptform.setHungerStatus(obj);

            for (int i = 0; i < 11; i++)
            {
                if (obj.GetType() == typeof(Asien))
                {
                    asien.fuetterTiere(i);
                }else if (obj.GetType() == typeof(Afrika))
                {
                    afrika.fuetterTiere(i);
                }else if (obj.GetType() == typeof(Alaska))
                {
                    alaska.fuetterTiere(i);
                }
            }            
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            sendFromForm = sender as Button;

            if ((Hauptform.rdbKevin.Enabled == false) || (Hauptform.rdbJaqueline.Enabled == false))
            {
                setLagerCounter();
            }

            if ((Hauptform.rdbKevin.Enabled == false) && (Hauptform.rdbJaqueline.Enabled == false))
            {
                MessageBox.Show("Der Tierpfleger " + tierpfleger.getName().ToString() + " und die Tierpflegerin " + tierpfleger.getName().ToString() + " sind beide im Lager...");
            }
            else if ((Hauptform.pbKevin.Value <= 15) || (Hauptform.pbJaqueline.Value <= 15))
            {
                MessageBox.Show("Der Tierpfleger " + tierpfleger.getName().ToString() + " hat nicht mehr genug Futter dabei. Gehen Sie bitte ins Lager um den Vorrat aufzufüllen","WARNUNG!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (sendFromForm.Tag.ToString())
                {
                    case "Asien":
                        fuetterTiere(asien);
                        break;
                    case "Afrika":
                        fuetterTiere(afrika);
                        break;
                    case "Alaska":
                        fuetterTiere(alaska);
                        break;
                }

                tierpfleger.setFuetterungen();
                MessageBox.Show(tierpfleger.getName().ToString() + " hat die Tiere in der Themenwelt " + sendFromForm.Tag.ToString() + " gefüttert.");
            }

            if (tierpfleger.getName() == "Kevin")
            {
                Hauptform.setStatusBarKevin();
            }
            else
            {
                Hauptform.setStatusBarJaq();
            }

            this.Close();
            Hauptform.Show();
        }

        private void setLagerCounter()
        {
            if ((Hauptform.rdbKevin.Enabled == false) && (Hauptform.rdbJaqueline.Enabled == false)){
                Hauptform.GetTierPflegerM().setLagerCounter(1);
                Hauptform.GetTierPflegerW().setLagerCounter(1);
            }
            else if (Hauptform.rdbKevin.Enabled == false)
            {
                Hauptform.GetTierPflegerM().setLagerCounter(1);
            }
            else if (Hauptform.rdbJaqueline.Enabled == false)
            {
                Hauptform.GetTierPflegerW().setLagerCounter(1);
            }
        }
     
        private void btnClose_Click(object sender, EventArgs e)
        {
            setLagerCounter();
            this.Close();
            Hauptform.Show();
        }

        public void setTierPfleger(Tierpfleger tf)
        {
            tierpfleger = tf;
        }

        public Tierpfleger GetTierpfleger()
        {
            return tierpfleger;
        }
    }
}