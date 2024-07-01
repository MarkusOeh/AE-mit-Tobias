namespace TESTZUMAUSFÜHREN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen bei TD!");

            List<string> todos = new();

            List<string> printTodos = new();
            printTodos.Add("Du hast folgende Aufgaben:");
            printTodos.Add("Welches Todo möchtest du löschen?");
            printTodos.Add("Welche Nummer soll überschieben werden?");

            void ToDoListe(string printTodos)
            {
                Console.WriteLine(printTodos);
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"\t{i}. {todos[i]}");
                }
            }

            do
            {
                Console.Clear();
                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen\n\t3. Todo abhacken\n\t4. Todo überschreiben");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // ToDos eingeben
                        Console.WriteLine("Was hast du zu tun? <Enter zum bestätigen>");
                        var todo = Console.ReadLine();
                        todos.Add(todo);
                        Console.WriteLine("Todo hinzugefügt: " + todo);
                        break;
                    case "2":
                        //Liste anzeigen
                        ToDoListe(printTodos[0]);
                        Console.WriteLine("Drücke <ENTER> um zurück ins Menü zu kommen.");
                        Console.ReadKey();
                        break;
                    case "3":
                        // Löschen
                        ToDoListe(printTodos[1]);
                        var todoIndexString = Console.ReadLine();
                        int todoIndex = int.Parse(todoIndexString);
                        todos.RemoveAt(todoIndex);
                        break;
                    case "4":
                        // Überschreiben
                        ToDoListe(printTodos[2]);
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
