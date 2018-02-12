using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {

            int usersChoice;
            int usersManagerChoice;
            int usersVolunteerChoice;
            int managerDuties;
            int managerPetChoice;
            int managerAdoptionChoice;

            VirtualPet nocholasPets = new VirtualPet();
            VirtualPetShelter staffAndPets = new VirtualPetShelter();
            Manager newManager = new Manager();
            Manager newAssistant = new Manager();
            Volunteer volunteerDuties = new Volunteer();
            TypeOfPet foodList = new TypeOfPet();

            List<string> newPetAdoptions = new List<string>()
            {
                "Jake The Snake",
                "Henry The Hippo",
                "Pitch The Panther"
            };
           


            Console.WriteLine("Welcome to the Nocholas's Virtual Exotic Pet Shelter.");

            do
            {
                
                Console.WriteLine(nocholasPets.TickTockAttribute());
                Console.WriteLine();
                Console.WriteLine("Do you wanna play as a:");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Volunteer");
                Console.WriteLine("3. to exit the game.");
                usersChoice = int.Parse(Console.ReadLine());

                switch(usersChoice)
                {
                    case 1:
                        Console.WriteLine("Do you wanna play as:");
                        Console.WriteLine("1."+ staffAndPets.ManagerOnStaff);
                        Console.WriteLine("2." + staffAndPets.AssistantManagerOnStaff);
                        usersManagerChoice = int.Parse(Console.ReadLine());
                            if(usersManagerChoice == 1)
                        {
                            Console.WriteLine("You are " + newManager.ManagerAdoptionDepartment);
                            Console.WriteLine();
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("1. Play with the pets." );
                            Console.WriteLine("2. Feed and give the pets water.");
                            Console.WriteLine("3. Adopt a pet.");
                            managerDuties = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            switch (managerDuties)
                            {
                                case 1:
                                    nocholasPets.DisplayingPetsNameAndDescrition();
                                    Console.WriteLine();
                                    Console.WriteLine("Which pet would you like to play with first?");
                                    Console.WriteLine("1. " + nocholasPets.NameOfPetOne);
                                    Console.WriteLine("2. " + nocholasPets.NameOfPetTwo);
                                    Console.WriteLine("3. " + nocholasPets.NameOfPetThree);
                                    managerPetChoice = int.Parse(Console.ReadLine());
                                    if (managerPetChoice == 1)
                                    {
                                        Console.WriteLine(staffAndPets.PetOneCage);
                                        Console.WriteLine();
                                        newManager.Playing();
                                        nocholasPets.PetsHunger += 20;
                                        nocholasPets.PetsBoredom -= 20;
                                        nocholasPets.PetsHappiness += 20;
                                        nocholasPets.PetsSleepiness += 20;
                                        Console.WriteLine();
                                        Console.WriteLine(nocholasPets.NameOfPetOne + " hunger level increased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetOne + " boredom level decreased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetOne + " happiness level increased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetOne + " sleepiness level increased by 20.");
                                        Console.WriteLine();
                                        nocholasPets.DisplayingPetOneAttributes();
                                    }

                                    else if (managerPetChoice == 2)
                                    {
                                        Console.WriteLine(staffAndPets.PetTwoCage);
                                        Console.WriteLine();
                                        newManager.Playing();
                                        nocholasPets.PetsHunger += 20;
                                        nocholasPets.PetsBoredom -= 20;
                                        nocholasPets.PetsHappiness += 20;
                                        nocholasPets.PetsSleepiness += 20;
                                        Console.WriteLine();
                                        Console.WriteLine(nocholasPets.NameOfPetTwo + " hunger level increased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetTwo + " boredom level decreased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetTwo + " happiness level increased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetTwo + " sleepiness level increased by 20.");
                                        Console.WriteLine();
                                        nocholasPets.DisplayingPetTwoAttributes();
                                    }

                                    else if (managerPetChoice == 3)
                                    {
                                        Console.WriteLine(staffAndPets.PetThreeCage);
                                        Console.WriteLine();
                                        newManager.Playing();
                                        nocholasPets.PetsHunger += 20;
                                        nocholasPets.PetsBoredom -= 20;
                                        nocholasPets.PetsHappiness += 20;
                                        nocholasPets.PetsSleepiness += 20;
                                        Console.WriteLine();
                                        Console.WriteLine(nocholasPets.NameOfPetThree + " hunger level increased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetThree + " boredom level decreased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetThree + " happiness level increased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetThree + " sleepiness level increased by 20.");
                                        Console.WriteLine();
                                        nocholasPets.DisplayingPetThreeAttributes();
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("Which pet would you like to feed first?");
                                    Console.WriteLine("1. " + nocholasPets.NameOfPetOne);
                                    Console.WriteLine("2. " + nocholasPets.NameOfPetTwo);
                                    Console.WriteLine("3. " + nocholasPets.NameOfPetThree);
                                    managerPetChoice = int.Parse(Console.ReadLine());

                                    if (managerPetChoice == 1)
                                    {
                                        Console.WriteLine(staffAndPets.PetOneCage);
                                        newManager.Feeding();
                                        nocholasPets.PetsHunger -= 40;
                                        nocholasPets.PetsBoredom -= 20;
                                        nocholasPets.PetsHappiness += 40;
                                        nocholasPets.PetsSleepiness += 20;
                                        Console.WriteLine();
                                        Console.WriteLine(nocholasPets.NameOfPetOne + " hunger level decreased by 40.");
                                        Console.WriteLine(nocholasPets.NameOfPetOne + " boredom level decreased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetOne + " happiness level increased by 40.");
                                        Console.WriteLine(nocholasPets.NameOfPetOne + " sleepiness level increased by 20.");
                                        Console.WriteLine();
                                        nocholasPets.DisplayingPetOneAttributes();
                                    }

                                    else if (managerPetChoice == 2)
                                    {
                                        Console.WriteLine(staffAndPets.PetTwoCage);
                                        newManager.Feeding();
                                        nocholasPets.PetsHunger -= 40;
                                        nocholasPets.PetsBoredom -= 20;
                                        nocholasPets.PetsHappiness += 40;
                                        nocholasPets.PetsSleepiness += 20;
                                        Console.WriteLine();
                                        Console.WriteLine(nocholasPets.NameOfPetTwo + " hunger level decreased by 40.");
                                        Console.WriteLine(nocholasPets.NameOfPetTwo + " boredom level decreased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetTwo + " happiness level increased by 40.");
                                        Console.WriteLine(nocholasPets.NameOfPetTwo + " sleepiness level increased by 20.");
                                        Console.WriteLine();
                                        nocholasPets.DisplayingPetTwoAttributes();

                                    }

                                    else if (managerPetChoice == 3)
                                    {
                                        Console.WriteLine(staffAndPets.PetThreeCage);
                                        newManager.Feeding();
                                        nocholasPets.PetsHunger -= 40;
                                        nocholasPets.PetsBoredom -= 20;
                                        nocholasPets.PetsHappiness += 40;
                                        nocholasPets.PetsSleepiness += 20;
                                        Console.WriteLine();
                                        Console.WriteLine(nocholasPets.NameOfPetThree + " hunger level decreased by 40.");
                                        Console.WriteLine(nocholasPets.NameOfPetThree + " boredom level decreased by 20.");
                                        Console.WriteLine(nocholasPets.NameOfPetThree + " happiness level increased by 40.");
                                        Console.WriteLine(nocholasPets.NameOfPetThree + " sleepiness level increased by 20.");
                                        Console.WriteLine();
                                        nocholasPets.DisplayingPetThreeAttributes();
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Which new pet would you like to adopt?");
                                    foreach(string pet in newPetAdoptions)
                                    {
                                        Console.WriteLine(pet);
                                    }
                                    Console.WriteLine("Type 1, 2 or 3");
                                    managerAdoptionChoice = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    if (managerAdoptionChoice == 1)
                                    {
                                        newManager.Adopting();
                                        Console.WriteLine("You've adopted Jake The Snake");
                                        newPetAdoptions.Remove("Jake The Snake");
                                    }
                                    else if(managerAdoptionChoice == 2)
                                    {
                                        newManager.Adopting();
                                        Console.WriteLine("You've adopted Henry The Hippo");
                                        newPetAdoptions.Remove("Henry The Hippo.");
                                    }
                                    else if(managerAdoptionChoice == 3)
                                    {
                                        newManager.Adopting();
                                        Console.WriteLine("You've adopted Pitch The Panther");
                                        newPetAdoptions.Remove("Pitch The Panther");
                                    }
                                    break;
                            } 
                        }
                        else if (usersManagerChoice == 2)
                        {
                            Console.WriteLine("You are " + newManager.AssistantWatching);
                            Console.WriteLine();
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("1. Play with the pets.");
                            Console.WriteLine("2. Feed and give the pets water.");
                            managerDuties = int.Parse(Console.ReadLine());

                            if (managerDuties == 1)
                            {
                                newAssistant.Playing();
                                Console.WriteLine("You played with all the pets.");
                                nocholasPets.PetsHunger += 25;
                                nocholasPets.PetsBoredom -= 10;
                                nocholasPets.PetsHappiness += 10;
                                nocholasPets.PetsSleepiness += 25;
                                Console.WriteLine();
                                nocholasPets.DisplayingPetOneAttributes();
                            }
                            else if (managerDuties == 2)
                            {
                                newAssistant.Playing();
                                Console.WriteLine("You fed all the pets.");
                                nocholasPets.PetsHunger -= 15;
                                nocholasPets.PetsBoredom -= 15;
                                nocholasPets.PetsHappiness += 15;
                                nocholasPets.PetsSleepiness += 30;
                                Console.WriteLine();
                                nocholasPets.DisplayingPetOneAttributes();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Which volunteer do you wanna play as:");
                        Console.WriteLine("1." + staffAndPets.VolunteerOneOnStaff);
                        Console.WriteLine("2." + staffAndPets.VolunteerTwoOnStaff);
                        Console.WriteLine("3." + staffAndPets.VolunteerThreeOnStaff);
                        usersVolunteerChoice = int.Parse(Console.ReadLine());

                            if(usersVolunteerChoice == 1)
                        {
                            Console.WriteLine(volunteerDuties.Playing());
                        }
                            else if(usersVolunteerChoice == 2)
                        {
                            Console.WriteLine(volunteerDuties.Feeding());
                            Console.WriteLine(volunteerDuties.GivingWater());
                        }
                        else if(usersVolunteerChoice == 3)
                        {
                            Console.WriteLine(volunteerDuties.VolunteerSpecialtyThree);
                            Console.WriteLine("You must go catch our pet's food.");
                            Console.WriteLine("Here's the list: ");
                            Console.WriteLine(foodList.DisplayingPetTypeOneAndDiet());
                            Console.WriteLine();
                            Console.WriteLine(foodList.DisplayingPetTypeTwoAndDiet());
                            Console.WriteLine();
                            Console.WriteLine(foodList.DisplayingPetTypeThreeAndDiet());
                        }
                        break;
                }

            } while (usersChoice != 3);
        }
    }
}
