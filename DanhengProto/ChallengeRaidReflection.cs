using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001AE RID: 430
	public static class ChallengeRaidReflection
	{
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x00037D90 File Offset: 0x00035F90
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeRaidReflection.descriptor;
			}
		}

		// Token: 0x04000828 RID: 2088
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNDaGFsbGVuZ2VSYWlkLnByb3RvIjMKDUNoYWxsZW5nZVJhaWQSEQoJbWF4" + "X3Njb3JlGAYgASgNEg8KB3JhaWRfaWQYBCABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeRaid), ChallengeRaid.Parser, new string[]
			{
				"MaxScore",
				"RaidId"
			}, null, null, null, null)
		}));
	}
}
