using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades.RSP;
using System.IO;


namespace WinFormsApp.RSP
{
    ///*****************************************************************************************************
    ///*****************************************************************************************************
    ///*****************************************************************************************************
    ///*****************************************************************************************************
    ///PARTE 1
    ///*****************************************************************************************************
    ///*****************************************************************************************************
    ///*****************************************************************************************************
    ///*****************************************************************************************************

    ///Crear en un proyecto de tipo ClassLibrary (Entidades.RSP), las siguientes clases:
    ///Tacho<T> (genérica)
    ///atributos protegidos: capacidad : Int32 e items : List<T>
    ///propiedad pública (sólo lectura): Items : List<T>
    ///Constructor privado con un parámetro de tipo int.
    ///Polimorfismo
    ///ToString: Mostrará cómo título 'CAPACIDAD: x - ELEMENTOS: y' siendo "x" la capacidad máxima 
    ///del tacho e "y" la cantidad de elementos actuales que posee el tacho.
    ///Además se mostrarán todos los detalles de cada elemento que posea el tacho.
    ///Equals: Si se compara con un objeto de tipo T y ese objeto se encuentra en el listado de elementos,
    ///retornará verdadero. Caso contrario, retornará false. 
    ///Sobrecargas
    ///implicit(Int32) : Tacho
    ///== (Tacho, T) : bool
    ///si T está en el listado, retornará true. Caso contrario, false.
    ///+ (Tacho, T) : Lata
    ///si T no está en el listado y todavía hay capacidad, se agregará al listado.
    ///
    ///Pintura
    ///atributos públicos: color : ConsoleColor, marca : String y codigo : Int32
    ///Polimorfismo
    ///ToString: Mostrará 'COLOR: x - MARCA: y - CÓDIGO: z' siendo "x" el color de la pintura, 
    ///"y" la marca y "z" el código.
    ///Equals: Si se compara con un objeto de tipo Pintura y las marcas y colores coinciden,
    ///retornará verdadero. Caso contrario, retornará false.
    ///
    public partial class FrmPrincipal : Form
    {
        private Tacho<Pintura> tacho_pintura;


        public FrmPrincipal()
        {
            InitializeComponent();

            this.Text = "Gonzalez Martin";

            MessageBox.Show(this.Text);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLataPinturas_Click(object sender, EventArgs e)
        {
            this.tacho_pintura = 4;

            Pintura p1 = new Pintura();
            Pintura p2 = new Pintura();
            Pintura p3 = new Pintura();

            p1.color = "Gray";
            p1.marca = "Alba";
            p1.codigo = 500;

            p2.color = "Magenta";
            p2.marca = "Sinteplast";
            p2.codigo = 800;

            p3.color = "Magenta";
            p3.marca = "Alba";
            p3.codigo = 800;           

            this.tacho_pintura += p1;
            this.tacho_pintura += p2;
            this.tacho_pintura += p3;

            this.txtPinturas.Text = this.tacho_pintura.ToString();
        }


        ///Agregar en la clase Tacho<T> dos eventos (diseñarlos según las convenciones vistas):
        ///CapacidadCompleta, se disparará cuando se intente agregar un elemento que supere la capacidad del tacho.
        ///
        ///ElementoRepetido, se disparará cuando un elemento sea igual a otro que ya está en el tacho.
        ///
        ///Los eventos se deben 'disparar' una sola vez (NO acumular manejadores de eventos innecesarios)

        private void btnEventosPinturas_Click(object sender, EventArgs e)
        {
            ///ASOCIAR MANEJADORES DE EVENTOS AQUÍ
            ///

            tacho_pintura.CapacidadCompleta += Tacho_CapacidadCompleta;
            tacho_pintura.ElementoRepetido += Tacho_ElementoRepetido;

            Pintura p = new Pintura();
            Pintura p1 = new Pintura();
            Pintura p2 = new Pintura();

            p.color = "Gray";
            p.marca = "Alba";
            p.codigo = 1;

            p1.color = "White";
            p1.marca = "Alba";
            p1.codigo = 500;

            p2.color = "Green";
            p2.marca = "Sinteplast";
            p2.codigo = 600;

            ///No debería agregarse por repetido
            this.tacho_pintura += p;
            this.txtPinturas.Text = this.tacho_pintura.ToString();

            ///Se debe agregar
            this.tacho_pintura += p1;
            this.txtPinturas.Text = this.tacho_pintura.ToString();

            ///No debería agregarse por exceso
            this.tacho_pintura += p2;
            this.txtPinturas.Text = this.tacho_pintura.ToString();


        }

        
        /// <summary>
        /// Manejador de eventos para ElementoRepetido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tacho_ElementoRepetido(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString(), "REPETIDO");
        }

        /// <summary>
        /// Manejador de eventos para CapacidadCompleta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tacho_CapacidadCompleta(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString(), "COMPLETO");
        }

        ///Crear la interface genérica ISerializador<T> (en el proyecto Class Library), con los métodos: 
        ///Escribir(string, T) : bool
        ///-->El primer parámetro indica el path dónde se encuentra el archivo.
        ///-->El segundo parámetro es el objeto T a ser serializado.
        ///-->Retorna true si se pudo serializar, false, caso contrario.
        ///Leer(string, Action<String>) : List<T>
        ///-->El primer parámetro indica el path dónde se encuentra el archivo.
        ///-->El segundo parámetro es un Action que contendrá el mensaje de éxito o de fracazo, según se pueda
        ///o no deserializar. Los mensajes se deben mostrar en lblMensaje.
        ///-->Retorna una lista genérica con los objetos deserializados. Mostrarlos en lstVisor.
        ///
        ///Implementar ISerializador<T> en Pintura (adecuar la clase según sea necesario).
        ///Implementar los métodos de forma explícita.
        ///La serialización/deserialización será a JSON.
        ///
        ///Para la serialización:
        ///El archivo .json guardarlo en el escritorio del cliente, con el nombre 
        ///formado con: apellido.nombre.pintura.json
        ///Ejemplo: Alumno: Juan Pérez -> perez.juan.pintura.json
        ///Para la deserialización:
        ///Tomar el archivo Pinturas.json del escritorio del cliente (provistos en el parcial).
        ///
        private void btnPinturaSerializar_Click(object sender, EventArgs e)
        {
            Pintura p = new Pintura();
            p.color = "Red";
            p.marca = "PuroColor";
            p.codigo = 888;

            ///obtener el path desde el escritorio del cliente.
            const string nombreArchivoJson = "gonzalez.martin.pintura.json";
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(rutaEscritorio, nombreArchivoJson);

            ///serializar la pintura
            bool serializadoJSON = ((ISerializador<Pintura>)p).Escribir(path, p);

            if (serializadoJSON)
            {
                this.lblMensaje.Text = "Pintura serializado a JSON!!!";
            }
            else
            {
                this.lblMensaje.Text = "Pintura NO se serizalizó a JSON!!!";
            }
        }

        ///Configurar el OpenFileDialog, para poder mostrar el archivo serializado a JSON
        ///
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ///titulo -> 'Abrir JSON'
            ///directorio por defecto -> Escritorio
            ///tipo de archivo (filtro) -> .json
            ///extensión por defecto -> .json
            ///nombre de archivo (defecto) -> apellido.nombre.pintura.json, siendo apellido, su apellido y
            ///nombre, su nombre. Ejemplo: Alumno: Juan Pérez -> perez.juan.pintura.json
            ///

            string rutaFile = string.Empty;
             List<Pintura> lista;
           

            OpenFileDialog open = new OpenFileDialog
            {
               
                Title = "Abrir JSON",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "json files (*.json)|*.json",
                DefaultExt = "json",
                FileName = "gonzalez.martin.pintura.json"
                
               
            };



           // open.ShowDialog() = DialogResult.Cancel;///Reemplazar por la llamada al método correspondiente del OpenFileDialog

            if (open.ShowDialog() == DialogResult.OK)
            {
                ///leer el archivo seleccionado por el cliente y mostrarlo en lstVisor
                rutaFile = open.FileName;

                lista = ((ISerializador<Pintura>)new Pintura()).Leer(rutaFile, this.MostrarMensajeDeserializacion);

                lstVisor.Items.Clear();

                foreach (Pintura item in lista)
                {
                    lstVisor.Items.Add(item.ToString());
                }


            }
            else
            {
                MessageBox.Show("Accion Cancelada por el usuario");
            }

            

        }

        private void btnPinturaDeserializar_Click(object sender, EventArgs e)
        {
            List<Pintura> lista;
            ///obtener el path desde el escritorio del cliente.
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            const string nombreArchivoJson = "Pinturas.json";

            string path = Path.Combine(rutaEscritorio, nombreArchivoJson);

            ///deserializar el archivo .json
            ///
            try
            {
                lista = ((ISerializador<Pintura>)new Pintura()).Leer(path, this.MostrarMensajeDeserializacion);
                lstVisor.Items.Clear();

                foreach (Pintura item in lista)
                {
                    lstVisor.Items.Add(item.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            
        }

        /// <summary>
        /// Manejador de eventos 'Action', para los mensajes de 
        /// deserialización
        /// </summary>
        /// <param name="mensaje"></param>
        private void MostrarMensajeDeserializacion(string mensaje)
        {
            this.lblMensaje.Text = mensaje;
        }

    }
}
