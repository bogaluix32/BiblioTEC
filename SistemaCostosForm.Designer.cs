namespace BibliotecaTEC
{
    partial class SistemaCostosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporteMorisidades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFormEstudiantes
            // 
            this.btnAbrirFormEstudiantes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbrirFormEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFormEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnAbrirFormEstudiantes.Location = new System.Drawing.Point(245, 234);
            this.btnAbrirFormEstudiantes.Name = "btnAbrirFormEstudiantes";
            this.btnAbrirFormEstudiantes.Size = new System.Drawing.Size(275, 41);
            this.btnAbrirFormEstudiantes.TabIndex = 23;
            this.btnAbrirFormEstudiantes.Text = "Reporte de extravios";
            this.btnAbrirFormEstudiantes.UseVisualStyleBackColor = false;
            this.btnAbrirFormEstudiantes.Click += new System.EventHandler(this.btnAbrirFormEstudiantes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sistema de costos";
            // 
            // btnReporteMorisidades
            // 
            this.btnReporteMorisidades.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReporteMorisidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteMorisidades.ForeColor = System.Drawing.Color.White;
            this.btnReporteMorisidades.Location = new System.Drawing.Point(245, 170);
            this.btnReporteMorisidades.Name = "btnReporteMorisidades";
            this.btnReporteMorisidades.Size = new System.Drawing.Size(275, 41);
            this.btnReporteMorisidades.TabIndex = 27;
            this.btnReporteMorisidades.Text = "Reporte de morosidades";
            this.btnReporteMorisidades.UseVisualStyleBackColor = false;
            this.btnReporteMorisidades.Click += new System.EventHandler(this.btnReporteMorisidades_Click);
            // 
            // SistemaCostosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteMorisidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirFormEstudiantes);
            this.Name = "SistemaCostosForm";
            this.Text = "SistemaCostosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAbrirFormEstudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporteMorisidades;
    }
}