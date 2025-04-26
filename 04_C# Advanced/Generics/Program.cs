/*
الجينيريكس بتساعدنا نعمل كلاس أو ميثود عامة 
نستخدمها مع أي نوع بيانات، بدل ما نكرر الكود.

قبل ما تكمل، مهم ترجع لدروس الArrayList وGeneric List 
عشان تفهم الصورة كاملة.

مراجعة سريعة:
- في الدوت نت، كل الأنواع أصلها Object.
- يعني أي حاجة (int, string, DateTime) كلها بالأخير Object.
- ArrayList بتسمحلك تحط أي نوع، بس كان فيها مشاكل:
  1. تأثير سلبي على الأداء (Boxing/Unboxing).
  2. ما في Type Safety (ممكن تغلط بالنوع).

الجينيريكس بتحل المشاكل هادي:
- بتحدد نوع العنصر وانت بتعمل الكائن.
- بتحافظ على الأداء.
- بتحميك من الأخطاء بالنوع.
*/

using System.Numerics;

// استخدام الكلاس الجينيريك
public partial class Program
{
    public static void Main()
    {
        System.Console.WriteLine(Add(5, 10)); // 15
        System.Console.WriteLine(Add(5.5, 10.5)); // 16
    }

    // Generic method
    public static T Add<T>(T num1, T num2) where T : INumber<T>
    {
        return num1 + num2;
    }

    /*
    الميثود Add<T> بتاخد متغيرين من نفس النوع T، 
    وبتجمعهم باستخدام dynamic.

    ملاحظة:
    - مش كل الأنواع ينفع نجمعها.
    - لازم النوع يدعم عملية الجمع.
    - لو بدك تتحكم أكتر، بتستخدم Generic Constraints.
    */
}

// استخدام Constraint لتحديد إن النوع لازم يكون class
// Generic Class with Constraints
public class GenericList<T> where T : class
{
    private List<T> items = new List<T>();

    public void Add(T item) => items.Add(item);

    public int Count() => items.Count;
}

/*
في GenericList:
- أجبرنا النوع T إنه يكون Reference Type (Class أو Interface).
- هيك منعنا انه ينحط Struct أو Value Type بالليستة.

ممكن كمان نحط شرط إنه النوع يرث من كلاس معين أو يطبق انترفيس معين.
*/


// ArrayList arrayList = new ArrayList();

// arrayList.Add(true);
// arrayList.Add('D');
// arrayList.Add(2.5);
// arrayList.Add("test");
// arrayList.Add(DateTime.Now);

// var genList = new List<int>();
// genList.Add(1);
// genList.Add(2);

// var genList2 = new List<bool>();
// genList2.Add(true);