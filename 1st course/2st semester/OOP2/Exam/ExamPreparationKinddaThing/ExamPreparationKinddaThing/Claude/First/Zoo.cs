using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.First
{
  internal class Zoo
  {
    List<Animal> animals;

    public void AddAnimal(Animal animal)
    {
      if (animal == null)
        throw new ArgumentException();

      animals.Add(animal);
    }

    public bool RemoveAnimal(string name)
    {
      Animal animalToRemove = animals.Where(a => a.Name == name).FirstOrDefault();
      if (animalToRemove == null)
        return false;

      animals.Remove(animalToRemove);
      return true;
    }

    public Animal FindByName(string name)
    {
      return animals.Where(a=>a.Name == name).FirstOrDefault();
    }

    public void DisplayAll()
    {
      foreach(Animal animal in animals)
        Console.WriteLine(animal.GetInfo());
    }

    public int Count
    {
      get { return animals.Count; }
    }
  }
}
