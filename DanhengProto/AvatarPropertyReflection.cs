using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C6 RID: 198
	public static class AvatarPropertyReflection
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0001A711 File Offset: 0x00018911
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarPropertyReflection.descriptor;
			}
		}

		// Token: 0x040003A1 RID: 929
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRBdmF0YXJQcm9wZXJ0eS5wcm90byKCAQoOQXZhdGFyUHJvcGVydHkSDgoG",
			"bWF4X2hwGAEgASgBEg4KBmF0dGFjaxgCIAEoARIPCgdkZWZlbmNlGAMgASgB",
			"Eg0KBXNwZWVkGAQgASgBEg8KB2xlZnRfaHAYBSABKAESDwoHbGVmdF9zcBgG",
			"IAEoARIOCgZtYXhfc3AYByABKAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarProperty), AvatarProperty.Parser, new string[]
			{
				"MaxHp",
				"Attack",
				"Defence",
				"Speed",
				"LeftHp",
				"LeftSp",
				"MaxSp"
			}, null, null, null, null)
		}));
	}
}
