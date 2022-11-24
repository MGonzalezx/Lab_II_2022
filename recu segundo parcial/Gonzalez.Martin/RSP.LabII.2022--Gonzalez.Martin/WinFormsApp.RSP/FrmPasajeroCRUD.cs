using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades.RSP;


namespace WinFormsApp.RSP
{
    ///Agregar en el proyecto de tipo Class Library, la clase estática Extensora, la cual tendrá:
    ///atributo privado: conexion : string
    ///constructor que inicializará al atributo con la cadena de conexión adecuada para conectarse
    ///con la base de datos 'pasajeros_db' (provista en el parcial)
    ///Método público: ObtenerTodosBD() : List<Pasajero>
    ///este método debe ser un método de extensión para la clase Pasajero.
    ///
    public partial class FrmPasajeroCRUD : Form
    {
        private List<Pasajero> lista;

        public FrmPasajeroCRUD()
        {
            InitializeComponent();
        }

        private void FrmPasajeroCRUD_Load(object sender, EventArgs e)
        {
            this.CargarListadoBD();
        }

        private void CargarListadoBD()
        {
            lstVisorCRUD.Items.Clear();

            ///obtener los pasajeros de la base de datos
            this.lista = new Pasajero().ObtenerTodosBD();

            if (lista != null)
            {
                foreach (Pasajero item in lista)
                {
                    lstVisorCRUD.Items.Add(item.ToString());
                }
            }
            else
            {
                lstVisorCRUD.Items.Add("ERROR EN BD.");
            }
        }

        private void lstVisorCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = this.lstVisorCRUD.SelectedIndex;
            if(i != -1)
            {
                Pasajero p = this.lista[i];

                this.txtDni.Text = p.dni.ToString();
                this.txtNombre.Text = p.nombre;
                this.txtEquipaje.Text = p.equipaje.ToString();
            }          
        }

        ///Agregar, a la clase Extensora, los siguientes métodos:
        ///AgregarBD() : Boolean
        ///Agregará a la base de datos la instancia actual.
        ///Actualizar listado.
        ///
        ///ModificarBD() : Boolean
        ///Modificará en la base de datos los valores de la instancia actual.
        ///No modificar el valor del DNI.
        ///Actualizar listado.
        ///
        ///EliminarBD() : Boolean
        ///Eliminará de la base de datos la instancia actual.
        ///Actualizar listado.
        ///
        ///Los métodos anteriores serán métodos de extensión de la clase Pasajero.
        ///Si alguna acción no se pudo realizar, informarla con un MessageBox.
        ///

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pasajero p = new Pasajero();
            p.dni = int.Parse(this.txtDni.Text);
            p.nombre = txtNombre.Text;
            p.equipaje = int.Parse(this.txtEquipaje.Text);

            if (p.AgregarBD())
            {
                this.CargarListadoBD();
            }
            else
            {
                MessageBox.Show("No se pudo AGREGAR");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pasajero p = new Pasajero();
            p.dni = int.Parse(this.txtDni.Text);
            p.nombre = txtNombre.Text;
            p.equipaje = int.Parse(this.txtEquipaje.Text);

            if (p.ModificarBD())
            {
                this.CargarListadoBD();
            }
            else
            {
                MessageBox.Show("No se pudo MODIFICAR");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pasajero p = new Pasajero();
            p.dni = int.Parse(this.txtDni.Text);

            if (p.EliminarBD())
            {
                this.CargarListadoBD();
            }
            else
            {
                MessageBox.Show("No se pudo ELIMINAR");
            }
        }
    }
}
