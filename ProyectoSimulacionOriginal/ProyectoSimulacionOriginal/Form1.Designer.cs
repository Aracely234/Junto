
namespace ProyectoSimulacionOriginal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.tbn = new System.Windows.Forms.TextBox();
            this.btnNoPseudoalatorio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumaNumeroGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbXo = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnV = new System.Windows.Forms.Button();
            this.btnTinas = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldisnor2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.btnpruebapromedios = new System.Windows.Forms.Button();
            this.PDistancia = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsobrenosotros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(411, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Generador de Números Pseodoaleatorios";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(220, 172);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(108, 20);
            this.tbn.TabIndex = 28;
            this.tbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbn_KeyPress);
            // 
            // btnNoPseudoalatorio
            // 
            this.btnNoPseudoalatorio.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNoPseudoalatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoPseudoalatorio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoPseudoalatorio.ForeColor = System.Drawing.Color.White;
            this.btnNoPseudoalatorio.Location = new System.Drawing.Point(23, 284);
            this.btnNoPseudoalatorio.Name = "btnNoPseudoalatorio";
            this.btnNoPseudoalatorio.Size = new System.Drawing.Size(100, 152);
            this.btnNoPseudoalatorio.TabIndex = 26;
            this.btnNoPseudoalatorio.Text = "Generar \r\nNúmeros\r\n";
            this.btnNoPseudoalatorio.UseVisualStyleBackColor = false;
            this.btnNoPseudoalatorio.Click += new System.EventHandler(this.btnNoPseudoalatorio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNumero,
            this.ColumaNumeroGenerado});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(146, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(262, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnaNumero
            // 
            this.ColumnaNumero.HeaderText = "No.";
            this.ColumnaNumero.Name = "ColumnaNumero";
            this.ColumnaNumero.ReadOnly = true;
            // 
            // ColumaNumeroGenerado
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumaNumeroGenerado.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumaNumeroGenerado.HeaderText = "Número Pseudoalatorio";
            this.ColumaNumeroGenerado.Name = "ColumaNumeroGenerado";
            this.ColumaNumeroGenerado.ReadOnly = true;
            this.ColumaNumeroGenerado.Width = 120;
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(312, 109);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(108, 20);
            this.tbM.TabIndex = 24;
            this.tbM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbM_KeyPress);
            // 
            // tbXo
            // 
            this.tbXo.Location = new System.Drawing.Point(155, 109);
            this.tbXo.Name = "tbXo";
            this.tbXo.Size = new System.Drawing.Size(108, 20);
            this.tbXo.TabIndex = 23;
            this.tbXo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXo_KeyPress);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(312, 79);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(108, 20);
            this.tbC.TabIndex = 22;
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbC_KeyPress);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(155, 79);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(108, 20);
            this.tbA.TabIndex = 21;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(278, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Xo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "c:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "a:";
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.DarkCyan;
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.ForeColor = System.Drawing.Color.White;
            this.btnV.Location = new System.Drawing.Point(640, 342);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(200, 40);
            this.btnV.TabIndex = 31;
            this.btnV.Text = "Volados";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnTinas
            // 
            this.btnTinas.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinas.ForeColor = System.Drawing.Color.White;
            this.btnTinas.Location = new System.Drawing.Point(640, 398);
            this.btnTinas.Name = "btnTinas";
            this.btnTinas.Size = new System.Drawing.Size(200, 40);
            this.btnTinas.TabIndex = 32;
            this.btnTinas.Text = "Tinas";
            this.btnTinas.UseVisualStyleBackColor = false;
            this.btnTinas.Click += new System.EventHandler(this.btnTinas_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.ForeColor = System.Drawing.Color.White;
            this.btnPi.Location = new System.Drawing.Point(640, 454);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(200, 40);
            this.btnPi.TabIndex = 33;
            this.btnPi.Text = "Pi";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 35;
            this.label7.Visible = false;
            // 
            // lbldisnor2
            // 
            this.lbldisnor2.AutoSize = true;
            this.lbldisnor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisnor2.Location = new System.Drawing.Point(141, 520);
            this.lbldisnor2.Name = "lbldisnor2";
            this.lbldisnor2.Size = new System.Drawing.Size(0, 16);
            this.lbldisnor2.TabIndex = 37;
            this.lbldisnor2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 34;
            this.label6.Visible = false;
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.ForeColor = System.Drawing.Color.White;
            this.lblpromedio.Location = new System.Drawing.Point(371, 486);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(0, 19);
            this.lblpromedio.TabIndex = 36;
            this.lblpromedio.Visible = false;
            // 
            // btnpruebapromedios
            // 
            this.btnpruebapromedios.BackColor = System.Drawing.Color.DarkCyan;
            this.btnpruebapromedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpruebapromedios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpruebapromedios.ForeColor = System.Drawing.Color.White;
            this.btnpruebapromedios.Location = new System.Drawing.Point(640, 126);
            this.btnpruebapromedios.Name = "btnpruebapromedios";
            this.btnpruebapromedios.Size = new System.Drawing.Size(200, 40);
            this.btnpruebapromedios.TabIndex = 38;
            this.btnpruebapromedios.Text = "Prueba de promedios";
            this.btnpruebapromedios.UseVisualStyleBackColor = false;
            this.btnpruebapromedios.Click += new System.EventHandler(this.btnpruebapromedios_Click);
            // 
            // PDistancia
            // 
            this.PDistancia.BackColor = System.Drawing.Color.DarkCyan;
            this.PDistancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDistancia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDistancia.ForeColor = System.Drawing.Color.White;
            this.PDistancia.Location = new System.Drawing.Point(640, 183);
            this.PDistancia.Name = "PDistancia";
            this.PDistancia.Size = new System.Drawing.Size(200, 40);
            this.PDistancia.TabIndex = 39;
            this.PDistancia.Text = "Prueba de la distancia";
            this.PDistancia.UseVisualStyleBackColor = false;
            this.PDistancia.Click += new System.EventHandler(this.PDistancia_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(519, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(413, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "Pruebas para los números pseudoaleatorios";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(602, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "Aplicaciones de la simulación";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 30);
            this.button2.TabIndex = 42;
            this.button2.Text = "Ayuda";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnsobrenosotros
            // 
            this.btnsobrenosotros.BackColor = System.Drawing.Color.Teal;
            this.btnsobrenosotros.FlatAppearance.BorderSize = 0;
            this.btnsobrenosotros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsobrenosotros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsobrenosotros.ForeColor = System.Drawing.Color.White;
            this.btnsobrenosotros.Location = new System.Drawing.Point(120, 0);
            this.btnsobrenosotros.Name = "btnsobrenosotros";
            this.btnsobrenosotros.Size = new System.Drawing.Size(114, 30);
            this.btnsobrenosotros.TabIndex = 43;
            this.btnsobrenosotros.Text = "Sobre nosotros";
            this.btnsobrenosotros.UseVisualStyleBackColor = false;
            this.btnsobrenosotros.Click += new System.EventHandler(this.btnsobrenosotros_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbXo);
            this.panel1.Controls.Add(this.tbA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbC);
            this.panel1.Controls.Add(this.tbM);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnNoPseudoalatorio);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblpromedio);
            this.panel1.Location = new System.Drawing.Point(1, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 547);
            this.panel1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(199, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Números a generar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.btnsobrenosotros);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 32);
            this.panel2.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(964, 579);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PDistancia);
            this.Controls.Add(this.btnpruebapromedios);
            this.Controls.Add(this.lbldisnor2);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnTinas);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.Button btnNoPseudoalatorio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbXo;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnTinas;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbldisnor2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Button btnpruebapromedios;
        private System.Windows.Forms.Button PDistancia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsobrenosotros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumaNumeroGenerado;
    }
}

