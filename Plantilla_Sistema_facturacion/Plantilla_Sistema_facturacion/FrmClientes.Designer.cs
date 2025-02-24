namespace Plantilla_Sistema_facturacion
{
    partial class FrmClientes
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
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(123, 31);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "NUEVO REGISTRO CLIENTE";
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre Cliente";
            this.txtNombre.Location = new System.Drawing.Point(54, 114);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(289, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Hint = "Documento";
            this.txtDocumento.Location = new System.Drawing.Point(54, 149);
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(289, 23);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.Location = new System.Drawing.Point(54, 184);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(289, 23);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "Teléfono";
            this.txtTelefono.Location = new System.Drawing.Point(54, 219);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(289, 23);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(54, 254);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(289, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(76, 354);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(97, 29);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(222, 354);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(97, 29);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 439);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
    }
}