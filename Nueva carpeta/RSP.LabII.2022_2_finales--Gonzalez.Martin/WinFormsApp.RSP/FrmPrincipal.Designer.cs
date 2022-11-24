
namespace WinFormsApp.RSP
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTachoPintura = new System.Windows.Forms.Button();
            this.txtPinturas = new System.Windows.Forms.TextBox();
            this.btnEventosPinturas = new System.Windows.Forms.Button();
            this.btnPinturaSerializar = new System.Windows.Forms.Button();
            this.btnPinturaDeserializar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lstVisor = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTachoPintura
            // 
            this.btnTachoPintura.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTachoPintura.Location = new System.Drawing.Point(6, 22);
            this.btnTachoPintura.Name = "btnTachoPintura";
            this.btnTachoPintura.Size = new System.Drawing.Size(342, 43);
            this.btnTachoPintura.TabIndex = 0;
            this.btnTachoPintura.Text = "Tacho de Pinturas";
            this.btnTachoPintura.UseVisualStyleBackColor = true;
            this.btnTachoPintura.Click += new System.EventHandler(this.btnLataPinturas_Click);
            // 
            // txtPinturas
            // 
            this.txtPinturas.Location = new System.Drawing.Point(6, 87);
            this.txtPinturas.Multiline = true;
            this.txtPinturas.Name = "txtPinturas";
            this.txtPinturas.Size = new System.Drawing.Size(342, 151);
            this.txtPinturas.TabIndex = 1;
            // 
            // btnEventosPinturas
            // 
            this.btnEventosPinturas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEventosPinturas.Location = new System.Drawing.Point(0, 254);
            this.btnEventosPinturas.Name = "btnEventosPinturas";
            this.btnEventosPinturas.Size = new System.Drawing.Size(348, 43);
            this.btnEventosPinturas.TabIndex = 4;
            this.btnEventosPinturas.Text = "Tacho de pintura eventos";
            this.btnEventosPinturas.UseVisualStyleBackColor = true;
            this.btnEventosPinturas.Click += new System.EventHandler(this.btnEventosPinturas_Click);
            // 
            // btnPinturaSerializar
            // 
            this.btnPinturaSerializar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPinturaSerializar.Location = new System.Drawing.Point(0, 328);
            this.btnPinturaSerializar.Name = "btnPinturaSerializar";
            this.btnPinturaSerializar.Size = new System.Drawing.Size(209, 43);
            this.btnPinturaSerializar.TabIndex = 6;
            this.btnPinturaSerializar.Text = "Pintura Serializar (JSON)";
            this.btnPinturaSerializar.UseVisualStyleBackColor = true;
            this.btnPinturaSerializar.Click += new System.EventHandler(this.btnPinturaSerializar_Click);
            // 
            // btnPinturaDeserializar
            // 
            this.btnPinturaDeserializar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPinturaDeserializar.Location = new System.Drawing.Point(0, 377);
            this.btnPinturaDeserializar.Name = "btnPinturaDeserializar";
            this.btnPinturaDeserializar.Size = new System.Drawing.Size(348, 43);
            this.btnPinturaDeserializar.TabIndex = 7;
            this.btnPinturaDeserializar.Text = "Pintura Deserializar (JSON)";
            this.btnPinturaDeserializar.UseVisualStyleBackColor = true;
            this.btnPinturaDeserializar.Click += new System.EventHandler(this.btnPinturaDeserializar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoEllipsis = true;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(404, 383);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(360, 29);
            this.lblMensaje.TabIndex = 10;
            this.lblMensaje.Text = "mensajes serialización/deserialización";
            // 
            // lstVisor
            // 
            this.lstVisor.FormattingEnabled = true;
            this.lstVisor.ItemHeight = 15;
            this.lstVisor.Location = new System.Drawing.Point(404, 22);
            this.lstVisor.Name = "lstVisor";
            this.lstVisor.Size = new System.Drawing.Size(389, 349);
            this.lstVisor.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.lstVisor);
            this.groupBox1.Controls.Add(this.btnTachoPintura);
            this.groupBox1.Controls.Add(this.txtPinturas);
            this.groupBox1.Controls.Add(this.btnEventosPinturas);
            this.groupBox1.Controls.Add(this.btnPinturaSerializar);
            this.groupBox1.Controls.Add(this.btnPinturaDeserializar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 438);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta 5";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.Location = new System.Drawing.Point(215, 328);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(133, 43);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 470);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Recuperatorio Segundo Parcial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTachoPintura;
        private System.Windows.Forms.TextBox txtPinturas;
        private System.Windows.Forms.Button btnEventosPinturas;
        private System.Windows.Forms.Button btnPinturaSerializar;
        private System.Windows.Forms.Button btnPinturaDeserializar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ListBox lstVisor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
    }
}

