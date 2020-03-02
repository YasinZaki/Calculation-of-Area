using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16_Modular_Calculator
{
    class Calculator
    {
         //Rectangle Area Function
        public double Rectangle(double num1, double num2)
        {
            return num1 * num2;
        }
        
        //Circle Area Function
        public double Circle(double radius)
        {
            
                
                double pi = Math.PI;


            return pi * (radius * radius); ;

         }

        //Triangle Area Function 
        public double Triangle(double num1, double num2)
        {
            return num1 * num2 / 2;
        }

 

   
    }
}
