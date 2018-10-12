using Newtonsoft.Json;

namespace FatturaElettronica.IndicePA
{
	public class Ente : ServizioFatturazione
	{
		public string Regione{ get; set; }

		public string Provincia { get; set; }

		public string Comune { get; set; }

		public string Cap { get; set; }

		public string Indirizzo { get; set; }

		[JsonProperty (PropertyName = "tel")]
		public string Telefono { get; set; }

		public string Fax { get; set; }

		public string Mail1 { get; set; }

		public string Mail2 { get; set; }

		public string Mail3 { get; set; }

		[JsonProperty (PropertyName = "nome_resp")]
		public string NomeResponsabile { get; set; }

		[JsonProperty (PropertyName = "cogn_resp")]
		public string CognomeResponsabile{ get; set; }

		[JsonProperty (PropertyName = "tel_resp")]
		public string TelefonoResponsabile{ get; set; }
	}

}

