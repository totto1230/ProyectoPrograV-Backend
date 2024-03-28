using ForoULAtina.AccesoDatos;
using ForoULAtina.Entidades.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForoULAtina.Logica
{
    public class LogicOrdenActiva
    {
        public ResponseOrdenActiva ValidateProduct()
        {
            ResponseOrdenActiva res = new ResponseOrdenActiva();
            DataClasses1DataContext connect = new DataClasses1DataContext();
            IdProductos ids = new IdProductos();
            res.Errors = new List<string>();
            string ErrorFromDB = "";
            int? errorIdDB = 0;
            int? numActivas = 0;

            try
            {
                connect.retornar_num_orden_activa(ref ErrorFromDB, ref numActivas);

                if (numActivas > 0)
                {
                    res.ordenActiva = new Entidades.Entities.OrdenActiva();
                    //Process - SQL retornar_orden_activa
                }
                else
                {
                    //No avail trips
                    res.Result = false;
                    res.Errors.Add(ErrorFromDB);
                    res.Message = "NO TRIPS AVAILABLE!, TRY AGAIN LATER! ";
                }
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

