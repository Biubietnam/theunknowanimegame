using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B8 RID: 440
	public static class ChallengeStatisticsReflection
	{
		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x000394FC File Offset: 0x000376FC
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeStatisticsReflection.descriptor;
			}
		}

		// Token: 0x0400085D RID: 2141
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlDaGFsbGVuZ2VTdGF0aXN0aWNzLnByb3RvGh1DaGFsbGVuZ2VTdGFnZVRl",
			"cnRpbmdnaS5wcm90byJbChNDaGFsbGVuZ2VTdGF0aXN0aWNzEjEKD3N0YWdl",
			"X3RlcnRpbmdnaRgFIAEoCzIYLkNoYWxsZW5nZVN0YWdlVGVydGluZ2dpEhEK",
			"CXJlY29yZF9pZBgNIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChallengeStageTertinggiReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStatistics), ChallengeStatistics.Parser, new string[]
			{
				"StageTertinggi",
				"RecordId"
			}, null, null, null, null)
		}));
	}
}
