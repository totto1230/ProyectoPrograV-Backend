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
using ForoULAtina.Entidades.Entities;


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
                int cantidadProductos = req.order.IdProducto.Length;
                int? errorIdDB = 0;
                int i = 0;
                int[] idsBackend = new int[cantidadProductos];
                string ErrorFromDB = "";
                bool? existe = false;
                decimal? totalComprar = 0;
                IdProductos ids = new IdProductos();
                DataClasses1DataContext connect = new DataClasses1DataContext();

                if (req == null)
                {
                    res.Errors.Add("NULL REQUEST, REVIEW YOUR INFO");
                }
                else
                {
                    //validar number
                    if (string.IsNullOrEmpty(req.order.Numero))
                    {
                        res.Result = false;
                        res.Errors.Add("PLEASE ENTER YOUR NUMBER! - NO NUMBER ERROR");

                    }
                    else
                    {
                        //VALIDAR NUM
                        connect.order_validate_number(req.order.Numero, ref errorIdDB, ref ErrorFromDB);

                        if (errorIdDB != 0)
                        {
                            res.Errors.Add("NUMBER DOESNT EXISTS! - BAD NUMBER ERROR -- " + ErrorFromDB + " -- " + errorIdDB.ToString());
                        }
                        else
                        {
                            //VALIDAR PRODUCTO
                            while (i < cantidadProductos)
                            {
                                if (req.order.Cantidad[i] == 0)
                                {
                                    res.Result = false;
                                    res.Errors.Add("PLEASE ENTER A CANTITY! - NO CANTITY ERROR");
                                }

                                if (req.order.IdProducto[i] == 0)
                                {
                                    res.Result = false;
                                    res.Errors.Add("NO ID ERROR");
                                }
                                else
                                {
                                    int idBackend = ids.matchIDs(req.order.IdProducto[i]);
                                    idsBackend[i] = idBackend;
                                    decimal? precio = 0;
                                    connect.order_validate_product(idBackend, req.order.Cantidad[i], ref existe, ref errorIdDB, ref precio, ref ErrorFromDB);

                                    if (existe == false)
                                    {
                                        res.Result = false;
                                        res.Errors.Add("PRODUCT DOESNOT EXISTS - NO PRODUCT ERROR " + "REF ID: " + req.order.IdProducto[i] + ErrorFromDB);

                                    }
                                    else
                                    {
                                        //150 driver
                                        totalComprar = totalComprar + (precio * req.order.Cantidad[i]) + 150;
                                    }
                                }

                                i++;
                            }

                            if (totalComprar == 0)
                            {
                                res.Result = false;
                                res.Errors.Add("SOMETHING WENT WRONG WHILE REVIEWING THE ORDER");
                            }
                            else
                            {
                                bool? validarComprar = false;
                                connect.order_validate_compra(req.order.NumeroTar, req.order.code, req.order.expiration, totalComprar, ref validarComprar, ref errorIdDB, ref ErrorFromDB);

                                if (validarComprar == false)
                                {
                                    res.Result = false;
                                    res.Errors.Add("SOMETHING WENT WRONG WHILE REVIEWING THE ORDER --" + ErrorFromDB);
                                }
                                else
                                {
                                    connect.actualizar_tarjeta(req.order.NumeroTar, req.order.code, req.order.expiration, totalComprar, ref errorIdDB, ref ErrorFromDB);

                                    if (string.IsNullOrEmpty(ErrorFromDB))
                                    {
                                        int j = 0;
                                        while (j < cantidadProductos)
                                        {
                                            connect.actualizar_inventario(req.order.Cantidad[j], idsBackend[j], ref errorIdDB, ref ErrorFromDB);

                                            j++;
                                        }

                                        if (string.IsNullOrEmpty(ErrorFromDB))
                                        {
                                            int? idOrden = 0;

                                            string convertedArrayId = string.Join(", ", req.order.IdProducto) , convertedArrayCantidad = string.Join(", ", req.order.Cantidad), convertedArrayCoords = string.Join(", ", req.order.coordenadas);

                                            //Review IDProduct, not urgent
                                            connect.crear_orden(req.order.Numero, convertedArrayId, convertedArrayCantidad, convertedArrayCoords, (double?)totalComprar, true, ref idOrden,ref  errorIdDB, ref ErrorFromDB);

                                            if (idOrden!=0)
                                            {
                                                //Revisar
                                                connect.crear_orden_activa(idOrden, req.order.Numero, "1", convertedArrayId, convertedArrayCantidad, convertedArrayCoords, (double?)totalComprar, 150 ,false, ref ErrorFromDB);

                                                if (string.IsNullOrEmpty(ErrorFromDB))
                                                {
                                                    res.Result = true;
                                                    res.Message = "ORDER PLACED SUCCESSFULLY!" + " If you have any issues, please provide us your order ID: " + (idOrden + 35555).ToString() + " Total pagado: " + totalComprar.ToString();
                                                }
                                            }

                                        }
                                     }


                                }
                            }

                        }
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
