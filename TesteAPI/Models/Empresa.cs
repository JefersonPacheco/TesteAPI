using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteAPI.Models
{
	public class Empresa
	{
		public int Id { get; set; }
		[Required]
		[StringLength(60, MinimumLength = 2)]
		public string Nome { get; set; }
		[Required]
		[StringLength(18, MinimumLength = 2)]
		public string Cnpj { get; set; }
		[Required]
		[StringLength(10, MinimumLength = 10)]
		public string Data { get; set; }
	}
}
