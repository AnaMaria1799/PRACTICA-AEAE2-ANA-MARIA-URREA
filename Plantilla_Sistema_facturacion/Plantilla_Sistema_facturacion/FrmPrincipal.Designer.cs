namespace Plantilla_Sistema_facturacion
{
    partial class FrmPrincipal
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
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.TpbMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.Tablas = new System.Windows.Forms.TabPage();
            this.Facturacion = new System.Windows.Forms.TabPage();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.Acerca = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnlPrincipal.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.TpbMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            this.Tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.PnlContenedor);
            this.PnlPrincipal.Controls.Add(this.PnlMenu);
            this.PnlPrincipal.Location = new System.Drawing.Point(-1, 61);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1203, 591);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.TpbMenu);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(328, 591);
            this.PnlMenu.TabIndex = 0;
            // 
            // TpbMenu
            // 
            this.TpbMenu.Controls.Add(this.Principal);
            this.TpbMenu.Controls.Add(this.Tablas);
            this.TpbMenu.Controls.Add(this.Facturacion);
            this.TpbMenu.Controls.Add(this.Seguridad);
            this.TpbMenu.Controls.Add(this.Acerca);
            this.TpbMenu.Depth = 0;
            this.TpbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpbMenu.Location = new System.Drawing.Point(0, 0);
            this.TpbMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TpbMenu.Name = "TpbMenu";
            this.TpbMenu.SelectedIndex = 0;
            this.TpbMenu.Size = new System.Drawing.Size(328, 591);
            this.TpbMenu.TabIndex = 1;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Principal.Controls.Add(this.btnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(320, 565);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // Tablas
            // 
            this.Tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tablas.Controls.Add(this.btnClientes);
            this.Tablas.Controls.Add(this.pictureBox2);
            this.Tablas.Location = new System.Drawing.Point(4, 22);
            this.Tablas.Name = "Tablas";
            this.Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tablas.Size = new System.Drawing.Size(320, 565);
            this.Tablas.TabIndex = 1;
            this.Tablas.Text = "Admin Tablas";
            // 
            // Facturacion
            // 
            this.Facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Facturacion.Location = new System.Drawing.Point(4, 22);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Size = new System.Drawing.Size(320, 565);
            this.Facturacion.TabIndex = 2;
            this.Facturacion.Text = "Facturacion";
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Seguridad.Location = new System.Drawing.Point(4, 22);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(320, 565);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // Acerca
            // 
            this.Acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Acerca.Location = new System.Drawing.Point(4, 22);
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(320, 565);
            this.Acerca.TabIndex = 4;
            this.Acerca.Text = "Acerca de";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(467, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabOpcionesMenu
            // 
            this.tabOpcionesMenu.BaseTabControl = this.TpbMenu;
            this.tabOpcionesMenu.Depth = 0;
            this.tabOpcionesMenu.Location = new System.Drawing.Point(447, 37);
            this.tabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionesMenu.Name = "tabOpcionesMenu";
            this.tabOpcionesMenu.Size = new System.Drawing.Size(646, 23);
            this.tabOpcionesMenu.TabIndex = 1;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(328, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(875, 591);
            this.PnlContenedor.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Plantilla_Sistema_facturacion.Properties.Resources.logout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(84, 327);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 49);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Plantilla_Sistema_facturacion.Properties.Resources.business_company_logo_C561B48365_seeklogo_com;
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 238);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::Plantilla_Sistema_facturacion.Properties.Resources.customer;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(39, 303);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(132, 49);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Plantilla_Sistema_facturacion.Properties.Resources.business_company_logo_C561B48365_seeklogo_com;
            this.pictureBox2.Location = new System.Drawing.Point(9, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(424, 238);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabOpcionesMenu);
            this.Controls.Add(this.PnlPrincipal);
            this.Name = "FrmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACIÓN";
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.TpbMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.Tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabControl TpbMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage Tablas;
        private MaterialSkin.Controls.MaterialTabSelector tabOpcionesMenu;
        private System.Windows.Forms.TabPage Facturacion;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Acerca;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PnlContenedor;
    }
}