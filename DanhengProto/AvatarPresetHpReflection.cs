using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C4 RID: 196
	public static class AvatarPresetHpReflection
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0001A3DD File Offset: 0x000185DD
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarPresetHpReflection.descriptor;
			}
		}

		// Token: 0x0400039A RID: 922
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRBdmF0YXJQcmVzZXRIcC5wcm90byI4Cg5BdmF0YXJQcmVzZXRIcBIRCglh" + "dmF0YXJfaWQYAiABKA0SEwoLRk1IRUNGSkVHSUIYDiABKA1CHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarPresetHp), AvatarPresetHp.Parser, new string[]
			{
				"AvatarId",
				"FMHECFJEGIB"
			}, null, null, null, null)
		}));
	}
}
