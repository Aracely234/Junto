
namespace ProyectoSimulacionOriginal
{
    partial class Pi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtValorAcumulado = new System.Windows.Forms.TextBox();
            this.txtPiAprox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimites = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLimSupPi = new System.Windows.Forms.TextBox();
            this.txtLimInfPi = new System.Windows.Forms.TextBox();
            this.labelPi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoCorridas = new System.Windows.Forms.TextBox();
            this.dataGridViewPi = new System.Windows.Forms.DataGridView();
            this.NoCorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtValorAcumulado);
            this.panel1.Controls.Add(this.txtPiAprox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnLimites);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtLimSupPi);
            this.panel1.Controls.Add(this.txtLimInfPi);
            this.panel1.Controls.Add(this.labelPi);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtTolerancia);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtNoCorridas);
            this.panel1.Controls.Add(this.dataGridViewPi);
            this.panel1.Controls.Add(this.btnPi);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(75, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 498);
            this.panel1.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(107, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Valor acumulado";
            // 
            // txtValorAcumulado
            // 
            this.txtValorAcumulado.Enabled = false;
            this.txtValorAcumulado.Location = new System.Drawing.Point(115, 149);
            this.txtValorAcumulado.Name = "txtValorAcumulado";
            this.txtValorAcumulado.Size = new System.Drawing.Size(100, 20);
            this.txtValorAcumulado.TabIndex = 15;
            // 
            // txtPiAprox
            // 
            this.txtPiAprox.Enabled = false;
            this.txtPiAprox.Location = new System.Drawing.Point(427, 139);
            this.txtPiAprox.Name = "txtPiAprox";
            this.txtPiAprox.Size = new System.Drawing.Size(100, 20);
            this.txtPiAprox.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(320, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Valor Pi Aproximado";
            // 
            // btnLimites
            // 
            this.btnLimites.Location = new System.Drawing.Point(530, 65);
            this.btnLimites.Name = "btnLimites";
            this.btnLimites.Size = new System.Drawing.Size(75, 23);
            this.btnLimites.TabIndex = 12;
            this.btnLimites.Text = "Decisión";
            this.btnLimites.UseVisualStyleBackColor = true;
            this.btnLimites.Click += new System.EventHandler(this.btnLimites_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(451, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Lim Sup.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Lim Inf.";
            // 
            // txtLimSupPi
            // 
            this.txtLimSupPi.Enabled = false;
            this.txtLimSupPi.Location = new System.Drawing.Point(505, 97);
            this.txtLimSupPi.Name = "txtLimSupPi";
            this.txtLimSupPi.Size = new System.Drawing.Size(100, 20);
            this.txtLimSupPi.TabIndex = 9;
            // 
            // txtLimInfPi
            // 
            this.txtLimInfPi.Enabled = false;
            this.txtLimInfPi.Location = new System.Drawing.Point(300, 100);
            this.txtLimInfPi.Name = "txtLimInfPi";
            this.txtLimInfPi.Size = new System.Drawing.Size(100, 20);
            this.txtLimInfPi.TabIndex = 8;
            // 
            // labelPi
            // 
            this.labelPi.AutoSize = true;
            this.labelPi.Location = new System.Drawing.Point(71, 56);
            this.labelPi.Name = "labelPi";
            this.labelPi.Size = new System.Drawing.Size(0, 13);
            this.labelPi.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tolerancia (%)";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(300, 71);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(100, 20);
            this.txtTolerancia.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Numero de corridas";
            // 
            // txtNoCorridas
            // 
            this.txtNoCorridas.Location = new System.Drawing.Point(115, 87);
            this.txtNoCorridas.Name = "txtNoCorridas";
            this.txtNoCorridas.Size = new System.Drawing.Size(100, 20);
            this.txtNoCorridas.TabIndex = 3;
            // 
            // dataGridViewPi
            // 
            this.dataGridViewPi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoCorrida,
            this.UPs,
            this.SPs,
            this.dis,
            this.sec,
            this.vacum});
            this.dataGridViewPi.Location = new System.Drawing.Point(0, 236);
            this.dataGridViewPi.Name = "dataGridViewPi";
            this.dataGridViewPi.Size = new System.Drawing.Size(640, 254);
            this.dataGridViewPi.TabIndex = 2;
            // 
            // NoCorrida
            // 
            this.NoCorrida.HeaderText = "No Corrida";
            this.NoCorrida.Name = "NoCorrida";
            // 
            // UPs
            // 
            this.UPs.HeaderText = "1er No Pseudoaleatorio";
            this.UPs.Name = "UPs";
            // 
            // SPs
            // 
            this.SPs.HeaderText = "2do No Pseudoaleatorio";
            this.SPs.Name = "SPs";
            // 
            // dis
            // 
            this.dis.HeaderText = "Distancia";
            this.dis.Name = "dis";
            // 
            // sec
            // 
            this.sec.HeaderText = "En sector";
            this.sec.Name = "sec";
            // 
            // vacum
            // 
            this.vacum.HeaderText = "Valor acumulado";
            this.vacum.Name = "vacum";
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(74, 115);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(75, 23);
            this.btnPi.TabIndex = 1;
            this.btnPi.Text = "Calcular";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pi";
            // 
            // Pi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 525);
            this.Controls.Add(this.panel1);
            this.Name = "Pi";
            this.Text = "Pi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtValorAcumulado;
        private System.Windows.Forms.TextBox txtPiAprox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLimites;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLimSupPi;
        private System.Windows.Forms.TextBox txtLimInfPi;
        private System.Windows.Forms.Label labelPi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoCorridas;
        private System.Windows.Forms.DataGridView dataGridViewPi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPs;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dis;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacum;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Label label9;
    }
}