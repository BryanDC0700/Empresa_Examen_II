using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    namespace ExamenII
    {
    public partial class Form1 : Form
        {
        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        private CalculadoraSueldo calculadoraSueldo = new CalculadoraSueldo();
        public Form1()
            {
                InitializeComponent();
            }

            private void label1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            double sueldoBruto;
            if (!double.TryParse(txtSueldoBruto.Text, out sueldoBruto) || sueldoBruto <= 0)
            {
                MessageBox.Show("Ingrese un sueldo bruto válido (mayor que cero).");
                return;
            }
            char categoria = char.ToUpper(txtCategoria.Text[0]);
            if (categoria != 'A' && categoria != 'B' && categoria != 'C')
            {
                MessageBox.Show("Ingrese una categoría válida (A, B o C).");
                return;
            }

            Empleado empleado = new Empleado
            {
                Nombre = nombre,
                Apellidos = apellidos,
                SueldoBruto = sueldoBruto,
                Categoria = categoria
            };

            calculadoraSueldo.CalcularAumentoYSueldoNeto(empleado);
            empleadoDAO.AgregarEmpleado(empleado);

            LimpiarCampos();
            ActualizarListaEmpleados();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtSueldoBruto.Clear();
            txtCategoria.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstEmpleados.Items.Clear();
            double totalSueldosNetos = 0;

            foreach (var empleado in empleadoDAO.ObtenerEmpleados())
            {
                lstEmpleados.Items.Add($"{empleado.Nombre} {empleado.Apellidos} - {empleado.SueldoBruto:C} - {empleado.MontoAumento:C} - {empleado.SueldoNeto:C}");
                totalSueldosNetos += empleado.SueldoNeto;
            }

            lstEmpleados.Items.Add($"Total Sueldos Netos: {totalSueldosNetos:C}");
        }

        private void button2_Click(object sender, EventArgs e)
    {
        txtNombre.Clear();
        txtApellidos.Clear();
        txtSueldoBruto.Clear();
        txtCategoria.Clear();
    }
    }
    }
