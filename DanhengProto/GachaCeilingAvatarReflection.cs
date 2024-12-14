using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005CE RID: 1486
	public static class GachaCeilingAvatarReflection
	{
		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06004254 RID: 16980 RVA: 0x000B48FD File Offset: 0x000B2AFD
		public static FileDescriptor Descriptor
		{
			get
			{
				return GachaCeilingAvatarReflection.descriptor;
			}
		}

		// Token: 0x04001A55 RID: 6741
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHYWNoYUNlaWxpbmdBdmF0YXIucHJvdG8iPAoSR2FjaGFDZWlsaW5nQXZh" + "dGFyEhMKC1JlcGVhdGVkQ250GAkgASgNEhEKCWF2YXRhcl9pZBgNIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GachaCeilingAvatar), GachaCeilingAvatar.Parser, new string[]
			{
				"RepeatedCnt",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
