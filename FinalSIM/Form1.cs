using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSIM
{
    public partial class Form1 : Form
    {

        /*En un negocio de arreglo y venta de relojes hay un relojero y su ayudante.
        El ayudante tiene como tarea atender a las personas que entran en el negocio 
        (llegan respetando una distribución uniforme entre 13 y 17 minutos), 
        comprar (45%): 6 a 10 minutos
        entregar relojes (25%): 3 minutos
        retirar relojes (30%): 3 minutos
        El relojero se encarga de la reparación de los relojes, demorando en esta tarea U(18 ; 22) minutos.
        Inicialmente hay 5 relojes en espera de ser retirados.
        Simule el trabajo de 12 hs. A partir de los 115 minutos ¿Puede algún cliente venir a retirar un reloj, y
        que el mismo no esté reparado aún?
        ¿Cuál es la cola máxima de clientes?*/

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarDataGrid();
            WindowState = FormWindowState.Maximized;
        }


        private void AñadirColumnaAlDataGrid(string nombreColumna, int ancho)
        {
            gridPrincipal.Columns.Add(nombreColumna, nombreColumna);
            gridPrincipal.Columns[nombreColumna].Width = ancho;
        }

        private void ConfigurarDataGrid()
        {
            AñadirColumnaAlDataGrid("Evento", 100);
            AñadirColumnaAlDataGrid("Hora", 50);

            AñadirColumnaAlDataGrid("random llegada", 55);
            AñadirColumnaAlDataGrid("tiempo llegada", 50);
            AñadirColumnaAlDataGrid("proxima llegada", 55);

            AñadirColumnaAlDataGrid("Ayudante", 60);
            AñadirColumnaAlDataGrid("random proposito del cliente", 65);
            AñadirColumnaAlDataGrid("proposito del cliente", 65);
            AñadirColumnaAlDataGrid("random tiempo atencion", 65);
            AñadirColumnaAlDataGrid("tiempo atencion", 60);
            AñadirColumnaAlDataGrid("proximo fin atencion", 65);
            AñadirColumnaAlDataGrid("cliente en cola", 45);

            AñadirColumnaAlDataGrid("Relojero", 60);
            AñadirColumnaAlDataGrid("random tiempo reparacion", 60);
            AñadirColumnaAlDataGrid("tiempo reparacion", 60);
            AñadirColumnaAlDataGrid("proximo fin reparacion", 65);
            AñadirColumnaAlDataGrid("cola de relojes a reparar", 65);
            AñadirColumnaAlDataGrid("relojes listos para retirar", 60);

            AñadirColumnaAlDataGrid("cola maxima de clientes", 65);
            AñadirColumnaAlDataGrid("relojes no reparados a tiempo", 60);
        }



        private void VaciarGrid()
        {
            gridPrincipal.Rows.Clear();
        }

        private void CargarGrid(List<Iteracion> iteraciones)
        {
            VaciarGrid();


            foreach (var i in iteraciones)
            {
                gridPrincipal.Rows.Add(
                    i.evento,
                    i.hora,

                    i.randomLlegada,
                    i.tiempoLlegada,
                    i.proximaLlegada,

                    i.estadoAyudante,
                    i.rndPropositoCliente,
                    i.propositoCliente,                                                       
                    i.rndTiempoAtencion,
                    i.tiempoAtencion,
                    i.proximoFinAtencion,
                    i.colaDeClientes,

                    i.estadoRelojero,
                    i.rndTiempoReparacion,
                    i.tiempoReparacion,                         
                    i.proximoFinReparacion,
                    i.colaRelojesPorReparar,
                    i.colaRelojesListos,

                    i.colaMaximaClientes,
                    i.relojesNoTerminadosATiempo
                    );
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controlador controlador = new Controlador();
            List<Iteracion> iteraciones = controlador.EjercutarSimulacion();
            CargarGrid(iteraciones);
        }

        #region otros
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
