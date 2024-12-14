using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200010E RID: 270
	public static class BCCJGMONBKGReflection
	{
		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0002498E File Offset: 0x00022B8E
		public static FileDescriptor Descriptor
		{
			get
			{
				return BCCJGMONBKGReflection.descriptor;
			}
		}

		// Token: 0x0400054F RID: 1359
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFCQ0NKR01PTkJLRy5wcm90bxoZQ2hhbGxlbmdlU3RhdGlzdGljcy5wcm90",
			"bxoeQ2hhbGxlbmdlU3RvcnlTdGF0aXN0aWNzLnByb3RvGh1DaGFsbGVuZ2VC",
			"b3NzU3RhdGlzdGljcy5wcm90byLOAQoLQkNDSkdNT05CS0cSEwoLTU1MQkZQ",
			"TlBIQ0wYCyABKA0SEAoIZ3JvdXBfaWQYBiABKA0SMAoRY2hhbGxlbmdlX2Rl",
			"ZmF1bHQY8gUgASgLMhQuQ2hhbGxlbmdlU3RhdGlzdGljcxIzCg9jaGFsbGVu",
			"Z2Vfc3RvcnkYqQMgASgLMhkuQ2hhbGxlbmdlU3RvcnlTdGF0aXN0aWNzEjEK",
			"DmNoYWxsZW5nZV9ib3NzGOoBIAEoCzIYLkNoYWxsZW5nZUJvc3NTdGF0aXN0",
			"aWNzQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChallengeStatisticsReflection.Descriptor,
			ChallengeStoryStatisticsReflection.Descriptor,
			ChallengeBossStatisticsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BCCJGMONBKG), BCCJGMONBKG.Parser, new string[]
			{
				"MMLBFPNPHCL",
				"GroupId",
				"ChallengeDefault",
				"ChallengeStory",
				"ChallengeBoss"
			}, null, null, null, null)
		}));
	}
}
