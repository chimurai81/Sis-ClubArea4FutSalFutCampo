namespace WindowsFormsApp1
{
    partial class FrmFinanzas
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
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbNroCI = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.button82 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtMontoDeuda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoaPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroFutsalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroFutbolCampoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbApellido.Location = new System.Drawing.Point(1180, 651);
            this.rbApellido.Margin = new System.Windows.Forms.Padding(4);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(79, 21);
            this.rbApellido.TabIndex = 403;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            this.rbApellido.CheckedChanged += new System.EventHandler(this.rbApellido_CheckedChanged);
            // 
            // rbNroCI
            // 
            this.rbNroCI.AutoSize = true;
            this.rbNroCI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNroCI.Location = new System.Drawing.Point(1297, 651);
            this.rbNroCI.Margin = new System.Windows.Forms.Padding(4);
            this.rbNroCI.Name = "rbNroCI";
            this.rbNroCI.Size = new System.Drawing.Size(104, 21);
            this.rbNroCI.TabIndex = 402;
            this.rbNroCI.TabStop = true;
            this.rbNroCI.Text = "Nro. Cedula";
            this.rbNroCI.UseVisualStyleBackColor = true;
            this.rbNroCI.CheckedChanged += new System.EventHandler(this.rbNroCI_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNombre.Location = new System.Drawing.Point(1031, 651);
            this.rbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(79, 21);
            this.rbNombre.TabIndex = 401;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // button82
            // 
            this.button82.BackColor = System.Drawing.Color.SeaGreen;
            this.button82.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button82.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button82.FlatAppearance.BorderSize = 0;
            this.button82.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button82.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button82.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button82.Location = new System.Drawing.Point(1442, 609);
            this.button82.Margin = new System.Windows.Forms.Padding(4);
            this.button82.Name = "button82";
            this.button82.Size = new System.Drawing.Size(76, 34);
            this.button82.TabIndex = 400;
            this.button82.Text = "BUSCAR";
            this.button82.UseVisualStyleBackColor = false;
            this.button82.Click += new System.EventHandler(this.button82_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(906, 614);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 398;
            this.label3.Text = "BUSCAR:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(1031, 604);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusqueda.Multiline = true;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(403, 39);
            this.txtbusqueda.TabIndex = 399;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(853, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(722, 443);
            this.dataGridView1.TabIndex = 397;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(228, 272);
            this.dtpFechaPago.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(319, 22);
            this.dtpFechaPago.TabIndex = 406;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(128, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 428;
            this.label6.Text = "Fecha:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(430, 664);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 57);
            this.button3.TabIndex = 416;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.Location = new System.Drawing.Point(280, 664);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 57);
            this.button2.TabIndex = 414;
            this.button2.Text = "GUARDAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(489, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 44);
            this.button1.TabIndex = 413;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(1487, 32);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 44);
            this.btnCerrar.TabIndex = 427;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(230, 420);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(235, 51);
            this.txtTotal.TabIndex = 410;
            this.txtTotal.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(119, 430);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 29);
            this.label.TabIndex = 426;
            this.label.Text = "TOTAL:";
            // 
            // txtMontoDeuda
            // 
            this.txtMontoDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoDeuda.Location = new System.Drawing.Point(229, 565);
            this.txtMontoDeuda.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoDeuda.Multiline = true;
            this.txtMontoDeuda.Name = "txtMontoDeuda";
            this.txtMontoDeuda.Size = new System.Drawing.Size(235, 50);
            this.txtMontoDeuda.TabIndex = 412;
            this.txtMontoDeuda.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 491);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 425;
            this.label2.Text = "Monto a Pagar:";
            // 
            // txtMontoaPagar
            // 
            this.txtMontoaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoaPagar.Location = new System.Drawing.Point(229, 488);
            this.txtMontoaPagar.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoaPagar.Multiline = true;
            this.txtMontoaPagar.Name = "txtMontoaPagar";
            this.txtMontoaPagar.Size = new System.Drawing.Size(235, 51);
            this.txtMontoaPagar.TabIndex = 411;
            this.txtMontoaPagar.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 569);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 424;
            this.label1.Text = "Monto de Deuda:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(229, 318);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(528, 80);
            this.txtObservacion.TabIndex = 409;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(59, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 423;
            this.label5.Text = "Observacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(138, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 420;
            this.label7.Text = "C.I.N°:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(108, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 419;
            this.label4.Text = "Apellido:";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(228, 240);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(528, 22);
            this.txtApelido.TabIndex = 405;
            this.txtApelido.Text = " ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(228, 208);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(528, 22);
            this.txtNombre.TabIndex = 404;
            this.txtNombre.Text = " ";
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(228, 178);
            this.txtCi.Margin = new System.Windows.Forms.Padding(4);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(235, 22);
            this.txtCi.TabIndex = 418;
            this.txtCi.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(108, 202);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 29);
            this.label13.TabIndex = 417;
            this.label13.Text = "Nombre:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(172)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1604, 28);
            this.menuStrip1.TabIndex = 429;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroFutsalToolStripMenuItem,
            this.registroFutbolCampoToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.nuevoToolStripMenuItem.Text = "Registrar";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // registroFutsalToolStripMenuItem
            // 
            this.registroFutsalToolStripMenuItem.Name = "registroFutsalToolStripMenuItem";
            this.registroFutsalToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.registroFutsalToolStripMenuItem.Text = "Registro Futsal";
            this.registroFutsalToolStripMenuItem.Click += new System.EventHandler(this.registroFutsalToolStripMenuItem_Click);
            // 
            // registroFutbolCampoToolStripMenuItem
            // 
            this.registroFutbolCampoToolStripMenuItem.Name = "registroFutbolCampoToolStripMenuItem";
            this.registroFutbolCampoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.registroFutbolCampoToolStripMenuItem.Text = "Registro Futbol Campo";
            this.registroFutbolCampoToolStripMenuItem.Click += new System.EventHandler(this.registroFutbolCampoToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(107, 82);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(273, 57);
            this.button5.TabIndex = 430;
            this.button5.Text = "Alumno Futsal";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(388, 82);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 57);
            this.button4.TabIndex = 431;
            this.button4.Text = "Alumno Campo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(138, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 29);
            this.label8.TabIndex = 433;
            this.label8.Text = "id:";
            this.label8.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(185, 147);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(235, 22);
            this.txtid.TabIndex = 432;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // FrmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(169)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1604, 748);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtMontoDeuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontoaPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rbApellido);
            this.Controls.Add(this.rbNroCI);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.button82);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmFinanzas";
            this.Text = "FrmFinanzas";
            this.Load += new System.EventHandler(this.FrmFinanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.RadioButton rbNroCI;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.Button button82;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.TextBox txtMontoDeuda;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMontoaPagar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtApelido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroFutsalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroFutbolCampoToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtid;
    }
}