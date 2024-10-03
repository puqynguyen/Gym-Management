using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class FormGymManager : Form
    {
        public FormGymManager()
        {
            InitializeComponent();
        }

        private void FormGymManager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormAddOrAdjust f = new FormAddOrAdjust())
            {
                UpdateControlProperties(f);
                f.ShowDialog();
            }
        }

        private void UpdateControlProperties(Control parent)
        {
            foreach (Control ctr in parent.Controls)
            {
                if (ctr is Label lbl && lbl.Name == "labelRegistHistory")
                {
                    lbl.Visible = false;
                }
                else if (ctr is Button && ctr.Name == "buttonUpdate")
                {
                    ctr.Text = "Thêm";
                }
                else if (ctr is Button && ctr.Name == "buttonDelete")
                {
                    ctr.Visible = false;
                }

                if (ctr.HasChildren)
                {
                    UpdateControlProperties(ctr);
                }
            }
        }

    }
}
