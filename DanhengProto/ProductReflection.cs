using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D04 RID: 3332
	public static class ProductReflection
	{
		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x060094E1 RID: 38113 RVA: 0x0018BB58 File Offset: 0x00189D58
		public static FileDescriptor Descriptor
		{
			get
			{
				return ProductReflection.descriptor;
			}
		}

		// Token: 0x040039A7 RID: 14759
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg1Qcm9kdWN0LnByb3RvGhVQcm9kdWN0R2lmdFR5cGUucHJvdG8imQEKB1By",
			"b2R1Y3QSEwoLRkZLS0tGSkxJUEIYCiABKAkSEwoLTE9FUEdEQ0RDQkoYCSAB",
			"KA0SJQoLRU1ESUJJS0JBTUsYBiABKA4yEC5Qcm9kdWN0R2lmdFR5cGUSEwoL",
			"TUVIUEFPQkNCREsYByABKA0SEwoLRkRHSE5LRENQQkkYDSABKAgSEwoLSk1M",
			"TklCS1BMR0IYBCABKAlCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ProductGiftTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Product), Product.Parser, new string[]
			{
				"FFKKKFJLIPB",
				"LOEPGDCDCBJ",
				"EMDIBIKBAMK",
				"MEHPAOBCBDK",
				"FDGHNKDCPBI",
				"JMLNIBKPLGB"
			}, null, null, null, null)
		}));
	}
}
