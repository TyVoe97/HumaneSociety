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
    
        public static Animal GetAnimalByID(int iD)
        {
            var Requireddata = (from r in db.Animals
                                where r.AnimalId == iD
                                select r).First();
            return Requireddata;
        }

        public static void UpdateClient(Client client)
        {
            var requiredData =
                 (from x in db.Clients
                  where x.ClientId == client.ClientId
                  select x).First();
            if(client.Income != null)
            {
                requiredData.Income = client.Income;
            }
            if(client.Password !=null)
            {
                requiredData.Password = client.Password;
            }
            if(client.NumberOfKids !=null)
            {
                requiredData.NumberOfKids = client.NumberOfKids;
            }
            if(client.HomeSquareFootage !=null)
            {
                requiredData.HomeSquareFootage = client.HomeSquareFootage;
            }



           
        }


        public static Client UpdateUsername(string username)
        {
            var newU = (from n in db.Clients
                        where n.UserName == username
                        select n).Single();
            return newU;
        }

        public static Client UpdateEmail(string email)
        {
            var clientEmails = (from i in db.Clients
                                where i.Email == email
                                select i).Single();
            return clientEmails;
        }

        public static void UpdateAddress(string addresses)
        {
            throw new NotImplementedException();

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

        public static IQueryable<Client> RetrieveClients()
        {
            var requiredData =
               from x in db.Clients
               select x;
            return requiredData;
        }

        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            throw new NotImplementedException();
        }

        public static void SearchForAnimalByMultipleTraits()
        {
            UserInterface.DisplayUserOptions("Please Enter   ");
          
        }




        

        public static Adoption UpdateAdoption(bool adopt,Adoption adoption)
           {
            var updateAdopt = (from u in db.Adoptions
                               where u.AdoptionId == adoption.AdoptionId
                               select u).Single();
            var animal = (from a in db.Animals
                          where a.AnimalId == adoption.AnimalId
                          select a).Single();


            if (adopt)
            {
                updateAdopt.ApprovalStatus = "Approved";

                animal.AdoptionStatus = "Adopted";
            }
            else 
            {
                updateAdopt.ApprovalStatus = "Pending";

                animal.AdoptionStatus = "Pending";
            }
            return updateAdopt;



        }

    

        public static IQueryable<Adoption> GetPendingAdoptions()
        {
            var requireddata = from g in db.Adoptions
                               where g.ApprovalStatus == "Pending"
                               select g;
            return requireddata;
        }
        



      
 

        public static object CheckEmployeeUserNameExist(string username)
        {
            throw new NotImplementedException();
        }

        

        public static object AddUsernameAndPassword(Employee employee)
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



        private static IQueryable<USState> GetState(string state)

        {
            var RequiredStates = (from i in db.USStates
                                  where i.Name == state
                                  select i);
            return RequiredStates;
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

        internal static object GetShots(Animal animal)
        {
            throw new NotImplementedException();
        }

        public static IQueryable<Adoption> GetUserAdoptionStatus(Client client)
        {
            var Requireddata = from x in db.Adoptions
                               where x.ClientId == client.ClientId && x.ApprovalStatus == "Pending"
                               select x;
            return Requireddata;
        }

        internal static void UpdateShot(string v, Animal animal)
        {
            throw new NotImplementedException();
        }

        public static int GetDietPlan()
        {
            //prompt user for food amount, name, and type of food

            //DietPlan diet = new DietPlan();
            //Console.WriteLine("How much food would you like?");
            //Console.WriteLine("What type of food would you like?");
            Console.WriteLine("What is the name of the diet plan??");
            string dietPlanName = Console.ReadLine();
            //db.DietPlans.InsertOnSubmit(diet);
            //db.SubmitChanges();
            int dietPlanId = (from d in db.DietPlans
                            where d.Name == dietPlanName
                            select d.DietPlanId).FirstOrDefault();
            return dietPlanId;


            // TODO
            // if dietPlanId is 0, make new diet plan, save to DB, return new id
            // otherwise, return dietPlanId :)

        }

        internal static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
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

        internal static void RunEmployeeQueries(Employee employee, string v)
        {
            
        }

        internal static void RemoveAnimal(object animal)
        {
            throw new NotImplementedException();
        }

        public static void AddAnimal(Animal animal)
        {
            db.Animals.InsertOnSubmit(animal);
            db.SubmitChanges();
            AssignRoom(animal);
            
        }
        public static void AssignRoom(Animal animal)
        {
            Room newRoom = new Room();
            newRoom.AnimalId = animal.AnimalId;
            int newNumber = 0;
            bool searching = false;
            while (!searching)
            {
                newNumber++;
                var isExisting = db.Rooms.AsEnumerable().Any(row => newNumber == row.RoomNumber);
                if (!isExisting)
                {
                    searching = true;
                    newRoom.RoomNumber = newNumber;
                }
            }
            db.Rooms.InsertOnSubmit(newRoom);
           db.SubmitChanges();
        }
        public static Room GetRoom(int animalId, string rooms)
        {
            var room = (from r in db.Rooms
                        where r.AnimalId == animalId
                        select r).FirstOrDefault();
            

            return room;


        } 

        internal static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            throw new NotImplementedException();
        }
    }

}


    
 