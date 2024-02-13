using System.ComponentModel.DataAnnotations;

namespace CryptoScanner.Data.Models.DbModels
{
    public class KryptoDbModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CurrentPrice { get; set; }
    }
}
