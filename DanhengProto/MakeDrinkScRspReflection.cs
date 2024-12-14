using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A78 RID: 2680
	public static class MakeDrinkScRspReflection
	{
		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x060076CC RID: 30412 RVA: 0x0013B378 File Offset: 0x00139578
		public static FileDescriptor Descriptor
		{
			get
			{
				return MakeDrinkScRspReflection.descriptor;
			}
		}

		// Token: 0x04002DA5 RID: 11685
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRNYWtlRHJpbmtTY1JzcC5wcm90byJFCg5NYWtlRHJpbmtTY1JzcBISCgpO" + "ZXh0Q2hhdElkGAYgASgNEg4KBklzU3VjYxgEIAEoCBIPCgdyZXRjb2RlGA8g" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MakeDrinkScRsp), MakeDrinkScRsp.Parser, new string[]
			{
				"NextChatId",
				"IsSucc",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
