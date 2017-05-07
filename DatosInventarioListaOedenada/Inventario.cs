using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosInventarioListaOedenada
{

    class Inventario
    {

        bool encontrado = false;
        private Producto primeroInicio = new Producto("", "", "", "");
       
        
        public Inventario()
        {
            primeroInicio = null;
        }

        public void ingressarProducto(Producto nuevo)
        {

            if (primeroInicio == null)
            {
                primeroInicio = nuevo;
            }
            else
            {
                Producto temporal = primeroInicio;
              
                int num = string.Compare(temporal.nombre, nuevo.nombre, true);
              
                if (num == 1)
                {
                    encontrado = true;

                    nuevo.siguiente = temporal;
                    primeroInicio = nuevo;

                }
               else if (num != 1)
                {
                    bool encontrado2 = true;
                    while (temporal.siguiente != null  && encontrado2 == false)
                    {

                        if (string.Compare(temporal.nombre, nuevo.nombre, true) == 1) {
                            encontrado2 = true;

                        }
                        else
                        {
                            temporal = temporal.siguiente;

                        }
                    }

                    if (encontrado2 == true)
                    {
                        nuevo.siguiente = temporal.siguiente;
                        temporal.siguiente = nuevo;
                    }
                   else if (encontrado2 == false)
                    {
                        temporal.siguiente = nuevo;
                    }


                }
            }
        }


        public void eliminarProducto(string codigo)
        {

            bool encontrado = false;
            Producto temporal = primeroInicio;

            if (temporal.codigo == codigo)
            {
                primeroInicio = temporal.siguiente;
                encontrado = true;
            }

            while (temporal != null && encontrado != true)
            {
               

                 if (temporal.siguiente.codigo == codigo)
                {


                    temporal.siguiente = temporal.siguiente.siguiente;

                    encontrado = true;
                }
                else
                {
                    temporal = temporal.siguiente;
                }

            }
        }

        public Producto buscarProducto(string codigo)
        {
            
            Producto buscado = null;
            bool encontrado = false;
            Producto temporal = primeroInicio;


            while (temporal != null && encontrado != true)
            {
                if (temporal.codigo == codigo)
                {
                    buscado = temporal;
                    encontrado = true;
                }
                else
                {
                    temporal = temporal.siguiente;
                }
            }

       



            return buscado;
        }

      

        public override string ToString()
        {
            string str = " ";

            Producto t = primeroInicio;

            while (t != null)
            {

                str += t.ToString();
                t = t.siguiente;

            }
            return str;

          

        }
        private string reporteInversoR(Producto aux)
        {
            string str = " ";
            if (aux.siguiente != null)
            {
                str = reporteInversoR(aux.siguiente);
            }
          return  str += aux.ToString();
        }

        public string reporteInverso()
        {
            return reporteInversoR(primeroInicio);
        }


       

    }
}
