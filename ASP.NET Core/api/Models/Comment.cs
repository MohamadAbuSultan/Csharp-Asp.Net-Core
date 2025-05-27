using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; }
        // Navigation property تسمح لنا بالتنقل داخل العلاقات بين النماذج 
        // Entity Framework Core سيتعرف تلقائياً على العلاقة بسبب الـ
        // convention (الاتفاقيات المعروفة في التسمية).
        public Stock? Stock { get; set; }
    }
}