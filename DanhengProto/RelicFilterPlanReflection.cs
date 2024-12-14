using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DA2 RID: 3490
	public static class RelicFilterPlanReflection
	{
		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x06009BFC RID: 39932 RVA: 0x0019F2C4 File Offset: 0x0019D4C4
		public static FileDescriptor Descriptor
		{
			get
			{
				return RelicFilterPlanReflection.descriptor;
			}
		}

		// Token: 0x04003C8D RID: 15501
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVSZWxpY0ZpbHRlclBsYW4ucHJvdG8aHVJlbGljRmlsdGVyUGxhblNldHRp",
			"bmdzLnByb3RvGhlSZWxpY0ZpbHRlclBsYW5JY29uLnByb3RvIscBCg9SZWxp",
			"Y0ZpbHRlclBsYW4SGAoQQXZhdGFySWRPbkNyZWF0ZRgDIAEoDRIQCghJc01h",
			"cmtlZBgPIAEoCBIqCghTZXR0aW5ncxgFIAEoCzIYLlJlbGljRmlsdGVyUGxh",
			"blNldHRpbmdzEhcKD1VwZGF0ZVRpbWVzdGFtcBgOIAEoAxIMCgROYW1lGAgg",
			"ASgJEhEKCVNsb3RJbmRleBgGIAEoDRIiCgRJY29uGAsgASgLMhQuUmVsaWNG",
			"aWx0ZXJQbGFuSWNvbkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RelicFilterPlanSettingsReflection.Descriptor,
			RelicFilterPlanIconReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RelicFilterPlan), RelicFilterPlan.Parser, new string[]
			{
				"AvatarIdOnCreate",
				"IsMarked",
				"Settings",
				"UpdateTimestamp",
				"Name",
				"SlotIndex",
				"Icon"
			}, null, null, null, null)
		}));
	}
}
