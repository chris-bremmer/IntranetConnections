
namespace MorphiForms.Models
{
	public class Observation
		{
		public int station_id { get; set; }
		public string station_name { get; set; }
		public string error_message { get; set; }
		public string time_date { get; set; }
		public string public_name { get; set; }
		public double latitude { get; set; }
		public double longitude { get; set; }
		public string timezone { get; set; }
		public double elevation { get; set; }
		public bool is_public { get; set; }
		public Status status { get; set; }
		public StationUnits station_units { get; set; }
		public List<string> outdoor_keys { get; set; }
		public List<Ob> obs { get; set; }

		public Observation()
		{
			time_date = DateTime.Today.ToString("MMMM dd, yyyy");
			//time_date += ", " + Format(Now, "h:mm tt");
			status = new Status();
			station_units = new StationUnits();
			outdoor_keys = new List<string>();
			obs = new List<Ob>();
		}
	}

	public class Status
	{
		public int status_code { get; set; }
		public string status_message { get; set; }
	}

	public class StationUnits
	{
		public string units_temp { get; set; }
		public string units_wind { get; set; }
		public string units_precip { get; set; }
		public string units_pressure { get; set; }
		public string units_distance { get; set; }
		public string units_direction { get; set; }
		public string units_other { get; set; }
	}

	public class Ob
	{
		public int timestamp { get; set; }
		public double air_temperature { get; set; }
		public double barometric_pressure { get; set; }
		public double station_pressure { get; set; }
		public double sea_level_pressure { get; set; }
		public int relative_humidity { get; set; }
		public double precip { get; set; }
		public double precip_accum_last_1hr { get; set; }
		public double precip_accum_local_day { get; set; }
		public double precip_accum_local_yesterday { get; set; }
		public int precip_minutes_local_day { get; set; }
		public int precip_minutes_local_yesterday { get; set; }
		public double wind_avg { get; set; }
		public int wind_direction { get; set; }
		public string wind_cardinal { get; set; }
		public double wind_gust { get; set; }

		public double wind_lull { get; set; }
		public int solar_radiation { get; set; }
		public double uv { get; set; }
		public int brightness { get; set; }
		public int lightning_strike_last_epoch { get; set; }
		public int lightning_strike_last_distance { get; set; }
		public int lightning_strike_count { get; set; }
		public int lightning_strike_count_last_1hr { get; set; }
		public int lightning_strike_count_last_3hr { get; set; }
		public double feels_like { get; set; }
		public double heat_index { get; set; }
		public double wind_chill { get; set; }
		public double dew_point { get; set; }
		public double wet_bulb_temperature { get; set; }
		public double delta_t { get; set; }
		public double air_density { get; set; }
		public string pressure_trend { get; set; }
	}

}

