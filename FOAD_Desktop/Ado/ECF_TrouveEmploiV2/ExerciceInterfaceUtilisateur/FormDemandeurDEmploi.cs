using ClassLibraryCheckTools;
using ClassLibraryMetier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceInterfaceUtilisateur
{
    public partial class FormDemandeurDEmploi : Form
    {
        private DemandeurDEmploi unDemandeurDEmploi;

        public DemandeurDEmploi UnDemandeurDEmploi { get => unDemandeurDEmploi; }

        public FormDemandeurDEmploi()
        {
            InitializeComponent();
            this.unDemandeurDEmploi = new DemandeurDEmploi();
        }

        private void TextBoxPuce_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(!CheckTools.VerificationNumeroSecuriteSocial(textBox.Text) && textBox.Text.Length != 0)
            {
                errorProviderPuce.SetError(textBoxPuce, "le numéro de sécurité social est composé de 15 chiffres et être cohérent");
            }
            else
            {
                errorProviderPuce.Clear();
            }
        }

        private void TextBoxNom_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!CheckTools.VerificationNomPrenom(textBox.Text) && textBox.Text.Length != 0)
            {
                errorProviderNom.SetError(textBoxNom, "Le nom doit faire au minimum 4 lettres et moins de 50");
            }
            else
            {
                errorProviderNom.Clear();
            }
        } 
        
        private void TextBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!CheckTools.VerificationNomPrenom(textBox.Text) && textBox.Text.Length != 0)
            {
                errorProviderPrenom.SetError(textBoxPrenom, "Le nom doit faire au minimum 4 lettres et moins de 50");
            }
            else
            {
                errorProviderPrenom.Clear();
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            if(!CheckTools.Verificationdate(dateTimePicker.Value))
            {
                errorProviderdate.SetError(dateTimePicker1, "la date doit être inférieur a la date actuelle");
            }
            else
            {
                errorProviderdate.Clear();
            }
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            bool nonValide = false;
            if (!CheckTools.VerificationNumeroSecuriteSocial(textBoxPuce.Text))
            {
                nonValide = true;
            }
            else if (!CheckTools.VerificationNomPrenom(textBoxNom.Text))
            {
                nonValide = true;
            }
            else if (!CheckTools.VerificationNomPrenom(textBoxPrenom.Text))
            {
                nonValide = true;
            }
            else if (!CheckTools.Verificationdate(dateTimePicker1.Value))
            {
                nonValide = true;
            }
            else if (unDemandeurDEmploi.Diplomes.Count == 0)
            {
                nonValide = true;
            }
            else
            {
                nonValide = false;
                bool addDemandeurEmploiOk = false;
                bool addDiplomesOk = false;
                unDemandeurDEmploi.AddDemandeurEmploi();
                unDemandeurDEmploi.AddDiplomes();
                if (addDemandeurEmploiOk && addDiplomesOk)
                {
                    MessageBox.Show("enregistrement effectué", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (nonValide)
            {
                MessageBox.Show("Tout les champs doivent être corectement remplis ainsi que les diplomes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAjouterDiplome_Click(object sender, EventArgs e)
        {
            Sdiplome diplome = new Sdiplome();
            FormDiplome formDiplome = new FormDiplome();
            formDiplome.ShowDialog();
            diplome = formDiplome.GetDiplome();
            ListViewItem item = new ListViewItem();
            this.unDemandeurDEmploi.Diplomes.Add(diplome.dateDobtention, diplome.diplomeObtenu);
            item.SubItems.Add(this.unDemandeurDEmploi.Diplomes.Last().Key.ToString());
            item.SubItems.Add(this.unDemandeurDEmploi.Diplomes.Last().Value.ToString());
            listView1.Items.Add(item);
        }
    }
}


