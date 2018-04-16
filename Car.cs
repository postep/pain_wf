using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Car
    {
        public string Make
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public int Year
        {
            get;
            set;
        }

        public string Plate
        {
            get;
            set;
        }

        public int Speed
        {
            get;
            set;
        }

        public bool isValid()
        {
            return (Make.Length != 0 & Model.Length != 0 & Year >= 1970 & Year < 2200 & 
                Speed >= 30 & Speed <= 500 & Plate.Length > 5 & Plate.Length < 10 &
                (Type == "Motocykl" | Type == "Osobowy"));
        }
        public Car(string make, string model, string type, int year, string plate, int speed)
        {
            Make = make;
            Model = model;
            Type = type;
            Year = year;
            Plate = plate;
            Speed = speed;
        }

        public Car() 
        { 
        }

    }
}
