using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorphiForms.Models;
namespace MorphiTest
{
	public class FormValueTests
	{
		[Fact]
		public void FormValue_ShouldStoreIntValue()
		{
			var formValue = new FormValue(42);
			Assert.Equal(42, formValue.AsInt);
		}

		[Fact]
		public void FormValue_ShouldStoreStringValue()
		{
			var formValue = new FormValue("test");
			Assert.Equal("test", formValue.AsString);
		}

		[Fact]
		public void FormValue_ShouldStoreDateValue()
		{
			var date = new DateTime(2025, 4, 1);
			var formValue = new FormValue(date);
			Assert.Equal(date, formValue.AsDate);
		}

		[Fact]
		public void FormValue_ShouldStoreBoolValue()
		{
			var formValue = new FormValue(true);
			Assert.True(formValue.AsBool);
		}

		[Fact]
		public void FormValue_ShouldHandleNullValue()
		{
			var formValue = new FormValue(null);
			Assert.Null(formValue.Value);
		}

		[Fact]
		public void FormValue_SetValue_ShouldUpdateValue()
		{
			var formValue = new FormValue(42);
			formValue.SetValue("new value");
			Assert.Equal("new value", formValue.AsString);
		}

		[Fact]
		public void FormValue_ToString_ShouldReturnStringValue()
		{
			var formValue = new FormValue("test");
			Assert.Equal("test", formValue.ToString());
		}

		[Fact]
		public void FormValue_ToString_ShouldReturnEmptyStringForNullValue()
		{
			var formValue = new FormValue(null);
			Assert.Equal(string.Empty, formValue.ToString());
		}

		[Fact]
		public void FormValue_AsInt_ShouldReturnZeroForNonIntValue()
		{
			var formValue = new FormValue("not an int");
			Assert.Equal(0, formValue.AsInt);
		}

		[Fact]
		public void FormValue_AsDate_ShouldReturnMinValueForNonDateValue()
		{
			var formValue = new FormValue("not a date");
			Assert.Equal(DateTime.MinValue, formValue.AsDate);
		}
	}
}
