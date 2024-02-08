using System;
using System.Collections.Generic;
using System.Linq;

namespace MaikHo.Extensions.Linq
{
    public static class LINQExtensions
    {
        // Beispiel Extension Method: Filtern einer Liste nach einer bestimmten Bedingung
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return source.Where(predicate);
        }

        // Beispiel Extension Method: Summieren aller Elemente in einer Liste
        public static int Sum(this IEnumerable<int> source)
        {
            return source.Sum();
        }

        // Beispiel Extension Method: Ermitteln des Durchschnitts aller Elemente in einer Liste
        public static double Average(this IEnumerable<int> source)
        {
            return source.Average();
        }

        // Beispiel Extension Method: Ermitteln des maximalen Elements in einer Liste
        public static T Max<T>(this IEnumerable<T> source)
        {
            return source.Max();
        }

        // Beispiel Extension Method: Ermitteln des minimalen Elements in einer Liste
        public static T Min<T>(this IEnumerable<T> source)
        {
            return source.Min();
        }

        // Beispiel Extension Method: Konvertieren einer Liste von einem Typ in einen anderen
        public static IEnumerable<TResult> ConvertAll<T, TResult>(this IEnumerable<T> source, Func<T, TResult> selector)
        {
            return source.Select(selector);
        }

        // Beispiel Extension Method: Überprüfen, ob alle Elemente in einer Liste eine Bedingung erfüllen
        public static bool All<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return source.All(predicate);
        }

        // Beispiel Extension Method: Überprüfen, ob mindestens ein Element in einer Liste eine Bedingung erfüllt
        public static bool Any<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return source.Any(predicate);
        }

        // Beispiel Extension Method: Erste Element in einer Liste zurückgeben oder einen Standardwert zurückgeben, falls die Liste leer ist
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            return source.FirstOrDefault();
        }

        // Beispiel Extension Method: Letztes Element in einer Liste zurückgeben oder einen Standardwert zurückgeben, falls die Liste leer ist
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            return source.LastOrDefault();
        }

        // Beispiel Extension Method: Gruppieren von Elementen einer Liste nach einem bestimmten Schlüssel
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.GroupBy(keySelector);
        }

        // Beispiel Extension Method: Ermitteln des Indexes eines Elements in einer Liste
        public static int IndexOf<TSource>(this IEnumerable<TSource> source, TSource item)
        {
            return source.ToList().IndexOf(item);
        }

        // Beispiel Extension Method: Mischen der Elemente in einer Liste
        public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }

        // Beispiel Extension Method: Durchführen einer benutzerdefinierten Aggregatfunktion auf den Elementen einer Liste
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return source.Aggregate(seed, func, resultSelector);
        }

        // Beispiel Extension Method: Zählen der Elemente in einer Liste
        public static int Count<TSource>(this IEnumerable<TSource> source)
        {
            return source.Count();
        }

        // Beispiel Extension Method: Zählen der Elemente in einer Liste, die eine bestimmte Bedingung erfüllen
        public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.Count(predicate);
        }

        // Beispiel Extension Method: Filtern einer Liste und Projektion der Ergebnisse in eine neue Liste
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            return source.SelectMany(selector);
        }

        // Beispiel Extension Method: Zusammenfügen von zwei Listen
        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Concat(second);
        }

        // Beispiel Extension Method: Ausschließen der Duplikate in einer Liste
        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
        {
            return source.Distinct();
        }

        // Beispiel Extension Method: Sortieren der Elemente in einer Liste
        public static IEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.OrderBy(keySelector);
        }

        // Beispiel Extension Method: Aufteilen einer Liste in Teillisten bestimmter Größe
        public static IEnumerable<IEnumerable<TSource>> Chunk<TSource>(this IEnumerable<TSource> source, int chunkSize)
        {
            while (source.Any())
            {
                yield return source.Take(chunkSize);
                source = source.Skip(chunkSize);
            }
        }

        // Beispiel Extension Method: Kombinieren von zwei Listen durch Ausführung einer Funktion auf entsprechenden Elementen
        public static IEnumerable<TResult> Zip<TSource1, TSource2, TResult>(this IEnumerable<TSource1> source1, IEnumerable<TSource2> source2, Func<TSource1, TSource2, TResult> resultSelector)
        {
            return source1.Zip(source2, resultSelector);
        }

        // Beispiel Extension Method: Prüfen, ob alle Elemente in einer Liste identisch sind
        public static bool AllEqual<TSource>(this IEnumerable<TSource> source)
        {
            return source.Distinct().Count() <= 1;
        }

        // Beispiel Extension Method: Ermitteln der häufigsten Elemente in einer Liste
        public static IEnumerable<TSource> MostCommon<TSource>(this IEnumerable<TSource> source)
        {
            return source.GroupBy(x => x)
                         .OrderByDescending(g => g.Count())
                         .Select(g => g.Key);
        }

        // Beispiel Extension Method: Ermitteln der seltensten Elemente in einer Liste
        public static IEnumerable<TSource> LeastCommon<TSource>(this IEnumerable<TSource> source)
        {
            return source.GroupBy(x => x)
                         .OrderBy(g => g.Count())
                         .Select(g => g.Key);
        }

        // Beispiel Extension Method: Ermitteln des durchschnittlichen Werts eines bestimmten Felds in einer Liste von Objekten
        public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            return source.Select(selector).Average();
        }

        // Beispiel Extension Method: Ermitteln des maximalen Werts eines bestimmten Felds in einer Liste von Objekten
        public static TSource MaxBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
            where TKey : IComparable<TKey>
        {
            return source.OrderByDescending(selector).FirstOrDefault();
        }

        // Beispiel Extension Method: Ermitteln des minimalen Werts eines bestimmten Felds in einer Liste von Objekten
        public static TSource MinBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
            where TKey : IComparable<TKey>
        {
            return source.OrderBy(selector).FirstOrDefault();
        }

        // Beispiel Extension Method: Zählen der Vorkommen jedes Elements in einer Liste
        public static IDictionary<TSource, int> CountOccurrences<TSource>(this IEnumerable<TSource> source)
        {
            return source.GroupBy(x => x)
                         .ToDictionary(g => g.Key, g => g.Count());
        }

        // Beispiel Extension Method: Filtern und Projektion der Ergebnisse in eine neue Liste basierend auf einer Bedingung
        public static IEnumerable<TResult> WhereSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
        {
            return source.Where(predicate).Select(selector);
        }

        // Beispiel Extension Method: Entfernen von Duplikaten aus einer Liste unter Berücksichtigung eines bestimmten Schlüssels
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.GroupBy(keySelector).Select(g => g.First());
        }

        // Beispiel Extension Method: Zufällige Auswahl eines Elements aus einer Liste
        public static TSource RandomElement<TSource>(this IEnumerable<TSource> source)
        {
            Random random = new Random();
            int index = random.Next(source.Count());
            return source.ElementAt(index);
        }

        // Beispiel Extension Method: Partitionieren einer Liste in Seiten mit einer bestimmten Größe
        public static IEnumerable<IEnumerable<TSource>> Partition<TSource>(this IEnumerable<TSource> source, int pageSize)
        {
            return source.Select((item, index) => new { item, index })
                         .GroupBy(x => x.index / pageSize)
                         .Select(g => g.Select(x => x.item));
        }

        // Beispiel Extension Method: Überprüfen, ob eine Liste leer oder null ist
        public static bool IsNullOrEmpty<TSource>(this IEnumerable<TSource> source)
        {
            return source == null || !source.Any();
        }

        // Beispiel Extension Method: Aufspalten einer Zeichenfolge in Wörter und Filtern der Leerzeichen
        public static IEnumerable<string> SplitAndTrim(this string source, params char[] separator)
        {
            return source.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim());
        }
    }
}
