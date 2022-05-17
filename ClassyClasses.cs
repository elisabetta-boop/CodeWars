// Classy Classes
// Basic Classes, this kata is mainly aimed at the new JS ES6 Update introducing classes
// Task
// Your task is to complete this Class, the Person class has been created. You must fill in the Constructor method to accept a name as string and an age as number, complete the get Info property and getInfo method/Info getter which should return johns age is 34
// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties

public class Person
{   
 public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public string Info
    {
        get { return $"{this.Name}s age is {this.Age}"; }
        
    }
}