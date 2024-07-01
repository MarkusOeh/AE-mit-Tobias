namespace TESTZUMAUSFÜHREN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen bei TD!");

            List<string> todos = new();



            // -------- Hausaufgabe -----------------------------
            // Liste ausgeben in eine Funktion gepackt
            // Wird später bei Case 2 3 4 benutzt
            void ToDoListe(string Konsolenausgabe)
            {
                Console.WriteLine(Konsolenausgabe);
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"\t{i}. {todos[i]}");
                }
            }
            List <string> Konsolenausgabe = new();
            Konsolenausgabe.Add("Du hast folgende Aufgaben:");
            Konsolenausgabe.Add("Welches Todo möchtest du löschen?");
            Konsolenausgabe.Add("Welche Nummer soll überschieben werden?");
            // -------------------------------------------------
            // -------------------------------------------------


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
                        ToDoListe(Konsolenausgabe[0]);

                        Console.WriteLine("Drücke <ENTER> um zurück ins Menü zu kommen.");
                        Console.ReadKey();
                        break;
                    case "3":
                        // Löschen
                        ToDoListe(Konsolenausgabe[1]);

                        var todoIndexString = Console.ReadLine();
                        int todoIndex = int.Parse(todoIndexString);
                        todos.RemoveAt(todoIndex);
                        break;
                    case "4":
                        // Überschreiben
                        ToDoListe(Konsolenausgabe[2]);

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
