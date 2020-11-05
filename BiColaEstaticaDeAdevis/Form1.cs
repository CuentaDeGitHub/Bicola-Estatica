using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BiColaEstaticaDeAdevis
{
    public partial class Form1 : Form
    {
        BiCola MiClase;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEncolarIzq_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = txtDato.Text;
                if(dato == "")
                {
                    MessageBox.Show("Dato no valido");
                    txtDato.Clear();
                    return;
                }
                MiClase.EncolarIzquierda(dato);
                txtDato.Clear();
                lblCola.Text = MiClase.Imprimir();
               
            }
            catch
            {
                MessageBox.Show("Error;");
            }
          
        }

        private void btnEncolarDer_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = txtDato.Text;
                if(dato == "")
                {
                    MessageBox.Show("Dato no valido");
                    txtDato.Clear();
                    return;
                }
                MiClase.EncolarDerecha(dato);
                txtDato.Clear();
                lblCola.Text = MiClase.Imprimir();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void btnDesencolarIzq_Click(object sender, EventArgs e)
        {
            MiClase.DesencolarIzquierda();
            lblCola.Text = MiClase.Imprimir();
        }

        private void btnDesencolarDer_Click(object sender, EventArgs e)
        {
            MiClase.DesencolarDerecha();
            lblCola.Text = MiClase.Imprimir();
        }

        private void btnFrente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El dato en el frente es: " + MiClase.Front());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {   
                int tamaño = int.Parse(txtTamaño.Text);
                if(tamaño <= 0)
                {
                    MessageBox.Show("Tamaño minimo : 1");
                    txtTamaño.Clear();
                    return;
                }
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                MiClase = new BiCola(tamaño);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            if (Seleccionar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    int contador = 0;
                    string ruta = Seleccionar.FileName;
                    string[] datosYtamaño = File.ReadAllLines(ruta);
                    int tamaño = int.Parse(datosYtamaño[1]);
                    string linea = datosYtamaño[0];
                    string[] Lista = linea.Split(',');
                    MiClase = new BiCola(tamaño);
                    foreach (string i in Lista)
                    {
                        MiClase.EncolarDerecha(Lista[contador]);
                        contador++;

                    }
                    lblCola.Text = MiClase.Imprimir();
                }
                catch
                {
                    MessageBox.Show("Error al cargar el archivo");
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog Dialogo = new FolderBrowserDialog();
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = MiClase.ImprimirFormato();
                    int tamaño = MiClase.arregloBicola.Length;
                    string nombreDelArchivo;
                    if (txtArchivo.Text == "")
                    {
                        nombreDelArchivo = "Cola";
                    }
                    else
                    {
                        nombreDelArchivo = txtArchivo.Text;
                    }

                    string ruta = Dialogo.SelectedPath + "\\" + nombreDelArchivo + ".txt";
                    using (var writer = new StreamWriter(ruta))
                    {
                        writer.Close();
                    }
                    string[] DatosYTamaño = { dato, tamaño +""};
                    File.WriteAllLines(ruta, DatosYTamaño);
                    MessageBox.Show("Datos guardados en la ruta : " + ruta);
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }
    }
}
