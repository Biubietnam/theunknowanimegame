using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200018C RID: 396
	public static class ChallengeReflection
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00032D4D File Offset: 0x00030F4D
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeReflection.descriptor;
			}
		}

		// Token: 0x04000769 RID: 1897
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg9DaGFsbGVuZ2UucHJvdG8aGENoYWxsZW5nZVN0YWdlSW5mby5wcm90byK7",
			"AQoJQ2hhbGxlbmdlEhMKC0RGRk1JQUNNSExEGAkgASgIEhEKCXNjb3JlX3R3",
			"bxgIIAEoDRIRCglyZWNvcmRfaWQYCiABKA0SDAoEc3RhchgNIAEoDRInCgpz",
			"dGFnZV9pbmZvGAUgASgLMhMuQ2hhbGxlbmdlU3RhZ2VJbmZvEhQKDHRha2Vu",
			"X3Jld2FyZBgHIAEoDRIQCghzY29yZV9pZBgMIAEoDRIUCgxjaGFsbGVuZ2Vf",
			"aWQYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			ChallengeStageInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Challenge), Challenge.Parser, new string[]
			{
				"DFFMIACMHLD",
				"ScoreTwo",
				"RecordId",
				"Star",
				"StageInfo",
				"TakenReward",
				"ScoreId",
				"ChallengeId"
			}, null, null, null, null)
		}));
	}
}
