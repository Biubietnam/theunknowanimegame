using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000F2 RID: 242
	public static class BattleRelicReflection
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x000200B9 File Offset: 0x0001E2B9
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleRelicReflection.descriptor;
			}
		}

		// Token: 0x0400048E RID: 1166
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFCYXR0bGVSZWxpYy5wcm90bxoQUmVsaWNBZmZpeC5wcm90byKlAQoLQmF0",
			"dGxlUmVsaWMSCgoCaWQYASABKA0SDQoFbGV2ZWwYAiABKA0SFQoNbWFpbl9h",
			"ZmZpeF9pZBgDIAEoDRIjCg5zdWJfYWZmaXhfbGlzdBgEIAMoCzILLlJlbGlj",
			"QWZmaXgSEQoJdW5pcXVlX2lkGAUgASgNEg4KBnNldF9pZBgGIAEoDRIMCgR0",
			"eXBlGAcgASgNEg4KBnJhcml0eRgIIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RelicAffixReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleRelic), BattleRelic.Parser, new string[]
			{
				"Id",
				"Level",
				"MainAffixId",
				"SubAffixList",
				"UniqueId",
				"SetId",
				"Type",
				"Rarity"
			}, null, null, null, null)
		}));
	}
}
