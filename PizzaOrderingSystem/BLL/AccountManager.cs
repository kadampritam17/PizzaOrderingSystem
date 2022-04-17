using PizzaOrderingSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaOrderingSystem.BLL
{
    public class AccountManager
    {
        PizzaDbContext entities = new PizzaDbContext();
        //validation logic for admin login
        public bool ValidateAdmin(string email, string password)
        {
            bool status = false;

            if (email == "admin@gmail.com" && password == "admin")
            {
                //on success pass true
                status = true;
            }
            //on fail pass false
            return status;
        }
    }
}