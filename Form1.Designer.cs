namespace alumnos
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
            this.antiguedadtxt = new System.Windows.Forms.TextBox();
            this.noaprobadastxt = new System.Windows.Forms.TextBox();
            this.fechaingtxt = new System.Windows.Forms.TextBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.legajotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechanactxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.activotxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.aprobadastxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edadingtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // antiguedadtxt
            // 
            this.antiguedadtxt.Location = new System.Drawing.Point(618, 489);
            this.antiguedadtxt.Name = "antiguedadtxt";
            this.antiguedadtxt.ReadOnly = true;
            this.antiguedadtxt.Size = new System.Drawing.Size(100, 20);
            this.antiguedadtxt.TabIndex = 0;
            // 
            // noaprobadastxt
            // 
            this.noaprobadastxt.Location = new System.Drawing.Point(451, 491);
            this.noaprobadastxt.Name = "noaprobadastxt";
            this.noaprobadastxt.ReadOnly = true;
            this.noaprobadastxt.Size = new System.Drawing.Size(53, 20);
            this.noaprobadastxt.TabIndex = 1;
            // 
            // fechaingtxt
            // 
            this.fechaingtxt.Location = new System.Drawing.Point(449, 128);
            this.fechaingtxt.Name = "fechaingtxt";
            this.fechaingtxt.Size = new System.Drawing.Size(100, 20);
            this.fechaingtxt.TabIndex = 2;
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(149, 236);
            this.grilla.MultiSelect = false;
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(499, 137);
            this.grilla.TabIndex = 3;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
            // 
            // agregar
            // 
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.agregar.Location = new System.Drawing.Point(150, 442);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(136, 25);
            this.agregar.TabIndex = 4;
            this.agregar.Text = "Agregar Alumno";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // borrar
            // 
            this.borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.borrar.Location = new System.Drawing.Point(540, 443);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(108, 23);
            this.borrar.TabIndex = 6;
            this.borrar.Text = "Borrar Alumno";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(84, 31);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(100, 20);
            this.nombretxt.TabIndex = 7;
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(297, 31);
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(100, 20);
            this.apellidotxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(233, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido";
            // 
            // legajotxt
            // 
            this.legajotxt.Location = new System.Drawing.Point(517, 32);
            this.legajotxt.Name = "legajotxt";
            this.legajotxt.Size = new System.Drawing.Size(70, 20);
            this.legajotxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(460, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Legajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(325, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de ingreso";
            // 
            // fechanactxt
            // 
            this.fechanactxt.Location = new System.Drawing.Point(165, 128);
            this.fechanactxt.Name = "fechanactxt";
            this.fechanactxt.Size = new System.Drawing.Size(100, 20);
            this.fechanactxt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(20, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Activo (ingrese si o no)";
            // 
            // activotxt
            // 
            this.activotxt.Location = new System.Drawing.Point(179, 169);
            this.activotxt.Name = "activotxt";
            this.activotxt.Size = new System.Drawing.Size(100, 20);
            this.activotxt.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.aprobadastxt);
            this.groupBox1.Controls.Add(this.activotxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.apellidotxt);
            this.groupBox1.Controls.Add(this.fechanactxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.legajotxt);
            this.groupBox1.Controls.Add(this.fechaingtxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombretxt);
            this.groupBox1.Location = new System.Drawing.Point(77, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 200);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de ingreso de alumnos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(20, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Materias aprobadas";
            // 
            // aprobadastxt
            // 
            this.aprobadastxt.Location = new System.Drawing.Point(160, 82);
            this.aprobadastxt.Name = "aprobadastxt";
            this.aprobadastxt.Size = new System.Drawing.Size(49, 20);
            this.aprobadastxt.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(277, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Materias no aprobadas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(532, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Antigüedad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dias",
            "Meses",
            "Años"});
            this.comboBox1.Location = new System.Drawing.Point(733, 488);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(12, 495);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Edad de ingreso";
            // 
            // edadingtxt
            // 
            this.edadingtxt.Location = new System.Drawing.Point(150, 492);
            this.edadingtxt.Name = "edadingtxt";
            this.edadingtxt.ReadOnly = true;
            this.edadingtxt.Size = new System.Drawing.Size(100, 20);
            this.edadingtxt.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(145, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(607, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Para modificar un alumno seleccione  el registro, cargue los nuevos datos y presi" +
    "one en Modificar Alumno";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(145, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(514, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Puede ver la edad de ingreso, las materias no aprobadas y la antigüedad seleccion" +
    "ado el alumno en la grilla";
            // 
            // modificar
            // 
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(349, 442);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(125, 23);
            this.modificar.TabIndex = 5;
            this.modificar.Text = "Modificar Alumno";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 540);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.edadingtxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.noaprobadastxt);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.antiguedadtxt);
            this.Name = "Form1";
            this.Text = "Carga de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox antiguedadtxt;
        private System.Windows.Forms.TextBox noaprobadastxt;
        private System.Windows.Forms.TextBox fechaingtxt;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox apellidotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox legajotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fechanactxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox activotxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aprobadastxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edadingtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button modificar;
    }
}

