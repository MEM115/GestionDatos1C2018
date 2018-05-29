using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class ListadoRol : Form
    {
        public ListadoRol()
        {
            InitializeComponent();
            DataTable resultado = SqlConexion.consultaQuery("SELECT r.ID_Rol, r.Nombre FROM Roles r");
            BindingSource bSource = new BindingSource();
            bSource.DataSource = resultado;
            gridRoles.DataSource = bSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABMRol pant = new ABMRol(0);
            pant.Show();
        }

        private void gridRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            ABMRol pant = new ABMRol(int.Parse(gridRoles.CurrentRow.Cells[0].Value.ToString()));
            pant.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }
    }
}
