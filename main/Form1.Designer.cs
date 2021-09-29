namespace FIBONACCI_DINAMICA_MEMOIZACION
{
    partial class ProgDinMem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgDinMem));
            this.TopWrapper = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiboDin = new System.Windows.Forms.Panel();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbx1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.TituloPanel1 = new System.Windows.Forms.Label();
            this.FiboMem = new System.Windows.Forms.Panel();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TituloPanel2 = new System.Windows.Forms.Label();
            this.lbx2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.INTRODUCCION = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RightWrapper = new System.Windows.Forms.Panel();
            this.TopWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.FiboDin.SuspendLayout();
            this.FiboMem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RightWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopWrapper
            // 
            this.TopWrapper.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TopWrapper.Controls.Add(this.btnMinimizar);
            this.TopWrapper.Controls.Add(this.btnSalir);
            this.TopWrapper.Controls.Add(this.label1);
            this.TopWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopWrapper.Location = new System.Drawing.Point(0, 0);
            this.TopWrapper.Name = "TopWrapper";
            this.TopWrapper.Size = new System.Drawing.Size(1300, 50);
            this.TopWrapper.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::FIBONACCI_DINAMICA_MEMOIZACION.Properties.Resources.MINIMIZAR_0;
            this.btnMinimizar.Location = new System.Drawing.Point(1222, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseDown);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseMove);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::FIBONACCI_DINAMICA_MEMOIZACION.Properties.Resources.SALIR_0;
            this.btnSalir.Location = new System.Drawing.Point(1258, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 3;
            this.btnSalir.TabStop = false;
            this.btnSalir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseDown);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROGRAMACION DINAMICA Y MEMOIZACION";
            // 
            // FiboDin
            // 
            this.FiboDin.BackColor = System.Drawing.Color.White;
            this.FiboDin.Controls.Add(this.txtResultado1);
            this.FiboDin.Controls.Add(this.label5);
            this.FiboDin.Controls.Add(this.label3);
            this.FiboDin.Controls.Add(this.lbx1);
            this.FiboDin.Controls.Add(this.button1);
            this.FiboDin.Controls.Add(this.txt1);
            this.FiboDin.Controls.Add(this.TituloPanel1);
            this.FiboDin.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiboDin.Location = new System.Drawing.Point(650, 50);
            this.FiboDin.Name = "FiboDin";
            this.FiboDin.Size = new System.Drawing.Size(650, 325);
            this.FiboDin.TabIndex = 2;
            // 
            // txtResultado1
            // 
            this.txtResultado1.BackColor = System.Drawing.Color.White;
            this.txtResultado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado1.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado1.Location = new System.Drawing.Point(10, 204);
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.ReadOnly = true;
            this.txtResultado1.Size = new System.Drawing.Size(302, 37);
            this.txtResultado1.TabIndex = 10;
            this.txtResultado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calcula para:";
            // 
            // lbx1
            // 
            this.lbx1.BackColor = System.Drawing.SystemColors.Info;
            this.lbx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx1.FormattingEnabled = true;
            this.lbx1.ItemHeight = 19;
            this.lbx1.Location = new System.Drawing.Point(328, 61);
            this.lbx1.Name = "lbx1";
            this.lbx1.Size = new System.Drawing.Size(298, 228);
            this.lbx1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(167, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.Gainsboro;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(167, 61);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(146, 30);
            this.txt1.TabIndex = 4;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TituloPanel1
            // 
            this.TituloPanel1.AutoSize = true;
            this.TituloPanel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPanel1.ForeColor = System.Drawing.Color.Black;
            this.TituloPanel1.Location = new System.Drawing.Point(7, 3);
            this.TituloPanel1.Name = "TituloPanel1";
            this.TituloPanel1.Size = new System.Drawing.Size(552, 21);
            this.TituloPanel1.TabIndex = 3;
            this.TituloPanel1.Text = "SERIE FIBONACCI CON PROGRAMACION DINAMICA";
            // 
            // FiboMem
            // 
            this.FiboMem.BackColor = System.Drawing.Color.White;
            this.FiboMem.Controls.Add(this.txtResultado2);
            this.FiboMem.Controls.Add(this.label6);
            this.FiboMem.Controls.Add(this.label4);
            this.FiboMem.Controls.Add(this.TituloPanel2);
            this.FiboMem.Controls.Add(this.lbx2);
            this.FiboMem.Controls.Add(this.button2);
            this.FiboMem.Controls.Add(this.txt2);
            this.FiboMem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FiboMem.Location = new System.Drawing.Point(650, 375);
            this.FiboMem.Name = "FiboMem";
            this.FiboMem.Size = new System.Drawing.Size(650, 325);
            this.FiboMem.TabIndex = 3;
            // 
            // txtResultado2
            // 
            this.txtResultado2.BackColor = System.Drawing.Color.White;
            this.txtResultado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado2.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado2.Location = new System.Drawing.Point(11, 232);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.ReadOnly = true;
            this.txtResultado2.Size = new System.Drawing.Size(302, 37);
            this.txtResultado2.TabIndex = 10;
            this.txtResultado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Calcula para:";
            // 
            // TituloPanel2
            // 
            this.TituloPanel2.AutoSize = true;
            this.TituloPanel2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPanel2.ForeColor = System.Drawing.Color.Black;
            this.TituloPanel2.Location = new System.Drawing.Point(7, 3);
            this.TituloPanel2.Name = "TituloPanel2";
            this.TituloPanel2.Size = new System.Drawing.Size(414, 21);
            this.TituloPanel2.TabIndex = 4;
            this.TituloPanel2.Text = "SERIE FIBONACCI CON MEMOIZACION";
            // 
            // lbx2
            // 
            this.lbx2.BackColor = System.Drawing.SystemColors.Info;
            this.lbx2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx2.FormattingEnabled = true;
            this.lbx2.ItemHeight = 19;
            this.lbx2.Location = new System.Drawing.Point(328, 57);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(298, 228);
            this.lbx2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(167, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "CALCULAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.Gainsboro;
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(167, 57);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(146, 30);
            this.txt2.TabIndex = 8;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // INTRODUCCION
            // 
            this.INTRODUCCION.AutoSize = true;
            this.INTRODUCCION.BackColor = System.Drawing.Color.Transparent;
            this.INTRODUCCION.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTRODUCCION.ForeColor = System.Drawing.Color.White;
            this.INTRODUCCION.Location = new System.Drawing.Point(12, 20);
            this.INTRODUCCION.Name = "INTRODUCCION";
            this.INTRODUCCION.Size = new System.Drawing.Size(227, 26);
            this.INTRODUCCION.TabIndex = 2;
            this.INTRODUCCION.Text = "INTRODUCCION";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.Descripcion.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.ForeColor = System.Drawing.Color.White;
            this.Descripcion.Location = new System.Drawing.Point(12, 67);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(628, 104);
            this.Descripcion.TabIndex = 3;
            this.Descripcion.Text = "La programación  dinámica  es  un  método para \r\nreducir el tiempo de ejecución d" +
    "e un algoritmo \r\nmediante la utilización de subproblemas super-\r\npuestos y subes" +
    "tructuras óptimas.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 156);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FIBONACCI_DINAMICA_MEMOIZACION.Properties.Resources.Logo_EMI_1;
            this.pictureBox1.Location = new System.Drawing.Point(169, 493);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(607, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "ESCUELA MILITAR DE INGENIERIA UNIDAD ACADEMICA SANTA CRUZ";
            // 
            // RightWrapper
            // 
            this.RightWrapper.BackColor = System.Drawing.Color.SlateGray;
            this.RightWrapper.BackgroundImage = global::FIBONACCI_DINAMICA_MEMOIZACION.Properties.Resources.FONDO_1;
            this.RightWrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightWrapper.Controls.Add(this.label7);
            this.RightWrapper.Controls.Add(this.pictureBox1);
            this.RightWrapper.Controls.Add(this.label2);
            this.RightWrapper.Controls.Add(this.Descripcion);
            this.RightWrapper.Controls.Add(this.INTRODUCCION);
            this.RightWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.RightWrapper.Location = new System.Drawing.Point(0, 50);
            this.RightWrapper.Name = "RightWrapper";
            this.RightWrapper.Size = new System.Drawing.Size(650, 650);
            this.RightWrapper.TabIndex = 1;
            // 
            // ProgDinMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.FiboMem);
            this.Controls.Add(this.FiboDin);
            this.Controls.Add(this.RightWrapper);
            this.Controls.Add(this.TopWrapper);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProgDinMem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROGRAMACION DINAMICA Y MEMOIZACION";
            this.TopWrapper.ResumeLayout(false);
            this.TopWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.FiboDin.ResumeLayout(false);
            this.FiboDin.PerformLayout();
            this.FiboMem.ResumeLayout(false);
            this.FiboMem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RightWrapper.ResumeLayout(false);
            this.RightWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopWrapper;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Panel FiboDin;
        private System.Windows.Forms.Label TituloPanel1;
        private System.Windows.Forms.Panel FiboMem;
        private System.Windows.Forms.Label TituloPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbx1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbx2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label INTRODUCCION;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel RightWrapper;
    }
}

