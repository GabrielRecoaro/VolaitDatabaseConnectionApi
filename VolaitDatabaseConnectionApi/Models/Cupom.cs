using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolaitDatabaseConnectionApi.Models
{
	public class Cupom
	{
		public int CupomId { get; set; }
		public string DescCupom { get; set; }
		public decimal ValorDesconto { get; set; }

		public Cupom(int Cupom_, string DescCupom_, decimal ValorDesconto_)
		{
			this.CupomId = Cupom_;
			this.DescCupom = DescCupom_;
			this.ValorDesconto = ValorDesconto_;
		}
	}
}