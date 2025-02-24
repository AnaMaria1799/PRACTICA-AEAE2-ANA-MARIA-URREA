namespace Plantilla_Sistema_facturacion
{
    partial class frmInformes
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
            this.lblGeneradorInformes = new MaterialSkin.Controls.MaterialLabel();
            this.lblSeleccioneInforme = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblOrdenarPor = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaFinal = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rbEnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lblGeneradorInformes
            // 
            this.lblGeneradorInformes.AutoSize = true;
            this.lblGeneradorInformes.Depth = 0;
            this.lblGeneradorInformes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGeneradorInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGeneradorInformes.Location = new System.Drawing.Point(209, 47);
            this.lblGeneradorInformes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGeneradorInformes.Name = "lblGeneradorInformes";
            this.lblGeneradorInformes.Size = new System.Drawing.Size(324, 19);
            this.lblGeneradorInformes.TabIndex = 13;
            this.lblGeneradorInformes.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // lblSeleccioneInforme
            // 
            this.lblSeleccioneInforme.AutoSize = true;
            this.lblSeleccioneInforme.Depth = 0;
            this.lblSeleccioneInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSeleccioneInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSeleccioneInforme.Location = new System.Drawing.Point(28, 128);
            this.lblSeleccioneInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccioneInforme.Name = "lblSeleccioneInforme";
            this.lblSeleccioneInforme.Size = new System.Drawing.Size(166, 19);
            this.lblSeleccioneInforme.TabIndex = 14;
            this.lblSeleccioneInforme.Text = "SELECCIONE INFORME";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.Depth = 0;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOrdenarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrdenarPor.Location = new System.Drawing.Point(420, 131);
            this.lblOrdenarPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(91, 19);
            this.lblOrdenarPor.TabIndex = 31;
            this.lblOrdenarPor.Text = "Ordenar por:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(533, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 21);
            this.comboBox2.TabIndex = 32;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(84, 196);
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(90, 19);
            this.lblFechaInicio.TabIndex = 33;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaFinal.Location = new System.Drawing.Point(385, 196);
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(85, 19);
            this.lblFechaFinal.TabIndex = 34;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(480, 195);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // BtnGenerarInforme
            // 
            this.BtnGenerarInforme.Depth = 0;
            this.BtnGenerarInforme.Location = new System.Drawing.Point(150, 334);
            this.BtnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGenerarInforme.Name = "BtnGenerarInforme";
            this.BtnGenerarInforme.Primary = true;
            this.BtnGenerarInforme.Size = new System.Drawing.Size(165, 34);
            this.BtnGenerarInforme.TabIndex = 39;
            this.BtnGenerarInforme.Text = "Generar Informe";
            this.BtnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(416, 334);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(104, 34);
            this.BtnSalir.TabIndex = 40;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // rbEnPantalla
            // 
            this.rbEnPantalla.AutoSize = true;
            this.rbEnPantalla.Depth = 0;
            this.rbEnPantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbEnPantalla.Location = new System.Drawing.Point(229, 263);
            this.rbEnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rbEnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEnPantalla.Name = "rbEnPantalla";
            this.rbEnPantalla.Ripple = true;
            this.rbEnPantalla.Size = new System.Drawing.Size(97, 30);
            this.rbEnPantalla.TabIndex = 41;
            this.rbEnPantalla.TabStop = true;
            this.rbEnPantalla.Text = "En pantalla";
            this.rbEnPantalla.UseVisualStyleBackColor = true;
            // 
            // rbPdf
            // 
            this.rbPdf.AutoSize = true;
            this.rbPdf.Depth = 0;
            this.rbPdf.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbPdf.Location = new System.Drawing.Point(337, 263);
            this.rbPdf.Margin = new System.Windows.Forms.Padding(0);
            this.rbPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Ripple = true;
            this.rbPdf.Size = new System.Drawing.Size(54, 30);
            this.rbPdf.TabIndex = 42;
            this.rbPdf.TabStop = true;
            this.rbPdf.Text = "PDF";
            this.rbPdf.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Depth = 0;
            this.rbExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbExcel.Location = new System.Drawing.Point(408, 263);
            this.rbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Ripple = true;
            this.rbExcel.Size = new System.Drawing.Size(62, 30);
            this.rbExcel.TabIndex = 43;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "Excel";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 568);
            this.Controls.Add(this.rbExcel);
            this.Controls.Add(this.rbPdf);
            this.Controls.Add(this.rbEnPantalla);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGenerarInforme);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblOrdenarPor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSeleccioneInforme);
            this.Controls.Add(this.lblGeneradorInformes);
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblGeneradorInformes;
        private MaterialSkin.Controls.MaterialLabel lblSeleccioneInforme;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel lblOrdenarPor;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialLabel lblFechaInicio;
        private MaterialSkin.Controls.MaterialLabel lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRadioButton rbEnPantalla;
        private MaterialSkin.Controls.MaterialRadioButton rbPdf;
        private MaterialSkin.Controls.MaterialRadioButton rbExcel;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}