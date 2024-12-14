using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001316 RID: 4886
	public static class TakeQuestOptionalRewardScRspReflection
	{
		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x0600DA07 RID: 55815 RVA: 0x00244CBD File Offset: 0x00242EBD
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeQuestOptionalRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040056D8 RID: 22232
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJUYWtlUXVlc3RPcHRpb25hbFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJcChxUYWtlUXVlc3RPcHRpb25hbFJld2FyZFNjUnNwEhkKBnJl",
			"d2FyZBgOIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYASABKA0SEAoIcXVl",
			"c3RfaWQYDyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeQuestOptionalRewardScRsp), TakeQuestOptionalRewardScRsp.Parser, new string[]
			{
				"Reward",
				"Retcode",
				"QuestId"
			}, null, null, null, null)
		}));
	}
}
