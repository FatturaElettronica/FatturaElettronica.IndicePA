using System.Collections.Generic;

namespace FatturaElettronicaPA.WebServices
{
	/// <summary>
	/// Questo servizio web consente di estrarre dall’iPA informazioni su tutti 
	/// gli uffici destinatari di Fatturazione Elettronica associati al Codice 
	/// Fiscale fornito.
	/// </summary>
	public class CodiceFiscaleWebService : WebService
	{
		public CodiceFiscaleWebService ()
		{
			Endpoint = "WS01_SFE_CF.php";
			RequestParam = "CF";
		}

		public Result PerformRequest ()
		{
			return PerformRequest <List<Ufficio>> ();
		}

		public List<Ufficio> Uffici { get { return Data != null ? (List<Ufficio>)Data : null; } }

		public string CodiceFiscale { 

			get{ return RequestValue; } 
			set{ RequestValue = value; }
		}
	}
}

