using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Actualizar_Grilla()
        {
            grilla.DataSource = null;
            grilla.DataSource = lista_alumnos;
            grilla.ClearSelection();
        }
        void BorrarIngresos()
        {
            legajotxt.Clear(); nombretxt.Clear(); apellidotxt.Clear(); aprobadastxt.Clear(); fechanactxt.Clear();
            fechaingtxt.Clear(); activotxt.Clear(); edadingtxt.Clear(); noaprobadastxt.Clear(); antiguedadtxt.Clear();

        }
        List<Alumno> lista_alumnos = new List<Alumno>();

        public int Buscar_indice()
        {
            int p, j;

            p = Convert.ToInt32(grilla.Rows[grilla.CurrentRow.Index].Cells[0].Value);
            for (j = 0; ; j++)
            {
                if (lista_alumnos[j].Legajo == p)
                    break;

            }

            return j;
        }


        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult pregunta = MessageBox.Show("¿Utilizar constructor con parametros?", "Agregar", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    Alumno O_Alumno = new Alumno(Convert.ToInt32(legajotxt.Text), nombretxt.Text, apellidotxt.Text, Convert.ToInt32(aprobadastxt.Text), Convert.ToDateTime(fechanactxt.Text), Convert.ToDateTime(fechaingtxt.Text), activotxt.Text);
                    lista_alumnos.Add(O_Alumno);

                    BorrarIngresos();
                    Actualizar_Grilla();

                }
                else
                {
                    Alumno O_Alumno = new Alumno();
                    O_Alumno.Legajo = Convert.ToInt32(legajotxt.Text);
                    O_Alumno.Nombre = nombretxt.Text;
                    O_Alumno.Apellido = apellidotxt.Text;
                    O_Alumno.Var_Cant_Materias_Aprobadas = Convert.ToInt32(aprobadastxt.Text);
                    O_Alumno.Fecha_Nacimiento = Convert.ToDateTime(fechanactxt.Text);
                    O_Alumno.Fecha_Ingreso = Convert.ToDateTime(fechaingtxt.Text);
                    if (activotxt.Text == "si")
                    { O_Alumno.Activo = true; }
                    else
                    { O_Alumno.Activo = false; }
                    lista_alumnos.Add(O_Alumno);
                    BorrarIngresos();
                    Actualizar_Grilla();

                }
            }
            catch { MessageBox.Show("error al cargar alumno"); }
        }
        private void borrar_Click(object sender, EventArgs e)
        {
            try
            {
                lista_alumnos[Buscar_indice()].Dispose();
                lista_alumnos.RemoveAt(Buscar_indice());
                Actualizar_Grilla();
                BorrarIngresos();
            }
            catch { MessageBox.Show("Error al borrar registro"); }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Dias";
        }

        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = Buscar_indice();
            string parametro = Convert.ToString(comboBox1.SelectedItem);

            antiguedadtxt.Text = Convert.ToString(lista_alumnos[indice].Antiguedad(parametro));
            edadingtxt.Text = Convert.ToString(lista_alumnos[indice].Edad_de_Ingreso());
            noaprobadastxt.Text = Convert.ToString(lista_alumnos[indice].Materias_No_Aprobadas());
            nombretxt.Text = Convert.ToString(lista_alumnos[indice].Nombre);
            apellidotxt.Text = Convert.ToString(lista_alumnos[indice].Apellido);
            legajotxt.Text = Convert.ToString(lista_alumnos[indice].Legajo);
            aprobadastxt.Text = Convert.ToString(lista_alumnos[indice].Var_Cant_Materias_Aprobadas);
            fechanactxt.Text = (lista_alumnos[indice].Obtener_nac()).ToString("dd/MM/yyyy");
            fechaingtxt.Text = (lista_alumnos[indice].Obtener_ing()).ToString("dd/MM/yyyy");

            if (lista_alumnos[indice].Activo == true)
            { activotxt.Text = "si"; }
            else
            { activotxt.Text = "no"; }




        }



        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string parametro = Convert.ToString(comboBox1.SelectedItem);
            antiguedadtxt.Text = Convert.ToString(lista_alumnos[Buscar_indice()].Antiguedad(parametro));
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = Buscar_indice();
                Alumno O_Alumno = new Alumno(Convert.ToInt32(legajotxt.Text), nombretxt.Text, apellidotxt.Text, Convert.ToInt32(aprobadastxt.Text), Convert.ToDateTime(fechanactxt.Text), Convert.ToDateTime(fechaingtxt.Text), activotxt.Text);
                lista_alumnos[ind] = O_Alumno;
                MessageBox.Show("Registro modificado correctamente");
                BorrarIngresos();
                Actualizar_Grilla();
            }

            catch (System.NullReferenceException)
            {

                MessageBox.Show("Error: debe seleccionar un alumno cargado antes de realizar la modificacion");
            }
            catch (System.FormatException) { MessageBox.Show("Error: datos de alumno no válidos"); }

        }
    }
}
