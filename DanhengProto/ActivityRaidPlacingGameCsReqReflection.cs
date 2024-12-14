using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000036 RID: 54
	public static class ActivityRaidPlacingGameCsReqReflection
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00006FB3 File Offset: 0x000051B3
		public static FileDescriptor Descriptor
		{
			get
			{
				return ActivityRaidPlacingGameCsReqReflection.descriptor;
			}
		}

		// Token: 0x040000BD RID: 189
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJBY3Rpdml0eVJhaWRQbGFjaW5nR2FtZUNzUmVxLnByb3RvGhZBbGxleVBs",
			"YWNpbmdTaGlwLnByb3RvInAKHEFjdGl2aXR5UmFpZFBsYWNpbmdHYW1lQ3NS",
			"ZXESJgoLSkxESEFLUE1KTk0YCiABKAsyES5BbGxleVBsYWNpbmdTaGlwEhMK",
			"C0JGQkNCQ0FER09KGAIgASgNEhMKC01ISkJGTEJNR01IGA4gASgNQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			AlleyPlacingShipReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ActivityRaidPlacingGameCsReq), ActivityRaidPlacingGameCsReq.Parser, new string[]
			{
				"JLDHAKPMJNM",
				"BFBCBCADGOJ",
				"MHJBFLBMGMH"
			}, null, null, null, null)
		}));
	}
}
