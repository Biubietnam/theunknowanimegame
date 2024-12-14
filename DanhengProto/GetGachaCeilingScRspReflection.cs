using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006D6 RID: 1750
	public static class GetGachaCeilingScRspReflection
	{
		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x000D3EE2 File Offset: 0x000D20E2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetGachaCeilingScRspReflection.descriptor;
			}
		}

		// Token: 0x04001EED RID: 7917
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpHZXRHYWNoYUNlaWxpbmdTY1JzcC5wcm90bxoSR2FjaGFDZWlsaW5nLnBy",
			"b3RvImEKFEdldEdhY2hhQ2VpbGluZ1NjUnNwEiQKDWdhY2hhX2NlaWxpbmcY",
			"CSABKAsyDS5HYWNoYUNlaWxpbmcSEgoKZ2FjaGFfdHlwZRgLIAEoDRIPCgdy",
			"ZXRjb2RlGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			GachaCeilingReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetGachaCeilingScRsp), GetGachaCeilingScRsp.Parser, new string[]
			{
				"GachaCeiling",
				"GachaType",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
