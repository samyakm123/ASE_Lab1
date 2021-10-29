using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMass
{
    class Program
    {
        static void Main(string[] args)
        {
            string stats;
            string next = "y";

            while(next == "y")
            {
                Console.WriteLine("Enter full name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your gender(m/f): ");
                string gender = Console.ReadLine();

                Console.WriteLine("Enter your body mass in kilograms: ");
                string m = Console.ReadLine();
                float mass = Single.Parse(m);

                Console.WriteLine("Enter your height in meters: ");
                string h = Console.ReadLine();
                float height = Single.Parse(h);

                float bmi;
                bmi = mass / (height * height);

                if (gender == "f")
                {
                    if (bmi < 17.5)
                    { stats = "anorexia"; }

                    else if (bmi < 19.1)
                    { stats = "underweight"; }

                    else if (bmi > 19.1 && bmi < 25.8)
                    { stats = "in normal range"; }

                    else if (bmi > 25.8 && bmi < 27.3)
                    { stats = "marginally overweight"; }

                    else if (bmi > 27.3 && bmi < 32.3)
                    { stats = "overweight"; }

                    else if (bmi > 32.3 && bmi < 35)
                    { stats = "very overweight or obese"; }

                    else if (bmi > 35 && bmi < 40)
                    { stats = "severely obese"; }

                    else if (bmi > 40 && bmi < 50)
                    { stats = "morbidly obese"; }

                    else
                    { stats = "super obese"; }
                }

                else
                {
                    if (bmi < 17.5)
                    { stats = "anorexia"; }

                    else if (bmi < 20.7)
                    { stats = "underweight"; }

                    else if (bmi > 20.7 && bmi < 26.4)
                    { stats = "in normal range"; }

                    else if (bmi > 26.4 && bmi < 27.8)
                    { stats = "marginally overweight"; }

                    else if (bmi > 27.8 && bmi < 31.1)
                    { stats = "overweight"; }

                    else if (bmi > 31.1 && bmi < 35)
                    { stats = "very overweight or obese"; }

                    else if (bmi > 35 && bmi < 40)
                    { stats = "severely obese"; }

                    else if (bmi > 40 && bmi < 50)
                    { stats = "morbidly obese"; }

                    else
                    { stats = "super obese"; }
                }

                Console.WriteLine(name);
                Console.WriteLine(gender);
                Console.WriteLine(bmi.ToString());
                Console.WriteLine(stats);

                Console.WriteLine("Do u want to enter a new value? (y/n): " );
                next = Console.ReadLine();
                
            }
        }
    }
}
