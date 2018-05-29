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
    public partial class ABMRol : Form
    {
        public int idRol;

        public ABMRol(int id)
        {
            InitializeComponent();
            idRol = id;
            if (idRol == 0) {
                buttonBorrar.Hide();
            }
            DataTable resultado = SqlConexion.consultaQuery("SELECT ID_Funcionalidad, Descripcion FROM Funcionalidades");
            foreach (DataRow row in resultado.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = row[1].ToString();
                item.Value = int.Parse(row[0].ToString());
                comboFuncionalidad.Items.Add(item);
            }
            if(idRol > 0) {
                resultado = SqlConexion.consultaQuery("SELECT TOP 1 Nombre,Estado FROM Roles WHERE ID_Rol = " + idRol);
                if (resultado.Rows.Count > 0) {
                    DataRow row = resultado.Rows[0];
                    textNombre.Text = row[0].ToString();
                    checkEstado.Checked = (bool)row[1];
                    resultado = SqlConexion.consultaQuery("SELECT f.ID_Funcionalidad, f.Descripcion FROM Funcionalidades f JOIN Funcionalidades_X_Rol x on x.ID_Funcionalidad = f.ID_Funcionalidad where x.ID_Rol = " + idRol);
                    foreach (DataRow fila in resultado.Rows) {
                        gridFuncionalidades.Rows.Add(fila[0], fila[1]);
                    }
                }
            }
        }

        private void buttonFuncionalidad_Click(object sender, EventArgs e)
        {
            ComboboxItem item = comboFuncionalidad.SelectedItem as ComboboxItem;
            if (!(item is null)) {
                if (!buscarExistente(item.Value)) {
                    gridFuncionalidades.Rows.Add(item.Value, item.Text);
                }
            }
        }
        private bool buscarExistente(int id)
        {
            foreach (DataGridViewRow row in gridFuncionalidades.Rows) {
                if ((int)row.Cells[0].Value == id) {
                    return true;
                }
            }
            return false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int resultado;
            string query="";
            if (idRol == 0) {
                query="INSERT INTO Roles(Nombre,Estado) VALUES('"+ textNombre.Text + "','" + (checkEstado.Checked ? "1" : "0") + "')";
            }
            else {
                query = "UPDATE Roles SET Nombre = '"+ textNombre.Text +"' ,Estado = "+ (checkEstado.Checked ? "1" : "0") + " WHERE ID_Rol= " + idRol;
            }
            resultado = SqlConexion.ejecutarQuery(query);
            if (resultado == 1) {
                this.Hide();
                MessageBox.Show("Rol Guardado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new AbmRol.ListadoRol().Show();
            }
            else {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int resultado = SqlConexion.ejecutarQuery("DELETE from Roles where ID_Rol = " + idRol);
            if (resultado == 1) {
                this.Hide();
                new AbmRol.ListadoRol().Show();
            }
            else {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmRol.ListadoRol().Show();
        }
    }
}
