using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrsMvc.Models {

	public class User {
		public int Id { get; set; }
		[Required]
		[Index("IDX_Username", IsUnique=true)]
		[StringLength(30)]
		public string Username { get; set; }
		[Required]
		[StringLength(64)]
		public string Password { get; set; }
		[Required]
		[StringLength(30)]
		public string Firstname { get; set; }
		[Required]
		[StringLength(30)]
		public string Lastname { get; set; }
		[Required]
		[StringLength(12)]
		public string Phone { get; set; }
		[Required]
		[StringLength(80)]
		public string Email { get; set; }
		public bool IsReviewer { get; set; } = false;
		public bool IsAdmin { get; set; } = false;
		public bool Active { get; set; } = true;

		public User() { }

		public User(int Id, string Username, string Password, string Firstname, string Lastname,
					string Phone, string Email, bool IsReviewer, bool IsAdmin, bool Active) {
			this.Id = 0;
			this.Username = Username;
			this.Password = Password;
			this.Firstname = Firstname;
			this.Lastname = Lastname;
			this.Phone = Phone;
			this.Email = Email;
			this.IsReviewer = IsReviewer;
			this.IsAdmin = IsAdmin;
		}

		public void Copy(User FromUser) {
			this.Username = FromUser.Username;
			this.Password = FromUser.Password;
			this.Firstname = FromUser.Firstname;
			this.Lastname = FromUser.Lastname;
			this.Phone = FromUser.Phone;
			this.Email = FromUser.Email;
			this.IsReviewer = FromUser.IsReviewer;
			this.IsAdmin = FromUser.IsAdmin;
			this.Active = FromUser.Active;
		}
	}
}