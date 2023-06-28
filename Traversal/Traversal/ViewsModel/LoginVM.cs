using System.ComponentModel.DataAnnotations;

namespace Traversal.ViewsModel
{
	public class LoginVM
	{
		[DataType(DataType.EmailAddress)]
		[Required(ErrorMessage ="Email can not be null")]
		public string Email { get; set; }
		[Required(ErrorMessage ="Password can not be null")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool IsRemember { get; set; }
	}
}
