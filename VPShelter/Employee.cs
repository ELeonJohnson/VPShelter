using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
   public abstract class Employee
    {

        //Fields 
        int employeeID = 123456;


        //Properties 
        public int EmployeeID
        {
            get { return this.employeeID; }
        }
        
        
        
        
        //Methods
        
        public abstract string Playing();
        public abstract string Feeding();

        
        
        
        


    }
}
