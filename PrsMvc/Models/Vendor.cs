using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrsMvc.Models {

	public class Vendor {
		public int Id { get; set; }
		[Index("IDX_VendorCode", IsUnique = true)]
		[Required]
		[StringLength(20)]
		public string Code { get; set; }
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
		[Required]
		[StringLength(50)]
		public string Address { get; set; }
		[Required]
		[StringLength(50)]
		public string City { get; set; }
		[Required]
		[StringLength(2)]
		public string State { get; set; }
		[Required]
		[StringLength(10)]
		public string Zip { get; set; }
		[Required]
		[StringLength(12)]
		public string Phone { get; set; }
		[Required]
		[StringLength(250)]
		public string Email { get; set; }
		public bool IsPreApproved { get; set; } = false;
		public bool Active { get; set; } = true;

		public Vendor() { }

		public Vendor(int Id, string Code, string Name, string Address, string City, string State, string Zip, 
			string Phone, string Email, bool IsPreApproved, bool Active) {
			this.Id = Id;
			this.Code = Code;
			this.Name = Name;
			this.Address = Address;
			this.City = City;
			this.State = State;
			this.Zip = Zip;
			this.Phone = Phone;
			this.Email = Email;
			this.IsPreApproved = IsPreApproved;
			this.Active = Active;
		}

		public void Copy(Vendor FromVendor) {
			this.Id = FromVendor.Id;
			this.Code = FromVendor.Code;
			this.Name = FromVendor.Name;
			this.Address = FromVendor.Address;
			this.City = FromVendor.City;
			this.State = FromVendor.State;
			this.Zip = FromVendor.Zip;
			this.Phone = FromVendor.Phone;
			this.Email = FromVendor.Email;
			this.IsPreApproved = FromVendor.IsPreApproved;
			this.Active = FromVendor.Active;
		}
	}
}