using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006AA RID: 1706
	public static class GetFirstTalkByPerformanceNpcScRspReflection
	{
		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x000CF410 File Offset: 0x000CD610
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFirstTalkByPerformanceNpcScRspReflection.descriptor;
			}
		}

		// Token: 0x04001E3C RID: 7740
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidHZXRGaXJzdFRhbGtCeVBlcmZvcm1hbmNlTnBjU2NSc3AucHJvdG8aIE5w",
			"Y01lZXRCeVBlcmZvcm1hbmNlU3RhdHVzLnByb3RvIm8KIUdldEZpcnN0VGFs",
			"a0J5UGVyZm9ybWFuY2VOcGNTY1JzcBI5ChRucGNfbWVldF9zdGF0dXNfbGlz",
			"dBgGIAMoCzIbLk5wY01lZXRCeVBlcmZvcm1hbmNlU3RhdHVzEg8KB3JldGNv",
			"ZGUYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			NpcMeetByPerformanceStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFirstTalkByPerformanceNpcScRsp), GetFirstTalkByPerformanceNpcScRsp.Parser, new string[]
			{
				"NpcMeetStatusList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
