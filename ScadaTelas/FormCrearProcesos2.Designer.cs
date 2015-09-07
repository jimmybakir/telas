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
            this.listView1 = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubProceso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Param1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Param2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Param3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Param4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.SubProceso,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4});
            this.listView1.Location = new System.Drawing.Point(28, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(479, 197);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            // 
            // SubProceso
            // 
            this.SubProceso.Text = "Sub Proceso";
            this.SubProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubProceso.Width = 99;
            // 
            // Param1
            // 
            this.Param1.Text = "Parametro 1";
            this.Param1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Param1.Width = 78;
            // 
            // Param2
            // 
            this.Param2.Text = "Parametro 2";
            this.Param2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Param2.Width = 78;
            // 
            // Param3
            // 
            this.Param3.Text = "Parametro 3";
            this.Param3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Param3.Width = 79;
            // 
            // Param4
            // 
            this.Param4.Text = "Parametro 4";
            this.Param4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Param4.Width = 81;
            // 
            // FormCrearProcesos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txCodigoProceso);
            this.Controls.Add(this.lbCodigoProceso);
            this.Controls.Add(this.lbNombreProceso);
            this.Controls.Add(this.txNombreProceso);
            this.Name = "FormCrearProcesos2";
            this.Text = "FormCrearProcesos2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txCodigoProceso;
        private System.Windows.Forms.Label lbCodigoProceso;
        private System.Windows.Forms.Label lbNombreProceso;
        private System.Windows.Forms.TextBox txNombreProceso;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader SubProceso;
        private System.Windows.Forms.ColumnHeader Param1;
        private System.Windows.Forms.ColumnHeader Param2;
        private System.Windows.Forms.ColumnHeader Param3;
        private System.Windows.Forms.ColumnHeader Param4;
    }
}