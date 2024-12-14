using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C98 RID: 3224
	public static class PickRogueAvatarScRspReflection
	{
		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x06008F66 RID: 36710 RVA: 0x0017AF9B File Offset: 0x0017919B
		public static FileDescriptor Descriptor
		{
			get
			{
				return PickRogueAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x04003715 RID: 14101
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpQaWNrUm9ndWVBdmF0YXJTY1JzcC5wcm90byJiChRQaWNrUm9ndWVBdmF0" + "YXJTY1JzcBIcChR0cmlhbF9hdmF0YXJfaWRfbGlzdBgCIAMoDRIbChNiYXNl" + "X2F2YXRhcl9pZF9saXN0GAQgAygNEg8KB3JldGNvZGUYCCABKA1CHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PickRogueAvatarScRsp), PickRogueAvatarScRsp.Parser, new string[]
			{
				"TrialAvatarIdList",
				"BaseAvatarIdList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
