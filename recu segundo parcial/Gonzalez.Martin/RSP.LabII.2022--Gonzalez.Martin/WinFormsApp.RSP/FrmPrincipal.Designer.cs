
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
            this.btnTransportePasajeros = new System.Windows.Forms.Button();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.txtCargas = new System.Windows.Forms.TextBox();
            this.btnTransporteCarga = new System.Windows.Forms.Button();
            this.btnEventosPasajeros = new System.Windows.Forms.Button();
            this.btnEventosCargas = new System.Windows.Forms.Button();
            this.btnPasajeroSerializar = new System.Windows.Forms.Button();
            this.btnPasajeroDeserializar = new System.Windows.Forms.Button();
            this.btnCargaSerializar = new System.Windows.Forms.Button();
            this.btnCargaDeserializar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lstVisor = new System.Windows.Forms.ListBox();
            this.btnPasajerosCRUD = new System.Windows.Forms.Button();
            this.btnPasajerosTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransportePasajeros
            // 
            this.btnTransportePasajeros.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransportePasajeros.Location = new System.Drawing.Point(6, 22);
            this.btnTransportePasajeros.Name = "btnTransportePasajeros";
            this.btnTransportePasajeros.Size = new System.Drawing.Size(290, 43);
            this.btnTransportePasajeros.TabIndex = 0;
            this.btnTransportePasajeros.Text = "Transporte de pasajeros";
            this.btnTransportePasajeros.UseVisualStyleBackColor = true;
            this.btnTransportePasajeros.Click += new System.EventHandler(this.btnTransportePasajeros_Click);
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Location = new System.Drawing.Point(6, 71);
            this.txtPasajeros.Multiline = true;
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(290, 119);
            this.txtPasajeros.TabIndex = 1;
            // 
            // txtCargas
            // 
            this.txtCargas.Location = new System.Drawing.Point(335, 71);
            this.txtCargas.Multiline = true;
            this.txtCargas.Name = "txtCargas";
            this.txtCargas.Size = new System.Drawing.Size(290, 119);
            this.txtCargas.TabIndex = 3;
            // 
            // btnTransporteCarga
            // 
            this.btnTransporteCarga.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransporteCarga.Location = new System.Drawing.Point(335, 22);
            this.btnTransporteCarga.Name = "btnTransporteCarga";
            this.btnTransporteCarga.Size = new System.Drawing.Size(290, 43);
            this.btnTransporteCarga.TabIndex = 2;
            this.btnTransporteCarga.Text = "Transporte de cargas";
            this.btnTransporteCarga.UseVisualStyleBackColor = true;
            this.btnTransporteCarga.Click += new System.EventHandler(this.btnTransporteCarga_Click);
            // 
            // btnEventosPasajeros
            // 
            this.btnEventosPasajeros.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEventosPasajeros.Location = new System.Drawing.Point(6, 209);
            this.btnEventosPasajeros.Name = "btnEventosPasajeros";
            this.btnEventosPasajeros.Size = new System.Drawing.Size(290, 43);
            this.btnEventosPasajeros.TabIndex = 4;
            this.btnEventosPasajeros.Text = "Transporte de pasajeros eventos";
            this.btnEventosPasajeros.UseVisualStyleBackColor = true;
            this.btnEventosPasajeros.Click += new System.EventHandler(this.btnEventosPasajeros_Click);
            // 
            // btnEventosCargas
            // 
            this.btnEventosCargas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEventosCargas.Location = new System.Drawing.Point(335, 209);
            this.btnEventosCargas.Name = "btnEventosCargas";
            this.btnEventosCargas.Size = new System.Drawing.Size(290, 43);
            this.btnEventosCargas.TabIndex = 5;
            this.btnEventosCargas.Text = "Transporte de cargas eventos";
            this.btnEventosCargas.UseVisualStyleBackColor = true;
            this.btnEventosCargas.Click += new System.EventHandler(this.btnEventosCargas_Click);
            // 
            // btnPasajeroSerializar
            // 
            this.btnPasajeroSerializar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPasajeroSerializar.Location = new System.Drawing.Point(6, 283);
            this.btnPasajeroSerializar.Name = "btnPasajeroSerializar";
            this.btnPasajeroSerializar.Size = new System.Drawing.Size(290, 43);
            this.btnPasajeroSerializar.TabIndex = 6;
            this.btnPasajeroSerializar.Text = "Pasajero Serializar (JSON)";
            this.btnPasajeroSerializar.UseVisualStyleBackColor = true;
            this.btnPasajeroSerializar.Click += new System.EventHandler(this.btnPasajeroSerializar_Click);
            // 
            // btnPasajeroDeserializar
            // 
            this.btnPasajeroDeserializar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPasajeroDeserializar.Location = new System.Drawing.Point(6, 332);
            this.btnPasajeroDeserializar.Name = "btnPasajeroDeserializar";
            this.btnPasajeroDeserializar.Size = new System.Drawing.Size(290, 43);
            this.btnPasajeroDeserializar.TabIndex = 7;
            this.btnPasajeroDeserializar.Text = "Pasajero Deserializar (JSON)";
            this.btnPasajeroDeserializar.UseVisualStyleBackColor = true;
            this.btnPasajeroDeserializar.Click += new System.EventHandler(this.btnPasajeroDeserializar_Click);
            // 
            // btnCargaSerializar
            // 
            this.btnCargaSerializar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargaSerializar.Location = new System.Drawing.Point(335, 283);
            this.btnCargaSerializar.Name = "btnCargaSerializar";
            this.btnCargaSerializar.Size = new System.Drawing.Size(290, 43);
            this.btnCargaSerializar.TabIndex = 8;
            this.btnCargaSerializar.Text = "Carga Serializar (XML)";
            this.btnCargaSerializar.UseVisualStyleBackColor = true;
            this.btnCargaSerializar.Click += new System.EventHandler(this.btnCargaSerializar_Click);
            // 
            // btnCargaDeserializar
            // 
            this.btnCargaDeserializar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargaDeserializar.Location = new System.Drawing.Point(335, 332);
            this.btnCargaDeserializar.Name = "btnCargaDeserializar";
            this.btnCargaDeserializar.Size = new System.Drawing.Size(290, 43);
            this.btnCargaDeserializar.TabIndex = 9;
            this.btnCargaDeserializar.Text = "Carga Deserializar (XML)";
            this.btnCargaDeserializar.UseVisualStyleBackColor = true;
            this.btnCargaDeserializar.Click += new System.EventHandler(this.btnCargaDeserializar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoEllipsis = true;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(22, 488);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(360, 29);
            this.lblMensaje.TabIndex = 10;
            this.lblMensaje.Text = "mensajes serialización/deserialización";
            // 
            // lstVisor
            // 
            this.lstVisor.FormattingEnabled = true;
            this.lstVisor.ItemHeight = 15;
            this.lstVisor.Location = new System.Drawing.Point(22, 22);
            this.lstVisor.Name = "lstVisor";
            this.lstVisor.Size = new System.Drawing.Size(389, 439);
            this.lstVisor.TabIndex = 11;
            // 
            // btnPasajerosCRUD
            // 
            this.btnPasajerosCRUD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPasajerosCRUD.Location = new System.Drawing.Point(6, 42);
            this.btnPasajerosCRUD.Name = "btnPasajerosCRUD";
            this.btnPasajerosCRUD.Size = new System.Drawing.Size(290, 43);
            this.btnPasajerosCRUD.TabIndex = 13;
            this.btnPasajerosCRUD.Text = "Pasajero BD CRUD";
            this.btnPasajerosCRUD.UseVisualStyleBackColor = true;
            this.btnPasajerosCRUD.Click += new System.EventHandler(this.btnPasajerosCRUD_Click);
            // 
            // btnPasajerosTask
            // 
            this.btnPasajerosTask.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPasajerosTask.Location = new System.Drawing.Point(335, 42);
            this.btnPasajerosTask.Name = "btnPasajerosTask";
            this.btnPasajerosTask.Size = new System.Drawing.Size(290, 43);
            this.btnPasajerosTask.TabIndex = 14;
            this.btnPasajerosTask.Text = "Pasajero BD Task";
            this.btnPasajerosTask.UseVisualStyleBackColor = true;
            this.btnPasajerosTask.Click += new System.EventHandler(this.btnPasajerosTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransportePasajeros);
            this.groupBox1.Controls.Add(this.txtPasajeros);
            this.groupBox1.Controls.Add(this.btnTransporteCarga);
            this.groupBox1.Controls.Add(this.txtCargas);
            this.groupBox1.Controls.Add(this.btnEventosPasajeros);
            this.groupBox1.Controls.Add(this.btnEventosCargas);
            this.groupBox1.Controls.Add(this.btnCargaDeserializar);
            this.groupBox1.Controls.Add(this.btnPasajeroSerializar);
            this.groupBox1.Controls.Add(this.btnCargaSerializar);
            this.groupBox1.Controls.Add(this.btnPasajeroDeserializar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 409);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parte 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPasajerosCRUD);
            this.groupBox2.Controls.Add(this.btnPasajerosTask);
            this.groupBox2.Location = new System.Drawing.Point(12, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 126);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parte 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstVisor);
            this.groupBox3.Controls.Add(this.lblMensaje);
            this.groupBox3.Location = new System.Drawing.Point(649, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 541);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visor Deserialización";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 595);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Recuperatorio Segundo Parcial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransportePasajeros;
        private System.Windows.Forms.TextBox txtPasajeros;
        private System.Windows.Forms.TextBox txtCargas;
        private System.Windows.Forms.Button btnTransporteCarga;
        private System.Windows.Forms.Button btnEventosPasajeros;
        private System.Windows.Forms.Button btnEventosCargas;
        private System.Windows.Forms.Button btnPasajeroSerializar;
        private System.Windows.Forms.Button btnPasajeroDeserializar;
        private System.Windows.Forms.Button btnCargaSerializar;
        private System.Windows.Forms.Button btnCargaDeserializar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ListBox lstVisor;
        private System.Windows.Forms.Button btnPasajerosCRUD;
        private System.Windows.Forms.Button btnPasajerosTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

