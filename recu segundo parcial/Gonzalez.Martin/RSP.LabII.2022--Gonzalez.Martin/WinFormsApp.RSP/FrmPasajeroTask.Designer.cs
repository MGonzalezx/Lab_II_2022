
namespace WinFormsApp.RSP
{
    partial class FrmPasajeroTask
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
            this.lstVisorTask = new System.Windows.Forms.ListBox();
            this.btnCancelarTask = new System.Windows.Forms.Button();
            this.btnIniciarTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVisorTask
            // 
            this.lstVisorTask.FormattingEnabled = true;
            this.lstVisorTask.ItemHeight = 15;
            this.lstVisorTask.Location = new System.Drawing.Point(12, 12);
            this.lstVisorTask.Name = "lstVisorTask";
            this.lstVisorTask.Size = new System.Drawing.Size(349, 394);
            this.lstVisorTask.TabIndex = 10;
            // 
            // btnCancelarTask
            // 
            this.btnCancelarTask.BackColor = System.Drawing.Color.Red;
            this.btnCancelarTask.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarTask.Location = new System.Drawing.Point(367, 236);
            this.btnCancelarTask.Name = "btnCancelarTask";
            this.btnCancelarTask.Size = new System.Drawing.Size(286, 46);
            this.btnCancelarTask.TabIndex = 12;
            this.btnCancelarTask.Text = "Cancelar Task";
            this.btnCancelarTask.UseVisualStyleBackColor = false;
            this.btnCancelarTask.Click += new System.EventHandler(this.btnCancelarTask_Click);
            // 
            // btnIniciarTask
            // 
            this.btnIniciarTask.BackColor = System.Drawing.Color.LawnGreen;
            this.btnIniciarTask.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarTask.Location = new System.Drawing.Point(367, 136);
            this.btnIniciarTask.Name = "btnIniciarTask";
            this.btnIniciarTask.Size = new System.Drawing.Size(286, 46);
            this.btnIniciarTask.TabIndex = 11;
            this.btnIniciarTask.Text = "Iniciar Task";
            this.btnIniciarTask.UseVisualStyleBackColor = false;
            this.btnIniciarTask.Click += new System.EventHandler(this.btnIniciarTask_Click);
            // 
            // FrmPasajeroTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 418);
            this.Controls.Add(this.lstVisorTask);
            this.Controls.Add(this.btnCancelarTask);
            this.Controls.Add(this.btnIniciarTask);
            this.Name = "FrmPasajeroTask";
            this.Text = "FrmPasajeroTask";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVisorTask;
        private System.Windows.Forms.Button btnCancelarTask;
        private System.Windows.Forms.Button btnIniciarTask;
    }
}