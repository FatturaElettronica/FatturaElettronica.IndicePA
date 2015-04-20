using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FatturaElettronicaPA.WebServices
{
	public abstract class WebService : IDisposable
	{

		protected string Endpoint;
		protected string RequestParam;
		protected string RequestValue;

		private object _data;
		private bool _silentOnExceptions = true;

		private const string RootUrl = "http://www.indicepa.gov.it/public-ws/";

		private string PerformRequestRaw ()
		{
			Validate ();

			using (var client = new HttpClient ()) {
				// the PA webservice will respond with a 403 Forbidden if we don't provide
				// a User-Agent header. Yes. That's another anti-pattern.
				client.DefaultRequestHeaders.Add ("User-Agent", "FatturaElettronicaPA");

				client.BaseAddress = new Uri (RootUrl);
				var content = new FormUrlEncodedContent (new[] {
					new KeyValuePair<string, string> ("AUTH_ID", AuthId),
					new KeyValuePair<string, string> (RequestParam, RequestValue)
				});

				HttpResponseMessage response;
				try {
					response = client.PostAsync (Endpoint, content).Result;
				} catch (Exception e) {
					if (SilentOnExceptions) {
						return null;
					}
					// ReSharper disable once PossibleIntendedRethrow
					throw e;
				}

				if (!response.IsSuccessStatusCode) {
					// TODO consider throwing the exception here, since there's
					// something wrong with the request (most likely the API
					// changed or there's a bug).
					return null;
				}
				return response.Content.ReadAsStringAsync ().Result;
			}
		}

		internal Result PerformRequest<T> () where T: new()
		{
			Result = null;
			Data = null;

			var raw = PerformRequestRaw ();
			if (raw == null) {
				// Typically we fall into this guard when an Exception has been 
				// thrown by the HttpClient and SilentOnException is true, or
				// when something went orribly wrong with the request.
				return null;
			}

			// the PA webservice changes its payload format depending on wether 
			// the request was valid and/or the lookup was successful, which is 
			// a complete anti-pattern. Alas, we have to handle it, so we don't 
			// expose this complexity to the user (we always return a Result 
			// object).
			var values = JsonConvert.DeserializeObject<Dictionary<string, object>> (raw);

			// deserialize Result, wherever it might be located in the payload (see
			// comment above.
			Result = JsonConvert.DeserializeObject<Result> (values.ContainsKey ("result") ? values ["result"].ToString () : raw);

			// deserialize data if available.
			if (Result != null && Result.ErrorCode == 0 && Result.ItemCount > 0) {
				_data = JsonConvert.DeserializeAnonymousType (values ["data"].ToString (), new T ());
			}
			return Result;
		}

		private void Validate ()
		{

			if (string.IsNullOrEmpty (Endpoint)) {
				throw new ArgumentNullException (Endpoint);
			}
			if (string.IsNullOrEmpty (RequestParam)) {
				throw new ArgumentNullException (RequestParam);
			}
			if (string.IsNullOrEmpty (RequestValue)) {
				throw new ArgumentNullException (RequestValue);
			}
			if (string.IsNullOrEmpty (AuthId)) {
				throw new ArgumentNullException (AuthId);
			}

		}

		public string AuthId { get; set; }

		public Result Result { get; internal set; }

		internal object Data {
			get { return _data; }
			set { _data = value; }
		}

		public bool SilentOnExceptions {
			get { return _silentOnExceptions; }
			set { _silentOnExceptions = value; }
		}

		public void Dispose ()
		{
			// Nothing to do here since we're dispoing HttpClient within the PerformRequestRaw Method.
		}
	}
}

