using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003C6 RID: 966
	public static class DoGachaScRspReflection
	{
		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x00077D71 File Offset: 0x00075F71
		public static FileDescriptor Descriptor
		{
			get
			{
				return DoGachaScRspReflection.descriptor;
			}
		}

		// Token: 0x04001172 RID: 4466
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJEb0dhY2hhU2NSc3AucHJvdG8aD0dhY2hhSXRlbS5wcm90byLSAQoMRG9H",
			"YWNoYVNjUnNwEhMKC0tFQUNHTUxLQkRLGA4gASgNEhMKC1BKQUZJTU1DUERG",
			"GAIgASgNEhMKC0hOUENQREpQR0xMGA0gASgNEhEKCWdhY2hhX251bRgLIAEo",
			"DRIQCghnYWNoYV9pZBgFIAEoDRITCgtjZWlsaW5nX251bRgBIAEoDRITCgtM",
			"SE1CTk1JT0tIQhgPIAEoDRIPCgdyZXRjb2RlGAYgASgNEiMKD2dhY2hhX2l0",
			"ZW1fbGlzdBgIIAMoCzIKLkdhY2hhSXRlbUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			GachaItemReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaScRsp), DoGachaScRsp.Parser, new string[]
			{
				"KEACGMLKBDK",
				"PJAFIMMCPDF",
				"HNPCPDJPGLL",
				"GachaNum",
				"GachaId",
				"CeilingNum",
				"LHMBNMIOKHB",
				"Retcode",
				"GachaItemList"
			}, null, null, null, null)
		}));
	}
}
