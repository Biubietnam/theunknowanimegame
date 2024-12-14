using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A8E RID: 2702
	public static class MarkReadMailScRspReflection
	{
		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x060077D3 RID: 30675 RVA: 0x0013DA9A File Offset: 0x0013BC9A
		public static FileDescriptor Descriptor
		{
			get
			{
				return MarkReadMailScRspReflection.descriptor;
			}
		}

		// Token: 0x04002DFC RID: 11772
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdNYXJrUmVhZE1haWxTY1JzcC5wcm90byIwChFNYXJrUmVhZE1haWxTY1Jz" + "cBIKCgJpZBgFIAEoDRIPCgdyZXRjb2RlGAQgASgNQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MarkReadMailScRsp), MarkReadMailScRsp.Parser, new string[]
			{
				"Id",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
