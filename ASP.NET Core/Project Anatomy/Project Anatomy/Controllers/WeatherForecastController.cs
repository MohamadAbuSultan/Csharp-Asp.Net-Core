using Microsoft.AspNetCore.Mvc;

namespace Project_Anatomy.Controllers;

/*
الكلاس لازم ينتهي اسمه بكلمة Controller، زي WeatherForecastController.

الكلاس لازم يعمل Inherit من ControllerBase لما تشتغل APIs.

ControllerBase: لخدمة الـ APIs بدون Views.

Controller: لو حابب كمان تتعامل مع Views زي لما تشتغل MVC.

ApiController و Route هما تقريبا بيكونوا ثابتين فوق أي API Controller بتكتبه.

[ApiController] كمان بيفعللك حاجات حلوة زي التحقق التلقائي من الـ ModelState.
*/


// بحدد إن الكلاس هذا API Controller للتعامل مع الريكويستات.
[ApiController]
/*
هنا يا معلم، لما تحط [ApiController] فوق الكلاس،
فإنت كأنك بتحطله "ختم" أو "علامة" إنه هذا كنترولر خاص بالـ APIs.
يعني الدوت نت لما يشغل التطبيق، بيلف على كل الكلاسات،
وبيدور على الكلاسات اللي معلمة بهاي العلامة علشان يجهزها للـ Endpoints.

الاتربيوت (Attribute) هاي بتسهل عالدوت نت يفهم إنه هذا مش أي كلاس،
لا، هذا كلاس معمول يخدم API، ويطلع منه لينكات وطرق استدعاء (Routes).
تمام؟ عاملة زي التاجات (tags) اللي بتحطها عالبوست عشان توصل للبوست بسهولة.
نفس الفكرة بالظبط.
*/

// بحدد عنوان الوصول للكلاس بناءً على اسمه بدون كلمة Controller.
[Route("[controller]")]
/*
وهاي [Route("[controller]")] بتحدد عنوان الرابط (URL) اللي الناس هتوصل منه للكلاس.
لما تكتب [controller] بين سكوير براكتس،
الدوت نت أوتوماتيك بياخد اسم الكلاس ويستعمله كجزء من الرابط.

مثلاً لو الكلاس اسمه WeatherForecastController،
الرابط هيكون "/WeatherForecast"، بدون كلمة Controller في آخره.

ولو بدك تغير اسم الرابط، عادي تشيل [controller]،
وتكتب اسم ثابت زي [Route("weather")]، هيصير الرابط "/weather" بدل ما هو اسم الكلاس.
*/

public class WeatherForecastController : ControllerBase
{
    /*
    هنا عاملين كلاس اسمه WeatherForecastController.
    ضروري الكلاس ينتهي بكلمة "Controller"، 
    وعاملينله Inherit من ControllerBase،
    علشان يكون مخصص للتعامل مع APIs بدون Views.
    لو كنت تشتغل MVC وبدك تعرض صفحات ويب، لازم ترث من Controller مش ControllerBase.
    بس احنا هان شغالين API بس.
    */

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger) // DI
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]

    /*
    الميثود Get مربوطة باتربيوت [HttpGet]،
    يعني لازم الريكويست اللي يوصلها يكون من نوع GET.

    المهم نعرف إنه [HttpGet] عبارة عن ميدالية (Attribute)،
    زي علامة بنعلم فيها الميثود إنو لما ييجي ريكويست من نوع GET،
    هاي الميثود لازم تشتغل.

    Name = "GetWeatherForecast" مش ضروري حالياً،
    بس بيكون مفيد لو بدنا نستخدمه لما نولد لينكات أو نوثق API.
    */
    public IEnumerable<WeatherForecast> Get()
    /*
    الميثود Get هاي مربوطة بصفة HttpGet،
    يعني علشان نوصللها لازم نبعت ريكويست من نوع GET.
    الاسم "GetWeatherForecast" مش ضروري تحطه، بس لو بدك تسميه خاص لتسهيل الربط أو التوثيق.
    الميثود نفسها بترجع مجموعة بيانات من نوع WeatherForecast.
    */
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    /*
     لما تبعت GET request على /WeatherForecast، الميثود هاي هي اللي بتتنفذ.
     لو ما كتبتش راوت خاص للميثود، فهي بتكون Default GET للكنترولر.
     لو بدك تخصص لينك مختلف، بتغير الراوت فوق الميثود.
     */
    /*
    الميثود بترجع IEnumerable من WeatherForecast،
    يعني بترجع مجموعة، زي لستة أو كولكشن.

    كل الدوت نت تقريبا مبنية حوالين IEnumerable،
    سواء List، Array، Collection، كله بيورث منو.
    */
}

/*
 الكلاس: لازم اسمه ينتهي بـ Controller، ويرث من ControllerBase لو API.
 [HttpGet]: بتربط الميثود بـ GET request.
*/


/*
 لما تبعت Request للكنترولر مباشرة باستخدام GET، بدون تحديد ميثود معينة،
الدوت نت أوتوماتيك بيروح ينفذ الميثود اللي فوقها [HttpGet]، اللي هي Get().

لو حطيت Route مخصص فوق الميثود زي [HttpGet("GetData")]،
لازم باللينك تحدد اسم الأكشن عشان توصلها.

يعني باختصار:
بدون راوت => بتمسك الديفولت ميثود اللي عليها [HttpGet].
مع راوت => لازم تكتب الراوت اللي حددته عشان توصله.

فكرة الإسم اللي في [HttpGet(Name = "GetWeatherForecast")] مش مهمة كتير دلوقتي،
بنحتاجها لاحقًا لما نستعمل تولز زي الـ LinkGenerator أو نعمل توثيق متقدم.
 */