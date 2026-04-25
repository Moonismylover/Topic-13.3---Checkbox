using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_13._3___Checkbox
{
    public partial class FormCheckDemo : Form
    {
        public FormCheckDemo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (chkStarTrek.Checked && !chkStarWars.Checked)
            {
                lblResults.Text = "You like only Star Trek!";
            }
            else if (chkStarWars.Checked && !chkStarTrek.Checked) // Only chkStarWars is selected
            {
                lblResults.Text = "You like only Star Wars!";
            }
            else if (chkStarTrek.Checked && chkStarTrek.Checked) // Both are checked
            {
                lblResults.Text = "You are truly a person of culture.";
            }
            else if (!chkStarWars.Checked && !chkStarTrek.Checked) // Neither is checked
            {
                lblResults.Text = "You have much to learn.";
            }
        }
    }
}
