namespace BibliotecaTEC
{
    partial class Menu
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
            this.btnAbrirFormEstudiantes = new System.Windows.Forms.Button();
            this.btnAbrirLibrosForm = new System.Windows.Forms.Button();
            this.btnAbrirAlquileresForm = new System.Windows.Forms.Button();
            this.btnAbrirFormSistemaCostos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirFormEstudiantes
            // 
            this.btnAbrirFormEstudiantes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbrirFormEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFormEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnAbrirFormEstudiantes.Location = new System.Drawing.Point(290, 179);
            this.btnAbrirFormEstudiantes.Name = "btnAbrirFormEstudiantes";
            this.btnAbrirFormEstudiantes.Size = new System.Drawing.Size(191, 41);
            this.btnAbrirFormEstudiantes.TabIndex = 21;
            this.btnAbrirFormEstudiantes.Text = "Estudiantes";
            this.btnAbrirFormEstudiantes.UseVisualStyleBackColor = false;
            this.btnAbrirFormEstudiantes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbrirLibrosForm
            // 
            this.btnAbrirLibrosForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbrirLibrosForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirLibrosForm.ForeColor = System.Drawing.Color.White;
            this.btnAbrirLibrosForm.Location = new System.Drawing.Point(290, 132);
            this.btnAbrirLibrosForm.Name = "btnAbrirLibrosForm";
            this.btnAbrirLibrosForm.Size = new System.Drawing.Size(191, 41);
            this.btnAbrirLibrosForm.TabIndex = 22;
            this.btnAbrirLibrosForm.Text = "Libros";
            this.btnAbrirLibrosForm.UseVisualStyleBackColor = false;
            this.btnAbrirLibrosForm.Click += new System.EventHandler(this.btnAbrirLibrosForm_Click);
            // 
            // btnAbrirAlquileresForm
            // 
            this.btnAbrirAlquileresForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbrirAlquileresForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirAlquileresForm.ForeColor = System.Drawing.Color.White;
            this.btnAbrirAlquileresForm.Location = new System.Drawing.Point(290, 226);
            this.btnAbrirAlquileresForm.Name = "btnAbrirAlquileresForm";
            this.btnAbrirAlquileresForm.Size = new System.Drawing.Size(191, 41);
            this.btnAbrirAlquileresForm.TabIndex = 23;
            this.btnAbrirAlquileresForm.Text = "Alquiler de libros";
            this.btnAbrirAlquileresForm.UseVisualStyleBackColor = false;
            this.btnAbrirAlquileresForm.Click += new System.EventHandler(this.btnAbrirAlquileresForm_Click);
            // 
            // btnAbrirFormSistemaCostos
            // 
            this.btnAbrirFormSistemaCostos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbrirFormSistemaCostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFormSistemaCostos.ForeColor = System.Drawing.Color.White;
            this.btnAbrirFormSistemaCostos.Location = new System.Drawing.Point(290, 273);
            this.btnAbrirFormSistemaCostos.Name = "btnAbrirFormSistemaCostos";
            this.btnAbrirFormSistemaCostos.Size = new System.Drawing.Size(191, 41);
            this.btnAbrirFormSistemaCostos.TabIndex = 24;
            this.btnAbrirFormSistemaCostos.Text = "Sistema Costos";
            this.btnAbrirFormSistemaCostos.UseVisualStyleBackColor = false;
            this.btnAbrirFormSistemaCostos.Click += new System.EventHandler(this.btnAbrirFormSistemaCostos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Menu BiblioTEC";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirFormSistemaCostos);
            this.Controls.Add(this.btnAbrirAlquileresForm);
            this.Controls.Add(this.btnAbrirLibrosForm);
            this.Controls.Add(this.btnAbrirFormEstudiantes);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAbrirFormEstudiantes;
        private System.Windows.Forms.Button btnAbrirLibrosForm;
        private System.Windows.Forms.Button btnAbrirAlquileresForm;
        private System.Windows.Forms.Button btnAbrirFormSistemaCostos;
        private System.Windows.Forms.Label label1;
    }
}