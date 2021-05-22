
namespace TP2
{
    partial class FormAdministrators
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
            this.grid_usuarios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_modificar_usuario = new System.Windows.Forms.Button();
            this.button_elimina_usuario = new System.Windows.Forms.Button();
            this.button_desbloquear_usuario = new System.Windows.Forms.Button();
            this.grid_reservas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_elimina_reserva = new System.Windows.Forms.Button();
            this.button_modificar_reserva = new System.Windows.Forms.Button();
            this.grid_alojamientos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_agregar_alojamiento = new System.Windows.Forms.Button();
            this.button_quitar_alojamiento = new System.Windows.Forms.Button();
            this.button_modificar_alojamiento = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alojamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_usuarios
            // 
            this.grid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Estado,
            this.DNI,
            this.Mail,
            this.EsAdmin});
            this.grid_usuarios.Location = new System.Drawing.Point(31, 112);
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.RowTemplate.Height = 25;
            this.grid_usuarios.Size = new System.Drawing.Size(549, 92);
            this.grid_usuarios.TabIndex = 0;
            this.grid_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // EsAdmin
            // 
            this.EsAdmin.HeaderText = "EsAdmin";
            this.EsAdmin.Name = "EsAdmin";
            // 
            // button_modificar_usuario
            // 
            this.button_modificar_usuario.Location = new System.Drawing.Point(590, 134);
            this.button_modificar_usuario.Name = "button_modificar_usuario";
            this.button_modificar_usuario.Size = new System.Drawing.Size(87, 38);
            this.button_modificar_usuario.TabIndex = 1;
            this.button_modificar_usuario.Text = "Modificar";
            this.button_modificar_usuario.UseVisualStyleBackColor = true;
            this.button_modificar_usuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_elimina_usuario
            // 
            this.button_elimina_usuario.Location = new System.Drawing.Point(683, 134);
            this.button_elimina_usuario.Name = "button_elimina_usuario";
            this.button_elimina_usuario.Size = new System.Drawing.Size(88, 38);
            this.button_elimina_usuario.TabIndex = 2;
            this.button_elimina_usuario.Text = "Eliminar";
            this.button_elimina_usuario.UseVisualStyleBackColor = true;
            // 
            // button_desbloquear_usuario
            // 
            this.button_desbloquear_usuario.Location = new System.Drawing.Point(786, 134);
            this.button_desbloquear_usuario.Name = "button_desbloquear_usuario";
            this.button_desbloquear_usuario.Size = new System.Drawing.Size(93, 38);
            this.button_desbloquear_usuario.TabIndex = 3;
            this.button_desbloquear_usuario.Text = "Desbloquear";
            this.button_desbloquear_usuario.UseVisualStyleBackColor = true;
            // 
            // grid_reservas
            // 
            this.grid_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_reservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Precio});
            this.grid_reservas.Location = new System.Drawing.Point(31, 254);
            this.grid_reservas.Name = "grid_reservas";
            this.grid_reservas.RowTemplate.Height = 25;
            this.grid_reservas.Size = new System.Drawing.Size(646, 92);
            this.grid_reservas.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "FDesde";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "FHasta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Propiedad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // button_elimina_reserva
            // 
            this.button_elimina_reserva.Location = new System.Drawing.Point(795, 279);
            this.button_elimina_reserva.Name = "button_elimina_reserva";
            this.button_elimina_reserva.Size = new System.Drawing.Size(94, 38);
            this.button_elimina_reserva.TabIndex = 6;
            this.button_elimina_reserva.Text = "Eliminar";
            this.button_elimina_reserva.UseVisualStyleBackColor = true;
            // 
            // button_modificar_reserva
            // 
            this.button_modificar_reserva.Location = new System.Drawing.Point(691, 279);
            this.button_modificar_reserva.Name = "button_modificar_reserva";
            this.button_modificar_reserva.Size = new System.Drawing.Size(98, 38);
            this.button_modificar_reserva.TabIndex = 5;
            this.button_modificar_reserva.Text = "Modificar";
            this.button_modificar_reserva.UseVisualStyleBackColor = true;
            // 
            // grid_alojamientos
            // 
            this.grid_alojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_alojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.grid_alojamientos.Location = new System.Drawing.Point(31, 411);
            this.grid_alojamientos.Name = "grid_alojamientos";
            this.grid_alojamientos.RowTemplate.Height = 25;
            this.grid_alojamientos.Size = new System.Drawing.Size(646, 92);
            this.grid_alojamientos.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Barrio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Estrellas";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "CantPersonas";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "TV";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // button_agregar_alojamiento
            // 
            this.button_agregar_alojamiento.Location = new System.Drawing.Point(691, 433);
            this.button_agregar_alojamiento.Name = "button_agregar_alojamiento";
            this.button_agregar_alojamiento.Size = new System.Drawing.Size(88, 38);
            this.button_agregar_alojamiento.TabIndex = 10;
            this.button_agregar_alojamiento.Text = "Agregar";
            this.button_agregar_alojamiento.UseVisualStyleBackColor = true;
            this.button_agregar_alojamiento.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_quitar_alojamiento
            // 
            this.button_quitar_alojamiento.Location = new System.Drawing.Point(878, 433);
            this.button_quitar_alojamiento.Name = "button_quitar_alojamiento";
            this.button_quitar_alojamiento.Size = new System.Drawing.Size(80, 38);
            this.button_quitar_alojamiento.TabIndex = 9;
            this.button_quitar_alojamiento.Text = "Quitar";
            this.button_quitar_alojamiento.UseVisualStyleBackColor = true;
            this.button_quitar_alojamiento.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_modificar_alojamiento
            // 
            this.button_modificar_alojamiento.Location = new System.Drawing.Point(786, 433);
            this.button_modificar_alojamiento.Name = "button_modificar_alojamiento";
            this.button_modificar_alojamiento.Size = new System.Drawing.Size(84, 38);
            this.button_modificar_alojamiento.TabIndex = 8;
            this.button_modificar_alojamiento.Text = "Modificar";
            this.button_modificar_alojamiento.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Usuarios:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 23);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Reservas:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 382);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 23);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Alojamientos:";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(831, 12);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(105, 39);
            this.button_logout.TabIndex = 14;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // FormAdministrators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(34)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_agregar_alojamiento);
            this.Controls.Add(this.button_quitar_alojamiento);
            this.Controls.Add(this.button_modificar_alojamiento);
            this.Controls.Add(this.grid_alojamientos);
            this.Controls.Add(this.button_elimina_reserva);
            this.Controls.Add(this.button_modificar_reserva);
            this.Controls.Add(this.grid_reservas);
            this.Controls.Add(this.button_desbloquear_usuario);
            this.Controls.Add(this.button_elimina_usuario);
            this.Controls.Add(this.button_modificar_usuario);
            this.Controls.Add(this.grid_usuarios);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormAdministrators";
            this.Text = "Alojamientos:";
            this.Load += new System.EventHandler(this.FormAdministrators_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alojamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_usuarios;
        private System.Windows.Forms.Button button_modificar_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsAdmin;
        private System.Windows.Forms.Button button_elimina_usuario;
        private System.Windows.Forms.Button button_desbloquear_usuario;
        private System.Windows.Forms.DataGridView grid_reservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button button_elimina_reserva;
        private System.Windows.Forms.Button button_modificar_reserva;
        private System.Windows.Forms.DataGridView grid_alojamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button_agregar_alojamiento;
        private System.Windows.Forms.Button button_quitar_alojamiento;
        private System.Windows.Forms.Button button_modificar_alojamiento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_logout;
    }
}