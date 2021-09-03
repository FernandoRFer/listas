using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exercicios_lista_2
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  double Salary { get; set; }

        public Funcionario(int id,string name,double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;

        }

        public void IncreaseSalary (double porcetagem)
        {
            Salary += Salary * porcetagem / 100;
        }

        public override string ToString()
        {
            return Id + "," + Name + "," + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
