using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MorphiForms.Models
{
	public class Tempest
	{
		private const int STATION_ID = 51117;
		private const string TOKEN = "3a5f4c21-912b-45a4-8823-67760f608592";
		private readonly HttpClient _httpClient;

		public Tempest(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<Observation> GetObservationAsync()
		{
			Observation result = new Observation();
			string requestUrl = $"https://swd.weatherflow.com/swd/rest/observations/station/{STATION_ID}?token={TOKEN}";
			string json = await GetWebRequestAsync(requestUrl);

			if (!string.IsNullOrEmpty(json))
				result = JsonSerializer.Deserialize<Observation>(json);

			return result;
		}

		public async Task<TempestForecast> GetForecastAsync()
		{
			TempestForecast result = new TempestForecast();
			string requestUrl = $"https://swd.weatherflow.com/swd/rest/better_forecast?station_id={STATION_ID}&token={TOKEN}";
			string json = await GetWebRequestAsync(requestUrl);

			if (!string.IsNullOrEmpty(json))
				result = JsonSerializer.Deserialize<TempestForecast>(json);

			return result;
		}

		private async Task<string> GetWebRequestAsync(string requestUrl)
		{
			try
			{
				var response = await _httpClient.GetAsync(requestUrl);
				response.EnsureSuccessStatusCode();
				return await response.Content.ReadAsStringAsync();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching data: {ex.Message}");
				return string.Empty;
			}
		}
	}
}
