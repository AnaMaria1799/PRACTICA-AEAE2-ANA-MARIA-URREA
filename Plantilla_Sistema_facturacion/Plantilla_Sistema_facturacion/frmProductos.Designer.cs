namespace Plantilla_Sistema_facturacion
{
    partial class frmProductos
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
            this.btnGuardarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigoRef = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.txtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDetalleProducto = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDatosProductos = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(319, 362);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(130, 29);
            this.BtnSalir.TabIndex = 19;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Depth = 0;
            this.btnGuardarProducto.Location = new System.Drawing.Point(148, 362);
            this.btnGuardarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Primary = true;
            this.btnGuardarProducto.Size = new System.Drawing.Size(130, 29);
            this.btnGuardarProducto.TabIndex = 18;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Depth = 0;
            this.txtCantidadStock.Hint = "Cantidad Stock";
            this.txtCantidadStock.Location = new System.Drawing.Point(41, 264);
            this.txtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.PasswordChar = '\0';
            this.txtCantidadStock.SelectedText = "";
            this.txtCantidadStock.SelectionLength = 0;
            this.txtCantidadStock.SelectionStart = 0;
            this.txtCantidadStock.Size = new System.Drawing.Size(210, 23);
            this.txtCantidadStock.TabIndex = 17;
            this.txtCantidadStock.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "Precio Venta";
            this.txtPrecioVenta.Location = new System.Drawing.Point(41, 220);
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(210, 23);
            this.txtPrecioVenta.TabIndex = 16;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio Compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(41, 176);
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(210, 23);
            this.txtPrecioCompra.TabIndex = 15;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtCodigoRef
            // 
            this.txtCodigoRef.Depth = 0;
            this.txtCodigoRef.Hint = "Código Referencia";
            this.txtCodigoRef.Location = new System.Drawing.Point(41, 132);
            this.txtCodigoRef.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoRef.Name = "txtCodigoRef";
            this.txtCodigoRef.PasswordChar = '\0';
            this.txtCodigoRef.SelectedText = "";
            this.txtCodigoRef.SelectionLength = 0;
            this.txtCodigoRef.SelectionStart = 0;
            this.txtCodigoRef.Size = new System.Drawing.Size(210, 23);
            this.txtCodigoRef.TabIndex = 14;
            this.txtCodigoRef.UseSystemPasswordChar = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "Nombre Producto";
            this.txtNombreProducto.Location = new System.Drawing.Point(41, 88);
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(210, 23);
            this.txtNombreProducto.TabIndex = 13;
            this.txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(419, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(329, 92);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 19);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoría";
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Depth = 0;
            this.txtRutaImagen.Hint = "Ruta Imagen";
            this.txtRutaImagen.Location = new System.Drawing.Point(333, 142);
            this.txtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.PasswordChar = '\0';
            this.txtRutaImagen.SelectedText = "";
            this.txtRutaImagen.SelectionLength = 0;
            this.txtRutaImagen.SelectionStart = 0;
            this.txtRutaImagen.Size = new System.Drawing.Size(243, 23);
            this.txtRutaImagen.TabIndex = 22;
            this.txtRutaImagen.UseSystemPasswordChar = false;
            // 
            // lblDetalleProducto
            // 
            this.lblDetalleProducto.AutoSize = true;
            this.lblDetalleProducto.Depth = 0;
            this.lblDetalleProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleProducto.Location = new System.Drawing.Point(329, 193);
            this.lblDetalleProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleProducto.Name = "lblDetalleProducto";
            this.lblDetalleProducto.Size = new System.Drawing.Size(120, 19);
            this.lblDetalleProducto.TabIndex = 23;
            this.lblDetalleProducto.Text = "Detalle producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 228);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 97);
            this.textBox1.TabIndex = 24;
            // 
            // lblDatosProductos
            // 
            this.lblDatosProductos.AutoSize = true;
            this.lblDatosProductos.Depth = 0;
            this.lblDatosProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosProductos.Location = new System.Drawing.Point(239, 30);
            this.lblDatosProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosProductos.Name = "lblDatosProductos";
            this.lblDatosProductos.Size = new System.Drawing.Size(147, 19);
            this.lblDatosProductos.TabIndex = 25;
            this.lblDatosProductos.Text = "DATOS PRODUCTOS";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 418);
            this.Controls.Add(this.lblDatosProductos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDetalleProducto);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtCodigoRef);
            this.Controls.Add(this.txtNombreProducto);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidadStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoRef;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaImagen;
        private MaterialSkin.Controls.MaterialLabel lblDetalleProducto;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel lblDatosProductos;
    }
}