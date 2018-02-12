using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
   public class Manager : Employee
    {
        //Fields
        private string managerAdoptionDepartment = "Head of Adoption Decisions.";
        private string assistantWatching = "Watcher Over Volunteers.";
        private bool manager = true;
        private bool assistantManager = true;

        //Properties
        public string ManagerAdoptionDepartment
        {
            get { return this.managerAdoptionDepartment; }
        }

        public string AssistantWatching
        {
            get { return this.assistantWatching; }
        }

        public  bool Management
        {
            get { return this.manager; }
        }

        public bool AssistantManager
        {
            get { return this.assistantManager; }
        }

        //Constructors

        public Manager()
        {
            //Default Constructor
        }

        public Manager(string managerAdoptionDepartment, string assistantWatching)
        {
            this.managerAdoptionDepartment = managerAdoptionDepartment;
            this.assistantWatching = assistantWatching;
        }

        public Manager(bool manager, bool assistantManager)
        {
            this.manager = manager;
            this.assistantManager = assistantManager;
        }

        //Methods
        
        public override string Playing()
        {
            if(manager || assistantManager)
            {
                Console.WriteLine("Our pets have a great relationship with our managers");
                Console.WriteLine("You are free to play with them inside their living space.");
            }

            return "";
        }

        public override string Feeding()
        {
            if(manager || assistantManager)
            {
                Console.WriteLine("It is perfectly safe for either of our two managers to feed");
                Console.WriteLine("our pets inside their living space.");
                Console.WriteLine("You have full permission to go inside and feed them.");
            }

            return "";
        }

        public string Adopting()
        {
            if(manager)
            {
                Console.WriteLine("You're the boss!");
                Console.WriteLine("You are the only one that can adopt a pet.");
            }

            return "";
        }

    }
}
