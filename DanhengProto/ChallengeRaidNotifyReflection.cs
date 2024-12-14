using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B0 RID: 432
	public static class ChallengeRaidNotifyReflection
	{
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x000380C5 File Offset: 0x000362C5
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeRaidNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400082F RID: 2095
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDaGFsbGVuZ2VSYWlkTm90aWZ5LnByb3RvGhNDaGFsbGVuZ2VSYWlkLnBy" + "b3RvIj0KE0NoYWxsZW5nZVJhaWROb3RpZnkSJgoOY2hhbGxlbmdlX3JhaWQY" + "DCABKAsyDi5DaGFsbGVuZ2VSYWlkQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ChallengeRaidReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeRaidNotify), ChallengeRaidNotify.Parser, new string[]
			{
				"ChallengeRaid"
			}, null, null, null, null)
		}));
	}
}
