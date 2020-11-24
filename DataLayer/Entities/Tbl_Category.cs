using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Tbl_Category
    {
        [Key]
        public int Id { get; set; }
        public string NameCat { get; set; }
        public int FatherId { get; set; }
        
        
        
        

    }
}