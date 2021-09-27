using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Escritorio escritorio = new Escritorio();

              // Llenado de los controles 
              escritorio.setproducto(txtNombre.Text);
              escritorio.setcategoria(txtCate.Text);
              escritorio.setcodigo(txtCodigo.Text);
              escritorio.setcolor(txtColor.Text);
              escritorio.setmateriales(txtMateriales.Text);


              // Agrega datos a Listbook
              lsbDatos.Items.Add(escritorio.getpropiedades());

              // limpiar los textos y enviar el enfoque a escribir

            txtNombre.Text = "";
            txtCate.Text = "";
            txtCodigo.Text = "";
            txtColor.Text = "";
            txtMateriales.Text = "";
            txtNombre.Focus();
        }


    }
}
