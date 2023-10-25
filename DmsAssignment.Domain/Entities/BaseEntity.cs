using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsAssignment.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        // common attributes
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DateDeleted { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
