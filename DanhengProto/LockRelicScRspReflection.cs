using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A5A RID: 2650
	public static class LockRelicScRspReflection
	{
		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06007587 RID: 30087 RVA: 0x001381E1 File Offset: 0x001363E1
		public static FileDescriptor Descriptor
		{
			get
			{
				return LockRelicScRspReflection.descriptor;
			}
		}

		// Token: 0x04002D34 RID: 11572
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMb2NrUmVsaWNTY1JzcC5wcm90byIhCg5Mb2NrUmVsaWNTY1JzcBIPCgdy" + "ZXRjb2RlGA4gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LockRelicScRsp), LockRelicScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
