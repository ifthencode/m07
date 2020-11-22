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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

       

        private void configuraciones_Click(object sender, EventArgs e)
        {

        }

        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seleccionar_carpeta_Click_1(object sender, EventArgs e)
        {

            if (rbfichero.Checked == true) {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.ShowDialog();

                labelseleccionado.Text = dialog.FileName;

            } else if (rbCarpeta.Checked==true) {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.RootFolder = Environment.SpecialFolder.Desktop;
                dialog.ShowDialog();

                labelseleccionado.Text = dialog.SelectedPath;
            }
           
           
        }

        private void seleccionar_fichero_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void btDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            dialog.ShowDialog();

            lbdestinoseleccionado.Text = dialog.SelectedPath;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbfichero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfichero.Checked == true) {
                seleccionar_carpeta.Text = "Seleccionar Fichero";
                seleccionar_carpeta.Visible = true;
            } else if (rbCarpeta.Checked==true) {
                seleccionar_carpeta.Text = "Seleccionar Directorio";
                seleccionar_carpeta.Visible = true;
            }
        }

        private void configuraciones_Click_1(object sender, EventArgs e)
        {
            Configuraciones cf = new Configuraciones(lbtiposel, lbFechaSel, lbPeriocidad);
            cf.Show();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            String ok = "nook";
            if (labelseleccionado.Text.Equals(""))
            {
                labelseleccionado.BackColor = Color.Red;
                seleccionar_carpeta.BackColor = Color.Red;
                ok = "nook";
            }
           

            if (lbdestinoseleccionado.Text.Equals("")) {
                lbdestinoseleccionado.BackColor = Color.Red;
                btDestino.BackColor = Color.Red;
                ok = "nook";
            }
           

            if (lbtiposel.Text.Equals("")) {
                lbtiposel.BackColor = Color.Red;
                configuraciones.BackColor = Color.Red;
                ok = "nook";
            }
            
            if (lbFechaSel.Text.Equals(""))
            {
                lbFechaSel.BackColor = Color.Red;
                configuraciones.BackColor = Color.Red;
                ok = "nook";
            }
           
            if (lbPeriocidad.Text.Equals(""))
            {
                lbPeriocidad.BackColor = Color.Red;
                configuraciones.BackColor = Color.Red;
                ok = "nook";
            }
           

            if (!labelseleccionado.Text.Equals("")&&!lbdestinoseleccionado.Text.Equals("")&&!lbtiposel.Text.Equals("")&&!lbFechaSel.Text.Equals("")&& !lbPeriocidad.Text.Equals("")) {

                ok = "ok";
                labelseleccionado.BackColor = Color.Green;
                configuraciones.BackColor = Color.Green;
                seleccionar_carpeta.BackColor = Color.Green;
                lbdestinoseleccionado.BackColor = Color.Green;
                btDestino.BackColor = Color.Green;
                lbtiposel.BackColor = Color.Green;
                lbFechaSel.BackColor = Color.Green;
                lbPeriocidad.BackColor = Color.Green;
                MessageBox.Show("Todo preparado se comenzará la copia de seguridad según la configuración seleccionada");
            }

            if (ok.Equals("nook")) {
                MessageBox.Show("Los datos indicados en rojo son necesarios para la programación");
            }
        }

        private void rbCarpeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfichero.Checked == true)
            {
                seleccionar_carpeta.Text = "Seleccionar Fichero";
                seleccionar_carpeta.Visible = true;
            }
            else if (rbCarpeta.Checked == true)
            {
                seleccionar_carpeta.Text = "Seleccionar Directorio";
                seleccionar_carpeta.Visible = true;
            }
        }
    }
}
