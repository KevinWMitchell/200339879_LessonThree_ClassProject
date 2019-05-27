using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _200339879_LessonThree_ClassProject.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Year { get; set; } 

        public Car(int Id, string Brand, string Model, string Type, int Year)
        {
            this.Id = Id;
            this.Brand = Brand;
            this.Model = Model;
            this.Type = Type;
            this.Year = Year;
        }

       
    }
}