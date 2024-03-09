using ForoULAtina.AccesoDatos;
using ForoULAtina.Entidades.Request;
using ForoULAtina.Entidades.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForoULAtina.Logica
{
    public class LogicLogin
    {
        public ResponseLogin ValidateUser(RequestLogin req)
        {
            ResponseLogin res = new ResponseLogin();
            try
            {
                res.Result = false;
                res.Errors = new List<string>();
                if (req == null)
                {
                    res.Errors.Add("NULL REQUEST, REVIEW YOUR INFO");
                }
                else {

                    if (string.IsNullOrEmpty(req.user.Number))
                    {
                        res.Result = false;
                        res.Errors.Add("PLEASE ENTER YOUR NUMBER! - NO NUMBER ERROR");

                    }

                    if (string.IsNullOrEmpty(req.user.Password))
                    {
                        res.Result = false;
                        res.Errors.Add("PLEASE ENTER YOUR Password! - NO Password ERROR");

                    }

                }
                if (res.Errors.Any())
                {
                    //Al menos un error 
                    res.Result = false;
                }
                else
                {
                    DataClasses1DataContext connect = new DataClasses1DataContext();
                    string name = "";
                    int? errorIdDB = 0;
                    string ErrorFromDB = "";
                    char? typeU =null;
                    bool? status = false;

                    connect.login(req.user.Number, req.user.Password, ref name, ref status, ref typeU, ref errorIdDB, ref ErrorFromDB);

                    if (string.IsNullOrEmpty(name))
                    {
                        res.Errors.Add(ErrorFromDB);
                        res.Result = false;
                    }
                    else
                    {
                        res.Result = true;
                    }
                    res.Message = "Welcome " + name + " !";
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
