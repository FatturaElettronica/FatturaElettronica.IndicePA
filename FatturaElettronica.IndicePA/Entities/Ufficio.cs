using Newtonsoft.Json;

namespace FatturaElettronica.IndicePA
{
	public class Ufficio
	{
		[JsonProperty (PropertyName = "cod_amm")]
		// ReSharper disable once InconsistentNaming
		public string CodiceEntePA { get; set; }

		[JsonProperty (PropertyName = "des_amm")]
		public string Denominazione { get; set; }

		public string StatoCanale { get; set; }

		[JsonProperty (PropertyName = "cod_uni_ou")]
		public string CodiceUnivocoUnitàOrganizzativa { get; set; }

		[JsonProperty (PropertyName = "des_ou")]
		public string DenominazioneUnitàOrganizzativa{ get; set; }
	}

}

