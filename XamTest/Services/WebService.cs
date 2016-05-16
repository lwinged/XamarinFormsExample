using System;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XamTest
{
	public class WebService
	{
		static HttpClient client = new HttpClient();
		static String url = "http://demo3143189.mockable.io/sessions";

		public WebService ()
		{
		}

		public static async Task<string> getStrData()
		{
			var uri = new Uri (url);
			var content = "";

			try {
				var response = await client.GetAsync (uri);
				if (response.IsSuccessStatusCode) {
					 content = await response.Content.ReadAsStringAsync();
				}
			} 
			catch (Exception ex){
				Debug.WriteLine ("ERROR {0}", ex.Message);
			}

			return content;
		}
			
		public static async Task<List<DataItem>> getDataItems()
		{

			var items = new List<DataItem> ();
			var uri = new Uri (url);

			try {
				var response = await client.GetAsync (uri);
				if (response.IsSuccessStatusCode) {
					var content = await response.Content.ReadAsStringAsync();
					items =  JsonConvert.DeserializeObject <List<DataItem>> (content);
				}
			} 
			catch (Exception ex){
				Debug.WriteLine ("ERROR {0}", ex.Message);
			}

			return items;
		}


	}
}

