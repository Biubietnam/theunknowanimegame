using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007CA RID: 1994
	public static class GetRogueScoreRewardInfoScRspReflection
	{
		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060058F2 RID: 22770 RVA: 0x000ED652 File Offset: 0x000EB852
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRogueScoreRewardInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04002297 RID: 8855
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJHZXRSb2d1ZVNjb3JlUmV3YXJkSW5mb1NjUnNwLnByb3RvGhpSb2d1ZVNj",
			"b3JlUmV3YXJkSW5mby5wcm90byJUChxHZXRSb2d1ZVNjb3JlUmV3YXJkSW5m",
			"b1NjUnNwEiMKBGluZm8YCyABKAsyFS5Sb2d1ZVNjb3JlUmV3YXJkSW5mbxIP",
			"CgdyZXRjb2RlGA0gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueScoreRewardInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueScoreRewardInfoScRsp), GetRogueScoreRewardInfoScRsp.Parser, new string[]
			{
				"Info",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
