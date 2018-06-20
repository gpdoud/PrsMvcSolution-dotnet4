using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrsMvc.Models {

	public class Product {
		public int Id { get; set; }
		public int VendorId { get; set; }
		[Required]
		[StringLength(50)]
		public string PartNumber { get; set; }
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
		[DisplayFormat(DataFormatString = "{0:C}")]
		public decimal Price { get; set; }
		[Required]
		[StringLength(15)]
		public string Unit { get; set; } = "EACH";
		[StringLength(255)]
		public string PhotoPath { get; set; }
		public bool Active { get; set; } = true;

		public virtual Vendor Vendor { get; set; }

		public Product() { }

		public Product(int Id, int VendorId, string PartNumber, string Name, decimal Price, string Unit, string PhotoPath, bool Active) {
			this.Id = Id;
			this.VendorId = VendorId;
			this.PartNumber = PartNumber;
			this.Name = Name;
			this.Price = Price;
			this.Unit = Unit;
			this.PhotoPath = PhotoPath;
			this.Active = Active;
		}
		public void Copy(Product FromProduct) {
			this.Id = FromProduct.Id;
			this.VendorId = FromProduct.VendorId;
			this.PartNumber = FromProduct.PartNumber;
			this.Name = FromProduct.Name;
			this.Price = FromProduct.Price;
			this.Unit = FromProduct.Unit;
			this.PhotoPath = FromProduct.PhotoPath;
			this.Active = FromProduct.Active;
		}
	}
}