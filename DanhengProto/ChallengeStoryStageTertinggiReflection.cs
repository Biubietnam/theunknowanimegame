using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C2 RID: 450
	public static class ChallengeStoryStageTertinggiReflection
	{
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0003A2A7 File Offset: 0x000384A7
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeStoryStageTertinggiReflection.descriptor;
			}
		}

		// Token: 0x0400087E RID: 2174
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJDaGFsbGVuZ2VTdG9yeVN0YWdlVGVydGluZ2dpLnByb3RvGhlDaGFsbGVu",
			"Z2VMaW5ldXBMaXN0LnByb3RvIqMBChxDaGFsbGVuZ2VTdG9yeVN0YWdlVGVy",
			"dGluZ2dpEikKC2xpbmV1cF9saXN0GAQgAygLMhQuQ2hhbGxlbmdlTGluZXVw",
			"TGlzdBITCgtQUE1LRE1JTkJOSBgHIAEoDRIQCghzY29yZV9pZBgJIAEoDRIQ",
			"CghidWZmX3R3bxgNIAEoDRIQCghidWZmX29uZRgBIAEoDRINCgVsZXZlbBgP",
			"IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChallengeLineupListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStoryStageTertinggi), ChallengeStoryStageTertinggi.Parser, new string[]
			{
				"LineupList",
				"PPMKDMINBNH",
				"ScoreId",
				"BuffTwo",
				"BuffOne",
				"Level"
			}, null, null, null, null)
		}));
	}
}
