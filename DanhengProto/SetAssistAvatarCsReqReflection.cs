using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010C8 RID: 4296
	public static class SetAssistAvatarCsReqReflection
	{
		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600BF99 RID: 49049 RVA: 0x00203D5C File Offset: 0x00201F5C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetAssistAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004DC3 RID: 19907
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRBc3Npc3RBdmF0YXJDc1JlcS5wcm90byJBChRTZXRBc3Npc3RBdmF0" + "YXJDc1JlcRIWCg5hdmF0YXJfaWRfbGlzdBgCIAMoDRIRCglhdmF0YXJfaWQY" + "CiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetAssistAvatarCsReq), SetAssistAvatarCsReq.Parser, new string[]
			{
				"AvatarIdList",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
