using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200089C RID: 2204
	public static class HeartDialDialogueInfoReflection
	{
		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06006267 RID: 25191 RVA: 0x0010755D File Offset: 0x0010575D
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeartDialDialogueInfoReflection.descriptor;
			}
		}

		// Token: 0x040025D0 RID: 9680
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtIZWFydERpYWxEaWFsb2d1ZUluZm8ucHJvdG8iQQoVSGVhcnREaWFsRGlh" + "bG9ndWVJbmZvEhMKC2RpYWxvZ3VlX2lkGAggASgNEhMKC0hPS09HR0hETk1C" + "GAsgASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeartDialDialogueInfo), HeartDialDialogueInfo.Parser, new string[]
			{
				"DialogueId",
				"HOKOGGHDNMB"
			}, null, null, null, null)
		}));
	}
}
