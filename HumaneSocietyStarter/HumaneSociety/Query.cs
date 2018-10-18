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

        public static Client GetClient(string userName, string password)
        {
            var Requireddata = (from x in db.Clients
                                where x.UserName == userName && x.Password == password
                                select x).Single();
            return Requireddata;
        }



        //database.SubmitChanges();  
        //public static Adoption GetUserAdoptionStatus()Emplee
        //{

        //}
        public static Animal GetAnimalByID(int iD)
        {
            var Requireddata = (from r in db.Animals
                                where r.AnimalId == iD
                                select r).First();
            return Requireddata;
        }
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

        public static Client UpdateClient(string userName, string password)
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

        public static Client UpdateFirstName(string firstname)
        {
            var clientFirstName = (from f in db.Clients
                                   where f.FirstName == firstname
                                   select f).Single();
            return clientFirstName;
        }

        public static void UpdateLastName(string lastname)
        {

            var clientLastName = (from f in db.Clients
                                  where f.FirstName == lastname
                                  select f).Single();
        }



        public static object RetrieveClients(string userName, string email)
        {
            // still working on a way to make this work, feel free to work on it also
            // var retrievedClients = (from r in db.Clients
            // where r.Email == 
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
            var user = (from u in db.Employees
                        where u.UserName.Equals(userName) &&
                        u.Password.Equals(password)
                        select u).Single();
            return user;
        }
        internal static object GetUserAdoptionStatus(Client client)
        {
            throw new NotImplementedException();
        }

        internal static void RunEmployeeQueries(Employee employee, string v)
        {
            throw new NotImplementedException();
        }

        internal static object GetStates()
        {
            throw new NotImplementedException();
        }

        internal static void Adopt(object animal, Client client)
        {
            throw new NotImplementedException();
        }
    
    }

}


    


