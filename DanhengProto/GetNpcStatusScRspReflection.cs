using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200074E RID: 1870
	public static class GetNpcStatusScRspReflection
	{
		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x060053A1 RID: 21409 RVA: 0x000E1342 File Offset: 0x000DF542
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetNpcStatusScRspReflection.descriptor;
			}
		}

		// Token: 0x040020E0 RID: 8416
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXROcGNTdGF0dXNTY1JzcC5wcm90bxoPTnBjU3RhdHVzLnByb3RvIkkK" + "EUdldE5wY1N0YXR1c1NjUnNwEg8KB3JldGNvZGUYCCABKA0SIwoPbnBjX3N0" + "YXR1c19saXN0GAwgAygLMgouTnBjU3RhdHVzQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			NpcStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcStatusScRsp), GetNpcStatusScRsp.Parser, new string[]
			{
				"Retcode",
				"NpcStatusList"
			}, null, null, null, null)
		}));
	}
}
