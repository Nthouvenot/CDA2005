using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papyrus
{
    public partial class SupplierSearchWindow : Form
    {
        public SupplierSearchWindow()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            PrintSupplierDataWindow form = new PrintSupplierDataWindow(textBoxSupplierCode.Text);
            form.Parent = this;
            form.Show();
        }

        private void TextBoxSupplierCode_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Regex supplierCodeRegex = new Regex("^[0-9]{1,10}$");
            if (!supplierCodeRegex.IsMatch(textBox.Text))
            {
                errorProviderCode.SetError(textBoxSupplierCode, "le code fournisseur doit comporter de 1 a 10 chiffres");
            }
            else
            {
                errorProviderCode.Clear();
                buttonOk.Enabled = true;
            }
        }
    }
}
