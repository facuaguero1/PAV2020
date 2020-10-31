using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuz.Forums;
using TuLuz.Forums.Clientes;
using TuLuz.Forums.Provincias;
using TuLuz.Clases;
using TuLuz.Negocio;
using TuLuz.Negocio.EstructuraNegocios;
using TuLuz.Forums.Reportes.CotizacionesXEstado;
using TuLuz.Forums.Reportes.PedidosXClientes;
using TuLuz.Forums.Reportes.ClientesXEstado;
using TuLuz.Forums.Reportes.Empleados_Jefes;
using TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos;
using TuLuz.Forums._Estadisticas.Prod_con_ProdEq;
using TuLuz.Forums.Estadisticas.Pedidos_Entre_Años;

namespace TuLuz
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }

        private void PersonalizarDiseño()
        {
            Panel_Barrios.Visible = false;
            Panel_Clientes.Visible = false;
            Panel_Empleados.Visible = false;
            Panel_Proveedores.Visible = false;
            Panel_Productos.Visible = false;
            Panel_Localidades.Visible = false;
            Panel_Provincias.Visible = false;
            Panel_Tipo_Doc.Visible = false;
            Panel_Procesos.Visible = false;
            Panel_Listados.Visible = false;
            Panel_Estadisticas.Visible = false;
            panelUsuario.Visible = false;
        }

        private void OcultarMenu()
        {
            if (Panel_Barrios.Visible == true)
                Panel_Barrios.Visible = false;
            if (Panel_Clientes.Visible == true)
                Panel_Clientes.Visible = false;
            if (Panel_Empleados.Visible == true)
                Panel_Empleados.Visible = false;
            if (Panel_Proveedores.Visible == true)
                Panel_Proveedores.Visible = false;
            if (Panel_Productos.Visible == true)
                Panel_Productos.Visible = false;
            if (Panel_Localidades.Visible == true)
                Panel_Localidades.Visible = false;
            if (Panel_Provincias.Visible == true)
                Panel_Provincias.Visible = false;
            if (Panel_Tipo_Doc.Visible == true)
                Panel_Tipo_Doc.Visible = false;
            if (Panel_Procesos.Visible == true)
                Panel_Procesos.Visible = false;
            if (Panel_Listados.Visible == true)
                Panel_Listados.Visible = false;
            if (Panel_Estadisticas.Visible == true)
                Panel_Estadisticas.Visible = false;
            if (panelUsuario.Visible == true)
                panelUsuario.Visible = false;
        }

        private void MostrarMenu(Panel Paneles)     //MOSTRAR LOS SUB MENUS CONTENEDORES
        {
            if (Paneles.Visible == false)         //SI UN PANEL ESTA OCULTO, LO MOSTRAMOS. PERO ANTES INVOCAMOS AL METODO OCULTAR_MENU, PARA CERRAR ALGUN OTRO PANEL ABIERTO
            {
                OcultarMenu();
                Paneles.Visible = true;
            }
            else
            {
                Paneles.Visible = false;        //SI EL PANEL ESTA ABIERTO, LO CERRAMOS.
            }
        }


        //    - -   -   -   -   -   -   LOGIN   -   -   -   -   -   -   -   -   -   -   -   

        private void Principal_Load(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            if (log.logOK == 0)
            {
                this.Close();
            }
            nomEmpleadoLog.Text = log.Usuario;
        }
        #region Botones_Principales_Paneles
        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Clientes);
        }

       

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Empleados);
        }

        private void btn_Proveedor_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Proveedores);
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Productos);
        }

        private void btn_Localidades_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Localidades);
        }

        private void btn_Provincia_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Provincias);
        }

        private void btn_Barrio_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Barrios);
        }

        private void btn_Tipo_Doc_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Tipo_Doc);
        }

        private void btn_Procesos_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Procesos);
        }

        private void btn_Listados_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Listados);
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            MostrarMenu(Panel_Estadisticas);
        }
        #endregion

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form FormularioActivo = null;
        public void AbrirFormularioSubMenu(Form FormularioSubMenu)
        {
            if (FormularioActivo != null)
                FormularioActivo.Close();       //si existe un formulario abierto, lo cerramos 

            FormularioActivo = FormularioSubMenu;
            FormularioSubMenu.TopLevel = false;
            FormularioSubMenu.FormBorderStyle = FormBorderStyle.None;   //sin bordes
            FormularioSubMenu.Dock = DockStyle.Fill;    //para rellenar formulario en el centro
            Panel_Centro.Controls.Add(FormularioSubMenu); //agregar formulario al panel central 
            Panel_Centro.Tag = FormularioSubMenu; //asociamos el formulario con el panel
            FormularioSubMenu.BringToFront(); //traer el formulario por delante de la imagen de fondo
            FormularioSubMenu.Show(); //ejecutar formulario
        }
        //  -   -   -   -   -   -   -   -   -   -   CLICK A LOS BOTONES DE LOS SUB MENUS    -   -   -   -   -   -   -   -   -   
        private void btn_RegistrarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaCliente());
        }

        private void btn_ModificarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarCliente());
        }
        private void btn_ConsultarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarCliente());
        }

        private void btn_EliminarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarCliente());
        }
        private void nomEmpleadoLog_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelUsuario);
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {

            Login log = new Login();
            log.ShowDialog();
            if (log.logOK == 0)
            {
                this.Close();
            }

            nomEmpleadoLog.Text = log.Usuario;
            panelUsuario.Visible = false;

        }

        private void btn_RegistrarBarrios_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaBarrio());
        }

        private void btn_EliminarBarrios_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarBarrio());
        }

        private void btn_ConsultarBarrios_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarBarrio());
        }

        private void btn_ModificarBarrios_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarBarrio());
        }

        private void perfil_Click(object sender, EventArgs e)
        {
            
            AbrirFormularioSubMenu(new VerPerfil(nomEmpleadoLog.Text));

        }

        private void Panel_Centro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_RegistrarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaEmpleados());
        }

        private void btn_ModificarEmpleados_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarEmpleados());
        }
        private void btn_ConsultarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarEmpleados());
        }
        private void btn_EliminarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarEmpleados());
        }
        private void btn_RegistrarProvincias_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaProvincia());
        }

        private void btn_ConsultarProvincias_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarProvincia());
        }

        private void btn_ModificarProvincias_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarProvincia());
        }

        private void btn_EliminarProvincias_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarProvincia());
        }

        private void btn_RegistrarLocalidades_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaLocalidad());
        }

        private void btn_EliminarLocalidades_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarLocalidad());
        }

        private void btn_ConsultarLocalidades_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarLocalidad());
        }

        private void btn_ModificarLocalidades_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarLocalidad());
        }

        private void btn_RegistrarProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaProveedor());
        }

        private void btn_ConsultarProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarProveedor());
        }

        private void btn_RegistrarTipoDoc_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaTipoDoc());
        }

        private void btn_EliminarTipoDoc_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarTipoDoc());
        }

        private void btn_ConsultarTipoDoc_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarTipoDocs());
        }

        private void btn_ModificarTipoDoc_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarTipoDoc());
        }

        private void btn_RegistrarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaProducto());
        }

        private void btn_EliminarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarProductos());
        }

        private void btn_ConsultarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarProductos());
        }

        private void btn_ModificarPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarPedidos());
        }

        private void btn_ModificarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarProductos());
        }

        private void btn_RegistrarPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaPedido());
        }

        private void btn_EliminarPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarPedido());
        }

        private void btn_ConsultarPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ConsultarPedidos());
        }
        private void btn_EliminarProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new BorrarProveedor());
        }

        private void btn_ModificarProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ModificarProveedor());
        }

        private void btn_CargarCotizacion_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new Cotizaciones());
            
        }

        private void btn_CargaPedido_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new Pedidos());
                
        }

        private void btn_ActualizacionStock_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ActualizarStock());
        }

        private void button39_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new PedidosXEmpleados());
        }

        private void Btn_Pedido_2fechas_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new Pedido_X_2Fechas());
        }

        private void btn_Productos_Equivalentes_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ProductoEquivalente());
        }

        private void btn_CotzEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new CotizacionesXEmpleados());
        }

        private void btn_CotzXEst_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new CotizacionesXEstado());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ProductoXPedidos());
        }

        private void button45_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ProductoXrangoPrecio());
        }

        private void button44_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new PedidosXCliente());
        }

        private void button43_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new ClientesXEstado1());
        }

        private void button48_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new cotizacionXprecio());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new Empleados_Jefes());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new Proveedores_Activos_Inactivos());
        }

        private void button42_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new Estadistica_Clientes_Ac_NoAc());
        }

        private void button41_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new Pedidos_Entre_Años());
        }

        private void button40_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new CotizacionXEstado());
        }

        private void button51_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new CotizacionesXFechaXEstado());
        }
    }
}
