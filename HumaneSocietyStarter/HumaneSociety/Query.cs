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

        public static IQueryable<Adoption> GetUserAdoptionStatus(Client client)
        {
            var Requireddata = from x in db.Adoptions
                               where x.ClientId == client.ClientId && x.ApprovalStatus == "Pending"
                               select x;
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
        public static void Adopt(Animal animal, Client client)
        {
            Adoption newAdd = new Adoption();
            newAdd.Client = client;
            newAdd.Animal = animal;
            newAdd.ApprovalStatus = "Pending";
            newAdd.AdoptionFee = 100;
            db.Adoptions.InsertOnSubmit(newAdd);
            db.SubmitChanges();
        }

        // SearchForAnimalByMultipleTraits
        //RetrieveClients
        //GetStates
        // AddNewClientgit 
        //updateClient
        // UpdateUsername
        //UpdateEmail
        //UpdateAddress
        //UpdateFirstName
        //UpdateLastName

        public static Client UpdateClient(string userName, string password)
        {
           
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
                                  where f.LastName == lastname
                                  select f).Single();
        }



        public static object RetrieveClients(string userName, string email)
        {
            throw new NotImplementedException();
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

        public static Adoption UpdateAdoption(int adoption)
        {
            var updateAdopt = (from u in db.Adoptions
                               where u.AdoptionId == adoption
                               select u).Single();
            var animal = (from a in db.Animals
                          where a.AdoptionStatus == "Adopted"
                          select a).Single();
            return updateAdopt;
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

        public static Species GetSpecies(string speciesName)
        {
            var requiredanimal = (from i in db.Species
                          where i.Name == speciesName
                          select i).Single();
            return requiredanimal;
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


     


        internal static void updateClient(Client client)
        {
            throw new NotImplementedException();
        }


        private static IQueryable<USState> GetState(string state)
        {
            var RequiredStates = (from i in db.USStates
                                  where i.Name == state
                                  select i);
            return RequiredStates;
        }



        internal static object GetAnimalByID(int iD)
        {
            throw new NotImplementedException();
        }

        

    }
        internal static void Adopt(object animal, Client client)
        {
            throw new NotImplementedException();
        }
    
    }

}


    


