
namespace ProyectoSimulacionOriginal
{
    partial class Volados
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
            this.panelV = new System.Windows.Forms.Panel();
            this.txmeta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txapuesta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txcanini = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxNoCor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.datavolados = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panelV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datavolados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelV
            // 
            this.panelV.Controls.Add(this.txmeta);
            this.panelV.Controls.Add(this.label11);
            this.panelV.Controls.Add(this.txapuesta);
            this.panelV.Controls.Add(this.label10);
            this.panelV.Controls.Add(this.txcanini);
            this.panelV.Controls.Add(this.label9);
            this.panelV.Controls.Add(this.cbxNoCor);
            this.panelV.Controls.Add(this.label7);
            this.panelV.Controls.Add(this.button2);
            this.panelV.Controls.Add(this.datavolados);
            this.panelV.Controls.Add(this.label6);
            this.panelV.Location = new System.Drawing.Point(54, 12);
            this.panelV.Name = "panelV";
            this.panelV.Size = new System.Drawing.Size(810, 468);
            this.panelV.TabIndex = 31;
            // 
            // txmeta
            // 
            this.txmeta.Location = new System.Drawing.Point(164, 93);
            this.txmeta.Name = "txmeta";
            this.txmeta.Size = new System.Drawing.Size(62, 20);
            this.txmeta.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Meta:";
            // 
            // txapuesta
            // 
            this.txapuesta.Location = new System.Drawing.Point(164, 67);
            this.txapuesta.Name = "txapuesta";
            this.txapuesta.Size = new System.Drawing.Size(62, 20);
            this.txapuesta.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Apostar:";
            // 
            // txcanini
            // 
            this.txcanini.Location = new System.Drawing.Point(164, 41);
            this.txcanini.Name = "txcanini";
            this.txcanini.Size = new System.Drawing.Size(62, 20);
            this.txcanini.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Cantidad inicial:";
            // 
            // cbxNoCor
            // 
            this.cbxNoCor.Location = new System.Drawing.Point(164, 17);
            this.cbxNoCor.Name = "cbxNoCor";
            this.cbxNoCor.Size = new System.Drawing.Size(62, 20);
            this.cbxNoCor.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Numero de corridas:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Generar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datavolados
            // 
            this.datavolados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datavolados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.datavolados.Location = new System.Drawing.Point(34, 148);
            this.datavolados.Name = "datavolados";
            this.datavolados.Size = new System.Drawing.Size(762, 276);
            this.datavolados.TabIndex = 30;
            // 
            // columna1
            // 
            this.columna1.HeaderText = "Numero de corrida";
            this.columna1.Name = "columna1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad que se tiene antes del volado";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apuesta";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Numero Pseudoalatorio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "se gano el juego";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cantidad que se tiene despues del volado";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Se llego a la meta";
            this.Column7.Name = "Column7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Volados";
            // 
            // Volados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 520);
            this.Controls.Add(this.panelV);
            this.Name = "Volados";
            this.Text = "Volados";
            this.panelV.ResumeLayout(false);
            this.panelV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datavolados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelV;
        private System.Windows.Forms.TextBox txmeta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txapuesta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txcanini;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cbxNoCor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datavolados;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label6;
    }
}