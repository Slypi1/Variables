using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson2_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string FullName = "Петров Сергей Леонидович";//Ф.И.О
            int Years = 19;//возраст
            string Email = "petrov_sl@gmail.com";//email
            double ProgrammingMark = 98.5;// баллы по програмированию 
            double MathsMark = 76.9;//баллы по математике
            double PhysicsMark = 86.4;// баллы пр физике 

            Console.WriteLine($"Ф.И.О: {FullName} \nВозраст: {Years} \nEmail: {Email} \nБаллы по програмированию: {ProgrammingMark} \nБаллы по матетике: {MathsMark} \nБаллы по физике: {PhysicsMark}");
            
            Console.ReadKey();

        }
    }
}
