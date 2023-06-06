using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Ordinal
    {
        public static string getOrdinal(int number) 
        {
            //ერორ ტექსტში ელემენტის ნომრის დაბოლოების სწორად მისათითებლად დამჭირდა სვიჩი აქ
            if (number % 100 >= 11 && number % 100 <= 13)
            {
                return number + "th";
            }

            switch (number % 10)
            {
                case 1:
                    return number + "st";
                case 2:
                    return number + "nd";
                case 3:
                    return number + "rd";
                default:
                    return number + "th";
            }
        }
    }
}
