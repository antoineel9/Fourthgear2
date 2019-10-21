using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FourthGear2.Data
{
    public class Accounting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AID { get; set; }
        [Display(Name = "Account MGR")]
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        [ForeignKey("DID")]
        public Departments DeptId { get; set; }
    }
}
