using System.ComponentModel.DataAnnotations;

namespace WebAppMVCHON.Models
{
    public class Std
    {
        [Key]
        public int StudentID { get; set; }
        public string? Name { get; set; }
    }

    public class Result
    {
        
        public int ResultID { get; set; }
        public string? Grade { get; set; }
        public int MarksID { get; set; } // y not marksid fk
        public int StdRefNo { get; set; }  // fk
        public Std? Std { get; set; }
    }
}
