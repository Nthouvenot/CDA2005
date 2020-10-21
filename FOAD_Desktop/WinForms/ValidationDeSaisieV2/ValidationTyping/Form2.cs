using ClassLibraryFacture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationSaisies
{
    public partial class Form2 : Form
    {
        Bill bill1;
        public Form2()
        {
            Bill Bill1 = new Bill("undefined", DateTime.Today, 0, "undefined");
            InitializeComponent();
        }

        private void buttonShowForm1_Click(object sender, EventArgs e)
        {
            Form1 formulaireSaisie = new Form1();
            formulaireSaisie.ShowDialog();
            this.bill1 = formulaireSaisie.CurrentBill;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(this.bill1 == null)
            {
                MessageBox.Show("Pas de facture a modifier", "Modification facture", MessageBoxButtons.OK);
            } else
            {
                Form1 formulaireSaisieUpdate = new Form1(this.bill1);
                formulaireSaisieUpdate.ShowDialog();
                this.bill1 = formulaireSaisieUpdate.CurrentBill;
            }
            
        }
    }
}
