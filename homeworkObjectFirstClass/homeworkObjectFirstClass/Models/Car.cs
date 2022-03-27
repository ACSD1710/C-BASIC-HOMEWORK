using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkObjectFirstClass.Models
{
   public class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public bool IsChosen { get; set; }
        

        public Car()
        {

        }
        public Car(string model, double speed, bool isChosen)
        {
            Model = model;
            Speed = speed;
            IsChosen = isChosen;
        }

    }
}
