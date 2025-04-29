/* 
// Introduction
// Projection & Filtering (Select, Where, OfType)
// Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
* Quantifiers (All, Any, Contains)
* Partitioning (Skip, SkipWhile, Take, TakeWhile, Chunk)
* Set Operations (Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy)
Joins (Join, GroupJoin)
Grouping (GroupBy, ToLookup)
*/

// الكوانتيفايرز عبارة عن methods بتختبر بياناتك:
// هل كل العناصر بتحقق شرط معين؟
// هل أي عنصر بيحقق الشرط؟
// هل الليست بتحتوي عنصر معين؟

// 3 ميثودات مشهورة:
// - All
// - Any
// - Contains

//---------------------------------------------------------

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// بدنا نشوف: هل كل العناصر أكبر من 0؟
var result = numbers.All(x => x > 0); // true

// System.Console.WriteLine(result); // true

// بدنا نشوف: هل في أي عنصر بالليست؟
result = numbers.Any(); // true

// System.Console.WriteLine(result); // true

// بدنا نشوف: هل الليست بتحتوي الرقم 5؟
result = numbers.Contains(5); // true

// System.Console.WriteLine(result); // true

//---------------------------------------------------------

// طيب نجي نحكي عن ال Partitioning 
// اللي هو تقسيم الليست أو التعامل مع أجزاء منها.

// بدنا ناخد أول 4 عناصر:
var query = numbers.Take(4); // 1, 2, 3, 4
// foreach (var number in query) System.Console.WriteLine(number); // 1, 2, 3, 4

// بدنا نطوف أول 4 عناصر ونكمل:
query = numbers.Skip(4); // 5, 6, 7, 8, 9, 10
// foreach (var number in query) System.Console.WriteLine(number); // 5, 6, 7, 8, 9, 10

// طيب خد بعد الطوفان 3 عناصر بس:
query = numbers.Skip(4).Take(3); // 5, 6, 7
// foreach (var number in query) System.Console.WriteLine(number); // 5, 6, 7

// خليك مرن، بدنا ناخد آخر 2 عنصر:
query = numbers.TakeLast(2); // 9, 10
// foreach (var number in query) System.Console.WriteLine(number); // 9, 10

// خد من البداية طول ما الشرط متحقق:
query = numbers.TakeWhile(x => x < 5); // 1, 2, 3, 4
// foreach (var number in query) System.Console.WriteLine(number); // 1, 2, 3, 4

// طوف من البداية طول ما الشرط متحقق:
query = numbers.SkipWhile(x => x < 5); // 5, 6, 7, 8, 9, 10
// foreach (var number in query) System.Console.WriteLine(number); // 5, 6, 7, 8, 9, 10

//---------------------------------------------------------

// Chunk
// اللي هو تقسيم الليست لمجموعات صغيرة بنفس الحجم.

var chunks = numbers.Chunk(3);

// بدنا نطبع كل مجموعة لحالها:
// foreach (var chunk in chunks) System.Console.WriteLine(string.Join(", ", chunk)); // 1, 2, 3 | 4, 5, 6 | 7, 8, 9 | 10

//---------------------------------------------------------

// Set Operations 
// اللي هي التعامل مع المجموعات زي التقاطع والاتحاد.

// نعمل ليست جديدة فيها تكرارات:
var numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// نلغي التكرارات:
var query2 = numbers2.Distinct(); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
// foreach (var number in query2) System.Console.WriteLine(number); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

// نلغي التكرار بناءً على شرط (زي الزوجي والفردي):
query2 = numbers2.DistinctBy(x => x % 2); // 1, 2
// foreach (var number in query2) System.Console.WriteLine(number); // 1, 2

// نلغي عناصر معينة:
query2 = numbers2.Except(new List<int> { 1, 2, 3 }); // 4, 5, 6, 7, 8, 9, 10
// foreach (var number in query2) System.Console.WriteLine(number); // 4, 5, 6, 7, 8, 9, 10

// نجيب العناصر المشتركة-المتقاطعة:
query2 = numbers2.Intersect(new List<int> { 1, 2, 3 }); // 1, 2, 3
// foreach (var number in query2) System.Console.WriteLine(number); // 1, 2, 3

// نعمل اتحاد بين ليستتين:
query2 = numbers.Union(new List<int> { 11, 21, 31 });
foreach (var number in query2)
    System.Console.WriteLine(number); // 1, 2, 3, ..., 10, 11, 21, 31


/*
ملخص سريع:
- Quantifiers: All, Any, Contains.
- Partitioning: Take, Skip, TakeWhile, SkipWhile, Chunk.
- Set Operations: Distinct, DistinctBy, Except, Intersect, Union.
*/
