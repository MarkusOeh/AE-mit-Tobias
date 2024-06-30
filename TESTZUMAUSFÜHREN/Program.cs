namespace TESTZUMAUSFÜHREN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen bei TD!");

            List<string> todos = new();



            // -------- Hausaufgabe ----------
            void ZeugAuflisten() // Eine Funktion erstellt damit wir das nicht bei Case 2,3,4 immer machen müssen
            {
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"\t{i}. {todos[i]}");
                }
            }
            // -------------------------------


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
                        Console.WriteLine("Du hast folgende Aufgaben:");

                        ZeugAuflisten();

                        Console.WriteLine("Drücke <ENTER> um zurück ins Menü zu kommen.");
                        Console.ReadKey();
                        break;
                    case "3":
                        // Löschen
                        Console.WriteLine("Welches Todo möchtest du löschen?");

                        ZeugAuflisten();

                        var todoIndexString = Console.ReadLine();
                        int todoIndex = int.Parse(todoIndexString);
                        todos.RemoveAt(todoIndex);
                        break;
                    case "4":
                        // Überschreiben
                        Console.WriteLine("Welche Nummer soll überschieben werden?");

                        ZeugAuflisten();

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
