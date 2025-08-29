namespace prySilvaInventario
{
    partial class frmGestionDeInventario
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
            cmdAgregar = new Button();
            cmdModificar = new Button();
            cmdEliminar = new Button();
            cmdBusqueda = new Button();
            cmdReporte = new Button();
            lblOpcion = new Label();
            SuspendLayout();
            // 
            // cmdAgregar
            // 
            cmdAgregar.Location = new Point(27, 80);
            cmdAgregar.Name = "cmdAgregar";
            cmdAgregar.Size = new Size(484, 64);
            cmdAgregar.TabIndex = 0;
            cmdAgregar.Text = "Agregar producto";
            cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(27, 158);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(484, 72);
            cmdModificar.TabIndex = 1;
            cmdModificar.Text = "Modificar producto";
            cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdEliminar
            // 
            cmdEliminar.Location = new Point(27, 246);
            cmdEliminar.Name = "cmdEliminar";
            cmdEliminar.Size = new Size(484, 69);
            cmdEliminar.TabIndex = 2;
            cmdEliminar.Text = "Eliminar producto";
            cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // cmdBusqueda
            // 
            cmdBusqueda.Location = new Point(27, 429);
            cmdBusqueda.Name = "cmdBusqueda";
            cmdBusqueda.Size = new Size(484, 64);
            cmdBusqueda.TabIndex = 3;
            cmdBusqueda.Text = "Buscar producto";
            cmdBusqueda.UseVisualStyleBackColor = true;
            // 
            // cmdReporte
            // 
            cmdReporte.Location = new Point(27, 337);
            cmdReporte.Name = "cmdReporte";
            cmdReporte.Size = new Size(484, 69);
            cmdReporte.TabIndex = 4;
            cmdReporte.Text = "Generar reporte ";
            cmdReporte.UseVisualStyleBackColor = true;
            // 
            // lblOpcion
            // 
            lblOpcion.AutoSize = true;
            lblOpcion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOpcion.Location = new Point(12, 28);
            lblOpcion.Name = "lblOpcion";
            lblOpcion.Size = new Size(138, 21);
            lblOpcion.TabIndex = 5;
            lblOpcion.Text = "Elige una opción";
            // 
            // frmGestionDeInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 543);
            Controls.Add(lblOpcion);
            Controls.Add(cmdReporte);
            Controls.Add(cmdBusqueda);
            Controls.Add(cmdEliminar);
            Controls.Add(cmdModificar);
            Controls.Add(cmdAgregar);
            Name = "frmGestionDeInventario";
            Text = "Gestión de Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAgregar;
        private Button cmdModificar;
        private Button cmdEliminar;
        private Button cmdBusqueda;
        private Button cmdReporte;
        private Label lblOpcion;
    }
}
