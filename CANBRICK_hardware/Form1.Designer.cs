namespace CANBRICK_hardware
{
    partial class principal
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
            this.components = new System.ComponentModel.Container();
            this.tick_refresco = new System.Windows.Forms.Timer(this.components);
            this.lb_current = new System.Windows.Forms.Label();
            this.txb_current = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_thickness = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_t_rise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_t_amb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_trace_length = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_width_internal = new System.Windows.Forms.Label();
            this.combo_width_internal = new System.Windows.Forms.ComboBox();
            this.lb_resist_internal = new System.Windows.Forms.Label();
            this.lb_volt_internal = new System.Windows.Forms.Label();
            this.lb_power_internal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lb_power_external = new System.Windows.Forms.Label();
            this.lb_volt_external = new System.Windows.Forms.Label();
            this.lb_resist_external = new System.Windows.Forms.Label();
            this.combo_width_external = new System.Windows.Forms.ComboBox();
            this.lb_width_external = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tick_refresco
            // 
            this.tick_refresco.Enabled = true;
            this.tick_refresco.Interval = 1000;
            this.tick_refresco.Tick += new System.EventHandler(this.tick_refresco_Tick);
            // 
            // lb_current
            // 
            this.lb_current.AutoSize = true;
            this.lb_current.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_current.ForeColor = System.Drawing.Color.Black;
            this.lb_current.Location = new System.Drawing.Point(78, 128);
            this.lb_current.Name = "lb_current";
            this.lb_current.Size = new System.Drawing.Size(98, 22);
            this.lb_current.TabIndex = 0;
            this.lb_current.Text = "Current:";
            // 
            // txb_current
            // 
            this.txb_current.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txb_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_current.Location = new System.Drawing.Point(182, 126);
            this.txb_current.Name = "txb_current";
            this.txb_current.Size = new System.Drawing.Size(65, 24);
            this.txb_current.TabIndex = 1;
            this.txb_current.Text = "0,01";
            this.txb_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(253, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(253, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "oz/ft^2";
            // 
            // txb_thickness
            // 
            this.txb_thickness.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txb_thickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_thickness.Location = new System.Drawing.Point(182, 160);
            this.txb_thickness.Name = "txb_thickness";
            this.txb_thickness.Size = new System.Drawing.Size(65, 24);
            this.txb_thickness.TabIndex = 4;
            this.txb_thickness.Text = "3";
            this.txb_thickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thickness:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(253, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "ºC";
            // 
            // txb_t_rise
            // 
            this.txb_t_rise.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txb_t_rise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_t_rise.Location = new System.Drawing.Point(182, 195);
            this.txb_t_rise.Name = "txb_t_rise";
            this.txb_t_rise.Size = new System.Drawing.Size(65, 24);
            this.txb_t_rise.TabIndex = 7;
            this.txb_t_rise.Text = "10";
            this.txb_t_rise.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tª Rise:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(253, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "ºC";
            // 
            // txb_t_amb
            // 
            this.txb_t_amb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txb_t_amb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_t_amb.Location = new System.Drawing.Point(182, 231);
            this.txb_t_amb.Name = "txb_t_amb";
            this.txb_t_amb.Size = new System.Drawing.Size(65, 24);
            this.txb_t_amb.TabIndex = 10;
            this.txb_t_amb.Text = "25";
            this.txb_t_amb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(89, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tª Amb:";
            // 
            // txb_trace_length
            // 
            this.txb_trace_length.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txb_trace_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_trace_length.Location = new System.Drawing.Point(182, 269);
            this.txb_trace_length.Name = "txb_trace_length";
            this.txb_trace_length.Size = new System.Drawing.Size(65, 24);
            this.txb_trace_length.TabIndex = 13;
            this.txb_trace_length.Text = "0,5";
            this.txb_trace_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(23, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Trace Length:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(492, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Power Loss:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(470, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Voltage Drop:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(492, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 22);
            this.label12.TabIndex = 17;
            this.label12.Text = "Resistance:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(382, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(241, 22);
            this.label13.TabIndex = 16;
            this.label13.Text = "Required Trace Width:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(492, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "Internal Layers:";
            // 
            // lb_width_internal
            // 
            this.lb_width_internal.AutoSize = true;
            this.lb_width_internal.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_width_internal.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_width_internal.Location = new System.Drawing.Point(641, 77);
            this.lb_width_internal.Name = "lb_width_internal";
            this.lb_width_internal.Size = new System.Drawing.Size(21, 22);
            this.lb_width_internal.TabIndex = 22;
            this.lb_width_internal.Text = "1";
            // 
            // combo_width_internal
            // 
            this.combo_width_internal.BackColor = System.Drawing.Color.SkyBlue;
            this.combo_width_internal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_width_internal.FormattingEnabled = true;
            this.combo_width_internal.Items.AddRange(new object[] {
            "mil",
            "mm"});
            this.combo_width_internal.Location = new System.Drawing.Point(742, 77);
            this.combo_width_internal.Name = "combo_width_internal";
            this.combo_width_internal.Size = new System.Drawing.Size(53, 28);
            this.combo_width_internal.TabIndex = 23;
            this.combo_width_internal.Text = "mil";
            this.combo_width_internal.SelectedIndexChanged += new System.EventHandler(this.combo_width_internal_SelectedIndexChanged);
            // 
            // lb_resist_internal
            // 
            this.lb_resist_internal.AutoSize = true;
            this.lb_resist_internal.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resist_internal.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_resist_internal.Location = new System.Drawing.Point(641, 108);
            this.lb_resist_internal.Name = "lb_resist_internal";
            this.lb_resist_internal.Size = new System.Drawing.Size(21, 22);
            this.lb_resist_internal.TabIndex = 24;
            this.lb_resist_internal.Text = "1";
            // 
            // lb_volt_internal
            // 
            this.lb_volt_internal.AutoSize = true;
            this.lb_volt_internal.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_volt_internal.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_volt_internal.Location = new System.Drawing.Point(641, 139);
            this.lb_volt_internal.Name = "lb_volt_internal";
            this.lb_volt_internal.Size = new System.Drawing.Size(21, 22);
            this.lb_volt_internal.TabIndex = 25;
            this.lb_volt_internal.Text = "1";
            // 
            // lb_power_internal
            // 
            this.lb_power_internal.AutoSize = true;
            this.lb_power_internal.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_power_internal.ForeColor = System.Drawing.Color.Maroon;
            this.lb_power_internal.Location = new System.Drawing.Point(641, 168);
            this.lb_power_internal.Name = "lb_power_internal";
            this.lb_power_internal.Size = new System.Drawing.Size(21, 22);
            this.lb_power_internal.TabIndex = 26;
            this.lb_power_internal.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(752, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 22);
            this.label14.TabIndex = 27;
            this.label14.Text = "ohm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(756, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 22);
            this.label15.TabIndex = 28;
            this.label15.Text = "V";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(756, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 22);
            this.label16.TabIndex = 29;
            this.label16.Text = "mW";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(756, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 22);
            this.label17.TabIndex = 42;
            this.label17.Text = "mW";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(756, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 22);
            this.label18.TabIndex = 41;
            this.label18.Text = "V";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(752, 289);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 22);
            this.label19.TabIndex = 40;
            this.label19.Text = "ohm";
            // 
            // lb_power_external
            // 
            this.lb_power_external.AutoSize = true;
            this.lb_power_external.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_power_external.ForeColor = System.Drawing.Color.Maroon;
            this.lb_power_external.Location = new System.Drawing.Point(641, 349);
            this.lb_power_external.Name = "lb_power_external";
            this.lb_power_external.Size = new System.Drawing.Size(21, 22);
            this.lb_power_external.TabIndex = 39;
            this.lb_power_external.Text = "1";
            // 
            // lb_volt_external
            // 
            this.lb_volt_external.AutoSize = true;
            this.lb_volt_external.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_volt_external.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_volt_external.Location = new System.Drawing.Point(641, 320);
            this.lb_volt_external.Name = "lb_volt_external";
            this.lb_volt_external.Size = new System.Drawing.Size(21, 22);
            this.lb_volt_external.TabIndex = 38;
            this.lb_volt_external.Text = "1";
            // 
            // lb_resist_external
            // 
            this.lb_resist_external.AutoSize = true;
            this.lb_resist_external.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resist_external.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_resist_external.Location = new System.Drawing.Point(641, 289);
            this.lb_resist_external.Name = "lb_resist_external";
            this.lb_resist_external.Size = new System.Drawing.Size(21, 22);
            this.lb_resist_external.TabIndex = 37;
            this.lb_resist_external.Text = "1";
            // 
            // combo_width_external
            // 
            this.combo_width_external.BackColor = System.Drawing.Color.SkyBlue;
            this.combo_width_external.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_width_external.FormattingEnabled = true;
            this.combo_width_external.Items.AddRange(new object[] {
            "mil",
            "mm"});
            this.combo_width_external.Location = new System.Drawing.Point(742, 258);
            this.combo_width_external.Name = "combo_width_external";
            this.combo_width_external.Size = new System.Drawing.Size(53, 28);
            this.combo_width_external.TabIndex = 36;
            this.combo_width_external.Text = "mil";
            this.combo_width_external.SelectedIndexChanged += new System.EventHandler(this.combo_width_external_SelectedIndexChanged);
            // 
            // lb_width_external
            // 
            this.lb_width_external.AutoSize = true;
            this.lb_width_external.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_width_external.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_width_external.Location = new System.Drawing.Point(641, 263);
            this.lb_width_external.Name = "lb_width_external";
            this.lb_width_external.Size = new System.Drawing.Size(21, 22);
            this.lb_width_external.TabIndex = 35;
            this.lb_width_external.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label24.Location = new System.Drawing.Point(492, 220);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(186, 22);
            this.label24.TabIndex = 34;
            this.label24.Text = "External Layers:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(492, 349);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 22);
            this.label25.TabIndex = 33;
            this.label25.Text = "Power Loss:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(470, 320);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(153, 22);
            this.label26.TabIndex = 32;
            this.label26.Text = "Voltage Drop:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(492, 289);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 22);
            this.label27.TabIndex = 31;
            this.label27.Text = "Resistance:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(382, 258);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(241, 22);
            this.label28.TabIndex = 30;
            this.label28.Text = "Required Trace Width:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(130, 83);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 22);
            this.label29.TabIndex = 43;
            this.label29.Text = "Inputs:";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.Black;
            this.lb_time.Location = new System.Drawing.Point(12, 395);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(54, 22);
            this.lb_time.TabIndex = 44;
            this.lb_time.Text = "time";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(253, 269);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 22);
            this.label20.TabIndex = 46;
            this.label20.Text = "inch";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(807, 426);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lb_power_external);
            this.Controls.Add(this.lb_volt_external);
            this.Controls.Add(this.lb_resist_external);
            this.Controls.Add(this.combo_width_external);
            this.Controls.Add(this.lb_width_external);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_power_internal);
            this.Controls.Add(this.lb_volt_internal);
            this.Controls.Add(this.lb_resist_internal);
            this.Controls.Add(this.combo_width_internal);
            this.Controls.Add(this.lb_width_internal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_trace_length);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_t_amb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_t_rise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_thickness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_current);
            this.Controls.Add(this.lb_current);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.MaximizeBox = false;
            this.Name = "principal";
            this.Text = "CANBRICK - PCB width calculator";
            this.Load += new System.EventHandler(this.principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tick_refresco;
        private System.Windows.Forms.Label lb_current;
        private System.Windows.Forms.TextBox txb_current;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_thickness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_t_rise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_t_amb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_trace_length;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_width_internal;
        private System.Windows.Forms.Label lb_resist_internal;
        private System.Windows.Forms.Label lb_volt_internal;
        private System.Windows.Forms.Label lb_power_internal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lb_power_external;
        private System.Windows.Forms.Label lb_volt_external;
        private System.Windows.Forms.Label lb_resist_external;
        private System.Windows.Forms.ComboBox combo_width_external;
        private System.Windows.Forms.Label lb_width_external;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lb_time;
        public System.Windows.Forms.ComboBox combo_width_internal;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label20;
    }
}

