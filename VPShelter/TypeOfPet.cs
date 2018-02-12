using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
   public class TypeOfPet : VirtualPet
    {

        //FieldsProperties     
        private string petTypeOne = "Komodo Dragon";
        private string petTypeTwo = "Liger";
        private string petTypeThree = "Brown Bear";
        private string specificDietOfPetOne = "Deers, Buffalos, Pigs, Smaller Dragons, Carrions";
        private string specificDietOfPetTwo = "Beef, Chicken, Deer, Cattle, Wild Boar";
        private string specificDietOfPetThree = "Salmon, Grass, Fruit, Insects, Carrion";

       
        //Properties

        public string PetTypeOne
        {
            get { return this.petTypeOne; }
        }

        public string PetTypeTwo
        {
            get { return this.petTypeTwo; }
        }

        public string PetTypeThree
        {
            get { return this.petTypeThree; }
        }

        public string SpecificDietOfPetOne
        {
            get { return this.specificDietOfPetOne; }
        }

        public string SpecificDietOfPetTwo
        {
            get { return this.specificDietOfPetTwo; }
        }

        public string SpecificDietOfPetThree
        {
            get { return this.specificDietOfPetThree; }
        }


        //Constructors 

        public TypeOfPet()
        {
            //Default Constructors
        }

        public TypeOfPet(string petTypeOne, string petTypeTwo, string petTypeThree, string specificDietOfPetOne, string specificDietOfPetTwo, string specificDietOfPetThree)
        {
            this.petTypeOne = petTypeOne;
            this.petTypeTwo = petTypeTwo;
            this.petTypeThree = petTypeThree;
            this.specificDietOfPetOne = specificDietOfPetOne;
            this.specificDietOfPetTwo = specificDietOfPetTwo;
            this.specificDietOfPetThree = specificDietOfPetThree;
        }

        //Methods 

        public string DisplayingPetTypeOneAndDiet()
        {
            Console.WriteLine(NameOfPetOne + " is a " + petTypeOne + ".");
            Console.WriteLine();
            Console.WriteLine(NameOfPetOne + " eats " + specificDietOfPetOne + ".");
            return "";
        }

        public string DisplayingPetTypeTwoAndDiet()
        {
            Console.WriteLine(NameOfPetTwo + " is a " + petTypeTwo + ".");
            Console.WriteLine();
            Console.WriteLine(NameOfPetTwo + " eats " + specificDietOfPetTwo + ".");
            return "";
        }

        public string DisplayingPetTypeThreeAndDiet()
        {
            Console.WriteLine(NameOfPetThree + " is a " + petTypeThree + ".");
            Console.WriteLine();
            Console.WriteLine(NameOfPetThree + " eats " + specificDietOfPetThree + ".");
            return "";
        }



    }
}


