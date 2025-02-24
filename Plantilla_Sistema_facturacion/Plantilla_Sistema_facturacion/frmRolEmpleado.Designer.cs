namespace Plantilla_Sistema_facturacion
{
    partial class frmRolEmpleado
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
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblRolEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescripcionRol = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(246, 377);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(85, 33);
            this.BtnSalir.TabIndex = 20;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Location = new System.Drawing.Point(112, 380);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(96, 26);
            this.BtnActualizar.TabIndex = 19;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Hint = "Nombre Rol";
            this.txtNombreRol.Location = new System.Drawing.Point(67, 99);
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(344, 23);
            this.txtNombreRol.TabIndex = 18;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // lblRolEmpleados
            // 
            this.lblRolEmpleados.AutoSize = true;
            this.lblRolEmpleados.Depth = 0;
            this.lblRolEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRolEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRolEmpleados.Location = new System.Drawing.Point(141, 36);
            this.lblRolEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleados.Name = "lblRolEmpleados";
            this.lblRolEmpleados.Size = new System.Drawing.Size(150, 19);
            this.lblRolEmpleados.TabIndex = 17;
            this.lblRolEmpleados.Text = "ROL DE EMPLEADOS";
            // 
            // lblDescripcionRol
            // 
            this.lblDescripcionRol.AutoSize = true;
            this.lblDescripcionRol.Depth = 0;
            this.lblDescripcionRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcionRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcionRol.Location = new System.Drawing.Point(63, 168);
            this.lblDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionRol.Name = "lblDescripcionRol";
            this.lblDescripcionRol.Size = new System.Drawing.Size(180, 19);
            this.lblDescripcionRol.TabIndex = 21;
            this.lblDescripcionRol.Text = "Descripción detallada Rol";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 126);
            this.textBox1.TabIndex = 41;
            // 
            // frmRolEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 437);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDescripcionRol);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.lblRolEmpleados);
            this.Name = "frmRolEmpleado";
            this.Text = "frmRolEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private MaterialSkin.Controls.MaterialLabel lblRolEmpleados;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionRol;
        private System.Windows.Forms.TextBox textBox1;
    }
}