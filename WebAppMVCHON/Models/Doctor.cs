using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVCHON.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    }
    public class DocDegree
    {
        public int ID { get; set; }
        public string? Degree { get; set; }

        public int Doctor____ID { get; set; } // fk , this

        [ForeignKey("Doctor")]
        public int DoctorrefID { get; set; } // fk , this 
        public Doctor? Doctors { get; set; }

        // 1. navigation property match with refdi fk
        // 2. table name match with parent of class name
        // 3. foreignkey attribute with nameof of navigation property
        // 4. foreignkey attribute also chk navigation prop name
    }
}
