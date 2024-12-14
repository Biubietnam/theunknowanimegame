using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012F2 RID: 4850
	public static class TakenChallengeRewardInfoReflection
	{
		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x0600D873 RID: 55411 RVA: 0x0024140D File Offset: 0x0023F60D
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakenChallengeRewardInfoReflection.descriptor;
			}
		}

		// Token: 0x04005660 RID: 22112
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5UYWtlbkNoYWxsZW5nZVJld2FyZEluZm8ucHJvdG8aDkl0ZW1MaXN0LnBy" + "b3RvIkkKGFRha2VuQ2hhbGxlbmdlUmV3YXJkSW5mbxISCgpzdGFyX2NvdW50" + "GAUgASgNEhkKBnJld2FyZBgLIAEoCzIJLkl0ZW1MaXN0Qh6qAhtFZ2dMaW5r" + "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakenChallengeRewardInfo), TakenChallengeRewardInfo.Parser, new string[]
			{
				"StarCount",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
