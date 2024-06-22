using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    

    public static void AddThingToDo(List<string>  array)
    {
        Console.WriteLine("Enter the task to add:");
        string toDo = Console.ReadLine();
        array.Add(toDo);
        Console.WriteLine($"Task '{toDo}' added.");
    }
    public static void Change(List<string> array)
    {
        Console.WriteLine("Enter index of the task you would like to change:");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0 && number < array.Count)
        {
            Console.WriteLine("Enter new task:");
            string newToDo = Console.ReadLine();
            array[number] = newToDo;
            Console.WriteLine($"Task at index {number} changed to '{newToDo}'.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
    public static void ListTasks(List<string> array)
    {
        Console.WriteLine("Current tasks:");
        if (array.Count == 0)
        {
            Console.WriteLine("No tasks in the list.");
        }
        else
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }
        }
    }
    public static void Delete(List<string> array)
    {
        Console.WriteLine("Enter index of the task you would like to remove:");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0 && number < array.Count)
        {
            string removedTask = array[number];
            array.RemoveAt(number);
            Console.WriteLine($"Task '{removedTask}' removed.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }


    }
    public static void Main(string[] args)
    {
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine("\nType 1 to add a task.\nType 2 to change a task.\nType 3 to remove a task.\nType 4 to list tasks.\nType 5 to stop the program.");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number == 1)
                {
                    AddThingToDo(list);
                }
                else if (number == 2)
                {
                    Change(list);
                }
                else if (number == 3)
                {
                    Delete(list);
                }
                else if (number == 4)
                {
                    ListTasks(list);
                }
                else if (number == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
