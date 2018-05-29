namespace FrbaHotel.AbmRol
{
    partial class ABMRol
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
            this.label2 = new System.Windows.Forms.Label();
            this.gridFuncionalidades = new System.Windows.Forms.DataGridView();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.comboFuncionalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFuncionalidad = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.ID_Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Funcionalidades:";
            // 
            // gridFuncionalidades
            // 
            this.gridFuncionalidades.AllowUserToAddRows = false;
            this.gridFuncionalidades.AllowUserToDeleteRows = false;
            this.gridFuncionalidades.AllowUserToOrderColumns = true;
            this.gridFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Funcionalidad,
            this.Descripcion});
            this.gridFuncionalidades.Location = new System.Drawing.Point(12, 68);
            this.gridFuncionalidades.Name = "gridFuncionalidades";
            this.gridFuncionalidades.ReadOnly = true;
            this.gridFuncionalidades.Size = new System.Drawing.Size(269, 228);
            this.gridFuncionalidades.TabIndex = 12;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkEstado.Location = new System.Drawing.Point(12, 32);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(62, 17);
            this.checkEstado.TabIndex = 11;
            this.checkEstado.Text = "Estado:";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(62, 6);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(174, 20);
            this.textNombre.TabIndex = 9;
            // 
            // comboFuncionalidad
            // 
            this.comboFuncionalidad.FormattingEnabled = true;
            this.comboFuncionalidad.Location = new System.Drawing.Point(287, 69);
            this.comboFuncionalidad.Name = "comboFuncionalidad";
            this.comboFuncionalidad.Size = new System.Drawing.Size(193, 21);
            this.comboFuncionalidad.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Agregar Funcionalidad:";
            // 
            // buttonFuncionalidad
            // 
            this.buttonFuncionalidad.Location = new System.Drawing.Point(287, 96);
            this.buttonFuncionalidad.Name = "buttonFuncionalidad";
            this.buttonFuncionalidad.Size = new System.Drawing.Size(75, 23);
            this.buttonFuncionalidad.TabIndex = 19;
            this.buttonFuncionalidad.Text = "Agregar";
            this.buttonFuncionalidad.UseVisualStyleBackColor = true;
            this.buttonFuncionalidad.Click += new System.EventHandler(this.buttonFuncionalidad_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(324, 303);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 20;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(405, 303);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 21;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // ID_Funcionalidad
            // 
            this.ID_Funcionalidad.HeaderText = "ID_Funcionalidad";
            this.ID_Funcionalidad.Name = "ID_Funcionalidad";
            this.ID_Funcionalidad.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 303);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 338);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonFuncionalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboFuncionalidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridFuncionalidades);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Name = "ABMRol";
            this.Text = "ABM de Roles";
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridFuncionalidades;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.ComboBox comboFuncionalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFuncionalidad;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Funcionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button buttonBack;
    }
}