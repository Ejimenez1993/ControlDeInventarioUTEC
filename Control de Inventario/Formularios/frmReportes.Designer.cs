
namespace Control_de_Inventario.Formularios
{
    partial class frmReportes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grupBoxTipoTrasaccion = new System.Windows.Forms.GroupBox();
            this.rBtnTodo = new System.Windows.Forms.RadioButton();
            this.rBtnAjusteSalida = new System.Windows.Forms.RadioButton();
            this.rBtnAjusteEntrada = new System.Windows.Forms.RadioButton();
            this.rBtnEmitir = new System.Windows.Forms.RadioButton();
            this.DateHasta = new System.Windows.Forms.DateTimePicker();
            this.DateDesde = new System.Windows.Forms.DateTimePicker();
            this.Desde = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIDArticulo = new System.Windows.Forms.Button();
            this.btnIDTransaccion = new System.Windows.Forms.Button();
            this.txtIDArticulo = new System.Windows.Forms.TextBox();
            this.txtIDTransaccion = new System.Windows.Forms.TextBox();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.btnBodega = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grupBoxTipoTrasaccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBodega);
            this.panel1.Controls.Add(this.btnBodega);
            this.panel1.Controls.Add(this.btnIDArticulo);
            this.panel1.Controls.Add(this.btnIDTransaccion);
            this.panel1.Controls.Add(this.txtIDArticulo);
            this.panel1.Controls.Add(this.txtIDTransaccion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Desde);
            this.panel1.Controls.Add(this.DateDesde);
            this.panel1.Controls.Add(this.DateHasta);
            this.panel1.Controls.Add(this.grupBoxTipoTrasaccion);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 356);
            this.panel1.TabIndex = 0;
            // 
            // grupBoxTipoTrasaccion
            // 
            this.grupBoxTipoTrasaccion.Controls.Add(this.rBtnTodo);
            this.grupBoxTipoTrasaccion.Controls.Add(this.rBtnAjusteSalida);
            this.grupBoxTipoTrasaccion.Controls.Add(this.rBtnAjusteEntrada);
            this.grupBoxTipoTrasaccion.Controls.Add(this.rBtnEmitir);
            this.grupBoxTipoTrasaccion.Location = new System.Drawing.Point(21, 183);
            this.grupBoxTipoTrasaccion.Name = "grupBoxTipoTrasaccion";
            this.grupBoxTipoTrasaccion.Size = new System.Drawing.Size(317, 154);
            this.grupBoxTipoTrasaccion.TabIndex = 10;
            this.grupBoxTipoTrasaccion.TabStop = false;
            this.grupBoxTipoTrasaccion.Text = "Tipo de transacción";
            // 
            // rBtnTodo
            // 
            this.rBtnTodo.AutoSize = true;
            this.rBtnTodo.Location = new System.Drawing.Point(6, 97);
            this.rBtnTodo.Name = "rBtnTodo";
            this.rBtnTodo.Size = new System.Drawing.Size(51, 19);
            this.rBtnTodo.TabIndex = 13;
            this.rBtnTodo.TabStop = true;
            this.rBtnTodo.Text = "Todo";
            this.rBtnTodo.UseVisualStyleBackColor = true;
            // 
            // rBtnAjusteSalida
            // 
            this.rBtnAjusteSalida.AutoSize = true;
            this.rBtnAjusteSalida.Location = new System.Drawing.Point(6, 72);
            this.rBtnAjusteSalida.Name = "rBtnAjusteSalida";
            this.rBtnAjusteSalida.Size = new System.Drawing.Size(94, 19);
            this.rBtnAjusteSalida.TabIndex = 12;
            this.rBtnAjusteSalida.TabStop = true;
            this.rBtnAjusteSalida.Text = "Ajuste/Salida";
            this.rBtnAjusteSalida.UseVisualStyleBackColor = true;
            // 
            // rBtnAjusteEntrada
            // 
            this.rBtnAjusteEntrada.AutoSize = true;
            this.rBtnAjusteEntrada.Location = new System.Drawing.Point(6, 47);
            this.rBtnAjusteEntrada.Name = "rBtnAjusteEntrada";
            this.rBtnAjusteEntrada.Size = new System.Drawing.Size(103, 19);
            this.rBtnAjusteEntrada.TabIndex = 11;
            this.rBtnAjusteEntrada.TabStop = true;
            this.rBtnAjusteEntrada.Text = "Ajuste/Entrada";
            this.rBtnAjusteEntrada.UseVisualStyleBackColor = true;
            // 
            // rBtnEmitir
            // 
            this.rBtnEmitir.AutoSize = true;
            this.rBtnEmitir.Location = new System.Drawing.Point(6, 22);
            this.rBtnEmitir.Name = "rBtnEmitir";
            this.rBtnEmitir.Size = new System.Drawing.Size(56, 19);
            this.rBtnEmitir.TabIndex = 10;
            this.rBtnEmitir.TabStop = true;
            this.rBtnEmitir.Text = "Emitir";
            this.rBtnEmitir.UseVisualStyleBackColor = true;
            // 
            // DateHasta
            // 
            this.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateHasta.Location = new System.Drawing.Point(235, 127);
            this.DateHasta.Name = "DateHasta";
            this.DateHasta.Size = new System.Drawing.Size(103, 23);
            this.DateHasta.TabIndex = 11;
            // 
            // DateDesde
            // 
            this.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDesde.Location = new System.Drawing.Point(70, 127);
            this.DateDesde.Name = "DateDesde";
            this.DateDesde.Size = new System.Drawing.Size(103, 23);
            this.DateDesde.TabIndex = 12;
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Desde.Location = new System.Drawing.Point(21, 132);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(43, 15);
            this.Desde.TabIndex = 13;
            this.Desde.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(190, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta";
            // 
            // btnIDArticulo
            // 
            this.btnIDArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIDArticulo.Location = new System.Drawing.Point(21, 49);
            this.btnIDArticulo.Name = "btnIDArticulo";
            this.btnIDArticulo.Size = new System.Drawing.Size(125, 26);
            this.btnIDArticulo.TabIndex = 18;
            this.btnIDArticulo.Text = "ID Artículo";
            this.btnIDArticulo.UseVisualStyleBackColor = true;
            // 
            // btnIDTransaccion
            // 
            this.btnIDTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIDTransaccion.Location = new System.Drawing.Point(21, 17);
            this.btnIDTransaccion.Name = "btnIDTransaccion";
            this.btnIDTransaccion.Size = new System.Drawing.Size(125, 26);
            this.btnIDTransaccion.TabIndex = 17;
            this.btnIDTransaccion.Text = "ID Transacción";
            this.btnIDTransaccion.UseVisualStyleBackColor = true;
            // 
            // txtIDArticulo
            // 
            this.txtIDArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDArticulo.Location = new System.Drawing.Point(152, 52);
            this.txtIDArticulo.Name = "txtIDArticulo";
            this.txtIDArticulo.Size = new System.Drawing.Size(186, 21);
            this.txtIDArticulo.TabIndex = 16;
            // 
            // txtIDTransaccion
            // 
            this.txtIDTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDTransaccion.Location = new System.Drawing.Point(152, 20);
            this.txtIDTransaccion.Name = "txtIDTransaccion";
            this.txtIDTransaccion.Size = new System.Drawing.Size(186, 21);
            this.txtIDTransaccion.TabIndex = 15;
            // 
            // txtBodega
            // 
            this.txtBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBodega.Location = new System.Drawing.Point(152, 84);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(186, 21);
            this.txtBodega.TabIndex = 20;
            // 
            // btnBodega
            // 
            this.btnBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBodega.Location = new System.Drawing.Point(21, 81);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(125, 26);
            this.btnBodega.TabIndex = 19;
            this.btnBodega.Text = "Bodega";
            this.btnBodega.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(12, 374);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(103, 43);
            this.btnGenerar.TabIndex = 16;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.Location = new System.Drawing.Point(138, 374);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 43);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(264, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 43);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(379, 433);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.panel1);
            this.Name = "Reportes";
            this.Text = "PROLAC - Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupBoxTipoTrasaccion.ResumeLayout(false);
            this.grupBoxTipoTrasaccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grupBoxTipoTrasaccion;
        private System.Windows.Forms.RadioButton rBtnTodo;
        private System.Windows.Forms.RadioButton rBtnAjusteSalida;
        private System.Windows.Forms.RadioButton rBtnAjusteEntrada;
        private System.Windows.Forms.RadioButton rBtnEmitir;
        private System.Windows.Forms.DateTimePicker DateDesde;
        private System.Windows.Forms.DateTimePicker DateHasta;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIDArticulo;
        private System.Windows.Forms.Button btnIDTransaccion;
        private System.Windows.Forms.TextBox txtIDArticulo;
        private System.Windows.Forms.TextBox txtIDTransaccion;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.Button btnBodega;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
    }
}