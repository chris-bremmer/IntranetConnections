using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorphiForms.Models;

namespace MorphiTest
{
	public class MorphFormFieldTests
	{
		[Fact]
		public void MorphFormField_ShouldStoreType()
		{
			var field = new MorphFormField { type = "text" };
			Assert.Equal("text", field.type);
		}

		[Fact]
		public void MorphFormField_ShouldStoreTypeEnum()
		{
			var field = new MorphFormField { typeEnum = MorphFormFieldType.Text };
			Assert.Equal(MorphFormFieldType.Text, field.typeEnum);
		}

		[Fact]
		public void MorphFormField_ShouldStoreDataType()
		{
			var field = new MorphFormField { dataType = MorphFormFieldDataType.String };
			Assert.Equal(MorphFormFieldDataType.String, field.dataType);
		}

		[Fact]
		public void MorphFormField_ShouldStoreLabel()
		{
			var field = new MorphFormField { label = "Name" };
			Assert.Equal("Name", field.label);
		}

		[Fact]
		public void MorphFormField_ShouldStoreBoolValue()
		{
			var field = new MorphFormField { boolValue = true };
			Assert.True(field.boolValue);
		}

		[Fact]
		public void MorphFormField_ShouldStoreDateValue()
		{
			var date = new DateTime(2025, 4, 1);
			var field = new MorphFormField { dateValue = date };
			Assert.Equal(date, field.dateValue);
		}

		[Fact]
		public void MorphFormField_ShouldStoreRequired()
		{
			var field = new MorphFormField { required = true };
			Assert.True(field.required);
		}

		[Fact]
		public void MorphFormField_ShouldStoreMinValue()
		{
			var field = new MorphFormField { min = 1 };
			Assert.Equal(1, field.min);
		}

		[Fact]
		public void MorphFormField_ShouldStoreMaxValue()
		{
			var field = new MorphFormField { max = 100 };
			Assert.Equal(100, field.max);
		}

		[Fact]
		public void MorphFormField_ShouldStoreValues()
		{
			var values = new List<string> { "Option1", "Option2" };
			var field = new MorphFormField { values = values };
			Assert.Equal(values, field.values);
		}
	}
}
