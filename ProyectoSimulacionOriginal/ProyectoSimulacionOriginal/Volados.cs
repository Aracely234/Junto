using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSimulacionOriginal
{
    public partial class Volados : Form
    {
        //Variables volados
        int numcorridas;
        double caninicial;
        int ad;
        double apuesta, apuestaoficial;
        double meta;
        public Volados()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            //if (dataGridView1.Rows[0].Cells[1].Value == null)
            //{
            //    MessageBox.Show("No se ha generado ningun numero pseudoalatodio");
            //}
            if (cbxNoCor.Text == "" || txcanini.Text == "" || txapuesta.Text == "" || txmeta.Text == "")
            {
                MessageBox.Show("Revise que llenara los campos necesarios");
            }
            else
            {

                //double.TryParse(tbA.Text, out a);
                //double.TryParse(tbC.Text, out c);
                //double.TryParse(tbXo.Text, out Xo);
                //double.TryParse(tbM.Text, out M);

                string winer = "si";
                string over = "no";
                string quiebre = "quiebre";
                double nuevacantidad = 0;
                double nuevaapuesta = 0;
                double resetapu;
                bool winner = true;
                int.TryParse(cbxNoCor.Text, out numcorridas);
                for (int i = 1; i <= numcorridas; i++)//<- For de la corridas que se decean hacer
                {

                    double.TryParse(txcanini.Text, out caninicial);
                    double.TryParse(txapuesta.Text, out apuesta);
                    double.TryParse(txapuesta.Text, out apuestaoficial);
                    double.TryParse(txmeta.Text, out meta);
                    if (apuesta > caninicial)
                    {
                        MessageBox.Show("Su apuesta no puede ser mayor al monto inicial con el que cuenta");
                        break;
                    }
                    else if (meta < caninicial)
                    {
                        MessageBox.Show("Su meta no puede ser menor a la cantidad inicial con la que cuente");
                        break;
                    }

                    else
                    {
                        ad = datavolados.Rows.Add();
                        datavolados.Rows[ad].Cells[0].Value = (i).ToString();

                        for (int b = 0; ; b++)//<-For de los calculos necesarios para cada corrida
                        {
                            ad = datavolados.Rows.Add();

                            datavolados.Rows[ad].Cells[1].Value = caninicial.ToString();
                            datavolados.Rows[ad].Cells[2].Value = apuesta.ToString();
                            modulo = (a * Xo + c) % M;
                            random[b] = modulo / M;
                            double redoneado = (Math.Round(random[b], 5));

                            datavolados.Rows[ad].Cells[3].Value = redoneado.ToString();
                            acumulador += random[b];
                            m = modulo;
                            Xo = m;
                            if (redoneado < 0.5)
                            {

                                datavolados.Rows[ad].Cells[4].Value = winer;
                                nuevacantidad = caninicial + apuesta;
                                datavolados.Rows[ad].Cells[5].Value = nuevacantidad;

                                if (nuevacantidad == meta)
                                {
                                    datavolados.Rows[ad].Cells[6].Value = winer;
                                    break;
                                }
                                else if (nuevacantidad == 0)
                                {
                                    datavolados.Rows[ad].Cells[6].Value = quiebre;
                                    break;
                                }
                                caninicial = nuevacantidad;
                                if (apuesta != apuestaoficial)
                                {
                                    apuesta = apuestaoficial;
                                }
                            }
                            else
                            {
                                datavolados.Rows[ad].Cells[4].Value = over;
                                nuevacantidad = caninicial - apuesta;
                                datavolados.Rows[ad].Cells[5].Value = nuevacantidad;

                                if (nuevacantidad >= meta)
                                {

                                    datavolados.Rows[ad].Cells[6].Value = winer;
                                    break;
                                }
                                else if (nuevacantidad <= 0)
                                {
                                    datavolados.Rows[ad].Cells[6].Value = quiebre;
                                    break;
                                }
                                caninicial = nuevacantidad;
                                nuevaapuesta = apuesta * 2;
                                if (nuevacantidad < nuevaapuesta)
                                {
                                    apuesta = nuevacantidad;

                                }
                                else
                                {
                                    apuesta = nuevaapuesta;
                                }


                            }


                        }

                    }

                }


            }
        }
    }
}
