using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLauncher;

namespace Game_Launcher
{
    public partial class fGameLauncher : Form
    {
        public fGameLauncher()
        {
            InitializeComponent();
        }

        private void fGameLauncher_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < GameController.Spiele.Count; i++)
            {
                lbSpiele.Items.Add(GameController.Spiele[i]);
            }
        }

        private void lbSpiele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSpiele.SelectedItem != null)
            {
                tbTitel.Text = ((Spiel)lbSpiele.SelectedItem).Titel;
                tbInstallationsDatum.Text = ((Spiel)lbSpiele.SelectedItem).InstallationsDatum.ToString();
                tbZuletztGespielt.Text = ((Spiel)lbSpiele.SelectedItem).Zuletzt_gespielt.ToString();
                tbInstallationsPfad.Text = ((Spiel)lbSpiele.SelectedItem).Pfad;
                tbKategorien.Text = ((Spiel)lbSpiele.SelectedItem).Kategorien;
                tbPublisher.Text = ((Spiel)lbSpiele.SelectedItem).Publisher;
                tbUSK.Text = ((Spiel)lbSpiele.SelectedItem).USK.ToString();
            }
        }

        private void bPfadKopieren_Click(object sender, EventArgs e)
        {
            if (tbInstallationsPfad.Text != "")
            {
                Clipboard.SetText(tbInstallationsPfad.Text);
            }
        }

        private void bStarten_Click(object sender, EventArgs e)
        {
            if (lbSpiele.SelectedItem != null)
            {
                GameController.Spiel_Starten((Spiel)lbSpiele.SelectedItem);
            }
        }

        private void bSpielEntfernen_Click(object sender, EventArgs e)
        {
            if (lbSpiele.SelectedItem != null)
            {
                GameController.Spiel_Entfernen((Spiel)lbSpiele.SelectedItem);
            }
        }

        private void bSpielHinzufügen_Click(object sender, EventArgs e)
        {
            if (tbPfadHinzufügen.Text == "" || tbKategorienHinzufügen.Text == "" ||tbUSKHinzufügen.Text == "")
            {
                MessageBox.Show("Bitte geben Sie den Titel, die Kategorien und die USK ein!");
            }
            else
            {
                GameController.Spiel_Hinzufügen(tbPfadHinzufügen.Text, tbKategorienHinzufügen.Text, Convert.ToInt32(tbUSKHinzufügen.Text));
            }
        }

        private void bSuchen_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdSpielSuchen.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPfadHinzufügen.Text = ofdSpielSuchen.FileName;
            }
        }
    }
}
