using Microsoft.CodeAnalysis.Operations;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVCHON.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string? CountryName { get; set; }
    }

    public class State
    {
        [Key]
        public int StataeID { get; set; }
        public string? StateName { get; set; }


        public int CountryID { get; set; }  // fk
        public Country _Country { get; set; }  // county table
    }
}
