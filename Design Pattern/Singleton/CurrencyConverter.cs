using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class CurrencyConverter
{
    /* 
    هنا عرفنا متغير خاص لتخزين الريتات بين العملات
    اللي هو IEnumerable<ExchangeRate>، 
    عشان نخزن فيه البيانات بعد ما نحملها لمرة وحدة
    */
    private IEnumerable<ExchangeRate> _exchangeRates;

    /*
    * الكونسركتور هنا Private ✋
    * عشان محدش يقدر يعمل New للكلاس برا
    * والتحميل (LoadExchangeRates) يصير بس من جوه الكلاس
    */
    private CurrencyConverter()
    {
        LoadExchangeRates();
    }

    /*
    * متغير لوك (Object) ستاتيك
    * عشان نستخدمه بقصة الحماية من 
    * المالتي ثريدنج لما نعمل سنجلتون
    */
    private static object _lock = new();

    /*
    * متغير ستاتيك من نوع الكلاس نفسه
    * هذا هو اللي حنخزن فيه النسخة الوحيدة 
    * (Singleton Instance)
    */
    private static CurrencyConverter _instance;

    /*
    * هذا البروبرتي اسمه Instance
    * مسؤول إنه يرجعلك النسخة الوحيدة من الكلاس
    * ولو مش موجودة، بعملها 
    * Create مع Lock عشان نتجنب مشاكل المالتي ثريدنج
    */
    public static CurrencyConverter Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new CurrencyConverter();
                }
            }
            return _instance;
        }
    }

    /*
    * هذا الميثود مسؤول عن تحميل بيانات تحويل العملات
    * بس مرة وحدة لما الكلاس ينشأ
    * وفيه Sleep 3 ثواني عشان يحاكي عملية تحميل ثقيلة 
    * (زي قراءة من داتابيز أو ويب سيرفيس)
    */
    private void LoadExchangeRates()
    {
        Thread.Sleep(3000); // بنعمل تأخير 3 ثواني كأننا بنجيب بيانات تقيلة
        _exchangeRates = new[]
        {
            new ExchangeRate("USD", "SAR", 3.75m),
            new ExchangeRate("USD", "EGP", 30.60m),
            new ExchangeRate("SAR", "EGP", 8.16m)
        };
    }

    /*
    * هذا الميثود Convert بيحول مبلغ معين من عملة لعملة تانية
    * بدور أول اشي على الريت المناسب من اللي مخزنينهم
    * إذا لقاه، بيرجع قيمة المبلغ بعد التحويل
    * لو ما لقاش الريت المناسب، برمي Exception
    */
    public decimal Convert(string baseCurrency, string targetCurrency, decimal amount)
    {
        var exchangeRate = _exchangeRates.FirstOrDefault(x =>
            x.BaseCurrency == baseCurrency
            && x.TargetCurrency == targetCurrency);

        if (exchangeRate == null)
        {
            throw new Exception("Exchange rate not found.");
        }

        return amount * exchangeRate.Rate;
    }
}
