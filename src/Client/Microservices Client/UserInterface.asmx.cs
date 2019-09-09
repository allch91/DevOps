using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Microservices_Client
{
    /// <summary>
    /// Descripción breve de UserInterface
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class UserInterface : System.Web.Services.WebService
    {

        [WebMethod]
        public string ServiceRequest(string user_id, string user_phone, int user_pos_init, int user_pos_end)
        {

            return "Hi: " + user_id + ". Your service from: " + user_pos_init + " to: " + user_pos_end + " was received. You will get a message to: " + user_phone + ";" ;
        }
    }
}
