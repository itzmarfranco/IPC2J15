﻿namespace WhizzHardBooks
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlibros
            // 
            this.dgvlibros.AllowUserToAddRows = false;
            this.dgvlibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlibros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlibros.Location = new System.Drawing.Point(36, 33);
            this.dgvlibros.Name = "dgvlibros";
            this.dgvlibros.RowHeadersVisible = false;
            this.dgvlibros.Size = new System.Drawing.Size(492, 188);
            this.dgvlibros.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvlibros);
            this.Name = "consultar";
            this.Text = "Consulta de libros";
            this.Load += new System.EventHandler(this.consultar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlibros;
        private System.Windows.Forms.Button button1;
    }
}