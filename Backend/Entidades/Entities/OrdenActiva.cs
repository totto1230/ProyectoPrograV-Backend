using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForoULAtina.Entidades.Entities
{
    public class OrdenActiva
    {
        //public int IdOrdenActiva { get; set; }
        //public int IdOrden { get; set; }
        //public string NumeroDriver { get; set; }
        public string NumeroCliente { get; set; }
        public string NombreProductos { get; set; }
        public string Cantidad { get; set; }
        public string Coordenadas { get; set; }
        public double TotalComprarOrden { get; set; }
        public double CostoViaje { get; set; }
        public bool Completada { get; set; }
    }
}
