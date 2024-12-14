using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004D8 RID: 1240
	public static class ExchangeHcoinScRspReflection
	{
		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x00098426 File Offset: 0x00096626
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExchangeHcoinScRspReflection.descriptor;
			}
		}

		// Token: 0x040015FD RID: 5629
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhFeGNoYW5nZUhjb2luU2NSc3AucHJvdG8iMgoSRXhjaGFuZ2VIY29pblNj" + "UnNwEgsKA251bRgPIAEoDRIPCgdyZXRjb2RlGA4gASgNQh6qAhtFZ2dMaW5r" + "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeHcoinScRsp), ExchangeHcoinScRsp.Parser, new string[]
			{
				"Num",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
