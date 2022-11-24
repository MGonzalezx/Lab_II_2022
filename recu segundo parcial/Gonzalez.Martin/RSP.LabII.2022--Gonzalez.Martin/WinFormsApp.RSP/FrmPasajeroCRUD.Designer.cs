
namespace WinFormsApp.RSP
{
    partial class FrmPasajeroCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbCRUD = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEquipaje = new System.Windows.Forms.TextBox();
            this.lstVisorCRUD = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpbCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCRUD
            // 
            this.gpbCRUD.Controls.Add(this.btnEliminar);
            this.gpbCRUD.Controls.Add(this.label1);
            this.gpbCRUD.Controls.Add(this.label2);
            this.gpbCRUD.Controls.Add(this.label3);
            this.gpbCRUD.Controls.Add(this.btnAgregar);
            this.gpbCRUD.Controls.Add(this.btnModificar);
            this.gpbCRUD.Controls.Add(this.txtDni);
            this.gpbCRUD.Controls.Add(this.txtNombre);
            this.gpbCRUD.Controls.Add(this.txtEquipaje);
            this.gpbCRUD.Location = new System.Drawing.Point(399, 12);
            this.gpbCRUD.Name = "gpbCRUD";
            this.gpbCRUD.Size = new System.Drawing.Size(337, 394);
            this.gpbCRUD.TabIndex = 0;
            this.gpbCRUD.TabStop = false;
            this.gpbCRUD.Text = "Pasajero CRUD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equipaje:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(23, 238);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(286, 46);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Yellow;
            this.btnModificar.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(23, 290);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(286, 46);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(23, 47);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(286, 29);
            this.txtDni.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(23, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 29);
            this.txtNombre.TabIndex = 7;
            // 
            // txtEquipaje
            // 
            this.txtEquipaje.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEquipaje.Location = new System.Drawing.Point(23, 181);
            this.txtEquipaje.Name = "txtEquipaje";
            this.txtEquipaje.Size = new System.Drawing.Size(286, 29);
            this.txtEquipaje.TabIndex = 8;
            // 
            // lstVisorCRUD
            // 
            this.lstVisorCRUD.FormattingEnabled = true;
            this.lstVisorCRUD.ItemHeight = 15;
            this.lstVisorCRUD.Location = new System.Drawing.Point(12, 12);
            this.lstVisorCRUD.Name = "lstVisorCRUD";
            this.lstVisorCRUD.Size = new System.Drawing.Size(349, 394);
            this.lstVisorCRUD.TabIndex = 0;
            this.lstVisorCRUD.SelectedIndexChanged += new System.EventHandler(this.lstVisorCRUD_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(23, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(286, 46);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmPasajeroCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 418);
            this.Controls.Add(this.lstVisorCRUD);
            this.Controls.Add(this.gpbCRUD);
            this.Name = "FrmPasajeroCRUD";
            this.Text = "FrmPasajeroCRUD";
            this.Load += new System.EventHandler(this.FrmPasajeroCRUD_Load);
            this.gpbCRUD.ResumeLayout(false);
            this.gpbCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCRUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEquipaje;
        private System.Windows.Forms.ListBox lstVisorCRUD;
        private System.Windows.Forms.Button btnEliminar;
    }
}