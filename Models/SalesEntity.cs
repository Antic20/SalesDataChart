using System.ComponentModel.DataAnnotations;

namespace SalesDataChart.Models
{
    public class SalesEntity
    {
        [Key]
       public int Id { get; set; }
       public string Monthname { get; set; }
       public int TotalSales { get; set; }
    }
}
