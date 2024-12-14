using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003B2 RID: 946
	public static class DisplayRelicInfoReflection
	{
		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x00075324 File Offset: 0x00073524
		public static FileDescriptor Descriptor
		{
			get
			{
				return DisplayRelicInfoReflection.descriptor;
			}
		}

		// Token: 0x04001105 RID: 4357
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZEaXNwbGF5UmVsaWNJbmZvLnByb3RvGhBSZWxpY0FmZml4LnByb3RvIoUB",
			"ChBEaXNwbGF5UmVsaWNJbmZvEg0KBWxldmVsGAogASgNEgsKA3RpZBgGIAEo",
			"DRIMCgR0eXBlGA8gASgNEhUKDW1haW5fYWZmaXhfaWQYBCABKA0SIwoOc3Vi",
			"X2FmZml4X2xpc3QYDSADKAsyCy5SZWxpY0FmZml4EgsKA2V4cBgIIAEoDUIe",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RelicAffixReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DisplayRelicInfo), DisplayRelicInfo.Parser, new string[]
			{
				"Level",
				"Tid",
				"Type",
				"MainAffixId",
				"SubAffixList",
				"Exp"
			}, null, null, null, null)
		}));
	}
}
