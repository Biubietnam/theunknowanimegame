using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004E4 RID: 1252
	public static class ExchangeStaminaScRspReflection
	{
		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x0009959A File Offset: 0x0009779A
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExchangeStaminaScRspReflection.descriptor;
			}
		}

		// Token: 0x04001621 RID: 5665
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpFeGNoYW5nZVN0YW1pbmFTY1JzcC5wcm90bxoOSXRlbUNvc3QucHJvdG8i",
			"kgEKFEV4Y2hhbmdlU3RhbWluYVNjUnNwEhkKEWxhc3RfcmVjb3Zlcl90aW1l",
			"GAEgASgDEhMKC3N0YW1pbmFfYWRkGAggASgNEhYKDmV4Y2hhbmdlX3RpbWVz",
			"GAcgASgNEiEKDml0ZW1fY29zdF9saXN0GAMgAygLMgkuSXRlbUNvc3QSDwoH",
			"cmV0Y29kZRgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemCostReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeStaminaScRsp), ExchangeStaminaScRsp.Parser, new string[]
			{
				"LastRecoverTime",
				"StaminaAdd",
				"ExchangeTimes",
				"ItemCostList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
