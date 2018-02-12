using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        //Fields 
        private string nameOfPetOne = "Ruby";
        private string nameOfPetTwo = "Lucy";
        private string nameOfPetThree = "Diamond";
        private string descriptionOfPetOne = "Eyes like ruby, armor like gold.";
        private string descriptionOfPetTwo = "Unique random stripes, big but a kitten at heart.";
        private string descriptionOfPetThree = "Brown and rugged like your favorite pair of boots.";
        private int petsHunger = 40;
        private int petsBoredom = 40;
        private int petsSleepiness = 40;
        private int petsHappiness = 40;

      //Properties
        public string NameOfPetOne
        {
            get { return this.nameOfPetOne; }
        }

        public string NameOfPetTwo
        {
            get { return this.nameOfPetTwo; }
        }

        public string NameOfPetThree
        {
            get { return this.nameOfPetThree; }
        }

        public string DescriptionOfPetTOne
        {
            get { return this.descriptionOfPetOne; }
        }

        public string DescriptionOfPetTwo
        {
            get { return this.descriptionOfPetTwo; }
        }

        public string DescriptionOfPetThree
        {
            get { return this.descriptionOfPetThree; }
        }

        public int PetsHunger
        {
            get { return this.petsHunger; }
            set { this.petsHunger = 40; }
        }

        public int PetsBoredom
        {
            get { return this.petsBoredom; }
            set { this.petsBoredom = 40; }
        } 

        public int PetsSleepiness
        {
            get { return this.petsSleepiness; }
            set { this.petsSleepiness = 40; }
        }

        public int PetsHappiness
        {
            get { return this.petsHappiness; }
            set { this.petsHappiness = 40; }
        }
        
        
        
        //Constructors

        public VirtualPet()
        {
            //Default Constructor
        }

        public VirtualPet(string nameOfPetOne, string nameOfPetTwo, string nameOfPetThree, string descriptionOfPetOne, string descriptionOfPetTwo, string descriptionOfPetThree)
        {
            this.nameOfPetOne = nameOfPetOne;
            this.nameOfPetTwo = nameOfPetTwo;
            this.nameOfPetThree = nameOfPetThree;
            this.descriptionOfPetOne = descriptionOfPetOne;
            this.descriptionOfPetTwo = descriptionOfPetTwo;
            this.descriptionOfPetThree = descriptionOfPetThree;
        }

        public VirtualPet(int petsHunger, int petsBoredom, int petsSleepiness, int petsHappiness)
        {
            this.petsHunger = petsHunger;
            this.petsBoredom = petsBoredom;
            this.petsSleepiness = petsSleepiness;
            this.petsHappiness = petsHappiness;
        }

       

        //Methods

        public void DisplayingPetsNameAndDescrition()
        {
            Console.WriteLine("These are the pets we have currently in the shelter:");
            Console.WriteLine(nameOfPetOne + ": " + descriptionOfPetOne);
            Console.WriteLine();
            Console.WriteLine(nameOfPetTwo + ": " + descriptionOfPetTwo);
            Console.WriteLine();
            Console.WriteLine(nameOfPetThree + ": " + descriptionOfPetThree);
        }

        public void DisplayingPetOneAttributes()
        {
            Console.WriteLine(nameOfPetOne + " Hunger Level: " + petsHunger);
            Console.WriteLine(nameOfPetOne + " Boredom Level: " + petsBoredom);
            Console.WriteLine(nameOfPetOne + " Sleepiness Level: " + petsSleepiness);
            Console.WriteLine(nameOfPetOne + " Happiness Level: " + petsHappiness);
            
        }

        public void DisplayingPetTwoAttributes()
        {
            Console.WriteLine(nameOfPetTwo + " Hunger Level: " + petsHunger);
            Console.WriteLine(nameOfPetTwo + " Boredom Level: " + petsBoredom);
            Console.WriteLine(nameOfPetTwo + " Sleepiness Level: " + petsSleepiness);
            Console.WriteLine(nameOfPetTwo + " Happiness Level: " + petsHappiness);

        }

        public void DisplayingPetThreeAttributes()
        {
            Console.WriteLine(nameOfPetThree + " Hunger Level: " + petsHunger);
            Console.WriteLine(nameOfPetThree + " Boredom Level: " + petsBoredom);
            Console.WriteLine(nameOfPetThree + " Sleepiness Level: " + petsSleepiness);
            Console.WriteLine(nameOfPetThree + " Happiness Level: " + petsHappiness);

        }

        public string TickTockAttribute()
        {
            petsHunger += 20;
            Console.WriteLine("Hunger Level: " + petsHunger);
            petsBoredom += 20;
            Console.WriteLine("Boredom Level: " + petsBoredom);
            petsSleepiness += 20;
            Console.WriteLine("Sleepiness Level: " + petsSleepiness);
            petsHappiness -= 20;
            Console.WriteLine("Happiness Level: " + petsHappiness);

            return "All pet's attributes have changed";
        }




    }
}
