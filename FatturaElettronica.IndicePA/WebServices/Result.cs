using Newtonsoft.Json;

namespace FatturaElettronica.IndicePA
{
	public class Result
	{
	    [JsonProperty (PropertyName = "cod_err")]
		public int ErrorCode { get; set; }

		[JsonProperty (PropertyName = "desc_err")]
		public string ErrorDescription { get; set; }

		[JsonProperty (PropertyName = "num_items")]
		public int ItemCount { get; set; }
	}
}

