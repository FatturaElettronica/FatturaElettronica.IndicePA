using System.Collections.Generic;

namespace FatturaElettronicaPA.WebServices
{
	public class UnitaOrganizzativaWebService : WebService
	{
		public UnitaOrganizzativaWebService ()
		{
			Endpoint = "WS03_OU.php";
			RequestParam = "COD_AMM";
		}

		public Result PerformRequest ()
		{
			return PerformRequest<List<UnitaOrganizzativa>> ();
		}

		public List<UnitaOrganizzativa> UnitàOrganizzative { get { return Data == null ? null : (List<UnitaOrganizzativa>)Data; } }

		public string CodiceEnte { 

			get{ return RequestValue; } 
			set{ RequestValue = value; }
		}
	}
}

