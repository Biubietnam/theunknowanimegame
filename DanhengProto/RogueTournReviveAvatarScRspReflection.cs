using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200100A RID: 4106
	public static class RogueTournReviveAvatarScRspReflection
	{
		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600B6B8 RID: 46776 RVA: 0x001EA26B File Offset: 0x001E846B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournReviveAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x04004A03 RID: 18947
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSb2d1ZVRvdXJuUmV2aXZlQXZhdGFyU2NSc3AucHJvdG8aEkl0ZW1Db3N0",
			"RGF0YS5wcm90byJYChtSb2d1ZVRvdXJuUmV2aXZlQXZhdGFyU2NSc3ASKAoR",
			"cm9ndWVfcmV2aXZlX2Nvc3QYDSABKAsyDS5JdGVtQ29zdERhdGESDwoHcmV0",
			"Y29kZRgIIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournReviveAvatarScRsp), RogueTournReviveAvatarScRsp.Parser, new string[]
			{
				"RogueReviveCost",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
