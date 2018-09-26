namespace ControlesPersonalizados.BasesDeDatos
{
    partial class DBConfig
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPuerto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbBaseDeDatos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos para configuración de base de datos";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servidor:";
            // 
            // txbServidor
            // 
            this.txbServidor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbServidor.Location = new System.Drawing.Point(137, 51);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(400, 26);
            this.txbServidor.TabIndex = 2;
            this.txbServidor.TextChanged += new System.EventHandler(this.txbServidor_TextChanged);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbUsuario.Location = new System.Drawing.Point(137, 83);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(250, 26);
            this.txbUsuario.TabIndex = 4;
            this.txbUsuario.TextChanged += new System.EventHandler(this.txbUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbContraseña.Location = new System.Drawing.Point(137, 115);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(250, 26);
            this.txbContraseña.TabIndex = 6;
            this.txbContraseña.TextChanged += new System.EventHandler(this.txbContraseña_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // txbPuerto
            // 
            this.txbPuerto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPuerto.Location = new System.Drawing.Point(137, 147);
            this.txbPuerto.Name = "txbPuerto";
            this.txbPuerto.Size = new System.Drawing.Size(100, 26);
            this.txbPuerto.TabIndex = 8;
            this.txbPuerto.TextChanged += new System.EventHandler(this.txbPuerto_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Puerto:";
            // 
            // txbBaseDeDatos
            // 
            this.txbBaseDeDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbBaseDeDatos.Location = new System.Drawing.Point(137, 179);
            this.txbBaseDeDatos.Name = "txbBaseDeDatos";
            this.txbBaseDeDatos.Size = new System.Drawing.Size(400, 26);
            this.txbBaseDeDatos.TabIndex = 10;
            this.txbBaseDeDatos.TextChanged += new System.EventHandler(this.txbBaseDeDatos_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Base de Datos:";
            // 
            // DBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbBaseDeDatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbPuerto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbServidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DBConfig";
            this.Size = new System.Drawing.Size(559, 215);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPuerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbBaseDeDatos;
        private System.Windows.Forms.Label label6;
    }
}
