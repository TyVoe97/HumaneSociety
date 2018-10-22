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
            if (client.Income != null)
            {
                requiredData.Income = client.Income;
            }
            if (client.Password != null)
            {
                requiredData.Password = client.Password;
            }
            if (client.NumberOfKids != null)
            {
                requiredData.NumberOfKids = client.NumberOfKids;
            }
            if (client.HomeSquareFootage != null)
            {
                requiredData.HomeSquareFootage = client.HomeSquareFootage;
            }

        }
        public static void UpdateUsername(Client client)
          {
            var newU = (from n in db.Clients
                        where n.ClientId == client.ClientId
                        select n).Single();
            newU.UserName = client.UserName;
            db.SubmitChanges();

           
        }
        public static void  UpdateEmail(Client client)
        {
            var clientEmails = (from n in db.Clients
                                where n.ClientId == client.ClientId
                                select n).Single();
            clientEmails.Email = client.Email;
            db.SubmitChanges();

        }
        public static void UpdateAddress(string addresses)
        {
            throw new NotImplementedException();

        }
        public static  void  UpdateFirstName(Client client)
        {
            var clientFirstName = (from f in db.Clients
                                   where f.ClientId == client.ClientId
                                   select f).First();
            clientFirstName.FirstName = client.FirstName;
            db.SubmitChanges();
        
        }
        public static void UpdateLastName(Client client)
        {

            var clientLastName = (from f in db.Clients
                                  where f.ClientId == client.ClientId
                                  select f).First();
            clientLastName.FirstName = client.LastName;
            db.SubmitChanges();
        }

<<<<<<< HEAD
        public static List<Client> RetrieveClients()
=======
        public static IQueryable<Client> RetrieveClients()
>>>>>>> 3f7f20f082404b877ae30a2cf60a82777c79e617
        {

            var requiredData =
               from x in db.Clients
               select x;
            return requiredData;
        }



        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            Console.WriteLine("What is your income?");
            int income = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many kids do you have?");
            int kids = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the square footage of your house?");
            int footage = Convert.ToInt32(Console.ReadLine());
            Client newClient = new Client();
            newClient.FirstName = firstName;
            newClient.LastName = lastName;
            newClient.UserName = username;
            newClient.Password = password;
            newClient.Email = email;
            newClient.AddressId = streetAddress; //ask about int=string
            newClient.Income = income;
            newClient.NumberOfKids = kids;
            newClient.HomeSquareFootage = footage;
            db.Clients.InsertOnSubmit(newClient);
            db.SubmitChanges();

        }


        public static IQueryable<Animal> SearchForAnimalByMultipleTraits(Animal animal)

        {
            UserInterface.DisplayUserOptions("Please Enter   ");


        }
        public static Adoption UpdateAdoption(bool adopt, Adoption adoption)


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
            var alreadyExists = (from a in db.Employees
                                 where a.UserName == username
                                 select a).Any();
            return alreadyExists;


        }


        public static Room GetRoom(int animalId, string rooms)
        {
            var room = (from r in db.Rooms
                        where r.AnimalId == animalId
                        select r).FirstOrDefault();

            return room;

            //int dietPlanId = (from d in db.DietPlans
            //     where d.Name == dietPlanName
            //     select d.DietPlanId).FirstOrDefault();
        }
        public static object AddUsernameAndPassword(Employee employee)
        {
            throw new NotImplementedException();

        }
        public static IQueryable<Adoption> GetPendingAdoptions(bool v)
        {
            var requireddata = from g in db.Adoptions
                               where g.ApprovalStatus == "Pending"
                               select g;
            return requireddata;
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
        internal static void AddAnimal(Animal animal)
        {
            db.Animals.InsertOnSubmit(animal);
            db.SubmitChanges();

        }


        public static IQueryable<AnimalShot> GetShots(Animal animal)

        {
            var Reqiredshots = (from i in db.AnimalShots
                                where i.AnimalId == animal.AnimalId
                                select i);
            return Reqiredshots;
        }

        public static IQueryable<Adoption> GetUserAdoptionStatus(Client client)
        {
            var Requireddata = from x in db.Adoptions
                               where x.ClientId == client.ClientId && x.ApprovalStatus == "Pending"
                               select x;
            return Requireddata;
        }

        public static void UpdateShot(string v, Animal animal)
        {
            var Updateshots = (from i in db.Shots
                               where i.ShotId == UpdateShot
                               select i); //halfway done
        }
        public static DietPlan GetDietPlan()
        {
            Console.WriteLine("What is the name of the diet plan?");
            string dietPlanName = Console.ReadLine();
            var dietPlan = (from d in db.DietPlans
                            where d.Name == dietPlanName
                            select d).FirstOrDefault();
            if (dietPlan == default(DietPlan))
            {
                DietPlan diet = new DietPlan();
                Console.WriteLine("What type of food would you like?");
                string foodType = Console.ReadLine();
                Console.WriteLine("How much of the food would you like in cups?");
                int cupsOfFood = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What would you like to know the new diet plan?");
                string newDiet = Console.ReadLine();
                diet.FoodType = foodType;
                diet.FoodAmountInCups = cupsOfFood;
                diet.Name = newDiet;
                db.DietPlans.InsertOnSubmit(diet);
                db.SubmitChanges();

                return dietPlan;
            }
            else
            {
                return dietPlan;
            }
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

        public static void RemoveAnimal(Animal animal)
        {
            var requiredData =
                (from x in db.Animals
                 where x.AnimalId == animal.AnimalId
                 select x).First();
            if (requiredData != null)
            {
                db.Animals.DeleteOnSubmit(requiredData);
                db.SubmitChanges();
            }
        }
        internal static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            throw new NotImplementedException();
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

        public static void ToList(Animal animal)
        {

        }

    }
}

