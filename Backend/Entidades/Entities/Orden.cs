using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForoULAtina.Entidades.Entities
{
    public class Orden
    {
        public string Numero {  get; set; }

        public int IdProducto { get; set;}

        public int Cantidad {  get; set; }

        public string NumeroTar { get; set; }

        public string code { get; set; }

        public DateTime expiration { get; set;}

        //AGREGAR COORDENADAS
        //BACKEND
        public double totalComprar {get; set;}
    }
}
