using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200049C RID: 1180
	public static class EvolveBuildAvatarReflection
	{
		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x0600349A RID: 13466 RVA: 0x0009060D File Offset: 0x0008E80D
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildAvatarReflection.descriptor;
			}
		}

		// Token: 0x040014E0 RID: 5344
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdFdm9sdmVCdWlsZEF2YXRhci5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJX" + "ChFFdm9sdmVCdWlsZEF2YXRhchIOCgZkYW1hZ2UYCyABKAESHwoKQXZhdGFy" + "VHlwZRgOIAEoDjILLkF2YXRhclR5cGUSEQoJYXZhdGFyX2lkGAggASgNQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildAvatar), EvolveBuildAvatar.Parser, new string[]
			{
				"Damage",
				"AvatarType",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
