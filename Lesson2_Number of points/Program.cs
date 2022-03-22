using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Number_of_points
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ProgrammingMark = 98.5;// баллы по програмированию 
            double MathsMark = 76.9;//баллы по математике
            double PhysicsMark = 86.4;// баллы пр физике 
            
            double SumMark = ProgrammingMark + MathsMark + PhysicsMark;// сумма баллов 
            double MediumMark = SumMark / 3;// средний балл

            string FormatMark = MediumMark.ToString("#.#");// формат ввывода среднего балла

            Console.WriteLine("Сумма баллов: " + SumMark);

            Console.ReadKey();

            Console.WriteLine("\nСредний балл: " + FormatMark);

            Console.ReadKey();


        }
    }
}
