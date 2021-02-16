namespace FinalSIM
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
            this.gridPrincipal = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.minutos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxLlegada = new System.Windows.Forms.TextBox();
            this.minLlegada = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minCompra = new System.Windows.Forms.TextBox();
            this.maxCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.minEntrega = new System.Windows.Forms.TextBox();
            this.maxEntrega = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.minRetiro = new System.Windows.Forms.TextBox();
            this.maxRetiro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.minReparacion = new System.Windows.Forms.TextBox();
            this.maxReparacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.probCompra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.probRetiro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.probEntrega = new System.Windows.Forms.TextBox();
            this.clienteRetiraCualquiera = new System.Windows.Forms.CheckBox();
            this.relojesListos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPrincipal
            // 
            this.gridPrincipal.AllowUserToAddRows = false;
            this.gridPrincipal.AllowUserToDeleteRows = false;
            this.gridPrincipal.AllowUserToOrderColumns = true;
            this.gridPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrincipal.Location = new System.Drawing.Point(12, 126);
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.ReadOnly = true;
            this.gridPrincipal.Size = new System.Drawing.Size(1326, 591);
            this.gridPrincipal.TabIndex = 0;
            this.gridPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1097, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minutos
            // 
            this.minutos.Location = new System.Drawing.Point(1221, 47);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(111, 20);
            this.minutos.TabIndex = 2;
            this.minutos.Text = "720";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1128, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "minutos a simular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minLlegada);
            this.groupBox1.Controls.Add(this.maxLlegada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalos de Llegadas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "minimo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "maximo";
            // 
            // maxLlegada
            // 
            this.maxLlegada.Location = new System.Drawing.Point(54, 47);
            this.maxLlegada.Name = "maxLlegada";
            this.maxLlegada.Size = new System.Drawing.Size(100, 20);
            this.maxLlegada.TabIndex = 5;
            this.maxLlegada.Text = "17";
            this.maxLlegada.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // minLlegada
            // 
            this.minLlegada.Location = new System.Drawing.Point(54, 21);
            this.minLlegada.Name = "minLlegada";
            this.minLlegada.Size = new System.Drawing.Size(100, 20);
            this.minLlegada.TabIndex = 5;
            this.minLlegada.Text = "13";
            this.minLlegada.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.minCompra);
            this.groupBox2.Controls.Add(this.maxCompra);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(564, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempos de compra";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minCompra
            // 
            this.minCompra.Location = new System.Drawing.Point(54, 21);
            this.minCompra.Name = "minCompra";
            this.minCompra.Size = new System.Drawing.Size(100, 20);
            this.minCompra.TabIndex = 5;
            this.minCompra.Text = "6";
            this.minCompra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maxCompra
            // 
            this.maxCompra.Location = new System.Drawing.Point(54, 47);
            this.maxCompra.Name = "maxCompra";
            this.maxCompra.Size = new System.Drawing.Size(100, 20);
            this.maxCompra.TabIndex = 5;
            this.maxCompra.Text = "10";
            this.maxCompra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "maximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "minimo";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.minEntrega);
            this.groupBox3.Controls.Add(this.maxEntrega);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(737, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 84);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempos de Entrega de Reloj";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minEntrega
            // 
            this.minEntrega.Location = new System.Drawing.Point(54, 21);
            this.minEntrega.Name = "minEntrega";
            this.minEntrega.Size = new System.Drawing.Size(100, 20);
            this.minEntrega.TabIndex = 5;
            this.minEntrega.Text = "3";
            this.minEntrega.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maxEntrega
            // 
            this.maxEntrega.Location = new System.Drawing.Point(54, 47);
            this.maxEntrega.Name = "maxEntrega";
            this.maxEntrega.Size = new System.Drawing.Size(100, 20);
            this.maxEntrega.TabIndex = 5;
            this.maxEntrega.Text = "3";
            this.maxEntrega.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "maximo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "minimo";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.minRetiro);
            this.groupBox4.Controls.Add(this.maxRetiro);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(910, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 84);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiempos de Retiro de Reloj";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minRetiro
            // 
            this.minRetiro.Location = new System.Drawing.Point(54, 21);
            this.minRetiro.Name = "minRetiro";
            this.minRetiro.Size = new System.Drawing.Size(100, 20);
            this.minRetiro.TabIndex = 5;
            this.minRetiro.Text = "3";
            this.minRetiro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maxRetiro
            // 
            this.maxRetiro.Location = new System.Drawing.Point(54, 47);
            this.maxRetiro.Name = "maxRetiro";
            this.maxRetiro.Size = new System.Drawing.Size(100, 20);
            this.maxRetiro.TabIndex = 5;
            this.maxRetiro.Text = "3";
            this.maxRetiro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "maximo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "minimo";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.minReparacion);
            this.groupBox5.Controls.Add(this.maxReparacion);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(391, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(167, 84);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tiempos de Reparacion";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minReparacion
            // 
            this.minReparacion.Location = new System.Drawing.Point(54, 21);
            this.minReparacion.Name = "minReparacion";
            this.minReparacion.Size = new System.Drawing.Size(100, 20);
            this.minReparacion.TabIndex = 5;
            this.minReparacion.Text = "18";
            this.minReparacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maxReparacion
            // 
            this.maxReparacion.Location = new System.Drawing.Point(54, 47);
            this.maxReparacion.Name = "maxReparacion";
            this.maxReparacion.Size = new System.Drawing.Size(100, 20);
            this.maxReparacion.TabIndex = 5;
            this.maxReparacion.Text = "22";
            this.maxReparacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "maximo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "minimo";
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.probEntrega);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.probRetiro);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.probCompra);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 108);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "probabilidad de finalidad del cliente";
            // 
            // probCompra
            // 
            this.probCompra.Location = new System.Drawing.Point(76, 24);
            this.probCompra.Name = "probCompra";
            this.probCompra.Size = new System.Drawing.Size(100, 20);
            this.probCompra.TabIndex = 7;
            this.probCompra.Text = "45";
            this.probCompra.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Compra %";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Retiro %";
            this.label13.Click += new System.EventHandler(this.label12_Click);
            // 
            // probRetiro
            // 
            this.probRetiro.Location = new System.Drawing.Point(76, 74);
            this.probRetiro.Name = "probRetiro";
            this.probRetiro.Size = new System.Drawing.Size(100, 20);
            this.probRetiro.TabIndex = 7;
            this.probRetiro.Text = "30";
            this.probRetiro.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Entrega %";
            this.label14.Click += new System.EventHandler(this.label12_Click);
            // 
            // probEntrega
            // 
            this.probEntrega.Location = new System.Drawing.Point(76, 48);
            this.probEntrega.Name = "probEntrega";
            this.probEntrega.Size = new System.Drawing.Size(100, 20);
            this.probEntrega.TabIndex = 7;
            this.probEntrega.Text = "25";
            this.probEntrega.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // clienteRetiraCualquiera
            // 
            this.clienteRetiraCualquiera.AutoSize = true;
            this.clienteRetiraCualquiera.Location = new System.Drawing.Point(1134, 103);
            this.clienteRetiraCualquiera.Name = "clienteRetiraCualquiera";
            this.clienteRetiraCualquiera.Size = new System.Drawing.Size(154, 17);
            this.clienteRetiraCualquiera.TabIndex = 6;
            this.clienteRetiraCualquiera.Text = " cliente retira cualquier reloj";
            this.clienteRetiraCualquiera.UseVisualStyleBackColor = true;
            this.clienteRetiraCualquiera.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // relojesListos
            // 
            this.relojesListos.Location = new System.Drawing.Point(1221, 21);
            this.relojesListos.Name = "relojesListos";
            this.relojesListos.Size = new System.Drawing.Size(111, 20);
            this.relojesListos.TabIndex = 2;
            this.relojesListos.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1094, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "relojes inicialmente listos";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.clienteRetiraCualquiera);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.relojesListos);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPrincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox minutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maxLlegada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minLlegada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox minCompra;
        private System.Windows.Forms.TextBox maxCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox minEntrega;
        private System.Windows.Forms.TextBox maxEntrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox minRetiro;
        private System.Windows.Forms.TextBox maxRetiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox minReparacion;
        private System.Windows.Forms.TextBox maxReparacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox probCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox probEntrega;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox probRetiro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox clienteRetiraCualquiera;
        private System.Windows.Forms.TextBox relojesListos;
        private System.Windows.Forms.Label label15;
    }
}

