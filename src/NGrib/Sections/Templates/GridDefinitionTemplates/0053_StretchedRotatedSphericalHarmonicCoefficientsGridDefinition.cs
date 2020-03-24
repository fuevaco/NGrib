﻿namespace NGrib.Sections.Templates.GridDefinitionTemplates
{
	public class StretchedRotatedSphericalHarmonicCoefficientsGridDefinition : RotatedSphericalHarmonicCoefficientsGridDefinition
	{
		/// <summary> .</summary>
		/// <returns> PoleLat as a float
		/// 
		/// </returns>
		public float PoleLat { get; }

		/// <summary> .</summary>
		/// <returns> PoleLon as a float
		/// 
		/// </returns>
		public float PoleLon { get; }

		/// <summary> .</summary>
		/// <returns> Factor as a float
		/// 
		/// </returns>
		public float Factor { get; }

		internal StretchedRotatedSphericalHarmonicCoefficientsGridDefinition(BufferedBinaryReader reader) : base(reader)
		{
			PoleLat = reader.ReadUInt32() * 1e-6f;
			PoleLon = reader.ReadUInt32() * 1e-6f;
			Factor = reader.ReadSingle();
		}
	}
}