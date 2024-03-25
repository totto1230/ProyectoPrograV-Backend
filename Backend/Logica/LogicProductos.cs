using ForoULAtina.AccesoDatos;
using ForoULAtina.Entidades;
using ForoULAtina.Entidades.Request;
using ForoULAtina.Entidades.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForoULAtina.Logica
{
    public class LogicProductos  
    {
        public ResponseProductos ValidateProduct(RequestProductos req)
        {
            ResponseProductos res = new ResponseProductos();
            DataClasses1DataContext connect = new DataClasses1DataContext();
            string ErrorFromDB = "";
            int? errorIdDB = 0;
            try
            {
                //PROGRESS
                 connect.retornar_productos_disponibles(ref errorIdDB, ref ErrorFromDB);


            }
            catch (Exception ex)
            {
                res.Result = false;
                res.Errors.Add(ex.ToString());
                throw;
            }
            return res;
        }
    }
}
