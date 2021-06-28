using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.EF_Models
{
    public class UserEntity :BaseEntity
    {
		public string UserName { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public string Address { get; set; }

		public DateTime? CreatedAt { get; set; }

		public DateTime? AddedAt { get; set; }

		public DateTime? ModifiedAt { get; set; }

	}
}
