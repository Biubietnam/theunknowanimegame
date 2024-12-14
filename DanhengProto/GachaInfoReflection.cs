using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005D0 RID: 1488
	public static class GachaInfoReflection
	{
		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x0600426B RID: 17003 RVA: 0x000B4C31 File Offset: 0x000B2E31
		public static FileDescriptor Descriptor
		{
			get
			{
				return GachaInfoReflection.descriptor;
			}
		}

		// Token: 0x04001A5C RID: 6748
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg9HYWNoYUluZm8ucHJvdG8aEkdhY2hhQ2VpbGluZy5wcm90byL8AQoJR2Fj",
			"aGFJbmZvEhIKCmJlZ2luX3RpbWUYDyABKAMSEAoIZW5kX3RpbWUYAiABKAMS",
			"EwoLSE5QQ1BESlBHTEwYCyABKA0SJAoNZ2FjaGFfY2VpbGluZxgJIAEoCzIN",
			"LkdhY2hhQ2VpbGluZxITCgtMSE1CTk1JT0tIQhgMIAEoDRIQCghnYWNoYV9p",
			"ZBgNIAEoDRIYChBpdGVtX2RldGFpbF9saXN0GAYgAygNEhcKD3ByaXplX2l0",
			"ZW1fbGlzdBgIIAMoDRIWCg5kZXRhaWxfd2VidmlldxgHIAEoCRIcChRkcm9w",
			"X2hpc3Rvcnlfd2VidmlldxgEIAEoCUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			GachaCeilingReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GachaInfo), GachaInfo.Parser, new string[]
			{
				"BeginTime",
				"EndTime",
				"HNPCPDJPGLL",
				"GachaCeiling",
				"LHMBNMIOKHB",
				"GachaId",
				"ItemDetailList",
				"PrizeItemList",
				"DetailWebview",
				"DropHistoryWebview"
			}, null, null, null, null)
		}));
	}
}
