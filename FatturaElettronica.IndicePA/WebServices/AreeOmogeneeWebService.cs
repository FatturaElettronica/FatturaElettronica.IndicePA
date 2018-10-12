using System.Collections.Generic;

namespace FatturaElettronica.IndicePA
{
	/// <summary>
	/// Questo servizio web consente di estrarre dall’ iPA informazioni su tutte le aree organizzative
	/// omogenee associate al codice iPA fornito. Il servizio consente, inoltre, di impostare come
	/// parametro di ricerca anche il codice AOO, oltre il codice iPA. Si tenga presente che nel caso
	/// in cui l’utente fornisca congiuntamente i due codici (codice iPA e codice AOO) dalla ricerca
	/// potrà essere estratta solo ed esclusivamente una Area Organizzativa Omogenea.
	/// </summary>
	public class AreeOmogeneeWebService : WebService
	{
		public AreeOmogeneeWebService ()
		{
			Endpoint = "WS02_AOO.php";
			RequestParam = "COD_AMM";
			RequestParam2 = "COD_AOO";
		}

		public Result PerformRequest ()
		{
			return PerformRequest<List<AreaOmogenea>> ();
		}

		public List<AreaOmogenea> AreeOmogenee { get { return Data == null ? null : (List<AreaOmogenea>)Data; } }

		public string CodiceEnte { 

			get{ return RequestValue; } 
			set{ RequestValue = value; }
		}

		/// <summary>
		/// Imposta o legge il codice area omogenea (opzionale).
		/// </summary>
		/// <value>Il codice area omogenea.</value>
		public string CodiceAreaOmogenea { 

			get{ return RequestValue2; } 
			set{ RequestValue2 = value; }
		}
	}
}

