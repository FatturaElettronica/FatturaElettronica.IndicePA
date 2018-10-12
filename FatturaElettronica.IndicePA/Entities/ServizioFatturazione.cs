using Newtonsoft.Json;

namespace FatturaElettronica.IndicePA
{
	public class ServizioFatturazione
	{
		[JsonProperty (PropertyName = "cod_amm")]
		public string CodiceEnte { get; set; }

		public string StatoCanale { get; set; }

		[JsonProperty (PropertyName = "cod_uni_ou")]
		public string CodiceUnivocoUnitàOrganizzativa { get; set; }

		[JsonProperty (PropertyName = "cod_aoo")]
		public string CodiceAreaOrganizzativaOmogenea{ get; set; }

		[JsonProperty (PropertyName = "des_ou")]
		public string DenominazioneUnitàOrganizzativa{ get; set; }

		[JsonProperty (PropertyName = "cf")]
		public string CodiceFiscale { get; set; }

		[JsonProperty (PropertyName = "dt_verifica_cf")]
		public string ValidazioneCodiceFiscaleServizioFatturazioneElettronica { get; set; }

		[JsonProperty (PropertyName = "dat_val_canale_trasm_sfe")]
		public string InizioAttivitàFatturazioneElettronica { get; set; }
	}

}

