using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006C0 RID: 1728
	public static class GetFriendChallengeLineupCsReqReflection
	{
		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06004D62 RID: 19810 RVA: 0x000D1C88 File Offset: 0x000CFE88
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendChallengeLineupCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001E9D RID: 7837
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHZXRGcmllbmRDaGFsbGVuZ2VMaW5ldXBDc1JlcS5wcm90byI1Ch1HZXRG" + "cmllbmRDaGFsbGVuZ2VMaW5ldXBDc1JlcRIUCgxjaGFsbGVuZ2VfaWQYDCAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendChallengeLineupCsReq), GetFriendChallengeLineupCsReq.Parser, new string[]
			{
				"ChallengeId"
			}, null, null, null, null)
		}));
	}
}
