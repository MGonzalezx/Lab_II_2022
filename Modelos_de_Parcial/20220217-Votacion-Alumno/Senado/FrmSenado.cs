using System;
using System.Drawing;
using System.Windows.Forms;
using CoreLibraries;
namespace Senado
{
    public partial class FrmSenado : Form
    {
        private Parlamento<Senador> parlamento;

        public FrmSenado()
        {
            InitializeComponent();

            this.parlamento = new Parlamento<Senador> (this.CrearSenador("P", 160, 382));

            parlamento.FinVotacion += FinalizaVotacion;
            parlamento.OcupaBanca += CambioPresentismo;
            parlamento.ParlamentariosRegistrados += FinCambioPresentismo;
            parlamento.VotoEmitido += RegistrarVoto;
            parlamento.ExceptionOcurrida += MostrarMensajeErorr;
        }

        private void FrmSenado_Load(object sender, EventArgs e)
        {
            int top = 125;
            int left;
            int cont = 1;

            for (int i = 1; i <= 4; i++)
            {
                left = 172 - (35 * i);
                for (int j = 1; j < 14 + (i * 2); j++)
                {
                    this.AgregarSenador(cont.ToString(), top, left);

                    left += 35;
                    cont++;
                }
                top -= 35;
            }
        }

        private Senador CrearSenador(string cod, int top, int left)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Location = new Point(left, top);
            label.Name = "label" + cod;
            label.Size = new Size(30, 30);
            label.ForeColor = Color.White;
            label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.TabIndex = 0;
            label.Text = cod;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BackColor = Color.DarkBlue;

            this.Controls.Add(label);

            return new Senador(cod, label);
        }

        private void AgregarSenador(string cod, int top, int left)
        {
            Senador senador = this.CrearSenador(cod, top, left);
            this.parlamento.Bancas.Add(senador);
        }

        public void CambioPresentismo(Senador banca)
        {
            Label label = (Label)banca.ControlVisual;
            
                label.BackColor = banca.ColorDeBanca;
        }

        public void FinCambioPresentismo()
        {
            if (this.InvokeRequired)
            {
                Action action = FinCambioPresentismo;
                Invoke(action);
            }
            else
            {
                this.btnActivarSesion.Enabled = true;
                this.btnVotar.Enabled = true;
            }
        }
        private void MostrarMensajeErorr(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        public void RegistrarVoto(Senador banca)
        {

            Label label = (Label)banca.ControlVisual;

                label.BackColor = banca.ColorDeBanca;
        }

        public void FinalizaVotacion()
        {

            if (this.InvokeRequired)
            {
                Invoke(new Action(FinalizaVotacion));
            }
            else
            {
                this.btnActivarSesion.Enabled = true;
                this.btnVotar.Enabled = true;

                lblAfirmativos.Text = this.parlamento.VotosAfirmativos.ToString();
                lblNegativos.Text = this.parlamento.VotosNegativos.ToString();
                lblAbstenciones.Text = this.parlamento.VotosAbstenciones.ToString();
            }
        }

        private void btnActivarSesion_Click(object sender, EventArgs e)
        {
            this.btnActivarSesion.Enabled = false;
            this.btnVotar.Enabled = false;
            this.parlamento.EstadoSesion = true;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            this.btnActivarSesion.Enabled = false;
            this.btnVotar.Enabled = false;
            this.parlamento.IniciarVotacion();
        }
    }
}
