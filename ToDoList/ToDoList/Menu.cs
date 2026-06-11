using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    internal class Menu
    {
        TaskManager taskMan = new TaskManager();
        FileManager fileMan = new FileManager();

        private void AddTask()
        {
            Console.WriteLine("------Legg til oppgave------");

            Console.Write("Tittel: ");
            string title = Console.ReadLine();

            Console.Write("Beskrivelse: ");
            string desc = Console.ReadLine();

            TaskItem task = new TaskItem(title, desc, false);
            taskMan.AddItem(task);

        }

        private void ShowAllTask()
        {
            taskMan.ShowItem();
        }

        private void ShowUnFinTask()
        {
            Console.WriteLine("------Ikke fullførte------");

            List<TaskItem> uncompleted = taskMan.GetUncompleted();
            foreach (TaskItem task in uncompleted)
            {
                Console.WriteLine($"Tittel: {task.Title}\n" +
                                  $"Beskriveslse: {task.Desc}\n");
            }
        }

        private void SearchTask()
        {
            Console.WriteLine("------Søk------");
            Console.Write("Skriv tittel: ");
            string title = Console.ReadLine();

            List<TaskItem> results = taskMan.Search(title);
            foreach (TaskItem task in results)
            {
                Console.WriteLine($"Tittel: {task.Title}\n" +
                                  $"Beskrivelse: {task.Desc}\n" +
                                  $"Fullført: {task.IsDone}\n");
            }

        }

        private void CompleteTask()
        {
            Console.WriteLine("------Fullføre oppgaver------");

            Console.Write("Hvilken oppgave vil du fullføre: ");
            string title = Console.ReadLine();

            taskMan.Completed(title);
            Console.WriteLine("Du har fullført: " + title);
        }

        private void CountCompTask()
        {
            Console.WriteLine("------Fullførte oppgaver------");

            int count = taskMan.CountCompleted();

            if (count > 0)
                Console.WriteLine($"Fullførte oppgaver: {count}");
            else
                Console.WriteLine("Du har ikke fullført noen oppgaver");
        }

        private void SaveTask()
        {
            fileMan.SaveFile(taskMan.GetItems());
        }

        private void LoadTask()
        {
            taskMan.LoadItems(fileMan.LoadFile());
        }

        public void Run()
        {
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("------Hovedside------");
                Console.WriteLine("1. Legg til Oppgave\n" +
                                  "2. Vis alle Oppgaver\n" +
                                  "3. Vis uløste oppgaver\n" +
                                  "4. Søk etter oppgave\n" +
                                  "5. Fullfør en oppgave\n" +
                                  "6. Tell fullførte oppgaver\n" +
                                  "7. Lagre til fil\n" +
                                  "8. Last fra fil\n" +
                                  "9. Avslutt\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ShowAllTask();
                        break;
                    case "3":
                        ShowUnFinTask();
                        break;
                    case "4":
                        SearchTask();
                        break;
                    case "5":
                        CompleteTask();
                        break;
                    case "6":
                        CountCompTask();
                        break;
                    case "7":
                        SaveTask();
                        break;
                    case "8":
                        LoadTask();
                        break;
                    case "9":
                        isTrue = false;
                        Console.WriteLine("Ha en fin dag");
                        break;
                }
            }
        }
    }
}
