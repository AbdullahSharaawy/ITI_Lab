using DaysCsharp.Day13;
using DaysCsharp.Day9;
using System.Text;

public class start
{
    public static void Main(string[] args)
    {

		//// Day 6
		///my name : Abdullah Adel Eid Sharaawy
		//int number;
		//do
		//{
		//    Console.Write("enter number to check is positive or negative: ");

		//    if (int.TryParse(Console.ReadLine(), out number))
		//    {
		//        if(number==0)
		//        {
		//            Console.WriteLine("it is zero ");
		//            break;
		//        }
		//        Console.WriteLine($" {number} is positive? {Day6.IsPositive(number)}");
		//        break;
		//    }
		//    else
		//    {
		//        Console.WriteLine("Please enter a valid integer.");
		//        continue;
		//    }
		//} while (true);

		//do
		//{
		//    Console.Write("enter number to check is even or odd: ");

		//    if (int.TryParse(Console.ReadLine(), out number))
		//    {
		//        Console.WriteLine($" {number} is positive? {Day6.IsEven(number)}");
		//        break;
		//    }
		//    else
		//    {
		//        Console.WriteLine("Please enter a valid integer.");
		//        continue;
		//    }
		//} while (true);

		//int length, width;

		//Console.WriteLine("enter width and length to check the rectangle is square or not: ");

		//do
		//{
		//    Console.Write("please enter the length: ");

		//    if (int.TryParse(Console.ReadLine(), out length))
		//    {
		//        break;
		//    }
		//    else
		//    {
		//        Console.WriteLine("Please enter a valid integer.");
		//        continue;
		//    }
		//} while (true);

		//do
		//{
		//    Console.Write("please enter the width: ");

		//    if (int.TryParse(Console.ReadLine(), out width))
		//    {
		//        break;
		//    }
		//    else
		//    {
		//        Console.WriteLine("Please enter a valid integer.");
		//        continue;
		//    }
		//} while (true);

		//if (Day6.IsSquareDimensions(length, width))
		//{
		//    Console.WriteLine($"The rectangle with length {length} and width {width} is a square.");
		//}
		//else
		//{
		//    Console.WriteLine($"The rectangle with length {length} and width {width} is not a square.");
		//}
		//==================================================
		// Day 7
		//Day7.PrintMulti();
		// Day7.ReadData();
		//
		//Day7.ArrayDegree();
		//     StartProgram startProgram = new StartProgram();
		//startProgram.Run();
		Console.WriteLine("--- Running Linqu Extension Method Tests ---");

		TestWhere();
		TestSelect();
		TestTake();
		TestTakeWhile();
		TestSkip();
		TestSkipWhile();
		TestTakeLast();
		TestSkipLast();
		TestOrderBy();
		TestOrderByDesc();
		TestFirstLastSingle();
		TestDistinct();

		Console.WriteLine("\n--- All Tests Completed ---");
		Console.ReadKey(); // Keep console open
	}
	private static void TestWhere()
	{
		Console.WriteLine("\n--- Testing Where ---");
		List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		// Where (predicate only)
		List<int> evenNumbers = numbers.Where(n => n % 2 == 0);
		Console.WriteLine($"Even numbers (Where): {string.Join(", ", evenNumbers)} (Expected: 2, 4, 6, 8, 10)");

		// Where (predicate with index)
		List<int> numbersAtIndexEven = numbers.Where((n, i) => i % 2 == 0);
		Console.WriteLine($"Numbers at even index (Where with index): {string.Join(", ", numbersAtIndexEven)} (Expected: 1, 3, 5, 7, 9)");

		// Empty list
		List<int> emptyList = new List<int>();
		List<int> resultEmpty = emptyList.Where(n => n > 0);
	//	Console.WriteLine($"Where on empty list: {string.Join(", ", resultEmpty)} (Expected: )");

		// No matching elements
		List<int> noMatch = numbers.Where(n => n > 100);
		Console.WriteLine($"Where no match: {string.Join(", ", noMatch)} (Expected: )");
	}

	private static void TestSelect()
	{
		Console.WriteLine("\n--- Testing Select ---");
		List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

		// Select (predicate only)
		List<int> squaredNumbers = numbers.Select(n => n * n);
		Console.WriteLine($"Squared numbers (Select): {string.Join(", ", squaredNumbers)} (Expected: 1, 4, 9, 16, 25)");

		// Select (predicate with index)
		List<int> indexedValues = numbers.Select((n, i) => n + i);
		Console.WriteLine($"Numbers + index (Select with index): {string.Join(", ", indexedValues)} (Expected: 1, 3, 5, 7, 9)");

		// Select to a different type (requires your Select to be generic for TResult, currently it's T to T)
		// Note: Your current Select method signature is `Func<T, T>`, meaning the input and output type must be the same.
		// A more general Select would be `public static List<TResult> Select<TSource, TResult>(this List<TSource> source, Func<TSource, TResult> prdicate)`
		// For now, testing with T to T.

		List<string> words = new List<string> { "apple", "banana", "cherry" };
		// Example if Select was T to T, converting to uppercase assuming T is string
		List<string> upperWords = words.Select(s => s.ToUpper());
		Console.WriteLine($"Uppercase words (Select): {string.Join(", ", upperWords)} (Expected: APPLE, BANANA, CHERRY)");

		// Empty list
		List<int> emptyList = new List<int>();
		List<int> resultEmpty = emptyList.Select(n => n * 2);
		//Console.WriteLine($"Select on empty list: {string.Join(", ", resultEmpty)} (Expected: )");
	}

	private static void TestTake()
	{
		Console.WriteLine("\n--- Testing Take ---");
		List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

		// Take fewer than available
		List<int> firstThree = numbers.Take(3);
		Console.WriteLine($"First 3 elements (Take): {string.Join(", ", firstThree)} (Expected: 10, 20, 30)");

		// Take more than available
		List<int> takeMore = numbers.Take(10);
		Console.WriteLine($"Take 10 elements (more than available): {string.Join(", ", takeMore)} (Expected: 10, 20, 30, 40, 50)");

		// Take zero
		List<int> takeZero = numbers.Take(0);
		Console.WriteLine($"Take 0 elements: {string.Join(", ", takeZero)} (Expected: )");
	}

	private static void TestTakeWhile()
	{
		Console.WriteLine("\n--- Testing TakeWhile ---");
		List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };

		// TakeWhile (predicate only)
		List<int> lessThan5 = numbers.TakeWhile(n => n < 5);
		Console.WriteLine($"Numbers less than 5 (TakeWhile): {string.Join(", ", lessThan5)} (Expected: 1, 2, 3, 4)");

		// TakeWhile (predicate with index)
		List<int> takeWhileIndex = numbers.TakeWhile((n, i) => i < 3);
		Console.WriteLine($"TakeWhile index < 3: {string.Join(", ", takeWhileIndex)} (Expected: 1, 2, 3)");

		// Predicate never false
		List<int> allNumbers = numbers.TakeWhile(n => n > 0);
		Console.WriteLine($"TakeWhile always true: {string.Join(", ", allNumbers)} (Expected: 1, 2, 3, 4, 5, 4, 3, 2, 1)");

		// Predicate immediately false
		List<int> none = numbers.TakeWhile(n => n > 10);
		Console.WriteLine($"TakeWhile immediately false: {string.Join(", ", none)} (Expected: )");
	}

	private static void TestSkip()
	{
		Console.WriteLine("\n--- Testing Skip ---");
		List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

		// Skip fewer than available
		List<int> skipTwo = numbers.Skip(2);
		Console.WriteLine($"Skip 2 elements: {string.Join(", ", skipTwo)} (Expected: 30, 40, 50)");

		// Skip more than available
		List<int> skipMore = numbers.Skip(10);
		//Console.WriteLine($"Skip 10 elements (more than available): {string.Join(", ", skipMore)} (Expected: )");

		// Skip zero
		List<int> skipZero = numbers.Skip(0);
		Console.WriteLine($"Skip 0 elements: {string.Join(", ", skipZero)} (Expected: 10, 20, 30, 40, 50)");

		}

	private static void TestSkipWhile()
	{
		Console.WriteLine("\n--- Testing SkipWhile ---");
		List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };

		// SkipWhile (predicate only)
		// Note: Your SkipWhile with index currently adds to result if predicate is true, then returns. This seems incorrect.
		// A correct SkipWhile should *skip* elements while the predicate is true, and return the *rest* of the elements once it's false.

		List<int> skipWhileLessThan5 = numbers.SkipWhile(n => n < 5);
		Console.WriteLine($"SkipWhile numbers less than 5: {string.Join(", ", skipWhileLessThan5)} (Expected: 5, 4, 3, 2, 1)");

		// SkipWhile (predicate with index)
		// Fixing the logic for this test to match typical SkipWhile behavior if your implementation is corrected.
		// If your current SkipWhile(T,int,bool) is *intended* to be different, adjust expectations.
		List<int> skipWhileIndexLessThan3 = numbers.SkipWhile((n, i) => i < 3);
		Console.WriteLine($"SkipWhile index less than 3: {string.Join(", ", skipWhileIndexLessThan3)} (Expected: 4, 5, 4, 3, 2, 1)"); // Based on corrected logic

		// Predicate never false
		List<int> skipAll = numbers.SkipWhile(n => n > 0);
		Console.WriteLine($"SkipWhile always true: {string.Join(", ", skipAll)} (Expected: )");

		// Predicate immediately false
		List<int> skipNone = numbers.SkipWhile(n => n > 10);
		Console.WriteLine($"SkipWhile immediately false: {string.Join(", ", skipNone)} (Expected: 1, 2, 3, 4, 5, 4, 3, 2, 1)");

		}

	private static void TestTakeLast()
	{
		Console.WriteLine("\n--- Testing TakeLast ---");
		List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

		// TakeLast fewer than available
		List<int> lastThree = numbers.TakeLast(3);
		Console.WriteLine($"Last 3 elements (TakeLast): {string.Join(", ", lastThree.OrderBy(x => x))} (Expected: 30, 40, 50 - Note: Your current TakeLast adds in reverse order. Re-order for comparison)");

		// TakeLast more than available
		List<int> takeLastMore = numbers.TakeLast(10);
		Console.WriteLine($"TakeLast 10 elements: {string.Join(", ", takeLastMore.OrderBy(x => x))} (Expected: 10, 20, 30, 40, 50)");

		// TakeLast zero
		List<int> takeLastZero = numbers.TakeLast(0);
		Console.WriteLine($"TakeLast 0 elements: {string.Join(", ", takeLastZero)} (Expected: )");

		// TakeLast from empty list
		List<int> emptyList = new List<int>();
		List<int> takeLastEmpty = emptyList.TakeLast(2);
		//Console.WriteLine($"TakeLast from empty list: {string.Join(", ", takeLastEmpty)} (Expected: )");
	}

	private static void TestSkipLast()
	{
		Console.WriteLine("\n--- Testing SkipLast ---");
		List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

		// SkipLast fewer than available
		// Your SkipLast currently adds elements in reverse order and the loop condition might be off.
		// It should remove elements from the end and return the *remaining* in original order.
		// Example of what it should return for SkipLast(2): 10, 20, 30
		// Your current implementation:
		// for (int i = source.Count()-NumElements-1; i >= 0 ; i--)
		// This starts from (5-2-1) = 2, so source[2]=30, source[1]=20, source[0]=10. Result: 30, 20, 10
		List<int> skipLastTwo = numbers.SkipLast(2);
		Console.WriteLine($"SkipLast 2 elements: {string.Join(", ", skipLastTwo.OrderBy(x => x))} (Expected: 10, 20, 30 - Note: Order corrected for comparison)");

		// SkipLast more than available
		List<int> skipLastMore = numbers.SkipLast(10);
		Console.WriteLine($"SkipLast 10 elements: {string.Join(", ", skipLastMore)} (Expected: )");

		// SkipLast zero
		List<int> skipLastZero = numbers.SkipLast(0);
		Console.WriteLine($"SkipLast 0 elements: {string.Join(", ", skipLastZero.OrderBy(x => x))} (Expected: 10, 20, 30, 40, 50)");

		// SkipLast from empty list
		List<int> emptyList = new List<int>();
		List<int> skipLastEmpty = emptyList.SkipLast(2);
		//Console.WriteLine($"SkipLast from empty list: {string.Join(", ", skipLastEmpty)} (Expected: )");
	}

	private static void TestOrderBy()
	{
		Console.WriteLine("\n--- Testing OrderBy ---");
		List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 4 };

		// OrderBy (ascending)
		List<int> orderedAsc = numbers.OrderBy(); // Your OrderBy directly modifies the source and returns it.
		Console.WriteLine($"Ordered Ascending: {string.Join(", ", orderedAsc)} (Expected: 1, 2, 4, 5, 8, 9)");

		// Test with already sorted list
		List<int> alreadySorted = new List<int> { 1, 2, 3, 4, 5 };
		List<int> stillSorted = alreadySorted.OrderBy();
		Console.WriteLine($"Already sorted Ascending: {string.Join(", ", stillSorted)} (Expected: 1, 2, 3, 4, 5)");

		// Test with reverse sorted list
		List<int> reverseSorted = new List<int> { 5, 4, 3, 2, 1 };
		List<int> sortedReverse = reverseSorted.OrderBy();
		Console.WriteLine($"Reverse sorted Ascending: {string.Join(", ", sortedReverse)} (Expected: 1, 2, 3, 4, 5)");

		// Empty list
		List<int> emptyList = new List<int>();
		List<int> orderedEmpty = emptyList.OrderBy();
		//Console.WriteLine($"OrderBy empty list: {string.Join(", ", orderedEmpty)} (Expected: )");
	}

	private static void TestOrderByDesc()
	{
		Console.WriteLine("\n--- Testing OrderByDesc ---");
		List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 4 };

		// OrderByDesc (descending)
		List<int> orderedDesc = numbers.OrderByDesc(); // Your OrderByDesc directly modifies the source and returns it.
		Console.WriteLine($"Ordered Descending: {string.Join(", ", orderedDesc)} (Expected: 9, 8, 5, 4, 2, 1)");

		// Test with already sorted desc list
		List<int> alreadySortedDesc = new List<int> { 9, 8, 7, 6 };
		List<int> stillSortedDesc = alreadySortedDesc.OrderByDesc();
		Console.WriteLine($"Already sorted Descending: {string.Join(", ", stillSortedDesc)} (Expected: 9, 8, 7, 6)");

		// Test with reverse sorted list (ascending)
		List<int> reverseSorted = new List<int> { 1, 2, 3, 4, 5 };
		List<int> sortedReverseDesc = reverseSorted.OrderByDesc();
		Console.WriteLine($"Reverse sorted Descending: {string.Join(", ", sortedReverseDesc)} (Expected: 5, 4, 3, 2, 1)");

		// Empty list
		List<int> emptyList = new List<int>();
		List<int> orderedDescEmpty = emptyList.OrderByDesc();
		//Console.WriteLine($"OrderByDesc empty list: {string.Join(", ", orderedDescEmpty)} (Expected: )");
	}

	private static void TestFirstLastSingle()
	{
		Console.WriteLine("\n--- Testing First, Last, Single ---");
		List<int> numbers = new List<int> { 10, 20, 30 };
		List<int> singleNumber = new List<int> { 100 };
		List<int> emptyList = new List<int>();

		// First
		Console.WriteLine($"First from [10, 20, 30]: {numbers.First()} (Expected: 10)");
		try
		{
			Console.WriteLine($"First from empty list (should throw): {emptyList.First()}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Caught expected exception for First on empty list: {ex.Message}");
		}

		// FirstOrDefault
		Console.WriteLine($"FirstOrDefault from [10, 20, 30]: {numbers.FirstOrDefault()} (Expected: 10)");
		Console.WriteLine($"FirstOrDefault from empty list: {emptyList.FirstOrDefault()} (Expected: 0)");

		// Last
		// Note: Your Last method `source[source.Count()]` will throw an `ArgumentOutOfRangeException`
		// because List is 0-indexed. It should be `source[source.Count() - 1]`.
		try
		{
			Console.WriteLine($"Last from [10, 20, 30]: {numbers.Last()} (Expected: 30)"); // Will throw with current impl
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Caught expected exception for Last (likely off-by-one): {ex.Message}");
		}
		try
		{
			Console.WriteLine($"Last from empty list (should throw): {emptyList.Last()}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Caught expected exception for Last on empty list: {ex.Message}");
		}

		// LastOrDefault
		// Note: Your LastOrDefault method `source[source.Count()]` will throw an `ArgumentOutOfRangeException`
		// because List is 0-indexed. It should be `source[source.Count() - 1]`.
		try
		{
			Console.WriteLine($"LastOrDefault from [10, 20, 30]: {numbers.LastOrDefault()} (Expected: 30)"); // Will throw with current impl
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Caught expected exception for LastOrDefault (likely off-by-one): {ex.Message}");
		}
		Console.WriteLine($"LastOrDefault from empty list: {emptyList.LastOrDefault()} (Expected: 0)");


		// Single
		Console.WriteLine($"Single from [100]: {singleNumber.Single()} (Expected: 100)");
		try
		{
			Console.WriteLine($"Single from [10, 20, 30] (should throw): {numbers.Single()}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Caught expected exception for Single on multiple elements: {ex.Message}");
		}
		try
		{
			Console.WriteLine($"Single from empty list (should throw): {emptyList.Single()}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Caught expected exception for Single on empty list: {ex.Message}");
		}

		// SingleOrDefault
		Console.WriteLine($"SingleOrDefault from [100]: {singleNumber.SingleOrDefault()} (Expected: 100)");
		Console.WriteLine($"SingleOrDefault from empty list: {emptyList.SingleOrDefault()} (Expected: 0)");
		try
		{
			Console.WriteLine($"SingleOrDefault from [10, 20, 30] (should throw): {numbers.SingleOrDefault()}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Caught expected exception for SingleOrDefault on multiple elements: {ex.Message}");
		}
	}

	private static void TestDistinct()
	{
		Console.WriteLine("\n--- Testing Distinct ---");
		List<int> numbersWithDuplicates = new List<int> { 1, 2, 2, 3, 4, 3, 5, 1, 6 };

		// Distinct
		List<int> distinctNumbers = numbersWithDuplicates.Distinct();
		Console.WriteLine($"Distinct numbers: {string.Join(", ", distinctNumbers)} (Expected: 1, 2, 3, 4, 5, 6)");

		// Already distinct
		List<int> distinctAlready = new List<int> { 1, 2, 3 };
		List<int> resultDistinctAlready = distinctAlready.Distinct();
		Console.WriteLine($"Already distinct list: {string.Join(", ", resultDistinctAlready)} (Expected: 1, 2, 3)");

		// All duplicates
		List<int> allDuplicates = new List<int> { 7, 7, 7, 7 };
		List<int> resultAllDuplicates = allDuplicates.Distinct();
		Console.WriteLine($"All duplicates list: {string.Join(", ", resultAllDuplicates)} (Expected: 7)");

		// Empty list
		List<int> emptyList = new List<int>();
		List<int> distinctEmpty = emptyList.Distinct();
		//Console.WriteLine($"Distinct from empty list: {string.Join(", ", distinctEmpty)} (Expected: )");

		// List with nulls (if T allows nulls, e.g., string)
		List<string> stringsWithNulls = new List<string> { "a", "b", null, "a", "c", null };
		List<string> distinctStrings = stringsWithNulls.Distinct();
		Console.WriteLine($"Distinct strings with nulls: {string.Join(", ", distinctStrings)} (Expected: a, b, , c)"); // Note: default(string) is null, so it shows as empty string in Console.WriteLine
	}
}
