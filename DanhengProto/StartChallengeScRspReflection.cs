using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011A6 RID: 4518
	public static class StartChallengeScRspReflection
	{
		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600C9B9 RID: 51641 RVA: 0x0021CFBF File Offset: 0x0021B1BF
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartChallengeScRspReflection.descriptor;
			}
		}

		// Token: 0x0400515A RID: 20826
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlTdGFydENoYWxsZW5nZVNjUnNwLnByb3RvGhBMaW5ldXBJbmZvLnByb3Rv",
			"GhhDaGFsbGVuZ2VTdGFnZUluZm8ucHJvdG8aEkN1ckNoYWxsZW5nZS5wcm90",
			"bxoPU2NlbmVJbmZvLnByb3RvIrIBChNTdGFydENoYWxsZW5nZVNjUnNwEicK",
			"CnN0YWdlX2luZm8YCCABKAsyEy5DaGFsbGVuZ2VTdGFnZUluZm8SGQoFc2Nl",
			"bmUYAiABKAsyCi5TY2VuZUluZm8SIAoLbGluZXVwX2xpc3QYDCADKAsyCy5M",
			"aW5ldXBJbmZvEiQKDWN1cl9jaGFsbGVuZ2UYBiABKAsyDS5DdXJDaGFsbGVu",
			"Z2USDwoHcmV0Y29kZRgDIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			LineupInfoReflection.Descriptor,
			ChallengeStageInfoReflection.Descriptor,
			CurChallengeReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartChallengeScRsp), StartChallengeScRsp.Parser, new string[]
			{
				"StageInfo",
				"Scene",
				"LineupList",
				"CurChallenge",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
