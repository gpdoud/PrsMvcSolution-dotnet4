using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrsMvc.Models {
	public class PrsMvcDbContext : DbContext {

		public PrsMvcDbContext() : base("name=PrsMvcDbContext") { }

		public System.Data.Entity.DbSet<PrsMvc.Models.User> Users { get; set; }

		public System.Data.Entity.DbSet<PrsMvc.Models.Vendor> Vendors { get; set; }

		public System.Data.Entity.DbSet<PrsMvc.Models.Product> Products { get; set; }

		public System.Data.Entity.DbSet<PrsMvc.Models.PurchaseRequest> PurchaseRequests { get; set; }

		public System.Data.Entity.DbSet<PrsMvc.Models.PurchaseRequestLineitem> PurchaseRequestLineitems { get; set; }
	}
}