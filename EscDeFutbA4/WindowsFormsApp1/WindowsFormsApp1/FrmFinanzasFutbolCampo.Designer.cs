namespace WindowsFormsApp1
{
    partial class FrmFinanzasFutbolCampo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinanzasFutbolCampo));
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbNroCI = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.button82 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbApellido.Location = new System.Drawing.Point(313, 530);
            this.rbApellido.Margin = new System.Windows.Forms.Padding(4);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(79, 21);
            this.rbApellido.TabIndex = 416;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            // 
            // rbNroCI
            // 
            this.rbNroCI.AutoSize = true;
            this.rbNroCI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNroCI.Location = new System.Drawing.Point(430, 530);
            this.rbNroCI.Margin = new System.Windows.Forms.Padding(4);
            this.rbNroCI.Name = "rbNroCI";
            this.rbNroCI.Size = new System.Drawing.Size(104, 21);
            this.rbNroCI.TabIndex = 415;
            this.rbNroCI.TabStop = true;
            this.rbNroCI.Text = "Nro. Cedula";
            this.rbNroCI.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNombre.Location = new System.Drawing.Point(164, 530);
            this.rbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(79, 21);
            this.rbNombre.TabIndex = 414;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
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
            this.button82.Location = new System.Drawing.Point(575, 488);
            this.button82.Margin = new System.Windows.Forms.Padding(4);
            this.button82.Name = "button82";
            this.button82.Size = new System.Drawing.Size(76, 34);
            this.button82.TabIndex = 413;
            this.button82.Text = "BUSCAR";
            this.button82.UseVisualStyleBackColor = false;
            this.button82.Click += new System.EventHandler(this.button82_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(39, 493);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 411;
            this.label3.Text = "BUSCAR:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(164, 483);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusqueda.Multiline = true;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(403, 39);
            this.txtbusqueda.TabIndex = 412;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 449);
            this.dataGridView1.TabIndex = 410;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // FrmFinanzasFutbolCampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(169)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(775, 572);
            this.Controls.Add(this.rbApellido);
            this.Controls.Add(this.rbNroCI);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.button82);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFinanzasFutbolCampo";
            this.Text = "Alumnos de Futbol de Campo";
            this.Load += new System.EventHandler(this.FrmFinanzasFutbolCampo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}