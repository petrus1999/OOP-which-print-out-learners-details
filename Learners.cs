using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_which_print_out_learners_details
{
     class Learners
    {
        public string name;
        public string surname;
        public string course;
        public string duration;
        public decimal price;

        public Learners(string Name,string Surname,string Course,string Duration, decimal Price)
        {
            name = Name;
            surname = Surname;
            course = Course;
            duration = Duration;
            price = Price;

        }
    }
}
