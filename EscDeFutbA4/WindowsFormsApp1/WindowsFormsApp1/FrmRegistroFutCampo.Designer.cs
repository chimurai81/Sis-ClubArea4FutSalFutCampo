﻿namespace WindowsFormsApp1
{
    partial class FrmRegistroFutCampo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroFutCampo));
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtEdadActual = new System.Windows.Forms.TextBox();
            this.btnCancelatFotoRegistro = new System.Windows.Forms.Button();
            this.btnAggFotoRegistro = new System.Windows.Forms.Button();
            this.ptbFotoRegistros = new System.Windows.Forms.PictureBox();
            this.dtpFechNac = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(335, 506);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(528, 46);
            this.txtCategoria.TabIndex = 381;
            this.txtCategoria.Text = "CATEGORIA";
            this.txtCategoria.Click += new System.EventHandler(this.txtCategoria_Click);
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // txtEdadActual
            // 
            this.txtEdadActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadActual.Location = new System.Drawing.Point(335, 449);
            this.txtEdadActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdadActual.Multiline = true;
            this.txtEdadActual.Name = "txtEdadActual";
            this.txtEdadActual.Size = new System.Drawing.Size(528, 46);
            this.txtEdadActual.TabIndex = 372;
            this.txtEdadActual.Text = "EDAD ACTUAL";
            this.txtEdadActual.Click += new System.EventHandler(this.txtEdadActual_Click);
            // 
            // btnCancelatFotoRegistro
            // 
            this.btnCancelatFotoRegistro.BackColor = System.Drawing.Color.Gray;
            this.btnCancelatFotoRegistro.FlatAppearance.BorderSize = 0;
            this.btnCancelatFotoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelatFotoRegistro.ForeColor = System.Drawing.Color.White;
            this.btnCancelatFotoRegistro.Location = new System.Drawing.Point(1222, 207);
            this.btnCancelatFotoRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelatFotoRegistro.Name = "btnCancelatFotoRegistro";
            this.btnCancelatFotoRegistro.Size = new System.Drawing.Size(39, 28);
            this.btnCancelatFotoRegistro.TabIndex = 377;
            this.btnCancelatFotoRegistro.Text = "X";
            this.btnCancelatFotoRegistro.UseVisualStyleBackColor = false;
            this.btnCancelatFotoRegistro.Click += new System.EventHandler(this.btnCancelatFotoRegistro_Click);
            // 
            // btnAggFotoRegistro
            // 
            this.btnAggFotoRegistro.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAggFotoRegistro.FlatAppearance.BorderSize = 0;
            this.btnAggFotoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggFotoRegistro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAggFotoRegistro.Location = new System.Drawing.Point(1012, 500);
            this.btnAggFotoRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggFotoRegistro.Name = "btnAggFotoRegistro";
            this.btnAggFotoRegistro.Size = new System.Drawing.Size(109, 28);
            this.btnAggFotoRegistro.TabIndex = 376;
            this.btnAggFotoRegistro.Text = "Seleccionar";
            this.btnAggFotoRegistro.UseVisualStyleBackColor = false;
            this.btnAggFotoRegistro.Click += new System.EventHandler(this.btnAggFotoRegistro_Click);
            // 
            // ptbFotoRegistros
            // 
            this.ptbFotoRegistros.Image = ((System.Drawing.Image)(resources.GetObject("ptbFotoRegistros.Image")));
            this.ptbFotoRegistros.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbFotoRegistros.InitialImage")));
            this.ptbFotoRegistros.Location = new System.Drawing.Point(898, 207);
            this.ptbFotoRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.ptbFotoRegistros.Name = "ptbFotoRegistros";
            this.ptbFotoRegistros.Size = new System.Drawing.Size(325, 286);
            this.ptbFotoRegistros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFotoRegistros.TabIndex = 379;
            this.ptbFotoRegistros.TabStop = false;
            // 
            // dtpFechNac
            // 
            this.dtpFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechNac.Location = new System.Drawing.Point(335, 411);
            this.dtpFechNac.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechNac.Name = "dtpFechNac";
            this.dtpFechNac.Size = new System.Drawing.Size(528, 30);
            this.dtpFechNac.TabIndex = 371;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(335, 357);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(528, 46);
            this.txtTelefono.TabIndex = 370;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(465, 637);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 49);
            this.btnNuevo.TabIndex = 375;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(587, 637);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 49);
            this.button3.TabIndex = 374;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(335, 560);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(528, 46);
            this.txtDireccion.TabIndex = 373;
            this.txtDireccion.Text = "Direccion";
            this.txtDireccion.Click += new System.EventHandler(this.txtDireccion_Click);
            // 
            // txtApelido
            // 
            this.txtApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApelido.Location = new System.Drawing.Point(335, 307);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApelido.Multiline = true;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(528, 42);
            this.txtApelido.TabIndex = 369;
            this.txtApelido.Text = "Apellido";
            this.txtApelido.Click += new System.EventHandler(this.txtApelido_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(335, 255);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(528, 43);
            this.txtNombre.TabIndex = 368;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // txtCi
            // 
            this.txtCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCi.Location = new System.Drawing.Point(335, 207);
            this.txtCi.Margin = new System.Windows.Forms.Padding(4);
            this.txtCi.Multiline = true;
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(528, 43);
            this.txtCi.TabIndex = 367;
            this.txtCi.Text = "C.I.N°";
            this.txtCi.Click += new System.EventHandler(this.txtCi_Click);
            this.txtCi.TextChanged += new System.EventHandler(this.txtCi_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1145, 47);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 378;
            this.button2.Text = "CERRAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(353, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(701, 45);
            this.label2.TabIndex = 382;
            this.label2.Text = "REGISTRO DE FUTBOL DE CAMPO AREA 4";
            // 
            // FrmRegistroFutCampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(169)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1716, 877);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtEdadActual);
            this.Controls.Add(this.btnCancelatFotoRegistro);
            this.Controls.Add(this.btnAggFotoRegistro);
            this.Controls.Add(this.ptbFotoRegistros);
            this.Controls.Add(this.dtpFechNac);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.button2);
            this.Name = "FrmRegistroFutCampo";
            this.Text = "FrmRegistroFutCampo";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.TextBox txtEdadActual;
        private System.Windows.Forms.Button btnCancelatFotoRegistro;
        private System.Windows.Forms.Button btnAggFotoRegistro;
        public System.Windows.Forms.PictureBox ptbFotoRegistros;
        private System.Windows.Forms.DateTimePicker dtpFechNac;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtApelido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}