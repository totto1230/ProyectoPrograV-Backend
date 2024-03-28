using ForoULAtina.AccesoDatos;
using ForoULAtina.Entidades;
using ForoULAtina.Entidades.Request;
using ForoULAtina.Entidades.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForoULAtina.Logica
{
    public class LogicProductos  
    {
        public ResponseProductos ValidateProduct()
        {
            ResponseProductos res = new ResponseProductos();
            DataClasses1DataContext connect = new DataClasses1DataContext();
            IdProductos ids = new IdProductos();
            res.Errors = new List<string>();
            string ErrorFromDB = "";
            int? errorIdDB = 0;
            int? numProductos =0 ;

            try
            {
                connect.retornar_num_productos(ref ErrorFromDB, ref numProductos);

                if (numProductos > 0 )
                {
                    int i = 0;
                    int?[] idFrontendProductos = new int?[(int)numProductos];
                    // Initialize the arrays
                    res.productos = new Productos();
                    res.productos.IdProducto = new int?[(int)numProductos];
                    res.productos.Name = new string[(int)numProductos];
                    res.productos.Cantidad = new int?[(int)numProductos];
                    res.productos.Precio = new decimal?[(int)numProductos];

                    while (numProductos > i )
                    {
                        //id,name,cantidad,precio
                        connect.retornar_productos_disponibles((i+1), ref errorIdDB, ref ErrorFromDB, ref idFrontendProductos[i], ref res.productos.Name[i], ref res.productos.Cantidad[i], ref res.productos.Precio[i]);
                        i++;
                    }

                    if (string.IsNullOrEmpty(ErrorFromDB) && res.productos.Name[0] != null)
                    {
                        int j = 0;
                        while(j < idFrontendProductos.Length)
                        {
                            res.productos.IdProducto[j] = ids.matchIDFs((int)idFrontendProductos[j]);
                            j++;
                        }
                        res.Result = true;
                        res.Message = "ENJOY YOUR PRODUCTS! " + res.productos.ToString();
                    }
                    else
                    {
                        //No avail products
                        res.Result = false;
                        res.Errors.Add(ErrorFromDB);
                        res.Message = "SOMETHING WENT WRONG!, TRY AGAIN LATER! ";
                    }
                }
                else
                {
                    //No avail products
                    res.Result = false;
                    res.Errors.Add(ErrorFromDB);
                    res.Message = "NO PRODUCTS AVAILABLE!, TRY AGAIN LATER! "; 
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
