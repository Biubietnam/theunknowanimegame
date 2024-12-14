using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007DA RID: 2010
	public static class GetRollShopInfoScRspReflection
	{
		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x000EF2D6 File Offset: 0x000ED4D6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRollShopInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x040022D1 RID: 8913
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpHZXRSb2xsU2hvcEluZm9TY1JzcC5wcm90byJvChRHZXRSb2xsU2hvcElu",
			"Zm9TY1JzcBIUCgxnYWNoYV9yYW5kb20YBCABKA0SGgoSc2hvcF9ncm91cF9p",
			"ZF9saXN0GA4gAygNEg8KB3JldGNvZGUYCiABKA0SFAoMcm9sbF9zaG9wX2lk",
			"GAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRollShopInfoScRsp), GetRollShopInfoScRsp.Parser, new string[]
			{
				"GachaRandom",
				"ShopGroupIdList",
				"Retcode",
				"RollShopId"
			}, null, null, null, null)
		}));
	}
}
