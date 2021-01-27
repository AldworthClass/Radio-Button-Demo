using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button_Demo
{
    public partial class FormRadioDemo : Form
    {
        public FormRadioDemo()
        {
            InitializeComponent();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            imgSaber.Image = Properties.Resources.SaberRed;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            imgSaber.Image = Properties.Resources.SaberBlue;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            imgSaber.Image = Properties.Resources.SaberGreen;
        }

        private void btnSubmitShip_Click(object sender, EventArgs e)
        {
            if (radEnterprise.Checked)
            {
                lblShip.Text = "You are correct.";
            }
            else if (radFalcon.Checked)
            {
                lblShip.Text = "I see you don't like science fiction.";
            }
            else
            {
                lblShip.Text = "Hang your head in shame.";
            }
        }
    }
}
