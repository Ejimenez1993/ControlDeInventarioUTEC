
namespace Control_de_Inventario.Formularios
{
    partial class frmArticulos
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
            this.labelNombreArticulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboIdEnvase = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelRol = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboUM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIdAlmacenaje = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgIdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgIdEnvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgIdAlmacenaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreArticulo
            // 
            this.labelNombreArticulo.AutoSize = true;
            this.labelNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombreArticulo.Location = new System.Drawing.Point(12, 53);
            this.labelNombreArticulo.Name = "labelNombreArticulo";
            this.labelNombreArticulo.Size = new System.Drawing.Size(62, 15);
            this.labelNombreArticulo.TabIndex = 14;
            this.labelNombreArticulo.Text = "ID artículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(445, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha de vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(237, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(238, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Envase";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(90, 48);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(142, 23);
            this.txtCodigoArticulo.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(90, 83);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(142, 23);
            this.txtDescripcion.TabIndex = 21;
            // 
            // cboIdEnvase
            // 
            this.cboIdEnvase.FormattingEnabled = true;
            this.cboIdEnvase.Location = new System.Drawing.Point(291, 83);
            this.cboIdEnvase.Name = "cboIdEnvase";
            this.cboIdEnvase.Size = new System.Drawing.Size(115, 23);
            this.cboIdEnvase.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(296, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 23);
            this.txtNombre.TabIndex = 24;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(578, 48);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(142, 23);
            this.dtpFechaVencimiento.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(300, 156);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 23);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(204, 156);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 23);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 156);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(108, 156);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(396, 156);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 23);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgIdArticulo,
            this.dtgIdEnvase,
            this.dtgUM,
            this.dtgIdAlmacenaje,
            this.dtgNombre,
            this.dtgDescripcion,
            this.dtgFechaCreacion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(719, 251);
            this.dataGridView1.TabIndex = 31;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRol.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelRol.Location = new System.Drawing.Point(284, 9);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(36, 20);
            this.labelRol.TabIndex = 35;
            this.labelRol.Text = "Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(237, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Rol: ";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelUsuario.Location = new System.Drawing.Point(90, 9);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(71, 20);
            this.labelUsuario.TabIndex = 33;
            this.labelUsuario.Text = "Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Usuario: ";
            // 
            // cboUM
            // 
            this.cboUM.FormattingEnabled = true;
            this.cboUM.Location = new System.Drawing.Point(445, 83);
            this.cboUM.Name = "cboUM";
            this.cboUM.Size = new System.Drawing.Size(84, 23);
            this.cboUM.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(412, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "U/M";
            // 
            // cboIdAlmacenaje
            // 
            this.cboIdAlmacenaje.FormattingEnabled = true;
            this.cboIdAlmacenaje.Location = new System.Drawing.Point(613, 83);
            this.cboIdAlmacenaje.Name = "cboIdAlmacenaje";
            this.cboIdAlmacenaje.Size = new System.Drawing.Size(107, 23);
            this.cboIdAlmacenaje.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(535, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Almacenaje";
            // 
            // dtgIdArticulo
            // 
            this.dtgIdArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtgIdArticulo.HeaderText = "ID Art.";
            this.dtgIdArticulo.Name = "dtgIdArticulo";
            this.dtgIdArticulo.ReadOnly = true;
            this.dtgIdArticulo.Width = 65;
            // 
            // dtgIdEnvase
            // 
            this.dtgIdEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtgIdEnvase.HeaderText = "ID envase";
            this.dtgIdEnvase.Name = "dtgIdEnvase";
            this.dtgIdEnvase.ReadOnly = true;
            this.dtgIdEnvase.Width = 82;
            // 
            // dtgUM
            // 
            this.dtgUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtgUM.HeaderText = "U_M";
            this.dtgUM.Name = "dtgUM";
            this.dtgUM.ReadOnly = true;
            this.dtgUM.Width = 56;
            // 
            // dtgIdAlmacenaje
            // 
            this.dtgIdAlmacenaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtgIdAlmacenaje.HeaderText = "ID almacenaje";
            this.dtgIdAlmacenaje.Name = "dtgIdAlmacenaje";
            this.dtgIdAlmacenaje.ReadOnly = true;
            this.dtgIdAlmacenaje.Width = 106;
            // 
            // dtgNombre
            // 
            this.dtgNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtgNombre.HeaderText = "Nombre";
            this.dtgNombre.Name = "dtgNombre";
            this.dtgNombre.ReadOnly = true;
            this.dtgNombre.Width = 76;
            // 
            // dtgDescripcion
            // 
            this.dtgDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtgDescripcion.HeaderText = "Descripción";
            this.dtgDescripcion.Name = "dtgDescripcion";
            this.dtgDescripcion.ReadOnly = true;
            this.dtgDescripcion.Width = 94;
            // 
            // dtgFechaCreacion
            // 
            this.dtgFechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtgFechaCreacion.HeaderText = "Fecha de Creación";
            this.dtgFechaCreacion.Name = "dtgFechaCreacion";
            this.dtgFechaCreacion.ReadOnly = true;
            this.dtgFechaCreacion.Width = 106;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(748, 477);
            this.Controls.Add(this.cboIdAlmacenaje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboUM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboIdEnvase);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombreArticulo);
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.Text = "PROCLAC - Artículos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboIdEnvase;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboIdAlmacenaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgIdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgIdEnvase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgIdAlmacenaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgFechaCreacion;
    }
}