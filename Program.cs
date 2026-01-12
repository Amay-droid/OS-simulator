using System;
using MiniOS.Core;

class Program
{
    static void Main()
    {
        ProcessManager processManager = new ProcessManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("====== MINI OS SIMULATOR ======");
            Console.WriteLine("1. Create Process");
            Console.WriteLine("2. View All Processes");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Process Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Priority: ");
                    int priority = int.Parse(Console.ReadLine());

                    Console.Write("Burst Time: ");
                    int burstTime = int.Parse(Console.ReadLine());

                    var process = processManager.CreateProcess(name, priority, burstTime);
                    Console.WriteLine($"Created: {process}");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine("---- Process Table ----");
                    foreach (var p in processManager.GetAllProcesses())
                    {
                        Console.WriteLine(p);
                    }
                    Console.ReadKey();
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
