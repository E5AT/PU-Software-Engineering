using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.Third
{
  internal class Company
  {
    private List<Employee> employees;

    public Company()
    {
      employees = new List<Employee>();
    }

    public void Add(Employee employee)
    {
      if (employee == null)
        throw new ArgumentNullException();

      employees.Add(employee);
    }

    public void Remove(string facNum)
    {
      employees.Remove(employees.Where(e=>e.FacNum==facNum).FirstOrDefault());
    }

    public void PrintAll()
    {
      foreach(Employee employee in employees)
        Console.WriteLine(employee.GetInfo());
    }

    public Employee GetEmpoyeeWithTheHighestSalary()
    {
      return employees.Where(e=>e.Salary==(employees.Select(em=>em.Salary).Max())).FirstOrDefault();
    }

    public void PrintProgrammers()
    {
      foreach(Programmer programmer in employees.Where(e=>e is Programmer))
        Console.WriteLine(programmer.GetInfo());
    }

    public void PrintManagers()
    {
      foreach(Manager manager in employees.Where(e=>e is Manager))
        Console.WriteLine(manager.GetInfo());
    }
  }
}
