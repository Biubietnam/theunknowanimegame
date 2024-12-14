using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E54 RID: 3668
	public static class RogueCommonGetScepterReflection
	{
		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0600A3AA RID: 41898 RVA: 0x001B8399 File Offset: 0x001B6599
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonGetScepterReflection.descriptor;
			}
		}

		// Token: 0x040042FD RID: 17149
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtSb2d1ZUNvbW1vbkdldFNjZXB0ZXIucHJvdG8aH1JvZ3VlTWFnaWNHYW1l",
			"U2NlcHRlckluZm8ucHJvdG8iUAoVUm9ndWVDb21tb25HZXRTY2VwdGVyEjcK",
			"E3VwZGF0ZV9zY2VwdGVyX2luZm8YCCABKAsyGi5Sb2d1ZU1hZ2ljR2FtZVNj",
			"ZXB0ZXJJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicGameScepterInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonGetScepter), RogueCommonGetScepter.Parser, new string[]
			{
				"UpdateScepterInfo"
			}, null, null, null, null)
		}));
	}
}
