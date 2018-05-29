namespace FrbaHotel
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonUsuario = new System.Windows.Forms.Button();
            this.ButtonRol = new System.Windows.Forms.Button();
            this.ButtonCliente = new System.Windows.Forms.Button();
            this.ButtonHotel = new System.Windows.Forms.Button();
            this.ButtonHabitacion = new System.Windows.Forms.Button();
            this.ButtonRegimen = new System.Windows.Forms.Button();
            this.ButtonAltaModReserva = new System.Windows.Forms.Button();
            this.ButtonCancelReserva = new System.Windows.Forms.Button();
            this.ButtonEstadia = new System.Windows.Forms.Button();
            this.ButtonConsumible = new System.Windows.Forms.Button();
            this.ButtonFacturacionEstadia = new System.Windows.Forms.Button();
            this.ButtonEstadisticas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelUserLogueado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonUsuario
            // 
            this.ButtonUsuario.Location = new System.Drawing.Point(12, 51);
            this.ButtonUsuario.Name = "ButtonUsuario";
            this.ButtonUsuario.Size = new System.Drawing.Size(179, 23);
            this.ButtonUsuario.TabIndex = 0;
            this.ButtonUsuario.Text = "ABM de Usuario";
            this.ButtonUsuario.UseVisualStyleBackColor = true;
            this.ButtonUsuario.Visible = false;
            // 
            // ButtonRol
            // 
            this.ButtonRol.Location = new System.Drawing.Point(12, 80);
            this.ButtonRol.Name = "ButtonRol";
            this.ButtonRol.Size = new System.Drawing.Size(179, 23);
            this.ButtonRol.TabIndex = 1;
            this.ButtonRol.Text = "ABM de Rol";
            this.ButtonRol.UseVisualStyleBackColor = true;
            this.ButtonRol.Visible = false;
            this.ButtonRol.Click += new System.EventHandler(this.ButtonRol_Click);
            // 
            // ButtonCliente
            // 
            this.ButtonCliente.Location = new System.Drawing.Point(12, 109);
            this.ButtonCliente.Name = "ButtonCliente";
            this.ButtonCliente.Size = new System.Drawing.Size(179, 23);
            this.ButtonCliente.TabIndex = 2;
            this.ButtonCliente.Text = "ABM de Cliente";
            this.ButtonCliente.UseVisualStyleBackColor = true;
            this.ButtonCliente.Visible = false;
            // 
            // ButtonHotel
            // 
            this.ButtonHotel.Location = new System.Drawing.Point(12, 138);
            this.ButtonHotel.Name = "ButtonHotel";
            this.ButtonHotel.Size = new System.Drawing.Size(179, 23);
            this.ButtonHotel.TabIndex = 3;
            this.ButtonHotel.Text = "ABM de Hotel";
            this.ButtonHotel.UseVisualStyleBackColor = true;
            this.ButtonHotel.Visible = false;
            // 
            // ButtonHabitacion
            // 
            this.ButtonHabitacion.Location = new System.Drawing.Point(12, 167);
            this.ButtonHabitacion.Name = "ButtonHabitacion";
            this.ButtonHabitacion.Size = new System.Drawing.Size(179, 23);
            this.ButtonHabitacion.TabIndex = 4;
            this.ButtonHabitacion.Text = "ABM de Habitación";
            this.ButtonHabitacion.UseVisualStyleBackColor = true;
            this.ButtonHabitacion.Visible = false;
            // 
            // ButtonRegimen
            // 
            this.ButtonRegimen.Location = new System.Drawing.Point(12, 196);
            this.ButtonRegimen.Name = "ButtonRegimen";
            this.ButtonRegimen.Size = new System.Drawing.Size(179, 23);
            this.ButtonRegimen.TabIndex = 5;
            this.ButtonRegimen.Text = "ABM de Regimen";
            this.ButtonRegimen.UseVisualStyleBackColor = true;
            this.ButtonRegimen.Visible = false;
            // 
            // ButtonAltaModReserva
            // 
            this.ButtonAltaModReserva.Location = new System.Drawing.Point(12, 225);
            this.ButtonAltaModReserva.Name = "ButtonAltaModReserva";
            this.ButtonAltaModReserva.Size = new System.Drawing.Size(179, 23);
            this.ButtonAltaModReserva.TabIndex = 6;
            this.ButtonAltaModReserva.Text = "Generación/Modificación Reserva";
            this.ButtonAltaModReserva.UseVisualStyleBackColor = true;
            this.ButtonAltaModReserva.Visible = false;
            // 
            // ButtonCancelReserva
            // 
            this.ButtonCancelReserva.Location = new System.Drawing.Point(12, 254);
            this.ButtonCancelReserva.Name = "ButtonCancelReserva";
            this.ButtonCancelReserva.Size = new System.Drawing.Size(179, 23);
            this.ButtonCancelReserva.TabIndex = 7;
            this.ButtonCancelReserva.Text = "Cancelación Reserva";
            this.ButtonCancelReserva.UseVisualStyleBackColor = true;
            this.ButtonCancelReserva.Visible = false;
            // 
            // ButtonEstadia
            // 
            this.ButtonEstadia.Location = new System.Drawing.Point(12, 283);
            this.ButtonEstadia.Name = "ButtonEstadia";
            this.ButtonEstadia.Size = new System.Drawing.Size(179, 23);
            this.ButtonEstadia.TabIndex = 8;
            this.ButtonEstadia.Text = "Registro Estadía";
            this.ButtonEstadia.UseVisualStyleBackColor = true;
            this.ButtonEstadia.Visible = false;
            // 
            // ButtonConsumible
            // 
            this.ButtonConsumible.Location = new System.Drawing.Point(12, 312);
            this.ButtonConsumible.Name = "ButtonConsumible";
            this.ButtonConsumible.Size = new System.Drawing.Size(179, 23);
            this.ButtonConsumible.TabIndex = 9;
            this.ButtonConsumible.Text = "Registro Consumible";
            this.ButtonConsumible.UseVisualStyleBackColor = true;
            this.ButtonConsumible.Visible = false;
            // 
            // ButtonFacturacionEstadia
            // 
            this.ButtonFacturacionEstadia.Location = new System.Drawing.Point(12, 341);
            this.ButtonFacturacionEstadia.Name = "ButtonFacturacionEstadia";
            this.ButtonFacturacionEstadia.Size = new System.Drawing.Size(179, 23);
            this.ButtonFacturacionEstadia.TabIndex = 10;
            this.ButtonFacturacionEstadia.Text = "Facturación Estadía";
            this.ButtonFacturacionEstadia.UseVisualStyleBackColor = true;
            this.ButtonFacturacionEstadia.Visible = false;
            // 
            // ButtonEstadisticas
            // 
            this.ButtonEstadisticas.Location = new System.Drawing.Point(12, 370);
            this.ButtonEstadisticas.Name = "ButtonEstadisticas";
            this.ButtonEstadisticas.Size = new System.Drawing.Size(179, 23);
            this.ButtonEstadisticas.TabIndex = 11;
            this.ButtonEstadisticas.Text = "Listado Estadisticas";
            this.ButtonEstadisticas.UseVisualStyleBackColor = true;
            this.ButtonEstadisticas.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario:";
            // 
            // LabelUserLogueado
            // 
            this.LabelUserLogueado.AutoSize = true;
            this.LabelUserLogueado.Location = new System.Drawing.Point(65, 13);
            this.LabelUserLogueado.Name = "LabelUserLogueado";
            this.LabelUserLogueado.Size = new System.Drawing.Size(0, 13);
            this.LabelUserLogueado.TabIndex = 13;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 540);
            this.Controls.Add(this.ButtonUsuario);
            this.Controls.Add(this.LabelUserLogueado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonEstadisticas);
            this.Controls.Add(this.ButtonFacturacionEstadia);
            this.Controls.Add(this.ButtonConsumible);
            this.Controls.Add(this.ButtonEstadia);
            this.Controls.Add(this.ButtonCancelReserva);
            this.Controls.Add(this.ButtonAltaModReserva);
            this.Controls.Add(this.ButtonRegimen);
            this.Controls.Add(this.ButtonHabitacion);
            this.Controls.Add(this.ButtonHotel);
            this.Controls.Add(this.ButtonCliente);
            this.Controls.Add(this.ButtonRol);
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonUsuario;
        private System.Windows.Forms.Button ButtonRol;
        private System.Windows.Forms.Button ButtonCliente;
        private System.Windows.Forms.Button ButtonHotel;
        private System.Windows.Forms.Button ButtonHabitacion;
        private System.Windows.Forms.Button ButtonRegimen;
        private System.Windows.Forms.Button ButtonAltaModReserva;
        private System.Windows.Forms.Button ButtonCancelReserva;
        private System.Windows.Forms.Button ButtonEstadia;
        private System.Windows.Forms.Button ButtonConsumible;
        private System.Windows.Forms.Button ButtonFacturacionEstadia;
        private System.Windows.Forms.Button ButtonEstadisticas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelUserLogueado;
    }
}

