using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANBRICK_hardware
{
    public partial class principal : Form
    {
        private bool mil_internal = true;
        private bool mil_external = true;
        public principal()
        {
            InitializeComponent();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        //Corriente en amperios, thickness en oz/fl^2, temperatura en grados y longitud en pulgadas
        private double[] calculate(bool interna, double current, double thickness, double t_rise, double t_amb, double trace_length)
        {
            //IPC - 2221 internal layers
            double k, b, c;
            if (interna)
            {
                k = 0.024; b = 0.44; c = 0.725;
            }
            else
            {
                k = 0.048; b = 0.44; c = 0.725;
            }
            //Calculo del Area en mils^2:
            double area = Math.Pow(current / (k * Math.Pow(t_rise, b)), (1.0 / c));
            double width_mill = area / (thickness * 1.378);
            //area = area * 2.54 * 2.54 / 1000000;
            double rho = 0.00000172; //ohm-cm
            double alpha = 0.0039; //ohm/ohm/
            double t = t_amb + t_rise;
            trace_length = trace_length * 2.54;
            area = area * 2.54 * 2.54 / 1000000;
            double resistant = (rho * trace_length / area) * (1 + alpha * (t - 25));
            double voltaje = resistant * current;
            double power = current * current * resistant * 1000;
            double[] solution = { width_mill, resistant, voltaje, power };
            return solution;
        }


        private void tick_refresco_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lb_time.Text = now.ToString("hh:mm:ss");
            double[] calculos_internal = calculate(true, Convert.ToDouble(txb_current.Text), Convert.ToDouble(txb_thickness.Text), Convert.ToDouble(txb_t_rise.Text), Convert.ToDouble(txb_t_amb.Text), Convert.ToDouble(txb_trace_length.Text));
            double[] calculos_external = calculate(false, Convert.ToDouble(txb_current.Text), Convert.ToDouble(txb_thickness.Text), Convert.ToDouble(txb_t_rise.Text), Convert.ToDouble(txb_t_amb.Text), Convert.ToDouble(txb_trace_length.Text));

            lb_width_internal.Text = calculos_internal[0].ToString("G4");
            lb_width_external.Text = calculos_external[0].ToString("G4");
            lb_resist_external.Text = calculos_external[1].ToString("G4");
            lb_resist_internal.Text = calculos_internal[1].ToString("G4");
            lb_volt_external.Text = calculos_external[2].ToString("G3");
            lb_volt_internal.Text = calculos_internal[2].ToString("G3");
            lb_power_external.Text = calculos_external[3].ToString("G4");
            lb_power_internal.Text = calculos_internal[3].ToString("G4");

            if (!mil_internal)
            {
                lb_width_internal.Text = (calculos_internal[0] * 0.0254).ToString("G3");

            }
            if (!mil_external)
            {
                lb_width_external.Text = (calculos_external[0] * 0.0254).ToString("G3");
            }

        }
        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void combo_width_internal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_1 = combo_width_internal.SelectedIndex;
            if (indice_1 == 1)
                mil_internal = false;
            else
                mil_internal = true;
        }

        private void combo_width_external_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice_2 = combo_width_external.SelectedIndex;
            if (indice_2 == 1)
                mil_external = false;
            else
                mil_external = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }


}
