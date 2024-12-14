using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200101C RID: 4124
	public static class RogueTournStartCsReqReflection
	{
		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600B767 RID: 46951 RVA: 0x001EC05E File Offset: 0x001EA25E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournStartCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004A4A RID: 19018
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZVRvdXJuU3RhcnRDc1JlcS5wcm90byJ0ChRSb2d1ZVRvdXJuU3Rh",
			"cnRDc1JlcRIPCgdhcmVhX2lkGAUgASgNEiAKGHN0YXJ0X2RpZmZpY3VsdHlf",
			"aWRfbGlzdBgEIAMoDRIMCgR3ZWVrGA4gASgNEhsKE2Jhc2VfYXZhdGFyX2lk",
			"X2xpc3QYAiADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournStartCsReq), RogueTournStartCsReq.Parser, new string[]
			{
				"AreaId",
				"StartDifficultyIdList",
				"Week",
				"BaseAvatarIdList"
			}, null, null, null, null)
		}));
	}
}
