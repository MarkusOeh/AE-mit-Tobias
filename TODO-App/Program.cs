using System.Linq;

namespace TODO_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menü anzeigen mit Optionen
            Console.WriteLine("Willkommen bei TD!");

            List<string> todos = new();

            // Console.WriteLine(todos.Count); // Ausgabe ist die Kapazität, also 20

            // das hier ist aktuell noch null!!!
            // Console.WriteLine(todos[9]);

            do
            {
                Console.Clear();
                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen\n\t3. Todo abhacken\n\t4. Todo überschreiben");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // ToDo hinzufügen
                        Console.WriteLine("Was hast du zu tun? <Enter zum bestätigen>");
                        var todo = Console.ReadLine();

                        todos.Add(todo);
                        Console.WriteLine("Todo hinzugefügt: " + todo);
                        break;
                    case "2":
                        // Liste der ToDos ausgeben
                        Console.WriteLine("Du hast folgende Aufgaben:");
                        for (int i = 0; i < todos.Count; i++)
                        {
                            Console.WriteLine($"\t{i}. {todos[i]}");
                        }
                        Console.WriteLine("Drücke <ENTER> um zurück ins Menü zu kommen.");
                        Console.ReadKey();
                        break;
                    case "3":
                        // Einzelnes ToDo Löschen
                        Console.WriteLine("Welches Todo möchtest du löschen?");
                        for (int i = 0; i < todos.Count; i++)
                        {
                            Console.WriteLine($"\t{i}. {todos[i]}");
                        }
                        var todoIndexString = Console.ReadLine();
                        int todoIndex = int.Parse(todoIndexString);
                        todos.RemoveAt(todoIndex);
                        break;
                    case "4":
                        // Überschreiben eines ToDos
                        Console.WriteLine("Welches Todo möchtest du anpassen?");
                        for (int i = 0; i < todos.Count; i++)
                        {
                            Console.WriteLine($"\t{i}. {todos[i]}");
                        }
                        var indexString = Console.ReadLine();
                        int index = int.Parse(indexString);

                        Console.WriteLine("Was möchtest du stattdessen tun?");
                        var newTodo = Console.ReadLine();
                        todos[index] = newTodo;
                        break;
                }
            } while (true);
        }
    }
}
