using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Final;
using System.ComponentModel;



namespace WinFormsApp
{
    ///Agregar manejo de excepciones en TODOS los lugares críticos!!!

    public delegate void DelegadoThreadConParam(object param);

    public partial class FrmPrincipal : Form
    {
        protected Task hilo;
        protected CancellationTokenSource cts;
        List<Usuario> lista;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Gonzalez,Martin";
            MessageBox.Show(this.Text); 
            this.cts = new CancellationTokenSource();
        }

        ///
        /// CRUD
        ///
        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListado frm = new FrmListado();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show(this);
        }

        ///
        /// VER LOG
        ///
        private void verLogToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //DialogResult rta = DialogResult.Cancel;///Reemplazar por la llamada al método correspondiente del OpenFileDialog

            string rutaFile = string.Empty;
            string textoDelArchivo;

            OpenFileDialog open = new OpenFileDialog
            {

                Title = "Abrir archivo de usuarios",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "log files (*.log)|*.log",
                DefaultExt = "log",
                FileName = "usuarios"


            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                /// Mostrar en txtUsuariosLog.Text el contenido del archivo .log
                rutaFile = open.FileName;

                textoDelArchivo = File.ReadAllText(rutaFile);

                 this.txtUsuariosLog.Clear();

                this.txtUsuariosLog.Text = textoDelArchivo;

            }
            else
            {
                MessageBox.Show("No se muestra .log");
            }
        }

        ///
        /// DESERIALIZAR JSON
        ///
        private void deserializarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Entidades.Final.Usuario> listado = null;
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            const string nombreArchivoJson = "usuarios_repetidos.json";

            string path = Path.Combine(rutaEscritorio, nombreArchivoJson); /// Reemplazar por el path correspondiente

            bool todoOK = Manejadora.DeserializarJSON(path, out listado); /// Reemplazar por la llamada al método correspondiente de Manejadora

            if (todoOK)
            {
                this.txtUsuariosLog.Clear();

                /// Mostrar en txtUsuariosLog.Text el contenido de la deserialización.

                foreach (Usuario item in listado)
                {
                    txtUsuariosLog.Text += item.ToString();
                }
            }
            else
            {
                MessageBox.Show("NO se pudo deserializar a JSON");
            }

        }

        ///
        /// TASK
        ///
        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cts = new CancellationTokenSource();
            ///Se inicia el hilo.

            this.hilo = new Task(ActualizarListadoUsuarios);
            this.hilo.Start();
            //this.hilo = Task.Run(ActualizarListadoUsuarios); /// inicializar tarea

            ///Se desasocia al manejador de eventos.
            this.taskToolStripMenuItem.Click -= new EventHandler(this.taskToolStripMenuItem_Click);
        }


        ///PARA ACTUALIZAR LISTADO DESDE BD EN HILO
        public void ActualizarListadoUsuarios()
        {
            /// Implementar...
            /// 
            this.lista = ADO.ObtenerTodos();
            foreach (Usuario item in lista)
            {
                this.Invoke((MethodInvoker)(() => lstUsuarios.Items.Add(item.ToString())));

            }


            do
            {
                 this.lista = ADO.ObtenerTodos();
                foreach (Usuario item in lista)
                {
                    this.Invoke((MethodInvoker)(() => lstUsuarios.Items.Add(item.ToString())));

                }
               
                this.lstUsuarios.BackColor = System.Drawing.Color.Black;
                this.lstUsuarios.ForeColor = System.Drawing.Color.White;
                Thread.Sleep(1500);
                 this.lstUsuarios.DataSource = null;
                this.Invoke((MethodInvoker)(() =>  this.lstUsuarios.Items.Clear()));
               
                foreach (Usuario item in lista)
                {
                    this.Invoke((MethodInvoker)(() => lstUsuarios.Items.Add(item.ToString())));

                }
                this.lstUsuarios.ForeColor = System.Drawing.Color.Black;
                this.lstUsuarios.BackColor = System.Drawing.Color.White;

                Thread.Sleep(1500);

                this.Invoke((MethodInvoker)(() =>  this.lstUsuarios.Items.Clear()));

            } while (true);
            
               
            


        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            ///CANCELAR HILO
            this.cts.Cancel();
        }
    }
}
