using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200014A RID: 330
	public static class BuyGoodsCsReqReflection
	{
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0002B9D2 File Offset: 0x00029BD2
		public static FileDescriptor Descriptor
		{
			get
			{
				return BuyGoodsCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400065F RID: 1631
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChNCdXlHb29kc0NzUmVxLnByb3RvInkKDUJ1eUdvb2RzQ3NSZXESEAoIZ29v",
			"ZHNfaWQYCiABKA0SDwoHaXRlbV9pZBgMIAEoDRIRCglnb29kc19udW0YAyAB",
			"KA0SDwoHc2hvcF9pZBgCIAEoDRIhChlpbnRlcmFjdGVkX3Byb3BfZW50aXR5",
			"X2lkGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BuyGoodsCsReq), BuyGoodsCsReq.Parser, new string[]
			{
				"GoodsId",
				"ItemId",
				"GoodsNum",
				"ShopId",
				"InteractedPropEntityId"
			}, null, null, null, null)
		}));
	}
}
