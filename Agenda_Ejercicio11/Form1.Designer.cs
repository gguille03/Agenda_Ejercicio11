namespace Agenda_Ejercicio11
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnNombre = new System.Windows.Forms.Label();
            this.lbTeléfono = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnNombre
            // 
            this.lnNombre.AutoSize = true;
            this.lnNombre.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnNombre.Location = new System.Drawing.Point(97, 177);
            this.lnNombre.Name = "lnNombre";
            this.lnNombre.Size = new System.Drawing.Size(96, 29);
            this.lnNombre.TabIndex = 0;
            this.lnNombre.Text = "Nombre";
            // 
            // lbTeléfono
            // 
            this.lbTeléfono.AutoSize = true;
            this.lbTeléfono.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeléfono.Location = new System.Drawing.Point(91, 235);
            this.lbTeléfono.Name = "lbTeléfono";
            this.lbTeléfono.Size = new System.Drawing.Size(102, 29);
            this.lbTeléfono.TabIndex = 1;
            this.lbTeléfono.Text = "Teléfono";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(129, 297);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(64, 29);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "Edad";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(283, 184);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(329, 22);
            this.txtbNombre.TabIndex = 3;
            this.txtbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombre_KeyPress);
            // 
            // txtbEdad
            // 
            this.txtbEdad.Location = new System.Drawing.Point(283, 304);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(329, 22);
            this.txtbEdad.TabIndex = 3;
            this.txtbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombre_KeyPress);
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(283, 242);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(329, 22);
            this.txtbTelefono.TabIndex = 3;
            this.txtbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombre_KeyPress);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiguiente.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(466, 443);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(146, 41);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = " Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(230, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 41);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(283, 366);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(329, 22);
            this.txtbDireccion.TabIndex = 3;
            this.txtbDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese sus datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 574);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbTeléfono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnNombre;
        private System.Windows.Forms.Label lbTeléfono;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

