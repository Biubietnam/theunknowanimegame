using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000382 RID: 898
	public static class DelMailScRspReflection
	{
		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x0006F3F4 File Offset: 0x0006D5F4
		public static FileDescriptor Descriptor
		{
			get
			{
				return DelMailScRspReflection.descriptor;
			}
		}

		// Token: 0x04001014 RID: 4116
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJEZWxNYWlsU2NSc3AucHJvdG8iLwoMRGVsTWFpbFNjUnNwEg4KBklkTGlz" + "dBgLIAMoDRIPCgdyZXRjb2RlGAMgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DelMailScRsp), DelMailScRsp.Parser, new string[]
			{
				"IdList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
