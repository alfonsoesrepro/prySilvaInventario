namespace prySilvaInventario
{
    partial class frmEntradaDeCodigo
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
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            cmdAceptar = new Button();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(79, 82);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(110, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigo.Location = new Point(30, 34);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(216, 19);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Ingrese el código del producto";
            // 
            // cmdAceptar
            // 
            cmdAceptar.Location = new Point(95, 135);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(75, 23);
            cmdAceptar.TabIndex = 2;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            // 
            // frmEntradaDeCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 204);
            Controls.Add(cmdAceptar);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Name = "frmEntradaDeCodigo";
            Text = "Entrada de código";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private Button cmdAceptar;
    }
}