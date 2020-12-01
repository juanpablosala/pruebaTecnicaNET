namespace PruebaTecnicaNET
{
    partial class FrmEscuela
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
            this.tcEscuela = new System.Windows.Forms.TabControl();
            this.tpAlumnos = new System.Windows.Forms.TabPage();
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.btnEditarAlumno = new System.Windows.Forms.Button();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.chkAlumnoActivo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpAlumnoFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlumnoCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlumnoEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlumnoDomicilio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlumnoDNI = new System.Windows.Forms.NumericUpDown();
            this.txtAlumnoApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlumnoNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvAlumnos = new System.Windows.Forms.DataGridView();
            this.tpCursos = new System.Windows.Forms.TabPage();
            this.chkCursoActivo = new System.Windows.Forms.CheckBox();
            this.btnCursoNuevo = new System.Windows.Forms.Button();
            this.btnCursoEditar = new System.Windows.Forms.Button();
            this.btnCursoGuardar = new System.Windows.Forms.Button();
            this.gvCursos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCursoDescripcion = new System.Windows.Forms.TextBox();
            this.txtCursoDenominacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpInscripcion = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.gvAlumnosxCurso = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.chkFinalizado = new System.Windows.Forms.CheckBox();
            this.chkEnCurso = new System.Windows.Forms.CheckBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tcEscuela.SuspendLayout();
            this.tpAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlumnoDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlumnos)).BeginInit();
            this.tpCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCursos)).BeginInit();
            this.tpInscripcion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlumnosxCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEscuela
            // 
            this.tcEscuela.Controls.Add(this.tpAlumnos);
            this.tcEscuela.Controls.Add(this.tpCursos);
            this.tcEscuela.Controls.Add(this.tpInscripcion);
            this.tcEscuela.Location = new System.Drawing.Point(2, 6);
            this.tcEscuela.Name = "tcEscuela";
            this.tcEscuela.SelectedIndex = 0;
            this.tcEscuela.Size = new System.Drawing.Size(856, 483);
            this.tcEscuela.TabIndex = 0;
            this.tcEscuela.SelectedIndexChanged += new System.EventHandler(this.tcEscuela_SelectedIndexChanged);
            // 
            // tpAlumnos
            // 
            this.tpAlumnos.Controls.Add(this.btnNuevoAlumno);
            this.tpAlumnos.Controls.Add(this.btnEditarAlumno);
            this.tpAlumnos.Controls.Add(this.btnGuardarAlumno);
            this.tpAlumnos.Controls.Add(this.chkAlumnoActivo);
            this.tpAlumnos.Controls.Add(this.label7);
            this.tpAlumnos.Controls.Add(this.dtpAlumnoFechaNac);
            this.tpAlumnos.Controls.Add(this.label6);
            this.tpAlumnos.Controls.Add(this.txtAlumnoCelular);
            this.tpAlumnos.Controls.Add(this.label5);
            this.tpAlumnos.Controls.Add(this.txtAlumnoEmail);
            this.tpAlumnos.Controls.Add(this.label4);
            this.tpAlumnos.Controls.Add(this.txtAlumnoDomicilio);
            this.tpAlumnos.Controls.Add(this.label3);
            this.tpAlumnos.Controls.Add(this.txtAlumnoDNI);
            this.tpAlumnos.Controls.Add(this.txtAlumnoApellido);
            this.tpAlumnos.Controls.Add(this.label2);
            this.tpAlumnos.Controls.Add(this.txtAlumnoNombre);
            this.tpAlumnos.Controls.Add(this.label1);
            this.tpAlumnos.Controls.Add(this.gvAlumnos);
            this.tpAlumnos.Location = new System.Drawing.Point(4, 24);
            this.tpAlumnos.Name = "tpAlumnos";
            this.tpAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlumnos.Size = new System.Drawing.Size(848, 455);
            this.tpAlumnos.TabIndex = 0;
            this.tpAlumnos.Text = "Alumnos";
            this.tpAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.Location = new System.Drawing.Point(752, 7);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoAlumno.TabIndex = 9;
            this.btnNuevoAlumno.Text = "Nuevo";
            this.btnNuevoAlumno.UseVisualStyleBackColor = true;
            this.btnNuevoAlumno.Click += new System.EventHandler(this.btnNuevoAlumno_Click);
            // 
            // btnEditarAlumno
            // 
            this.btnEditarAlumno.Location = new System.Drawing.Point(752, 85);
            this.btnEditarAlumno.Name = "btnEditarAlumno";
            this.btnEditarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnEditarAlumno.TabIndex = 8;
            this.btnEditarAlumno.Text = "Editar";
            this.btnEditarAlumno.UseVisualStyleBackColor = true;
            this.btnEditarAlumno.Click += new System.EventHandler(this.btnEditarAlumno_Click);
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(752, 48);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlumno.TabIndex = 7;
            this.btnGuardarAlumno.Text = "Guardar";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // chkAlumnoActivo
            // 
            this.chkAlumnoActivo.AutoSize = true;
            this.chkAlumnoActivo.Location = new System.Drawing.Point(657, 41);
            this.chkAlumnoActivo.Name = "chkAlumnoActivo";
            this.chkAlumnoActivo.Size = new System.Drawing.Size(60, 19);
            this.chkAlumnoActivo.TabIndex = 6;
            this.chkAlumnoActivo.Text = "Activo";
            this.chkAlumnoActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // dtpAlumnoFechaNac
            // 
            this.dtpAlumnoFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlumnoFechaNac.Location = new System.Drawing.Point(566, 39);
            this.dtpAlumnoFechaNac.Name = "dtpAlumnoFechaNac";
            this.dtpAlumnoFechaNac.Size = new System.Drawing.Size(78, 23);
            this.dtpAlumnoFechaNac.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Celular:";
            // 
            // txtAlumnoCelular
            // 
            this.txtAlumnoCelular.Location = new System.Drawing.Point(330, 39);
            this.txtAlumnoCelular.Name = "txtAlumnoCelular";
            this.txtAlumnoCelular.Size = new System.Drawing.Size(126, 23);
            this.txtAlumnoCelular.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // txtAlumnoEmail
            // 
            this.txtAlumnoEmail.Location = new System.Drawing.Point(56, 39);
            this.txtAlumnoEmail.Name = "txtAlumnoEmail";
            this.txtAlumnoEmail.Size = new System.Drawing.Size(224, 23);
            this.txtAlumnoEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Domicilio:";
            // 
            // txtAlumnoDomicilio
            // 
            this.txtAlumnoDomicilio.Location = new System.Drawing.Point(554, 7);
            this.txtAlumnoDomicilio.Name = "txtAlumnoDomicilio";
            this.txtAlumnoDomicilio.Size = new System.Drawing.Size(161, 23);
            this.txtAlumnoDomicilio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dni:";
            // 
            // txtAlumnoDNI
            // 
            this.txtAlumnoDNI.Location = new System.Drawing.Point(365, 7);
            this.txtAlumnoDNI.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtAlumnoDNI.Name = "txtAlumnoDNI";
            this.txtAlumnoDNI.Size = new System.Drawing.Size(120, 23);
            this.txtAlumnoDNI.TabIndex = 2;
            // 
            // txtAlumnoApellido
            // 
            this.txtAlumnoApellido.Location = new System.Drawing.Point(220, 7);
            this.txtAlumnoApellido.Name = "txtAlumnoApellido";
            this.txtAlumnoApellido.Size = new System.Drawing.Size(100, 23);
            this.txtAlumnoApellido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // txtAlumnoNombre
            // 
            this.txtAlumnoNombre.Location = new System.Drawing.Point(58, 7);
            this.txtAlumnoNombre.Name = "txtAlumnoNombre";
            this.txtAlumnoNombre.Size = new System.Drawing.Size(100, 23);
            this.txtAlumnoNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // gvAlumnos
            // 
            this.gvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAlumnos.Location = new System.Drawing.Point(6, 87);
            this.gvAlumnos.Name = "gvAlumnos";
            this.gvAlumnos.Size = new System.Drawing.Size(711, 354);
            this.gvAlumnos.TabIndex = 0;
            this.gvAlumnos.TabStop = false;
            this.gvAlumnos.Text = "dataGridView1";
            this.gvAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAlumnos_CellDoubleClick);
            // 
            // tpCursos
            // 
            this.tpCursos.Controls.Add(this.chkCursoActivo);
            this.tpCursos.Controls.Add(this.btnCursoNuevo);
            this.tpCursos.Controls.Add(this.btnCursoEditar);
            this.tpCursos.Controls.Add(this.btnCursoGuardar);
            this.tpCursos.Controls.Add(this.gvCursos);
            this.tpCursos.Controls.Add(this.label9);
            this.tpCursos.Controls.Add(this.txtCursoDescripcion);
            this.tpCursos.Controls.Add(this.txtCursoDenominacion);
            this.tpCursos.Controls.Add(this.label8);
            this.tpCursos.Location = new System.Drawing.Point(4, 24);
            this.tpCursos.Name = "tpCursos";
            this.tpCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tpCursos.Size = new System.Drawing.Size(848, 455);
            this.tpCursos.TabIndex = 1;
            this.tpCursos.Text = "Cursos";
            this.tpCursos.UseVisualStyleBackColor = true;
            // 
            // chkCursoActivo
            // 
            this.chkCursoActivo.AutoSize = true;
            this.chkCursoActivo.Location = new System.Drawing.Point(419, 66);
            this.chkCursoActivo.Name = "chkCursoActivo";
            this.chkCursoActivo.Size = new System.Drawing.Size(60, 19);
            this.chkCursoActivo.TabIndex = 6;
            this.chkCursoActivo.Text = "Activo";
            this.chkCursoActivo.UseVisualStyleBackColor = true;
            // 
            // btnCursoNuevo
            // 
            this.btnCursoNuevo.Location = new System.Drawing.Point(498, 20);
            this.btnCursoNuevo.Name = "btnCursoNuevo";
            this.btnCursoNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnCursoNuevo.TabIndex = 24;
            this.btnCursoNuevo.Text = "Nuevo";
            this.btnCursoNuevo.UseVisualStyleBackColor = true;
            this.btnCursoNuevo.Click += new System.EventHandler(this.btnNuevoCurso_Click);
            // 
            // btnCursoEditar
            // 
            this.btnCursoEditar.Location = new System.Drawing.Point(498, 98);
            this.btnCursoEditar.Name = "btnCursoEditar";
            this.btnCursoEditar.Size = new System.Drawing.Size(75, 23);
            this.btnCursoEditar.TabIndex = 23;
            this.btnCursoEditar.Text = "Editar";
            this.btnCursoEditar.UseVisualStyleBackColor = true;
            this.btnCursoEditar.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // btnCursoGuardar
            // 
            this.btnCursoGuardar.Location = new System.Drawing.Point(498, 61);
            this.btnCursoGuardar.Name = "btnCursoGuardar";
            this.btnCursoGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnCursoGuardar.TabIndex = 22;
            this.btnCursoGuardar.Text = "Guardar";
            this.btnCursoGuardar.UseVisualStyleBackColor = true;
            this.btnCursoGuardar.Click += new System.EventHandler(this.btnGuardarCurso_Click);
            // 
            // gvCursos
            // 
            this.gvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCursos.Location = new System.Drawing.Point(11, 102);
            this.gvCursos.Name = "gvCursos";
            this.gvCursos.Size = new System.Drawing.Size(464, 344);
            this.gvCursos.TabIndex = 1;
            this.gvCursos.TabStop = false;
            this.gvCursos.Text = "dataGridView1";
            this.gvCursos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCursos_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Descripción:";
            // 
            // txtCursoDescripcion
            // 
            this.txtCursoDescripcion.Location = new System.Drawing.Point(113, 62);
            this.txtCursoDescripcion.Name = "txtCursoDescripcion";
            this.txtCursoDescripcion.Size = new System.Drawing.Size(253, 23);
            this.txtCursoDescripcion.TabIndex = 21;
            // 
            // txtCursoDenominacion
            // 
            this.txtCursoDenominacion.Location = new System.Drawing.Point(113, 25);
            this.txtCursoDenominacion.Name = "txtCursoDenominacion";
            this.txtCursoDenominacion.Size = new System.Drawing.Size(100, 23);
            this.txtCursoDenominacion.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Denominación:";
            // 
            // tpInscripcion
            // 
            this.tpInscripcion.Controls.Add(this.groupBox1);
            this.tpInscripcion.Controls.Add(this.chkFinalizado);
            this.tpInscripcion.Controls.Add(this.chkEnCurso);
            this.tpInscripcion.Controls.Add(this.chkActivo);
            this.tpInscripcion.Controls.Add(this.label11);
            this.tpInscripcion.Controls.Add(this.cmbCursos);
            this.tpInscripcion.Controls.Add(this.label10);
            this.tpInscripcion.Location = new System.Drawing.Point(4, 24);
            this.tpInscripcion.Name = "tpInscripcion";
            this.tpInscripcion.Size = new System.Drawing.Size(848, 455);
            this.tpInscripcion.TabIndex = 2;
            this.tpInscripcion.Text = "Inscripción";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarAlumno);
            this.groupBox1.Controls.Add(this.gvAlumnosxCurso);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbAlumnos);
            this.groupBox1.Location = new System.Drawing.Point(6, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 396);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos por curso";
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(538, 44);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarAlumno.TabIndex = 4;
            this.btnAgregarAlumno.Text = "Agregar a Curso";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // gvAlumnosxCurso
            // 
            this.gvAlumnosxCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAlumnosxCurso.Location = new System.Drawing.Point(8, 23);
            this.gvAlumnosxCurso.Name = "gvAlumnosxCurso";
            this.gvAlumnosxCurso.Size = new System.Drawing.Size(240, 365);
            this.gvAlumnosxCurso.TabIndex = 3;
            this.gvAlumnosxCurso.Text = "dataGridView1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Alumnos:";
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(336, 45);
            this.cmbAlumnos.MaxDropDownItems = 100;
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(187, 23);
            this.cmbAlumnos.TabIndex = 1;
            this.cmbAlumnos.SelectionChangeCommitted += new System.EventHandler(this.cmbCursos_SelectionChangeCommitted);
            // 
            // chkFinalizado
            // 
            this.chkFinalizado.AutoSize = true;
            this.chkFinalizado.Location = new System.Drawing.Point(479, 10);
            this.chkFinalizado.Name = "chkFinalizado";
            this.chkFinalizado.Size = new System.Drawing.Size(79, 19);
            this.chkFinalizado.TabIndex = 2;
            this.chkFinalizado.Text = "Finalizado";
            this.chkFinalizado.UseVisualStyleBackColor = true;
            this.chkFinalizado.CheckedChanged += new System.EventHandler(this.chkFinalizado_CheckedChanged);
            // 
            // chkEnCurso
            // 
            this.chkEnCurso.AutoSize = true;
            this.chkEnCurso.Location = new System.Drawing.Point(401, 10);
            this.chkEnCurso.Name = "chkEnCurso";
            this.chkEnCurso.Size = new System.Drawing.Size(73, 19);
            this.chkEnCurso.TabIndex = 2;
            this.chkEnCurso.Text = "En Curso";
            this.chkEnCurso.UseVisualStyleBackColor = true;
            this.chkEnCurso.CheckedChanged += new System.EventHandler(this.chkEnCurso_CheckedChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(330, 11);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(60, 19);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Estado:";
            // 
            // cmbCursos
            // 
            this.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(111, 9);
            this.cmbCursos.MaxDropDownItems = 100;
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(151, 23);
            this.cmbCursos.TabIndex = 1;
            this.cmbCursos.SelectionChangeCommitted += new System.EventHandler(this.cmbCursos_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Seleccione curso:";
            // 
            // FrmEscuela
            // 
            this.ClientSize = new System.Drawing.Size(870, 496);
            this.Controls.Add(this.tcEscuela);
            this.Name = "FrmEscuela";
            this.Load += new System.EventHandler(this.FrmEscuela_Load);
            this.tcEscuela.ResumeLayout(false);
            this.tpAlumnos.ResumeLayout(false);
            this.tpAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlumnoDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlumnos)).EndInit();
            this.tpCursos.ResumeLayout(false);
            this.tpCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCursos)).EndInit();
            this.tpInscripcion.ResumeLayout(false);
            this.tpInscripcion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlumnosxCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEscuela;
        private System.Windows.Forms.TabPage tpAlumnos;
        private System.Windows.Forms.TabPage tpCursos;
        private System.Windows.Forms.DataGridView gvAlumnos;
        private System.Windows.Forms.TextBox txtAlumnoApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlumnoNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtAlumnoDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlumnoDomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlumnoEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlumnoCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpAlumnoFechaNac;
        private System.Windows.Forms.Button btnEditarAlumno;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.CheckBox chkAlumnoActivo;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.TextBox txtCursoDenominacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCursoNuevo;
        private System.Windows.Forms.Button btnCursoEditar;
        private System.Windows.Forms.Button btnCursoGuardar;
        private System.Windows.Forms.DataGridView gvCursos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCursoDescripcion;
        private System.Windows.Forms.CheckBox chkCursoActivo;
        private System.Windows.Forms.TabPage tpInscripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkFinalizado;
        private System.Windows.Forms.CheckBox chkEnCurso;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbAlumnos;
        private System.Windows.Forms.DataGridView gvAlumnosxCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarAlumno;
    }
}

