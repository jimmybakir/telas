namespace ScadaTelas
{
    partial class FormCrearProcesos2
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
            this.txCodigoProceso = new System.Windows.Forms.TextBox();
            this.lbCodigoProceso = new System.Windows.Forms.Label();
            this.lbNombreProceso = new System.Windows.Forms.Label();
            this.txNombreProceso = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txCodigoProceso
            // 
            this.txCodigoProceso.Location = new System.Drawing.Point(362, 30);
            this.txCodigoProceso.Name = "txCodigoProceso";
            this.txCodigoProceso.Size = new System.Drawing.Size(71, 20);
            this.txCodigoProceso.TabIndex = 7;
            // 
            // lbCodigoProceso
            // 
            this.lbCodigoProceso.AutoSize = true;
            this.lbCodigoProceso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoProceso.Location = new System.Drawing.Point(285, 29);
            this.lbCodigoProceso.Name = "lbCodigoProceso";
            this.lbCodigoProceso.Size = new System.Drawing.Size(71, 19);
            this.lbCodigoProceso.TabIndex = 6;
            this.lbCodigoProceso.Text = "Código:";
            // 
            // lbNombreProceso
            // 
            this.lbNombreProceso.AutoSize = true;
            this.lbNombreProceso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreProceso.Location = new System.Drawing.Point(24, 29);
            this.lbNombreProceso.Name = "lbNombreProceso";
            this.lbNombreProceso.Size = new System.Drawing.Size(76, 19);
            this.lbNombreProceso.TabIndex = 5;
            this.lbNombreProceso.Text = "Nombre:";
            // 
            // txNombreProceso
            // 
            this.txNombreProceso.Location = new System.Drawing.Point(106, 30);
            this.txNombreProceso.Name = "txNombreProceso";
            this.txNombreProceso.Size = new System.Drawing.Size(154, 20);
            this.txNombreProceso.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(28, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 197);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // FormCrearProcesos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txCodigoProceso);
            this.Controls.Add(this.lbCodigoProceso);
            this.Controls.Add(this.lbNombreProceso);
            this.Controls.Add(this.txNombreProceso);
            this.Name = "FormCrearProcesos2";
            this.Text = "FormCrearProcesos2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txCodigoProceso;
        private System.Windows.Forms.Label lbCodigoProceso;
        private System.Windows.Forms.Label lbNombreProceso;
        private System.Windows.Forms.TextBox txNombreProceso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}