using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Backup
{
    public partial class Configuraciones : Form
    {

        String[] tipoCopia = {
            "",
            "Completa",
            "Incremental",
            "Diferencial",
            };
        String[] repeticionCopia = {
            "",
            "Única",
            "Diaria",
            "Semanal",
            "Mensual"
            };
        private Label lbtiposel;
        private Label lbFechaSel;
        private Label lbPeriocidad;

        public Configuraciones()
        {
            InitializeComponent();
        }

        public Configuraciones(Label lbtiposel, Label lbFechaSel, Label lbPeriocidad)
        {

            InitializeComponent();
            this.lbtiposel = lbtiposel;
            this.lbFechaSel = lbFechaSel;
            this.lbPeriocidad = lbPeriocidad;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            rellenar(cbTipo, null, tipoCopia);
            rellenar(cbrepeticion, null,repeticionCopia);

        }
        private void rellenar(ComboBox cb, String selected, String[] array)
        {
            cb.Items.Clear();
            foreach (String s in array)
            {
                cb.Items.Add(s);
            }
            if (selected == null)
                cb.SelectedIndex = 0;
            else
                cb.SelectedItem = selected;
        }
        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guardarPantallaConf_Click(object sender, EventArgs e)
        {
            String fechaInicio = dtApertura.Value.ToString();
            lbtiposel.Text = cbTipo.Text;
            lbFechaSel.Text = fechaInicio;
            lbPeriocidad.Text = cbrepeticion.Text;
            this.Close();
        }

        private void cbrepeticion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
