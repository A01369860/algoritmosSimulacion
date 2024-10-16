using algoritmosSimulacion.algoritmos;
using algoritmosSimulacion.clases;

namespace algoritmosSimulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // paso 0: Condicion de vacio
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS.");
                return;
            }

            // Paso 1: Inicializacion de parametros
            int puntosTotales = Convert.ToInt32(textBox1.Text);
            int maximo = Convert.ToInt32(textBox2.Text);
            int minimo = Convert.ToInt32(textBox3.Text);

            // Paso 2: Llamar algoritmo
            GeneradorNumerosAleatorios generador = new GeneradorNumerosAleatorios();

            // Paso 3
            List<Class1> listaSalida = generador.CrearListaOrigen(puntosTotales, minimo, maximo);

            // Paso 4
            llenarGrid(listaSalida);
        }



        public void llenarGrid(List<Class1> lista)
        {
            // Paso 0: Indicas el numero de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";
            string numeroColumna6 = "6";
            string numeroColumna7 = "7";

            // Paso 1: Determinas la cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Panel1");
            dataGridView1.Columns.Add(numeroColumna3, "Panel2");
            dataGridView1.Columns.Add(numeroColumna4, "Panel3");
            dataGridView1.Columns.Add(numeroColumna5, "Panel4");
            dataGridView1.Columns.Add(numeroColumna6, "Panel5");
            dataGridView1.Columns.Add(numeroColumna7, "Valor");

            List<decimal> valoresColumna7 = new List<decimal>();


            // Paso 2: Recorres el grid para cada fila y llenar de valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = lista[i].IdExp.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].Panel1.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = lista[i].Panel2.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = lista[i].Panel3.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna5) - 1].Value = lista[i].Panel4.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna6) - 1].Value = lista[i].Panel5.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna7) - 1].Value = lista[i].Valor.ToString();

               
                decimal valorColumna7 = lista[i].Valor;
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna7) - 1].Value = valorColumna7.ToString();

                
                valoresColumna7.Add(valorColumna7);
            }

           
            decimal promedio = valoresColumna7.Average();


            MessageBox.Show($"Promedio de los valores de la columna 7: {promedio}", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        public void DescargaExcel(DataGridView data)
        {
            // Paso 0: Instalar complemento de Excel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;

            // Paso 1: Construyes columnas y los nombres de las "cabeceras"
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }

            // Paso 2: Construyes filas y llenas valores
            int indiceFilas = 0;

            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }

            // Paso 3: Visibilidad
            exportarExcel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
