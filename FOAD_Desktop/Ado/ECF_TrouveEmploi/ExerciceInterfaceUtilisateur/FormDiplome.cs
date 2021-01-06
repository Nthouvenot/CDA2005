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

        public FormDiplome()
        {
            InitializeComponent();
            dateDobtention = DateTime.Now;
            diplomeObtenu = EnumDiplomes.Bac;

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

        private void buttonValider_Click(object sender, EventArgs e)
        {
            // a coder
        }

       
    }
}
