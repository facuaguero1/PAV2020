using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuz.Negocio;

namespace TuLuz.Forums
{
    public partial class Login : Form
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int logOK = 0;

        public Login()
        {
            InitializeComponent();
           
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Usr.Text == "" || txtPsw.Text == "")
            {
                MessageBox.Show("No se ha insertado Usuario o Contraseña", "Atencion: ", MessageBoxButtons.OK);
                return;
            }

            Ng_Users usr = new Ng_Users();
            if (usr.validarUsuario(txt_Usr.Text, txtPsw.Text) == Ng_Users.Respuesta.validacion_Correcta)
            {
              
                Usuario = txt_Usr.Text;
                this.Close();
                logOK = 1;
                
               
                
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta", "Atencion: ", MessageBoxButtons.OK);
                return;

            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Usr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
