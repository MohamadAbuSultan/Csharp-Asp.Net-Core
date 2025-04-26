public class ExchangeRate
{
    public string BaseCurrency { get; }
    public string TargetCurrency { get; }
    public decimal Rate { get; }

    public ExchangeRate(string baseCurrency, string targetCurrency, decimal rate)
    {
        BaseCurrency = baseCurrency;
        TargetCurrency = targetCurrency;
        Rate = rate;
    }
}