using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B0A RID: 2826
	public static class MonopolyBuyGoodsCsReqReflection
	{
		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x06007D22 RID: 32034 RVA: 0x0014B5E0 File Offset: 0x001497E0
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyBuyGoodsCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400301A RID: 12314
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNb25vcG9seUJ1eUdvb2RzQ3NSZXEucHJvdG8iOgoVTW9ub3BvbHlCdXlH" + "b29kc0NzUmVxEg8KB3Nob3BfaWQYByABKA0SEAoIZ29vZHNfaWQYBiABKA1C" + "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyBuyGoodsCsReq), MonopolyBuyGoodsCsReq.Parser, new string[]
			{
				"ShopId",
				"GoodsId"
			}, null, null, null, null)
		}));
	}
}
