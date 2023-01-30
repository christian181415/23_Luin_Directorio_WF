using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if(CBoxEmpresa.Text == "Farmaceutica Luin")
            {
                if(CBoxNombre.Text == "Christian De Jesus Moreno")
                {
                    DataUser usuario = new DataUser();
                    usuario.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto");
                }
            }


            if (CBoxEmpresa.Text == "")
            {
                if (CBoxNombre.Text == "$login")
                {
                    AdminUser usuario = new AdminUser();
                    usuario.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto");
                }
            }

        }
    }
}
