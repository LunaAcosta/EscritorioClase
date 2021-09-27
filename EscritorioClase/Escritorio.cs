using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioClase
{
    class Escritorio
    {
        // Definir los miembros de la clase
        // propiedades

        private string _producto;

        private string _categoria;

        private string _codigo;

        private string _color;

        private string _materiales;

        public Escritorio(string producto, string categoria, string codigo, string color, string materiales)
        {
            // definicion de constructor

            _producto = producto;
            _categoria = categoria;
            _codigo = codigo;
            _color = color;
            _materiales = materiales;

        }

        public Escritorio(string producto)
        {
            _producto = producto;
        }

        public Escritorio()
        {
        }


        //Metodos de propiedad
        public void setproducto(string producto)
        {
            _producto = producto;
        }

        public string getproducto()
        {
            return _producto;
        }

        public void setcategoria(string categoria)
        {
            _categoria = categoria;
        }

        public string getcategoria()
        {
            return _categoria;
        }

        public void setcodigo(string codigo)
        {
            _codigo = codigo;
        }

        public string getcodigo()
        {
            return _codigo;
        }

        public void setcolor(string color)
        {
            _color = color;
        }

        public string getcolor()
        {
            return _color;
        }

        public void setmateriales(string materiales)
        {
            _materiales = materiales;
        }

        internal static object GetDatos()
        {
            throw new NotImplementedException();
        }

        public string getmateriales()
        {
            return _materiales;
        }


        //Metodos 

        public string getProductoInfo()
        {
            return _producto + " " + _categoria + " " + _codigo + " " + _color + " " + _materiales;
        }

        public string getpropiedades()
        {
            return "Escritorio: " + _producto + " Categoria: " + _categoria + " Codigo: " + _codigo + " Color: " + _color + " Materiales: " + _materiales;






        }

    }
}