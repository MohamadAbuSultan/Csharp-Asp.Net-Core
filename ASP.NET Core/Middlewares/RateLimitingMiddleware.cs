public class RateLimitingMiddleware
{
    private static int _counter = 0;

    private static DateTime _lastRequestTime = DateTime.Now;

    private readonly RequestDelegate _next;

    public RateLimitingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        _counter++;
        if (DateTime.Now.Subtract(_lastRequestTime).Seconds > 10)
        {
            _counter = 1;
            _lastRequestTime = DateTime.Now;
            await _next(context);
        }
        else if (_counter > 5)
        {
            _lastRequestTime = DateTime.Now;
            await context.Response.WriteAsync("Rate Limit Exceeded.");
        }
        else
        {
            _lastRequestTime = DateTime.Now;
            await _next(context);
        }
    }
}

// هيك بتحمي API تبعتك من الضغط أو
// الهجمات اللي بتحاول تغرقها requests.