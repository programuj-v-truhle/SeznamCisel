using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeznamCisel
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        int soucet = 0;
        int maxPrvek = int.MinValue;
        int minPrvek = int.MaxValue;

        private void vlozCislo_Click(object sender, EventArgs e)
        {
            int naseCislo = 0;
            if (int.TryParse(vkladaneCislo.Text, out naseCislo))
            {
                seznam.Items.Add(naseCislo);
                vkladaneCislo.Clear();

                soucet += naseCislo;

                float prumerCisel = (float) soucet / (float)seznam.Items.Count;
                prumer.Text = "Prumer cisel: " + prumerCisel.ToString();

                if (naseCislo > maxPrvek)
                {
                    maxPrvek = naseCislo;
                }

                if (naseCislo < minPrvek)
                {
                    minPrvek = naseCislo;
                }

                nejvetsi.Text = "Nejvetsi cislo : " + maxPrvek.ToString();
                nejmensi.Text = "Nejmensi cislo : " + minPrvek.ToString();
            }
        }

        private void seznam_DoubleClick(object sender, EventArgs e)
        {
            soucet -= (int)seznam.SelectedItem;
            seznam.Items.Remove(seznam.SelectedItem);

            minPrvek = int.MaxValue;
            maxPrvek = int.MinValue;
            for (int i = 0; i < seznam.Items.Count; i++)
            {
                if ((int)seznam.Items[i] > maxPrvek)
                {
                    maxPrvek = (int)seznam.Items[i];
                }

                if ((int)seznam.Items[i] < minPrvek)
                {
                    minPrvek = (int)seznam.Items[i];
                }
            }
            nejvetsi.Text = "Nejvetsi cislo : " + maxPrvek.ToString();
            nejmensi.Text = "Nejmensi cislo : " + minPrvek.ToString();
 
        }

        private void vkladaneCislo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                vlozCislo.PerformClick();
            }
        }

        private void seznam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)seznam.SelectedItem % 2 == 0)
            {
                parita.Text = "Parita : sude";
            }
            else
            {
                parita.Text = "Parita : liche";    
            }
        }

      

    }
}
