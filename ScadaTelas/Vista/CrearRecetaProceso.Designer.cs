namespace ScadaTelas
{
    partial class CrearRecetaProceso
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subProceso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.param1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.param2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.param3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.param4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bAgregar = new System.Windows.Forms.Button();
            this.bSubir = new System.Windows.Forms.Button();
            this.bBajar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(652, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 264);
            this.listBox1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.subProceso,
            this.param1,
            this.param2,
            this.param3,
            this.param4});
            this.listView1.Location = new System.Drawing.Point(12, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(482, 277);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // no
            // 
            this.no.Text = "No";
            this.no.Width = 38;
            // 
            // subProceso
            // 
            this.subProceso.Text = "Sub Proceso";
            this.subProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subProceso.Width = 100;
            // 
            // param1
            // 
            this.param1.Text = "Param 1";
            this.param1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.param1.Width = 78;
            // 
            // param2
            // 
            this.param2.Text = "Param 2";
            this.param2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.param2.Width = 77;
            // 
            // param3
            // 
            this.param3.Text = "Param 3";
            this.param3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.param3.Width = 77;
            // 
            // param4
            // 
            this.param4.Text = "Param 4";
            this.param4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.param4.Width = 77;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(533, 130);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "<<";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bSubir
            // 
            this.bSubir.Location = new System.Drawing.Point(533, 159);
            this.bSubir.Name = "bSubir";
            this.bSubir.Size = new System.Drawing.Size(75, 23);
            this.bSubir.TabIndex = 3;
            this.bSubir.Text = "Subir";
            this.bSubir.UseVisualStyleBackColor = true;
            // 
            // bBajar
            // 
            this.bBajar.Location = new System.Drawing.Point(533, 189);
            this.bBajar.Name = "bBajar";
            this.bBajar.Size = new System.Drawing.Size(75, 23);
            this.bBajar.TabIndex = 4;
            this.bBajar.Text = "Bajar";
            this.bBajar.UseVisualStyleBackColor = true;
            // 
            // CrearRecetaProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 321);
            this.Controls.Add(this.bBajar);
            this.Controls.Add(this.bSubir);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Name = "CrearRecetaProceso";
            this.Text = "CrearRecetaProceso";
            this.Load += new System.EventHandler(this.CrearRecetaProceso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader subProceso;
        private System.Windows.Forms.ColumnHeader param1;
        private System.Windows.Forms.ColumnHeader param2;
        private System.Windows.Forms.ColumnHeader param3;
        private System.Windows.Forms.ColumnHeader param4;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bSubir;
        private System.Windows.Forms.Button bBajar;
    }
}