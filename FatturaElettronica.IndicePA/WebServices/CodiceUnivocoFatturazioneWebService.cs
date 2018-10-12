
namespace FatturaElettronica.IndicePA
{
	public class CodiceUnivocoFatturazioneWebService : WebService
	{
		public CodiceUnivocoFatturazioneWebService ()
		{
			Endpoint = "WS06_OU_CODUNI.php";
			RequestParam = "COD_UNI_OU";
		}

        public Result PerformRequest() 
        {
            return PerformRequest<Ente>();
        }

        public Ente Ufficio { get { return Data == null ? null : (Ente)Data; } }
		public string CodiceUfficio { 
			get{ return RequestValue; } 
			set{ RequestValue = value; }
		}
	}
}

