namespace InterfazImpresora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviarImp = new System.Windows.Forms.Button();
            this.txtInstruccionImp = new System.Windows.Forms.TextBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.btnCerrarImp = new System.Windows.Forms.Button();
            this.txtRespuestaImp = new System.Windows.Forms.TextBox();
            this.btnConsultarImp = new System.Windows.Forms.Button();
            this.btnConsultarPLC = new System.Windows.Forms.Button();
            this.txtRespuestaPLC = new System.Windows.Forms.TextBox();
            this.btnCerrarPLC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInstruccionPLC = new System.Windows.Forms.TextBox();
            this.btnEnviarPLC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRemoto = new System.Windows.Forms.CheckBox();
            this.chkAutomatico = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrden = new System.Windows.Forms.Button();
            this.chkManual = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMotorAtras = new System.Windows.Forms.Button();
            this.btnMotorAdelante = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoImpreso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviarImp
            // 
            this.btnEnviarImp.Location = new System.Drawing.Point(102, 56);
            this.btnEnviarImp.Name = "btnEnviarImp";
            this.btnEnviarImp.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarImp.TabIndex = 0;
            this.btnEnviarImp.Text = "Enviar";
            this.btnEnviarImp.UseVisualStyleBackColor = true;
            this.btnEnviarImp.Click += new System.EventHandler(this.btnEnviarImp_Click);
            // 
            // txtInstruccionImp
            // 
            this.txtInstruccionImp.Location = new System.Drawing.Point(97, 21);
            this.txtInstruccionImp.Name = "txtInstruccionImp";
            this.txtInstruccionImp.Size = new System.Drawing.Size(242, 23);
            this.txtInstruccionImp.TabIndex = 3;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(21, 24);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(66, 15);
            this.lblInstruccion.TabIndex = 6;
            this.lblInstruccion.Text = "Instruccion";
            // 
            // btnCerrarImp
            // 
            this.btnCerrarImp.Location = new System.Drawing.Point(264, 56);
            this.btnCerrarImp.Name = "btnCerrarImp";
            this.btnCerrarImp.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarImp.TabIndex = 8;
            this.btnCerrarImp.Text = "Cerrar";
            this.btnCerrarImp.UseVisualStyleBackColor = true;
            this.btnCerrarImp.Click += new System.EventHandler(this.btnCerrarImp_Click);
            // 
            // txtRespuestaImp
            // 
            this.txtRespuestaImp.Enabled = false;
            this.txtRespuestaImp.Location = new System.Drawing.Point(21, 102);
            this.txtRespuestaImp.Name = "txtRespuestaImp";
            this.txtRespuestaImp.Size = new System.Drawing.Size(318, 23);
            this.txtRespuestaImp.TabIndex = 9;
            // 
            // btnConsultarImp
            // 
            this.btnConsultarImp.Location = new System.Drawing.Point(183, 56);
            this.btnConsultarImp.Name = "btnConsultarImp";
            this.btnConsultarImp.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarImp.TabIndex = 12;
            this.btnConsultarImp.Text = "Consultar";
            this.btnConsultarImp.UseVisualStyleBackColor = true;
            this.btnConsultarImp.Click += new System.EventHandler(this.btnConsultarImp_Click);
            // 
            // btnConsultarPLC
            // 
            this.btnConsultarPLC.Location = new System.Drawing.Point(580, 56);
            this.btnConsultarPLC.Name = "btnConsultarPLC";
            this.btnConsultarPLC.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarPLC.TabIndex = 19;
            this.btnConsultarPLC.Text = "Consultar";
            this.btnConsultarPLC.UseVisualStyleBackColor = true;
            this.btnConsultarPLC.Click += new System.EventHandler(this.btnConsultarPLC_Click);
            // 
            // txtRespuestaPLC
            // 
            this.txtRespuestaPLC.Enabled = false;
            this.txtRespuestaPLC.Location = new System.Drawing.Point(418, 102);
            this.txtRespuestaPLC.Name = "txtRespuestaPLC";
            this.txtRespuestaPLC.Size = new System.Drawing.Size(318, 23);
            this.txtRespuestaPLC.TabIndex = 17;
            // 
            // btnCerrarPLC
            // 
            this.btnCerrarPLC.Location = new System.Drawing.Point(661, 56);
            this.btnCerrarPLC.Name = "btnCerrarPLC";
            this.btnCerrarPLC.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarPLC.TabIndex = 16;
            this.btnCerrarPLC.Text = "Cerrar";
            this.btnCerrarPLC.UseVisualStyleBackColor = true;
            this.btnCerrarPLC.Click += new System.EventHandler(this.btnCerrarPLC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Instruccion";
            // 
            // txtInstruccionPLC
            // 
            this.txtInstruccionPLC.Location = new System.Drawing.Point(494, 21);
            this.txtInstruccionPLC.Name = "txtInstruccionPLC";
            this.txtInstruccionPLC.Size = new System.Drawing.Size(242, 23);
            this.txtInstruccionPLC.TabIndex = 14;
            // 
            // btnEnviarPLC
            // 
            this.btnEnviarPLC.Location = new System.Drawing.Point(499, 56);
            this.btnEnviarPLC.Name = "btnEnviarPLC";
            this.btnEnviarPLC.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarPLC.TabIndex = 13;
            this.btnEnviarPLC.Text = "Enviar";
            this.btnEnviarPLC.UseVisualStyleBackColor = true;
            this.btnEnviarPLC.Click += new System.EventHandler(this.btnEnviarPLC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Impresora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "PLC";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(463, 201);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 22;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(463, 231);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "CONTROL BANDA";
            // 
            // chkRemoto
            // 
            this.chkRemoto.AutoSize = true;
            this.chkRemoto.Location = new System.Drawing.Point(636, 205);
            this.chkRemoto.Name = "chkRemoto";
            this.chkRemoto.Size = new System.Drawing.Size(68, 19);
            this.chkRemoto.TabIndex = 25;
            this.chkRemoto.Text = "Remoto";
            this.chkRemoto.UseVisualStyleBackColor = true;
            this.chkRemoto.Click += new System.EventHandler(this.chkRemoto_Click);
            // 
            // chkAutomatico
            // 
            this.chkAutomatico.AutoSize = true;
            this.chkAutomatico.Location = new System.Drawing.Point(636, 234);
            this.chkAutomatico.Name = "chkAutomatico";
            this.chkAutomatico.Size = new System.Drawing.Size(89, 19);
            this.chkAutomatico.TabIndex = 26;
            this.chkAutomatico.Text = "Automático";
            this.chkAutomatico.UseVisualStyleBackColor = true;
            this.chkAutomatico.Click += new System.EventHandler(this.chkAutomatico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "CONDICIONES DE ARRANQUE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.Location = new System.Drawing.Point(557, 311);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(75, 23);
            this.btnOrden.TabIndex = 28;
            this.btnOrden.Text = "Orden";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.Location = new System.Drawing.Point(636, 259);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(66, 19);
            this.chkManual.TabIndex = 29;
            this.chkManual.Text = "Manual";
            this.chkManual.UseVisualStyleBackColor = true;
            this.chkManual.Click += new System.EventHandler(this.chkManual_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "CONTROL MOTOR MANUAL";
            // 
            // btnMotorAtras
            // 
            this.btnMotorAtras.Location = new System.Drawing.Point(77, 282);
            this.btnMotorAtras.Name = "btnMotorAtras";
            this.btnMotorAtras.Size = new System.Drawing.Size(75, 23);
            this.btnMotorAtras.TabIndex = 31;
            this.btnMotorAtras.Text = "Atrás";
            this.btnMotorAtras.UseVisualStyleBackColor = true;
            this.btnMotorAtras.Click += new System.EventHandler(this.btnMotorAtras_Click);
            // 
            // btnMotorAdelante
            // 
            this.btnMotorAdelante.Location = new System.Drawing.Point(183, 282);
            this.btnMotorAdelante.Name = "btnMotorAdelante";
            this.btnMotorAdelante.Size = new System.Drawing.Size(75, 23);
            this.btnMotorAdelante.TabIndex = 32;
            this.btnMotorAdelante.Text = "Adelante ";
            this.btnMotorAdelante.UseVisualStyleBackColor = true;
            this.btnMotorAdelante.Click += new System.EventHandler(this.btnMotorAdelante_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(557, 429);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "ALARMA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 23);
            this.textBox1.TabIndex = 35;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 201);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(92, 15);
            this.lblCodigo.TabIndex = 36;
            this.lblCodigo.Text = "Codigo impreso";
            // 
            // txtCodigoImpreso
            // 
            this.txtCodigoImpreso.Location = new System.Drawing.Point(117, 198);
            this.txtCodigoImpreso.Name = "txtCodigoImpreso";
            this.txtCodigoImpreso.Size = new System.Drawing.Size(227, 23);
            this.txtCodigoImpreso.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 464);
            this.Controls.Add(this.txtCodigoImpreso);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMotorAdelante);
            this.Controls.Add(this.btnMotorAtras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkManual);
            this.Controls.Add(this.btnOrden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkAutomatico);
            this.Controls.Add(this.chkRemoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultarPLC);
            this.Controls.Add(this.txtRespuestaPLC);
            this.Controls.Add(this.btnCerrarPLC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstruccionPLC);
            this.Controls.Add(this.btnEnviarPLC);
            this.Controls.Add(this.btnConsultarImp);
            this.Controls.Add(this.txtRespuestaImp);
            this.Controls.Add(this.btnCerrarImp);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.txtInstruccionImp);
            this.Controls.Add(this.btnEnviarImp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnviarImp;
        private TextBox txtInstruccionImp;
        private Label lblInstruccion;
        private Button btnCerrarImp;
        private TextBox txtRespuestaImp;
        private Button btnConsultarImp;
        private Button btnConsultarPLC;
        private TextBox txtRespuestaPLC;
        private Button btnCerrarPLC;
        private Label label1;
        private TextBox txtInstruccionPLC;
        private Button btnEnviarPLC;
        private Label label2;
        private Label label3;
        private Button Start;
        private Button btnStop;
        private Label label4;
        private CheckBox chkRemoto;
        private CheckBox chkAutomatico;
        private Label label5;
        private Button btnOrden;
        private CheckBox chkManual;
        private Label label6;
        private Button btnMotorAtras;
        private Button btnMotorAdelante;
        private Button btnReset;
        private Label label7;
        private TextBox textBox1;
        private Label lblCodigo;
        private TextBox txtCodigoImpreso;
    }
}