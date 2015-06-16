namespace WhizzHardBooks
{
    partial class prestamo
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
            this.prestar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcarne = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.reservar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvlibros
            // 
            this.dgvlibros.AllowUserToAddRows = false;
            this.dgvlibros.AllowUserToDeleteRows = false;
            this.dgvlibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlibros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prestar,
            this.reservar});
            this.dgvlibros.Location = new System.Drawing.Point(69, 71);
            this.dgvlibros.Name = "dgvlibros";
            this.dgvlibros.RowHeadersVisible = false;
            this.dgvlibros.Size = new System.Drawing.Size(476, 182);
            this.dgvlibros.TabIndex = 0;
            this.dgvlibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlibros_CellContentClick);
            // 
            // prestar
            // 
            this.prestar.HeaderText = "Prestar libro";
            this.prestar.Name = "prestar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcarne, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(69, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 39);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carné:";
            // 
            // txtcarne
            // 
            this.txtcarne.Location = new System.Drawing.Point(47, 3);
            this.txtcarne.Name = "txtcarne";
            this.txtcarne.Size = new System.Drawing.Size(100, 20);
            this.txtcarne.TabIndex = 1;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(69, 260);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 3;
            // 
            // reservar
            // 
            this.reservar.HeaderText = "Reservar";
            this.reservar.Name = "reservar";
            // 
            // prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 322);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvlibros);
            this.Name = "prestamo";
            this.Text = "Préstamo del libro";
            this.Load += new System.EventHandler(this.prestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlibros;
        private System.Windows.Forms.DataGridViewButtonColumn prestar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcarne;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.DataGridViewButtonColumn reservar;
    }
}