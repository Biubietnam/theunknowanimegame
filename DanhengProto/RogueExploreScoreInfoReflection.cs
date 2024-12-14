using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E82 RID: 3714
	public static class RogueExploreScoreInfoReflection
	{
		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0600A5B6 RID: 42422 RVA: 0x001BD700 File Offset: 0x001BB900
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueExploreScoreInfoReflection.descriptor;
			}
		}

		// Token: 0x040043B0 RID: 17328
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtSb2d1ZUV4cGxvcmVTY29yZUluZm8ucHJvdG8aF1JvZ3VlRXhwbG9yZVNj",
			"b3JlLnByb3RvImkKFVJvZ3VlRXhwbG9yZVNjb3JlSW5mbxITCgtCQktEQ05E",
			"SUpMThgOIAEoDRITCgtJTEVGSkFDTElDRxgFIAEoAhImCgpzY29yZV9saXN0",
			"GAggAygLMhIuUm9ndWVFeHBsb3JlU2NvcmVCHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueExploreScoreReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueExploreScoreInfo), RogueExploreScoreInfo.Parser, new string[]
			{
				"BBKDCNDIJLN",
				"ILEFJACLICG",
				"ScoreList"
			}, null, null, null, null)
		}));
	}
}
