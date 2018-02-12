using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPetShelter
    {
        //Fields
        private string petOneCage = "You've Entered: The Dragon's Nest.";
        private string petTwoCage = "You've Entered: The Liger's Den.";
        private string petThreeCage = "You've Entered: The Bear's Cabin";
        private string managerOnStaff = "Manager: John";
        private string assistantManagerOnStaff = "Assistant Manager: Emily";
        private string volunteerOneOnStaff = "Volunteer One: Charles";
        private string volunteerTwoOnStaff = "Volunteer Two: Anna";
        private string volunteerThreeOnStaff = "Volunteer Three: Misty";




        //Properties
        public string PetOneCage
        {
            get { return this.petOneCage; }
        }

        public string PetTwoCage
        {
            get { return this.petTwoCage; }
        }

        public string PetThreeCage
        {
            get { return this.petThreeCage; }
        }

        public string ManagerOnStaff
        {
            get { return this.managerOnStaff; }
        }

        public string AssistantManagerOnStaff
        {
            get { return this.assistantManagerOnStaff; }
        }

        public string VolunteerOneOnStaff
        {
            get { return this.volunteerOneOnStaff; }
        }

        public string VolunteerTwoOnStaff
        {
            get { return this.volunteerTwoOnStaff; }
        }

        public string VolunteerThreeOnStaff
        {
            get { return this.volunteerThreeOnStaff; }
        }





        //Constructors


        public VirtualPetShelter()
        {
            //Default Shelter
        }

        public VirtualPetShelter(string petOneCage, string petTwoCage, string petThreeCage, string managerOnStaff, string assistantManagerOnStaff, string volunteerOneOnStaff, string volunteerTwoOnStaff, string volunteerThreeOnStaff)
        {
            this.petOneCage = petOneCage;
            this.petTwoCage = petTwoCage;
            this.petThreeCage = petThreeCage;
            this.managerOnStaff = managerOnStaff;
            this.assistantManagerOnStaff = assistantManagerOnStaff;
            this.volunteerOneOnStaff = volunteerOneOnStaff;
            this.volunteerTwoOnStaff = volunteerTwoOnStaff;
            this.volunteerThreeOnStaff = volunteerThreeOnStaff;
           
        }


        



            

           
      

        
    }
}
