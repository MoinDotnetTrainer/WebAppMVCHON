using System.ComponentModel.DataAnnotations;

namespace WebAppMVCHON.Models
{
    public class Adhar
    {
        public int AdharID { get; set; }
        public string? Name { get; set; }
    }

    public class Pan
    {
        [Key]
        public int PanID { get; set; }
        public string? PanUser { get; set; }
        //public int Age { get; set; }
        public int AdharNo { get; set; } // fk
        public Adhar? Adhar { get; set; }
    }
}
