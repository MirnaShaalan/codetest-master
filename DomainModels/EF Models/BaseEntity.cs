using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.EF_Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
