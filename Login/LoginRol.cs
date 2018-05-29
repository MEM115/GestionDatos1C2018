using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class LoginRol : Form
    {
        public static string Rol;
        public static int idRol;

        public LoginRol()
        {
            InitializeComponent();
            DataTable resultado = SqlConexion.consultaQuery("SELECT r.ID_Rol, r.Nombre FROM Roles r join Roles_X_Usuario x on r.ID_Rol = x.ID_Rol WHERE x.ID_Usuario = " + Login.idUsuario + " and r.Estado = 1");
            foreach (DataRow row in resultado.Rows) {
                ComboboxItem item = new ComboboxItem();
                item.Text = row[1].ToString();
                item.Value = int.Parse(row[0].ToString());
                comboRoles.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboboxItem item = comboRoles.SelectedItem as ComboboxItem;
            if (!(item is null)) {
                idRol = item.Value;
                Rol = item.Text;
                this.Hide();
                new Menu().Show();
            }
            else {
                MessageBox.Show("Seleccionar un rol", "Roles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
