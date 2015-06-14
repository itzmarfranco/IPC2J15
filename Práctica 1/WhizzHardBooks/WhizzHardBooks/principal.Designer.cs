namespace WhizzHardBooks
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.inscrpcionDeLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscrpcionDeLibroToolStripMenuItem,
            this.consultaDeLibrosToolStripMenuItem,
            this.préstamoToolStripMenuItem,
            this.devoluciónToolStripMenuItem,
            this.registroDeClienteToolStripMenuItem,
            this.repotToolStripMenuItem});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(614, 24);
            this.ms1.TabIndex = 1;
            this.ms1.Text = "menuStrip1";
            // 
            // inscrpcionDeLibroToolStripMenuItem
            // 
            this.inscrpcionDeLibroToolStripMenuItem.Name = "inscrpcionDeLibroToolStripMenuItem";
            this.inscrpcionDeLibroToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.inscrpcionDeLibroToolStripMenuItem.Text = "Inscripción de libro";
            this.inscrpcionDeLibroToolStripMenuItem.Click += new System.EventHandler(this.inscrpcionDeLibroToolStripMenuItem_Click);
            // 
            // consultaDeLibrosToolStripMenuItem
            // 
            this.consultaDeLibrosToolStripMenuItem.Name = "consultaDeLibrosToolStripMenuItem";
            this.consultaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.consultaDeLibrosToolStripMenuItem.Text = "Consulta de libros";
            this.consultaDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeLibrosToolStripMenuItem_Click);
            // 
            // préstamoToolStripMenuItem
            // 
            this.préstamoToolStripMenuItem.Name = "préstamoToolStripMenuItem";
            this.préstamoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.préstamoToolStripMenuItem.Text = "Préstamo";
            this.préstamoToolStripMenuItem.Click += new System.EventHandler(this.préstamoToolStripMenuItem_Click);
            // 
            // devoluciónToolStripMenuItem
            // 
            this.devoluciónToolStripMenuItem.Name = "devoluciónToolStripMenuItem";
            this.devoluciónToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.devoluciónToolStripMenuItem.Text = "Devolución";
            this.devoluciónToolStripMenuItem.Click += new System.EventHandler(this.devoluciónToolStripMenuItem_Click);
            // 
            // registroDeClienteToolStripMenuItem
            // 
            this.registroDeClienteToolStripMenuItem.Name = "registroDeClienteToolStripMenuItem";
            this.registroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.registroDeClienteToolStripMenuItem.Text = "Registro de cliente";
            this.registroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.registroDeClienteToolStripMenuItem_Click);
            // 
            // repotToolStripMenuItem
            // 
            this.repotToolStripMenuItem.Name = "repotToolStripMenuItem";
            this.repotToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.repotToolStripMenuItem.Text = "Reporte de libros";
            this.repotToolStripMenuItem.Click += new System.EventHandler(this.repotToolStripMenuItem_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ms1);
            this.Location = new System.Drawing.Point(500, 200);
            this.MainMenuStrip = this.ms1;
            this.Name = "principal";
            this.Text = "Whizz Hard Books - Sistema de gestión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscrpcionDeLibroToolStripMenuItem;
    }
}

