using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000642 RID: 1602
	public static class GetChallengeRaidInfoScRspReflection
	{
		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x000C4D8A File Offset: 0x000C2F8A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChallengeRaidInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001CC0 RID: 7360
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9HZXRDaGFsbGVuZ2VSYWlkSW5mb1NjUnNwLnByb3RvGhNDaGFsbGVuZ2VS",
			"YWlkLnByb3RvInwKGUdldENoYWxsZW5nZVJhaWRJbmZvU2NSc3ASHAoUdGFr",
			"ZW5fcmV3YXJkX2lkX2xpc3QYCyADKA0SMAoYY2hhbGxlbmdlX3JhaWRfZGF0",
			"YV9saXN0GAEgAygLMg4uQ2hhbGxlbmdlUmFpZBIPCgdyZXRjb2RlGAIgASgN",
			"Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChallengeRaidReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengeRaidInfoScRsp), GetChallengeRaidInfoScRsp.Parser, new string[]
			{
				"TakenRewardIdList",
				"ChallengeRaidDataList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
