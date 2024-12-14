using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013CC RID: 5068
	public static class UnlockTutorialCsReqReflection
	{
		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x0600E1F5 RID: 57845 RVA: 0x00259215 File Offset: 0x00257415
		public static FileDescriptor Descriptor
		{
			get
			{
				return UnlockTutorialCsReqReflection.descriptor;
			}
		}

		// Token: 0x040059E8 RID: 23016
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlVbmxvY2tUdXRvcmlhbENzUmVxLnByb3RvIioKE1VubG9ja1R1dG9yaWFs" + "Q3NSZXESEwoLdHV0b3JpYWxfaWQYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UnlockTutorialCsReq), UnlockTutorialCsReq.Parser, new string[]
			{
				"TutorialId"
			}, null, null, null, null)
		}));
	}
}
