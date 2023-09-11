namespace BibliotecaTEC
{
    partial class AlquileresForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaDevolucion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaAlquiler = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCampusEstudiante = new System.Windows.Forms.TextBox();
            this.txtCarerraEstudiante = new System.Windows.Forms.TextBox();
            this.txtCarneEstudiante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.carne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(37, 512);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(104, 22);
            this.txtEstado.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(34, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 105;
            this.label10.Text = "Estado";
            // 
            // txtFechaDevolucion
            // 
            this.txtFechaDevolucion.Location = new System.Drawing.Point(37, 455);
            this.txtFechaDevolucion.Name = "txtFechaDevolucion";
            this.txtFechaDevolucion.Size = new System.Drawing.Size(253, 22);
            this.txtFechaDevolucion.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 103;
            this.label8.Text = "Fecha de devolucion";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(37, 394);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(253, 22);
            this.txtFechaVencimiento.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 101;
            this.label7.Text = "Fecha de vencimiento";
            // 
            // txtFechaAlquiler
            // 
            this.txtFechaAlquiler.Location = new System.Drawing.Point(37, 329);
            this.txtFechaAlquiler.Name = "txtFechaAlquiler";
            this.txtFechaAlquiler.Size = new System.Drawing.Size(253, 22);
            this.txtFechaAlquiler.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 99;
            this.label6.Text = "Fecha de alquiler";
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.Firebrick;
            this.btnElimina.ForeColor = System.Drawing.Color.White;
            this.btnElimina.Location = new System.Drawing.Point(37, 597);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(253, 42);
            this.btnElimina.TabIndex = 98;
            this.btnElimina.Text = "Eliminar";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(37, 549);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(253, 42);
            this.btnRegistrar.TabIndex = 97;
            this.btnRegistrar.Text = "Registrar/Actualizar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 96;
            this.label4.Text = "Campus del estudiante";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(213, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(77, 22);
            this.txtID.TabIndex = 94;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Visible = false;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(182, 53);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(25, 22);
            this.txtIndex.TabIndex = 95;
            this.txtIndex.Text = "-1";
            this.txtIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIndex.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 23);
            this.label9.TabIndex = 93;
            this.label9.Text = "Detalle del alquiler";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(37, 265);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(253, 22);
            this.txtNombreLibro.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "Nombre del libro";
            // 
            // txtCampusEstudiante
            // 
            this.txtCampusEstudiante.Location = new System.Drawing.Point(37, 206);
            this.txtCampusEstudiante.Name = "txtCampusEstudiante";
            this.txtCampusEstudiante.Size = new System.Drawing.Size(253, 22);
            this.txtCampusEstudiante.TabIndex = 90;
            // 
            // txtCarerraEstudiante
            // 
            this.txtCarerraEstudiante.Location = new System.Drawing.Point(37, 150);
            this.txtCarerraEstudiante.Name = "txtCarerraEstudiante";
            this.txtCarerraEstudiante.Size = new System.Drawing.Size(253, 22);
            this.txtCarerraEstudiante.TabIndex = 89;
            // 
            // txtCarneEstudiante
            // 
            this.txtCarneEstudiante.Location = new System.Drawing.Point(37, 94);
            this.txtCarneEstudiante.Name = "txtCarneEstudiante";
            this.txtCarneEstudiante.Size = new System.Drawing.Size(253, 22);
            this.txtCarneEstudiante.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Carrera del estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Carné del estudiante";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 653);
            this.label1.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(179, 486);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 107;
            this.label11.Text = "Multa";
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(182, 512);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(104, 22);
            this.txtMulta.TabIndex = 108;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelect,
            this.carne,
            this.carrera,
            this.campus,
            this.libro,
            this.alquiler,
            this.vencimiento,
            this.devolucion,
            this.estado,
            this.Multa});
            this.dgvData.Location = new System.Drawing.Point(374, 73);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(976, 552);
            this.dgvData.TabIndex = 110;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnSelect
            // 
            this.btnSelect.HeaderText = "";
            this.btnSelect.MinimumWidth = 6;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ReadOnly = true;
            this.btnSelect.Width = 50;
            // 
            // carne
            // 
            this.carne.HeaderText = "Carne";
            this.carne.MinimumWidth = 6;
            this.carne.Name = "carne";
            this.carne.ReadOnly = true;
            this.carne.Width = 150;
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Carrera";
            this.carrera.MinimumWidth = 6;
            this.carrera.Name = "carrera";
            this.carrera.ReadOnly = true;
            this.carrera.Width = 200;
            // 
            // campus
            // 
            this.campus.HeaderText = "Campus";
            this.campus.MinimumWidth = 6;
            this.campus.Name = "campus";
            this.campus.ReadOnly = true;
            this.campus.Width = 125;
            // 
            // libro
            // 
            this.libro.HeaderText = "Libro";
            this.libro.MinimumWidth = 6;
            this.libro.Name = "libro";
            this.libro.ReadOnly = true;
            this.libro.Width = 125;
            // 
            // alquiler
            // 
            this.alquiler.HeaderText = "Alquiler";
            this.alquiler.MinimumWidth = 6;
            this.alquiler.Name = "alquiler";
            this.alquiler.ReadOnly = true;
            this.alquiler.Width = 125;
            // 
            // vencimiento
            // 
            this.vencimiento.HeaderText = "Vencimiento";
            this.vencimiento.MinimumWidth = 6;
            this.vencimiento.Name = "vencimiento";
            this.vencimiento.ReadOnly = true;
            this.vencimiento.Width = 125;
            // 
            // devolucion
            // 
            this.devolucion.HeaderText = "Devolucion";
            this.devolucion.MinimumWidth = 6;
            this.devolucion.Name = "devolucion";
            this.devolucion.ReadOnly = true;
            this.devolucion.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // Multa
            // 
            this.Multa.HeaderText = "Multa";
            this.Multa.MinimumWidth = 6;
            this.Multa.Name = "Multa";
            this.Multa.ReadOnly = true;
            this.Multa.Width = 125;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(374, 15);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label12.Size = new System.Drawing.Size(976, 43);
            this.label12.TabIndex = 109;
            this.label12.Text = "Lista de alquileres registrados";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlquileresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFechaDevolucion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFechaAlquiler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCampusEstudiante);
            this.Controls.Add(this.txtCarerraEstudiante);
            this.Controls.Add(this.txtCarneEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlquileresForm";
            this.Text = "Alquileres";
            this.Load += new System.EventHandler(this.AlquileresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaDevolucion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaAlquiler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCampusEstudiante;
        private System.Windows.Forms.TextBox txtCarerraEstudiante;
        private System.Windows.Forms.TextBox txtCarneEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn carne;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn campus;
        private System.Windows.Forms.DataGridViewTextBoxColumn libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multa;
    }
}