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
            LabelUserLogueado.Text = Clases.LoginInfo.GetUsuario();
            List<Clases.Funcionalidad> funcionalidades = Clases.LoginInfo.GetFuncionalidad();
            foreach (Clases.Funcionalidad func in funcionalidades)
            {
                foreach(Control con in this.Controls)
                {
                    if (func.Descripcion == con.Text)
                    {
                        con.Show();
                    }
                }
            }
        }
    }
}
