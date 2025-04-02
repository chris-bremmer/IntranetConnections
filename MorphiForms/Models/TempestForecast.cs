namespace MorphiForms.Models
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Reflection;
	using System.Runtime.CompilerServices;
	using System.Security;
	using System.Text;
	using System.Threading.Tasks;
	using Microsoft.VisualBasic;

	public class CurrentConditions
	{
		public int time { get; set; }
		public string conditions { get; set; }
		public string icon { get; set; }
		public int air_temperature { get; set; }
		public double sea_level_pressure { get; set; }
		public double station_pressure { get; set; }
		public string pressure_trend { get; set; }
		public int relative_humidity { get; set; }
		public int wind_avg { get; set; }
		public int wind_direction { get; set; }
		public string wind_direction_cardinal { get; set; }
		public int wind_gust { get; set; }
		public int solar_radiation { get; set; }
		public int uv { get; set; }
		public int brightness { get; set; }
		public int feels_like { get; set; }
		public int dew_point { get; set; }
		public int wet_bulb_temperature { get; set; }
		public int delta_t { get; set; }
		public double air_density { get; set; }
		public int lightning_strike_count_last_1hr { get; set; }
		public int lightning_strike_count_last_3hr { get; set; }
		public int lightning_strike_last_distance { get; set; }
		public string lightning_strike_last_distance_msg { get; set; }
		public int lightning_strike_last_epoch { get; set; }
		public int precip_accum_local_day { get; set; }
		public int precip_accum_local_yesterday { get; set; }
		public int precip_minutes_local_day { get; set; }
		public int precip_minutes_local_yesterday { get; set; }
		public bool is_precip_local_day_rain_check { get; set; }
		public bool is_precip_local_yesterday_rain_check { get; set; }
	}

	public class Daily
	{
		public int day_start_local { get; set; }
		public int day_num { get; set; }
		public int month_num { get; set; }
		public string conditions { get; set; }
		public string icon { get; set; }
		public int sunrise { get; set; }
		public int sunset { get; set; }
		public int air_temp_high { get; set; }
		public int air_temp_low { get; set; }
		public int precip_probability { get; set; }
		public string precip_icon { get; set; }
		public string precip_type { get; set; }
	}

	public class Hourly
	{
		public int time { get; set; }
		public string conditions { get; set; }
		public string icon { get; set; }
		public int air_temperature { get; set; }
		public double sea_level_pressure { get; set; }
		public int relative_humidity { get; set; }
		public int precip { get; set; }
		public int precip_probability { get; set; }
		public string precip_icon { get; set; }
		public int wind_avg { get; set; }
		public int wind_direction { get; set; }
		public string wind_direction_cardinal { get; set; }
		public int wind_gust { get; set; }
		public int uv { get; set; }
		public int feels_like { get; set; }
		public int local_hour { get; set; }
		public int local_day { get; set; }
		public string precip_type { get; set; }
	}

	public class Forecast
	{
		public Daily[] daily { get; set; }
		public Hourly[] hourly { get; set; }
	}


	public class Units
	{
		public string units_temp { get; set; }
		public string units_wind { get; set; }
		public string units_precip { get; set; }
		public string units_pressure { get; set; }
		public string units_distance { get; set; }
		public string units_brightness { get; set; }
		public string units_solar_radiation { get; set; }
		public string units_other { get; set; }
		public string units_air_density { get; set; }
	}

	public class TempestForecast
	{
		public double latitude { get; set; }
		public double longitude { get; set; }
		public string timezone { get; set; }
		public int timezone_offset_minutes { get; set; }
		public string location_name { get; set; }
		public CurrentConditions current_conditions { get; set; }
		public Forecast forecast { get; set; }
		public Status status { get; set; }
		public Units units { get; set; }

		public TempestForecast()
		{
			current_conditions = new CurrentConditions();
			forecast = new Forecast();
			status = new Status();
			units = new Units();
		}
	}
}
