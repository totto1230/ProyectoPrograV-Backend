using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForoULAtina.Entidades.Response
{
    public class ResponseBase
    {
        public Boolean Result { get; set; }
        public List<String> Errors { get; set; }
    }
}
