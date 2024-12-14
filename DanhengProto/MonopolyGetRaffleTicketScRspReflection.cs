using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B46 RID: 2886
	public static class MonopolyGetRaffleTicketScRspReflection
	{
		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x06007FCA RID: 32714 RVA: 0x001517FE File Offset: 0x0014F9FE
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyGetRaffleTicketScRspReflection.descriptor;
			}
		}

		// Token: 0x040030EA RID: 12522
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJNb25vcG9seUdldFJhZmZsZVRpY2tldFNjUnNwLnByb3RvGhFLSEJBRk5P",
			"RUpPRS5wcm90byJjChxNb25vcG9seUdldFJhZmZsZVRpY2tldFNjUnNwEiEK",
			"C1BDSUhKRExJQ0dLGAEgAygLMgwuS0hCQUZOT0VKT0USDwoHcG9vbF9pZBgL",
			"IAEoDRIPCgdyZXRjb2RlGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			KHBAFNOEJOEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGetRaffleTicketScRsp), MonopolyGetRaffleTicketScRsp.Parser, new string[]
			{
				"PCIHJDLICGK",
				"PoolId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
