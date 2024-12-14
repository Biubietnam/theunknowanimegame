using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E8C RID: 3724
	public static class RogueGambleMazeGroupInfoReflection
	{
		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x0600A65B RID: 42587 RVA: 0x001BFE1C File Offset: 0x001BE01C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueGambleMazeGroupInfoReflection.descriptor;
			}
		}

		// Token: 0x0400440D RID: 17421
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5Sb2d1ZUdhbWJsZU1hemVHcm91cEluZm8ucHJvdG8aGVJvZ3VlR2FtYmxl",
			"TWF6ZUluZm8ucHJvdG8iawoYUm9ndWVHYW1ibGVNYXplR3JvdXBJbmZvEhAK",
			"CGdyb3VwX2lkGAEgASgNEhQKDGdyb3VwX2VuYWJsZRgNIAEoCBInCgltYXpl",
			"X2xpc3QYCiADKAsyFC5Sb2d1ZUdhbWJsZU1hemVJbmZvQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueGambleMazeInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueGambleMazeGroupInfo), RogueGambleMazeGroupInfo.Parser, new string[]
			{
				"GroupId",
				"GroupEnable",
				"MazeList"
			}, null, null, null, null)
		}));
	}
}
