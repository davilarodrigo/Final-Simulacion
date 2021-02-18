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
            this.minLlegada = new System.Windows.Forms.TextBox();
            this.maxLlegada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.clienteRetiraCualquiera = new System.Windows.Forms.CheckBox();
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
            this.probEntrega = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.probRetiro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.probCompra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.relojesListos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.int3b = new System.Windows.Forms.TextBox();
            this.int2b = new System.Windows.Forms.TextBox();
            this.int1b = new System.Windows.Forms.TextBox();
            this.int3a = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.int2a = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.int1a = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Estadisticos = new System.Windows.Forms.Label();
            this.ultimosMinutos = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(1103, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minutos
            // 
            this.minutos.Location = new System.Drawing.Point(1227, 63);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(111, 20);
            this.minutos.TabIndex = 2;
            this.minutos.Text = "720";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1134, 66);
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
            this.groupBox1.Location = new System.Drawing.Point(808, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalos de Llegadas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minLlegada
            // 
            this.minLlegada.Location = new System.Drawing.Point(54, 21);
            this.minLlegada.Name = "minLlegada";
            this.minLlegada.Size = new System.Drawing.Size(69, 20);
            this.minLlegada.TabIndex = 5;
            this.minLlegada.Text = "13";
            this.minLlegada.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maxLlegada
            // 
            this.maxLlegada.Location = new System.Drawing.Point(54, 47);
            this.maxLlegada.Name = "maxLlegada";
            this.maxLlegada.Size = new System.Drawing.Size(69, 20);
            this.maxLlegada.TabIndex = 5;
            this.maxLlegada.Text = "17";
            this.maxLlegada.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.minCompra);
            this.groupBox2.Controls.Add(this.maxCompra);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(669, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempos de compra";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minCompra
            // 
            this.minCompra.Location = new System.Drawing.Point(54, 21);
            this.minCompra.Name = "minCompra";
            this.minCompra.Size = new System.Drawing.Size(69, 20);
            this.minCompra.TabIndex = 5;
            this.minCompra.Text = "6";
            this.minCompra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maxCompra
            // 
            this.maxCompra.Location = new System.Drawing.Point(54, 47);
            this.maxCompra.Name = "maxCompra";
            this.maxCompra.Size = new System.Drawing.Size(69, 20);
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
            this.groupBox3.Location = new System.Drawing.Point(507, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 84);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempos de entrega de reloj";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minEntrega
            // 
            this.minEntrega.Location = new System.Drawing.Point(54, 21);
            this.minEntrega.Name = "minEntrega";
            this.minEntrega.Size = new System.Drawing.Size(73, 20);
            this.minEntrega.TabIndex = 5;
            this.minEntrega.Text = "3";
            this.minEntrega.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maxEntrega
            // 
            this.maxEntrega.Location = new System.Drawing.Point(54, 47);
            this.maxEntrega.Name = "maxEntrega";
            this.maxEntrega.Size = new System.Drawing.Size(73, 20);
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
            this.groupBox4.Controls.Add(this.clienteRetiraCualquiera);
            this.groupBox4.Controls.Add(this.minRetiro);
            this.groupBox4.Controls.Add(this.maxRetiro);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(149, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 108);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiempos de Retiro de Reloj";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clienteRetiraCualquiera
            // 
            this.clienteRetiraCualquiera.AutoSize = true;
            this.clienteRetiraCualquiera.Location = new System.Drawing.Point(9, 76);
            this.clienteRetiraCualquiera.Name = "clienteRetiraCualquiera";
            this.clienteRetiraCualquiera.Size = new System.Drawing.Size(154, 17);
            this.clienteRetiraCualquiera.TabIndex = 6;
            this.clienteRetiraCualquiera.Text = " cliente retira cualquier reloj";
            this.clienteRetiraCualquiera.UseVisualStyleBackColor = true;
            this.clienteRetiraCualquiera.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.groupBox5.Location = new System.Drawing.Point(947, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 84);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tiempos de Reparacion";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // minReparacion
            // 
            this.minReparacion.Location = new System.Drawing.Point(54, 21);
            this.minReparacion.Name = "minReparacion";
            this.minReparacion.Size = new System.Drawing.Size(69, 20);
            this.minReparacion.TabIndex = 5;
            this.minReparacion.Text = "18";
            this.minReparacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maxReparacion
            // 
            this.maxReparacion.Location = new System.Drawing.Point(54, 47);
            this.maxReparacion.Name = "maxReparacion";
            this.maxReparacion.Size = new System.Drawing.Size(69, 20);
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
            this.groupBox6.Size = new System.Drawing.Size(131, 108);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Finalidades de clientes";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // probEntrega
            // 
            this.probEntrega.Location = new System.Drawing.Point(76, 48);
            this.probEntrega.Name = "probEntrega";
            this.probEntrega.Size = new System.Drawing.Size(38, 20);
            this.probEntrega.TabIndex = 7;
            this.probEntrega.Text = "25";
            this.probEntrega.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
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
            // probRetiro
            // 
            this.probRetiro.Location = new System.Drawing.Point(76, 74);
            this.probRetiro.Name = "probRetiro";
            this.probRetiro.Size = new System.Drawing.Size(38, 20);
            this.probRetiro.TabIndex = 7;
            this.probRetiro.Text = "30";
            this.probRetiro.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
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
            // probCompra
            // 
            this.probCompra.Location = new System.Drawing.Point(76, 24);
            this.probCompra.Name = "probCompra";
            this.probCompra.Size = new System.Drawing.Size(38, 20);
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
            // relojesListos
            // 
            this.relojesListos.Location = new System.Drawing.Point(1227, 37);
            this.relojesListos.Name = "relojesListos";
            this.relojesListos.Size = new System.Drawing.Size(111, 20);
            this.relojesListos.TabIndex = 2;
            this.relojesListos.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1100, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "relojes inicialmente listos";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.int3b);
            this.groupBox7.Controls.Add(this.int2b);
            this.groupBox7.Controls.Add(this.int1b);
            this.groupBox7.Controls.Add(this.int3a);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.int2a);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.int1a);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Location = new System.Drawing.Point(322, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(179, 108);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Intervalos de minutos a mostrar";
            // 
            // int3b
            // 
            this.int3b.Location = new System.Drawing.Point(115, 71);
            this.int3b.Name = "int3b";
            this.int3b.Size = new System.Drawing.Size(45, 20);
            this.int3b.TabIndex = 1;
            this.int3b.Text = "2100";
            this.int3b.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // int2b
            // 
            this.int2b.Location = new System.Drawing.Point(115, 45);
            this.int2b.Name = "int2b";
            this.int2b.Size = new System.Drawing.Size(45, 20);
            this.int2b.TabIndex = 1;
            this.int2b.Text = "1100";
            this.int2b.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // int1b
            // 
            this.int1b.Location = new System.Drawing.Point(115, 19);
            this.int1b.Name = "int1b";
            this.int1b.Size = new System.Drawing.Size(45, 20);
            this.int1b.TabIndex = 1;
            this.int1b.Text = "720";
            this.int1b.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // int3a
            // 
            this.int3a.Location = new System.Drawing.Point(69, 71);
            this.int3a.Name = "int3a";
            this.int3a.Size = new System.Drawing.Size(45, 20);
            this.int3a.TabIndex = 1;
            this.int3a.Text = "2000";
            this.int3a.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Intervalo 3";
            // 
            // int2a
            // 
            this.int2a.Location = new System.Drawing.Point(69, 45);
            this.int2a.Name = "int2a";
            this.int2a.Size = new System.Drawing.Size(45, 20);
            this.int2a.TabIndex = 1;
            this.int2a.Text = "1000";
            this.int2a.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Intervalo 2";
            // 
            // int1a
            // 
            this.int1a.Location = new System.Drawing.Point(69, 19);
            this.int1a.Name = "int1a";
            this.int1a.Size = new System.Drawing.Size(45, 20);
            this.int1a.TabIndex = 1;
            this.int1a.Text = "0";
            this.int1a.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Intervalo 1";
            // 
            // Estadisticos
            // 
            this.Estadisticos.AutoSize = true;
            this.Estadisticos.Location = new System.Drawing.Point(515, 103);
            this.Estadisticos.Name = "Estadisticos";
            this.Estadisticos.Size = new System.Drawing.Size(40, 13);
            this.Estadisticos.TabIndex = 7;
            this.Estadisticos.Text = "           ";
            // 
            // ultimosMinutos
            // 
            this.ultimosMinutos.Location = new System.Drawing.Point(1227, 12);
            this.ultimosMinutos.Name = "ultimosMinutos";
            this.ultimosMinutos.Size = new System.Drawing.Size(44, 20);
            this.ultimosMinutos.TabIndex = 2;
            this.ultimosMinutos.Text = "100";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1145, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "mostrar ultimos";
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1272, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "minutos";
            this.label20.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Estadisticos);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ultimosMinutos);
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox int1a;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox int2b;
        private System.Windows.Forms.TextBox int1b;
        private System.Windows.Forms.TextBox int2a;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Estadisticos;
        private System.Windows.Forms.TextBox int3b;
        private System.Windows.Forms.TextBox int3a;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ultimosMinutos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

