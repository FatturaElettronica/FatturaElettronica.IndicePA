
namespace FatturaElettronica.IndicePA
{
	public class DatiEnteWebService : WebService
	{
		public DatiEnteWebService ()
		{
			Endpoint = "WS05_AMM.php";
			RequestParam = "COD_AMM";
		}

        public Result PerformRequest() 
        {
            return PerformRequest<Ente>();
        }
        public Ente Ente { get { return Data == null ? null : (Ente)Data; } }

		public string CodiceEnte { 

			get{ return RequestValue; } 
			set{ RequestValue = value; }
		}
	}
}

