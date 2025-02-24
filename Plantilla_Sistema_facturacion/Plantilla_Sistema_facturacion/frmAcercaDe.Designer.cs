namespace Plantilla_Sistema_facturacion
{
    partial class frmAcercaDe
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAcercaDeSistema = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 283);
            this.textBox1.TabIndex = 5;
            // 
            // lblAcercaDeSistema
            // 
            this.lblAcercaDeSistema.AutoSize = true;
            this.lblAcercaDeSistema.Depth = 0;
            this.lblAcercaDeSistema.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAcercaDeSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAcercaDeSistema.Location = new System.Drawing.Point(55, 48);
            this.lblAcercaDeSistema.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAcercaDeSistema.Name = "lblAcercaDeSistema";
            this.lblAcercaDeSistema.Size = new System.Drawing.Size(293, 19);
            this.lblAcercaDeSistema.TabIndex = 4;
            this.lblAcercaDeSistema.Text = "ACERCA DEL SISTEMA DE FACTURACIÓN";
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAcercaDeSistema);
            this.Name = "frmAcercaDe";
            this.Text = "frmAcercaDe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel lblAcercaDeSistema;
    }
}