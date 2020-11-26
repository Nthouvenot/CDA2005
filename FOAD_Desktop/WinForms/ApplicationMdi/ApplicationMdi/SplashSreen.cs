using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationMdi
{
    public partial class SplashSreen : Form
    {
        public SplashSreen()
        {
            InitializeComponent();
            timerSplashShow.Start();
        }

        private void timerSplashShow_Tick(object sender, EventArgs e)
        {
            timerSplashShow.Stop();

            //display mainform

            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();

            //hide this form
            this.Hide();
        }
    }
}
