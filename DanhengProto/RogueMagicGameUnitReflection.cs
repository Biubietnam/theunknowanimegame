using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED8 RID: 3800
	public static class RogueMagicGameUnitReflection
	{
		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x0600A9E7 RID: 43495 RVA: 0x001C9C40 File Offset: 0x001C7E40
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameUnitReflection.descriptor;
			}
		}

		// Token: 0x04004561 RID: 17761
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSb2d1ZU1hZ2ljR2FtZVVuaXQucHJvdG8iOgoSUm9ndWVNYWdpY0dhbWVV" + "bml0EhUKDW1hZ2ljX3VuaXRfaWQYAyABKA0SDQoFbGV2ZWwYBSABKA1CHqoC" + "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicGameUnit), RogueMagicGameUnit.Parser, new string[]
			{
				"MagicUnitId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
