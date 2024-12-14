using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004D4 RID: 1236
	public static class ExchangeGachaCeilingScRspReflection
	{
		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x00097BAD File Offset: 0x00095DAD
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExchangeGachaCeilingScRspReflection.descriptor;
			}
		}

		// Token: 0x040015EB RID: 5611
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9FeGNoYW5nZUdhY2hhQ2VpbGluZ1NjUnNwLnByb3RvGhJHYWNoYUNlaWxp",
			"bmcucHJvdG8aDkl0ZW1MaXN0LnByb3RvIqABChlFeGNoYW5nZUdhY2hhQ2Vp",
			"bGluZ1NjUnNwEiQKDWdhY2hhX2NlaWxpbmcYDSABKAsyDS5HYWNoYUNlaWxp",
			"bmcSEQoJYXZhdGFyX2lkGAYgASgNEg8KB3JldGNvZGUYBSABKA0SJQoSdHJh",
			"bnNmZXJfaXRlbV9saXN0GAkgASgLMgkuSXRlbUxpc3QSEgoKZ2FjaGFfdHlw",
			"ZRgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			GachaCeilingReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeGachaCeilingScRsp), ExchangeGachaCeilingScRsp.Parser, new string[]
			{
				"GachaCeiling",
				"AvatarId",
				"Retcode",
				"TransferItemList",
				"GachaType"
			}, null, null, null, null)
		}));
	}
}
