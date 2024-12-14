using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001336 RID: 4918
	public static class TakeRollShopRewardScRspReflection
	{
		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x0600DB7E RID: 56190 RVA: 0x0024894E File Offset: 0x00246B4E
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeRollShopRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04005761 RID: 22369
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1UYWtlUm9sbFNob3BSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv",
			"dG8ibAoXVGFrZVJvbGxTaG9wUmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgCIAEo",
			"DRISCgpSb2xsU2hvcElkGAEgASgNEhEKCUdyb3VwVHlwZRgLIAEoDRIZCgZy",
			"ZXdhcmQYCCABKAsyCS5JdGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeRollShopRewardScRsp), TakeRollShopRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"RollShopId",
				"GroupType",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
