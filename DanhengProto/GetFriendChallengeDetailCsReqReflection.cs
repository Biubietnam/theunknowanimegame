using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006BC RID: 1724
	public static class GetFriendChallengeDetailCsReqReflection
	{
		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06004D31 RID: 19761 RVA: 0x000D147A File Offset: 0x000CF67A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendChallengeDetailCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001E8A RID: 7818
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHZXRGcmllbmRDaGFsbGVuZ2VEZXRhaWxDc1JlcS5wcm90byJCCh1HZXRG" + "cmllbmRDaGFsbGVuZ2VEZXRhaWxDc1JlcRIUCgxjaGFsbGVuZ2VfaWQYASAB" + "KA0SCwoDdWlkGAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendChallengeDetailCsReq), GetFriendChallengeDetailCsReq.Parser, new string[]
			{
				"ChallengeId",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
