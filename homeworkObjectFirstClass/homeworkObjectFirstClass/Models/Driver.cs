using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkObjectFirstClass.Models
{
   public class Driver
    {
        public string Name { get; set; }
        public double Skill { get; set; }
        public bool IsChose { get; set; }
        

        public Driver()
        {

        }
        public Driver(string name, double skill, bool isChose)
        {
            Name = name;
            Skill = skill;
            IsChose = isChose;
            

        }

      
    }

    
}
