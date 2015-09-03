namespace ScadaTelas
{
    partial class FormCrearProcesos
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
            this.txNombreProceso = new System.Windows.Forms.TextBox();
            this.lbNombreProceso = new System.Windows.Forms.Label();
            this.lbCodigoProceso = new System.Windows.Forms.Label();
            this.txCodigoProceso = new System.Windows.Forms.TextBox();
            this.btnAñadirSubProceso = new System.Windows.Forms.Button();
            this.txSubProcesosDisponibles = new System.Windows.Forms.TextBox();
            this.txSubProcesosSeleccionados = new System.Windows.Forms.TextBox();
            this.btnQuitarSubProceso = new System.Windows.Forms.Button();
            this.btnSiguienteCrearProceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txNombreProceso
            // 
            this.txNombreProceso.Location = new System.Drawing.Point(104, 26);
            this.txNombreProceso.Name = "txNombreProceso";
            this.txNombreProceso.Size = new System.Drawing.Size(154, 20);
            this.txNombreProceso.TabIndex = 0;
            // 
            // lbNombreProceso
            // 
            this.lbNombreProceso.AutoSize = true;
            this.lbNombreProceso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreProceso.Location = new System.Drawing.Point(22, 25);
            this.lbNombreProceso.Name = "lbNombreProceso";
            this.lbNombreProceso.Size = new System.Drawing.Size(76, 19);
            this.lbNombreProceso.TabIndex = 1;
            this.lbNombreProceso.Text = "Nombre:";
            this.lbNombreProceso.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCodigoProceso
            // 
            this.lbCodigoProceso.AutoSize = true;
            this.lbCodigoProceso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoProceso.Location = new System.Drawing.Point(283, 25);
            this.lbCodigoProceso.Name = "lbCodigoProceso";
            this.lbCodigoProceso.Size = new System.Drawing.Size(71, 19);
            this.lbCodigoProceso.TabIndex = 2;
            this.lbCodigoProceso.Text = "Código:";
            // 
            // txCodigoProceso
            // 
            this.txCodigoProceso.Location = new System.Drawing.Point(360, 26);
            this.txCodigoProceso.Name = "txCodigoProceso";
            this.txCodigoProceso.Size = new System.Drawing.Size(71, 20);
            this.txCodigoProceso.TabIndex = 3;
            // 
            // btnAñadirSubProceso
            // 
            this.btnAñadirSubProceso.Location = new System.Drawing.Point(197, 125);
            this.btnAñadirSubProceso.Name = "btnAñadirSubProceso";
            this.btnAñadirSubProceso.Size = new System.Drawing.Size(78, 33);
            this.btnAñadirSubProceso.TabIndex = 4;
            this.btnAñadirSubProceso.Text = ">>";
            this.btnAñadirSubProceso.UseVisualStyleBackColor = true;
            // 
            // txSubProcesosDisponibles
            // 
            this.txSubProcesosDisponibles.Location = new System.Drawing.Point(55, 90);
            this.txSubProcesosDisponibles.Multiline = true;
            this.txSubProcesosDisponibles.Name = "txSubProcesosDisponibles";
            this.txSubProcesosDisponibles.Size = new System.Drawing.Size(106, 181);
            this.txSubProcesosDisponibles.TabIndex = 5;
            // 
            // txSubProcesosSeleccionados
            // 
            this.txSubProcesosSeleccionados.Location = new System.Drawing.Point(305, 90);
            this.txSubProcesosSeleccionados.Multiline = true;
            this.txSubProcesosSeleccionados.Name = "txSubProcesosSeleccionados";
            this.txSubProcesosSeleccionados.Size = new System.Drawing.Size(106, 181);
            this.txSubProcesosSeleccionados.TabIndex = 6;
            // 
            // btnQuitarSubProceso
            // 
            this.btnQuitarSubProceso.Location = new System.Drawing.Point(197, 188);
            this.btnQuitarSubProceso.Name = "btnQuitarSubProceso";
            this.btnQuitarSubProceso.Size = new System.Drawing.Size(78, 33);
            this.btnQuitarSubProceso.TabIndex = 7;
            this.btnQuitarSubProceso.Text = "<<";
            this.btnQuitarSubProceso.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteCrearProceso
            // 
            this.btnSiguienteCrearProceso.Location = new System.Drawing.Point(305, 299);
            this.btnSiguienteCrearProceso.Name = "btnSiguienteCrearProceso";
            this.btnSiguienteCrearProceso.Size = new System.Drawing.Size(106, 33);
            this.btnSiguienteCrearProceso.TabIndex = 8;
            this.btnSiguienteCrearProceso.Text = "Siguiente";
            this.btnSiguienteCrearProceso.UseVisualStyleBackColor = true;
            this.btnSiguienteCrearProceso.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCrearProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 353);
            this.Controls.Add(this.btnSiguienteCrearProceso);
            this.Controls.Add(this.btnQuitarSubProceso);
            this.Controls.Add(this.txSubProcesosSeleccionados);
            this.Controls.Add(this.txSubProcesosDisponibles);
            this.Controls.Add(this.btnAñadirSubProceso);
            this.Controls.Add(this.txCodigoProceso);
            this.Controls.Add(this.lbCodigoProceso);
            this.Controls.Add(this.lbNombreProceso);
            this.Controls.Add(this.txNombreProceso);
            this.Name = "FormCrearProcesos";
            this.Text = "ScadaTelas :: Crear Procesos";
            this.Load += new System.EventHandler(this.FormCrearProcesos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNombreProceso;
        private System.Windows.Forms.Label lbNombreProceso;
        private System.Windows.Forms.Label lbCodigoProceso;
        private System.Windows.Forms.TextBox txCodigoProceso;
        private System.Windows.Forms.Button btnAñadirSubProceso;
        private System.Windows.Forms.TextBox txSubProcesosDisponibles;
        private System.Windows.Forms.TextBox txSubProcesosSeleccionados;
        private System.Windows.Forms.Button btnQuitarSubProceso;
        private System.Windows.Forms.Button btnSiguienteCrearProceso;

    }
}

