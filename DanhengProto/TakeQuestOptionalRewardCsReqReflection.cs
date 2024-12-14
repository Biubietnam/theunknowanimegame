using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001314 RID: 4884
	public static class TakeQuestOptionalRewardCsReqReflection
	{
		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x0600D9F0 RID: 55792 RVA: 0x00244984 File Offset: 0x00242B84
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeQuestOptionalRewardCsReqReflection.descriptor;
			}
		}

		// Token: 0x040056D1 RID: 22225
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlUXVlc3RPcHRpb25hbFJld2FyZENzUmVxLnByb3RvIkwKHFRha2VR" + "dWVzdE9wdGlvbmFsUmV3YXJkQ3NSZXESEAoIcXVlc3RfaWQYDCABKA0SGgoS" + "b3B0aW9uYWxfcmV3YXJkX2lkGAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeQuestOptionalRewardCsReq), TakeQuestOptionalRewardCsReq.Parser, new string[]
			{
				"QuestId",
				"OptionalRewardId"
			}, null, null, null, null)
		}));
	}
}
