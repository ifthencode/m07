using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Backup
{
    public partial class Backup : Form
    {

        String[] filtroIncidencia = {
            "Elegir el filtro...",
            "Tipo",
            "Email",
            "Estado",
           
            };
        ListView lvFiltrado;
     //   FiltrarIncidencias fi;
        ListViewItem[] itemlist;

        public Backup()
        {
            InitializeComponent();
          
           // view.Filter = UserFilter;
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {

        }

      
        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    private void nuevaIncidencia_Click(object sender, EventArgs e)
        {
            //      AgregadorIncidencias ai = new AgregadorIncidencias(lvIncidencias);


            //    ai.Show();

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            dialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                labelseleccionado.Text = dialog.SelectedPath;
            }
        }

        private void nuevaIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // AgregadorIncidencias ai = new AgregadorIncidencias(lvIncidencias);


          //  ai.Show();
        }

        private void lvIncidencias_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
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
        private void Form1_Shown(object sender, EventArgs e)
        {
          //  rellenar(cbFiltro, null, filtroIncidencia);
           

        }
        private void button2_Click(object sender, EventArgs e)
        {
           // ModificarIncidencia mi;
            String estado;
           
            //try
            //{
                 
            //    if (lvIncidencias.SelectedItems.Count>0)
            //    {
            //        estado = lvIncidencias.SelectedItems[0].SubItems[4].Text;
                
            //        mi = new ModificarIncidencia(lvIncidencias, estado);
            //        mi.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Debe seleccionar una incidencia ");

            //    }
            //}
            //catch (Exception ex)
            //{
                
            //}

           
           


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            //int posicion = 0;
            //int numero = 0;

            //if (lvIncidencias.SelectedItems.Count > 0)
            //{
            //    ListViewItem itemr = lvIncidencias.SelectedItems[0];
            //    foreach (ListViewItem iteml in lvIncidencias.Items)
            //    {


            //        if (iteml == itemr)
            //        {

            //            posicion = numero;

            //        };
            //        numero++;
            //    }
            //    lvIncidencias.Items.RemoveAt(posicion);
            //}
            //else {
            //    MessageBox.Show("Debe seleccionar una incidencia ");

            //}
        }

        private void txFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
           

            //if (!txFiltro.Text.Equals(""))
            //{
            //     itemlist = new ListViewItem[lvIncidencias.Items.Count];
            //    ListViewItem item = new ListViewItem();
                
               

            //    foreach (ListViewItem iteml in lvIncidencias.Items)
            //    {


            //        if (cbFiltro.SelectedItem.Equals("Tipo"))
            //        {

            //            if (iteml.SubItems[1].Text.Equals(txFiltro.Text)) {
            //                int cont = 0;
            //                itemlist[cont] = iteml;
                            

            //            }



            //        }else if (cbFiltro.SelectedItem.Equals("Email")){

            //            if (iteml.SubItems[3].Text.Equals(txFiltro.Text))
            //            {
            //                int cont = 0;
            //                itemlist[cont] = iteml;


            //            }


            //        } else if (cbFiltro.SelectedItem.Equals("Estado")){
            //            if (iteml.SubItems[4].Text.Equals(txFiltro.Text))
            //            {
            //                int cont = 0;
            //                itemlist[cont] = iteml;


            //            }


            //        }

            //    }
               
            //}
            //else
            //{
            //    MessageBox.Show("Debe escribir un filtro ");

            //}
            //fi = new FiltrarIncidencias(itemlist);
            //fi.Show();


        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void seleccionar_fichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog=new OpenFileDialog();
           
            dialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                labelseleccionado.Text = dialog.FileName;
            }
        }

        private void seleccionar_carpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            dialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                labelseleccionado.Text = dialog.SelectedPath;
            }

        }

        private void btDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            dialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lbdestinoseleccionado.Text = dialog.SelectedPath;
            }
        }

        private void configuraciones_Click(object sender, EventArgs e)
        {
            //  Configuraciones cf= new Configuraciones(lbdestinoseleccionado,lbFechaSel,lbPeriocidad);
            //   cf.Show();
            
        }
    }
}
