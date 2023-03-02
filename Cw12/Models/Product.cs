using System.ComponentModel.DataAnnotations;

namespace Cw12.Models
{
	public class Product
	{
		[Display(Name ="شماره")]
		public int Id { get; set; }
		[Display(Name = "نام محصول")]
		[Required(ErrorMessage ="*")]
		[MaxLength(6,ErrorMessage ="نمی تواند بیشتر از 6 کاراکتر باشد")]
		public string Name { get; set; }
		[Display(Name = "رنگ")]
		public string Color { get; set; }
		[Display(Name = "مدل")]
		public string Model { get; set; }
		[Display(Name = "برند")]
		[Required(ErrorMessage = "*")]
		public BrandEnum BrandEnum { get; set; }
		[Display(Name = "کد")]
		[Required(ErrorMessage = "*")]
		[Range(1000,9999,ErrorMessage = "کد وارد شده باید بین 1000 تا 9999 باشد")]
		public int Code { get; set; }
	}
}
