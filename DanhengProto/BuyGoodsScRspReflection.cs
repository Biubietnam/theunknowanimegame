using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200014C RID: 332
	public static class BuyGoodsScRspReflection
	{
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0002BF44 File Offset: 0x0002A144
		public static FileDescriptor Descriptor
		{
			get
			{
				return BuyGoodsScRspReflection.descriptor;
			}
		}

		// Token: 0x0400066C RID: 1644
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChNCdXlHb29kc1NjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJ7Cg1CdXlH",
			"b29kc1NjUnNwEg8KB3JldGNvZGUYAiABKA0SDgoGU2hvcElkGAYgASgNEg8K",
			"B0dvb2RzSWQYDSABKA0SFQoNR29vZHNCdXlUaW1lcxgDIAEoDRIhCg5SZXR1",
			"cm5JdGVtTGlzdBgHIAEoCzIJLkl0ZW1MaXN0Qh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BuyGoodsScRsp), BuyGoodsScRsp.Parser, new string[]
			{
				"Retcode",
				"ShopId",
				"GoodsId",
				"GoodsBuyTimes",
				"ReturnItemList"
			}, null, null, null, null)
		}));
	}
}
