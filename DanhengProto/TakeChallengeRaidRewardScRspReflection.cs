using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012C4 RID: 4804
	public static class TakeChallengeRaidRewardScRspReflection
	{
		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x0600D64F RID: 54863 RVA: 0x0023BA9A File Offset: 0x00239C9A
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeChallengeRaidRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04005596 RID: 21910
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJUYWtlQ2hhbGxlbmdlUmFpZFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJdChxUYWtlQ2hhbGxlbmdlUmFpZFJld2FyZFNjUnNwEg8KB3Jl",
			"dGNvZGUYDyABKA0SEQoJcmV3YXJkX2lkGAogASgNEhkKBnJld2FyZBgJIAEo",
			"CzIJLkl0ZW1MaXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeChallengeRaidRewardScRsp), TakeChallengeRaidRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"RewardId",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
