using Microsoft.EntityFrameworkCore;
using PruebaTecnicaNET.Contexts;
using PruebaTecnicaNET.DTOs;
using PruebaTecnicaNET.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnicaNET
{
    public partial class FrmEscuela : Form
    {
        public FrmEscuela()
        {
            InitializeComponent();
         
        }

        private bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.
        private string tipoEdicion = "";

        ApplicationDbContext _context = new ApplicationDbContext();
        int alumnoId;
        int cursoId;
        bool soloLectura = true;

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            using ApplicationDbContext db = new ApplicationDbContext();
        
            var cursoActivo = (from c in db.Cursos
                          join ac in db.AlumnoCursos on c.Id equals ac.CursoId
                          where ac.AlumnoId == alumnoId && c.EstadoCursoId == 3
                        select c).ToList();

            if (cursoActivo.Count == 0)
            {
                chkAlumnoActivo.Enabled = true;
            }
            else
            {
                chkAlumnoActivo.Enabled = false;
            }

            HabilitarControlesAlumnos();
            tipoEdicion = "update";
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            Limpiar(tpAlumnos);
            HabilitarControlesAlumnos();
            tipoEdicion = "new";
            chkAlumnoActivo.Checked = true;

            txtAlumnoNombre.Focus();
        }

        private void DeshabilitarControlesAlumno()
        {
            txtAlumnoNombre.ReadOnly = true;
            txtAlumnoApellido.ReadOnly = true;
            txtAlumnoDNI.ReadOnly = true;
            txtAlumnoDomicilio.ReadOnly = true;
            txtAlumnoEmail.ReadOnly = true;
            txtAlumnoDNI.Enabled = false;
            txtAlumnoCelular.ReadOnly = true;
            dtpAlumnoFechaNac.Enabled = false;
            chkAlumnoActivo.Enabled = false;

            btnGuardarAlumno.Enabled = false;
        }

        private void HabilitarControlesAlumnos()
        {
            txtAlumnoNombre.ReadOnly = false;
            txtAlumnoApellido.ReadOnly = false;
            txtAlumnoDNI.ReadOnly = false;
            txtAlumnoDomicilio.ReadOnly = false;
            txtAlumnoEmail.ReadOnly = false;
            txtAlumnoDNI.Enabled = true;
            txtAlumnoCelular.ReadOnly = false;
            dtpAlumnoFechaNac.Enabled = true;

            btnGuardarAlumno.Enabled = true;
            btnEditarAlumno.Enabled = false;

        }

        private void DeshabilitarControlesCurso()
        {
            txtCursoDenominacion.ReadOnly = true;
            txtCursoDescripcion.ReadOnly = true;
            chkCursoActivo.Enabled = false;
        }

        private void HabilitarControlesCurso()
        {
            txtCursoDenominacion.ReadOnly = false;
            txtCursoDescripcion.ReadOnly = false;
            chkCursoActivo.Enabled = true;

            btnCursoGuardar.Enabled = true;
            btnCursoEditar.Enabled = false;
        }

        private void FrmEscuela_Load(object sender, EventArgs e)
        {
            LoadEstructuraGrillaAlumnos();
            LoadEstructuraGrillaCursos();
            LoadAlumnos();
            DeshabilitarControlesAlumno();
            DeshabilitarControlesCurso();
            btnEditarAlumno.Enabled = false;
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            if (Validar(tpAlumnos))
            {
                Alumno alumno = new Alumno()
                {
                    Nombre = txtAlumnoNombre.Text,
                    Apellido = txtAlumnoApellido.Text,
                    Dni = (long)txtAlumnoDNI.Value,
                    Domicilio = txtAlumnoDomicilio.Text,
                    Email = txtAlumnoEmail.Text,
                    Celular = txtAlumnoCelular.Text,
                    Fecha_nac = dtpAlumnoFechaNac.Value,
                    Baja = chkAlumnoActivo.Checked
                };
     
       
                if (tipoEdicion == "update")
                {
                    using ApplicationDbContext db = new ApplicationDbContext();
                    alumno.Id = alumnoId;
                    db.Entry(alumno).State = EntityState.Modified;
                    db.SaveChanges();

                    LoadAlumnos();
                    DeshabilitarControlesAlumno();
                }
                else
                {
                    var dni = _context.Alumnos.Where(x => x.Dni == txtAlumnoDNI.Value).FirstOrDefault();

                    if (dni == null)
                    {
                        alumno.Baja = true;
                        _context.Alumnos.Add(alumno);
                        _context.SaveChanges();

                        Limpiar(tpAlumnos);
                        LoadAlumnos();
                        DeshabilitarControlesAlumno();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un alumno con el Dni: " + txtAlumnoDNI.Value, "Nuevo Alumno",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

          
        }

        private bool Validar(TabPage tapPage)
        {
            foreach (Control oControls in tapPage.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            if (vacio == true)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validar Datos Ingresados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); // Si nuestra variable es verdadera mostramos un mensaje.
                vacio = false; // Devolvemos el valor original a nuestra variable.
                return false;
            }
            else 
            {
                return true; 
            }
        }

        private void Limpiar(TabPage tapPage)
        {
            foreach (Control oControls in tapPage.Controls)
            {
                if (oControls is TextBox) 
                {
                    oControls.Text = "";
                    
                }
                if (oControls is DateTimePicker)
                {
                    oControls.Text = "";
                }
                if (oControls is NumericUpDown)
                {
                    oControls.Text = "0";
                }
            }
        
        }

        private void LoadAlumnos()
        {
            gvAlumnos.Rows.Clear();
            gvAlumnos.Refresh();


            using ApplicationDbContext db = new ApplicationDbContext();
            var alumnos = db.Alumnos.ToList();

            foreach (var item in alumnos)
            {
                gvAlumnos.Rows.Add(
                    item.Id,
                    item.Nombre,
                    item.Apellido,
                    item.Dni,
                    item.Domicilio,
                    item.Email,
                    item.Celular,
                    item.Fecha_nac.ToString("dd/MM/yyyy"),
                    item.Baja);
            }

        }

        private void LoadCursos()
        {
            gvCursos.Rows.Clear();
            gvCursos.Refresh();

            using ApplicationDbContext db = new ApplicationDbContext();
            var cursos = db.Cursos.ToList();

            if (cursos.Count > 0)
            {
                foreach (var item in cursos)
                {
                    gvCursos.Rows.Add(
                        item.Id,
                        item.Denominacion,
                        item.Descripcion,
                        item.Baja);
                }
            }

        }

        private void LoadAlumnosxCurso()
        {
            gvAlumnosxCurso.Rows.Clear();
            gvAlumnosxCurso.Refresh();


            using ApplicationDbContext db = new ApplicationDbContext();

            cursoId = Convert.ToInt32(cmbCursos.SelectedValue);



            var query = from a in db.Alumnos
                        join ac in db.AlumnoCursos on a.Id equals ac.AlumnoId
                        where ac.CursoId == cursoId
                        select a;

            foreach (var item in query)
            {
                gvAlumnosxCurso.Rows.Add(
                    item.Id,
                    item.Nombre,
                    item.Apellido);
            }

        }

        private void LoadEstructuraGrillaAlumnos()
        {
            {
                var gv = gvAlumnos;
                gv.Columns.Clear();
                gv.AutoGenerateColumns = false;
                gv.AllowUserToOrderColumns = true;
                gv.AllowUserToDeleteRows = false;
                gv.AllowUserToAddRows = false;
                gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gv.ScrollBars = ScrollBars.Both;
                gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                gv.DefaultCellStyle.Font = new Font("Tahoma", 8);
                gv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
                gv.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
                gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                gv.ColumnHeadersHeight = 30;
                gv.RowHeadersVisible = false;
                gv.RowHeadersWidth = 30;
                gv.EnableHeadersVisualStyles = false;
                gv.AllowUserToResizeRows = false;

                DataGridViewTextBoxColumn colTxt = new DataGridViewTextBoxColumn();

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Id",
                    HeaderText = "ID",
                    DataPropertyName = "Id",
                    Visible = false,
                    ReadOnly = true,
                    Width = 40
                };
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Nombre",
                    HeaderText = "NOMBRE",
                    DataPropertyName = "Nombre",
                    Visible = true,
                    ReadOnly = true,
                    Width = 90
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Apellido",
                    HeaderText = "APELLIDO",
                    DataPropertyName = "Apellido",
                    Visible = true,
                    ReadOnly = true,
                    Width = 90
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Dni",
                    HeaderText = "DNI",
                    DataPropertyName = "Dni",
                    Visible = true,
                    ReadOnly = true,
                    Width = 60
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Domicilio",
                    HeaderText = "DOMICILIO",
                    DataPropertyName = "Domicilio",
                    Visible = true,
                    ReadOnly = true,
                    Width = 110
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Email",
                    HeaderText = "EMAIL",
                    DataPropertyName = "Email",
                    Visible = true,
                    ReadOnly = true,
                    Width = 140
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Celular",
                    HeaderText = "CELULAR",
                    DataPropertyName = "Celular",
                    Visible = true,
                    ReadOnly = true,
                    Width = 80
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Fecha_Nac",
                    HeaderText = "FECHA NAC",
                    DataPropertyName = "Fecha_Nac",
                    Visible = true,
                    ReadOnly = true,
                    Width = 70
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

               
                DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();

                colCheck = new DataGridViewCheckBoxColumn
                {
                    Name = "Baja",
                    HeaderText = "ACTIVO",
                    DataPropertyName = "Baja",
                    Visible = true,
                    ReadOnly = true,
                    Width = 55
                };
                colCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colCheck);

   
            }
        }

        private void LoadEstructuraGrillaCursos()
        {
            {
                var gv = gvCursos;
                gv.Columns.Clear();
                gv.AutoGenerateColumns = false;
                gv.AllowUserToOrderColumns = true;
                gv.AllowUserToDeleteRows = false;
                gv.AllowUserToAddRows = false;
                gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gv.ScrollBars = ScrollBars.Both;
                gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                gv.DefaultCellStyle.Font = new Font("Tahoma", 8);
                gv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
                gv.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
                gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                gv.ColumnHeadersHeight = 30;
                gv.RowHeadersVisible = false;
                gv.RowHeadersWidth = 30;
                gv.EnableHeadersVisualStyles = false;
                gv.AllowUserToResizeRows = false;

                DataGridViewTextBoxColumn colTxt = new DataGridViewTextBoxColumn();

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Id",
                    HeaderText = "ID",
                    DataPropertyName = "Id",
                    Visible = false,
                    ReadOnly = true,
                    Width = 40
                };
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Denominacion",
                    HeaderText = "DENOMINACION",
                    DataPropertyName = "Denominacion",
                    Visible = true,
                    ReadOnly = true,
                    Width = 90
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Descripcion",
                    HeaderText = "DESCRIPCION",
                    DataPropertyName = "Descripcion",
                    Visible = true,
                    ReadOnly = true,
                    Width = 300
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

                DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();

                colCheck = new DataGridViewCheckBoxColumn
                {
                    Name = "Baja",
                    HeaderText = "ACTIVO",
                    DataPropertyName = "Baja",
                    Visible = true,
                    ReadOnly = true,
                    Width = 55
                };
                colCheck.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colCheck);


            }
        }

        private void LoadEstructuraGrillaAlumnosxCurso()
        {
            {
                var gv = gvAlumnosxCurso;
                gv.Columns.Clear();
                gv.AutoGenerateColumns = false;
                gv.AllowUserToOrderColumns = true;
                gv.AllowUserToDeleteRows = false;
                gv.AllowUserToAddRows = false;
                gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gv.ScrollBars = ScrollBars.Both;
                gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                gv.DefaultCellStyle.Font = new Font("Tahoma", 8);
                gv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
                gv.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
                gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                gv.ColumnHeadersHeight = 30;
                gv.RowHeadersVisible = false;
                gv.RowHeadersWidth = 30;
                gv.EnableHeadersVisualStyles = false;
                gv.AllowUserToResizeRows = false;

                DataGridViewTextBoxColumn colTxt = new DataGridViewTextBoxColumn();

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Id",
                    HeaderText = "ID",
                    DataPropertyName = "Id",
                    Visible = false,
                    ReadOnly = true,
                    Width = 40
                };
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Nombre",
                    HeaderText = "NOMBRE",
                    DataPropertyName = "Nombre",
                    Visible = true,
                    ReadOnly = true,
                    Width = 100
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

                colTxt = new DataGridViewTextBoxColumn
                {
                    Name = "Apellido",
                    HeaderText = "APELLIDO",
                    DataPropertyName = "Apellido",
                    Visible = true,
                    ReadOnly = true,
                    Width = 120
                };
                colTxt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                colTxt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gv.Columns.Add(colTxt);

            }
        }

        private void gvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvAlumnos.Rows.Count > 0)
            {
                alumnoId= (int)gvAlumnos.Rows[e.RowIndex].Cells["Id"].Value;
                txtAlumnoNombre.Text = gvAlumnos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtAlumnoApellido.Text= gvAlumnos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                txtAlumnoDNI.Value = (long)gvAlumnos.Rows[e.RowIndex].Cells["Dni"].Value;
                txtAlumnoDomicilio.Text = gvAlumnos.Rows[e.RowIndex].Cells["Domicilio"].Value.ToString();
                txtAlumnoEmail.Text = gvAlumnos.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtAlumnoCelular.Text = gvAlumnos.Rows[e.RowIndex].Cells["Celular"].Value.ToString();
                dtpAlumnoFechaNac.Value = Convert.ToDateTime(gvAlumnos.Rows[e.RowIndex].Cells["Fecha_Nac"].Value.ToString());
                chkAlumnoActivo.Checked = Convert.ToBoolean(gvAlumnos.Rows[e.RowIndex].Cells["Baja"].Value);

                DeshabilitarControlesAlumno();
                btnEditarAlumno.Enabled = true;
            }
        }

        private void btnGuardarCurso_Click(object sender, EventArgs e)
        {
          
            if (Validar(tpCursos))
            {

                Curso curso = new Curso()
                {
                    Denominacion = txtCursoDenominacion.Text,
                    Descripcion = txtCursoDescripcion.Text,
                    Baja = true,
                    EstadoCursoId = 1
                };

       

                if (tipoEdicion == "update")
                {
                    curso.Id = cursoId;
                    using ApplicationDbContext db = new ApplicationDbContext();
                    db.Entry(curso).State = EntityState.Modified;
                    db.SaveChanges();

                    LoadCursos();
                    DeshabilitarControlesCurso();
                }
                else
                {
                
                    curso.Baja = true;
                    _context.Cursos.Add(curso);
                    _context.SaveChanges();

                    Limpiar(tpCursos);
                    LoadCursos();
                    DeshabilitarControlesCurso();

                }
            }
        }

        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            Limpiar(tpCursos);
            HabilitarControlesCurso();
            tipoEdicion = "new";

            chkCursoActivo.Checked = true;
            chkCursoActivo.Enabled = false;

            txtCursoDenominacion.Focus();
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            HabilitarControlesCurso();
            tipoEdicion = "update";
        }

        private void tcEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcEscuela.SelectedIndex == 1)
            {
                LoadCursos();
            }
            if (tcEscuela.SelectedIndex == 2)
            {
                loadComboCursos();
                LoadEstructuraGrillaAlumnosxCurso();
                LoadComboAlumnos();
                DeshabilitarInscripcion();
                DeshabilitarCheck();
            }
        }

        void DeshabilitarCheck()
        {
            chkActivo.Enabled = false;
            chkEnCurso.Enabled = false;
            chkFinalizado.Enabled = false;
        }

        void HabilitarCheck()
        {
            chkActivo.Enabled = true;
            chkEnCurso.Enabled = true;
            chkFinalizado.Enabled = true;
        }

        void LoadComboAlumnos()
        {
            using ApplicationDbContext db = new ApplicationDbContext();

            var query = (from a in db.Alumnos
                        where a.Baja == true
                        select new
                        {
                            Id = a.Id,
                            NombreAlumno = a.Nombre + " " + a.Apellido
                        }).ToList();

            cmbAlumnos.DataSource = query;
            cmbAlumnos.ValueMember = "Id";
            cmbAlumnos.DisplayMember = "NombreAlumno";
        
        }

        private void gvCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvCursos.ColumnCount > 0)
            {
                cursoId = (int)gvCursos.Rows[e.RowIndex].Cells["Id"].Value;
                txtCursoDenominacion.Text = gvCursos.Rows[e.RowIndex].Cells["Denominacion"].Value.ToString();
                txtCursoDescripcion.Text = gvCursos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                chkCursoActivo.Checked = Convert.ToBoolean(gvCursos.Rows[e.RowIndex].Cells["Baja"].Value);
            }
        }

        void loadComboCursos()
        {
            using ApplicationDbContext db = new ApplicationDbContext();
            cmbCursos.DataSource = db.Cursos.Where(x=> x.Baja == true).ToList();
            cmbCursos.DisplayMember = "Denominacion";
            cmbCursos.ValueMember = "Id";
            cmbCursos.SelectedIndex = -1;
            cmbCursos.Invalidate();

        }

        private void cmbCursos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            soloLectura = true;
            cursoId = Convert.ToInt32(cmbCursos.SelectedValue);

            using ApplicationDbContext db = new ApplicationDbContext();
            var estadoCursoId = db.Cursos.Where(x=> x.Id == cursoId).Select(x => x.EstadoCursoId).FirstOrDefault();

            if (estadoCursoId == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Desea Activar el curso de " + cmbCursos.Text + " ?", "Activar Cursos",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
               
                    var estados = new string[] { "Activo", "En Curso" };

                    var query = (from c in db.Cursos
                                 join ec in db.EstadoCursos on c.EstadoCursoId equals ec.Id
                                 where estados.Contains(ec.Nombre)
                                 select c.Denominacion).ToList();

                    if (query.Count > 0)
                    {
                        chkActivo.CheckState = CheckState.Unchecked;
                        chkEnCurso.CheckState = CheckState.Unchecked;
                        chkFinalizado.CheckState = CheckState.Unchecked;

                        MessageBox.Show("No se puede Activar un curso nuevo mientras \n haya cursos en estado Activo o En Curso", "Activar Nuevo Curso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DeshabilitarCheck();
                        LoadAlumnosxCurso();
                        DeshabilitarInscripcion();

                        return;
                    }

                    Curso curso = db.Cursos.Where(x => x.Id == cursoId).FirstOrDefault();

                    var cursoDTO = new CursoDTO
                    {
                        Id = curso.Id,
                        EstadoCursoId = 2
                    };

                    cursoDTO.MapToModel(curso);
                    db.SaveChanges();

                    chkActivo.Checked = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    chkActivo.CheckState = CheckState.Unchecked;
                    chkEnCurso.CheckState = CheckState.Unchecked;
                    chkFinalizado.CheckState = CheckState.Unchecked;

                    DeshabilitarCheck();
                    LoadAlumnosxCurso();
                    DeshabilitarInscripcion();

                    return;
                }

            }

            switch (estadoCursoId)
            {
                case 2:
                    chkActivo.CheckState = CheckState.Checked;

                    break;
                case 3:
                    chkEnCurso.CheckState = CheckState.Checked;

                    break;
                case 4:
                    chkFinalizado.CheckState = CheckState.Checked;
                 
                    break;
            }

            LoadAlumnosxCurso();

            if (cursoId != 0 && estadoCursoId != 4)
            {
                HabilitarInscripcion();
                HabilitarCheck();
            }
            else
            {
                DeshabilitarInscripcion();
                DeshabilitarCheck();
            }


            soloLectura = false;

        }

        private void ActualizarEstadoCurso(int estadoCursoId)
        {
            using ApplicationDbContext db = new ApplicationDbContext();
            cursoId = Convert.ToInt32(cmbCursos.SelectedValue);

            Curso curso = db.Cursos.Where(x => x.Id == cursoId).FirstOrDefault();

            var cursoDTO = new CursoDTO
            {
                Id = curso.Id,
                EstadoCursoId = estadoCursoId
            };

            cursoDTO.MapToModel(curso);
            db.SaveChanges();
        }

   
        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivo.CheckState == CheckState.Checked && cmbCursos.SelectedIndex >= 0)
            {
                chkEnCurso.CheckState = CheckState.Unchecked;
                chkFinalizado.CheckState = CheckState.Unchecked;


                if (!soloLectura)
                {
                    ActualizarEstadoCurso(2);

                    HabilitarInscripcion();
                }
           
            }
        }

 
        private void chkFinalizado_CheckedChanged(object sender, EventArgs e)
        {

            if (chkFinalizado.CheckState == CheckState.Checked && cmbCursos.SelectedIndex >= 0)
            {
                chkActivo.CheckState = CheckState.Unchecked;
                chkEnCurso.CheckState = CheckState.Unchecked;


                if (!soloLectura)
                {
                    ActualizarEstadoCurso(4);
                    DeshabilitarInscripcion();
                    DeshabilitarCheck();
                }
            }
        }

        private void chkEnCurso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnCurso.CheckState == CheckState.Checked && cmbCursos.SelectedIndex >= 0)
            {
                chkActivo.CheckState = CheckState.Unchecked;
                chkFinalizado.CheckState = CheckState.Unchecked;

                if (!soloLectura)
                {
                    ActualizarEstadoCurso(3);

                    HabilitarInscripcion();
                }
            }
        }

        void HabilitarInscripcion()
        {
            btnAgregarAlumno.Enabled = true;
            cmbAlumnos.Enabled = true;
        }

        void DeshabilitarInscripcion()
        {
            btnAgregarAlumno.Enabled = false;
            cmbAlumnos.Enabled = false;
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            alumnoId = Convert.ToInt32(cmbAlumnos.SelectedValue);
            cursoId = Convert.ToInt32(cmbCursos.SelectedValue);


            using ApplicationDbContext db = new ApplicationDbContext();
            var alumnoOk = db.AlumnoCursos.Where(x => x.AlumnoId == alumnoId && x.CursoId == cursoId).FirstOrDefault();
            int estadoCursoId = db.Cursos.Where(x => x.Id == cursoId).Select(x => x.EstadoCursoId).FirstOrDefault();

            if (alumnoOk == null)
            {
                AlumnoCurso alumnoCurso = new AlumnoCurso()
                {
                    AlumnoId = alumnoId,
                    CursoId = cursoId
                };

                db.AlumnoCursos.Add(alumnoCurso);
                db.SaveChanges();

                LoadAlumnosxCurso();
            }
        }
    }
}
