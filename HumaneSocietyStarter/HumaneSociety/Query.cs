using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        public static HumaneSocietyDataContext db = new HumaneSocietyDataContext();
<<<<<<< HEAD
      
        public static Client GetClient(string userName, string password)
=======

        public static Client GetClient(string userName, string password)
        {
            var Requireddata = (from x in db.Clients
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

        public static void UpdateClient(Client client)
>>>>>>> 86f79be168bdcea371a30196425aaab898b8b737
        {
            var Requireddata = (from x in db.Clients
                                where x.UserName == userName && x.Password == password
                                select x).Single();
            return Requireddata;
        }


        public static void UpdateUsername(Client client)
        {
            throw new NotImplementedException();
        }

        public static Client UpdateEmail(string email)
        {
            var clientEmails = (from i in db.Clients
                                where i.Email == email
                                select i).Single();
            return clientEmails;
        }

        public static void UpdateAddress(Client client)
        {
           
        }

        public static void UpdateFirstName(Client client)
        {
            throw new NotImplementedException();
        }

        public static void UpdateLastName(Client client)
        {
            throw new NotImplementedException();
        }

        public static object RetrieveClients()
        {
            throw new NotImplementedException();
        }

        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            throw new NotImplementedException();
        }

        public static object SearchForAnimalByMultipleTraits()
        {
            throw new NotImplementedException();
        }

        public static void UpdateAdoption(bool v, Adoption adoption)
        {
            throw new NotImplementedException();
        }

        public static object GetPendingAdoptions()
        {
            throw new NotImplementedException();
        }

        public static object CheckEmployeeUserNameExist()
        {
            throw new NotImplementedException();
        }

        public static object AddUsernameAndPassword(Employee employee)
        {
            throw new NotImplementedException();

        }

        public static DietPlan GetDietPlan()
        {
            throw new NotImplementedException();
        }

        public static Species GetSpecies()
        {
            throw new NotImplementedException();
        }

        public static Employee EmployeeLogin(string userName, string password)
        {
<<<<<<< HEAD
            var user = (from u in db.Employees
=======

             var user = (from u in db.Employees
>>>>>>> 86f79be168bdcea371a30196425aaab898b8b737
                        where u.UserName.Equals(userName) &&
                        u.Password.Equals(password)
                        select u).Single();
            return user;
<<<<<<< HEAD
        }

        internal static object GetUserAdoptionStatus(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void RunEmployeeQueries(Employee employee, string v)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void updateClient(Client client)
        {
            throw new NotImplementedException();
        }

        internal static object GetStates()
        {
            throw new NotImplementedException();
        }

        internal static object GetAnimalByID(int iD)
        {
            throw new NotImplementedException();
        }

        internal static void Adopt(object animal, Client client)
        {
            throw new NotImplementedException();
=======
>>>>>>> 86f79be168bdcea371a30196425aaab898b8b737
        }
    }
}
