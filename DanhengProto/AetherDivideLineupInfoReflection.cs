using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000054 RID: 84
	public static class AetherDivideLineupInfoReflection
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000B005 File Offset: 0x00009205
		public static FileDescriptor Descriptor
		{
			get
			{
				return AetherDivideLineupInfoReflection.descriptor;
			}
		}

		// Token: 0x04000156 RID: 342
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxBZXRoZXJEaXZpZGVMaW5ldXBJbmZvLnByb3RvIkIKFkFldGhlckRpdmlk" + "ZUxpbmV1cEluZm8SGgoSYWV0aGVyX2F2YXRhcl9saXN0GA0gAygNEgwKBHNs" + "b3QYCCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideLineupInfo), AetherDivideLineupInfo.Parser, new string[]
			{
				"AetherAvatarList",
				"Slot"
			}, null, null, null, null)
		}));
	}
}
