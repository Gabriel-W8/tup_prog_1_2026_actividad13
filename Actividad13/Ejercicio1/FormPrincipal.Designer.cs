namespace Ejercicio1
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.btnBuscarYVerAlumno = new System.Windows.Forms.Button();
            this.btnMostrarListadoOrdenado = new System.Windows.Forms.Button();
            this.btnMayoresAlPromedio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLU = new System.Windows.Forms.TextBox();
            this.rbBurbuja = new System.Windows.Forms.RadioButton();
            this.rbBinaria = new System.Windows.Forms.RadioButton();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.rbSecuencial = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarAlumno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud de valor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBinaria);
            this.groupBox2.Controls.Add(this.rbSecuencial);
            this.groupBox2.Controls.Add(this.tbLU);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBuscarYVerAlumno);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salidas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbQuickSort);
            this.groupBox3.Controls.Add(this.rbBurbuja);
            this.groupBox3.Controls.Add(this.btnMostrarListadoOrdenado);
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 94);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salidas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMayoresAlPromedio);
            this.groupBox4.Location = new System.Drawing.Point(12, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 81);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salidas";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(56, 29);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(105, 28);
            this.btnRegistrarAlumno.TabIndex = 0;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnBuscarYVerAlumno
            // 
            this.btnBuscarYVerAlumno.Location = new System.Drawing.Point(126, 19);
            this.btnBuscarYVerAlumno.Name = "btnBuscarYVerAlumno";
            this.btnBuscarYVerAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarYVerAlumno.TabIndex = 1;
            this.btnBuscarYVerAlumno.Text = "Buscar";
            this.btnBuscarYVerAlumno.UseVisualStyleBackColor = true;
            // 
            // btnMostrarListadoOrdenado
            // 
            this.btnMostrarListadoOrdenado.Location = new System.Drawing.Point(74, 28);
            this.btnMostrarListadoOrdenado.Name = "btnMostrarListadoOrdenado";
            this.btnMostrarListadoOrdenado.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarListadoOrdenado.TabIndex = 2;
            this.btnMostrarListadoOrdenado.Text = "Mostrar Listado";
            this.btnMostrarListadoOrdenado.UseVisualStyleBackColor = true;
            // 
            // btnMayoresAlPromedio
            // 
            this.btnMayoresAlPromedio.Location = new System.Drawing.Point(56, 28);
            this.btnMayoresAlPromedio.Name = "btnMayoresAlPromedio";
            this.btnMayoresAlPromedio.Size = new System.Drawing.Size(105, 28);
            this.btnMayoresAlPromedio.TabIndex = 3;
            this.btnMayoresAlPromedio.Text = "Listar Ordenado";
            this.btnMayoresAlPromedio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LU:";
            // 
            // tbLU
            // 
            this.tbLU.Location = new System.Drawing.Point(40, 21);
            this.tbLU.Name = "tbLU";
            this.tbLU.Size = new System.Drawing.Size(80, 20);
            this.tbLU.TabIndex = 3;
            // 
            // rbBurbuja
            // 
            this.rbBurbuja.AutoSize = true;
            this.rbBurbuja.Checked = true;
            this.rbBurbuja.Location = new System.Drawing.Point(20, 57);
            this.rbBurbuja.Name = "rbBurbuja";
            this.rbBurbuja.Size = new System.Drawing.Size(61, 17);
            this.rbBurbuja.TabIndex = 4;
            this.rbBurbuja.TabStop = true;
            this.rbBurbuja.Text = "Burbuja";
            this.rbBurbuja.UseVisualStyleBackColor = true;
            // 
            // rbBinaria
            // 
            this.rbBinaria.AutoSize = true;
            this.rbBinaria.Location = new System.Drawing.Point(104, 48);
            this.rbBinaria.Name = "rbBinaria";
            this.rbBinaria.Size = new System.Drawing.Size(57, 17);
            this.rbBinaria.TabIndex = 5;
            this.rbBinaria.Text = "Binaria";
            this.rbBinaria.UseVisualStyleBackColor = true;
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Location = new System.Drawing.Point(104, 57);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(72, 17);
            this.rbQuickSort.TabIndex = 7;
            this.rbQuickSort.TabStop = true;
            this.rbQuickSort.Text = "QuickSort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // rbSecuencial
            // 
            this.rbSecuencial.AutoSize = true;
            this.rbSecuencial.Checked = true;
            this.rbSecuencial.Location = new System.Drawing.Point(20, 47);
            this.rbSecuencial.Name = "rbSecuencial";
            this.rbSecuencial.Size = new System.Drawing.Size(78, 17);
            this.rbSecuencial.TabIndex = 6;
            this.rbSecuencial.TabStop = true;
            this.rbSecuencial.Text = "Secuencial";
            this.rbSecuencial.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad 13";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBinaria;
        private System.Windows.Forms.RadioButton rbBurbuja;
        private System.Windows.Forms.TextBox tbLU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarYVerAlumno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbSecuencial;
        private System.Windows.Forms.Button btnMostrarListadoOrdenado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMayoresAlPromedio;
    }
}

