using System;
using System.Drawing;

namespace CoreLibraries
{
    public class Senador : IParlamentario
    {
        private object controlVisual;

        private string banca;
        private bool presentismo;
        private EVoto voto;

        public event FinalizarRegistro Fin;
        public event Parlamento<Senador>.InformarCambioEstado Informar;
        public Senador(string banca, object controlVisual)
        {
            this.banca = banca;
            this.controlVisual = controlVisual;
            this.voto = EVoto.Indefinido;
      
        }

        

        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual { get => controlVisual; set => controlVisual = value; }



        public Color ColorDeBanca
        {
            get
            {
                if (this.Presentismo)
                {
                    switch (this.voto)
                    {
                        case EVoto.Abstencion:
                            return Color.FromArgb(0,200,255);
                        case EVoto.Negativo:
                            return Color.DarkRed;
                        case EVoto.Positivo:
                            return Color.DarkGreen;
                        default:
                            return Color.DarkBlue;
                    }
                }
                else
                    return Color.Black;
            }
        }

        public bool AperturaSesion
        {
            set
            {
                if (value)
                {
                    if (new Random().Next(0,2) == 1)
                    {
                        this.Presentismo = value;
                    }
                    else
                    {
                        this.Presentismo = false;

                    }
                }
                else
                {
                    this.Presentismo = false;
                }
            }
        }
    
        public string Banca { get => banca; set => banca = value; }
        public bool Presentismo { get => presentismo; set => presentismo = value; }
        public EVoto Voto { get => voto; set => voto = value ; }

        public void EmitirVoto()
        {
            this.voto = (EVoto)new Random().Next(1, 4);
        }
    }
}
