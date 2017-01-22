using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDomainModels.Users
{
    [Table("SysUserInfo")]
    public class SysUserInfo: ISupportAudit
    {
        [Key]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }

        public DateTime CreateDate
        {
            get;set;
        }

        public int CreateUser
        {
            get; set;
        }

        

        public DateTime? UpdateDate
        {
            get; set;
        }

        public int? UpdateUser
        {
            get; set;
        }
    }
}
