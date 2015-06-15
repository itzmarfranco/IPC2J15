namespace WhizzHardBooks
{
    partial class consultar
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
            this.dgvlibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlibros
            // 
            this.dgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlibros.Location = new System.Drawing.Point(32, 34);
            this.dgvlibros.Name = "dgvlibros";
            this.dgvlibros.Size = new System.Drawing.Size(492, 188);
            this.dgvlibros.TabIndex = 0;
            // 
            // consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 262);
            this.Controls.Add(this.dgvlibros);
            this.Name = "consultar";
            this.Text = "Consulta de libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlibros;
    }
}