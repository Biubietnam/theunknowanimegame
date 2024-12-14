using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200000E RID: 14
	public static class AcceptActivityExpeditionScRspReflection
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002EC5 File Offset: 0x000010C5
		public static FileDescriptor Descriptor
		{
			get
			{
				return AcceptActivityExpeditionScRspReflection.descriptor;
			}
		}

		// Token: 0x0400002B RID: 43
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNBY2NlcHRBY3Rpdml0eUV4cGVkaXRpb25TY1JzcC5wcm90bxoYQWN0aXZp",
			"dHlFeHBlZGl0aW9uLnByb3RvIloKHUFjY2VwdEFjdGl2aXR5RXhwZWRpdGlv",
			"blNjUnNwEg8KB3JldGNvZGUYDSABKA0SKAoLTkFDSkdGQUZDR0UYAiABKAsy",
			"Ey5BY3Rpdml0eUV4cGVkaXRpb25CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ActivityExpeditionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AcceptActivityExpeditionScRsp), AcceptActivityExpeditionScRsp.Parser, new string[]
			{
				"Retcode",
				"NACJGFAFCGE"
			}, null, null, null, null)
		}));
	}
}
