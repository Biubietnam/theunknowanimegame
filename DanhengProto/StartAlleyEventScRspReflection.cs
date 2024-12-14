using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200119A RID: 4506
	public static class StartAlleyEventScRspReflection
	{
		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600C92D RID: 51501 RVA: 0x0021B9E1 File Offset: 0x00219BE1
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartAlleyEventScRspReflection.descriptor;
			}
		}

		// Token: 0x0400512A RID: 20778
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTdGFydEFsbGV5RXZlbnRTY1JzcC5wcm90byI5ChRTdGFydEFsbGV5RXZl" + "bnRTY1JzcBIPCgdyZXRjb2RlGAcgASgNEhAKCGV2ZW50X2lkGA4gASgNQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartAlleyEventScRsp), StartAlleyEventScRsp.Parser, new string[]
			{
				"Retcode",
				"EventId"
			}, null, null, null, null)
		}));
	}
}
