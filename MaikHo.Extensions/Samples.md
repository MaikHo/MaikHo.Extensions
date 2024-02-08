Extension-Methods können für viele verschiedene Zwecke erstellt werden, um die Funktionalität von vorhandenen Klassen zu erweitern oder um nützliche Hilfsfunktionen bereitzustellen. Hier sind einige weitere Bereiche, für die man Extension-Methods erstellen kann:

1. **String-Verarbeitung**: Erweitern von `string`-Funktionalitäten, z. B. das Formatieren von Zeichenfolgen, das Entfernen oder Extrahieren von Teilen, das Umwandeln von Zeichenfolgen in bestimmte Formate usw.

2. **Dateioperationen**: Erstellen von Methoden zum Lesen, Schreiben, Löschen oder Manipulieren von Dateien und Ordnern.

3. **Validierung**: Erstellen von Validierungsmethoden für verschiedene Datentypen, z. B. Überprüfen von E-Mail-Adressen, Passwörtern, Zahlenbereichen usw.

4. **Datenkonvertierung**: Erstellen von Methoden zum Konvertieren von Daten zwischen verschiedenen Formaten, z. B. JSON, XML, CSV usw.

5. **Mathematische Operationen**: Hinzufügen von mathematischen Funktionen, die in der Standardbibliothek fehlen könnten, z. B. Berechnung von Quadratwurzeln, Potenzen, Trigonometrie usw.

6. **Serialization/Deserialization**: Erstellen von Methoden zum Serialisieren und Deserialisieren von Objekten in verschiedene Formate, z. B. JSON, XML, Binary usw.

7. **Logging und Tracing**: Erweitern von Logging- und Tracing-Funktionen, um das Protokollieren von Ereignissen zu erleichtern.

8. **Webentwicklung**: Erstellen von Methoden zum Senden von HTTP-Anfragen, Verarbeiten von JSON- oder XML-Antworten, Parsen von HTML, usw.

9. **Datenbankzugriff**: Erweitern von Datenbankfunktionalitäten, z. B. das Ausführen von Abfragen, das Mapping von Datenbanktabellen auf Objekte usw.

10. **Benutzeroberfläche**: Erstellen von Hilfsmethoden für die Benutzeroberfläche, z. B. das Manipulieren von Steuerelementen, Validieren von Benutzereingaben usw.

11. **Kryptografie**: Erstellen von Methoden zum Hashen, Verschlüsseln oder Signieren von Daten.

Das sind nur einige Beispiele, aber im Grunde genommen können Extension-Methods für fast jeden Bereich der Softwareentwicklung erstellt werden, um die Code-Wiederverwendbarkeit, Lesbarkeit und Funktionalität zu verbessern.

```cs
using System;
using MaikHo.Extensions.String;

class Program
{
    static void Main()
    {
        // Beispiel für die Verwendung der Reverse-Methode
        string reversedString = "hello".Reverse();
        Console.WriteLine(reversedString); // Ausgabe: "olleh"

        // Beispiel für die Verwendung der IsPalindrome-Methode
        string palindrome = "anna";
        bool isPalindrome = palindrome.IsPalindrome();
        Console.WriteLine($"Is \"{palindrome}\" a palindrome? {isPalindrome}"); // Ausgabe: "Is "anna" a palindrome? True"

        // Beispiel für die Verwendung der CountOccurrences-Methode
        string text = "hello world";
        char character = 'l';
        int occurrences = text.CountOccurrences(character);
        Console.WriteLine($"The character '{character}' occurs {occurrences} times in \"{text}\""); // Ausgabe: "The character 'l' occurs 3 times in "hello world""
    }
}



```

```cs

using System;
using MaikHo.Extensions.Int;

class Program
{
    static void Main()
    {
        int number = 6;

        // Überprüfen, ob die Zahl gerade ist
        bool isEven = number.IsEven();
        Console.WriteLine($"Is {number} even? {isEven}"); // Ausgabe: "Is 6 even? True"

        // Überprüfen, ob die Zahl ungerade ist
        bool isOdd = number.IsOdd();
        Console.WriteLine($"Is {number} odd? {isOdd}"); // Ausgabe: "Is 6 odd? False"

        // Berechnen der Quadratzahl
        int square = number.Square();
        Console.WriteLine($"The square of {number} is {square}"); // Ausgabe: "The square of 6 is 36"

        // Überprüfen, ob die Zahl positiv ist
        bool isPositive = number.IsPositive();
        Console.WriteLine($"Is {number} positive? {isPositive}"); // Ausgabe: "Is 6 positive? True"

        // Überprüfen, ob die Zahl negativ ist
        bool isNegative = number.IsNegative();
        Console.WriteLine($"Is {number} negative? {isNegative}"); // Ausgabe: "Is 6 negative? False"

        // Berechnen der Fakultät
        int factorial = number.Factorial();
        Console.WriteLine($"The factorial of {number} is {factorial}"); // Ausgabe: "The factorial of 6 is 720"

        // Überprüfen, ob die Zahl eine Primzahl ist
        bool isPrime = number.IsPrime();
        Console.WriteLine($"Is {number} prime? {isPrime}"); // Ausgabe: "Is 6 prime? False"
    }
}


```

```cs

using System;
using System.Collections.Generic;
using MaikHo.Extensions.Linq;

class Program
{
    static void Main()
    {
        // Beispiel Daten
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

        // Filtern einer Liste nach einer bestimmten Bedingung
        var filteredNumbers = numbers.Filter(x => x % 2 == 0);
        Console.WriteLine("Filtered Numbers:");
        foreach (var num in filteredNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        // Summieren aller Elemente in einer Liste
        var sum = numbers.Sum();
        Console.WriteLine($"Sum of numbers: {sum}");
        Console.WriteLine();

        // Ermitteln des Durchschnitts aller Elemente in einer Liste
        var average = numbers.Average();
        Console.WriteLine($"Average of numbers: {average}");
        Console.WriteLine();

        // Ermitteln des maximalen Elements in einer Liste
        var max = numbers.Max();
        Console.WriteLine($"Max of numbers: {max}");
        Console.WriteLine();

        // Ermitteln des minimalen Elements in einer Liste
        var min = numbers.Min();
        Console.WriteLine($"Min of numbers: {min}");
        Console.WriteLine();

        // Konvertieren einer Liste von einem Typ in einen anderen
        var lengths = words.ConvertAll(x => x.Length);
        Console.WriteLine("Lengths of words:");
        foreach (var length in lengths)
        {
            Console.WriteLine(length);
        }
        Console.WriteLine();

        // Überprüfen, ob alle Elemente in einer Liste eine Bedingung erfüllen
        var allEven = numbers.All(x => x % 2 == 0);
        Console.WriteLine($"All numbers even? {allEven}");
        Console.WriteLine();

        // Überprüfen, ob mindestens ein Element in einer Liste eine Bedingung erfüllt
        var anyEven = numbers.Any(x => x % 2 == 0);
        Console.WriteLine($"Any number even? {anyEven}");
        Console.WriteLine();

        // Erste Element in einer Liste zurückgeben oder einen Standardwert zurückgeben, falls die Liste leer ist
        var firstOrDefault = numbers.FirstOrDefault();
        Console.WriteLine($"First or default: {firstOrDefault}");
        Console.WriteLine();

        // Letztes Element in einer Liste zurückgeben oder einen Standardwert zurückgeben, falls die Liste leer ist
        var lastOrDefault = numbers.LastOrDefault();
        Console.WriteLine($"Last or default: {lastOrDefault}");
        Console.WriteLine();

        // Gruppieren von Elementen einer Liste nach einem bestimmten Schlüssel
        var groupedWords = words.GroupBy(x => x[0]);
        Console.WriteLine("Grouped words by first letter:");
        foreach (var group in groupedWords)
        {
            Console.WriteLine($"Key: {group.Key}, Count: {group.Count()}");
        }
        Console.WriteLine();

        // Ermitteln des Indexes eines Elements in einer Liste
        var index = words.IndexOf("banana");
        Console.WriteLine($"Index of 'banana': {index}");
        Console.WriteLine();

        // Mischen der Elemente in einer Liste
        var shuffledNumbers = numbers.Shuffle();
        Console.WriteLine("Shuffled numbers:");
        foreach (var num in shuffledNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        // Durchführen einer benutzerdefinierten Aggregatfunktion auf den Elementen einer Liste
        var product = numbers.Aggregate(1, (acc, x) => acc * x);
        Console.WriteLine($"Product of numbers: {product}");
        Console.WriteLine();

        // Zählen der Elemente in einer Liste
        var count = numbers.Count();
        Console.WriteLine($"Count of numbers: {count}");
        Console.WriteLine();

        // Zählen der Elemente in einer Liste, die eine bestimmte Bedingung erfüllen
        var countEven = numbers.Count(x => x % 2 == 0);
        Console.WriteLine($"Count of even numbers: {countEven}");
        Console.WriteLine();

        // Filtern einer Liste und Projektion der Ergebnisse in eine neue Liste
        var lengthsOfEvenWords = words.WhereSelect(x => x.Length % 2 == 0, x => x.Length);
        Console.WriteLine("Lengths of even length words:");
        foreach (var length in lengthsOfEvenWords)
        {
            Console.WriteLine(length);
        }
        Console.WriteLine();

        // Zusammenfügen von zwei Listen
        var combinedList = numbers.Concat(numbers);
        Console.WriteLine("Combined list:");
        foreach (var num in combinedList)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        // Ausschließen der Duplikate in einer Liste
        var distinctNumbers = numbers.Distinct();
        Console.WriteLine("Distinct numbers:");
        foreach (var num in distinctNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        // Sortieren der Elemente in einer Liste
        var sortedNumbers = numbers.OrderBy(x => x);
        Console.WriteLine("Sorted numbers:");
        foreach (var num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        // Aufteilen einer Liste in Teillisten bestimmter Größe
        var chunks = numbers.Chunk(2);
        Console.WriteLine("Chunks of numbers:");
        foreach (var chunk in chunks)
        {
            Console.WriteLine(string.Join(", ", chunk));
        }
        Console.WriteLine();

        // Kombinieren von zwei Listen durch Ausführung einer Funktion auf entsprechenden Elementen
        var zippedList = numbers.Zip(numbers, (x, y) => x * y);
        Console.WriteLine("Zipped list:");
        foreach (var num in zippedList)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        // Prüfen, ob alle Elemente in einer Liste identisch sind
        var allEqual = numbers.AllEqual();
        Console.WriteLine($"All numbers equal? {allEqual}");
        Console.WriteLine();

        // Ermitteln der häufigsten Elemente in einer Liste
        var mostCommon = numbers.MostCommon();
        Console.WriteLine("Most common numbers:");
        foreach (var num in mostCommon)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        // Ermitteln der seltensten Elemente in einer Liste
        var leastCommon = numbers.LeastCommon();
        Console.WriteLine("Least common numbers:");
        foreach (var num in leastCommon)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        // Ermitteln des durchschnittlichen Werts eines bestimmten Felds in einer Liste von Objekten
        var averageLength = words.Average(x => x.Length);
        Console.WriteLine($"Average length of words: {averageLength}");
        Console.WriteLine();

        // Ermitteln des maximalen Werts eines bestimmten Felds in einer Liste von Objekten
        var maxLengthWord = words.MaxBy(x => x.Length);
        Console.WriteLine($"Longest word: {maxLengthWord}");
        Console.WriteLine();

        // Ermitteln des minimalen Werts eines bestimmten Felds in einer Liste von Objekten
        var minLengthWord = words.MinBy(x => x.Length);
        Console.WriteLine($"Shortest word: {minLengthWord}");
        Console.WriteLine();

        // Zählen der Vorkommen jedes Elements in einer Liste
        var occurrences = numbers.CountOccurrences();
        Console.WriteLine("Occurrences of numbers:");
        foreach (var kvp in occurrences)
        {
            Console.WriteLine($"Number: {kvp.Key}, Count: {kvp.Value}");
        }
        Console.WriteLine();

        // Filtern und Projektion der Ergebnisse in eine neue Liste basierend auf einer Bedingung
        var evenWordLengths = words.WhereSelect(x => x.Length % 2 == 0, x => x.Length);
        Console.WriteLine("Lengths of words with even length:");
        foreach (var length in evenWordLengths)
        {
            Console.WriteLine(length);
        }
        Console.WriteLine();

        // Entfernen von Duplikaten aus einer Liste unter Berücksichtigung eines bestimmten Schlüssels
        var distinctByLength = words.DistinctBy(x => x.Length);
        Console.WriteLine("Distinct words by length:");
        foreach (var word in distinctByLength)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine();

        // Zufällige Auswahl eines Elements aus einer Liste
        var randomWord = words.RandomElement();
        Console.WriteLine($"Random word: {randomWord}");
        Console.WriteLine();

        // Partitionieren einer Liste in Seiten mit einer bestimmten Größe
        var partitions = numbers.Partition(2);
        Console.WriteLine("Partitions of numbers:");
        foreach (var partition in partitions)
        {
            Console.WriteLine(string.Join(", ", partition));
        }
        Console.WriteLine();

        // Überprüfen, ob eine Liste leer oder null ist
        var isNullOrEmpty = words.IsNullOrEmpty();
        Console.WriteLine($"Is words list null or empty? {isNullOrEmpty}");
        Console.WriteLine();

        // Aufspalten einer Zeichenfolge in Wörter und Filtern der Leerzeichen
        var sentence = "This is a test sentence.";
        var wordsInSentence = sentence.SplitAndTrim(' ');
        Console.WriteLine("Words in sentence:");
        foreach (var word in wordsInSentence)
        {
            Console.WriteLine(word);
        }
    }
}


```

```cs

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MaikHo.Extensions.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen einer ObservableCollection von Personen
            var people = new ObservableCollection<Person>
            {
                new Person("Alice", 25),
                new Person("Bob", 30),
                new Person("Charlie", 40),
                new Person("David", 35)
            };

            Console.WriteLine("Original list of people:");
            PrintPeople(people);

            // Hinzufügen einer Sammlung von Personen
            var newPeople = new List<Person>
            {
                new Person("Emily", 28),
                new Person("Frank", 45)
            };
            people.AddRange(newPeople);
            Console.WriteLine("\nAfter adding new people:");
            PrintPeople(people);

            // Entfernen einer Sammlung von Personen
            var removePeople = new List<Person> { people[0], people[1] };
            people.RemoveRange(removePeople);
            Console.WriteLine("\nAfter removing some people:");
            PrintPeople(people);

            // Kombinieren von zwei ObservableCollectionen
            var additionalPeople = new ObservableCollection<Person>
            {
                new Person("George", 50),
                new Person("Hannah", 35)
            };
            var combinedPeople = people.Combine(additionalPeople);
            Console.WriteLine("\nCombined list of people:");
            PrintPeople(combinedPeople);

            // Filtern und Aktualisieren einer Ansicht basierend auf einer Bedingung
            var filteredView = new ObservableCollection<Person>();
            people.FilterAndUpdateView(p => p.Age > 30, filteredView);
            Console.WriteLine("\nFiltered view of people older than 30:");
            PrintPeople(filteredView);

            // Überprüfen, ob die ObservableCollection leer ist
            Console.WriteLine($"\nIs the original list empty? {people.IsEmpty()}");

            // Ermitteln des Indexes eines Elements in der ObservableCollection
            var index = people.IndexOf(new Person("Charlie", 40));
            Console.WriteLine($"\nIndex of 'Charlie' in the original list: {index}");

            // Einfügen einer Sammlung von Personen an einer bestimmten Position
            var insertPeople = new List<Person>
            {
                new Person("Irene", 27),
                new Person("Jack", 33)
            };
            people.InsertRange(2, insertPeople);
            Console.WriteLine("\nAfter inserting new people at index 2:");
            PrintPeople(people);

            // Umkehren der Reihenfolge der Elemente
            people.Reverse();
            Console.WriteLine("\nAfter reversing the list:");
            PrintPeople(people);

            // Ersetzen eines Elements
            var oldPerson = new Person("Hannah", 35);
            var newPerson = new Person("Kate", 31);
            people.Replace(oldPerson, newPerson);
            Console.WriteLine("\nAfter replacing 'Hannah' with 'Kate':");
            PrintPeople(people);

            // Klonen der ObservableCollection
            var clonedPeople = people.Clone();
            Console.WriteLine("\nCloned list of people:");
            PrintPeople(clonedPeople);

            // Überprüfen, ob alle Elemente eine Bedingung erfüllen
            var allAbove25 = people.All(p => p.Age > 25);
            Console.WriteLine($"\nAre all people above 25? {allAbove25}");

            // Überprüfen, ob mindestens ein Element eine Bedingung erfüllt
            var anyUnder30 = people.Any(p => p.Age < 30);
            Console.WriteLine($"Is there anyone under 30? {anyUnder30}");

            // Entfernen aller Elemente
            people.Clear();
            Console.WriteLine("\nAfter clearing the list:");
            PrintPeople(people);
        }

        static void PrintPeople(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

    // Beispielklasse Person
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}


```

```cs

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MaikHo.Extensions.Collections;

class Program
{
    static void Main()
    {
        // Beispiel Daten
        var collection = new ObservableCollection<int> { 1, 2, 3, 4, 5 };
        var anotherCollection = new ObservableCollection<int> { 6, 7, 8, 9, 10 };

        // Hinzufügen einer Sammlung von Elementen zu einer ObservableCollection
        collection.AddRange(anotherCollection);

        // Entfernen einer Sammlung von Elementen aus einer ObservableCollection
        collection.RemoveRange(new List<int> { 2, 4, 6 });

        // Kombinieren von zwei ObservableCollectionen
        var combinedCollection = collection.Combine(anotherCollection);

        // Filtern einer ObservableCollection und Aktualisieren der Ansicht basierend auf einer Bedingung
        var filteredView = new ObservableCollection<int>();
        collection.FilterAndUpdateView(x => x % 2 == 0, filteredView);

        // Überprüfen, ob eine ObservableCollection leer ist
        var isEmpty = collection.IsEmpty();

        // Ermitteln des Indexes eines Elements in einer ObservableCollection
        var index = collection.IndexOf(5);

        // Einfügen einer Sammlung von Elementen an einer bestimmten Position in einer ObservableCollection
        collection.InsertRange(2, new List<int> { 100, 200, 300 });

        // Umkehren der Reihenfolge der Elemente in einer ObservableCollection
        collection.Reverse();

        // Ersetzen eines Elements in einer ObservableCollection durch ein anderes
        collection.Replace(3, 300);

        // Klonen einer ObservableCollection
        var clonedCollection = collection.Clone();

        // Überprüfen, ob alle Elemente in einer ObservableCollection eine Bedingung erfüllen
        var allEven = collection.All(x => x % 2 == 0);

        // Überprüfen, ob mindestens ein Element in einer ObservableCollection eine Bedingung erfüllt
        var anyGreaterThanTen = collection.Any(x => x > 10);

        // Entfernen aller Elemente aus einer ObservableCollection
        collection.ClearAll();

        // Projektion der Elemente einer ObservableCollection in eine neue Liste
        var newList = collection.SelectToList(x => x * 2);

        // Sortieren der Elemente in einer ObservableCollection
        var sortedCollection = collection.OrderBy(x => x);

        // Einfügen eines Elements an einer bestimmten Position in einer ObservableCollection
        collection.InsertAt(0, 50);

        // Entfernen eines Elements an einer bestimmten Position in einer ObservableCollection
        collection.RemoveAt(1);
    }
}


```

```cs

using System;
using MaikHo.Extensions.FileOperations;

class Program
{
    static void Main()
    {
        // Beispiel Dateipfade
        string textFilePath = "example.txt";
        string binaryFilePath = "example.bin";
        string destTextFilePath = "example_copy.txt";
        string destBinaryFilePath = "example_copy.bin";
        string directoryPath = "example_directory";

        // Text in eine Textdatei schreiben
        textFilePath.WriteTextFile("Hello, world!");

        // Text aus der Textdatei lesen
        string textContent = textFilePath.ReadTextFile();
        Console.WriteLine($"Text content: {textContent}");

        // Binärdaten in eine Binärdatei schreiben
        byte[] binaryData = { 0x48, 0x65, 0x6C, 0x6C, 0x6F };
        binaryFilePath.WriteBinaryFile(binaryData);

        // Binärdaten aus der Binärdatei lesen
        byte[] readBinaryData = binaryFilePath.ReadBinaryFile();
        Console.WriteLine($"Binary content: {BitConverter.ToString(readBinaryData)}");

        // Datei kopieren
        textFilePath.CopyFile(destTextFilePath, overwrite: true);

        // Datei verschieben
        destTextFilePath.MoveFile(destBinaryFilePath);

        // Datei löschen
        destBinaryFilePath.DeleteFile();

        // Verzeichnis erstellen
        directoryPath.CreateDirectory();

        // Überprüfen, ob eine Datei existiert
        bool fileExists = textFilePath.FileExists();
        Console.WriteLine($"File exists: {fileExists}");

        // Rekursives Löschen eines Verzeichnisses
        directoryPath.DeleteDirectory(recursive: true);
    }
}


```

```cs

using System;
using MaikHo.Extensions.ExceptionExtensions;

class Program
{
    static void Main()
    {
        try
        {
            // Hier tritt eine Ausnahme auf
            throw new InvalidOperationException("Invalid operation occurred");
        }
        catch (Exception ex)
        {
            // Schreibe die Ausnahme in eine Log-Datei mit Stacktrace-Informationen
            ex.LogExceptionToFileWithStackTrace();
                
            // Schreibe die Ausnahmeinformationen in eine Log-Datei
            ex.LogExceptionDataToFile();
        }        
    }
}


```

```cs

using System;

namespace ValidationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beispielverwendung der Extension-Methods für Validierung
            string email = "test@example.com";
            string invalidEmail = "invalidemail";
            string password = "Passw0rd!";
            int number = 10;

            // Überprüfen der E-Mail-Adressen
            Console.WriteLine($"Is '{email}' a valid email address? {email.IsValidEmail()}");
            Console.WriteLine($"Is '{invalidEmail}' a valid email address? {invalidEmail.IsValidEmail()}");

            // Überprüfen des Passworts
            Console.WriteLine($"Is '{password}' a valid password? {password.IsValidPassword()}");

            // Überprüfen der Zahlen innerhalb eines bestimmten Bereichs
            Console.WriteLine($"Is '{number}' in range [5, 15]? {number.IsInRange(5, 15)}");
        }
    }

    // Hier können die Extension-Methods für Validierung eingefügt werden
}



```