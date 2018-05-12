using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Clases
{
    public static class LoginInfo
    {
        private static string Username;
        private static List<Funcionalidad> Funcionalidades;

        public static void SetUsuario(string user)
        {
            Username = user;
        }
        public static string GetUsuario()
        {
            return Username;
        }
        public static List<Funcionalidad> GetFuncionalidad()
        {
            return Funcionalidades;
        }
    }
}
