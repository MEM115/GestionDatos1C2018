using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class Login : Form
    {
        public static string Usuario;
        public static int idUsuario;
        public Login()
        {
            InitializeComponent();
        }

        private int logUsuario(string username, string password)
        {
            string encryptedpassword;
            DataTable resultado = SqlConexion.consultaQuery("select top 1 ID_Usuario,Username,LOWER(Password), Intentos_login from Usuarios where Username like '" + username +"' and Estado like 'A'");
            if (resultado.Rows.Count > 0)
            {
                encryptedpassword = resultado.Rows[0][2].ToString();
                string encryptedpassword2 = GetHashSha256(password);
                if (encryptedpassword.Equals(encryptedpassword2) && int.Parse(resultado.Rows[0][3].ToString()) < 3) {
                    Usuario= resultado.Rows[0][1].ToString();
                    idUsuario = int.Parse(resultado.Rows[0][0].ToString());
                    return 0;
                }
                else {
                    return -1;
                }
            }
            else {
                return -2;
            }
        }

        public string GetHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logUsuario(TextboxUser.Text, TextboxPassword.Text) ==0)
            {
                UpdateIntentos(TextboxUser.Text, false);
                IrAProximaPantalla();
                
            }
            else if(logUsuario(TextboxUser.Text, TextboxPassword.Text) == -1)
            {
                UpdateIntentos(TextboxUser.Text, true);
                MessageBox.Show("Login Error", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("Login Error", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateIntentos(string username, bool fallo)
        {
            string query = "update Usuarios set Intentos_login = ";
            if (fallo)
            {
                query += "Intentos_login + 1";
            }
            else
            {
                query += "0";
            }
            query+=" where Username like '" + username + "'";
            SqlConexion.ejecutarQuery(query);
        }
        private void IrAProximaPantalla()
        {
            DataTable resultado = SqlConexion.consultaQuery("SELECT r.ID_Rol, r.Nombre FROM Roles r join Roles_X_Usuario x on r.ID_Rol = x.ID_Rol WHERE x.ID_Usuario = " + idUsuario + " and r.Estado = 1");
            if (resultado.Rows.Count == 1) {
                this.Hide();
                LoginRol.Rol = resultado.Rows[0][1].ToString();
                LoginRol.idRol = int.Parse(resultado.Rows[0][0].ToString());
                new Menu().Show();
            }
            else {
                this.Hide();
                new LoginRol().Show();
            }
        }

        private void ButtonGuest_Click(object sender, EventArgs e)
        {
            DataTable resultado = SqlConexion.consultaQuery("SELECT top 1 ID_Rol, Nombre FROM Roles WHERE Nombre like 'Invitado'");
            this.Hide();
            Usuario = "Invitado";
            idUsuario = 0;
            LoginRol.Rol = resultado.Rows[0][1].ToString();
            LoginRol.idRol = int.Parse(resultado.Rows[0][0].ToString());
            new Menu().Show();
        }
    }
}
