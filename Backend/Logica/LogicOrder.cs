using ForoULAtina.Entidades.Request;
using ForoULAtina.Entidades.Response;
using System;
using GeoJSON.Net.Feature;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GeoJSON.Net.Geometry;
using GeoJSON.Net;
using ForoULAtina.AccesoDatos;
using System.Runtime.Remoting.Messaging;

namespace ForoULAtina.Logica
{
    public class LogicOrder
    {
        public ResponseOrder ValidateOrder (RequestOrden req)
        {
            ResponseOrder res = new ResponseOrder();

            try
            {
                res.Result = false;
                res.Errors = new List<string>();

                if (req == null)
                {
                    res.Errors.Add("NULL REQUEST, REVIEW YOUR INFO");
                }
                else
                {
                    if (string.IsNullOrEmpty(req.order.Numero))
                    {
                        res.Result = false;
                        res.Errors.Add("PLEASE ENTER YOUR NUMBER! - NO NUMBER ERROR");
                        res.Message = "PLEASE ENTER YOUR NUMBER! - NO NUMBER ERROR";
                    }

                    if (req.order.Cantidad == 0)
                    {
                        res.Result = false;
                        res.Errors.Add("PLEASE ENTER A CANTITY! - NO CANTITY ERROR");
                        res.Message = "PLEASE ENTER A CANTITY! - NO CANTITY ERROR";
                    }

                    if (req.order.IdProducto == 0)
                    {
                        res.Result = false;
                        res.Errors.Add("NO ID ERROR");
                        res.Message = "NO ID ERROR";
                    }
                }

                if (res.Errors.Any())
                {
                    res.Result = false;
                }
                else
                {
                    DataClasses1DataContext connect = new DataClasses1DataContext();
                    string numberOut = "";
                    int? errorIdDB = 0;
                    string ErrorFromDB = "";
                    bool? existe = false;

                    connect.order_validate_number(req.order.Numero, ref numberOut , ref errorIdDB , ref  ErrorFromDB);

                    if (string.IsNullOrEmpty(ErrorFromDB))
                    {
                        connect.order_validate_product(req.order.IdProducto, req.order.Cantidad, ref existe, ref errorIdDB, ref ErrorFromDB);

                    }

                    if (existe == false)
                    {
                        res.Errors.Add("ERROR, PRODUCTO NO EXISTE");
                        res.Message = "ERROR, PRODUCTO NO EXISTE";
                    }
                    else if (string.IsNullOrEmpty(ErrorFromDB))
                    {
                        bool? validarComprar = false;
                        connect.order_validate_compra(req.order.NumeroTar, req.order.code, req.order.expiration, (decimal) req.order.totalComprar, ref validarComprar , ref errorIdDB , ref ErrorFromDB);

                        if (validarComprar == true)
                        {
                            
                            connect.actualizar_inventario(req.order.NumeroTar, req.order.code, req.order.expiration, (decimal)req.order.totalComprar, req.order.Cantidad, req.order.IdProducto, ref errorIdDB, ref ErrorFromDB);

                            if(string.IsNullOrEmpty(ErrorFromDB)){
                                res.Result = true;
                                res.Valid = true;
                            }

                        }
                        else
                        {
                            res.Errors.Add(ErrorFromDB);
                            res.Result = false;
                        }

                    }
                    else
                    {
                        res.Errors.Add(ErrorFromDB);
                        res.Result = false;
                    }
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
