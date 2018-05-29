using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            LabelUserLogueado.Text = Login.Login.Usuario;
            DataTable resultado = SqlConexion.consultaQuery("SELECT Descripcion FROM Funcionalidades f JOIN Funcionalidades_X_Rol x on x.ID_Funcionalidad = f.ID_Funcionalidad where x.ID_Rol = " + Login.LoginRol.idRol);
            foreach (DataRow row in resultado.Rows)
            {
                foreach (Control con in Controls)
                {
                    if (row[0].ToString() == con.Text)
                    {
                        con.Show();
                    }
                }
            }
        }

        private void ButtonRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmRol.ListadoRol().Show();
        }
    }
}
