using System.ComponentModel.DataAnnotations;

namespace Core_Proje_Api.DAL.Entity
{
    public class Test
    {
        [Key] 
        public int testıd { get; set; }
        public int propName { get; set; }
    }
}
