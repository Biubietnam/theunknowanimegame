using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B0C RID: 2828
	public static class MonopolyBuyGoodsScRspReflection
	{
		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x06007D39 RID: 32057 RVA: 0x0014B915 File Offset: 0x00149B15
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyBuyGoodsScRspReflection.descriptor;
			}
		}

		// Token: 0x04003021 RID: 12321
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNb25vcG9seUJ1eUdvb2RzU2NSc3AucHJvdG8iSwoVTW9ub3BvbHlCdXlH" + "b29kc1NjUnNwEg8KB3Nob3BfaWQYBSABKA0SEAoIZ29vZHNfaWQYDSABKA0S" + "DwoHcmV0Y29kZRgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyBuyGoodsScRsp), MonopolyBuyGoodsScRsp.Parser, new string[]
			{
				"ShopId",
				"GoodsId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
