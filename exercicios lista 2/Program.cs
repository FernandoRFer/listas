using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicios_lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //aaaaaaaaaaaaaaaaaaaaaaasadsadsa dsad sads ad
            //aaaaaaaaaaaaaaaaaaaaaaasadsadsa dsad sads ad
            //aaaaaaaaaaaaaaaaaaaaaaasadsadsa dsad sads ad
            //aaaaaaaaaaaaaaaaaaaaaaasadsadsa dsad sads ad
            //aaaaaaaaaaaaaaaaaaaaaaasadsadsa dsad sads ad
            //aaaaaaaaaaaaaaaaaaaaaaasadsadsa dsad sads ad
            //aaaaaaaaaaaaaaaaaaaaaaasadsadsa dsad sads ad
            List<Funcionario> list = new List<Funcionario>();

            Console.WriteLine("How many employees will be registered?");
            int reg = int.Parse(Console.ReadLine());

            for (int i = 1; i <= reg; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase :");
            int searched = int.Parse(Console.ReadLine());

            Funcionario fun = list.Find(x => x.Id == searched);

            if (fun != null)
            {
                Console.Write("Enter the percentage:");
                double porce = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                fun.IncreaseSalary(porce);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
