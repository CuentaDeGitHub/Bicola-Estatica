namespace BiColaEstaticaDeAdevis
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncolarIzq = new System.Windows.Forms.Button();
            this.btnEncolarDer = new System.Windows.Forms.Button();
            this.btnDesencolarIzq = new System.Windows.Forms.Button();
            this.btnDesencolarDer = new System.Windows.Forms.Button();
            this.btnFrente = new System.Windows.Forms.Button();
            this.lblCola = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEncolarIzq
            // 
            this.btnEncolarIzq.Location = new System.Drawing.Point(92, 23);
            this.btnEncolarIzq.Name = "btnEncolarIzq";
            this.btnEncolarIzq.Size = new System.Drawing.Size(75, 23);
            this.btnEncolarIzq.TabIndex = 1;
            this.btnEncolarIzq.Text = "Encolar Izq";
            this.btnEncolarIzq.UseVisualStyleBackColor = true;
            this.btnEncolarIzq.Click += new System.EventHandler(this.btnEncolarIzq_Click);
            // 
            // btnEncolarDer
            // 
            this.btnEncolarDer.Location = new System.Drawing.Point(173, 23);
            this.btnEncolarDer.Name = "btnEncolarDer";
            this.btnEncolarDer.Size = new System.Drawing.Size(75, 23);
            this.btnEncolarDer.TabIndex = 2;
            this.btnEncolarDer.Text = "Encolar Der";
            this.btnEncolarDer.UseVisualStyleBackColor = true;
            this.btnEncolarDer.Click += new System.EventHandler(this.btnEncolarDer_Click);
            // 
            // btnDesencolarIzq
            // 
            this.btnDesencolarIzq.Location = new System.Drawing.Point(283, 52);
            this.btnDesencolarIzq.Name = "btnDesencolarIzq";
            this.btnDesencolarIzq.Size = new System.Drawing.Size(103, 23);
            this.btnDesencolarIzq.TabIndex = 3;
            this.btnDesencolarIzq.Text = "Desencolar Izq";
            this.btnDesencolarIzq.UseVisualStyleBackColor = true;
            this.btnDesencolarIzq.Click += new System.EventHandler(this.btnDesencolarIzq_Click);
            // 
            // btnDesencolarDer
            // 
            this.btnDesencolarDer.Location = new System.Drawing.Point(392, 52);
            this.btnDesencolarDer.Name = "btnDesencolarDer";
            this.btnDesencolarDer.Size = new System.Drawing.Size(103, 23);
            this.btnDesencolarDer.TabIndex = 4;
            this.btnDesencolarDer.Text = "Desencolar Der";
            this.btnDesencolarDer.UseVisualStyleBackColor = true;
            this.btnDesencolarDer.Click += new System.EventHandler(this.btnDesencolarDer_Click);
            // 
            // btnFrente
            // 
            this.btnFrente.Location = new System.Drawing.Point(283, 81);
            this.btnFrente.Name = "btnFrente";
            this.btnFrente.Size = new System.Drawing.Size(75, 23);
            this.btnFrente.TabIndex = 5;
            this.btnFrente.Text = "Frente";
            this.btnFrente.UseVisualStyleBackColor = true;
            this.btnFrente.Click += new System.EventHandler(this.btnFrente_Click);
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(280, 28);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(28, 13);
            this.lblCola.TabIndex = 6;
            this.lblCola.Text = "Cola";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(9, 25);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 20);
            this.txtDato.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtArchivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDato);
            this.groupBox1.Controls.Add(this.btnEncolarIzq);
            this.groupBox1.Controls.Add(this.lblCola);
            this.groupBox1.Controls.Add(this.btnEncolarDer);
            this.groupBox1.Controls.Add(this.btnFrente);
            this.groupBox1.Controls.Add(this.btnDesencolarIzq);
            this.groupBox1.Controls.Add(this.btnDesencolarDer);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(9, 67);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(92, 67);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtArchivo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del archivo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.txtTamaño);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 34);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(227, 7);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(146, 7);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(107, 9);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(33, 20);
            this.txtTamaño.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tamaño de la cola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 151);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncolarIzq;
        private System.Windows.Forms.Button btnEncolarDer;
        private System.Windows.Forms.Button btnDesencolarIzq;
        private System.Windows.Forms.Button btnDesencolarDer;
        private System.Windows.Forms.Button btnFrente;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label3;
    }
}

