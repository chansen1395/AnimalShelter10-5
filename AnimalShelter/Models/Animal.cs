using System;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public Types ThisTypes { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateAdmitted { get; set; }
    public string Breed { get; set; }
  }
  public enum Types
  {
    Dog,
    Cat
  }
  public enum Gender
  {
    Male,
    Female
  }
}

//     public TeaType SelectTeaType { get; set; }
// }

// public enum TeaType
// {
//     Tea, Coffee, GreenTea, BlackTea
// }