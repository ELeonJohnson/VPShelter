using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        //Fields
        private string volunteerSpecialtyOne = "Player of the pets.";
        private string volunteerSpecialtyTwo = "Feeder of the pets.";
        private string volunteerSpecialtyThree = "Catcher of the pet's food.";
        private bool volunteerOne = true;
        private bool volunteerTwo = true;

       
        //Property 
        public string VolunteerSpecialtyOne
        {
            get { return this.volunteerSpecialtyOne; }
        }

        public string VolunteerSpecialtyTwo
        {
            get { return this.volunteerSpecialtyTwo; }
        }

        public string VolunteerSpecialtyThree
        {
            get { return this.volunteerSpecialtyThree; }
        }

        public bool VolunteerOne
        {
            get { return this.volunteerOne; }
        }

        public bool VolunteerTwo
        {
            get { return this.volunteerTwo; }
        }

       


        //Constructors

        public Volunteer()
        {
            //Default Constructor
        }

        public Volunteer(string volunteerSpecialtyOne, string volunteerSpecialtyTwo, string volunteerSpecialtyThree)
        {
            this.volunteerSpecialtyOne = volunteerSpecialtyOne;
            this.volunteerSpecialtyTwo = volunteerSpecialtyTwo;
            this.volunteerSpecialtyThree = volunteerSpecialtyThree;
        }

        public Volunteer(bool volunteerOne, bool volunteerTwo)
        {
            this.volunteerOne = volunteerOne;
            this.volunteerTwo = volunteerTwo;
        }


        //Methods

        public override string Playing()
        {
           if(volunteerOne)
            {
                Console.WriteLine("You must be our Volunteer One...");
                Console.WriteLine("You must play with our exotic pets outside of their living spaces.");
                
            }
            return "";
            
        }

        public override string Feeding()
        {
            if(volunteerTwo)
            {
                Console.WriteLine("You must be our Volunteer Two...");
                Console.WriteLine("You must feed all of our exotic pets outside of their living spaces.");
            }

            return "";
        }

        public string GivingWater()
        {
            Console.WriteLine("All animals have been hydrated.");
            return "";
        }

       
            
            
            
            
        

        







    }

}
