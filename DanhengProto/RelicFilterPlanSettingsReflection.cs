using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DA8 RID: 3496
	public static class RelicFilterPlanSettingsReflection
	{
		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x06009C49 RID: 40009 RVA: 0x0019FFF1 File Offset: 0x0019E1F1
		public static FileDescriptor Descriptor
		{
			get
			{
				return RelicFilterPlanSettingsReflection.descriptor;
			}
		}

		// Token: 0x04003CAA RID: 15530
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1SZWxpY0ZpbHRlclBsYW5TZXR0aW5ncy5wcm90byLtAgoXUmVsaWNGaWx0",
			"ZXJQbGFuU2V0dGluZ3MSFQoNcmFyaXR5X2JpdHNldBgBIAEoDRIWCg5yZWxp",
			"Y19zZXRfbGlzdBgCIAMoDRIfChdib2R5X21haW5fcHJvcGVydHlfbGlzdBgD",
			"IAMoDRIfChdmb290X21haW5fcHJvcGVydHlfbGlzdBgEIAMoDRIhChlzcGhl",
			"cmVfbWFpbl9wcm9wZXJ0eV9saXN0GAUgAygNEh8KF3JvcGVfbWFpbl9wcm9w",
			"ZXJ0eV9saXN0GAYgAygNEiYKHmlzX2luY2x1ZGVfZmlsdGVyX3N1Yl9wcm9w",
			"ZXJ0eRgHIAEoCBIYChBzdWJfcHJvcGVydHlfbnVtGAggASgNEhkKEXN1Yl9w",
			"cm9wZXJ0eV9saXN0GAkgAygNEh8KF2hlYWRfbWFpbl9wcm9wZXJ0eV9saXN0",
			"GAogAygNEh8KF2hhbmRfbWFpbl9wcm9wZXJ0eV9saXN0GAsgAygNQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RelicFilterPlanSettings), RelicFilterPlanSettings.Parser, new string[]
			{
				"RarityBitset",
				"RelicSetList",
				"BodyMainPropertyList",
				"FootMainPropertyList",
				"SphereMainPropertyList",
				"RopeMainPropertyList",
				"IsIncludeFilterSubProperty",
				"SubPropertyNum",
				"SubPropertyList",
				"HeadMainPropertyList",
				"HandMainPropertyList"
			}, null, null, null, null)
		}));
	}
}
