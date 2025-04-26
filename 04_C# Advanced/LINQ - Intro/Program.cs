/* 
// Introduction
* Projection & Filtering (Select, Where, OfType)
Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
Quantifiers (All, Any, Contains)
Partitioning (Skip, SkipWhile, Take, TakeWhile, Chunk)
Set Operations (Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy)
Joins (Join, GroupJoin)
Grouping (GroupBy, ToLookup)
*/

/* قبل ما تفهم اللينك كويس، ضروري تكون فاهم حاجات زي:
* - Extension Methods
* - Lambda Expressions
* - Anonymous Functions
* - Delegates
* لأنه اللينك مبني عليهم بشكل كبير، ولو مش فاهمهم كويس رجع راجع دروسهم بالأول.
*/

// ايش يعني LINQ؟
/*
* LINQ اختصار لـ Language Integrated Query
* بالعربي: استعلام مدمج مع اللغة.

* لما كنا نتعامل مع قواعد بيانات زي 
* SQL Server أو MySQL أو أي نوع تاني،
* كان في حاجة اسمها لغة استعلامات (SQL)، 
* نكتب فيها أوامر علشان نجيب بيانات معينة.

مثلاً:
* هاتلي الطلاب اللي ناجحين
* ، هاتلي الموظفين اللي راتبهم فوق 3000 وهكذا.
*/

/*
* طيب! اللينك جابت نفس فكرة الاستعلامات بس داخل الكود نفسه.
* يعني بدل ما تتعامل مع داتابيز، بتتعامل مع ليستات أو آرايز 
* أو كولكشنز جوة الكود كأنهم داتا حقيقية، وتستعلم عنهم بسهولة.
*/

// الأمثلة:
/*
* لو عندك List أرقام وبدك تجيب كل الأرقام الأكبر من 5
* لو بدك ترتبهم
* لو بدك تجيب أعلى 5 أرقام
* لو بدك تحذف التكرار

* كل هذا تقدر تعمله باستخدام LINQ بكل سهولة.
*/

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//* Query Expression Syntax
//* هان بنكتب LINQ زي لما تكتب SQL بالزبط لكن بال C#
//* يعني بنستخدم كلمات محجوزة زي from, where, select
var result = from number in numbers
             where number > 5
             select number; //* Linq expression

//* Method Syntax
//* هان بنكتبها بطريقة methods عادية
result = numbers.Where(number => number % 2 == 0); //* Linq method syntax

//* Deferred Execution
/*
*- result مش شايل نتيجة الاستعلام، هو شايل الاستعلام نفسه (الأوامر).
*- يعني مش بنفذ الاستعلام مباشرة، بننفذه لما نطلب البيانات.
*/

foreach (var number in result) Console.WriteLine(number);

System.Console.WriteLine("-----------------");

numbers.AddRange(new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });

foreach (var number in result) Console.WriteLine(number);

// ملاحظة مهمة جدا:
/*
* بما إنه تنفيذ اللينك مؤجل (Deferred Execution)
* فأي تغيير في ال source data (numbers list)
* رح يأثر مباشرة على النتيجة عند التنفيذ.

* يعني لما ضفنا أرقام جديدة
* ، لما عملنا فور لوب تاني، النتيجة تغيرت.

* لو بدك تثبت النتيجة الحالية وما تتغير مع التعديلات الجاية،
* تقدر تستعمل ToList()، زي كالتالي:
*/

//* var fixedResult = result.ToList();
//* هيك بتحفظ snapshot للنتيجة وقت التنفيذ ومابتتغير لو اللست الأصلية تغيرت.


// مثال 2 توضيحي:

/*
- Query Expression Syntax:
    from item in collection
    where condition
    select item;

- Method Syntax:
    collection.Where(condition).Select(item)

* الاتنين صح وبيوصلوا لنفس الهدف.
* بس الميثود سينتاكس مرات
* أسهل في التعامل خاصة لو بدأت تتعود عليها.
*/

/* لينك بتخليك تعمل كمان:
- Filtering (فلترة)
- Sorting (ترتيب)
- Projection (تحويل شكل الداتا)
- Grouping (تجميع)
- Joining (ربط أكثر من مجموعة)
- Aggregation (زي العد والجمع وأخذ المتوسط)
وكل هذا بكود صغير وواضح وسهل القراءة.
*/

// ملاحظة أخيرة مهمة:
// 
//* الصيغة اللي كتبنا فيها (Query Syntax) مجرد شكل شكلي أجمل ومفهوم أكثر.
//* لكن وقت الكومبيلر، اللينك كلها بتتحول لـ method syntax يعني بنفس شكل Method Calls
//* بمعنى إنه في الآخر الكل بتنفذ بنفس الطريقة.

//* فإنت حر تختار اللي ترتاحله: Query Style أو Method Style