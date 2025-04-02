namespace MorphiForms.Models
{
	public class FormValue
	{
		public object Value { get; set; }

		public FormValue(int intval)
		{
			Value = intval;
		}

		public FormValue(string strval)
		{
			Value = strval;
		}

		public FormValue(DateTime dateval)
		{
			Value = dateval;
		}

		public FormValue(bool boolval)
		{
			Value = boolval;
		}

		public FormValue(object val)
		{
			Value = val;
		}

		public int AsInt
		{
			get => Value is int intValue ? intValue : 0;
			set => Value = value;
		}

		public string AsString
		{
			get => Value as string ?? string.Empty;
			set => Value = value;
		}

		public DateTime? AsDate
		{
			get => Value is DateTime dateValue ? dateValue : DateTime.MinValue;
			set => Value = value is not null ? value : DateTime.MinValue;
		}

		public bool AsBool
		{
			get => Value is bool boolValue ? boolValue : false;
			set => Value = value;
		}

		public void SetValue(object newValue)
		{
			Value = newValue;
		}

		public override string ToString()
		{
			return Value?.ToString() ?? string.Empty;
		}
	}
}
