namespace MorphiForms.Models
{
	public class Deserializer
	{

		private Dictionary<string, string> _formData;

		public Deserializer(Dictionary<string, FormValue> formData)
		{
			_formData = new Dictionary<string, string>();
			foreach (var key in formData.Keys)
			{
				_formData.Add(key, formData[key].Value.ToString());
			}
		}

		public Dictionary<string, string> FormData
		{
			get
			{
				return _formData;
			}
		}

	}
}
