using System;
using FatturaElettronicaPA.WebServices;

namespace Playground
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            // CodiceUnivoco lookup using the IDisposable interface.
		    using (var codiceWebService = new CodiceUnivocoFatturazioneWebService())
		    {
		        codiceWebService.AuthId = "UMMIKQRI";
                codiceWebService.CodiceUfficio = "KN3VNW";

                codiceWebService.PerformRequest();

                if (codiceWebService.Ufficio == null) return;

                Console.WriteLine(codiceWebService.Ufficio.Comune);
		    }

            // CodiceEnte lookup using object initializers.
		    var enteWebService = new DatiEnteWebService {AuthId = "UMMIKQRI", CodiceEnte = "c_h199"};

			enteWebService.PerformRequest();

		    if (enteWebService.Ente == null) return;

		    Console.WriteLine(enteWebService.Ente.Comune);
		}
	}
}
