using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alumnos
{
    public partial class Form1 : Form
    {
        public class Alumno : IDisposable

        {

            public int Legajo { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime Fecha_Nacimiento { set { Var_Fecha_Nacimiento = value; } }


            public DateTime Fecha_Ingreso { set { Var_Fecha_Ingreso = value; } }
            public Boolean Activo { get; set; }
            private int Var_Edad;
            public int Edad
            {
                get
                {
                    this.Var_Edad = DateTime.Now.Year - this.Var_Fecha_Nacimiento.Year;

                    DateTime cumpleanio = this.Var_Fecha_Nacimiento.AddYears(this.Var_Edad);


                    if (DateTime.Compare(DateTime.Now, cumpleanio) < 0)
                    {
                        this.Var_Edad -= 1;
                    }

                    return Var_Edad;
                }
            }

            private DateTime Var_Fecha_Nacimiento;
            private DateTime Var_Fecha_Ingreso;
            public int Var_Cant_Materias_Aprobadas;

            int Cant_Materias_Aprobadas { set { Var_Cant_Materias_Aprobadas = value; } }
            public DateTime Obtener_nac() { return Var_Fecha_Nacimiento; }
            public DateTime Obtener_ing() { return Var_Fecha_Ingreso; }


            public int Antiguedad(string medida)
            {

                if (medida == "Dias")
                {
                    TimeSpan cantidad_de_dias = DateTime.Now - Var_Fecha_Ingreso;
                    return cantidad_de_dias.Days;
                }

                int total_anios = DateTime.Now.Year - Var_Fecha_Ingreso.Year;
                DateTime ingreso = Var_Fecha_Ingreso.AddYears(total_anios);


                if (Var_Fecha_Ingreso.CompareTo(ingreso) < 0)
                {
                    --total_anios;
                }
                if (medida == "Años")
                {
                    return total_anios;
                }


                if (medida == "Meses")
                {
                    int meses = total_anios * 12;
                    if (DateTime.Now.Month >= Var_Fecha_Ingreso.Month)
                    {
                        meses += (DateTime.Now.Month - Var_Fecha_Ingreso.Month);
                        return meses;

                    }
                    else
                    {

                        meses += 12 - Var_Fecha_Ingreso.Month + DateTime.Now.Month;
                        return meses;
                    }
                }

                return 0;

            }
            public int Edad_de_Ingreso()
            {

                int edad = Var_Fecha_Ingreso.Year - Var_Fecha_Nacimiento.Year;
                DateTime cumpleanio = Var_Fecha_Nacimiento.AddYears(edad);

                if (Var_Fecha_Ingreso.CompareTo(cumpleanio) < 0)
                {
                    --edad;
                }

                return edad;
            }
            public int Materias_No_Aprobadas()
            {

                return (36 - Var_Cant_Materias_Aprobadas);
            }
            public void Dispose()
            {
                MessageBox.Show("Objeto liberado\n" + "Legajo= " + this.Legajo + " " + "Nombre: " + this.Nombre + " " +
                        "Apellido: " + this.Apellido);
                GC.SuppressFinalize(this);

            }

            public Alumno() { }
            public Alumno(int Leg, string Nom, string Ape, int mat_aprob, DateTime fechanac, DateTime fechaing, string act)
            {

                this.Legajo = Leg;
                this.Nombre = Nom;
                this.Apellido = Ape;
                Fecha_Nacimiento = fechanac;
                Fecha_Ingreso = fechaing;
                if (act == "si")
                { this.Activo = true; }
                else
                { this.Activo = false; }
                this.Cant_Materias_Aprobadas = mat_aprob;
            }

            ~Alumno()
            {

            }





        }




    }
}
