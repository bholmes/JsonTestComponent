using System;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace JsonTest
{
	public class Client
	{
		private Client ()
		{
		}

		class IpFetchResult
		{
			public string Ip { get; set; }
		}

		public static async Task<IPAddress> FetchIp ()
		{
			var client = new WebClient {
				BaseAddress = "http://ip.jsontest.com"
			};

			var result = await client.DownloadStringTaskAsync ("/");

			return IPAddress.Parse (JsonConvert.DeserializeObject<IpFetchResult> (result).Ip);
		}

		class FetchDateTimeResult
		{
//			[JsonProperty("time")]
			public DateTime Time { get; set; }

//			[JsonProperty("milliseconds_since_epoch")]
			public long MillisecondsSinceEpoch { get; set; }

//			[JsonProperty("date")]
			public DateTime Date { get; set; }
		}

		public static async Task<DateTime> FetchDateTime (bool toLocal = false)
		{
			var client = new WebClient {
				BaseAddress = "http://date.jsontest.com"
			};

			var fetchResult = await client.DownloadStringTaskAsync ("/");

			var parseResult = JsonConvert.DeserializeObject<FetchDateTimeResult> (fetchResult);

			var milliseconds = parseResult.MillisecondsSinceEpoch;

			var utcTime = new DateTime (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds (milliseconds);

			if (toLocal)
				return utcTime.ToLocalTime ();

			return utcTime;
		}
	}
}

