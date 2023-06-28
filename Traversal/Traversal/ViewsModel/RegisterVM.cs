using System;
using System.ComponentModel.DataAnnotations;

namespace Traversal.ViewsModel
{
	public class RegisterVM
	{
		[Required(ErrorMessage ="Name can not be null")]
		public string Name { get; set; }
		[Required(ErrorMessage ="Surname can not be null")]
		public string Surname { get; set; }
		[Required(ErrorMessage ="Username can not be null")]
		public string Username { get; set; }
		[Required(ErrorMessage ="Phone Number can not be null")]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set;}
		[Required(ErrorMessage ="Email can not be null")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required(ErrorMessage ="Password can not be null")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required(ErrorMessage ="ConfirmPassword can not be null")]
		[DataType(DataType.Password)]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }
		public DateTime CreateTime = DateTime.UtcNow.AddHours(4);
		public bool isDeactive { get; set; }
		public bool IsRemember { get; set; }
	}
}
