using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.RSP;


namespace WinFormsApp.RSP
{
    public partial class FrmPasajeroTask : Form
    {
        Task cargaPasajeros;
        CancellationTokenSource cts;
        List<Pasajero> listaPasajeros;

        public FrmPasajeroTask()
        {
            InitializeComponent();

            cts = new CancellationTokenSource();
            cargaPasajeros = new Task(this.ComenzarCarga);
            listaPasajeros = new List<Pasajero>();
        }

        ///Diseñar el método ComenzarCarga que mostrará la lista de pasajeros (de la BD) mediante un Task.
        ///Dicho método realizará las siguientes tareas:
        /// * Agregar un pasajero a la lista
        /// * Actualizar el ListBox lstVisorTask con la lista de pasajeros
        /// * Repetirá este proceso cada 2 segundos hasta que se cancele la tarea o se finalice la carga.

        private void ComenzarCarga()
        {
            while (true)
            {
                if (cts.IsCancellationRequested)
                {
                    return;
                }
                else if (this.lstVisorTask.InvokeRequired)
                {
                    this.listaPasajeros = new Pasajero().ObtenerTodosBD();
                    
                    foreach (Pasajero item in listaPasajeros)
                    {
                        lstVisorTask.Items.Add(item.ToString());
                    }

                    this.lstVisorTask.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lstVisorTask.DataSource = null;
                        lstVisorTask.DataSource = listaPasajeros;
                    });
                }
                Thread.Sleep(2000);
            }
        }

        private void btnIniciarTask_Click(object sender, System.EventArgs e)
        {
            this.cargaPasajeros.Start();
            MessageBox.Show("Se inicia la tarea.");
        }

        private void btnCancelarTask_Click(object sender, System.EventArgs e)
        {
            this.cts.Cancel();
            MessageBox.Show("Se cancela la tarea.");
        }
    }
}
