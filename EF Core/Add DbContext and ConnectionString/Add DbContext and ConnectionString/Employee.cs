using System.ComponentModel.DataAnnotations;

namespace Add_DbContext_and_ConnectionString
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
