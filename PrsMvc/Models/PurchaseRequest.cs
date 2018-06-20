using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrsMvc.Models {

	public class PurchaseRequest {
		public int Id { get; set; }
		public int UserId { get; set; }
		[Required]
		[StringLength(80)]
		public string Description { get; set; }
		[Required]
		[StringLength(255)]
		public string Justification { get; set; }
		[StringLength(80)]
		public string RejectionReason { get; set; }
		[Required]
		[StringLength(30)]
		public string DeliveryMode { get; set; }
		[Required]
		[StringLength(15)]
		public string Status { get; set; }
		[DisplayFormat(DataFormatString = "{0:C}")]
		public decimal Total { get; set; } = 0;
		public bool Active { get; set; } = true;

		public virtual List<PurchaseRequestLineitem> PurchaseRequestLineitems { get; set; }

		public virtual User User { get; set; }

		public PurchaseRequest() { }

		public PurchaseRequest(int Id, int UserId, string Description, string Justification, string RejectionReason,
			string DeliveryMode, string Status, decimal Total, bool Active) {
			this.Id = Id;
			this.UserId = UserId;
			this.Description = Description;
			this.Justification = Justification;
			this.RejectionReason = RejectionReason;
			this.DeliveryMode = DeliveryMode;
			this.Status = Status;
			this.Total = Total;
			this.Active = Active;
		}

		public void Copy(PurchaseRequest FromPurchaseRequest) {
			this.Id = FromPurchaseRequest.Id;
			this.UserId = FromPurchaseRequest.UserId;
			this.Description = FromPurchaseRequest.Description;
			this.Justification = FromPurchaseRequest.Justification;
			this.RejectionReason = FromPurchaseRequest.RejectionReason;
			this.DeliveryMode = FromPurchaseRequest.DeliveryMode;
			this.Status = FromPurchaseRequest.Status;
			this.Total = FromPurchaseRequest.Total;
			this.Active = FromPurchaseRequest.Active;
		}
	}



}