using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200013E RID: 318
	public static class BoxingClubRewardScNotifyReflection
	{
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0002A75D File Offset: 0x0002895D
		public static FileDescriptor Descriptor
		{
			get
			{
				return BoxingClubRewardScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000629 RID: 1577
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5Cb3hpbmdDbHViUmV3YXJkU2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnBy",
			"b3RvInAKGEJveGluZ0NsdWJSZXdhcmRTY05vdGlmeRIZCgZyZXdhcmQYDSAB",
			"KAsyCS5JdGVtTGlzdBITCgtESk1LRktOQ1BKUBgBIAEoDRIUCgxjaGFsbGVu",
			"Z2VfaWQYAyABKA0SDgoGaXNfd2luGAIgASgIQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BoxingClubRewardScNotify), BoxingClubRewardScNotify.Parser, new string[]
			{
				"Reward",
				"DJMKFKNCPJP",
				"ChallengeId",
				"IsWin"
			}, null, null, null, null)
		}));
	}
}
