using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkObjectFirstClass.Models
{
   public class Driver
    {
        public string Name { get; set; }
        public double Skill { get; set; }
        

        public Driver()
        {

        }
        public Driver(string name, double skill)
        {
            Name = name;
            Skill = skill;
            
        }

        public static implicit operator string(Driver v)
        {
            throw new NotImplementedException();
        }
    }

    
}
