using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForoULAtina.Entidades.Response
{
    public class ResponseOrder : ResponseBase
    {
        public string Message { get; set; }

        public Boolean Valid { get; set; }

        //public int idProducto { get; set; }
    }
}
