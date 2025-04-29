namespace Basic_CRUD_Operations.Data
{
    public class Product
    {
        public required int Id { get; set; } // المفتاح الأساسي
        public required string Name { get; set; } // اسم المنتج
        public required string Sku { get; set; } // الكود التعريفي للمنتج
    }
}
