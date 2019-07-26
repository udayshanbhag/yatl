using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoapi.Models
{
    public class Todo
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime  ModifiedDateTime { get; set; }

        public User CreatedBy { get; set; }
    }
}
