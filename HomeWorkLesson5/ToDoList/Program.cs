using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static readonly string addTaskSign = "A";
        static readonly int maxNumOfTasks = 100;
        static int numOfTasks = 0;
        static readonly string jsonFileName = "tasks.json";
 
        static void Main()
        {
            string json;

            ToDo[] tasks = new ToDo[maxNumOfTasks];
            if (File.Exists(jsonFileName))
            {
                json = File.ReadAllText(jsonFileName);
                tasks = JsonSerializer.Deserialize<ToDo[]>(json);
                do
                    numOfTasks++;
                while (!(tasks[numOfTasks] == null));
            }

            int res = 1;
            string entS;
            bool valid;
            do
            {
                Console.Clear();
                for (int i = 0; i < numOfTasks; i++)
                {
                    Console.WriteLine($"{i + 1} {tasks[i].GetString()}");
                }
                Console.WriteLine(Environment.NewLine);
                Console.Write("Введите номер задачи для изменения ее статуса, A для добавления задачи, 0 для выхода : ");
                entS = Console.ReadLine();
                if (String.Compare(entS.ToUpper(), addTaskSign) == 0)
                {
                    Console.Write("Введите новую задачу : ");
                    entS = Console.ReadLine();
                    tasks[numOfTasks] = new ToDo(entS, false);
                    numOfTasks++;
                }
                else
                {
                    valid = Int32.TryParse(entS, out res);
                    if (valid && res > 0 && res < numOfTasks + 1)
                        tasks[res - 1].IsDone = !tasks[res - 1].IsDone;
                }
            }
            while (!(res == 0));
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            json = JsonSerializer.Serialize(tasks, options);
            File.WriteAllText(jsonFileName, json); 
        }
    }
}
