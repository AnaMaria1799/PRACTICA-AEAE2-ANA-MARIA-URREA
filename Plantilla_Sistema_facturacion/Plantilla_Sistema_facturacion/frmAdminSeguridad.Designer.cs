namespace Plantilla_Sistema_facturacion
{
    partial class frmAdminSeguridad
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
            this.lblAdmiUsuarioSistema = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtClaveSistema = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuarioSistema = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblAdmiUsuarioSistema
            // 
            this.lblAdmiUsuarioSistema.AutoSize = true;
            this.lblAdmiUsuarioSistema.Depth = 0;
            this.lblAdmiUsuarioSistema.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdmiUsuarioSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdmiUsuarioSistema.Location = new System.Drawing.Point(70, 44);
            this.lblAdmiUsuarioSistema.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdmiUsuarioSistema.Name = "lblAdmiUsuarioSistema";
            this.lblAdmiUsuarioSistema.Size = new System.Drawing.Size(329, 19);
            this.lblAdmiUsuarioSistema.TabIndex = 13;
            this.lblAdmiUsuarioSistema.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleado.Location = new System.Drawing.Point(44, 146);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 19);
            this.lblEmpleado.TabIndex = 14;
            this.lblEmpleado.Text = "Empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // txtClaveSistema
            // 
            this.txtClaveSistema.Depth = 0;
            this.txtClaveSistema.Hint = "Clave";
            this.txtClaveSistema.Location = new System.Drawing.Point(156, 254);
            this.txtClaveSistema.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClaveSistema.Name = "txtClaveSistema";
            this.txtClaveSistema.PasswordChar = '\0';
            this.txtClaveSistema.SelectedText = "";
            this.txtClaveSistema.SelectionLength = 0;
            this.txtClaveSistema.SelectionStart = 0;
            this.txtClaveSistema.Size = new System.Drawing.Size(189, 23);
            this.txtClaveSistema.TabIndex = 33;
            this.txtClaveSistema.UseSystemPasswordChar = false;
            // 
            // txtUsuarioSistema
            // 
            this.txtUsuarioSistema.Depth = 0;
            this.txtUsuarioSistema.Hint = "Usuario";
            this.txtUsuarioSistema.Location = new System.Drawing.Point(156, 211);
            this.txtUsuarioSistema.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuarioSistema.Name = "txtUsuarioSistema";
            this.txtUsuarioSistema.PasswordChar = '\0';
            this.txtUsuarioSistema.SelectedText = "";
            this.txtUsuarioSistema.SelectionLength = 0;
            this.txtUsuarioSistema.SelectionStart = 0;
            this.txtUsuarioSistema.Size = new System.Drawing.Size(189, 23);
            this.txtUsuarioSistema.TabIndex = 32;
            this.txtUsuarioSistema.UseSystemPasswordChar = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(264, 344);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(97, 29);
            this.BtnSalir.TabIndex = 35;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(112, 344);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(97, 29);
            this.btnActualizar.TabIndex = 34;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // frmAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 433);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtClaveSistema);
            this.Controls.Add(this.txtUsuarioSistema);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblAdmiUsuarioSistema);
            this.Name = "frmAdminSeguridad";
            this.Text = "frmAdminSeguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblAdmiUsuarioSistema;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClaveSistema;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuarioSistema;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
    }
}