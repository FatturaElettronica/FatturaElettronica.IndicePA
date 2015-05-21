using Newtonsoft.Json;

namespace FatturaElettronicaPA.WebServices
{
	public class Email
	{
		[JsonProperty (PropertyName = "tipo_email")]
		public string TipoEmail { get; set; }

		[JsonProperty (PropertyName = "tipo_entita")]
		public string TipoEntita { get; set; }

		[JsonProperty (PropertyName = "cod_amm")]
		// ReSharper disable once InconsistentNaming
		public string CodiceEntePA { get; set; }

		[JsonProperty (PropertyName = "des_amm")]
		public string Denominazione { get; set; }

		[JsonProperty (PropertyName = "cod_entita")]
		public string Codice { get; set; }

	}

}

