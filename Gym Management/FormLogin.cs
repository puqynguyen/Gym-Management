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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            FormGymManager f = new FormGymManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
        }
    }
}