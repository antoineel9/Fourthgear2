using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FourthGear2.Data
{
    public class Supervisors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int DID { get; set; }

        [ForeignKey("DID")]
        public Departments DeptId { get; set; }
    }
}
