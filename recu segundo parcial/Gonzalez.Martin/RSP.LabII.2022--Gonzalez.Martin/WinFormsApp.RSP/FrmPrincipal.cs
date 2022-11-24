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
    ///Transporte<T> (genérica)
    ///atributos protegidos: capacidad : Int32 e items : List<T>
    ///propiedad pública (sólo lectura): Items : List<T>
    ///Constructor privado con un parámetro de tipo int.
    ///Polimorfismo
    ///ToString: Mostrará cómo título 'CAPACIDAD: x - ELEMENTOS: y' siendo "x" la capacidad máxima 
    ///del transporte e "y" la cantidad de elementos actuales que posee el transporte.
    ///Además se mostrarán todos los detalles de cada elemento que posea el transporte.
    ///Equals: Si se compara con un objeto de tipo T y ese objeto se encuentra en el listado de elementos,
    ///retornará verdadero. Caso contrario, retornará false. 
    ///Sobrecargas
    ///implicit(Int32) : Transporte
    ///== (Transporte, T) : bool
    ///si T está en el listado, retornará true. Caso contrario, false.
    ///+ (Transporte, T) : Transporte
    ///si T no está en el listado y todavía hay capacidad, se agregará al listado.
    ///
    ///Pasajero
    ///atributos públicos: dni : Int32, nombre : String y equipaje : Int32
    ///Polimorfismo
    ///ToString: Mostrará 'DNI: x - NOMBRE: y - EQUIPAJE: z' siendo "x" el número de dni del pasajero, 
    ///"y" el nombre y "z" la cantidad de equipajes.
    ///Equals: Si se compara con un objeto de tipo Pasajero y los números de dni coinciden,
    ///retornará verdadero. Caso contrario, retornará false.
    ///
    ///Carga
    ///atributos públicos: codigo : Int32, tipo : String y peso : Double
    ///Polimorfismo
    ///ToString: Mostrará 'CÓDIGO: x - TIPO: y - PESO: z' siendo "x" el número del código de la carga, 
    ///"y" el tipo y "z" el peso.
    ///Equals: Si se compara con un objeto de tipo Carga y los números de código coinciden,
    ///retornará verdadero. Caso contrario, retornará false.
    ///
    public partial class FrmPrincipal : Form
    {
        private Transporte<Pasajero> tp;
        private Transporte<Carga> tc;


        public FrmPrincipal()
        {
            InitializeComponent();

            this.Text = "Gonzalez Martin";

            MessageBox.Show(this.Text);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnTransportePasajeros_Click(object sender, EventArgs e)
        {
            this.tp = 4;

            Pasajero p1 = new Pasajero();
            Pasajero p2 = new Pasajero();
            Pasajero p3 = new Pasajero();

            p1.dni = 11222333;
            p1.nombre = "Juan";
            p1.equipaje = 2;

            p2.dni = 22333444;
            p2.nombre = "Juan";
            p2.equipaje = 1;

            p3.dni = 33444555;
            p3.nombre = "Susana";
            p3.equipaje = 0;           

            this.tp += p1;
            this.tp += p2;
            this.tp += p3;

            this.txtPasajeros.Text = this.tp.ToString();
        }

        private void btnTransporteCarga_Click(object sender, EventArgs e)
        {
            this.tc = 3;

            Carga c1 = new Carga();
            Carga c2 = new Carga();

            c1.codigo = 1;
            c1.tipo = "contenedor";
            c1.peso = 2500;

            c2.codigo = 2;
            c2.tipo = "contenedor";
            c2.peso = 2500;

            this.tc += c1;
            this.tc += c2;           

            this.txtCargas.Text = this.tc.ToString();
        }

        ///Agregar en la clase Transporte<T> dos eventos (diseñarlos según las convenciones vistas):
        ///CapacidadCompleta, se disparará cuando se intente agregar un elemento que supere la capacidad del transporte.
        ///
        ///ElementoRepetido, se disparará cuando un elemento sea igual a otro que ya está en el transporte.
        ///
        private void btnEventosPasajeros_Click(object sender, EventArgs e)
        {
            ///ASOCIAR MANEJADORES DE EVENTOS AQUÍ
            ///

            tp.CapacidadCompleta += Transporte_CapacidadCompleta;
            tp.ElementoRepetido += Transporte_ElementoRepetido;

            Pasajero p = new Pasajero();
            Pasajero p1 = new Pasajero();
            Pasajero p2 = new Pasajero();

            p.dni = 11222333;
            p.nombre = "Rosa";
            p.equipaje = 1;

            p1.dni = 44555666;
            p1.nombre = "Enzo";
            p1.equipaje = 3;

            p2.dni = 55666777;
            p2.nombre = "Esteban";
            p2.equipaje = 1;

            ///No debería agregarse por repetido
            this.tp += p;
            this.txtPasajeros.Text = this.tp.ToString();

            ///Se debe agregar
            this.tp += p1;
            this.txtPasajeros.Text = this.tp.ToString();

            ///No debería agregarse por exceso
            this.tp += p2;
            this.txtPasajeros.Text = this.tp.ToString();
        }

        

        private void btnEventosCargas_Click(object sender, EventArgs e)
        {
            ///ASOCIAR MANEJADOR DE EVENTOS AQUÍ
            ///
            tc.CapacidadCompleta += Transporte_CapacidadCompleta;
            tc.ElementoRepetido += Transporte_ElementoRepetido;

            Carga c = new Carga();
            Carga c1 = new Carga();
            Carga c2 = new Carga();

            c.codigo = 1;
            c.tipo = "caja";
            c.peso = 50;

            c1.codigo = 3;
            c1.tipo = "caja";
            c1.peso = 25;

            c2.codigo = 4;
            c2.tipo = "pallet";
            c2.peso = 300;

            ///No debería agregarse por repetido
            this.tc += c;
            this.txtCargas.Text = this.tc.ToString();

            ///Se debe agregar
            this.tc += c1;
            this.txtCargas.Text = this.tc.ToString();

            ///No debería agregarse por exceso
            this.tc += c2;
            this.txtCargas.Text = this.tc.ToString();
        }

        /// <summary>
        /// Manejador de eventos para ElementoRepetido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transporte_ElementoRepetido(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString(), "REPETIDO");
        }

        /// <summary>
        /// Manejador de eventos para CapacidadCompleta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transporte_CapacidadCompleta(object sender, EventArgs e)
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
        ///Implementar ISerializador<T> en Pasajero y Carga (adecuar las clases según sea necesario).
        ///En la clase Pasajero implementar los métodos de forma explícita.
        ///La serialización/deserialización será a JSON.
        ///En la clase Carga implementar los métodos de forma implícita.
        ///La serialización/deserialización será a XML.
        ///
        ///Para la serialización:
        ///El archivo .json guardarlo en la carpeta 'Mis documentos' del cliente, con el nombre 
        ///formado con: apellido.nombre.pasajeros.json
        ///Ejemplo: Alumno: Juan Pérez -> perez.juan.pasajeros.json
        ///El archivo .xml guardarlo en el escritorio del cliente, con el nombre formado 
        ///con: apellido.nombre.cargas.xml
        ///Ejemplo: Alumno: Juan Pérez -> perez.juan.cargas.xml
        ///Para la deserialización:
        ///tomar el archivo Pasajeros.json y Cargas.xml del escritorio del cliente (provistos en el parcial).
        ///
        private void btnPasajeroSerializar_Click(object sender, EventArgs e)
        {
            Pasajero p = new Pasajero();
            p.dni = 11888999;
            p.nombre = "Pity Martinez";
            p.equipaje = 3;
            const string nombreArchivoJson = "Gonzalez.Martin.pasajeros.json";
            string rutaMisDocumentos =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = Path.Combine(rutaMisDocumentos, nombreArchivoJson);
            
            ///obtener el path desde 'Mis documentos' del cliente.
            ///
           
            
            
            ///serializar el pasajero
            bool serializadoJSON = p.Escribir(path,p);

            if (serializadoJSON)
            {
                this.lblMensaje.Text = "Pasajero serializado a JSON!!!";
            }
            else
            {
                this.lblMensaje.Text = "Pasajero NO se serizalizó a JSON!!!";
            }
        }

        private void btnPasajeroDeserializar_Click(object sender, EventArgs e)
        {
            List<Pasajero> lista;
            ///obtener el path desde el escritorio del cliente.
            

            string rutaEscritorio =  Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
             const string nombreArchivoJson = "Pasajeros.json";

            string path = Path.Combine(rutaEscritorio, nombreArchivoJson);
            
            ///deserializar el archivo .json
            lista = ((ISerializador<Pasajero>)this).Leer(path, MostrarMensajeDeserializacion);

            lstVisor.Items.Clear();

            foreach (Pasajero item in lista)
            {
                lstVisor.Items.Add(item.ToString());
            }
        }


        private void btnCargaSerializar_Click(object sender, EventArgs e)
        {
            Carga c = new Carga();
            c.codigo = 666;
            c.tipo = "pallet";
            c.peso = 404;

            ///obtener el path desde el escritorio del cliente.
            const string nombreArchivoXml = "Gonzalez.Martin.carga.xml";
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(rutaEscritorio, nombreArchivoXml);

            ///serializar la carga
           // bool serializadoXML = false;
             bool serializadoXML =((ISerializador<Carga>)this).Escribir(path,c);

            if (serializadoXML)
            {
                this.lblMensaje.Text = "Carga Serializada a XML!!!";
            }
            else
            {
                this.lblMensaje.Text = "Carga NO se serizalizó a XML!!!";
            }
        }

        private void btnCargaDeserializar_Click(object sender, EventArgs e)
        {
            List<Carga> lista;
            ///obtener el path desde el escritorio del cliente.
           

            const string nombreArchivoXml = "Cargas.xml";
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(rutaEscritorio, nombreArchivoXml);


            ///deserializar el archivo .xml
            lista = ((ISerializador<Carga>)this).Leer(path, MostrarMensajeDeserializacion);

            lstVisor.Items.Clear();

            foreach (Carga item in lista)
            {
                lstVisor.Items.Add(item.ToString());
            }
        }

        /// <summary>
        /// Manejador de eventos 'Action', para los mensajes de 
        /// serialización/deserialización
        /// </summary>
        /// <param name="mensaje"></param>
        private void MostrarMensajeDeserializacion(string mensaje)
        {
            this.lblMensaje.Text = mensaje;
        }

        ///*****************************************************************************************************
        ///*****************************************************************************************************
        ///*****************************************************************************************************
        ///*****************************************************************************************************
        ///PARTE 2
        ///*****************************************************************************************************
        ///*****************************************************************************************************
        ///*****************************************************************************************************
        ///*****************************************************************************************************
        
        private void btnPasajerosCRUD_Click(object sender, EventArgs e)
        {
            FrmPasajeroCRUD frm = new FrmPasajeroCRUD();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void btnPasajerosTask_Click(object sender, EventArgs e)
        {
            FrmPasajeroTask frm = new FrmPasajeroTask();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }
    }
}
