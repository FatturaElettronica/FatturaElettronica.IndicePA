using Newtonsoft.Json;

namespace FatturaElettronicaPA.WebServices
{
	public class Ente
	{
	    [JsonProperty (PropertyName = "cod_amm")]
		public string CodiceEnte { get; set; }

		[JsonProperty (PropertyName = "cod_uni_ou")]
		public string CodiceUnivocoUnitàOrganizzativa { get; set; }

		[JsonProperty (PropertyName = "cod_aoo")]
		public string CodiceAreaOrganizzativaOmogenea{ get; set; }

		[JsonProperty (PropertyName = "des_ou")]
		public string DenominazioneUnitàOrganizzativa{ get; set; }

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

		public string StatoCanale { get; set; }

		[JsonProperty (PropertyName = "cf")]
		public string CodiceFiscale { get; set; }

		[JsonProperty (PropertyName = "dt_verifica_cf")]
		public string ValidazioneCodiceFiscaleServizioFatturazioneElettronica { get; set; }

		[JsonProperty (PropertyName = "dat_val_canale_trasm_sfe")]
		public string InizioAttivitàFatturazioneElettronica { get; set; }




	}

}

