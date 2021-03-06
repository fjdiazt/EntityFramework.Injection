﻿using System.ComponentModel.DataAnnotations.Schema;
using EntityFramework.Inject.Localization;

namespace SampleLibrary.Entities
{
	[Table("Categories")]
	public class ProtectedCategory
	{
		public void InitComputed()
		{
			CategoryComputed = new ComputedLocalizedStrings3();
		}

		public int Id { get; set; }

		public LocalizedStrings3 CategoryName { get; set; }

		public ComputedLocalizedStrings3 CategoryComputed { get; protected set; }

		public string NotLocalizedName { get; set; }
	}
}