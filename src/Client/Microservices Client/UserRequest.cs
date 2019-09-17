using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Microservices_Client
{
    public class UserRequest
    {
        public UserRequest()
        {

        }

        public string SendRequest(string user_id, string user_phone, int user_pos_init, int user_pos_end)
        {
            return "Hi: " + user_id + ". Your service from: " + user_pos_init + " to: " + user_pos_end + " was received. You will get a message to: " + user_phone + ";";
        }
    }
}