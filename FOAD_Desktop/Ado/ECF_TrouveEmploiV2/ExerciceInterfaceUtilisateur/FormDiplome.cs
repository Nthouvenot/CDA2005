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
    public partial class FormDiplome : Form
    {
        private DateTime dateDobtention;
        private EnumDiplomes diplomeObtenu;

        public DateTime DateDobtention { get => dateDobtention; }
        public EnumDiplomes DiplomeObtenu { get => diplomeObtenu; }

        /// <summary>
        /// constructeur edition de la fenetre en mode creation
        /// </summary>
        public FormDiplome()
        {
            InitializeComponent();
            dateDobtention = DateTime.Now;
            diplomeObtenu = EnumDiplomes.Bac;
        }

        /// <summary>
        /// constructeur edition de la fenetre en mode modification
        /// </summary>
        public FormDiplome(DateTime dateDobtention, EnumDiplomes diplomeObtenu)
        {
            InitializeComponent();
            this.dateDobtention = dateDobtention;
            this.diplomeObtenu = diplomeObtenu;
        }

        private void FormDiplome_Load(object sender, EventArgs e)
        {
            this.dateTimePickerDateDobtention.Value = dateDobtention;
            foreach (string dNom in Enum.GetNames(typeof(EnumDiplomes)))
            {
                this.comboBoxDiplomes.Items.Add(dNom);
            }
            this.comboBoxDiplomes.SelectedItem = this.diplomeObtenu.ToString();
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            if (!CheckTools.Verificationdate(dateTimePickerDateDobtention.Value))
            {
                MessageBox.Show("La date doit etre inférieur a la date actuelle", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }

        private void DateTimePickerDateDobtention_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            if (!CheckTools.Verificationdate(dateTimePicker.Value))
            {
                errorProviderDate.SetError(dateTimePickerDateDobtention, "la date doit être inférieur a la date actuelle");
            }
            else
            {
                errorProviderDate.Clear();
            }
        }
        
        public Sdiplome GetDiplome()
        {
            Sdiplome diplome = new Sdiplome();
            diplome.dateDobtention = this.dateDobtention;
            diplome.diplomeObtenu = this.diplomeObtenu;
            return diplome;
        }
    }
}
