using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Program
    {
        static readonly string quitStr = "QUIT";
        static readonly string yesStr = "Y";
        static void Main()
        {
            do
            {
                Process[] processes = Process.GetProcesses();
                Console.WriteLine("Running processes:");
                for (int i = 0; i < processes.Length; i++)
                    Console.WriteLine($"\t {processes[i].Id} \t {processes[i].ProcessName}");
                Console.Write("Enter Process ID or Process Name to kill, 'Ouit' for exit : ");
                string enterStr = Console.ReadLine();
                if (enterStr.ToUpper() == quitStr) return;

                List<Process> procLst;
                if (Int32.TryParse(enterStr, out int id))
                    procLst = GetProcessList(processes, id, String.Empty);
                else
                    procLst = GetProcessList(processes, 0, enterStr);

                if (procLst.Count == 0)
                {
                    Console.WriteLine("Invalid ID or ProcessName");
                }
                else
                {
                    Console.WriteLine("Processes to kill:");
                    foreach (Process pr in procLst)
                    {
                        Console.WriteLine($"\t ID {pr.Id} \t {pr.ProcessName}");
                    }
                    Console.WriteLine($"Kill? (Y / N)");
                    enterStr = Console.ReadLine();
                    if (enterStr.ToUpper() == yesStr)
                        KillProcesses(procLst);
                    else
                        Console.WriteLine("Canceled");
                }
                Console.ReadKey();
            }
            while (true);
        }

        static void KillProcesses(List<Process> prLst)
        {
            foreach (Process pr in prLst)
                try
                {
                    pr.Kill();
                    Console.WriteLine($"Process {pr.ProcessName}, ID {pr.Id} killed sucsessfuly");
                }
                catch (Win32Exception)
                {
                    Console.WriteLine($"Process {pr.ProcessName}, ID {pr.Id} could not be terminated");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception {e.Message}");
                }
        }

        static List<Process> GetProcessList(Process[] prArr, int p_id, string p_name)
        {
            List<Process> ListPr = new List<Process>();
            //Процесс Idle имеет ID = 0, но поскольку он не может быть остановлен, считаем что ID должен быть != 0
            if (p_id != 0)
            {
                for (int i = 0; i < prArr.Length; i++)
                    if (prArr[i].Id == p_id)
                    {
                        ListPr.Add(prArr[i]);
                        break;
                    }
            }
            else
            {
                for (int i = 0; i < prArr.Length; i++)
                    if (prArr[i].ProcessName == p_name)
                    {
                        ListPr.Add(prArr[i]);
                    }
            }
            return ListPr;
        }
    }
}
