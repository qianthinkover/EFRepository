using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDomainModels.Orders
{
    [Table("PersperationOrder")]
    public class PersperationOrder
    {
        public int Id { get; set; }
        [Column("OrderNo")]
        public string OrderNo { get; set; }
        [Column("PatientId")]
        public string PatientId { get; set; }
        [Column("PatientName")]
        public string PatientName{ get; set; }
        [Column("HisDoctorId")]
        public string HisDoctorId { get; set; }
        [Column("HisDoctorName")]
        public string HisDoctorName { get; set; }
    }
}
