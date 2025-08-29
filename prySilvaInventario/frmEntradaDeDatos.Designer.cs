namespace prySilvaInventario
{
    partial class frmEntradaDeDatos
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
            lblCod = new Label();
            lblNombre = new Label();
            lblDesc = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblCateg = new Label();
            txtCod = new TextBox();
            txtNombre = new TextBox();
            txtDescrip = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            txtCateg = new TextBox();
            cmdAceptar = new Button();
            cmdVolver = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCod.Location = new Point(41, 60);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(48, 15);
            lblCod.TabIndex = 0;
            lblCod.Text = "Código:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(41, 111);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesc.Location = new Point(37, 184);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(75, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(37, 252);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(45, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.Location = new Point(41, 309);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 15);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock:";
            // 
            // lblCateg
            // 
            lblCateg.AutoSize = true;
            lblCateg.Location = new Point(36, 355);
            lblCateg.Name = "lblCateg";
            lblCateg.Size = new Size(63, 15);
            lblCateg.TabIndex = 5;
            lblCateg.Text = "Categoría:";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(157, 57);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(100, 23);
            txtCod.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtDescrip
            // 
            txtDescrip.Location = new Point(157, 170);
            txtDescrip.Multiline = true;
            txtDescrip.Name = "txtDescrip";
            txtDescrip.Size = new Size(159, 43);
            txtDescrip.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(157, 249);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(157, 301);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 10;
            // 
            // txtCateg
            // 
            txtCateg.Location = new Point(157, 352);
            txtCateg.Name = "txtCateg";
            txtCateg.Size = new Size(100, 23);
            txtCateg.TabIndex = 11;
            // 
            // cmdAceptar
            // 
            cmdAceptar.Font = new Font("Segoe UI", 9F);
            cmdAceptar.Location = new Point(241, 435);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(75, 23);
            cmdAceptar.TabIndex = 12;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            // 
            // cmdVolver
            // 
            cmdVolver.Font = new Font("Segoe UI", 9F);
            cmdVolver.Location = new Point(36, 435);
            cmdVolver.Name = "cmdVolver";
            cmdVolver.Size = new Size(75, 23);
            cmdVolver.TabIndex = 13;
            cmdVolver.Text = "Volver";
            cmdVolver.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(75, 19);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmEntradaDeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 488);
            Controls.Add(button1);
            Controls.Add(cmdVolver);
            Controls.Add(cmdAceptar);
            Controls.Add(txtCateg);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescrip);
            Controls.Add(txtNombre);
            Controls.Add(txtCod);
            Controls.Add(lblCateg);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblDesc);
            Controls.Add(lblNombre);
            Controls.Add(lblCod);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "frmEntradaDeDatos";
            Text = "Entrada de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCod;
        private Label lblNombre;
        private Label lblDesc;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblCateg;
        private TextBox txtCod;
        private TextBox txtNombre;
        private TextBox txtDescrip;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private TextBox txtCateg;
        private Button cmdAceptar;
        private Button cmdVolver;
        private Button button1;
    }
}