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
        public Login()
        {
            InitializeComponent();
        }

        private bool logUsuario(string username, string password)
        {
            string encryptedpassword;
            SqlConnection mysqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            mysqlconnection.Open();

            SqlDataAdapter da = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand()
            };

            da.SelectCommand.Connection = mysqlconnection;
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.CommandText = "select top 1 Password from Usuarios where Username like '" + username +"' and Intentos_login < 3";
            encryptedpassword = da.SelectCommand.ExecuteScalar().ToString();

            da.Dispose();

            mysqlconnection.Close();
            string encryptedpassword2 = GetHashSha256(password);
            return encryptedpassword.Equals(encryptedpassword2);
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
            if (logUsuario(TextboxUser.Text, TextboxPassword.Text))
            {
                FrbaHotel.Clases.LoginInfo.SetUsuario(TextboxUser.Text);
                UpdateIntentos(TextboxUser.Text, false);
                MessageBox.Show("Login OK", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new FrbaHotel.Menu().Show();
            }
            else
            {
                UpdateIntentos(TextboxUser.Text, true);
                MessageBox.Show("Login Error", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateIntentos(string username, bool fallo)
        {
            SqlConnection mysqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            mysqlconnection.Open();

            SqlDataAdapter da = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand()
            };

            da.SelectCommand.Connection = mysqlconnection;
            da.SelectCommand.CommandType = CommandType.Text;
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
            da.SelectCommand.CommandText = query;
            int resultado = da.SelectCommand.ExecuteNonQuery();

            da.Dispose();

            mysqlconnection.Close();
        }
    }
}
