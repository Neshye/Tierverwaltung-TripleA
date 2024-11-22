using System;
using System.Drawing;
using System.Windows.Forms;

namespace TripleA
{
    public partial class Form1 : Form
    {
        Afrika afrika;
        Asien asien;
        Alaska alaska;
        Tierpfleger tierpflegerM;
        Tierpfleger tierpflegerW;
        Tierpfleger aktTierpfleger;
        Tiere tiere;
        Lager lager = new Lager();

        Bitmap hpBarAsien;
        Bitmap hpBarAfrika;
        Bitmap hpBarAlaska;
        Button clickedButton;

        int hungerStatus = 100;

        public Form1() { }

        public Form1(Afrika afrika1, Asien asien1, Alaska alaska1, Tierpfleger tierpfleger1, Tierpfleger tierpfleger2, Tiere tiere1)
        {
            afrika = afrika1;
            asien = asien1;
            alaska = alaska1;
            tierpflegerM = tierpfleger1;
            tierpflegerW = tierpfleger2;
            tiere = tiere1;

            tierpflegerM.resetLagerCounter();
            tierpflegerW.resetLagerCounter();

            InitializeComponent();
            
            pbKevin.Value = 100;
            pbJaqueline.Value = 100;
            
            setZustand();
            setStatusBarKevin();
            setStatusBarJaq();
            setTierpflegerWerte();

            this.Activated += (sender, e) => UpdateForm();
        }

        private void btnAsia_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            if (rdbKevin.Checked == true)
            {
                asien.setTierPfleger(tierpflegerM);
            }
            else if (rdbJaqueline.Checked == true)
            {
                asien.setTierPfleger(tierpflegerW);
            }
            
            Form2 tierUebersicht = new Form2(sender, clickedButton.Tag.ToString(), afrika, asien, alaska, tiere);
            tierUebersicht.Show();
            this.Hide();
        }

        private void btnAfrika_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            if (rdbKevin.Checked == true)
            {
                afrika.setTierPfleger(tierpflegerM);
            }
            else if (rdbJaqueline.Checked == true)
            {
                afrika.setTierPfleger(tierpflegerW);
            }
            Form2 tierUebersicht = new Form2(sender, clickedButton.Tag.ToString(), afrika, asien, alaska, tiere);
            tierUebersicht.Show();
            this.Hide();
        }

        private void btnAlaska_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            if (rdbKevin.Checked == true)
            {
                alaska.setTierPfleger(tierpflegerM);
            }
            else if (rdbJaqueline.Checked == true)
            {
                alaska.setTierPfleger(tierpflegerW);
            }
            Form2 tierUebersicht = new Form2(sender, clickedButton.Tag.ToString(), afrika, asien, alaska, tiere);
            tierUebersicht.Show();
            this.Hide();
        }

        private void UpdateForm(){
            setZustand();
            setTierpflegerWerte();
            checkLagerCounter();                       

            if (asien.getTierZustand(1) == 0)
            {
                asiaButton.Enabled = false;
            }
            if (afrika.getTierZustand(1) == 0)
            {
                afrikaButton.Enabled = false;
            }
            if (alaska.getTierZustand(1) == 0)
            {
                alaskaButton.Enabled = false;
            }
        }

        private void setZustand()
        {
            hpBarAsien = tiere.lebensAnzeige(asien.getTierZustand(1));
            asiaButton.Image = hpBarAsien;
            asiaButton.Text = ("Asien" + "\n\n" + "Zustand der Tiere: \n\n" + tiere.setTierZustand(asien.getTierZustand(1)));

            hpBarAfrika = tiere.lebensAnzeige(afrika.getTierZustand(1));
            afrikaButton.Image = hpBarAfrika;
            afrikaButton.Text = ("Afrika" + "\n\n" + "Zustand der Tiere: \n\n" + tiere.setTierZustand(afrika.getTierZustand(1)));

            hpBarAlaska = tiere.lebensAnzeige(alaska.getTierZustand(1));
            alaskaButton.Image = hpBarAlaska;
            alaskaButton.Text = ("Alaska" + "\n\n" + "Zustand der Tiere: \n\n" + tiere.setTierZustand(alaska.getTierZustand(1)));
        }

        private void setTierpflegerWerte()
        {
            rdbKevin.Text = tierpflegerM.getName().ToString();
            rdbJaqueline.Text = tierpflegerW.getName().ToString();

            if (rdbKevin.Enabled == true) {
                lblKevinFeedCounter.Text = "Anzahl Fütterungen: " + tierpflegerM.getFuetterungen().ToString();
            }
            if (rdbJaqueline.Enabled == true)
            {
                lblJaquelineFeedCounter.Text = "Anzahl Fütterungen: " + tierpflegerW.getFuetterungen().ToString();
            }       
        }

        public void setHungerStatus(object obj)
        {
            if (obj.GetType() == typeof(Asien))
            {
                hungerStatus = asien.getTierZustand(1);
            }
            else if (obj.GetType() == typeof(Afrika))
            {
                hungerStatus = afrika.getTierZustand(1);
            }
            else if (obj.GetType() == typeof(Alaska))
            {
                hungerStatus = alaska.getTierZustand(1);
            }  
        }

        public void setStatusBarKevin()
        {
            if (pbKevin.Value >= 15)
            {
                pbKevin.Value -= ((100 - hungerStatus) / 5);
                lblStatusKev.Text = pbKevin.Value.ToString();
            }
        }

        public void setStatusBarJaq()
        {
            if (pbJaqueline.Value >= 15)
            {
                pbJaqueline.Value -= ((100 - hungerStatus) / 5);
                lblStatusJaq.Text = pbJaqueline.Value.ToString();
            }
        }

        private void btnLagerKevin_Click(object sender, EventArgs e)
        {
            lblKevinFeedCounter.Text = "Im Lager";
            btnLagerKevin.Enabled = false;
            rdbJaqueline.Checked = true;
            rdbKevin.Enabled = false;
            lager.Tierpfleger = tierpflegerM;
        }

        private void btnLagerJaq_Click(object sender, EventArgs e)
        {
            lblJaquelineFeedCounter.Text = "Im Lager";
            rdbJaqueline.Enabled = false;
            rdbKevin.Checked = true;
            btnLagerJaq.Enabled = false;
            lager.Tierpfleger = tierpflegerW;
        }

        private void checkLagerCounter()
        {

            if (tierpflegerM.getLagerCounter() == 3)
            {
                if (btnLagerKevin.Enabled == false)
                {
                    btnLagerKevin.Enabled = true;
                    rdbKevin.Enabled = true;
                    pbKevin.Value = 100;
                    lblStatusKev.Text = "100";
                }

                setTierPflegerM(tierpflegerM);
                tierpflegerM.resetLagerCounter();
            }

            if (tierpflegerW.getLagerCounter() == 3)
            {
                if (btnLagerJaq.Enabled == false)
                {
                    btnLagerJaq.Enabled = true;
                    rdbJaqueline.Enabled = true;
                    pbJaqueline.Value = 100;
                    lblStatusJaq.Text = "100";
                }

                setTierPflegerW(tierpflegerW);
                tierpflegerW.resetLagerCounter();
            }
            setTierpflegerWerte();
        }

        public Tierpfleger GetTierPflegerM()
        {
            return tierpflegerM;
        }

        public void setTierPflegerM(Tierpfleger tf)
        {
            this.tierpflegerM = tf;
        }

        public Tierpfleger GetTierPflegerW()
        {
            return tierpflegerW;
        }

        public void setTierPflegerW(Tierpfleger tf)
        {
            this.tierpflegerW = tf;
        }
    }
}
