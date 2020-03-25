namespace WindowsFormsApp1
{
    partial class FrmConsultaFutbolCampo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaFutbolCampo));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rboCategoria = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rboCiNro = new System.Windows.Forms.RadioButton();
            this.rboApellido = new System.Windows.Forms.RadioButton();
            this.rboNombre = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.txtEdadActual = new System.Windows.Forms.TextBox();
            this.btnCancelatFotoRegistro = new System.Windows.Forms.Button();
            this.btnAggFotoRegistro = new System.Windows.Forms.Button();
            this.ptbFotoRegistros = new System.Windows.Forms.PictureBox();
            this.dtpFechNac = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(428, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 45);
            this.label1.TabIndex = 422;
            this.label1.Text = "ALUMNOS DE FUTBOL DE CAMPO AREA 4";
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
            this.button2.Location = new System.Drawing.Point(1406, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 414;
            this.button2.Text = "CERRAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rboCategoria
            // 
            this.rboCategoria.AutoSize = true;
            this.rboCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rboCategoria.Location = new System.Drawing.Point(1196, 736);
            this.rboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.rboCategoria.Name = "rboCategoria";
            this.rboCategoria.Size = new System.Drawing.Size(90, 21);
            this.rboCategoria.TabIndex = 444;
            this.rboCategoria.TabStop = true;
            this.rboCategoria.Text = "Categoria";
            this.rboCategoria.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(20, 122);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(528, 43);
            this.txtId.TabIndex = 443;
            this.txtId.Text = "id";
            this.txtId.Visible = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(20, 469);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(528, 46);
            this.txtCategoria.TabIndex = 442;
            this.txtCategoria.Text = "CATEGORIA";
            this.txtCategoria.Click += new System.EventHandler(this.txtCategoria_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(272, 580);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 49);
            this.button4.TabIndex = 441;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1381, 706);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 25);
            this.button1.TabIndex = 440;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rboCiNro
            // 
            this.rboCiNro.AutoSize = true;
            this.rboCiNro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rboCiNro.Location = new System.Drawing.Point(1120, 736);
            this.rboCiNro.Margin = new System.Windows.Forms.Padding(4);
            this.rboCiNro.Name = "rboCiNro";
            this.rboCiNro.Size = new System.Drawing.Size(68, 21);
            this.rboCiNro.TabIndex = 439;
            this.rboCiNro.TabStop = true;
            this.rboCiNro.Text = "CI.Nro";
            this.rboCiNro.UseVisualStyleBackColor = true;
            // 
            // rboApellido
            // 
            this.rboApellido.AutoSize = true;
            this.rboApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rboApellido.Location = new System.Drawing.Point(1033, 736);
            this.rboApellido.Margin = new System.Windows.Forms.Padding(4);
            this.rboApellido.Name = "rboApellido";
            this.rboApellido.Size = new System.Drawing.Size(79, 21);
            this.rboApellido.TabIndex = 438;
            this.rboApellido.TabStop = true;
            this.rboApellido.Text = "Apellido";
            this.rboApellido.UseVisualStyleBackColor = true;
            // 
            // rboNombre
            // 
            this.rboNombre.AutoSize = true;
            this.rboNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rboNombre.Location = new System.Drawing.Point(946, 736);
            this.rboNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rboNombre.Name = "rboNombre";
            this.rboNombre.Size = new System.Drawing.Size(79, 21);
            this.rboNombre.TabIndex = 437;
            this.rboNombre.TabStop = true;
            this.rboNombre.Text = "Nombre";
            this.rboNombre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1034, 670);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 27);
            this.label3.TabIndex = 436;
            this.label3.Text = "BUSQUEDA DE ALUMNOS";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(899, 706);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(476, 22);
            this.TxtBuscar.TabIndex = 435;
            // 
            // txtEdadActual
            // 
            this.txtEdadActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadActual.Location = new System.Drawing.Point(20, 415);
            this.txtEdadActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdadActual.Multiline = true;
            this.txtEdadActual.Name = "txtEdadActual";
            this.txtEdadActual.Size = new System.Drawing.Size(528, 46);
            this.txtEdadActual.TabIndex = 429;
            this.txtEdadActual.Text = "EDAD ACTUAL";
            this.txtEdadActual.Click += new System.EventHandler(this.txtEdadActual_Click);
            // 
            // btnCancelatFotoRegistro
            // 
            this.btnCancelatFotoRegistro.BackColor = System.Drawing.Color.Gray;
            this.btnCancelatFotoRegistro.FlatAppearance.BorderSize = 0;
            this.btnCancelatFotoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelatFotoRegistro.ForeColor = System.Drawing.Color.White;
            this.btnCancelatFotoRegistro.Location = new System.Drawing.Point(801, 180);
            this.btnCancelatFotoRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelatFotoRegistro.Name = "btnCancelatFotoRegistro";
            this.btnCancelatFotoRegistro.Size = new System.Drawing.Size(39, 28);
            this.btnCancelatFotoRegistro.TabIndex = 433;
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
            this.btnAggFotoRegistro.Location = new System.Drawing.Point(570, 469);
            this.btnAggFotoRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggFotoRegistro.Name = "btnAggFotoRegistro";
            this.btnAggFotoRegistro.Size = new System.Drawing.Size(256, 28);
            this.btnAggFotoRegistro.TabIndex = 432;
            this.btnAggFotoRegistro.Text = "Seleccionar";
            this.btnAggFotoRegistro.UseVisualStyleBackColor = false;
            this.btnAggFotoRegistro.Click += new System.EventHandler(this.btnAggFotoRegistro_Click_1);
            // 
            // ptbFotoRegistros
            // 
            this.ptbFotoRegistros.Image = ((System.Drawing.Image)(resources.GetObject("ptbFotoRegistros.Image")));
            this.ptbFotoRegistros.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbFotoRegistros.InitialImage")));
            this.ptbFotoRegistros.Location = new System.Drawing.Point(556, 176);
            this.ptbFotoRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.ptbFotoRegistros.Name = "ptbFotoRegistros";
            this.ptbFotoRegistros.Size = new System.Drawing.Size(284, 285);
            this.ptbFotoRegistros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFotoRegistros.TabIndex = 434;
            this.ptbFotoRegistros.TabStop = false;
            // 
            // dtpFechNac
            // 
            this.dtpFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechNac.Location = new System.Drawing.Point(20, 377);
            this.dtpFechNac.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechNac.Name = "dtpFechNac";
            this.dtpFechNac.Size = new System.Drawing.Size(528, 30);
            this.dtpFechNac.TabIndex = 428;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(20, 323);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(528, 46);
            this.txtTelefono.TabIndex = 427;
            this.txtTelefono.Text = "Telefono";
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
            this.button3.Location = new System.Drawing.Point(148, 580);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 49);
            this.button3.TabIndex = 431;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(20, 526);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(528, 46);
            this.txtDireccion.TabIndex = 430;
            this.txtDireccion.Text = "Direccion";
            // 
            // txtApelido
            // 
            this.txtApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApelido.Location = new System.Drawing.Point(20, 273);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApelido.Multiline = true;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(528, 42);
            this.txtApelido.TabIndex = 426;
            this.txtApelido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(20, 221);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(528, 43);
            this.txtNombre.TabIndex = 425;
            this.txtNombre.Text = "Nombre";
            // 
            // txtCi
            // 
            this.txtCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCi.Location = new System.Drawing.Point(20, 173);
            this.txtCi.Margin = new System.Windows.Forms.Padding(4);
            this.txtCi.Multiline = true;
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(528, 43);
            this.txtCi.TabIndex = 424;
            this.txtCi.Text = "C.I.N°";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(847, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 494);
            this.dataGridView1.TabIndex = 423;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FrmConsultaFutbolCampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(169)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1716, 877);
            this.Controls.Add(this.rboCategoria);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rboCiNro);
            this.Controls.Add(this.rboApellido);
            this.Controls.Add(this.rboNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.txtEdadActual);
            this.Controls.Add(this.btnCancelatFotoRegistro);
            this.Controls.Add(this.btnAggFotoRegistro);
            this.Controls.Add(this.ptbFotoRegistros);
            this.Controls.Add(this.dtpFechNac);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaFutbolCampo";
            this.Text = "ConsultaFutbolCampo";
            this.Load += new System.EventHandler(this.FrmConsultaFutbolCampo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rboCategoria;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rboCiNro;
        private System.Windows.Forms.RadioButton rboApellido;
        private System.Windows.Forms.RadioButton rboNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBuscar;
        public System.Windows.Forms.TextBox txtEdadActual;
        private System.Windows.Forms.Button btnCancelatFotoRegistro;
        private System.Windows.Forms.Button btnAggFotoRegistro;
        public System.Windows.Forms.PictureBox ptbFotoRegistros;
        private System.Windows.Forms.DateTimePicker dtpFechNac;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtApelido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCi;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}