using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007C6 RID: 1990
	public static class GetRogueInitialScoreScRspReflection
	{
		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x000ED0EE File Offset: 0x000EB2EE
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRogueInitialScoreScRspReflection.descriptor;
			}
		}

		// Token: 0x0400228D RID: 8845
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9HZXRSb2d1ZUluaXRpYWxTY29yZVNjUnNwLnByb3RvGhpSb2d1ZVNjb3Jl",
			"UmV3YXJkSW5mby5wcm90byJkChlHZXRSb2d1ZUluaXRpYWxTY29yZVNjUnNw",
			"Eg8KB3JldGNvZGUYAyABKA0SNgoXcm9ndWVfc2NvcmVfcmV3YXJkX2luZm8Y",
			"DyABKAsyFS5Sb2d1ZVNjb3JlUmV3YXJkSW5mb0IeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueScoreRewardInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueInitialScoreScRsp), GetRogueInitialScoreScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueScoreRewardInfo"
			}, null, null, null, null)
		}));
	}
}
