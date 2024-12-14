using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A8A RID: 2698
	public static class MarkItemScRspReflection
	{
		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x060077A5 RID: 30629 RVA: 0x0013D44D File Offset: 0x0013B64D
		public static FileDescriptor Descriptor
		{
			get
			{
				return MarkItemScRspReflection.descriptor;
			}
		}

		// Token: 0x04002DEE RID: 11758
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNNYXJrSXRlbVNjUnNwLnByb3RvIkYKDU1hcmtJdGVtU2NSc3ASEwoLRkJF" + "SElDQktDQU0YDyABKAgSDwoHaXRlbV9pZBgDIAEoDRIPCgdyZXRjb2RlGAIg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MarkItemScRsp), MarkItemScRsp.Parser, new string[]
			{
				"FBEHICBKCAM",
				"ItemId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
