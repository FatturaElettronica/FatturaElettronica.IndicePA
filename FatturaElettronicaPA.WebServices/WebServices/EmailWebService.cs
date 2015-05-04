using System.Collections.Generic;

namespace FatturaElettronicaPA.WebServices
{
	/// <summary>
	/// Questo servizio web consente di estrarre dall’iPA informazioni relativa ad una entità, sia 
	/// essa un Ente, un’Unità Organizzativa, un’Area Organizzativa Omogenea, un servizio generico, 
	/// un Servizio di Fatturazione Elettronica, un Responsabile o un Referente, associata ad uno 
	/// specifico indirizzo email. Se un indirizzo mail è associato a più entità all’interno di iPA, 
	/// verranno visualizzate le informazioni di dettaglio relative a ciascuna delle entità individuate.
	/// </summary>
	public class EmailWebService : WebService
	{
		public EmailWebService ()
		{
			Endpoint = "WS07_EMAIL.php";
			RequestParam = "EMAIL";
		}

		public Result PerformRequest ()
		{
			return PerformRequest <List<Email>> ();
		}

		public List<Email> Emails { get { return Data == null ? null : (List<Email>)Data; } }

		public string Email { 

			get{ return RequestValue; } 
			set{ RequestValue = value; }
		}
	}
}

