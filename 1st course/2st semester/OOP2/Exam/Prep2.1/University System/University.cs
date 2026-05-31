using System.Linq;

namespace University_System;

public class University
{
    private readonly List<Person> persons;

    public University()
    {
        persons = new();
    }

    public IReadOnlyList<Person> Persons => persons.AsReadOnly();

    public void AddPerson(Person person)
    {
        if (person is null)
            throw new ArgumentNullException(nameof(person), "Person cannot be null!");

        persons.Add(person);
    }

    public void RemovePerson(int id)
    {
        Person? personToDelete = persons.FirstOrDefault(p => p.Id == id);

        if (personToDelete is null)
            throw new InvalidOperationException("Cannot find person with that id!");

        persons.Remove(personToDelete);
    }

    public Person? GetHighestSalaryPerson()
    {
        var salaryPeople = persons.Where(p => p.Salary > 0);
        return salaryPeople.Any() ? salaryPeople.MaxBy(p => p.Salary) : null;
    }

    public Student? GetStudentWithHighestCredits()
    {
        return persons.Where(p => p is Student).Select(p=>(Student)p).MaxBy(s=>s.Salary);
    }

    public List<Person> GetTop3OldestPersons()
    {
        return persons.OrderByDescending(p => p.Age).Take(3).ToList();
    }

    public double GetTotalSalaryCost()
    {
        return persons.Sum(p => p.Salary);
    }

    public IEnumerable<string> GetAllInfo() // helper method for PrintAll()
    {
        return persons.Select(p => p.GetInfo());
    }

    public void PrintAll()
    {
        Console.WriteLine(string.Join("\n", GetAllInfo()));
    }
}
