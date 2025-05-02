// الـ record هو نوع خاص في C#
// بيسهّل عليك كتابة كود نظيف ومرتب
// وبيعطيك مزايا زي مقارنة القيم تلقائياً، طباعة جميلة، و immutability

var point = new PointRecord(1, 2);
var point2 = new PointRecord(1, 2);
System.Console.WriteLine(point);
System.Console.WriteLine(point2);
// ToString() بتكون جاهزة ومرتبة في الـ record
// بتطبع القيم الداخلية بشكل تلقائي من غير ما تكتب ميثود لحالك


// مقارنة القيم (value equality)
// بيقارن القيم جوه الـ object مش المرجع نفسه
System.Console.WriteLine(point == point2);

// System.Console.WriteLine(point.Equals(point2));
// System.Console.WriteLine(point.GetHashCode() == point2.GetHashCode());
// System.Console.WriteLine(point.GetHashCode());
// System.Console.WriteLine(point2.GetHashCode());

// تفكيك الـ record (deconstruction)
// بتقدر تفك الـ record لعناصره زي هيك:
var (parmeterX, parameterY) = point;
System.Console.WriteLine($"X: {parmeterX}, Y: {parameterY}");


// Immutability (الثبات)
// الـ record بيخلي الـ object ثابت (immutable)
// يعني ما بتقدر تغير خصائصه بعد الإنشاء (init-only)
// point3 نسخة من point لكن عدلنا قيمة X فقط
// باقي القيم بضلوا زي ما هما، وما تأثر الأصلي
var point3 = point with { X = 596 };
System.Console.WriteLine(point3);

var s = new Student("John", "Doe", new Address("New York", "5th Avenue"));
System.Console.WriteLine(s);

// مشكلة الـ shallow immutability
// القيمة الداخلية (City) تم تعديلها رغم أن record immutable
// السبب إن Address معمول كـ class مش record
// لو بدك تمنع التعديل تمامًا، لازم تحول Address لـ record مش class
s.Address.City = "Los Angeles";
System.Console.WriteLine(s);

public record class PointRecord(int X, int Y);

// public record class PointRecord
// {
//     public int X { get; init; }
//     public int Y { get; init; }

//     public PointRecord(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }
// }


public record Student(string FirstName, string LastName, Address Address);

// Address معمول كـ class عشان نوضح مشكلة shallow immutability
// لو كان record، بيصير فعلاً immutable بالكامل
// Primary constructor
public class Address(string City, string streetName)
{
    public string City { get; set; } = City;
    public string StreetName { get; set; } = streetName;
    public override string ToString() => $"{City}, {StreetName}";
}