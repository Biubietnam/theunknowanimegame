using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003D2 RID: 978
	public static class DressAvatarScRspReflection
	{
		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x00079559 File Offset: 0x00077759
		public static FileDescriptor Descriptor
		{
			get
			{
				return DressAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x040011AB RID: 4523
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEcmVzc0F2YXRhclNjUnNwLnByb3RvIiMKEERyZXNzQXZhdGFyU2NSc3AS" + "DwoHcmV0Y29kZRgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DressAvatarScRsp), DressAvatarScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
