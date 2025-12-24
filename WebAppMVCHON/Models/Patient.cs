using System.ComponentModel.DataAnnotations;

namespace WebAppMVCHON.Models
{
    public class Patient
    {
        [Key]
        public int PID { get; set; }
        public string Name { get; set; }
    }

    public class Lab
    {
        [Key]
        public int LabID { get; set; }
        public string Report { get; set; }
      //  public string TestID { get; set; }
        public int PID { get; set; }  // not a fk
        public Patient? Patient { get; set; }  // fk
    }
}
