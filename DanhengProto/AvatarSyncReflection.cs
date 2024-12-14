using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000CA RID: 202
	public static class AvatarSyncReflection
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0001B208 File Offset: 0x00019408
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarSyncReflection.descriptor;
			}
		}

		// Token: 0x040003B9 RID: 953
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBBdmF0YXJTeW5jLnByb3RvGgxBdmF0YXIucHJvdG8iKgoKQXZhdGFyU3lu" + "YxIcCgthdmF0YXJfbGlzdBgDIAMoCzIHLkF2YXRhckIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			AvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarSync), AvatarSync.Parser, new string[]
			{
				"AvatarList"
			}, null, null, null, null)
		}));
	}
}
