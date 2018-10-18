using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
      public static  HumaneSocietyDataContext database = new HumaneSocietyDataContext();

        public static Client GetClient(string userName, string password)
        {
            var Requireddata = (from x in database.Clients
                                where x.UserName == userName && x.Password == password
                                select x).Single();
            return Requireddata;
        }
          //database.SubmitChanges();  
        //GetUserAdoptionStatus
        //GetAnimalByID
        //Adopt
        // SearchForAnimalByMultipleTraits
        //RetrieveClients
        //GetStates
        // AddNewClient
        //updateClient
        // UpdateUsername
        //UpdateEmail
        //UpdateAddress
        //UpdateFirstName
        //UpdateLastName
    }
}
