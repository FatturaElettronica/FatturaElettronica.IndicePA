using System.Collections.Generic;

namespace FatturaElettronicaPA.WebServices
{
	/// <summary>
	/// Questo servizio web consente di estrarre dall’iPA informazioni relativa ad una entità, sia
	/// essa un Ente, un’Unità Organizzativa, un’Area Organizzativa Omogenea, un servizio
	/// generico, un Servizio di Fatturazione Elettronica, un Responsabile o un Referente, associata
	/// ad uno specifico indirizzo email. Se un indirizzo mail è associato a più entità all’interno di
	/// iPA, verranno visualizzate le informazioni di dettaglio relative a ciascuna delle entità
	/// individuate.
	/// </summary>
	public class ServiziFatturazioneWebService : WebService
	{
		public ServiziFatturazioneWebService ()
		{
			Endpoint = "WS04_SFE.php";
			RequestParam = "COD_AMM";
		}

		public Result PerformRequest ()
		{
			return PerformRequest <List<ServizioFatturazione>> ();
		}

		public List<ServizioFatturazione> ServiziFatturazione { get { return Data == null ? null : (List<ServizioFatturazione>)Data; } }

		public string CodiceEnte { 

			get{ return RequestValue; } 
			set{ RequestValue = value; }
		}
	}
}

