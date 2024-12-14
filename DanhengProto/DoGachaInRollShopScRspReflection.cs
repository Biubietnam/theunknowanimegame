using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003C4 RID: 964
	public static class DoGachaInRollShopScRspReflection
	{
		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000777B4 File Offset: 0x000759B4
		public static FileDescriptor Descriptor
		{
			get
			{
				return DoGachaInRollShopScRspReflection.descriptor;
			}
		}

		// Token: 0x04001165 RID: 4453
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxEb0dhY2hhSW5Sb2xsU2hvcFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90",
			"byKMAQoWRG9HYWNoYUluUm9sbFNob3BTY1JzcBIZCgZyZXdhcmQYDyABKAsy",
			"CS5JdGVtTGlzdBIUCgxyb2xsX3Nob3BfaWQYDSABKA0SGwoTcmV3YXJkX2Rp",
			"c3BsYXlfdHlwZRgEIAEoDRIPCgdyZXRjb2RlGAkgASgNEhMKC0tFQUNHTUxL",
			"QkRLGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaInRollShopScRsp), DoGachaInRollShopScRsp.Parser, new string[]
			{
				"Reward",
				"RollShopId",
				"RewardDisplayType",
				"Retcode",
				"KEACGMLKBDK"
			}, null, null, null, null)
		}));
	}
}
