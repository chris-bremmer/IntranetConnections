namespace MorphiForms.Models
{
	public enum MorphFormFieldDataType
	{
		String,
		Int,
		Bool,
		DateTime
	}
	public enum MorphFormFieldType
	{
		Text,
		Email,
		Date,
		Number,
		Dropdown,
		Checkbox
	}
	public class MorphFormField
	{
		public string type { get; set; }
		public MorphFormFieldType typeEnum { get; set; }
		public MorphFormFieldDataType dataType { get; set; } 
		public string label { get; set; }
		public bool boolValue { get; set; }
		public DateTime dateValue { get; set; }
		public bool required { get; set; }
		public int min { get; set; }
		public int max { get; set; }
		public List<string> values { get; set; }
	}
}
