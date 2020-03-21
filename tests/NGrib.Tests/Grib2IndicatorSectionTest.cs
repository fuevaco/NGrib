﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NFluent;
using NGrib.Sections;
using Xunit;

namespace NGrib.Tests
{
	public class Grib2IndicatorSectionTest
	{
		[Fact]
		public void BuildFrom_ValidGribFile_Test()
		{
			using var gribFileStream = File.OpenRead(GribFileSamples.ValidFile);
			var reader = new BufferedBinaryReader(gribFileStream);
			
			var indicatorSection = Grib2IndicatorSection.BuildFrom(reader);

			Check.That(indicatorSection).IsNotNull();
			Check.That(indicatorSection.GribEdition).Equals(2);
			Check.That(indicatorSection.DisciplineNumber).Equals(0);
			Check.That(indicatorSection.Discipline).Equals(Discipline.MeteorologicalProducts);
			Check.That(indicatorSection.TotalLength.Sign).IsStrictlyPositive();
		}
	}

	internal static class GribFileSamples
	{
		public static string ValidFile{ get; } = "samples/gfs.20200314.t00z.pgrb2.0p25.anl";
	}
}