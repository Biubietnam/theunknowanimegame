using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F3C RID: 3900
	public static class RogueMiracleReflection
	{
		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x0600AE0F RID: 44559 RVA: 0x001D41AF File Offset: 0x001D23AF
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMiracleReflection.descriptor;
			}
		}

		// Token: 0x040046DC RID: 18140
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJSb2d1ZU1pcmFjbGUucHJvdG8ixQEKDFJvZ3VlTWlyYWNsZRIRCgltYXhf",
			"dGltZXMYDSABKA0SEgoKbWlyYWNsZV9pZBgGIAEoDRIRCgljdXJfdGltZXMY",
			"BCABKA0SMwoLT0VPSUpCSEFJTkIYDiADKAsyHi5Sb2d1ZU1pcmFjbGUuT0VP",
			"SUpCSEFJTkJFbnRyeRISCgpkdXJhYmlsaXR5GAcgASgNGjIKEE9FT0lKQkhB",
			"SU5CRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMiracle), RogueMiracle.Parser, new string[]
			{
				"MaxTimes",
				"MiracleId",
				"CurTimes",
				"OEOIJBHAINB",
				"Durability"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
