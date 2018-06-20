using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrsMvc.Models {

	public class PurchaseRequestLineitem {
		public int Id { get; set; }
		public int PurchaseRequestId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }

		public virtual PurchaseRequest PurchaseRequest { get; set; }
		public virtual Product Product { get; set; }

		public PurchaseRequestLineitem() { }

		public PurchaseRequestLineitem(int Id, int PurchaseRequestId, int ProductId, int Quantity) {
			this.Id = Id;
			this.PurchaseRequestId = PurchaseRequestId;
			this.ProductId = ProductId;
			this.Quantity = Quantity;
		}
		public void Copy(PurchaseRequestLineitem FromItem) {
			this.Id = FromItem.Id;
			this.PurchaseRequestId = FromItem.PurchaseRequestId;
			this.ProductId = FromItem.ProductId;
			this.Quantity = FromItem.Quantity;
		}
	}
}